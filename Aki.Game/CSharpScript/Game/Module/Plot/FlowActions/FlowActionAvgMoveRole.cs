using System;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot.Avg;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x02004075 RID: 16501
	public class FlowActionAvgMoveRole : FlowActionBase
	{
		// Token: 0x06029D84 RID: 171396 RVA: 0x00BD51EC File Offset: 0x00BD33EC
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
