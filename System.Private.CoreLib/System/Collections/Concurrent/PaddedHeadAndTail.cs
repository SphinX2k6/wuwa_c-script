using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.Collections.Concurrent
{
	// Token: 0x02000991 RID: 2449
	[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	[StructLayout(LayoutKind.Explicit, Size = 192)]
	internal struct PaddedHeadAndTail
	{
		// Token: 0x04002242 RID: 8770
		[FieldOffset(64)]
		public int Head;

		// Token: 0x04002243 RID: 8771
		[FieldOffset(128)]
		public int Tail;
	}
}
