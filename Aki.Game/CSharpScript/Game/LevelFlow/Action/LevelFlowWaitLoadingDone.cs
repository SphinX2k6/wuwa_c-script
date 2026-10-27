using System;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006FA8 RID: 28584
	public class LevelFlowWaitLoadingDone : LevelFlowActionBase
	{
		// Token: 0x0604579D RID: 284573 RVA: 0x0113C3C0 File Offset: 0x0113A5C0
		protected override void OnExecute()
		{
			if (!LoadingModel.Instance.IsLoading)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0604579E RID: 284574 RVA: 0x0113C3D5 File Offset: 0x0113A5D5
		protected override void OnTick(float delta)
		{
			if (!LoadingModel.Instance.IsLoading)
			{
				base.FinishExecute(true);
			}
		}
	}
}
