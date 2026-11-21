using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C8 RID: 29640
	public class IParticipateGroupPatrolT
	{
		// Token: 0x1700D9BA RID: 55738
		// (get) Token: 0x06033D82 RID: 212354 RVA: 0x006FE008 File Offset: 0x006FC208
		// (set) Token: 0x06033D83 RID: 212355 RVA: 0x006FE010 File Offset: 0x006FC210
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D9BB RID: 55739
		// (get) Token: 0x06033D84 RID: 212356 RVA: 0x006FE019 File Offset: 0x006FC219
		// (set) Token: 0x06033D85 RID: 212357 RVA: 0x006FE021 File Offset: 0x006FC221
		public int GroupAiEntityId { get; set; }

		// Token: 0x06033D86 RID: 212358 RVA: 0x006FE02A File Offset: 0x006FC22A
		public IParticipateGroupPatrolT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.GroupAiEntityId = 0;
		}
	}
}
