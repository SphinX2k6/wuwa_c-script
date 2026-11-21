using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046E6 RID: 18150
	public class IWalkingPatternConditionT
	{
		// Token: 0x17007F29 RID: 32553
		// (get) Token: 0x0601AB2F RID: 109359 RVA: 0x003CB961 File Offset: 0x003C9B61
		// (set) Token: 0x0601AB30 RID: 109360 RVA: 0x003CB969 File Offset: 0x003C9B69
		public EChildQuest Type { get; set; }

		// Token: 0x17007F2A RID: 32554
		// (get) Token: 0x0601AB31 RID: 109361 RVA: 0x003CB972 File Offset: 0x003C9B72
		// (set) Token: 0x0601AB32 RID: 109362 RVA: 0x003CB97A File Offset: 0x003C9B7A
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007F2B RID: 32555
		// (get) Token: 0x0601AB33 RID: 109363 RVA: 0x003CB983 File Offset: 0x003C9B83
		// (set) Token: 0x0601AB34 RID: 109364 RVA: 0x003CB98B File Offset: 0x003C9B8B
		public int SplineEntityId { get; set; }

		// Token: 0x17007F2C RID: 32556
		// (get) Token: 0x0601AB35 RID: 109365 RVA: 0x003CB994 File Offset: 0x003C9B94
		// (set) Token: 0x0601AB36 RID: 109366 RVA: 0x003CB99C File Offset: 0x003C9B9C
		public int EndEntityId { get; set; }

		// Token: 0x17007F2D RID: 32557
		// (get) Token: 0x0601AB37 RID: 109367 RVA: 0x003CB9A5 File Offset: 0x003C9BA5
		// (set) Token: 0x0601AB38 RID: 109368 RVA: 0x003CB9AD File Offset: 0x003C9BAD
		public TVarRefUnion ScoreVar { get; set; }

		// Token: 0x0601AB39 RID: 109369 RVA: 0x003CB9B6 File Offset: 0x003C9BB6
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
