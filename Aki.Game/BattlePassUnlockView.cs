using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200181D RID: 6173
public class BattlePassUnlockView : UiViewBase
{
	// Token: 0x0600F248 RID: 62024 RVA: 0x00472CC4 File Offset: 0x00470EC4
	[NullableContext(1)]
	public BattlePassUnlockView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F249 RID: 62025 RVA: 0x00472CD8 File Offset: 0x00470ED8
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

	// Token: 0x0600F24A RID: 62026 RVA: 0x00472E02 File Offset: 0x00471002
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x0600F24B RID: 62027 RVA: 0x00472E20 File Offset: 0x00471020
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.BattlePassMainViewHide, new Action(this.OnMainViewHide));
	}

	// Token: 0x0600F24C RID: 62028 RVA: 0x00472E3E File Offset: 0x0047103E
	private void OnMainViewHide()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600F24D RID: 62029 RVA: 0x00472E48 File Offset: 0x00471048
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

	// Token: 0x0600F24E RID: 62030 RVA: 0x00472F22 File Offset: 0x00471122
	[NullableContext(1)]
	private CommonItemSmallItemGrid CreateRewardItem()
	{
		return new CommonItemSmallItemGrid();
	}

	// Token: 0x0600F24F RID: 62031 RVA: 0x00472F2C File Offset: 0x0047112C
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

	// Token: 0x0600F250 RID: 62032 RVA: 0x00472F7B File Offset: 0x0047117B
	private void OnBtnClose()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400888B RID: 34955
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardGridView;

	// Token: 0x0400888C RID: 34956
	[Nullable(2)]
	private List<TItem> RewardList = new List<TItem>();

	// Token: 0x02007A47 RID: 31303
	private enum EComponents
	{
		// Token: 0x04027A21 RID: 162337
		ItemGrid,
		// Token: 0x04027A22 RID: 162338
		TxtTitle,
		// Token: 0x04027A23 RID: 162339
		PrimaryPic,
		// Token: 0x04027A24 RID: 162340
		HighPic,
		// Token: 0x04027A25 RID: 162341
		BtnClose,
		// Token: 0x04027A26 RID: 162342
		TxtTip
	}
}
