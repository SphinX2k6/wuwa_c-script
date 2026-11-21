using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004D67 RID: 19815
	public class StepConditionIndexChangeProcess : TPendingProcess
	{
		// Token: 0x06031B9B RID: 203675 RVA: 0x00DE7315 File Offset: 0x00DE5515
		public StepConditionIndexChangeProcess(EMissionItemView viewId, int stepId, int? curConditionTextIndex)
		{
		}

		// Token: 0x1700622F RID: 25135
		// (get) Token: 0x06031B9C RID: 203676 RVA: 0x00DE7332 File Offset: 0x00DE5532
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.StepConditionIndexChange;
			}
		}

		// Token: 0x17006230 RID: 25136
		// (get) Token: 0x06031B9D RID: 203677 RVA: 0x00DE7335 File Offset: 0x00DE5535
		public override bool IsSkipAnim
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0401A530 RID: 107824
		public readonly EMissionItemView ViewId = viewId;

		// Token: 0x0401A531 RID: 107825
		public readonly int StepId = stepId;

		// Token: 0x0401A532 RID: 107826
		public readonly int? CurConditionTextIndex = curConditionTextIndex;
	}
}
