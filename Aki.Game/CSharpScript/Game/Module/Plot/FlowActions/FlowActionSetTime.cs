using System;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.FlowActions
{
	// Token: 0x020050D6 RID: 20694
	public class FlowActionSetTime : FlowActionBase
	{
		// Token: 0x06034F51 RID: 216913 RVA: 0x00C8B840 File Offset: 0x00C89A40
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

		// Token: 0x06034F52 RID: 216914 RVA: 0x00C8B890 File Offset: 0x00C89A90
		protected override void OnBackgroundExecute()
		{
			this.OnExecute();
		}
	}
}
