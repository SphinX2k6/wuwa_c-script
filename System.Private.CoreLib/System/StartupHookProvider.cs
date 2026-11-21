using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace System
{
	// Token: 0x020001B4 RID: 436
	internal static class StartupHookProvider
	{
		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x00065DD4 File Offset: 0x00063FD4
		private static bool IsSupported
		{
			get
			{
				bool flag;
				return !AppContext.TryGetSwitch("System.StartupHookProvider.IsSupported", out flag) || flag;
			}
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x00065DF4 File Offset: 0x00063FF4
		private static void ProcessStartupHooks(string diagnosticStartupHooks)
		{
			if (!StartupHookProvider.IsSupported)
			{
				return;
			}
			string text = AppContext.GetData("STARTUP_HOOKS") as string;
			if (text == null && string.IsNullOrEmpty(diagnosticStartupHooks))
			{
				return;
			}
			List<string> list = new List<string>();
			if (!string.IsNullOrEmpty(diagnosticStartupHooks))
			{
				list.AddRange(diagnosticStartupHooks.Split(Path.PathSeparator, StringSplitOptions.None));
			}
			if (text != null)
			{
				list.AddRange(text.Split(Path.PathSeparator, StringSplitOptions.None));
			}
			StartupHookProvider.StartupHookNameOrPath[] array = new StartupHookProvider.StartupHookNameOrPath[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				StartupHookProvider.ParseStartupHook(ref array[i], list[i]);
			}
			for (int j = 0; j < array.Length; j++)
			{
				StartupHookProvider.CallStartupHook(array[j]);
			}
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00065EAC File Offset: 0x000640AC
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "An ILLink warning when trimming an app with System.StartupHookProvider.IsSupported=true already exists for ProcessStartupHooks.")]
		private unsafe static void CallStartupHook(char* pStartupHookPart)
		{
			if (!StartupHookProvider.IsSupported)
			{
				return;
			}
			StartupHookProvider.StartupHookNameOrPath startupHook = default(StartupHookProvider.StartupHookNameOrPath);
			StartupHookProvider.ParseStartupHook(ref startupHook, new string(pStartupHookPart));
			StartupHookProvider.CallStartupHook(startupHook);
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00065EDC File Offset: 0x000640DC
		private unsafe static void ParseStartupHook(ref StartupHookProvider.StartupHookNameOrPath startupHook, string startupHookPart)
		{
			<>y__InlineArray4<char> <>y__InlineArray = default(<>y__InlineArray4<char>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 0) = Path.DirectorySeparatorChar;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 1) = Path.AltDirectorySeparatorChar;
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 2) = ' ';
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<char>, char>(ref <>y__InlineArray, 3) = ',';
			ReadOnlySpan<char> readOnlySpan = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<char>, char>(<>y__InlineArray, 4);
			if (string.IsNullOrEmpty(startupHookPart))
			{
				return;
			}
			if (Path.IsPathFullyQualified(startupHookPart))
			{
				startupHook.Path = startupHookPart;
				return;
			}
			for (int i = 0; i < readOnlySpan.Length; i++)
			{
				if (startupHookPart.Contains((char)(*readOnlySpan[i])))
				{
					throw new ArgumentException(SR.Format(SR.Argument_InvalidStartupHookSimpleAssemblyName, startupHookPart));
				}
			}
			if (startupHookPart.EndsWith(".dll", StringComparison.OrdinalIgnoreCase))
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidStartupHookSimpleAssemblyName, startupHookPart));
			}
			try
			{
				startupHook.AssemblyName = new AssemblyName(startupHookPart);
			}
			catch (Exception innerException)
			{
				throw new ArgumentException(SR.Format(SR.Argument_InvalidStartupHookSimpleAssemblyName, startupHookPart), innerException);
			}
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00065FCC File Offset: 0x000641CC
		[RequiresUnreferencedCode("The StartupHookSupport feature switch has been enabled for this app which is being trimmed. Startup hook code is not observable by the trimmer and so required assemblies, types and members may be removed")]
		private static void CallStartupHook(StartupHookProvider.StartupHookNameOrPath startupHook)
		{
			Assembly assembly;
			try
			{
				if (startupHook.Path != null)
				{
					assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(startupHook.Path);
				}
				else
				{
					if (startupHook.AssemblyName == null)
					{
						return;
					}
					assembly = AssemblyLoadContext.Default.LoadFromAssemblyName(startupHook.AssemblyName);
				}
			}
			catch (Exception innerException)
			{
				throw new ArgumentException(SR.Format(SR.Argument_StartupHookAssemblyLoadFailed, startupHook.Path ?? startupHook.AssemblyName.ToString()), innerException);
			}
			Type type = assembly.GetType("StartupHook", true);
			MethodInfo method = type.GetMethod("Initialize", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (method == null)
			{
				try
				{
					if (type.GetMethod("Initialize", BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic) == null)
					{
						throw new MissingMethodException("StartupHook", "Initialize");
					}
				}
				catch (AmbiguousMatchException)
				{
				}
			}
			if (method == null || method.ReturnType != typeof(void))
			{
				string argument_InvalidStartupHookSignature = SR.Argument_InvalidStartupHookSignature;
				ReadOnlySpan<char> str = "StartupHook";
				char delimiter = Type.Delimiter;
				throw new ArgumentException(SR.Format(argument_InvalidStartupHookSignature, str + new ReadOnlySpan<char>(ref delimiter) + "Initialize", startupHook.Path ?? startupHook.AssemblyName.ToString()));
			}
			method.Invoke(null, null);
		}

		// Token: 0x020001B5 RID: 437
		private struct StartupHookNameOrPath
		{
			// Token: 0x0400057E RID: 1406
			public AssemblyName AssemblyName;

			// Token: 0x0400057F RID: 1407
			public string Path;
		}
	}
}
