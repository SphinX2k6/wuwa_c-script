using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004437 RID: 17463
	public class IQuestMonsterPointT
	{
		// Token: 0x17007903 RID: 30979
		// (get) Token: 0x06019051 RID: 102481 RVA: 0x00391D8D File Offset: 0x0038FF8D
		// (set) Token: 0x06019052 RID: 102482 RVA: 0x00391D95 File Offset: 0x0038FF95
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007904 RID: 30980
		// (get) Token: 0x06019053 RID: 102483 RVA: 0x00391D9E File Offset: 0x0038FF9E
		// (set) Token: 0x06019054 RID: 102484 RVA: 0x00391DA6 File Offset: 0x0038FFA6
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007905 RID: 30981
		// (get) Token: 0x06019055 RID: 102485 RVA: 0x00391DAF File Offset: 0x0038FFAF
		// (set) Token: 0x06019056 RID: 102486 RVA: 0x00391DB7 File Offset: 0x0038FFB7
		public EElementCategory DamageElementType { get; set; }

		// Token: 0x17007906 RID: 30982
		// (get) Token: 0x06019057 RID: 102487 RVA: 0x00391DC0 File Offset: 0x0038FFC0
		// (set) Token: 0x06019058 RID: 102488 RVA: 0x00391DC8 File Offset: 0x0038FFC8
		public ESkillCategory SkillCategory { get; set; }

		// Token: 0x17007907 RID: 30983
		// (get) Token: 0x06019059 RID: 102489 RVA: 0x00391DD1 File Offset: 0x0038FFD1
		// (set) Token: 0x0601905A RID: 102490 RVA: 0x00391DD9 File Offset: 0x0038FFD9
		public List<int> KillByEntities { get; set; }

		// Token: 0x17007908 RID: 30984
		// (get) Token: 0x0601905B RID: 102491 RVA: 0x00391DE2 File Offset: 0x0038FFE2
		// (set) Token: 0x0601905C RID: 102492 RVA: 0x00391DEA File Offset: 0x0038FFEA
		public bool KilledByAny { get; set; }

		// Token: 0x17007909 RID: 30985
		// (get) Token: 0x0601905D RID: 102493 RVA: 0x00391DF3 File Offset: 0x0038FFF3
		// (set) Token: 0x0601905E RID: 102494 RVA: 0x00391DFB File Offset: 0x0038FFFB
		public List<IMonsterPointTypeConfigT> TypeConfigs { get; set; }

		// Token: 0x1700790A RID: 30986
		// (get) Token: 0x0601905F RID: 102495 RVA: 0x00391E04 File Offset: 0x00390004
		// (set) Token: 0x06019060 RID: 102496 RVA: 0x00391E0C File Offset: 0x0039000C
		public List<IMonsterPointEntityConfigT> EntityConfigs { get; set; }

		// Token: 0x1700790B RID: 30987
		// (get) Token: 0x06019061 RID: 102497 RVA: 0x00391E15 File Offset: 0x00390015
		// (set) Token: 0x06019062 RID: 102498 RVA: 0x00391E1D File Offset: 0x0039001D
		public bool OnlyCountThisTreeAwakeEntities { get; set; }

		// Token: 0x1700790C RID: 30988
		// (get) Token: 0x06019063 RID: 102499 RVA: 0x00391E26 File Offset: 0x00390026
		// (set) Token: 0x06019064 RID: 102500 RVA: 0x00391E2E File Offset: 0x0039002E
		public IBindCrossSceneSyncKillMonsterT BindCrossSceneSyncKillMonster { get; set; }

		// Token: 0x1700790D RID: 30989
		// (get) Token: 0x06019065 RID: 102501 RVA: 0x00391E37 File Offset: 0x00390037
		// (set) Token: 0x06019066 RID: 102502 RVA: 0x00391E3F File Offset: 0x0039003F
		public byte NullMask { get; set; }

		// Token: 0x06019067 RID: 102503 RVA: 0x00391E48 File Offset: 0x00390048
		public IQuestMonsterPointT()
		{
			this.Type = EStatisticsEventType.Collect;
			this.Var = null;
			this.DamageElementType = EElementCategory.Element0;
			this.SkillCategory = ESkillCategory.Normal;
			this.KillByEntities = null;
			this.KilledByAny = false;
			this.TypeConfigs = null;
			this.EntityConfigs = null;
			this.OnlyCountThisTreeAwakeEntities = false;
			this.BindCrossSceneSyncKillMonster = null;
			this.NullMask = 0;
		}
	}
}
