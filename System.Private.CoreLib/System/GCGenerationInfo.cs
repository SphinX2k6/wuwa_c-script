using System;

namespace System
{
	// Token: 0x0200011F RID: 287
	public readonly struct GCGenerationInfo
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00030C06 File Offset: 0x0002EE06
		public long SizeBeforeBytes { get; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00030C0E File Offset: 0x0002EE0E
		public long FragmentationBeforeBytes { get; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00030C16 File Offset: 0x0002EE16
		public long SizeAfterBytes { get; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00030C1E File Offset: 0x0002EE1E
		public long FragmentationAfterBytes { get; }
	}
}
