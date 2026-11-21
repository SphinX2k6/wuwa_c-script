using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004485 RID: 17541
	public class IQuestScheduleTypeT
	{
		// Token: 0x170079D1 RID: 31185
		// (get) Token: 0x060193BD RID: 103357 RVA: 0x00399A36 File Offset: 0x00397C36
		// (set) Token: 0x060193BE RID: 103358 RVA: 0x00399A3E File Offset: 0x00397C3E
		public EQuestScheduleType Type { get; set; }

		// Token: 0x060193BF RID: 103359 RVA: 0x00399A47 File Offset: 0x00397C47
		public IQuestScheduleTypeT()
		{
			this.Type = EQuestScheduleType.None;
		}
	}
}
