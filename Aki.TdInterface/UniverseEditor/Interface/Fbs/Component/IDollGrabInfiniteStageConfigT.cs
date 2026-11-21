using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005602 RID: 22018
	public class IDollGrabInfiniteStageConfigT
	{
		// Token: 0x17009DD7 RID: 40407
		// (get) Token: 0x06023189 RID: 143753 RVA: 0x004D4C3B File Offset: 0x004D2E3B
		// (set) Token: 0x0602318A RID: 143754 RVA: 0x004D4C43 File Offset: 0x004D2E43
		public float Duration { get; set; }

		// Token: 0x17009DD8 RID: 40408
		// (get) Token: 0x0602318B RID: 143755 RVA: 0x004D4C4C File Offset: 0x004D2E4C
		// (set) Token: 0x0602318C RID: 143756 RVA: 0x004D4C54 File Offset: 0x004D2E54
		public IDollGrabStageAudioStateT AudioState { get; set; }

		// Token: 0x0602318D RID: 143757 RVA: 0x004D4C5D File Offset: 0x004D2E5D
		public IDollGrabInfiniteStageConfigT()
		{
			this.Duration = 0f;
			this.AudioState = null;
		}
	}
}
