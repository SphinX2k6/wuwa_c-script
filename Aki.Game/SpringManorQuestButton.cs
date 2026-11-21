using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020011D8 RID: 4568
public class SpringManorQuestButton : UiPanelBase
{
	// Token: 0x0600B54E RID: 46414 RVA: 0x0035916C File Offset: 0x0035736C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickButton))
		};
	}

	// Token: 0x0600B54F RID: 46415 RVA: 0x003591D3 File Offset: 0x003573D3
	private void OnClickButton()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x0600B550 RID: 46416 RVA: 0x003591E8 File Offset: 0x003573E8
	public void RefreshRedDot()
	{
		SpringManorModel instance = SpringManorModel.Instance;
		bool uiactive = instance != null && instance.ActivityData.HasAnySubQuestRedDot();
		UUIItem item = base.GetItem(1);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(uiactive);
	}

	// Token: 0x040068DD RID: 26845
	[Nullable(2)]
	public Action ClickCallback;

	// Token: 0x0200748F RID: 29839
	private static class ESpringManorQuestButton
	{
		// Token: 0x04025EF3 RID: 155379
		public const int Button = 0;

		// Token: 0x04025EF4 RID: 155380
		public const int RedDot = 1;
	}
}
