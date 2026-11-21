using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007511 RID: 29969
	public class IPreloadLinkResourceT
	{
		// Token: 0x1700DC8C RID: 56460
		// (get) Token: 0x060348E7 RID: 215271 RVA: 0x00712F0C File Offset: 0x0071110C
		// (set) Token: 0x060348E8 RID: 215272 RVA: 0x00712F14 File Offset: 0x00711114
		public EPreloadObjectType Type { get; set; }

		// Token: 0x1700DC8D RID: 56461
		// (get) Token: 0x060348E9 RID: 215273 RVA: 0x00712F1D File Offset: 0x0071111D
		// (set) Token: 0x060348EA RID: 215274 RVA: 0x00712F25 File Offset: 0x00711125
		public int LinkResourceId { get; set; }

		// Token: 0x060348EB RID: 215275 RVA: 0x00712F2E File Offset: 0x0071112E
		public IPreloadLinkResourceT()
		{
			this.Type = EPreloadObjectType.PreloadTrialCharacterForSkill;
			this.LinkResourceId = 0;
		}
	}
}
