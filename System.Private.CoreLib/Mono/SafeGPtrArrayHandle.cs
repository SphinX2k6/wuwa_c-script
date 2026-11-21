using System;

namespace Mono
{
	// Token: 0x02000A06 RID: 2566
	internal struct SafeGPtrArrayHandle : IDisposable
	{
		// Token: 0x06009436 RID: 37942 RVA: 0x00171B09 File Offset: 0x0016FD09
		internal SafeGPtrArrayHandle(IntPtr ptr)
		{
			this.handle = new RuntimeGPtrArrayHandle(ptr);
		}

		// Token: 0x06009437 RID: 37943 RVA: 0x00171B17 File Offset: 0x0016FD17
		public void Dispose()
		{
			RuntimeGPtrArrayHandle.DestroyAndFree(ref this.handle);
		}

		// Token: 0x17001436 RID: 5174
		// (get) Token: 0x06009438 RID: 37944 RVA: 0x00171B24 File Offset: 0x0016FD24
		internal int Length
		{
			get
			{
				return this.handle.Length;
			}
		}

		// Token: 0x17001437 RID: 5175
		internal IntPtr this[int i]
		{
			get
			{
				return this.handle[i];
			}
		}

		// Token: 0x040022FB RID: 8955
		private RuntimeGPtrArrayHandle handle;
	}
}
