using System;
using System.ComponentModel;

namespace System.Runtime.InteropServices.ComTypes
{
	// Token: 0x02000648 RID: 1608
	[EditorBrowsable(EditorBrowsableState.Never)]
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct TYPEDESC
	{
		// Token: 0x0400140F RID: 5135
		public IntPtr lpValue;

		// Token: 0x04001410 RID: 5136
		public short vt;
	}
}
