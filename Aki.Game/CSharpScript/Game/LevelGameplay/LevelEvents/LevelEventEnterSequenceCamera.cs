using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Plot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C97 RID: 23703
	public class LevelEventEnterSequenceCamera : LevelEventBase
	{
		// Token: 0x0603A211 RID: 238097 RVA: 0x01063DC4 File Offset: 0x01061FC4
		public LevelEventEnterSequenceCamera(int id) : base(id)
		{
		}

		// Token: 0x0603A212 RID: 238098 RVA: 0x01063DCD File Offset: 0x01061FCD
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
