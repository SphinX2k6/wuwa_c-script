using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CFB RID: 23803
	public class LevelEventShowPlotPhoto : LevelEventBase
	{
		// Token: 0x0603A3C2 RID: 238530 RVA: 0x010748B4 File Offset: 0x01072AB4
		public LevelEventShowPlotPhoto(int id) : base(id)
		{
		}

		// Token: 0x0603A3C3 RID: 238531 RVA: 0x010748C0 File Offset: 0x01072AC0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (!(inParams is TakePlotPhoto))
			{
				return;
			}
			PhotographController.Instance.CameraCaptureType = ECameraCaptureType.EntityCamera;
			if (!UiManager.Instance.IsViewOpen(EUiViewName.PhotographView) && PhotographController.Instance.TryOpenPhotograph(ECameraCaptureType.EntityCamera))
			{
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.PhotographView);
			}
			base.FinishExecute(true, false, true);
		}
	}
}
