using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000633 RID: 1587
	[NullableContext(1)]
	[Guid("00000102-0000-0000-C000-000000000046")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[ComImport]
	public interface IEnumMoniker
	{
		// Token: 0x06007260 RID: 29280
		[PreserveSig]
		int Next(int celt, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] [Out] IMoniker[] rgelt, IntPtr pceltFetched);

		// Token: 0x06007261 RID: 29281
		[PreserveSig]
		int Skip(int celt);

		// Token: 0x06007262 RID: 29282
		void Reset();

		// Token: 0x06007263 RID: 29283
		void Clone(out IEnumMoniker ppenum);
	}
}
