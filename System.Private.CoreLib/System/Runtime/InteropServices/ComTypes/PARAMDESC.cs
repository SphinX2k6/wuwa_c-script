using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000647 RID: 1607
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct PARAMDESC
	{
		// Token: 0x0400140D RID: 5133
		public IntPtr lpVarValue;

		// Token: 0x0400140E RID: 5134
		public PARAMFLAG wParamFlags;
	}
}
