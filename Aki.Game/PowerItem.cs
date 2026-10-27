using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020025FC RID: 9724
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class PowerItem : GridProxyAbstract<PowerItemInfo>
{
	// Token: 0x06013C9F RID: 81055 RVA: 0x004F6790 File Offset: 0x004F4990
	public PowerItem(UUIItem uiItem)
	{
		this.CreateThenShowByActor(uiItem.GetOwner());
	}

	// Token: 0x06013CA0 RID: 81056 RVA: 0x004F67A4 File Offset: 0x004F49A4
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

	// Token: 0x06013CA1 RID: 81057 RVA: 0x004F6838 File Offset: 0x004F4A38
	public void SetClickCallback(Action<PowerItemInfo> toggleFunction)
	{
		this.ClickCallback = toggleFunction;
	}

	// Token: 0x06013CA2 RID: 81058 RVA: 0x004F6844 File Offset: 0x004F4A44
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

	// Token: 0x06013CA3 RID: 81059 RVA: 0x004F6A16 File Offset: 0x004F4C16
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

	// Token: 0x06013CA4 RID: 81060 RVA: 0x004F6A32 File Offset: 0x004F4C32
	public void SetIntoToggleGroup(UUIItem group)
	{
		base.GetExtendToggle(0).SetToggleGroup(group.GetOwner());
	}

	// Token: 0x0400951B RID: 38171
	[StaticVariableRuleIgnore]
	private static readonly FColor CoinNotEnoughColor = FColor.FromHex("9D2437FF");

	// Token: 0x0400951C RID: 38172
	private PowerItemInfo ItemInfo;

	// Token: 0x0400951D RID: 38173
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Action<PowerItemInfo> ClickCallback;

	// Token: 0x02008C2E RID: 35886
	[NullableContext(0)]
	private enum EPowerItem
	{
		// Token: 0x0402D821 RID: 186401
		Item1,
		// Token: 0x0402D822 RID: 186402
		Item2,
		// Token: 0x0402D823 RID: 186403
		Item3,
		// Token: 0x0402D824 RID: 186404
		ImageIcon,
		// Token: 0x0402D825 RID: 186405
		ImageQuality,
		// Token: 0x0402D826 RID: 186406
		Lock,
		// Token: 0x0402D827 RID: 186407
		IconRole,
		// Token: 0x0402D828 RID: 186408
		ImageRoleBg,
		// Token: 0x0402D829 RID: 186409
		TextLevel,
		// Token: 0x0402D82A RID: 186410
		Stage,
		// Token: 0x0402D82B RID: 186411
		TextNumber
	}
}
