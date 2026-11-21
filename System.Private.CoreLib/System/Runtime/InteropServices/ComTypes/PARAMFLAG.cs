using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000646 RID: 1606
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	public enum PARAMFLAG : short
	{
		// Token: 0x04001405 RID: 5125
		PARAMFLAG_NONE = 0,
		// Token: 0x04001406 RID: 5126
		PARAMFLAG_FIN = 1,
		// Token: 0x04001407 RID: 5127
		PARAMFLAG_FOUT = 2,
		// Token: 0x04001408 RID: 5128
		PARAMFLAG_FLCID = 4,
		// Token: 0x04001409 RID: 5129
		PARAMFLAG_FRETVAL = 8,
		// Token: 0x0400140A RID: 5130
		PARAMFLAG_FOPT = 16,
		// Token: 0x0400140B RID: 5131
		PARAMFLAG_FHASDEFAULT = 32,
		// Token: 0x0400140C RID: 5132
		PARAMFLAG_FHASCUSTDATA = 64
	}
}
