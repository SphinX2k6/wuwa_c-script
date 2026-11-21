using System;
using System.Runtime.CompilerServices;

namespace System.Reflection
{
	// Token: 0x020006F2 RID: 1778
	internal sealed class LoaderAllocatorScout
	{
		// Token: 0x060075F2 RID: 30194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Destroy(IntPtr native);

		// Token: 0x060075F3 RID: 30195 RVA: 0x00119214 File Offset: 0x00117414
		internal LoaderAllocatorScout(IntPtr native)
		{
			this.m_native = native;
		}

		// Token: 0x060075F4 RID: 30196 RVA: 0x00119224 File Offset: 0x00117424
		~LoaderAllocatorScout()
		{
			if (!LoaderAllocatorScout.Destroy(this.m_native))
			{
				GC.ReRegisterForFinalize(this);
			}
		}

		// Token: 0x04001536 RID: 5430
		internal IntPtr m_native;
	}
}
