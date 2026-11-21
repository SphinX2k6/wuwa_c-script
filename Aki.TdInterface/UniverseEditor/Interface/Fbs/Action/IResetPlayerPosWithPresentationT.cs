using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007622 RID: 30242
	public class IResetPlayerPosWithPresentationT
	{
		// Token: 0x1700DE30 RID: 56880
		// (get) Token: 0x06035111 RID: 217361 RVA: 0x00720C0F File Offset: 0x0071EE0F
		// (set) Token: 0x06035112 RID: 217362 RVA: 0x00720C17 File Offset: 0x0071EE17
		public IResetPresentationFailureT Presentation { get; set; }

		// Token: 0x1700DE31 RID: 56881
		// (get) Token: 0x06035113 RID: 217363 RVA: 0x00720C20 File Offset: 0x0071EE20
		// (set) Token: 0x06035114 RID: 217364 RVA: 0x00720C28 File Offset: 0x0071EE28
		public TResetPosTypeUnion ResetPosConfig { get; set; }

		// Token: 0x1700DE32 RID: 56882
		// (get) Token: 0x06035115 RID: 217365 RVA: 0x00720C31 File Offset: 0x0071EE31
		// (set) Token: 0x06035116 RID: 217366 RVA: 0x00720C39 File Offset: 0x0071EE39
		public bool NeedWaitResetPos { get; set; }

		// Token: 0x1700DE33 RID: 56883
		// (get) Token: 0x06035117 RID: 217367 RVA: 0x00720C42 File Offset: 0x0071EE42
		// (set) Token: 0x06035118 RID: 217368 RVA: 0x00720C4A File Offset: 0x0071EE4A
		public byte NullMask { get; set; }

		// Token: 0x06035119 RID: 217369 RVA: 0x00720C53 File Offset: 0x0071EE53
		public IResetPlayerPosWithPresentationT()
		{
			this.Presentation = null;
			this.ResetPosConfig = null;
			this.NeedWaitResetPos = false;
			this.NullMask = 0;
		}
	}
}
