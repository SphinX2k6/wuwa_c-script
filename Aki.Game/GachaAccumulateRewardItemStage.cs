using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001C6D RID: 7277
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class GachaAccumulateRewardItemStage : GridProxyAbstract<GachaAccumulateRewardItemStageData>
{
	// Token: 0x0600DB4F RID: 56143 RVA: 0x0032FC50 File Offset: 0x0032DE50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600DB50 RID: 56144 RVA: 0x0032FD40 File Offset: 0x0032DF40
	protected override void OnStart()
	{
		this.CommonItemGrid = new CommonItemSmallItemGrid();
		this.CommonItemGrid.CreateThenShowByActor(base.GetItem(3).GetOwner());
		this.CommonItemGrid.SetAllowClickBack(false);
		this.CommonItemGrid.BindOnExtendToggleClicked(delegate(MediumItemGridExtendCallback _)
		{
			this.OnClickButton();
		});
		this.CommonItemGrid.ShowReceivedCallBack = delegate(TItem _)
		{
			GachaAccumulateRewardItemStageData data = this.Data;
			if (data == null)
			{
				return false;
			}
			GachaAccumulateRewardData data2 = data.Data;
			return ((data2 != null) ? new EGachaAccumulateRewardStatus?(data2.Status) : null).GetValueOrDefault() == EGachaAccumulateRewardStatus.Claimed;
		};
		this.CommonItemGrid.ShowReceivableCallBack = delegate(TItem _)
		{
			GachaAccumulateRewardItemStageData data = this.Data;
			if (data == null)
			{
				return false;
			}
			GachaAccumulateRewardData data2 = data.Data;
			return ((data2 != null) ? new EGachaAccumulateRewardStatus?(data2.Status) : null).GetValueOrDefault() == EGachaAccumulateRewardStatus.CanClaim;
		};
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		base.GetExtendToggle(0).OnUndeterminedClicked.Add(new Action(this.OnClickButton));
	}

	// Token: 0x0600DB51 RID: 56145 RVA: 0x0032FDFC File Offset: 0x0032DFFC
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
		extendToggle2.OnUndeterminedClicked.Remove(new Action(this.OnClickButton));
	}

	// Token: 0x0600DB52 RID: 56146 RVA: 0x0032FE4E File Offset: 0x0032E04E
	public override void Refresh(GachaAccumulateRewardItemStageData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshStateSubPanel(data);
		this.RefreshItem(data);
		base.GetText(5).SetText(data.Data.GachaNum.ToString(), true);
	}

	// Token: 0x0600DB53 RID: 56147 RVA: 0x0032FE84 File Offset: 0x0032E084
	private void RefreshStateSubPanel(GachaAccumulateRewardItemStageData data)
	{
		EGachaAccumulateRewardStatus status = data.Data.Status;
		base.GetItem(1).SetUIActive(status == EGachaAccumulateRewardStatus.NotReached);
		base.GetItem(2).SetUIActive(status == EGachaAccumulateRewardStatus.CanClaim);
		base.GetItem(4).SetUIActive(status == EGachaAccumulateRewardStatus.Claimed);
	}

	// Token: 0x0600DB54 RID: 56148 RVA: 0x0032FED0 File Offset: 0x0032E0D0
	private void RefreshItem(GachaAccumulateRewardItemStageData data)
	{
		RewardItemData rewardItemData = data.Data.GetRewardItemList()[0];
		TItem data2 = new TItem
		{
			ItemData = new InventoryDefine.GetItemData(rewardItemData.ConfigId, 0),
			Count = rewardItemData.Count
		};
		this.CommonItemGrid.Refresh(data2);
		this.CommonItemGrid.SetRedDotVisible(new bool?(data.Data.Status == EGachaAccumulateRewardStatus.CanClaim));
		if (data.Data.Status == EGachaAccumulateRewardStatus.Claimed)
		{
			this.CommonItemGrid.SetReceivedColor("eae4ab");
		}
	}

	// Token: 0x0600DB55 RID: 56149 RVA: 0x0032FF5D File Offset: 0x0032E15D
	private void OnToggleStateChange(EToggleState _)
	{
		this.OnClickButton();
	}

	// Token: 0x0600DB56 RID: 56150 RVA: 0x0032FF68 File Offset: 0x0032E168
	private void OnClickButton()
	{
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(this.Data.AccumulateId);
		EGachaAccumulateRewardStatus status = this.Data.Data.Status;
		if (status == EGachaAccumulateRewardStatus.NotReached || status == EGachaAccumulateRewardStatus.Claimed)
		{
			ItemController.Instance.OpenItemTipsByItemId(this.Data.Data.GetRewardItemList()[0].ConfigId, true, null);
			return;
		}
		List<int> list = accumulateData.CollectAllClaimableRewardIds();
		GachaAccumulateController.Instance.ClaimAccumulateRewardAsync(this.Data.AccumulateId, list.ToArray(), Array.Empty<int>()).Forget<bool>();
	}

	// Token: 0x04006483 RID: 25731
	private const string ReceivedCheckColor = "eae4ab";

	// Token: 0x04006484 RID: 25732
	[Nullable(2)]
	private GachaAccumulateRewardItemStageData Data;

	// Token: 0x04006485 RID: 25733
	[Nullable(2)]
	private CommonItemSmallItemGrid CommonItemGrid;
}
