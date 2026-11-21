using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200063D RID: 1597
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
	public struct BINDPTR
	{
		// Token: 0x040013BB RID: 5051
		[FieldOffset(0)]
		public IntPtr lpfuncdesc;

		// Token: 0x040013BC RID: 5052
		[FieldOffset(0)]
		public IntPtr lpvardesc;

		// Token: 0x040013BD RID: 5053
		[FieldOffset(0)]
		public IntPtr lptcomp;
	}
}
