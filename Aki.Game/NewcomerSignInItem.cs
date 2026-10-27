using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013AE RID: 5038
[NullableContext(1)]
[Nullable(0)]
public class NewcomerSignInItem : GridProxyAbstract<OneItemConfig>
{
	// Token: 0x06008D8F RID: 36239 RVA: 0x001E812C File Offset: 0x001E632C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06008D90 RID: 36240 RVA: 0x001E82DC File Offset: 0x001E64DC
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerSignInItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerSignInItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008D91 RID: 36241 RVA: 0x001E8320 File Offset: 0x001E6520
	private void OnClickToggle(EToggleState toggleState)
	{
		ActivitySevenDaySignData activityData = this.ActivityData;
		if (((activityData != null) ? activityData.GetRewardStateByDay(base.GridIndex) : null).GetValueOrDefault() == SignState.Unlock)
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivityData.Id, base.GridIndex);
		}
	}

	// Token: 0x06008D92 RID: 36242 RVA: 0x001E8374 File Offset: 0x001E6574
	private void OnClickGrid()
	{
		ActivitySevenDaySignData activityData = this.ActivityData;
		if (((activityData != null) ? activityData.GetRewardStateByDay(base.GridIndex) : null).GetValueOrDefault() == SignState.Unlock)
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivityData.Id, base.GridIndex);
			return;
		}
		ActivitySignGrandReward? activitySignGrandReward;
		this.GrandRewardConfigMap.TryGetValue(base.GridIndex + 1, out activitySignGrandReward);
		if (activitySignGrandReward != null && activitySignGrandReward.Value.PreviewType == 1)
		{
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, activitySignGrandReward.Value.GetPreviewListArray().ToList<int>(), null, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null);
	}

	// Token: 0x06008D93 RID: 36243 RVA: 0x001E8437 File Offset: 0x001E6637
	private string GetRewardStateTextId(SignState state)
	{
		switch (state)
		{
		case SignState.Lock:
			return "NeedSign";
		case SignState.Unlock:
			return "CanGetReward";
		case SignState.IsReceive:
			return "CollectActivity_state_recived";
		default:
			return "NeedSign";
		}
	}

	// Token: 0x06008D94 RID: 36244 RVA: 0x001E8464 File Offset: 0x001E6664
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x06008D95 RID: 36245 RVA: 0x001E84B3 File Offset: 0x001E66B3
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textId, Array.Empty<object>());
	}

	// Token: 0x06008D96 RID: 36246 RVA: 0x001E84E4 File Offset: 0x001E66E4
	public override void Refresh(OneItemConfig data, bool isSelected, int gridIndex)
	{
		if (this.ActivityData == null)
		{
			return;
		}
		base.GridIndex = gridIndex;
		ActivitySevenDaySignData activityData = this.ActivityData;
		SignState valueOrDefault = ((activityData != null) ? activityData.GetRewardStateByDay(gridIndex) : null).GetValueOrDefault();
		this.ItemId = data.ItemId;
		this.SetDayText(gridIndex + 1);
		bool flag = valueOrDefault == SignState.IsReceive;
		bool flag2 = valueOrDefault == SignState.Unlock;
		this.CanGetReward = flag2;
		this.SetStateText(this.GetRewardStateTextId(valueOrDefault));
		base.GetItem(1).SetUIActive(!flag2);
		base.GetItem(4).SetUIActive(flag2);
		base.GetItem(8).SetUIActive(flag);
		base.GetItem(9).SetUIActive(flag2);
		TItem data2 = new TItem(new InventoryDefine.GetItemData(data.ItemId, 0), data.Count);
		CommonItemSmallItemGrid grid = this.Grid;
		if (grid != null)
		{
			grid.Refresh(data2);
		}
		CommonItemSmallItemGrid grid2 = this.Grid;
		if (grid2 != null)
		{
			grid2.SetReceivableVisible(flag2);
		}
		CommonItemSmallItemGrid grid3 = this.Grid;
		if (grid3 == null)
		{
			return;
		}
		grid3.SetReceivedVisible(flag);
	}

	// Token: 0x06008D97 RID: 36247 RVA: 0x001E85E3 File Offset: 0x001E67E3
	public void SetActivityData(ActivitySevenDaySignData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x06008D98 RID: 36248 RVA: 0x001E85EC File Offset: 0x001E67EC
	public void SetGrandRewardConfigMap(Dictionary<int, ActivitySignGrandReward?> grandRewardConfigMap)
	{
		this.GrandRewardConfigMap = grandRewardConfigMap;
	}

	// Token: 0x04003ED9 RID: 16089
	private CommonItemSmallItemGrid Grid;

	// Token: 0x04003EDA RID: 16090
	private ActivitySevenDaySignData ActivityData;

	// Token: 0x04003EDB RID: 16091
	protected bool CanGetReward;

	// Token: 0x04003EDC RID: 16092
	private int ItemId;

	// Token: 0x04003EDD RID: 16093
	private Dictionary<int, ActivitySignGrandReward?> GrandRewardConfigMap;

	// Token: 0x02007A21 RID: 31265
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402833F RID: 164671
		public const int Toggle = 0;

		// Token: 0x04028340 RID: 164672
		public const int StateNormalRoot = 1;

		// Token: 0x04028341 RID: 164673
		public const int NormalDayText = 2;

		// Token: 0x04028342 RID: 164674
		public const int StateText = 3;

		// Token: 0x04028343 RID: 164675
		public const int StateGetItem = 4;

		// Token: 0x04028344 RID: 164676
		public const int GetDayText = 5;

		// Token: 0x04028345 RID: 164677
		public const int GetStateText = 6;

		// Token: 0x04028346 RID: 164678
		public const int PropItem = 7;

		// Token: 0x04028347 RID: 164679
		public const int FinishMask = 8;

		// Token: 0x04028348 RID: 164680
		public const int RedDotItem = 9;
	}
}
