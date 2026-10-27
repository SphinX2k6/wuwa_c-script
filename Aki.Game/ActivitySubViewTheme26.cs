using System;
using CSharpScript.Game.Ui;

// Token: 0x020012B2 RID: 4786
public class ActivitySubViewTheme26 : ActivitySubViewSevenHills
{
	// Token: 0x06008382 RID: 33666 RVA: 0x001C04AB File Offset: 0x001BE6AB
	protected override void OnConfirmBtnClick()
	{
		UiManager.Instance.OpenView(EUiViewName.Theme26MainView, this.ActivityData, null);
	}
}
