using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020015E0 RID: 5600
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerSettlementBossResultPanel : UiPanelBase
{
	// Token: 0x06009E52 RID: 40530 RVA: 0x00228490 File Offset: 0x00226690
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009E53 RID: 40531 RVA: 0x002284F9 File Offset: 0x002266F9
	protected override void OnStart()
	{
		this.BossScrollView = new GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerSettlementBossItem>(this.CreateBossItem), null, false, null);
	}

	// Token: 0x06009E54 RID: 40532 RVA: 0x0022851C File Offset: 0x0022671C
	public void Refresh(List<IBossItemData> bossList)
	{
		GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView == null)
		{
			return;
		}
		bossScrollView.RefreshByData(bossList, null, true);
	}

	// Token: 0x06009E55 RID: 40533 RVA: 0x00228531 File Offset: 0x00226731
	public void SetBossScrollEnable(bool canScroll)
	{
		GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView == null)
		{
			return;
		}
		bossScrollView.SetVerticalScrollEnable(canScroll);
	}

	// Token: 0x06009E56 RID: 40534 RVA: 0x00228544 File Offset: 0x00226744
	private WheelTowerSettlementBossItem CreateBossItem()
	{
		return new WheelTowerSettlementBossItem();
	}

	// Token: 0x0400468D RID: 18061
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> BossScrollView;
}
