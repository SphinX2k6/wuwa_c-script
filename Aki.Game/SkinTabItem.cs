using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001FA9 RID: 8105
public class SkinTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x06014186 RID: 82310 RVA: 0x005DC150 File Offset: 0x005DA350
	public override void BindRedDot(ERedDotName redDotName, int? uId = 0)
	{
		int? num = uId;
		int num2 = 0;
		if (!(num.GetValueOrDefault() == num2 & num != null) && uId != null)
		{
			RedDotController.Instance.UnBindRedDotAndClearData(redDotName);
		}
		base.BindRedDot(redDotName, uId);
	}

	// Token: 0x06014187 RID: 82311 RVA: 0x005DC191 File Offset: 0x005DA391
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
