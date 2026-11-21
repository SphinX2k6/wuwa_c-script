using System;
using Microsoft.Win32.SafeHandles;

namespace System.IO.Strategies
{
	// Token: 0x02000862 RID: 2146
	internal abstract class FileStreamStrategy : Stream
	{
		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x0600881E RID: 34846
		internal abstract bool IsAsync { get; }

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600881F RID: 34847 RVA: 0x0014AF72 File Offset: 0x00149172
		// (set) Token: 0x06008820 RID: 34848 RVA: 0x0014AF7A File Offset: 0x0014917A
		internal bool IsDerived { get; set; }

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06008821 RID: 34849
		internal abstract string Name { get; }

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06008822 RID: 34850
		internal abstract SafeFileHandle SafeFileHandle { get; }

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06008823 RID: 34851 RVA: 0x0014AF83 File Offset: 0x00149183
		internal IntPtr Handle
		{
			get
			{
				return this.SafeFileHandle.DangerousGetHandle();
			}
		}

		// Token: 0x170011EF RID: 4591
		// (get) Token: 0x06008824 RID: 34852
		internal abstract bool IsClosed { get; }

		// Token: 0x06008825 RID: 34853
		internal abstract void Lock(long position, long length);

		// Token: 0x06008826 RID: 34854
		internal abstract void Unlock(long position, long length);

		// Token: 0x06008827 RID: 34855
		internal abstract void Flush(bool flushToDisk);

		// Token: 0x06008828 RID: 34856 RVA: 0x0014AF90 File Offset: 0x00149190
		internal void DisposeInternal(bool disposing)
		{
			this.Dispose(disposing);
		}
	}
}
