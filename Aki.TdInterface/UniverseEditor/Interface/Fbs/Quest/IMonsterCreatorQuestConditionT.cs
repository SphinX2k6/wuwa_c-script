using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004371 RID: 17265
	public class IMonsterCreatorQuestConditionT
	{
		// Token: 0x17007670 RID: 30320
		// (get) Token: 0x06018629 RID: 99881 RVA: 0x0037A432 File Offset: 0x00378632
		// (set) Token: 0x0601862A RID: 99882 RVA: 0x0037A43A File Offset: 0x0037863A
		public EChildQuest Type { get; set; }

		// Token: 0x17007671 RID: 30321
		// (get) Token: 0x0601862B RID: 99883 RVA: 0x0037A443 File Offset: 0x00378643
		// (set) Token: 0x0601862C RID: 99884 RVA: 0x0037A44B File Offset: 0x0037864B
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007672 RID: 30322
		// (get) Token: 0x0601862D RID: 99885 RVA: 0x0037A454 File Offset: 0x00378654
		// (set) Token: 0x0601862E RID: 99886 RVA: 0x0037A45C File Offset: 0x0037865C
		public string TidMonsterGroupName { get; set; }

		// Token: 0x17007673 RID: 30323
		// (get) Token: 0x0601862F RID: 99887 RVA: 0x0037A465 File Offset: 0x00378665
		// (set) Token: 0x06018630 RID: 99888 RVA: 0x0037A46D File Offset: 0x0037866D
		public List<int> MonsterCreatorEntityIds { get; set; }

		// Token: 0x17007674 RID: 30324
		// (get) Token: 0x06018631 RID: 99889 RVA: 0x0037A476 File Offset: 0x00378676
		// (set) Token: 0x06018632 RID: 99890 RVA: 0x0037A47E File Offset: 0x0037867E
		public TVarRefUnion PrefabVar { get; set; }

		// Token: 0x17007675 RID: 30325
		// (get) Token: 0x06018633 RID: 99891 RVA: 0x0037A487 File Offset: 0x00378687
		// (set) Token: 0x06018634 RID: 99892 RVA: 0x0037A48F File Offset: 0x0037868F
		public bool ShowMonsterMergedHpBar { get; set; }

		// Token: 0x17007676 RID: 30326
		// (get) Token: 0x06018635 RID: 99893 RVA: 0x0037A498 File Offset: 0x00378698
		// (set) Token: 0x06018636 RID: 99894 RVA: 0x0037A4A0 File Offset: 0x003786A0
		public IMonsterMergedHpBarSettingsT MonsterMergedHpBarSettings { get; set; }

		// Token: 0x17007677 RID: 30327
		// (get) Token: 0x06018637 RID: 99895 RVA: 0x0037A4A9 File Offset: 0x003786A9
		// (set) Token: 0x06018638 RID: 99896 RVA: 0x0037A4B1 File Offset: 0x003786B1
		public List<ISpecificMonsterDeadPositionT> SpecificMonsterDeadPositions { get; set; }

		// Token: 0x17007678 RID: 30328
		// (get) Token: 0x06018639 RID: 99897 RVA: 0x0037A4BA File Offset: 0x003786BA
		// (set) Token: 0x0601863A RID: 99898 RVA: 0x0037A4C2 File Offset: 0x003786C2
		public byte NullMask { get; set; }

		// Token: 0x0601863B RID: 99899 RVA: 0x0037A4CC File Offset: 0x003786CC
		public IMonsterCreatorQuestConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.TidMonsterGroupName = null;
			this.MonsterCreatorEntityIds = null;
			this.PrefabVar = null;
			this.ShowMonsterMergedHpBar = false;
			this.MonsterMergedHpBarSettings = null;
			this.SpecificMonsterDeadPositions = null;
			this.NullMask = 0;
		}
	}
}
