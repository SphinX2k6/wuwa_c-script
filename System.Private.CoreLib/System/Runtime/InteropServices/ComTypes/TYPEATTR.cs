using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000642 RID: 1602
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEATTR
	{
		// Token: 0x040013DD RID: 5085
		public const int MEMBER_ID_NIL = -1;

		// Token: 0x040013DE RID: 5086
		public Guid guid;

		// Token: 0x040013DF RID: 5087
		public int lcid;

		// Token: 0x040013E0 RID: 5088
		public int dwReserved;

		// Token: 0x040013E1 RID: 5089
		public int memidConstructor;

		// Token: 0x040013E2 RID: 5090
		public int memidDestructor;

		// Token: 0x040013E3 RID: 5091
		public IntPtr lpstrSchema;

		// Token: 0x040013E4 RID: 5092
		public int cbSizeInstance;

		// Token: 0x040013E5 RID: 5093
		public TYPEKIND typekind;

		// Token: 0x040013E6 RID: 5094
		public short cFuncs;

		// Token: 0x040013E7 RID: 5095
		public short cVars;

		// Token: 0x040013E8 RID: 5096
		public short cImplTypes;

		// Token: 0x040013E9 RID: 5097
		public short cbSizeVft;

		// Token: 0x040013EA RID: 5098
		public short cbAlignment;

		// Token: 0x040013EB RID: 5099
		public TYPEFLAGS wTypeFlags;

		// Token: 0x040013EC RID: 5100
		public short wMajorVerNum;

		// Token: 0x040013ED RID: 5101
		public short wMinorVerNum;

		// Token: 0x040013EE RID: 5102
		public TYPEDESC tdescAlias;

		// Token: 0x040013EF RID: 5103
		public IDLDESC idldescType;
	}
}
