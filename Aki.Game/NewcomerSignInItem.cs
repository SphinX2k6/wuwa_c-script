using System;
using System.Collections.Generic;
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

// Token: 0x02000862 RID: 2146
[NullableContext(1)]
[Nullable(0)]
public class NewcomerSignInItem : GridProxyAbstract<OneItemConfig>
{
	// Token: 0x06006125 RID: 24869 RVA: 0x001F0D7C File Offset: 0x001EEF7C
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

	// Token: 0x06006126 RID: 24870 RVA: 0x001F0F2C File Offset: 0x001EF12C
	protected override UniTask OnBeforeStartAsync()
	{
		NewcomerSignInItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewcomerSignInItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006127 RID: 24871 RVA: 0x001F0F70 File Offset: 0x001EF170
	private void OnClickToggle(EToggleState toggleState)
	{
		ActivitySevenDaySignData activityData = this.ActivityData;
		if (((activityData != null) ? activityData.GetRewardStateByDay(base.GridIndex) : null).GetValueOrDefault() == SignState.Unlock)
		{
			ActivitySevenDaySignController.Instance.GetRewardByDay(this.ActivityData.Id, base.GridIndex);
		}
	}

	// Token: 0x06006128 RID: 24872 RVA: 0x001F0FC4 File Offset: 0x001EF1C4
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
			RoleController.Instance.OpenRoleMainView(ERoleAgentType.Preview, 0, new List<int>(activitySignGrandReward.Value.GetPreviewListArray()), null, null);
			return;
		}
		ItemController.Instance.OpenItemTipsByItemId(this.ItemId, true, null, false);
	}

	// Token: 0x06006129 RID: 24873 RVA: 0x001F1088 File Offset: 0x001EF288
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

	// Token: 0x0600612A RID: 24874 RVA: 0x001F10B8 File Offset: 0x001EF2B8
	public void SetDayText(int day)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "DayNum", new <>z__ReadOnlySingleElementList<object>(day));
	}

	// Token: 0x0600612B RID: 24875 RVA: 0x001F1107 File Offset: 0x001EF307
	public void SetStateText(string textId)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textId, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(6), textId, Array.Empty<object>());
	}

	// Token: 0x0600612C RID: 24876 RVA: 0x001F1138 File Offset: 0x001EF338
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

	// Token: 0x0600612D RID: 24877 RVA: 0x001F1237 File Offset: 0x001EF437
	public void SetActivityData(ActivitySevenDaySignData data)
	{
		this.ActivityData = data;
	}

	// Token: 0x0600612E RID: 24878 RVA: 0x001F1240 File Offset: 0x001EF440
	public void SetGrandRewardConfigMap(Dictionary<int, ActivitySignGrandReward?> grandRewardConfigMap)
	{
		this.GrandRewardConfigMap = grandRewardConfigMap;
	}

	// Token: 0x04003F71 RID: 16241
	private CommonItemSmallItemGrid Grid;

	// Token: 0x04003F72 RID: 16242
	private ActivitySevenDaySignData ActivityData;

	// Token: 0x04003F73 RID: 16243
	protected bool CanGetReward;

	// Token: 0x04003F74 RID: 16244
	private int ItemId;

	// Token: 0x04003F75 RID: 16245
	private Dictionary<int, ActivitySignGrandReward?> GrandRewardConfigMap;

	// Token: 0x02006BA7 RID: 27559
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402365C RID: 144988
		public const int Toggle = 0;

		// Token: 0x0402365D RID: 144989
		public const int StateNormalRoot = 1;

		// Token: 0x0402365E RID: 144990
		public const int NormalDayText = 2;

		// Token: 0x0402365F RID: 144991
		public const int StateText = 3;

		// Token: 0x04023660 RID: 144992
		public const int StateGetItem = 4;

		// Token: 0x04023661 RID: 144993
		public const int GetDayText = 5;

		// Token: 0x04023662 RID: 144994
		public const int GetStateText = 6;

		// Token: 0x04023663 RID: 144995
		public const int PropItem = 7;

		// Token: 0x04023664 RID: 144996
		public const int FinishMask = 8;

		// Token: 0x04023665 RID: 144997
		public const int RedDotItem = 9;
	}
}
