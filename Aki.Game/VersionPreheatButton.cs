using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A2E RID: 2606
public class VersionPreheatButton : UiPanelBase
{
	// Token: 0x060070FD RID: 28925 RVA: 0x0022A454 File Offset: 0x00228654
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

	// Token: 0x060070FE RID: 28926 RVA: 0x0022A51B File Offset: 0x0022871B
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "Text_RoleQuestGoto_Text", Array.Empty<object>());
	}

	// Token: 0x060070FF RID: 28927 RVA: 0x0022A54B File Offset: 0x0022874B
	private void HandleOnClick()
	{
		if (this.ClickRewardFunc != null && this.ClickRewardPassData != null)
		{
			this.ClickRewardFunc(this.ClickRewardPassData.Value);
		}
	}

	// Token: 0x04004598 RID: 17816
	[Nullable(1)]
	public TVersionPreheatQuestDetailClickFunc ClickRewardFunc;

	// Token: 0x04004599 RID: 17817
	public int? ClickRewardPassData;

	// Token: 0x02006D32 RID: 27954
	private class EButtonComponent
	{
		// Token: 0x04023DAF RID: 146863
		public const int RootButton = 0;

		// Token: 0x04023DB0 RID: 146864
		public const int ConfirmText = 1;

		// Token: 0x04023DB1 RID: 146865
		public const int RedDotItem = 2;
	}
}
