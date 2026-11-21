using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Runtime.Versioning;
using System.Threading;

namespace Internal.Runtime.InteropServices
{
	// Token: 0x0200006C RID: 108
	internal static class ComponentActivator
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00006302 File Offset: 0x00004502
		private static bool IsSupported { get; } = ComponentActivator.InitializeIsSupported();

		// Token: 0x06000208 RID: 520 RVA: 0x0000630C File Offset: 0x0000450C
		private static bool InitializeIsSupported()
		{
			bool flag;
			return !AppContext.TryGetSwitch("System.Runtime.InteropServices.EnableConsumingManagedCodeFromNativeHosting", out flag) || flag;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000632A File Offset: 0x0000452A
		private static string MarshalToString(IntPtr arg, string argName)
		{
			string text = Marshal.PtrToStringAuto(arg);
			ArgumentNullException.ThrowIfNull(text, argName);
			return text;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000633C File Offset: 0x0000453C
		[RequiresDynamicCode("The native code for the method requested might not be available at runtime.")]
		[RequiresUnreferencedCode("Native hosting is not trim compatible and this warning will be seen if trimming is enabled.", Url = "https://aka.ms/dotnet-illink/nativehost")]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("maccatalyst")]
		[UnsupportedOSPlatform("tvos")]
		[UnmanagedCallersOnly]
		public unsafe static int LoadAssemblyAndGetFunctionPointer(IntPtr assemblyPathNative, IntPtr typeNameNative, IntPtr methodNameNative, IntPtr delegateTypeNative, IntPtr reserved, IntPtr functionHandle)
		{
			if (!ComponentActivator.IsSupported)
			{
				return -2147450713;
			}
			try
			{
				string assemblyPath = ComponentActivator.MarshalToString(assemblyPathNative, "assemblyPathNative");
				string typeName = ComponentActivator.MarshalToString(typeNameNative, "typeNameNative");
				string methodName = ComponentActivator.MarshalToString(methodNameNative, "methodNameNative");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(reserved, IntPtr.Zero, "reserved");
				ArgumentNullException.ThrowIfNull(functionHandle, "functionHandle");
				AssemblyLoadContext isolatedComponentLoadContext = ComponentActivator.GetIsolatedComponentLoadContext(assemblyPath);
				*functionHandle = ComponentActivator.InternalGetFunctionPointer(isolatedComponentLoadContext, typeName, methodName, delegateTypeNative);
			}
			catch (Exception ex)
			{
				return ex.HResult;
			}
			return 0;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x000063C8 File Offset: 0x000045C8
		[RequiresDynamicCode("The native code for the method requested might not be available at runtime.")]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("maccatalyst")]
		[UnsupportedOSPlatform("tvos")]
		[UnmanagedCallersOnly]
		public static int LoadAssembly(IntPtr assemblyPathNative, IntPtr loadContext, IntPtr reserved)
		{
			if (!ComponentActivator.IsSupported)
			{
				return -2147450713;
			}
			try
			{
				string assemblyPath = ComponentActivator.MarshalToString(assemblyPathNative, "assemblyPathNative");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(loadContext, IntPtr.Zero, "loadContext");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(reserved, IntPtr.Zero, "reserved");
				ComponentActivator.<LoadAssembly>g__LoadAssemblyLocal|13_0(assemblyPath);
			}
			catch (Exception ex)
			{
				return ex.HResult;
			}
			return 0;
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00006430 File Offset: 0x00004630
		[RequiresUnreferencedCode("Native hosting is not trim compatible and this warning will be seen if trimming is enabled.", Url = "https://aka.ms/dotnet-illink/nativehost")]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("maccatalyst")]
		[UnsupportedOSPlatform("tvos")]
		private static void LoadAssemblyImpl(string assemblyPath)
		{
			HashSet<string> obj = ComponentActivator.s_loadedInDefaultContext;
			bool flag = false;
			try
			{
				Monitor.Enter(obj, ref flag);
				if (!ComponentActivator.s_loadedInDefaultContext.Contains(assemblyPath))
				{
					AssemblyDependencyResolver resolver = new AssemblyDependencyResolver(assemblyPath);
					AssemblyLoadContext.Default.Resolving += delegate(AssemblyLoadContext context, AssemblyName assemblyName)
					{
						string text = resolver.ResolveAssemblyToPath(assemblyName);
						if (text == null)
						{
							return null;
						}
						return context.LoadFromAssemblyPath(text);
					};
					AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
					ComponentActivator.s_loadedInDefaultContext.Add(assemblyPath);
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(obj);
				}
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000064B8 File Offset: 0x000046B8
		[RequiresDynamicCode("The native code for the method requested might not be available at runtime.")]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("maccatalyst")]
		[UnsupportedOSPlatform("tvos")]
		[UnmanagedCallersOnly]
		public unsafe static int LoadAssemblyBytes(byte* assembly, IntPtr assemblyByteLength, byte* symbols, IntPtr symbolsByteLength, IntPtr loadContext, IntPtr reserved)
		{
			if (!ComponentActivator.IsSupported)
			{
				return -2147450713;
			}
			try
			{
				ArgumentNullException.ThrowIfNull((void*)assembly, "assembly");
				ArgumentOutOfRangeException.ThrowIfNegativeOrZero<IntPtr>(assemblyByteLength, "assemblyByteLength");
				ArgumentOutOfRangeException.ThrowIfGreaterThan<IntPtr>(assemblyByteLength, (IntPtr)int.MaxValue, "assemblyByteLength");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(loadContext, IntPtr.Zero, "loadContext");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(reserved, IntPtr.Zero, "reserved");
				ReadOnlySpan<byte> assemblyBytes = new ReadOnlySpan<byte>((void*)assembly, (int)assemblyByteLength);
				ReadOnlySpan<byte> symbolsBytes = default(ReadOnlySpan<byte>);
				if (symbols != null && symbolsByteLength > (IntPtr)0)
				{
					symbolsBytes = new ReadOnlySpan<byte>((void*)symbols, (int)symbolsByteLength);
				}
				ComponentActivator.<LoadAssemblyBytes>g__LoadAssemblyBytesLocal|15_0(assemblyBytes, symbolsBytes);
			}
			catch (Exception ex)
			{
				return ex.HResult;
			}
			return 0;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00006564 File Offset: 0x00004764
		[RequiresDynamicCode("The native code for the method requested might not be available at runtime.")]
		[UnmanagedCallersOnly]
		public unsafe static int GetFunctionPointer(IntPtr typeNameNative, IntPtr methodNameNative, IntPtr delegateTypeNative, IntPtr loadContext, IntPtr reserved, IntPtr functionHandle)
		{
			if (!ComponentActivator.IsSupported)
			{
				return -2147450713;
			}
			try
			{
				string typeName = ComponentActivator.MarshalToString(typeNameNative, "typeNameNative");
				string methodName = ComponentActivator.MarshalToString(methodNameNative, "methodNameNative");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(loadContext, IntPtr.Zero, "loadContext");
				ArgumentOutOfRangeException.ThrowIfNotEqual<IntPtr>(reserved, IntPtr.Zero, "reserved");
				ArgumentNullException.ThrowIfNull(functionHandle, "functionHandle");
				*functionHandle = ComponentActivator.InternalGetFunctionPointer(AssemblyLoadContext.Default, typeName, methodName, delegateTypeNative);
			}
			catch (Exception ex)
			{
				return ex.HResult;
			}
			return 0;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000065F4 File Offset: 0x000047F4
		[RequiresUnreferencedCode("Native hosting is not trim compatible and this warning will be seen if trimming is enabled.", Url = "https://aka.ms/dotnet-illink/nativehost")]
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("tvos")]
		private static IsolatedComponentLoadContext GetIsolatedComponentLoadContext(string assemblyPath)
		{
			Dictionary<string, IsolatedComponentLoadContext> obj = ComponentActivator.s_assemblyLoadContexts;
			IsolatedComponentLoadContext isolatedComponentLoadContext;
			lock (obj)
			{
				if (!ComponentActivator.s_assemblyLoadContexts.TryGetValue(assemblyPath, out isolatedComponentLoadContext))
				{
					isolatedComponentLoadContext = new IsolatedComponentLoadContext(assemblyPath);
					ComponentActivator.s_assemblyLoadContexts.Add(assemblyPath, isolatedComponentLoadContext);
				}
			}
			return isolatedComponentLoadContext;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00006650 File Offset: 0x00004850
		[RequiresDynamicCode("The native code for the method requested might not be available at runtime.")]
		[RequiresUnreferencedCode("Native hosting is not trim compatible and this warning will be seen if trimming is enabled.", Url = "https://aka.ms/dotnet-illink/nativehost")]
		private static IntPtr InternalGetFunctionPointer(AssemblyLoadContext alc, string typeName, string methodName, IntPtr delegateTypeNative)
		{
			Func<AssemblyName, Assembly> assemblyResolver = new Func<AssemblyName, Assembly>(alc.LoadFromAssemblyName);
			Type type;
			if (delegateTypeNative == IntPtr.Zero)
			{
				type = typeof(ComponentActivator.ComponentEntryPoint);
			}
			else if (delegateTypeNative == (IntPtr)(-1))
			{
				type = null;
			}
			else
			{
				type = Type.GetType(ComponentActivator.MarshalToString(delegateTypeNative, "delegateTypeNative"), assemblyResolver, null, true);
			}
			Type type2 = Type.GetType(typeName, assemblyResolver, null, true);
			IntPtr intPtr;
			if (type == null)
			{
				MethodInfo method = type2.GetMethod(methodName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
				if (method == null)
				{
					throw new MissingMethodException(typeName, methodName);
				}
				MethodInfo methodInfo = method;
				if (methodInfo.GetCustomAttribute<UnmanagedCallersOnlyAttribute>() == null)
				{
					throw new InvalidOperationException(SR.InvalidOperation_FunctionMissingUnmanagedCallersOnly);
				}
				intPtr = methodInfo.MethodHandle.GetFunctionPointer();
			}
			else
			{
				Delegate @delegate = Delegate.CreateDelegate(type, type2, methodName);
				intPtr = Marshal.GetFunctionPointerForDelegate(@delegate);
				Dictionary<IntPtr, Delegate> obj = ComponentActivator.s_delegates;
				lock (obj)
				{
					ComponentActivator.s_delegates[intPtr] = @delegate;
				}
			}
			return intPtr;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00006774 File Offset: 0x00004974
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The same feature switch applies to GetFunctionPointer and this function. We rely on the warning from GetFunctionPointer.")]
		internal static void <LoadAssembly>g__LoadAssemblyLocal|13_0(string assemblyPath)
		{
			ComponentActivator.LoadAssemblyImpl(assemblyPath);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000677C File Offset: 0x0000497C
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The same feature switch applies to GetFunctionPointer and this function. We rely on the warning from GetFunctionPointer.")]
		internal static void <LoadAssemblyBytes>g__LoadAssemblyBytesLocal|15_0(ReadOnlySpan<byte> assemblyBytes, ReadOnlySpan<byte> symbolsBytes)
		{
			AssemblyLoadContext.Default.InternalLoad(assemblyBytes, symbolsBytes);
		}

		// Token: 0x040001DA RID: 474
		[UnsupportedOSPlatform("android")]
		[UnsupportedOSPlatform("browser")]
		[UnsupportedOSPlatform("ios")]
		[UnsupportedOSPlatform("maccatalyst")]
		[UnsupportedOSPlatform("tvos")]
		private static readonly Dictionary<string, IsolatedComponentLoadContext> s_assemblyLoadContexts = new Dictionary<string, IsolatedComponentLoadContext>(StringComparer.InvariantCulture);

		// Token: 0x040001DB RID: 475
		private static readonly Dictionary<IntPtr, Delegate> s_delegates = new Dictionary<IntPtr, Delegate>();

		// Token: 0x040001DC RID: 476
		private static readonly HashSet<string> s_loadedInDefaultContext = new HashSet<string>(StringComparer.InvariantCulture);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000215 RID: 533
		public delegate int ComponentEntryPoint(IntPtr args, int sizeBytes);
	}
}
