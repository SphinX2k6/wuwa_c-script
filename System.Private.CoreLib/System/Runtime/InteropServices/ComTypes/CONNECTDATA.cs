using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000631 RID: 1585
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct CONNECTDATA
	{
		// Token: 0x040013A5 RID: 5029
		[Nullable(1)]
		[MarshalAs(UnmanagedType.Interface)]
		public object pUnk;

		// Token: 0x040013A6 RID: 5030
		public int dwCookie;
	}
}
