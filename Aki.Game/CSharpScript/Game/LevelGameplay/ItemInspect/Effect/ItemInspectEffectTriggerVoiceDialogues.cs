using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F77 RID: 24439
	public class ItemInspectEffectTriggerVoiceDialogues : ItemInspectEffectBase
	{
		// Token: 0x0603AC32 RID: 240690 RVA: 0x0109DC28 File Offset: 0x0109BE28
		[NullableContext(1)]
		protected override void Execute(IInteractEffect @params)
		{
			EUiViewName? viewName = ItemInspectModel.Instance.GetViewName();
			if (viewName == null)
			{
				base.FinishExecute(true);
				return;
			}
			ItemInspectViewBase itemInspectViewBase = UiManager.Instance.GetViewByName(viewName.Value) as ItemInspectViewBase;
			if (itemInspectViewBase == null)
			{
				return;
			}
			itemInspectViewBase.ExecuteTriggerVoiceDialogues(@params as ITriggerVoiceDialogues, delegate
			{
				base.FinishExecute(true);
			});
		}
	}
}
