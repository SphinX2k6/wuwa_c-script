using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FC7 RID: 24519
	public class IStateRepPerfMontagePathT
	{
		// Token: 0x1700B592 RID: 46482
		// (get) Token: 0x06029427 RID: 168999 RVA: 0x005A1A18 File Offset: 0x0059FC18
		// (set) Token: 0x06029428 RID: 169000 RVA: 0x005A1A20 File Offset: 0x0059FC20
		public EStateRepPerfType Type { get; set; }

		// Token: 0x1700B593 RID: 46483
		// (get) Token: 0x06029429 RID: 169001 RVA: 0x005A1A29 File Offset: 0x0059FC29
		// (set) Token: 0x0602942A RID: 169002 RVA: 0x005A1A31 File Offset: 0x0059FC31
		public string MontagePath { get; set; }

		// Token: 0x1700B594 RID: 46484
		// (get) Token: 0x0602942B RID: 169003 RVA: 0x005A1A3A File Offset: 0x0059FC3A
		// (set) Token: 0x0602942C RID: 169004 RVA: 0x005A1A42 File Offset: 0x0059FC42
		public string MontageName { get; set; }

		// Token: 0x0602942D RID: 169005 RVA: 0x005A1A4B File Offset: 0x0059FC4B
		public IStateRepPerfMontagePathT()
		{
			this.Type = EStateRepPerfType.SkillId;
			this.MontagePath = null;
			this.MontageName = null;
		}
	}
}
