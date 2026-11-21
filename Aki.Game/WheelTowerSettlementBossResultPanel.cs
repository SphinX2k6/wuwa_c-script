using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000A98 RID: 2712
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerSettlementBossResultPanel : UiPanelBase
{
	// Token: 0x06007230 RID: 29232 RVA: 0x00232244 File Offset: 0x00230444
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

	// Token: 0x06007231 RID: 29233 RVA: 0x002322AD File Offset: 0x002304AD
	protected override void OnStart()
	{
		this.BossScrollView = new GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData>(base.GetScrollViewWithScrollbar(0), new Func<WheelTowerSettlementBossItem>(this.CreateBossItem), null, false, null);
	}

	// Token: 0x06007232 RID: 29234 RVA: 0x002322D0 File Offset: 0x002304D0
	public void Refresh(List<IBossItemData> bossList)
	{
		GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView == null)
		{
			return;
		}
		bossScrollView.RefreshByData(bossList, null, true);
	}

	// Token: 0x06007233 RID: 29235 RVA: 0x002322E5 File Offset: 0x002304E5
	public void SetBossScrollEnable(bool canScroll)
	{
		GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> bossScrollView = this.BossScrollView;
		if (bossScrollView == null)
		{
			return;
		}
		bossScrollView.SetVerticalScrollEnable(canScroll);
	}

	// Token: 0x06007234 RID: 29236 RVA: 0x002322F8 File Offset: 0x002304F8
	private WheelTowerSettlementBossItem CreateBossItem()
	{
		return new WheelTowerSettlementBossItem();
	}

	// Token: 0x04004733 RID: 18227
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<WheelTowerSettlementBossItem, IBossItemData> BossScrollView;
}
