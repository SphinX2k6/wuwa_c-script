using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200063A RID: 1594
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct STATSTG
	{
		// Token: 0x040013A9 RID: 5033
		[Nullable(1)]
		public string pwcsName;

		// Token: 0x040013AA RID: 5034
		public int type;

		// Token: 0x040013AB RID: 5035
		public long cbSize;

		// Token: 0x040013AC RID: 5036
		public FILETIME mtime;

		// Token: 0x040013AD RID: 5037
		public FILETIME ctime;

		// Token: 0x040013AE RID: 5038
		public FILETIME atime;

		// Token: 0x040013AF RID: 5039
		public int grfMode;

		// Token: 0x040013B0 RID: 5040
		public int grfLocksSupported;

		// Token: 0x040013B1 RID: 5041
		public Guid clsid;

		// Token: 0x040013B2 RID: 5042
		public int grfStateBits;

		// Token: 0x040013B3 RID: 5043
		public int reserved;
	}
}
