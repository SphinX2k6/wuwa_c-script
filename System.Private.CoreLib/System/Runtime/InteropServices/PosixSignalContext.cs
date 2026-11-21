using System;

namespace System.Runtime.InteropServices
{
	// Token: 0x020005E8 RID: 1512
	public sealed class PosixSignalContext
	{
		// Token: 0x06007158 RID: 29016 RVA: 0x0010FC6E File Offset: 0x0010DE6E
		public PosixSignalContext(PosixSignal signal)
		{
			this.Signal = signal;
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06007159 RID: 29017 RVA: 0x0010FC7D File Offset: 0x0010DE7D
		// (set) Token: 0x0600715A RID: 29018 RVA: 0x0010FC85 File Offset: 0x0010DE85
		public PosixSignal Signal { get; internal set; }

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600715B RID: 29019 RVA: 0x0010FC8E File Offset: 0x0010DE8E
		// (set) Token: 0x0600715C RID: 29020 RVA: 0x0010FC96 File Offset: 0x0010DE96
		public bool Cancel { get; set; }
	}
}
