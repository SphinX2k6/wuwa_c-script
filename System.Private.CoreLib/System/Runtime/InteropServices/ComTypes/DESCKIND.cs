using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200063C RID: 1596
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum DESCKIND
	{
		// Token: 0x040013B5 RID: 5045
		DESCKIND_NONE,
		// Token: 0x040013B6 RID: 5046
		DESCKIND_FUNCDESC,
		// Token: 0x040013B7 RID: 5047
		DESCKIND_VARDESC,
		// Token: 0x040013B8 RID: 5048
		DESCKIND_TYPECOMP,
		// Token: 0x040013B9 RID: 5049
		DESCKIND_IMPLICITAPPOBJ,
		// Token: 0x040013BA RID: 5050
		DESCKIND_MAX
	}
}
