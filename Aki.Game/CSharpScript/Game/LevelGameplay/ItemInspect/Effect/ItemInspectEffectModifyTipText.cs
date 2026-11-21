using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F74 RID: 24436
	public class ItemInspectEffectModifyTipText : ItemInspectEffectBase
	{
		// Token: 0x0603AC2A RID: 240682 RVA: 0x0109DABC File Offset: 0x0109BCBC
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
			itemInspectViewBase.ExecuteModifyTipText(((IModifyTipText)@params).TipText, delegate
			{
				base.FinishExecute(true);
			});
		}
	}
}
