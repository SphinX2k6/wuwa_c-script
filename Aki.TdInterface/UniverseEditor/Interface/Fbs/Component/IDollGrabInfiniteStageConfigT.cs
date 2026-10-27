using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200509D RID: 20637
	public class IDollGrabInfiniteStageConfigT
	{
		// Token: 0x170095EA RID: 38378
		// (get) Token: 0x06021235 RID: 135733 RVA: 0x0049ACAF File Offset: 0x00498EAF
		// (set) Token: 0x06021236 RID: 135734 RVA: 0x0049ACB7 File Offset: 0x00498EB7
		public float Duration { get; set; }

		// Token: 0x170095EB RID: 38379
		// (get) Token: 0x06021237 RID: 135735 RVA: 0x0049ACC0 File Offset: 0x00498EC0
		// (set) Token: 0x06021238 RID: 135736 RVA: 0x0049ACC8 File Offset: 0x00498EC8
		public IDollGrabStageAudioStateT AudioState { get; set; }

		// Token: 0x06021239 RID: 135737 RVA: 0x0049ACD1 File Offset: 0x00498ED1
		public IDollGrabInfiniteStageConfigT()
		{
			this.Duration = 0f;
			this.AudioState = null;
		}
	}
}
