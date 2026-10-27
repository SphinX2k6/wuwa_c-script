using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001290 RID: 4752
public class InviteNewbieRewardItem : UiPanelBase
{
	// Token: 0x060081EC RID: 33260 RVA: 0x001B8D1C File Offset: 0x001B6F1C
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

	// Token: 0x060081ED RID: 33261 RVA: 0x001B8DE3 File Offset: 0x001B6FE3
	[NullableContext(1)]
	public void SetActivityData(InviteNewbieProtocolContext data)
	{
		this.CurrentData = data;
	}

	// Token: 0x060081EE RID: 33262 RVA: 0x001B8DEC File Offset: 0x001B6FEC
	private void OnClickRewardButton()
	{
		ActivityInviteNewbieController.Instance.HandleOnRewardClick(this.CurrentData);
	}

	// Token: 0x060081EF RID: 33263 RVA: 0x001B8DFE File Offset: 0x001B6FFE
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060081F0 RID: 33264 RVA: 0x001B8E12 File Offset: 0x001B7012
	[NullableContext(1)]
	public void RefreshByDataExternal(string textId, string score)
	{
		LguiUtil.Instance.TrySetLocalTextNew(base.GetText(1), textId, new <>z__ReadOnlySingleElementList<object>(score));
	}

	// Token: 0x04003ACD RID: 15053
	[Nullable(2)]
	private InviteNewbieProtocolContext CurrentData;

	// Token: 0x020078A6 RID: 30886
	private class EComponent
	{
		// Token: 0x04027BF9 RID: 162809
		public const int ConfirmButton = 0;

		// Token: 0x04027BFA RID: 162810
		public const int ScoreText = 1;

		// Token: 0x04027BFB RID: 162811
		public const int RedDotItem = 2;
	}
}
