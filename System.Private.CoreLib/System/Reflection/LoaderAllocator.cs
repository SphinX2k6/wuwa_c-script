using System;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	// Token: 0x020006F3 RID: 1779
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class LoaderAllocator
	{
		// Token: 0x060075F5 RID: 30197 RVA: 0x00119260 File Offset: 0x00117460
		private LoaderAllocator(IntPtr native)
		{
			this.m_scout = new LoaderAllocatorScout(native);
		}

		// Token: 0x04001537 RID: 5431
		private LoaderAllocatorScout m_scout;

		// Token: 0x04001538 RID: 5432
		private object[] m_slots;

		// Token: 0x04001539 RID: 5433
		private object[] m_hashes;

		// Token: 0x0400153A RID: 5434
		private int m_nslots;
	}
}
