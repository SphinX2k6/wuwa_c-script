using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF8 RID: 28152
	public class ItemInspectEffectTriggerVoiceDialogues : ItemInspectEffectBase
	{
		// Token: 0x06044ACE RID: 281294 RVA: 0x010F3960 File Offset: 0x010F1B60
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
