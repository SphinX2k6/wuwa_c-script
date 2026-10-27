using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200148E RID: 5262
public class ActivityRecallCaptionPanel : UiPanelBase
{
	// Token: 0x0600950F RID: 38159 RVA: 0x00202638 File Offset: 0x00200838
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnBackBtnClick))
		};
	}

	// Token: 0x06009510 RID: 38160 RVA: 0x002026E1 File Offset: 0x002008E1
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.ActivityRegressMainView, null);
	}

	// Token: 0x06009511 RID: 38161 RVA: 0x002026F4 File Offset: 0x002008F4
	public void RefreshData(RegressBase config)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, config.Title ?? "", Array.Empty<object>());
	}

	// Token: 0x02007ABC RID: 31420
	private class EActivityRecallCaptionPanelComponents
	{
		// Token: 0x0402861F RID: 165407
		public const int TitleIcon = 0;

		// Token: 0x04028620 RID: 165408
		public const int TitleTxt = 1;

		// Token: 0x04028621 RID: 165409
		public const int HelpInfoBtn = 2;

		// Token: 0x04028622 RID: 165410
		public const int BackBtn = 3;

		// Token: 0x04028623 RID: 165411
		public const int CostPanel = 4;
	}
}
