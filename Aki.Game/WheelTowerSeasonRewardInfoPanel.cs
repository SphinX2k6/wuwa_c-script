using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Skin.Tab.Weapon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020015D6 RID: 5590
[NullableContext(1)]
[Nullable(0)]
public class WheelTowerSeasonRewardInfoPanel : UiPanelBase
{
	// Token: 0x06009E32 RID: 40498 RVA: 0x002272C4 File Offset: 0x002254C4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 3;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickLook));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickLeft));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickRight));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06009E33 RID: 40499 RVA: 0x00227434 File Offset: 0x00225634
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerSeasonRewardInfoPanel.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerSeasonRewardInfoPanel.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009E34 RID: 40500 RVA: 0x00227478 File Offset: 0x00225678
	public void RefreshDataList(List<IWheelTowerSeasonScoreData> dataList)
	{
		this.DataList = dataList;
		int num = dataList.Count - 1;
		for (int i = 0; i < dataList.Count; i++)
		{
			if (!dataList[i].IsReceived)
			{
				num = i;
				break;
			}
		}
		this.CurIndex = num;
		this.Refresh(dataList[num]);
	}

	// Token: 0x06009E35 RID: 40501 RVA: 0x002274CC File Offset: 0x002256CC
	private void Refresh(IWheelTowerSeasonScoreData data)
	{
		List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(data.DropId);
		if (dropPackagePreviewItemList.Count <= 0)
		{
			return;
		}
		TItem titem = dropPackagePreviewItemList[0];
		WheelTowerSeasonRewardInfoItem rewardInfoItem = this.RewardInfoItem;
		if (rewardInfoItem != null)
		{
			rewardInfoItem.Refresh(titem, data.PreviewIcon);
		}
		this.RewardItem = new TItem?(titem);
		this.MotorPreviewId = data.MotorPreviewId;
		this.WeaponPreviewId = data.WeaponPreviewId;
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(titem.ItemData.ItemId);
		if (itemConfigData != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), itemConfigData.Name, Array.Empty<object>());
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "WheelTower_SeasonScore_TotalScoreGet", new <>z__ReadOnlySingleElementList<object>(data.Score));
		UUIButtonComponent button = base.GetButton(3);
		if (button != null)
		{
			UUIItem uuiitem = button.RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(this.CurIndex > 0);
			}
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 == null)
		{
			return;
		}
		UUIItem uuiitem2 = button2.RootUIComp.Get();
		if (uuiitem2 == null)
		{
			return;
		}
		uuiitem2.SetUIActive(this.DataList != null && this.CurIndex < this.DataList.Count - 1);
	}

	// Token: 0x06009E36 RID: 40502 RVA: 0x00227604 File Offset: 0x00225804
	private void OnClickLook()
	{
		if (this.RewardItem == null)
		{
			return;
		}
		if (this.MotorPreviewId > 0)
		{
			this.ReportRewardPreviewEvent(0, 0, this.MotorPreviewId);
			MotorcycleDiyController.Instance.OpenMotorGeneralPreviewView(this.MotorPreviewId);
			return;
		}
		if (this.WeaponPreviewId > 0)
		{
			this.ReportRewardPreviewEvent(0, 0, this.WeaponPreviewId);
			WeaponSkinController.Instance.OpenWeaponSkinShowView(new List<int>
			{
				this.WeaponPreviewId
			});
			return;
		}
		int itemId = this.RewardItem.Value.ItemData.ItemId;
		this.ReportRewardPreviewEvent(0, itemId, 0);
		ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
	}

	// Token: 0x06009E37 RID: 40503 RVA: 0x002276A8 File Offset: 0x002258A8
	private void ReportRewardPreviewEvent(int goodsId = 0, int itemId = 0, int skinId = 0)
	{
		NewTowerRewardPreviewEvent newTowerRewardPreviewEvent = new NewTowerRewardPreviewEvent();
		newTowerRewardPreviewEvent.i_goods_id = goodsId;
		newTowerRewardPreviewEvent.i_item_id = itemId;
		newTowerRewardPreviewEvent.i_skin_id = skinId;
		LogReportController.Instance.LogReport(newTowerRewardPreviewEvent);
	}

	// Token: 0x06009E38 RID: 40504 RVA: 0x002276DC File Offset: 0x002258DC
	private void OnClickLeft()
	{
		if (this.DataList == null || this.DataList.Count == 0)
		{
			return;
		}
		this.CurIndex = MathUtils.Instance.Clamp(this.CurIndex - 1, 0, this.DataList.Count - 1);
		Action playSwitchTween = this.PlaySwitchTween;
		if (playSwitchTween != null)
		{
			playSwitchTween();
		}
		this.Refresh(this.DataList[this.CurIndex]);
	}

	// Token: 0x06009E39 RID: 40505 RVA: 0x00227750 File Offset: 0x00225950
	private void OnClickRight()
	{
		if (this.DataList == null || this.DataList.Count == 0)
		{
			return;
		}
		this.CurIndex = MathUtils.Instance.Clamp(this.CurIndex + 1, 0, this.DataList.Count - 1);
		Action playSwitchTween = this.PlaySwitchTween;
		if (playSwitchTween != null)
		{
			playSwitchTween();
		}
		this.Refresh(this.DataList[this.CurIndex]);
	}

	// Token: 0x0400465C RID: 18012
	[Nullable(2)]
	public Action PlaySwitchTween;

	// Token: 0x0400465D RID: 18013
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<IWheelTowerSeasonScoreData> DataList;

	// Token: 0x0400465E RID: 18014
	[Nullable(2)]
	private WheelTowerSeasonRewardInfoItem RewardInfoItem;

	// Token: 0x0400465F RID: 18015
	private TItem? RewardItem;

	// Token: 0x04004660 RID: 18016
	private int MotorPreviewId;

	// Token: 0x04004661 RID: 18017
	private int WeaponPreviewId;

	// Token: 0x04004662 RID: 18018
	private int CurIndex;
}
