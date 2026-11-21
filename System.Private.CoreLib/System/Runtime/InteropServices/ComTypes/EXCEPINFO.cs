using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200064F RID: 1615
	[NullableContext(1)]
	[Nullable(0)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct EXCEPINFO
	{
		// Token: 0x04001426 RID: 5158
		public short wCode;

		// Token: 0x04001427 RID: 5159
		public short wReserved;

		// Token: 0x04001428 RID: 5160
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrSource;

		// Token: 0x04001429 RID: 5161
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrDescription;

		// Token: 0x0400142A RID: 5162
		[MarshalAs(UnmanagedType.BStr)]
		public string bstrHelpFile;

		// Token: 0x0400142B RID: 5163
		public int dwHelpContext;

		// Token: 0x0400142C RID: 5164
		public IntPtr pvReserved;

		// Token: 0x0400142D RID: 5165
		public IntPtr pfnDeferredFillIn;

		// Token: 0x0400142E RID: 5166
		public int scode;
	}
}
