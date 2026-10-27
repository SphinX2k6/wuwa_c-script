using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FE4 RID: 16356
	public class IQuestFailedConditionPlayerMotionStateT
	{
		// Token: 0x170072C7 RID: 29383
		// (get) Token: 0x060178AD RID: 96429 RVA: 0x003653C4 File Offset: 0x003635C4
		// (set) Token: 0x060178AE RID: 96430 RVA: 0x003653CC File Offset: 0x003635CC
		public EPlayerMotionState MotionState { get; set; }

		// Token: 0x170072C8 RID: 29384
		// (get) Token: 0x060178AF RID: 96431 RVA: 0x003653D5 File Offset: 0x003635D5
		// (set) Token: 0x060178B0 RID: 96432 RVA: 0x003653DD File Offset: 0x003635DD
		public ECompare Compare { get; set; }

		// Token: 0x060178B1 RID: 96433 RVA: 0x003653E6 File Offset: 0x003635E6
		public IQuestFailedConditionPlayerMotionStateT()
		{
			this.MotionState = EPlayerMotionState.Ground;
			this.Compare = ECompare.Eq;
		}
	}
}
