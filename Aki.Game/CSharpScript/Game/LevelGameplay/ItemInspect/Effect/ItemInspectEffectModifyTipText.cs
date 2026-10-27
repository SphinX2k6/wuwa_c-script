using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02006DF5 RID: 28149
	public class ItemInspectEffectModifyTipText : ItemInspectEffectBase
	{
		// Token: 0x06044AC6 RID: 281286 RVA: 0x010F37F4 File Offset: 0x010F19F4
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
