using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BD RID: 22973
	public class IStateRepPerfSkillIdT
	{
		// Token: 0x1700AC64 RID: 44132
		// (get) Token: 0x06026ED5 RID: 159445 RVA: 0x0055AFCC File Offset: 0x005591CC
		// (set) Token: 0x06026ED6 RID: 159446 RVA: 0x0055AFD4 File Offset: 0x005591D4
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700AC65 RID: 44133
		// (get) Token: 0x06026ED7 RID: 159447 RVA: 0x0055AFDD File Offset: 0x005591DD
		// (set) Token: 0x06026ED8 RID: 159448 RVA: 0x0055AFE5 File Offset: 0x005591E5
		public long SkillId { get; set; }

		// Token: 0x06026ED9 RID: 159449 RVA: 0x0055AFEE File Offset: 0x005591EE
		public IStateRepPerfSkillIdT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.SkillId = 0L;
		}
	}
}
