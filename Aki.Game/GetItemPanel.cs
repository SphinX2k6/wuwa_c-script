using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001836 RID: 6198
internal class GetItemPanel : UiPanelBase
{
	// Token: 0x0600F4BB RID: 62651 RVA: 0x00477270 File Offset: 0x00475470
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnItemButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600F4BC RID: 62652 RVA: 0x00477337 File Offset: 0x00475537
	protected override void OnStart()
	{
		base.GetTexture(1).SetUIActive(false);
	}

	// Token: 0x0600F4BD RID: 62653 RVA: 0x00477346 File Offset: 0x00475546
	private void OnItemButtonClick()
	{
		if (this.ItemId == 0)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
	}

	// Token: 0x0600F4BE RID: 62654 RVA: 0x00477364 File Offset: 0x00475564
	public void Refresh(int itemId, int count)
	{
		this.ItemId = itemId;
		UUITexture textureIcon = base.GetTexture(1);
		base.SetItemIcon(textureIcon, itemId, null, delegate(bool _)
		{
			textureIcon.SetUIActive(true);
		});
		UUIText text = base.GetText(2);
		LguiUtil.Instance.SetLocalTextNew(text, "Text_RoleCount_Text", new <>z__ReadOnlySingleElementList<object>(count.ToString()));
	}

	// Token: 0x0400893A RID: 35130
	private int ItemId;

	// Token: 0x02007A59 RID: 31321
	private enum EGetItemPanelComponents
	{
		// Token: 0x04027A94 RID: 162452
		ButtonReward,
		// Token: 0x04027A95 RID: 162453
		TextureIcon,
		// Token: 0x04027A96 RID: 162454
		TextNum
	}
}
