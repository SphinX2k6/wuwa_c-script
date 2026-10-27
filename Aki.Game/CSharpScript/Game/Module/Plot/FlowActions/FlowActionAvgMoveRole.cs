using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Avg;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050A5 RID: 20645
	public class FlowActionAvgMoveRole : FlowActionBase
	{
		// Token: 0x06034E8B RID: 216715 RVA: 0x00C87F6C File Offset: 0x00C8616C
		protected override void OnExecute()
		{
			AvgMoveRole avgMoveRole = this.ActionInfo.Params as AvgMoveRole;
			AvgTalkerMoveActionContext context = new AvgTalkerMoveActionContext
			{
				CharacterId = avgMoveRole.RoleId,
				AnimationType = avgMoveRole.AnimationType,
				TargetPosition = avgMoveRole.TargetPosition,
				EaseCurve = avgMoveRole.EaseCurve
			};
			if (this.ActionInfo.Async.GetValueOrDefault())
			{
				PlotModel.Instance.PlotAvg.AvgCharacterMoveAsync(context).Forget();
				base.FinishExecute(true, true);
				return;
			}
			PlotModel.Instance.PlotAvg.AvgCharacterMoveAsync(context).ContinueWith(delegate()
			{
				base.FinishExecute(true, true);
			}).Forget();
		}
	}
}
