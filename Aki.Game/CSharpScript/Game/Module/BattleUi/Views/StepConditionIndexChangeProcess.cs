using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005D85 RID: 23941
	public class StepConditionIndexChangeProcess : TPendingProcess
	{
		// Token: 0x0603CC3F RID: 248895 RVA: 0x00E96ACD File Offset: 0x00E94CCD
		public StepConditionIndexChangeProcess(EMissionItemView viewId, int stepId, int? curConditionTextIndex)
		{
		}

		// Token: 0x17008E5D RID: 36445
		// (get) Token: 0x0603CC40 RID: 248896 RVA: 0x00E96AEA File Offset: 0x00E94CEA
		public override EMissionProcessType ProcessType
		{
			get
			{
				return EMissionProcessType.StepConditionIndexChange;
			}
		}

		// Token: 0x17008E5E RID: 36446
		// (get) Token: 0x0603CC41 RID: 248897 RVA: 0x00E96AED File Offset: 0x00E94CED
		public override bool IsSkipAnim
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0401FA78 RID: 129656
		public readonly EMissionItemView ViewId = viewId;

		// Token: 0x0401FA79 RID: 129657
		public readonly int StepId = stepId;

		// Token: 0x0401FA7A RID: 129658
		public readonly int? CurConditionTextIndex = curConditionTextIndex;
	}
}
