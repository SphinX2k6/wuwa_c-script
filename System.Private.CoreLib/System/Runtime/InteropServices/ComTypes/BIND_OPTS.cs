using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200062C RID: 1580
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct BIND_OPTS
	{
		// Token: 0x040013A1 RID: 5025
		public int cbStruct;

		// Token: 0x040013A2 RID: 5026
		public int grfFlags;

		// Token: 0x040013A3 RID: 5027
		public int grfMode;

		// Token: 0x040013A4 RID: 5028
		public int dwTickCountDeadline;
	}
}
