using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02000E36 RID: 3638
public class SmallItemGridExchangeRewardComponent : SmallItemGridVisibleComponent
{
	// Token: 0x060092EE RID: 37614 RVA: 0x002BDE6F File Offset: 0x002BC06F
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBFirstReward";
	}

	// Token: 0x060092EF RID: 37615 RVA: 0x002BDE78 File Offset: 0x002BC078
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x060092F0 RID: 37616 RVA: 0x002BDEE1 File Offset: 0x002BC0E1
	protected override void OnStart()
	{
		base.GetSprite(1).SetColor(FColor.FromHex("#468fba"));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "InstanceDungeon_ExchangeReward", Array.Empty<object>());
	}

	// Token: 0x02007054 RID: 28756
	private enum EComponents
	{
		// Token: 0x04024A40 RID: 150080
		TxtContent,
		// Token: 0x04024A41 RID: 150081
		SpriteBg
	}
}
