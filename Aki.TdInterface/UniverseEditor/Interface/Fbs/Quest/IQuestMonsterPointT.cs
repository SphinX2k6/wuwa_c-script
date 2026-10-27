using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FF6 RID: 16374
	public class IQuestMonsterPointT
	{
		// Token: 0x17007301 RID: 29441
		// (get) Token: 0x060179B8 RID: 96696 RVA: 0x00367F99 File Offset: 0x00366199
		// (set) Token: 0x060179B9 RID: 96697 RVA: 0x00367FA1 File Offset: 0x003661A1
		public EStatisticsEventType Type { get; set; }

		// Token: 0x17007302 RID: 29442
		// (get) Token: 0x060179BA RID: 96698 RVA: 0x00367FAA File Offset: 0x003661AA
		// (set) Token: 0x060179BB RID: 96699 RVA: 0x00367FB2 File Offset: 0x003661B2
		public TVarRefUnion Var { get; set; }

		// Token: 0x17007303 RID: 29443
		// (get) Token: 0x060179BC RID: 96700 RVA: 0x00367FBB File Offset: 0x003661BB
		// (set) Token: 0x060179BD RID: 96701 RVA: 0x00367FC3 File Offset: 0x003661C3
		public EElementCategory DamageElementType { get; set; }

		// Token: 0x17007304 RID: 29444
		// (get) Token: 0x060179BE RID: 96702 RVA: 0x00367FCC File Offset: 0x003661CC
		// (set) Token: 0x060179BF RID: 96703 RVA: 0x00367FD4 File Offset: 0x003661D4
		public ESkillCategory SkillCategory { get; set; }

		// Token: 0x17007305 RID: 29445
		// (get) Token: 0x060179C0 RID: 96704 RVA: 0x00367FDD File Offset: 0x003661DD
		// (set) Token: 0x060179C1 RID: 96705 RVA: 0x00367FE5 File Offset: 0x003661E5
		public List<int> KillByEntities { get; set; }

		// Token: 0x17007306 RID: 29446
		// (get) Token: 0x060179C2 RID: 96706 RVA: 0x00367FEE File Offset: 0x003661EE
		// (set) Token: 0x060179C3 RID: 96707 RVA: 0x00367FF6 File Offset: 0x003661F6
		public bool KilledByAny { get; set; }

		// Token: 0x17007307 RID: 29447
		// (get) Token: 0x060179C4 RID: 96708 RVA: 0x00367FFF File Offset: 0x003661FF
		// (set) Token: 0x060179C5 RID: 96709 RVA: 0x00368007 File Offset: 0x00366207
		public List<IMonsterPointTypeConfigT> TypeConfigs { get; set; }

		// Token: 0x17007308 RID: 29448
		// (get) Token: 0x060179C6 RID: 96710 RVA: 0x00368010 File Offset: 0x00366210
		// (set) Token: 0x060179C7 RID: 96711 RVA: 0x00368018 File Offset: 0x00366218
		public List<IMonsterPointEntityConfigT> EntityConfigs { get; set; }

		// Token: 0x17007309 RID: 29449
		// (get) Token: 0x060179C8 RID: 96712 RVA: 0x00368021 File Offset: 0x00366221
		// (set) Token: 0x060179C9 RID: 96713 RVA: 0x00368029 File Offset: 0x00366229
		public bool OnlyCountThisTreeAwakeEntities { get; set; }

		// Token: 0x1700730A RID: 29450
		// (get) Token: 0x060179CA RID: 96714 RVA: 0x00368032 File Offset: 0x00366232
		// (set) Token: 0x060179CB RID: 96715 RVA: 0x0036803A File Offset: 0x0036623A
		public IBindCrossSceneSyncKillMonsterT BindCrossSceneSyncKillMonster { get; set; }

		// Token: 0x1700730B RID: 29451
		// (get) Token: 0x060179CC RID: 96716 RVA: 0x00368043 File Offset: 0x00366243
		// (set) Token: 0x060179CD RID: 96717 RVA: 0x0036804B File Offset: 0x0036624B
		public byte NullMask { get; set; }

		// Token: 0x060179CE RID: 96718 RVA: 0x00368054 File Offset: 0x00366254
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
