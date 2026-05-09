// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information. 

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using Microsoft.Xaml.Behaviors;

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: System.Runtime.InteropServices.ComVisible(false)]
[assembly: CLSCompliant(true)]

[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Behaviors.Input")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Behaviors.Layout")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "Microsoft.Xaml.Media.Effects")]

// TODO: JKuhne- the following seem to be quirks with the current build of VS
[module: SuppressMessage("Microsoft.MSInternal", "CA904:DeclareTypesInMicrosoftOrSystemNamespace",
    Scope = "namespace", Target = "XamlGeneratedNamespace")]
[module: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes",
    Scope = "namespace", Target = "XamlGeneratedNamespace")]

[assembly: SuppressMessage("Microsoft.Performance", "CA1824:MarkAssembliesWithNeutralResourcesLanguage")]
[assembly: System.Resources.NeutralResourcesLanguage("en", System.Resources.UltimateResourceFallbackLocation.MainAssembly)]

[assembly: XmlnsPrefix(@"http://schemas.devtools.ui/xaml/behaviors", "b")]
[assembly: XmlnsDefinition(@"http://schemas.devtools.ui/xaml/behaviors", "Microsoft.Xaml.Behaviors")]
[assembly: XmlnsDefinition(@"http://schemas.devtools.ui/xaml/behaviors", "Microsoft.Xaml.Behaviors.Core")]
[assembly: XmlnsDefinition(@"http://schemas.devtools.ui/xaml/behaviors", "Microsoft.Xaml.Behaviors.Input")]
[assembly: XmlnsDefinition(@"http://schemas.devtools.ui/xaml/behaviors", "Microsoft.Xaml.Behaviors.Layout")]
[assembly: XmlnsDefinition(@"http://schemas.devtools.ui/xaml/behaviors", "Microsoft.Xaml.Behaviors.Media")]

[assembly: SuppressMessage("Microsoft.Design", "CA1020:AvoidNamespacesWithFewTypes", Scope = "namespace", Target = "Microsoft.Xaml.Behaviors")]

[assembly: InternalsVisibleTo("UnitTests, PublicKey=0024000004800000940000000602000000240000525341310004000001000100ed9de419bf0bb128351aba05c8345522c35d513fd39014e01832cf6c2a81cffea7895be5429668ed682c5d64553c6c9be89c22eb8084b46395a3407725e7b31adcfbcbb995c73f6e77849e4246326594c8ddb904995ddb2525089d50164703baa130f4c568203c7a2408bb7fdb9a4938aa3aa17db1180015e7babefe687e5dcb")]
