using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001D16 RID: 7446
public class SpringManorQuestButton : UiPanelBase
{
	// Token: 0x0600E131 RID: 57649 RVA: 0x0034D73C File Offset: 0x0034B93C
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

	// Token: 0x0600E132 RID: 57650 RVA: 0x0034D7A3 File Offset: 0x0034B9A3
	private void OnClickButton()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x0600E133 RID: 57651 RVA: 0x0034D7B8 File Offset: 0x0034B9B8
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

	// Token: 0x040067FE RID: 26622
	[Nullable(2)]
	public Action ClickCallback;

	// Token: 0x02008306 RID: 33542
	private static class ESpringManorQuestButton
	{
		// Token: 0x0402ABCB RID: 175051
		public const int Button = 0;

		// Token: 0x0402ABCC RID: 175052
		public const int RedDot = 1;
	}
}
