using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001AE7 RID: 6887
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PowerItem : GridProxyAbstract<PowerItemInfo>
{
	// Token: 0x06011181 RID: 70017 RVA: 0x00505524 File Offset: 0x00503724
	public PowerItem(UUIItem uiItem)
	{
		this.CreateThenShowByActor(uiItem.GetOwner());
	}

	// Token: 0x06011182 RID: 70018 RVA: 0x00505538 File Offset: 0x00503738
	public override void Refresh(PowerItemInfo data, bool isSelected, int gridIndex)
	{
		this.ItemInfo = data;
		base.GetText(10).text = data.StackValue.ToString();
		if (data.CostValue > data.StackValue)
		{
			base.GetText(10).SetColor(PowerItem.CoinNotEnoughColor);
		}
		base.GetSprite(7).SetActive(false, false);
		base.GetItem(9).SetActive(false, false);
		base.GetItem(5).SetActive(false, false);
		base.SetItemIcon(base.GetTexture(3), data.ItemId, null, null);
	}

	// Token: 0x06011183 RID: 70019 RVA: 0x005055CC File Offset: 0x005037CC
	public void SetClickCallback(Action<PowerItemInfo> toggleFunction)
	{
		this.ClickCallback = toggleFunction;
	}

	// Token: 0x06011184 RID: 70020 RVA: 0x005055D8 File Offset: 0x005037D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011185 RID: 70021 RVA: 0x005057AA File Offset: 0x005039AA
	private void ToggleClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			Action<PowerItemInfo> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.ItemInfo);
		}
	}

	// Token: 0x06011186 RID: 70022 RVA: 0x005057C6 File Offset: 0x005039C6
	public void SetIntoToggleGroup(UUIItem group)
	{
		base.GetExtendToggle(0).SetToggleGroup(group.GetOwner());
	}

	// Token: 0x04009672 RID: 38514
	[StaticVariableRuleIgnore]
	private static readonly FColor CoinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x04009673 RID: 38515
	private PowerItemInfo ItemInfo;

	// Token: 0x04009674 RID: 38516
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PowerItemInfo> ClickCallback;

	// Token: 0x02007DB7 RID: 32183
	[NullableContext(0)]
	private enum EPowerItem
	{
		// Token: 0x04028B39 RID: 166713
		Item1,
		// Token: 0x04028B3A RID: 166714
		Item2,
		// Token: 0x04028B3B RID: 166715
		Item3,
		// Token: 0x04028B3C RID: 166716
		ImageIcon,
		// Token: 0x04028B3D RID: 166717
		ImageQuality,
		// Token: 0x04028B3E RID: 166718
		Lock,
		// Token: 0x04028B3F RID: 166719
		IconRole,
		// Token: 0x04028B40 RID: 166720
		ImageRoleBg,
		// Token: 0x04028B41 RID: 166721
		TextLevel,
		// Token: 0x04028B42 RID: 166722
		Stage,
		// Token: 0x04028B43 RID: 166723
		TextNumber
	}
}
