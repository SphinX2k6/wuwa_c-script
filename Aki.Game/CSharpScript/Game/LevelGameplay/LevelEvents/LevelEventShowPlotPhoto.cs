using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B83 RID: 27523
	public class LevelEventShowPlotPhoto : LevelEventBase
	{
		// Token: 0x06044270 RID: 279152 RVA: 0x010CAC1C File Offset: 0x010C8E1C
		public LevelEventShowPlotPhoto(int id) : base(id)
		{
		}

		// Token: 0x06044271 RID: 279153 RVA: 0x010CAC28 File Offset: 0x010C8E28
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
