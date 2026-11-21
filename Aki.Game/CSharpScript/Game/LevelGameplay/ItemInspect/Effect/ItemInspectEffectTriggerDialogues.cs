using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.ItemInspect.View;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.Effect
{
	// Token: 0x02005F76 RID: 24438
	public class ItemInspectEffectTriggerDialogues : ItemInspectEffectBase
	{
		// Token: 0x0603AC2F RID: 240687 RVA: 0x0109DBBC File Offset: 0x0109BDBC
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
