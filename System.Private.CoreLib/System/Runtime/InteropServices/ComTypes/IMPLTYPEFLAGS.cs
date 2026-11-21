using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000641 RID: 1601
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	public enum IMPLTYPEFLAGS
	{
		// Token: 0x040013D9 RID: 5081
		IMPLTYPEFLAG_FDEFAULT = 1,
		// Token: 0x040013DA RID: 5082
		IMPLTYPEFLAG_FSOURCE = 2,
		// Token: 0x040013DB RID: 5083
		IMPLTYPEFLAG_FRESTRICTED = 4,
		// Token: 0x040013DC RID: 5084
		IMPLTYPEFLAG_FDEFAULTVTABLE = 8
	}
}
