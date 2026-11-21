using System;
using System.Runtime.InteropServices;

namespace Internal
{
	// Token: 0x02000068 RID: 104
	[StructLayout(LayoutKind.Explicit, Size = 64)]
	internal struct PaddedReference
	{
		// Token: 0x040001D6 RID: 470
		[FieldOffset(0)]
		public object Object;
	}
}
