using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000658 RID: 1624
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Flags]
	public enum LIBFLAGS : short
	{
		// Token: 0x04001467 RID: 5223
		LIBFLAG_FRESTRICTED = 1,
		// Token: 0x04001468 RID: 5224
		LIBFLAG_FCONTROL = 2,
		// Token: 0x04001469 RID: 5225
		LIBFLAG_FHIDDEN = 4,
		// Token: 0x0400146A RID: 5226
		LIBFLAG_FHASDISKIMAGE = 8
	}
}
