using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000649 RID: 1609
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct ELEMDESC
	{
		// Token: 0x04001411 RID: 5137
		public TYPEDESC tdesc;

		// Token: 0x04001412 RID: 5138
		public ELEMDESC.DESCUNION desc;

		// Token: 0x0200064A RID: 1610
		[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
		public struct DESCUNION
		{
			// Token: 0x04001413 RID: 5139
			[FieldOffset(0)]
			public IDLDESC idldesc;

			// Token: 0x04001414 RID: 5140
			[FieldOffset(0)]
			public PARAMDESC paramdesc;
		}
	}
}
