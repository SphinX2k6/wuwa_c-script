using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B1F RID: 27423
	public class LevelEventEnterSequenceCamera : LevelEventBase
	{
		// Token: 0x060440BF RID: 278719 RVA: 0x010BA538 File Offset: 0x010B8738
		public LevelEventEnterSequenceCamera(int id) : base(id)
		{
		}

		// Token: 0x060440C0 RID: 278720 RVA: 0x010BA541 File Offset: 0x010B8741
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				return;
			}
			if ((inParams as ActionEnterSequenceCamera).ShouldEnter)
			{
				PlotModel.Instance.SwitchCameraMode(EPlotCameraMode.PlotMain);
				return;
			}
			PlotModel.Instance.SwitchCameraMode(EPlotCameraMode.Main);
		}
	}
}
