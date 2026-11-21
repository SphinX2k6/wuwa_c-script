using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000659 RID: 1625
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPELIBATTR
	{
		// Token: 0x0400146B RID: 5227
		public Guid guid;

		// Token: 0x0400146C RID: 5228
		public int lcid;

		// Token: 0x0400146D RID: 5229
		public SYSKIND syskind;

		// Token: 0x0400146E RID: 5230
		public short wMajorVerNum;

		// Token: 0x0400146F RID: 5231
		public short wMinorVerNum;

		// Token: 0x04001470 RID: 5232
		public LIBFLAGS wLibFlags;
	}
}
