using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020040A6 RID: 16550
	public class FlowActionSetTime : FlowActionBase
	{
		// Token: 0x06029E4A RID: 171594 RVA: 0x00BD8B28 File Offset: 0x00BD6D28
		protected override void OnExecute()
		{
			AdjustTodTime adjustTodTime = this.ActionInfo.Params as AdjustTodTime;
			double num = TodDayTime.ConvertFromHourMinute((double)adjustTodTime.Hour, (double)adjustTodTime.Min);
			if (num < 0.0)
			{
				return;
			}
			PlotModel.Instance.PlotTimeOfDay.SetTime((int)num);
		}

		// Token: 0x06029E4B RID: 171595 RVA: 0x00BD8B78 File Offset: 0x00BD6D78
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
