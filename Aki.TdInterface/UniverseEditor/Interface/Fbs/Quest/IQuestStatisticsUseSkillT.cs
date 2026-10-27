using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200405C RID: 16476
	public class IQuestStatisticsUseSkillT
	{
		// Token: 0x17007402 RID: 29698
		// (get) Token: 0x06017E47 RID: 97863 RVA: 0x00372ADD File Offset: 0x00370CDD
		// (set) Token: 0x06017E48 RID: 97864 RVA: 0x00372AE5 File Offset: 0x00370CE5
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007403 RID: 29699
		// (get) Token: 0x06017E49 RID: 97865 RVA: 0x00372AEE File Offset: 0x00370CEE
		// (set) Token: 0x06017E4A RID: 97866 RVA: 0x00372AF6 File Offset: 0x00370CF6
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007404 RID: 29700
		// (get) Token: 0x06017E4B RID: 97867 RVA: 0x00372AFF File Offset: 0x00370CFF
		// (set) Token: 0x06017E4C RID: 97868 RVA: 0x00372B07 File Offset: 0x00370D07
		public int SkillId { get; set; }

		// Token: 0x17007405 RID: 29701
		// (get) Token: 0x06017E4D RID: 97869 RVA: 0x00372B10 File Offset: 0x00370D10
		// (set) Token: 0x06017E4E RID: 97870 RVA: 0x00372B18 File Offset: 0x00370D18
		public bool IsWaitFinish { get; set; }

		// Token: 0x17007406 RID: 29702
		// (get) Token: 0x06017E4F RID: 97871 RVA: 0x00372B21 File Offset: 0x00370D21
		// (set) Token: 0x06017E50 RID: 97872 RVA: 0x00372B29 File Offset: 0x00370D29
		public byte NullMask { get; set; }

		// Token: 0x06017E51 RID: 97873 RVA: 0x00372B32 File Offset: 0x00370D32
		public IQuestStatisticsUseSkillT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.SkillId = 0;
			this.IsWaitFinish = false;
			this.NullMask = 0;
		}
	}
}
