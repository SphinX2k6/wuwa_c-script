using System;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x02006129 RID: 24873
	public class LevelFlowWaitLoadingDone : LevelFlowActionBase
	{
		// Token: 0x0603B94B RID: 244043 RVA: 0x010E61C4 File Offset: 0x010E43C4
		protected override void OnExecute()
		{
			if (!LoadingModel.Instance.IsLoading)
			{
				base.FinishExecute(true);
			}
		}

		// Token: 0x0603B94C RID: 244044 RVA: 0x010E61D9 File Offset: 0x010E43D9
		protected override void OnTick(float delta)
		{
			if (!LoadingModel.Instance.IsLoading)
			{
				base.FinishExecute(true);
			}
		}
	}
}
