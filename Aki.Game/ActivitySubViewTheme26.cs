using System;
using CSharpScript.Game.Ui;

// Token: 0x02000766 RID: 1894
public class ActivitySubViewTheme26 : ActivitySubViewSevenHills
{
	// Token: 0x06005719 RID: 22297 RVA: 0x001C923B File Offset: 0x001C743B
	protected override void OnConfirmBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.Theme26MainView, this.ActivityData, null);
	}
}
