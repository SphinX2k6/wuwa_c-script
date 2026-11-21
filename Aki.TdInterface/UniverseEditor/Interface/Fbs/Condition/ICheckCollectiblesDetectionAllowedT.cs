using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E61 RID: 20065
	public class ICheckCollectiblesDetectionAllowedT
	{
		// Token: 0x17008F12 RID: 36626
		// (get) Token: 0x0601F115 RID: 127253 RVA: 0x0045613A File Offset: 0x0045433A
		// (set) Token: 0x0601F116 RID: 127254 RVA: 0x00456142 File Offset: 0x00454342
		public ECondition Type { get; set; }

		// Token: 0x17008F13 RID: 36627
		// (get) Token: 0x0601F117 RID: 127255 RVA: 0x0045614B File Offset: 0x0045434B
		// (set) Token: 0x0601F118 RID: 127256 RVA: 0x00456153 File Offset: 0x00454353
		public int CollectiblesDetectionId { get; set; }

		// Token: 0x17008F14 RID: 36628
		// (get) Token: 0x0601F119 RID: 127257 RVA: 0x0045615C File Offset: 0x0045435C
		// (set) Token: 0x0601F11A RID: 127258 RVA: 0x00456164 File Offset: 0x00454364
		public bool IsDetectable { get; set; }

		// Token: 0x0601F11B RID: 127259 RVA: 0x0045616D File Offset: 0x0045436D
		public ICheckCollectiblesDetectionAllowedT()
		{
			this.Type = ECondition.CompareVar;
			this.CollectiblesDetectionId = 0;
			this.IsDetectable = false;
		}
	}
}
