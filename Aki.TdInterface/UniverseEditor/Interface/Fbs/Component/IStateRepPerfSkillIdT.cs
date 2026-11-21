using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FCA RID: 24522
	public class IStateRepPerfSkillIdT
	{
		// Token: 0x1700B598 RID: 46488
		// (get) Token: 0x0602943F RID: 169023 RVA: 0x005A1C38 File Offset: 0x0059FE38
		// (set) Token: 0x06029440 RID: 169024 RVA: 0x005A1C40 File Offset: 0x0059FE40
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700B599 RID: 46489
		// (get) Token: 0x06029441 RID: 169025 RVA: 0x005A1C49 File Offset: 0x0059FE49
		// (set) Token: 0x06029442 RID: 169026 RVA: 0x005A1C51 File Offset: 0x0059FE51
		public long SkillId { get; set; }

		// Token: 0x06029443 RID: 169027 RVA: 0x005A1C5A File Offset: 0x0059FE5A
		public IStateRepPerfSkillIdT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.SkillId = 0L;
		}
	}
}
