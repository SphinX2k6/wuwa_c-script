using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428A RID: 17034
	public class IWalkingPatternConditionT
	{
		// Token: 0x170078F8 RID: 30968
		// (get) Token: 0x060193C3 RID: 103363 RVA: 0x003A0289 File Offset: 0x0039E489
		// (set) Token: 0x060193C4 RID: 103364 RVA: 0x003A0291 File Offset: 0x0039E491
		public EChildQuest Type { get; set; }

		// Token: 0x170078F9 RID: 30969
		// (get) Token: 0x060193C5 RID: 103365 RVA: 0x003A029A File Offset: 0x0039E49A
		// (set) Token: 0x060193C6 RID: 103366 RVA: 0x003A02A2 File Offset: 0x0039E4A2
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x170078FA RID: 30970
		// (get) Token: 0x060193C7 RID: 103367 RVA: 0x003A02AB File Offset: 0x0039E4AB
		// (set) Token: 0x060193C8 RID: 103368 RVA: 0x003A02B3 File Offset: 0x0039E4B3
		public int SplineEntityId { get; set; }

		// Token: 0x170078FB RID: 30971
		// (get) Token: 0x060193C9 RID: 103369 RVA: 0x003A02BC File Offset: 0x0039E4BC
		// (set) Token: 0x060193CA RID: 103370 RVA: 0x003A02C4 File Offset: 0x0039E4C4
		public int EndEntityId { get; set; }

		// Token: 0x170078FC RID: 30972
		// (get) Token: 0x060193CB RID: 103371 RVA: 0x003A02CD File Offset: 0x0039E4CD
		// (set) Token: 0x060193CC RID: 103372 RVA: 0x003A02D5 File Offset: 0x0039E4D5
		public TVarRefUnion ScoreVar { get; set; }

		// Token: 0x060193CD RID: 103373 RVA: 0x003A02DE File Offset: 0x0039E4DE
		public IWalkingPatternConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.SplineEntityId = 0;
			this.EndEntityId = 0;
			this.ScoreVar = null;
		}
	}
}
