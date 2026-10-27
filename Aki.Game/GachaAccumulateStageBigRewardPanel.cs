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

// Token: 0x02001C6F RID: 7279
[NullableContext(2)]
[Nullable(0)]
public class GachaAccumulateStageBigRewardPanel : UiPanelBase
{
	// Token: 0x0600DB5B RID: 56155 RVA: 0x0033008C File Offset: 0x0032E28C
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

	// Token: 0x0600DB5C RID: 56156 RVA: 0x00330118 File Offset: 0x0032E318
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

	// Token: 0x0600DB5D RID: 56157 RVA: 0x003301D4 File Offset: 0x0032E3D4
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

	// Token: 0x0600DB5E RID: 56158 RVA: 0x00330228 File Offset: 0x0032E428
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

	// Token: 0x0600DB5F RID: 56159 RVA: 0x003302DE File Offset: 0x0032E4DE
	private void OnToggleStateChange(EToggleState _)
	{
		this.OnClickPanel();
	}

	// Token: 0x0600DB60 RID: 56160 RVA: 0x003302E8 File Offset: 0x0032E4E8
	private void OnClickPanel()
	{
		if (this.CurrentReward == null)
		{
			return;
		}
		if (this.CurrentReward.Status != EGachaAccumulateRewardStatus.CanClaim)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.CurrentReward.GetRewardItemList()[0].ConfigId, true, null);
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

	// Token: 0x0400648A RID: 25738
	[Nullable(1)]
	private const string ReceivedCheckColor = "eae4ab";

	// Token: 0x0400648B RID: 25739
	private CommonItemSmallItemGrid ItemGrid;

	// Token: 0x0400648C RID: 25740
	private int AccumulateId;

	// Token: 0x0400648D RID: 25741
	private GachaAccumulateRewardData CurrentReward;
}
