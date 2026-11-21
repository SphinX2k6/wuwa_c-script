using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004281 RID: 17025
	public class IFinishRoleTowerConditionT
	{
		// Token: 0x1700743B RID: 29755
		// (get) Token: 0x06017C35 RID: 97333 RVA: 0x00364039 File Offset: 0x00362239
		// (set) Token: 0x06017C36 RID: 97334 RVA: 0x00364041 File Offset: 0x00362241
		public EChildQuest Type { get; set; }

		// Token: 0x1700743C RID: 29756
		// (get) Token: 0x06017C37 RID: 97335 RVA: 0x0036404A File Offset: 0x0036224A
		// (set) Token: 0x06017C38 RID: 97336 RVA: 0x00364052 File Offset: 0x00362252
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x1700743D RID: 29757
		// (get) Token: 0x06017C39 RID: 97337 RVA: 0x0036405B File Offset: 0x0036225B
		// (set) Token: 0x06017C3A RID: 97338 RVA: 0x00364063 File Offset: 0x00362263
		public TRoleTowerConditionStepUnion Step { get; set; }

		// Token: 0x1700743E RID: 29758
		// (get) Token: 0x06017C3B RID: 97339 RVA: 0x0036406C File Offset: 0x0036226C
		// (set) Token: 0x06017C3C RID: 97340 RVA: 0x00364074 File Offset: 0x00362274
		public TVarRefUnion Batch { get; set; }

		// Token: 0x06017C3D RID: 97341 RVA: 0x0036407D File Offset: 0x0036227D
		public IFinishRoleTowerConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.Step = null;
			this.Batch = null;
		}
	}
}
