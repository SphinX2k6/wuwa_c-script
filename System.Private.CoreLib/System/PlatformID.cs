using System;
using System.ComponentModel;

namespace System
{
	// Token: 0x0200018F RID: 399
	public enum PlatformID
	{
		// Token: 0x0400053C RID: 1340
		[EditorBrowsable(EditorBrowsableState.Never)]
		Win32S,
		// Token: 0x0400053D RID: 1341
		[EditorBrowsable(EditorBrowsableState.Never)]
		Win32Windows,
		// Token: 0x0400053E RID: 1342
		Win32NT,
		// Token: 0x0400053F RID: 1343
		[EditorBrowsable(EditorBrowsableState.Never)]
		WinCE,
		// Token: 0x04000540 RID: 1344
		Unix,
		// Token: 0x04000541 RID: 1345
		[EditorBrowsable(EditorBrowsableState.Never)]
		Xbox,
		// Token: 0x04000542 RID: 1346
		[EditorBrowsable(EditorBrowsableState.Never)]
		MacOSX,
		// Token: 0x04000543 RID: 1347
		Other
	}
}
