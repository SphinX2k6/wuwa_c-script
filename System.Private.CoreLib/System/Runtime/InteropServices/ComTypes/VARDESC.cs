using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200064C RID: 1612
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct VARDESC
	{
		// Token: 0x0400141A RID: 5146
		public int memid;

		// Token: 0x0400141B RID: 5147
		[Nullable(1)]
		public string lpstrSchema;

		// Token: 0x0400141C RID: 5148
		public VARDESC.DESCUNION desc;

		// Token: 0x0400141D RID: 5149
		public ELEMDESC elemdescVar;

		// Token: 0x0400141E RID: 5150
		public short wVarFlags;

		// Token: 0x0400141F RID: 5151
		public VARKIND varkind;

		// Token: 0x0200064D RID: 1613
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DESCUNION
		{
			// Token: 0x04001420 RID: 5152
			[FieldOffset(0)]
			public int oInst;

			// Token: 0x04001421 RID: 5153
			[FieldOffset(0)]
			public IntPtr lpvarValue;
		}
	}
}
