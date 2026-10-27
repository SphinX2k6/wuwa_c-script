using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF7 RID: 28151
	public class ItemInspectEffectTriggerDialogues : ItemInspectEffectBase
	{
		// Token: 0x06044ACB RID: 281291 RVA: 0x010F38F4 File Offset: 0x010F1AF4
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
			itemInspectViewBase.ExecuteTriggerDialogues((ITriggerDialogues)@params, delegate
			{
				base.FinishExecute(true);
			});
		}
	}
}
