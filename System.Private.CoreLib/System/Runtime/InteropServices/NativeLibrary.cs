using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005A6 RID: 1446
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeLibrary
	{
		// Token: 0x06006F97 RID: 28567 RVA: 0x0010CF0A File Offset: 0x0010B10A
		private static IntPtr LoadLibraryByName(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, bool throwOnError)
		{
			return NativeLibrary.LoadByName(libraryName, (RuntimeAssembly)assembly, searchPath != null, (uint)searchPath.GetValueOrDefault(), throwOnError);
		}

		// Token: 0x06006F98 RID: 28568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr LoadFromPath(string libraryName, bool throwOnError);

		// Token: 0x06006F99 RID: 28569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr LoadByName(string libraryName, RuntimeAssembly callingAssembly, bool hasDllImportSearchPathFlag, uint dllImportSearchPathFlag, bool throwOnError);

		// Token: 0x06006F9A RID: 28570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void FreeLib(IntPtr handle);

		// Token: 0x06006F9B RID: 28571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetSymbol(IntPtr handle, string symbolName, bool throwOnError);

		// Token: 0x06006F9C RID: 28572 RVA: 0x0010CF27 File Offset: 0x0010B127
		private static void MonoLoadLibraryCallbackStub(string libraryName, Assembly assembly, bool hasDllImportSearchPathFlags, uint dllImportSearchPathFlags, ref IntPtr dll)
		{
			dll = NativeLibrary.LoadLibraryCallbackStub(libraryName, assembly, hasDllImportSearchPathFlags, dllImportSearchPathFlags);
		}

		// Token: 0x06006F9D RID: 28573 RVA: 0x0010CF35 File Offset: 0x0010B135
		public static IntPtr Load(string libraryPath)
		{
			ArgumentNullException.ThrowIfNull(libraryPath, "libraryPath");
			return NativeLibrary.LoadFromPath(libraryPath, true);
		}

		// Token: 0x06006F9E RID: 28574 RVA: 0x0010CF49 File Offset: 0x0010B149
		public static bool TryLoad(string libraryPath, out IntPtr handle)
		{
			ArgumentNullException.ThrowIfNull(libraryPath, "libraryPath");
			handle = NativeLibrary.LoadFromPath(libraryPath, false);
			return handle != IntPtr.Zero;
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x0010CF6B File Offset: 0x0010B16B
		public static IntPtr Load(string libraryName, Assembly assembly, DllImportSearchPath? searchPath)
		{
			ArgumentNullException.ThrowIfNull(libraryName, "libraryName");
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			return NativeLibrary.LoadLibraryByName(libraryName, assembly, searchPath, true);
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x0010CFA0 File Offset: 0x0010B1A0
		public static bool TryLoad(string libraryName, Assembly assembly, DllImportSearchPath? searchPath, out IntPtr handle)
		{
			ArgumentNullException.ThrowIfNull(libraryName, "libraryName");
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			handle = NativeLibrary.LoadLibraryByName(libraryName, assembly, searchPath, false);
			return handle != IntPtr.Zero;
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x0010CFED File Offset: 0x0010B1ED
		public static void Free(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				return;
			}
			NativeLibrary.FreeLib(handle);
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x0010CFFE File Offset: 0x0010B1FE
		public static IntPtr GetExport(IntPtr handle, string name)
		{
			ArgumentNullException.ThrowIfNull(handle, "handle");
			ArgumentNullException.ThrowIfNull(name, "name");
			return NativeLibrary.GetSymbol(handle, name, true);
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x0010D01E File Offset: 0x0010B21E
		public static bool TryGetExport(IntPtr handle, string name, out IntPtr address)
		{
			ArgumentNullException.ThrowIfNull(handle, "handle");
			ArgumentNullException.ThrowIfNull(name, "name");
			address = NativeLibrary.GetSymbol(handle, name, false);
			return address != IntPtr.Zero;
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x0010D04C File Offset: 0x0010B24C
		public static void SetDllImportResolver(Assembly assembly, DllImportResolver resolver)
		{
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			ArgumentNullException.ThrowIfNull(resolver, "resolver");
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			if (NativeLibrary.s_nativeDllResolveMap == null)
			{
				Interlocked.CompareExchange<ConditionalWeakTable<Assembly, DllImportResolver>>(ref NativeLibrary.s_nativeDllResolveMap, new ConditionalWeakTable<Assembly, DllImportResolver>(), null);
			}
			if (!NativeLibrary.s_nativeDllResolveMap.TryAdd(assembly, resolver))
			{
				throw new InvalidOperationException(SR.InvalidOperation_CannotRegisterSecondResolver);
			}
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x0010D0B4 File Offset: 0x0010B2B4
		internal static IntPtr LoadLibraryCallbackStub(string libraryName, Assembly assembly, bool hasDllImportSearchPathFlags, uint dllImportSearchPathFlags)
		{
			if (NativeLibrary.s_nativeDllResolveMap == null)
			{
				return IntPtr.Zero;
			}
			DllImportResolver dllImportResolver;
			if (!NativeLibrary.s_nativeDllResolveMap.TryGetValue(assembly, out dllImportResolver))
			{
				return IntPtr.Zero;
			}
			return dllImportResolver(libraryName, assembly, hasDllImportSearchPathFlags ? new DllImportSearchPath?((DllImportSearchPath)dllImportSearchPathFlags) : null);
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x0010D0FF File Offset: 0x0010B2FF
		public static IntPtr GetMainProgramHandle()
		{
			IntPtr zero = IntPtr.Zero;
			IntPtr moduleHandle = Interop.Kernel32.GetModuleHandle(null);
			if (moduleHandle == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastPInvokeError());
			}
			return moduleHandle;
		}

		// Token: 0x04001238 RID: 4664
		private static ConditionalWeakTable<Assembly, DllImportResolver> s_nativeDllResolveMap;
	}
}
