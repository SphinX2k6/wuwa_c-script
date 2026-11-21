using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000645 RID: 1605
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct IDLDESC
	{
		// Token: 0x04001402 RID: 5122
		public IntPtr dwReserved;

		// Token: 0x04001403 RID: 5123
		public IDLFLAG wIDLFlags;
	}
}
