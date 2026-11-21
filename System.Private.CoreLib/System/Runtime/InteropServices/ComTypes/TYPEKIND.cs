using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200063F RID: 1599
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum TYPEKIND
	{
		// Token: 0x040013BF RID: 5055
		TKIND_ENUM,
		// Token: 0x040013C0 RID: 5056
		TKIND_RECORD,
		// Token: 0x040013C1 RID: 5057
		TKIND_MODULE,
		// Token: 0x040013C2 RID: 5058
		TKIND_INTERFACE,
		// Token: 0x040013C3 RID: 5059
		TKIND_DISPATCH,
		// Token: 0x040013C4 RID: 5060
		TKIND_COCLASS,
		// Token: 0x040013C5 RID: 5061
		TKIND_ALIAS,
		// Token: 0x040013C6 RID: 5062
		TKIND_UNION,
		// Token: 0x040013C7 RID: 5063
		TKIND_MAX
	}
}
