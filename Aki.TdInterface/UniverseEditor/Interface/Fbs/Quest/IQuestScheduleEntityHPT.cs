using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004464 RID: 17508
	public class IQuestScheduleEntityHPT
	{
		// Token: 0x1700797D RID: 31101
		// (get) Token: 0x06019242 RID: 102978 RVA: 0x003960E8 File Offset: 0x003942E8
		// (set) Token: 0x06019243 RID: 102979 RVA: 0x003960F0 File Offset: 0x003942F0
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700797E RID: 31102
		// (get) Token: 0x06019244 RID: 102980 RVA: 0x003960F9 File Offset: 0x003942F9
		// (set) Token: 0x06019245 RID: 102981 RVA: 0x00396101 File Offset: 0x00394301
		public int EntityId { get; set; }

		// Token: 0x06019246 RID: 102982 RVA: 0x0039610A File Offset: 0x0039430A
		public IQuestScheduleEntityHPT()
		{
			this.Type = EQuestScheduleType.None;
			this.EntityId = 0;
		}
	}
}
