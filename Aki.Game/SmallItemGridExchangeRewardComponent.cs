using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

// Token: 0x02001979 RID: 6521
public class SmallItemGridExchangeRewardComponent : SmallItemGridVisibleComponent
{
	// Token: 0x0600BEE6 RID: 48870 RVA: 0x002B2EEB File Offset: 0x002B10EB
	[NullableContext(2)]
	protected override string GetResourceId()
	{
		return "UiItem_ItemBFirstReward";
	}

	// Token: 0x0600BEE7 RID: 48871 RVA: 0x002B2EF4 File Offset: 0x002B10F4
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

	// Token: 0x0600BEE8 RID: 48872 RVA: 0x002B2F5D File Offset: 0x002B115D
	protected override void OnStart()
	{
		base.GetSprite(1).SetColor(FColor.FromHex("#468fba"));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "InstanceDungeon_ExchangeReward", Array.Empty<object>());
	}

	// Token: 0x02007EC5 RID: 32453
	private enum EComponents
	{
		// Token: 0x04029703 RID: 169731
		TxtContent,
		// Token: 0x04029704 RID: 169732
		SpriteBg
	}
}
