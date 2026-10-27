using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004023 RID: 16419
	public class IQuestScheduleEntityHPT
	{
		// Token: 0x1700737B RID: 29563
		// (get) Token: 0x06017BA9 RID: 97193 RVA: 0x0036C2F4 File Offset: 0x0036A4F4
		// (set) Token: 0x06017BAA RID: 97194 RVA: 0x0036C2FC File Offset: 0x0036A4FC
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700737C RID: 29564
		// (get) Token: 0x06017BAB RID: 97195 RVA: 0x0036C305 File Offset: 0x0036A505
		// (set) Token: 0x06017BAC RID: 97196 RVA: 0x0036C30D File Offset: 0x0036A50D
		public int EntityId { get; set; }

		// Token: 0x06017BAD RID: 97197 RVA: 0x0036C316 File Offset: 0x0036A516
		public IQuestScheduleEntityHPT()
		{
			this.Type = EQuestScheduleType.None;
			this.EntityId = 0;
		}
	}
}
