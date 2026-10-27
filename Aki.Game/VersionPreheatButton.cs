using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001576 RID: 5494
public class VersionPreheatButton : UiPanelBase
{
	// Token: 0x06009D1F RID: 40223 RVA: 0x002206A4 File Offset: 0x0021E8A4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.HandleOnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009D20 RID: 40224 RVA: 0x0022076B File Offset: 0x0021E96B
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_RoleQuestGoto_Text", Array.Empty<object>());
	}

	// Token: 0x06009D21 RID: 40225 RVA: 0x0022079B File Offset: 0x0021E99B
	private void HandleOnClick()
	{
		if (this.ClickRewardFunc != null && this.ClickRewardPassData != null)
		{
			this.ClickRewardFunc(this.ClickRewardPassData.Value);
		}
	}

	// Token: 0x040044F2 RID: 17650
	[Nullable(1)]
	public TVersionPreheatQuestDetailClickFunc ClickRewardFunc;

	// Token: 0x040044F3 RID: 17651
	public int? ClickRewardPassData;

	// Token: 0x02007BA7 RID: 31655
	private class EButtonComponent
	{
		// Token: 0x04028A74 RID: 166516
		public const int RootButton = 0;

		// Token: 0x04028A75 RID: 166517
		public const int ConfirmText = 1;

		// Token: 0x04028A76 RID: 166518
		public const int RedDotItem = 2;
	}
}
