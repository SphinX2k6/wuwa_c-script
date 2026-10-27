using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AF7 RID: 27383
	public class LevelEventBvbPlayDialog : LevelEventBase
	{
		// Token: 0x06044016 RID: 278550 RVA: 0x010B1ECE File Offset: 0x010B00CE
		public LevelEventBvbPlayDialog(int id) : base(id)
		{
		}

		// Token: 0x06044017 RID: 278551 RVA: 0x010B1ED8 File Offset: 0x010B00D8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			BvbPlayDialog bvbPlayDialog = inParams as BvbPlayDialog;
			if (bvbPlayDialog == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			UiViewBase viewByName = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleDetailsView);
			if (viewByName != null)
			{
				(viewByName.OpenParam as PhantomArenaBattleDetailsViewProxy).DialogManager.NotifyDialogType(bvbPlayDialog.DialogType);
				base.FinishExecute(true, false, true);
				return;
			}
			UiViewBase viewByName2 = UiManager.Instance.GetViewByName(EUiViewName.PhantomArenaBattleView);
			if (viewByName2 != null)
			{
				(viewByName2.OpenParam as PhantomArenaBattleProxy).DialogManager.NotifyDialogType(bvbPlayDialog.DialogType);
			}
			base.FinishExecute(true, false, true);
		}
	}
}
