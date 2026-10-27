using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C61 RID: 27745
	public class IParticipateGroupPatrolT
	{
		// Token: 0x1700CE9F RID: 52895
		// (get) Token: 0x06030E27 RID: 200231 RVA: 0x006A3B08 File Offset: 0x006A1D08
		// (set) Token: 0x06030E28 RID: 200232 RVA: 0x006A3B10 File Offset: 0x006A1D10
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CEA0 RID: 52896
		// (get) Token: 0x06030E29 RID: 200233 RVA: 0x006A3B19 File Offset: 0x006A1D19
		// (set) Token: 0x06030E2A RID: 200234 RVA: 0x006A3B21 File Offset: 0x006A1D21
		public int GroupAiEntityId { get; set; }

		// Token: 0x06030E2B RID: 200235 RVA: 0x006A3B2A File Offset: 0x006A1D2A
		public IParticipateGroupPatrolT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.GroupAiEntityId = 0;
		}
	}
}
