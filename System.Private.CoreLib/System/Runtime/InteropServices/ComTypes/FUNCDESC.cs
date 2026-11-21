using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000643 RID: 1603
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct FUNCDESC
	{
		// Token: 0x040013F0 RID: 5104
		public int memid;

		// Token: 0x040013F1 RID: 5105
		public IntPtr lprgscode;

		// Token: 0x040013F2 RID: 5106
		public IntPtr lprgelemdescParam;

		// Token: 0x040013F3 RID: 5107
		public FUNCKIND funckind;

		// Token: 0x040013F4 RID: 5108
		public INVOKEKIND invkind;

		// Token: 0x040013F5 RID: 5109
		public CALLCONV callconv;

		// Token: 0x040013F6 RID: 5110
		public short cParams;

		// Token: 0x040013F7 RID: 5111
		public short cParamsOpt;

		// Token: 0x040013F8 RID: 5112
		public short oVft;

		// Token: 0x040013F9 RID: 5113
		public short cScodes;

		// Token: 0x040013FA RID: 5114
		public ELEMDESC elemdescFunc;

		// Token: 0x040013FB RID: 5115
		public short wFuncFlags;
	}
}
