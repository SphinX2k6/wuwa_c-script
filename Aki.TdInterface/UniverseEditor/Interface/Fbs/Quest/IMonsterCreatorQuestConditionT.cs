using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F33 RID: 16179
	public class IMonsterCreatorQuestConditionT
	{
		// Token: 0x17007080 RID: 28800
		// (get) Token: 0x06016FC9 RID: 94153 RVA: 0x0035100D File Offset: 0x0034F20D
		// (set) Token: 0x06016FCA RID: 94154 RVA: 0x00351015 File Offset: 0x0034F215
		public EChildQuest Type { get; set; }

		// Token: 0x17007081 RID: 28801
		// (get) Token: 0x06016FCB RID: 94155 RVA: 0x0035101E File Offset: 0x0034F21E
		// (set) Token: 0x06016FCC RID: 94156 RVA: 0x00351026 File Offset: 0x0034F226
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007082 RID: 28802
		// (get) Token: 0x06016FCD RID: 94157 RVA: 0x0035102F File Offset: 0x0034F22F
		// (set) Token: 0x06016FCE RID: 94158 RVA: 0x00351037 File Offset: 0x0034F237
		public string TidMonsterGroupName { get; set; }

		// Token: 0x17007083 RID: 28803
		// (get) Token: 0x06016FCF RID: 94159 RVA: 0x00351040 File Offset: 0x0034F240
		// (set) Token: 0x06016FD0 RID: 94160 RVA: 0x00351048 File Offset: 0x0034F248
		public List<int> MonsterCreatorEntityIds { get; set; }

		// Token: 0x17007084 RID: 28804
		// (get) Token: 0x06016FD1 RID: 94161 RVA: 0x00351051 File Offset: 0x0034F251
		// (set) Token: 0x06016FD2 RID: 94162 RVA: 0x00351059 File Offset: 0x0034F259
		public TVarRefUnion PrefabVar { get; set; }

		// Token: 0x17007085 RID: 28805
		// (get) Token: 0x06016FD3 RID: 94163 RVA: 0x00351062 File Offset: 0x0034F262
		// (set) Token: 0x06016FD4 RID: 94164 RVA: 0x0035106A File Offset: 0x0034F26A
		public bool ShowMonsterMergedHpBar { get; set; }

		// Token: 0x17007086 RID: 28806
		// (get) Token: 0x06016FD5 RID: 94165 RVA: 0x00351073 File Offset: 0x0034F273
		// (set) Token: 0x06016FD6 RID: 94166 RVA: 0x0035107B File Offset: 0x0034F27B
		public IMonsterMergedHpBarSettingsT MonsterMergedHpBarSettings { get; set; }

		// Token: 0x17007087 RID: 28807
		// (get) Token: 0x06016FD7 RID: 94167 RVA: 0x00351084 File Offset: 0x0034F284
		// (set) Token: 0x06016FD8 RID: 94168 RVA: 0x0035108C File Offset: 0x0034F28C
		public byte NullMask { get; set; }

		// Token: 0x06016FD9 RID: 94169 RVA: 0x00351095 File Offset: 0x0034F295
		public IMonsterCreatorQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TidMonsterGroupName = null;
			this.MonsterCreatorEntityIds = null;
			this.PrefabVar = null;
			this.ShowMonsterMergedHpBar = false;
			this.MonsterMergedHpBarSettings = null;
			this.NullMask = 0;
		}
	}
}
