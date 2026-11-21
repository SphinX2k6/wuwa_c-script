using System;
using System.Collections.Generic;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001488 RID: 5256
public class GiftItemUseLogic : ItemUseLogicBase
{
	// Token: 0x0600D277 RID: 53879 RVA: 0x003E71FA File Offset: 0x003E53FA
	public override bool CheckUseCondition(int itemId, int num)
	{
		return InventoryModel.Instance.GetCommonItemData(itemId, 0) != null;
	}

	// Token: 0x0600D278 RID: 53880 RVA: 0x003E720C File Offset: 0x003E540C
	public unsafe override void OnUse(int itemId, int num)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		if (itemConfig == null)
		{
			return;
		}
		int num2;
		if (!itemConfig.Value.Parameters().TryGetValue(2, out num2))
		{
			if (itemConfig.Value.Parameters().ContainsKey(4))
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.LY;
			string message = "礼包道具未配置开启方式";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		else
		{
			GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(num2);
			if (giftPackageConfig == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Inventory;
				ELogAuthor author2 = ELogAuthor.LY;
				string message2 = "礼包道具查不到礼包配置";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ItemId", itemId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("GiftId", num2);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			switch (giftPackageConfig.Value.Type)
			{
			case GiftType.Fixed:
			case GiftType.Random:
			case GiftType.RandomPhantom:
			case GiftType.CaptureMonster:
				this.UseCommonGift(itemId);
				return;
			case GiftType.Optional:
				InventoryGiftController.Instance.SendGiftPackPreviewRequest(itemId, giftPackageConfig.Value, null, 1);
				return;
			case GiftType.TotalTopUpRole:
				this.UseTotalTopUpRoleGift(itemId);
				return;
			case GiftType.ResonantChainOptional:
				this.UseResonantChainOptionalGift(itemId, num2);
				return;
			default:
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Inventory;
				ELogAuthor author3 = ELogAuthor.LY;
				string message3 = "礼包类型无对应使用逻辑";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ItemId", itemId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("GiftId", num2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("GiftType", giftPackageConfig.Value.Type);
				instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				return;
			}
			}
		}
	}

	// Token: 0x0600D279 RID: 53881 RVA: 0x003E73FC File Offset: 0x003E55FC
	private void UseTotalTopUpRoleGift(int itemId)
	{
		TotalTopUpRolePackageData totalTopUpRolePackageData = TotalTopUpRolePackageData.TryParsePackageData(itemId);
		if (totalTopUpRolePackageData == null)
		{
			return;
		}
		TotalTopUpPickRoleViewModel totalTopUpPickRoleViewModel = new TotalTopUpPickRoleViewModel();
		totalTopUpPickRoleViewModel.LoadFromGiftPackageInBag(totalTopUpRolePackageData);
		UiManager.Instance.OpenView(EUiViewName.TotalTopUpPickRoleRewardView, totalTopUpPickRoleViewModel, null);
	}

	// Token: 0x0600D27A RID: 53882 RVA: 0x003E7434 File Offset: 0x003E5634
	private void UseResonantChainOptionalGift(int itemId, int giftId)
	{
		ItemRewardSelectViewOpenParam itemRewardSelectViewOpenParam = new ItemRewardSelectViewOpenParam();
		itemRewardSelectViewOpenParam.GiftPackageId = giftId;
		itemRewardSelectViewOpenParam.OnSelectItemCallBack = delegate(int index, int selectItem)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(itemId, 1, new int[]
			{
				selectItem
			});
		};
		UiManager.Instance.OpenView(EUiViewName.ItemRewardSelectView, itemRewardSelectViewOpenParam, null);
	}

	// Token: 0x0600D27B RID: 53883 RVA: 0x003E7480 File Offset: 0x003E5680
	private void UseCommonGift(int itemId)
	{
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		if (itemCountByConfigId <= 1)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(itemId, 1, null);
			return;
		}
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		if (itemConfig == null)
		{
			return;
		}
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(itemConfig.Value.Name, null);
		List<TItem> itemData = new List<TItem>
		{
			new TItem(new InventoryDefine.GetItemData(itemConfig.Value.Id, 0), itemCountByConfigId)
		};
		AcquireData acquireData = new AcquireData();
		acquireData.SetAcquireViewType(EAcquireViewType.SelectAmount);
		acquireData.SetAmount(1);
		acquireData.SetMaxAmount(itemCountByConfigId);
		acquireData.SetRemainItemCount(itemCountByConfigId);
		acquireData.SetItemData(itemData);
		acquireData.SetNameText(localTextNew);
		acquireData.SetConfigId(itemId);
		acquireData.SetRightButtonFunction(delegate
		{
			GiftItemUseLogic.OnClickedUseMultiGift(itemId, acquireData.GetAmount());
			return default(UniTask);
		});
		InventoryGiftController.Instance.ShowAcquireView(acquireData);
	}

	// Token: 0x0600D27C RID: 53884 RVA: 0x003E75AA File Offset: 0x003E57AA
	private static void OnClickedUseMultiGift(int itemConfigId, int count)
	{
		if (count > 0)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(itemConfigId, count, null);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("NotEnoughItem", Array.Empty<object>());
	}
}
