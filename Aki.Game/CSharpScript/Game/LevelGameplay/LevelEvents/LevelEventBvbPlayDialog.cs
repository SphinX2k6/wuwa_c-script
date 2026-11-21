using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C6F RID: 23663
	public class LevelEventBvbPlayDialog : LevelEventBase
	{
		// Token: 0x0603A168 RID: 237928 RVA: 0x0105B79E File Offset: 0x0105999E
		public LevelEventBvbPlayDialog(int id) : base(id)
		{
		}

		// Token: 0x0603A169 RID: 237929 RVA: 0x0105B7A8 File Offset: 0x010599A8
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
