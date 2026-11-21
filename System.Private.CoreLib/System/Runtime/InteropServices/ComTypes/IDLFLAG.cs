using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000644 RID: 1604
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	public enum IDLFLAG : short
	{
		// Token: 0x040013FD RID: 5117
		IDLFLAG_NONE = 0,
		// Token: 0x040013FE RID: 5118
		IDLFLAG_FIN = 1,
		// Token: 0x040013FF RID: 5119
		IDLFLAG_FOUT = 2,
		// Token: 0x04001400 RID: 5120
		IDLFLAG_FLCID = 4,
		// Token: 0x04001401 RID: 5121
		IDLFLAG_FRETVAL = 8
	}
}
