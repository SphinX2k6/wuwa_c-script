using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x0200112E RID: 4398
[NullableContext(2)]
[Nullable(0)]
public class GachaAccumulateStageBigRewardPanel : UiPanelBase
{
	// Token: 0x0600AF71 RID: 44913 RVA: 0x0033B4D8 File Offset: 0x003396D8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600AF72 RID: 44914 RVA: 0x0033B564 File Offset: 0x00339764
	protected override void OnStart()
	{
		this.ItemGrid = new CommonItemSmallItemGrid();
		this.ItemGrid.CreateThenShowByActor(base.GetItem(1).GetOwner());
		this.ItemGrid.SetAllowClickBack(false);
		this.ItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnClickPanel();
		});
		this.ItemGrid.ShowReceivedCallBack = delegate(TItem _)
		{
			GachaAccumulateRewardData currentReward = this.CurrentReward;
			return currentReward != null && currentReward.Status == EGachaAccumulateRewardStatus.Claimed;
		};
		this.ItemGrid.ShowReceivableCallBack = delegate(TItem _)
		{
			GachaAccumulateRewardData currentReward = this.CurrentReward;
			return currentReward != null && currentReward.Status == EGachaAccumulateRewardStatus.CanClaim;
		};
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickPanel));
	}

	// Token: 0x0600AF73 RID: 44915 RVA: 0x0033B620 File Offset: 0x00339820
	protected override void OnBeforeDestroy()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChange));
		}
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.OnUndeterminedClicked.Remove(new Action(this.OnClickPanel));
	}

	// Token: 0x0600AF74 RID: 44916 RVA: 0x0033B674 File Offset: 0x00339874
	public void Refresh(int accumulateId, GachaAccumulateRewardData reward)
	{
		this.AccumulateId = accumulateId;
		this.CurrentReward = reward;
		if (reward == null)
		{
			base.SetUiActive(false);
			return;
		}
		base.SetUiActive(true);
		RewardItemData rewardItemData = reward.GetRewardItemList()[0];
		TItem data = new TItem
		{
			ItemData = new InventoryDefine.GetItemData(rewardItemData.ConfigId, 0),
			Count = rewardItemData.Count
		};
		this.ItemGrid.Refresh(data);
		this.ItemGrid.SetRedDotVisible(new bool?(reward.Status == EGachaAccumulateRewardStatus.CanClaim));
		if (reward.Status == EGachaAccumulateRewardStatus.Claimed)
		{
			this.ItemGrid.SetReceivedColor("eae4ab");
		}
		base.GetText(2).SetText(reward.GachaNum.ToString(), true);
	}

	// Token: 0x0600AF75 RID: 44917 RVA: 0x0033B72A File Offset: 0x0033992A
	private void OnToggleStateChange(EToggleState _)
	{
		this.OnClickPanel();
	}

	// Token: 0x0600AF76 RID: 44918 RVA: 0x0033B734 File Offset: 0x00339934
	private void OnClickPanel()
	{
		if (this.CurrentReward == null)
		{
			return;
		}
		if (this.CurrentReward.Status != EGachaAccumulateRewardStatus.CanClaim)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CurrentReward.GetRewardItemList()[0].ConfigId, true, null, false);
			return;
		}
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(this.AccumulateId);
		if (accumulateData == null)
		{
			return;
		}
		List<int> list = accumulateData.CollectAllClaimableRewardIds();
		GachaAccumulateController.Instance.ClaimAccumulateRewardAsync(this.AccumulateId, list.ToArray(), Array.Empty<int>()).Forget<bool>();
	}

	// Token: 0x0400655C RID: 25948
	[Nullable(1)]
	private const string ReceivedCheckColor = "eae4ab";

	// Token: 0x0400655D RID: 25949
	private CommonItemSmallItemGrid ItemGrid;

	// Token: 0x0400655E RID: 25950
	private int AccumulateId;

	// Token: 0x0400655F RID: 25951
	private GachaAccumulateRewardData CurrentReward;
}
