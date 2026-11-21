using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x0200064E RID: 1614
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct DISPPARAMS
	{
		// Token: 0x04001422 RID: 5154
		public IntPtr rgvarg;

		// Token: 0x04001423 RID: 5155
		public IntPtr rgdispidNamedArgs;

		// Token: 0x04001424 RID: 5156
		public int cArgs;

		// Token: 0x04001425 RID: 5157
		public int cNamedArgs;
	}
}
