using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002A2E RID: 10798
public class SkinTabItem : CommonTabItem, ITabViewRegister
{
	// Token: 0x0601677D RID: 92029 RVA: 0x005B1108 File Offset: 0x005AF308
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

	// Token: 0x0601677E RID: 92030 RVA: 0x005B1149 File Offset: 0x005AF349
	[NullableContext(1)]
	public void RegisterViewModule(UiTabViewBase tabView)
	{
		tabView.AddUiTabViewBehavior<UiTabCamera>().SetTabData((EUiTabViewName)tabView.GetViewName());
		tabView.AddUiTabViewBehavior<UiTabSequence>().SetRootItem(tabView);
	}
}
