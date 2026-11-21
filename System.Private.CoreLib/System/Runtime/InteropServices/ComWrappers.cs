using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005BE RID: 1470
	[NullableContext(1)]
	[Nullable(0)]
	[UnsupportedOSPlatform("android")]
	[UnsupportedOSPlatform("browser")]
	[UnsupportedOSPlatform("ios")]
	[UnsupportedOSPlatform("tvos")]
	[CLSCompliant(false)]
	public abstract class ComWrappers
	{
		// Token: 0x06006FEB RID: 28651
		[NullableContext(0)]
		protected unsafe abstract ComWrappers.ComInterfaceEntry* ComputeVtables([Nullable(1)] object obj, CreateComInterfaceFlags flags, out int count);

		// Token: 0x06006FEC RID: 28652
		[NullableContext(2)]
		protected abstract object CreateObject(IntPtr externalComObject, CreateObjectFlags flags);

		// Token: 0x06006FED RID: 28653
		protected abstract void ReleaseObjects(IEnumerable objects);

		// Token: 0x06006FEE RID: 28654 RVA: 0x0010D820 File Offset: 0x0010BA20
		public static bool TryGetComInstance(object obj, out IntPtr unknown)
		{
			unknown = (IntPtr)0;
			return false;
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x0010D827 File Offset: 0x0010BA27
		[NullableContext(2)]
		public static bool TryGetObject(IntPtr unknown, [NotNullWhen(true)] out object obj)
		{
			obj = null;
			return false;
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public IntPtr GetOrCreateComInterfaceForObject(object instance, CreateComInterfaceFlags flags)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public object GetOrCreateObjectForComInstance(IntPtr externalComObject, CreateObjectFlags flags)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public object GetOrRegisterObjectForComInstance(IntPtr externalComObject, CreateObjectFlags flags, object wrapper)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public object GetOrRegisterObjectForComInstance(IntPtr externalComObject, CreateObjectFlags flags, object wrapper, IntPtr inner)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF4 RID: 28660 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void RegisterForTrackerSupport(ComWrappers instance)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF5 RID: 28661 RVA: 0x0000ACEC File Offset: 0x00008EEC
		[SupportedOSPlatform("windows")]
		public static void RegisterForMarshalling(ComWrappers instance)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x06006FF6 RID: 28662 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public static void GetIUnknownImpl(out IntPtr fpQueryInterface, out IntPtr fpAddRef, out IntPtr fpRelease)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x020005BF RID: 1471
		[NullableContext(0)]
		public struct ComInterfaceEntry
		{
			// Token: 0x04001278 RID: 4728
			public Guid IID;

			// Token: 0x04001279 RID: 4729
			public IntPtr Vtable;
		}

		// Token: 0x020005C0 RID: 1472
		[NullableContext(0)]
		public struct ComInterfaceDispatch
		{
			// Token: 0x06006FF8 RID: 28664 RVA: 0x0000ACEC File Offset: 0x00008EEC
			[NullableContext(1)]
			public unsafe static T GetInstance<T>([Nullable(0)] ComWrappers.ComInterfaceDispatch* dispatchPtr) where T : class
			{
				throw new PlatformNotSupportedException();
			}

			// Token: 0x0400127A RID: 4730
			public IntPtr Vtable;
		}
	}
}
