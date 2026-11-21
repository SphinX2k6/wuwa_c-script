using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000942 RID: 2370
public class ActivityRecallCaptionPanel : UiPanelBase
{
	// Token: 0x060068A4 RID: 26788 RVA: 0x0020B5A0 File Offset: 0x002097A0
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

	// Token: 0x060068A5 RID: 26789 RVA: 0x0020B649 File Offset: 0x00209849
	private void OnBackBtnClick()
	{
		UiManager.Instance.CloseView(EUiViewName.ActivityRegressMainView, null);
	}

	// Token: 0x060068A6 RID: 26790 RVA: 0x0020B65C File Offset: 0x0020985C
	public void RefreshData(RegressBase config)
	{
		UUIText text = base.GetText(1);
		LguiUtil.Instance.SetLocalTextNew(text, config.Title ?? "", Array.Empty<object>());
	}

	// Token: 0x02006C40 RID: 27712
	private class EActivityRecallCaptionPanelComponents
	{
		// Token: 0x04023939 RID: 145721
		public const int TitleIcon = 0;

		// Token: 0x0402393A RID: 145722
		public const int TitleTxt = 1;

		// Token: 0x0402393B RID: 145723
		public const int HelpInfoBtn = 2;

		// Token: 0x0402393C RID: 145724
		public const int BackBtn = 3;

		// Token: 0x0402393D RID: 145725
		public const int CostPanel = 4;
	}
}
