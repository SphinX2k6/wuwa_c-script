using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000744 RID: 1860
public class InviteNewbieRewardItem : UiPanelBase
{
	// Token: 0x06005583 RID: 21891 RVA: 0x001C19EC File Offset: 0x001BFBEC
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
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRewardButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06005584 RID: 21892 RVA: 0x001C1AB3 File Offset: 0x001BFCB3
	[NullableContext(1)]
	public void SetActivityData(InviteNewbieProtocolContext data)
	{
		this.CurrentData = data;
	}

	// Token: 0x06005585 RID: 21893 RVA: 0x001C1ABC File Offset: 0x001BFCBC
	private void OnClickRewardButton()
	{
		ActivityInviteNewbieController.Instance.HandleOnRewardClick(this.CurrentData);
	}

	// Token: 0x06005586 RID: 21894 RVA: 0x001C1ACE File Offset: 0x001BFCCE
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x06005587 RID: 21895 RVA: 0x001C1AE2 File Offset: 0x001BFCE2
	[NullableContext(1)]
	public void RefreshByDataExternal(string textId, string score)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, new <>z__ReadOnlySingleElementList<object>(score));
	}

	// Token: 0x04003B65 RID: 15205
	[Nullable(2)]
	private InviteNewbieProtocolContext CurrentData;

	// Token: 0x02006A31 RID: 27185
	private class EComponent
	{
		// Token: 0x04022F2A RID: 143146
		public const int ConfirmButton = 0;

		// Token: 0x04022F2B RID: 143147
		public const int ScoreText = 1;

		// Token: 0x04022F2C RID: 143148
		public const int RedDotItem = 2;
	}
}
