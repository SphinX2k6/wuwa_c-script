using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002351 RID: 9041
internal class GetItemPanel : UiPanelBase
{
	// Token: 0x0601200B RID: 73739 RVA: 0x0046A1A8 File Offset: 0x004683A8
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

	// Token: 0x0601200C RID: 73740 RVA: 0x0046A26F File Offset: 0x0046846F
	protected override void OnStart()
	{
		base.GetTexture(1).SetUIActive(false);
	}

	// Token: 0x0601200D RID: 73741 RVA: 0x0046A27E File Offset: 0x0046847E
	private void OnItemButtonClick()
	{
		if (this.ItemId == 0)
		{
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
	}

	// Token: 0x0601200E RID: 73742 RVA: 0x0046A29C File Offset: 0x0046849C
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

	// Token: 0x040087F7 RID: 34807
	private int ItemId;

	// Token: 0x020088D0 RID: 35024
	private enum EGetItemPanelComponents
	{
		// Token: 0x0402C780 RID: 182144
		ButtonReward,
		// Token: 0x0402C781 RID: 182145
		TextureIcon,
		// Token: 0x0402C782 RID: 182146
		TextNum
	}
}
