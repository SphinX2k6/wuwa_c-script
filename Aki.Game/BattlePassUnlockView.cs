using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002338 RID: 9016
public class BattlePassUnlockView : UiViewBase
{
	// Token: 0x06011D98 RID: 73112 RVA: 0x00465BFC File Offset: 0x00463DFC
	[NullableContext(1)]
	public BattlePassUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011D99 RID: 73113 RVA: 0x00465C10 File Offset: 0x00463E10
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnBtnClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06011D9A RID: 73114 RVA: 0x00465D3A File Offset: 0x00463F3A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06011D9B RID: 73115 RVA: 0x00465D58 File Offset: 0x00463F58
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x06011D9C RID: 73116 RVA: 0x00465D76 File Offset: 0x00463F76
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x06011D9D RID: 73117 RVA: 0x00465D80 File Offset: 0x00463F80
	protected override void OnStart()
	{
		EBattlePassUnlockType ebattlePassUnlockType = (EBattlePassUnlockType)this.OpenParam;
		this.RewardList = new List<TItem>();
		BattlePassConfig.Instance.GetBattlePassUnlockReward(ebattlePassUnlockType, this.RewardList);
		this.RewardGridView = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(0), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, true);
		this.RewardGridView.RefreshByData(this.RewardList, null, false);
		BattlePassUnlockPop value = BattlePassConfig.Instance.GetBattlePassUnlock((int)ebattlePassUnlockType).Value;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), value.UnlockTitle, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), value.UnlockText, Array.Empty<object>());
		base.GetItem(2).SetUIActive(ebattlePassUnlockType == EBattlePassUnlockType.Primary);
		base.GetItem(3).SetUIActive(ebattlePassUnlockType != EBattlePassUnlockType.Primary);
	}

	// Token: 0x06011D9E RID: 73118 RVA: 0x00465E5A File Offset: 0x0046405A
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x06011D9F RID: 73119 RVA: 0x00465E64 File Offset: 0x00464064
	protected override void OnBeforeDestroy()
	{
		this.RewardList.Clear();
		this.RewardList = null;
		this.RewardGridView = null;
		if ((EBattlePassUnlockType)this.OpenParam == EBattlePassUnlockType.Primary)
		{
			EventSystem.Instance.Emit(EEventName.BattlePassFirstUnlockAnime);
			return;
		}
		BattlePassController.Instance.PopHighUnlockReward();
	}

	// Token: 0x06011DA0 RID: 73120 RVA: 0x00465EB3 File Offset: 0x004640B3
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x04008748 RID: 34632
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardGridView;

	// Token: 0x04008749 RID: 34633
	[Nullable(2)]
	private List<TItem> RewardList = new List<TItem>();

	// Token: 0x020088BE RID: 35006
	private enum EComponents
	{
		// Token: 0x0402C70D RID: 182029
		ItemGrid,
		// Token: 0x0402C70E RID: 182030
		TxtTitle,
		// Token: 0x0402C70F RID: 182031
		PrimaryPic,
		// Token: 0x0402C710 RID: 182032
		HighPic,
		// Token: 0x0402C711 RID: 182033
		BtnClose,
		// Token: 0x0402C712 RID: 182034
		TxtTip
	}
}
