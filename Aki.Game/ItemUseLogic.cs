using System;
using System.Collections.Generic;
using System.Linq;
using Aki.Config;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.Cipher;
using CSharpScript.Game.Module.Activity.ActivityContent.SpringManor;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001FC0 RID: 8128
public class ItemUseLogic
{
	// Token: 0x0600FE29 RID: 65065 RVA: 0x003DA970 File Offset: 0x003D8B70
	public static bool TryUseParameterItem(int itemId, int num = 1)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		if (itemConfig == null)
		{
			return false;
		}
		if (itemConfig.Value.Parameters().Count == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "使用道具失败,使用参数为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		InventoryController.Instance.RequestItemUse(itemId, num);
		return true;
	}

	// Token: 0x0600FE2A RID: 65066 RVA: 0x003DA9E8 File Offset: 0x003D8BE8
	public static bool TryUseUiPlayItem(int itemId, int num = 1)
	{
		ItemInfo? config = ConfigItemInfoById.GetConfig(itemId, true);
		if (config == null || !config.Value.UiPlayItem)
		{
			return false;
		}
		UiPlayItem? config2 = ConfigUiPlayItemById.GetConfig(itemId, true);
		if (config2 == null)
		{
			return false;
		}
		ESimpleGameplayType esimpleGameplayType = ESimpleGameplayTypeExtensions.FromString(config2.Value.Type);
		if (esimpleGameplayType != ESimpleGameplayType.Cipher)
		{
			if (esimpleGameplayType == ESimpleGameplayType.SignalBreak)
			{
				UiManager.Instance.OpenView(EUiViewName.SignalDecodeView, config2.Value.UiPlayKey, null);
			}
		}
		else
		{
			CipherController.Instance.OpenCipherView(config2.Value.UiPlayKey);
		}
		return true;
	}

	// Token: 0x0600FE2B RID: 65067 RVA: 0x003DAA88 File Offset: 0x003D8C88
	public static bool TryUseBattlePassItem(int itemId, int num = 1)
	{
		ItemUseLogic.<>c__DisplayClass2_0 CS$<>8__locals1 = new ItemUseLogic.<>c__DisplayClass2_0();
		CS$<>8__locals1.itemId = itemId;
		if (CS$<>8__locals1.itemId == BattlePassModel.Instance.PrimaryItemId || CS$<>8__locals1.itemId == BattlePassModel.Instance.AdvanceItemId)
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(BattlePassModel.Instance.GetBattlePassItemConfirmId(CS$<>8__locals1.itemId));
			confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<TryUseBattlePassItem>g__confirmCallback|0));
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return true;
		}
		return false;
	}

	// Token: 0x0600FE2C RID: 65068 RVA: 0x003DAB03 File Offset: 0x003D8D03
	public static bool TryUseBuffItem(int itemId, int num = 1)
	{
		return ItemUseLogic.TryUseBuffItem(itemId, num, false, 0);
	}

	// Token: 0x0600FE2D RID: 65069 RVA: 0x003DAB10 File Offset: 0x003D8D10
	public static bool TryUseBuffItem(int itemId, int num = 1, bool isDirect = false, int roleConfigId = 0)
	{
		if (!BuffItemConfig.Instance.IsBuffItem(itemId))
		{
			return false;
		}
		if (GameModeController.Instance.IsInInstance())
		{
			int instanceId = CreatureModel.Instance.GetInstanceId();
			InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
			if (config != null && config.Value.CanUseItem == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByText(ConfigMultiTextLang.GetLocalTextNew("Dungeon_BanItem", null));
				return true;
			}
		}
		if (BuffItemModel.Instance.GetBuffItemRemainCdTime(itemId) > 0.0)
		{
			ScrollingTipsController.Instance.ShowTipsById("UseBuffCdText", Array.Empty<object>());
			return true;
		}
		if (BuffItemConfig.Instance.IsTeamBuffItem(itemId))
		{
			BuffItemControl.Instance.RequestUseBuffItem(itemId, 1, -1);
			return true;
		}
		BuffItemControl.Instance.InitializeAllUseBuffItemRoleFromPlayerFormationInstance(itemId);
		if (BuffItemModel.Instance.GetAllUseBuffItemRole().Count <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoneRole", Array.Empty<object>());
			return true;
		}
		if (!isDirect)
		{
			UiManager.Instance.OpenView(EUiViewName.UseBuffItemView, itemId, null);
			return true;
		}
		return ItemUseLogic.TryUseSingleBuffItemDirectly(itemId, num, roleConfigId);
	}

	// Token: 0x0600FE2E RID: 65070 RVA: 0x003DAC24 File Offset: 0x003D8E24
	private static bool TryUseSingleBuffItemDirectly(int itemId, int num = 1, int roleConfigId = 0)
	{
		SceneTeamItem teamItem = SceneTeamModel.Instance.GetTeamItem((long)roleConfigId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId
		});
		if (teamItem == null)
		{
			return false;
		}
		if (teamItem.GetConfigId > 100000)
		{
			ScrollingTipsController.Instance.ShowTipsById("NoneRole", Array.Empty<object>());
			return true;
		}
		object obj;
		if (teamItem == null)
		{
			obj = null;
		}
		else
		{
			EntityHandle entityHandle = teamItem.EntityHandle;
			obj = ((entityHandle != null) ? entityHandle.Entity : null);
		}
		object obj2 = obj;
		BaseAttributeComponent baseAttributeComponent = (obj2 != null) ? obj2.GetComponent<BaseAttributeComponent>() : null;
		if (baseAttributeComponent == null)
		{
			return false;
		}
		double num2 = Math.Ceiling((double)baseAttributeComponent.GetCurrentValue(EAttributeType.Life));
		double num3 = Math.Ceiling((double)baseAttributeComponent.GetCurrentValue(EAttributeType.LifeMax));
		if (num2 >= num3)
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("HpFull", null);
			ScrollingTipsController.Instance.ShowTipsByText(localTextNew);
			return true;
		}
		BuffItemControl.Instance.RequestUseBuffItem(itemId, num, roleConfigId);
		return true;
	}

	// Token: 0x0600FE2F RID: 65071 RVA: 0x003DACE5 File Offset: 0x003D8EE5
	public static bool TryUsePowerItem(int itemId, int num = 1)
	{
		if (itemId == 10800)
		{
			PowerController.Instance.OpenPowerRecoveryExchangeView((EPowerRecoveryItem)itemId);
			return true;
		}
		return false;
	}

	// Token: 0x0600FE30 RID: 65072 RVA: 0x003DAD00 File Offset: 0x003D8F00
	public static bool TryUseMonthCardItem(int itemId, int num = 1)
	{
		ItemUseLogic.<>c__DisplayClass7_0 CS$<>8__locals1 = new ItemUseLogic.<>c__DisplayClass7_0();
		CS$<>8__locals1.itemId = itemId;
		ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(CS$<>8__locals1.itemId);
		int key;
		if (!config.Value.Parameters().TryGetValue(13, out key) && !config.Value.Parameters().TryGetValue(14, out key))
		{
			return false;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.MonthCardUseTips);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null);
		confirmBoxDataNew.SetTextArgs(new string[]
		{
			localTextNew,
			MonthCardConfig.Instance.GetConfig(key).Value.Days.ToString()
		});
		confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<TryUseMonthCardItem>g__confirmFunction|0));
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		return true;
	}

	// Token: 0x0600FE31 RID: 65073 RVA: 0x003DADE8 File Offset: 0x003D8FE8
	public static bool TryUseGiftItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (commonItemData.GetType().GetValueOrDefault() != InventoryDefine.EItemType.Gift)
		{
			return false;
		}
		ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(itemId);
		bool flag = false;
		int id;
		if (!config.Value.Parameters().TryGetValue(2, out id))
		{
			if (!config.Value.Parameters().TryGetValue(4, out id))
			{
				return false;
			}
			flag = true;
		}
		GiftPackage value = GiftPackageConfig.Instance.GetGiftPackageConfig(id).Value;
		if (flag)
		{
			return true;
		}
		if (value.Type == GiftType.ResonantChainOptional)
		{
			return false;
		}
		if (value.Type != GiftType.Fixed && value.Type != GiftType.Random && value.Type != GiftType.RandomPhantom && value.Type != GiftType.CaptureMonster)
		{
			InventoryGiftController.Instance.SendGiftPackPreviewRequest(itemId, value, null, 1);
			return true;
		}
		int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0);
		string localTextNew = ConfigMultiTextLang.GetLocalTextNew(config.Value.Name, null);
		List<TItem> list = new List<TItem>();
		TItem item = new TItem(new InventoryDefine.GetItemData(config.Value.Id, 0), itemCountByConfigId);
		list.Add(item);
		if (itemCountByConfigId > 1)
		{
			AcquireData acquireData = new AcquireData();
			acquireData.SetAcquireViewType(EAcquireViewType.SelectAmount);
			acquireData.SetAmount(1);
			acquireData.SetMaxAmount(itemCountByConfigId);
			acquireData.SetRemainItemCount(itemCountByConfigId);
			acquireData.SetItemData(list);
			acquireData.SetNameText(localTextNew);
			acquireData.SetConfigId(itemId);
			acquireData.SetRightButtonFunction(delegate
			{
				ItemUseLogic.OnClickedUseMultiGift(itemId, acquireData.GetAmount());
				return default(UniTask);
			});
			InventoryGiftController.Instance.ShowAcquireView(acquireData);
			return true;
		}
		InventoryGiftController.Instance.SendItemGiftUseRequest(itemId, 1, null);
		return true;
	}

	// Token: 0x0600FE32 RID: 65074 RVA: 0x003DAFF4 File Offset: 0x003D91F4
	public static bool TryUseGiftItemWithSelectedItem(int giftItemId, int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(giftItemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (commonItemData.GetType().GetValueOrDefault() != InventoryDefine.EItemType.Gift)
		{
			return false;
		}
		int id;
		if (!CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(giftItemId).Value.Parameters().TryGetValue(2, out id))
		{
			return false;
		}
		GiftPackage value = GiftPackageConfig.Instance.GetGiftPackageConfig(id).Value;
		if (value.Type != GiftType.Optional)
		{
			return false;
		}
		InventoryGiftController.Instance.SendGiftPackPreviewRequest(giftItemId, value, new int?(itemId), num);
		return true;
	}

	// Token: 0x0600FE33 RID: 65075 RVA: 0x003DB088 File Offset: 0x003D9288
	public static bool TryUseShipTowerItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (commonItemData.GetType().GetValueOrDefault() != InventoryDefine.EItemType.ShipTowerBuff)
		{
			return false;
		}
		EventSystem.Instance.Emit(EEventName.OpenActivityViewShipTower);
		return true;
	}

	// Token: 0x0600FE34 RID: 65076 RVA: 0x003DB0CF File Offset: 0x003D92CF
	public static bool TryUseStudentCardItem(int itemId, int num = 1)
	{
		if (itemId != 70290000)
		{
			return false;
		}
		UiManager.Instance.OpenView(EUiViewName.AdmissionStudentCardView, null, null);
		return true;
	}

	// Token: 0x0600FE35 RID: 65077 RVA: 0x003DB0F0 File Offset: 0x003D92F0
	public static bool TryUsePayShopCouponItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (commonItemData.GetType().GetValueOrDefault() != InventoryDefine.EItemType.PayShopCoupon)
		{
			return false;
		}
		PayShopViewData payShopViewData = new PayShopViewData();
		payShopViewData.PayShopId = PayShopDefine.EPayShopTabType.SkinShop;
		PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		return true;
	}

	// Token: 0x0600FE36 RID: 65078 RVA: 0x003DB140 File Offset: 0x003D9340
	private static void OnClickedUseMultiGift(int itemConfigId, int count)
	{
		if (count > 0)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(itemConfigId, count, null);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsById("NotEnoughItem", Array.Empty<object>());
	}

	// Token: 0x0600FE37 RID: 65079 RVA: 0x003DB168 File Offset: 0x003D9368
	public static bool TryUseBirthdayItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (commonItemData.GetType().GetValueOrDefault() != InventoryDefine.EItemType.BirthdayItem)
		{
			return false;
		}
		BirthdayController.Instance.UseBirthdayItem(itemId);
		return true;
	}

	// Token: 0x0600FE38 RID: 65080 RVA: 0x003DB1AC File Offset: 0x003D93AC
	public static bool TryUseVisionRefineItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (!commonItemData.GetConfig().ShowTypes.Contains(54))
		{
			return false;
		}
		VisionRefineTabViewParam param = new VisionRefineTabViewParam
		{
			ViewState = ERefineViewState.Choose,
			RefineType = new EVisionRefineRefineType?(EVisionRefineRefineType.Main)
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRefineTabView, param);
		return true;
	}

	// Token: 0x0600FE39 RID: 65081 RVA: 0x003DB20C File Offset: 0x003D940C
	public static bool TryUseVisionRefineSubItem(int itemId, int num = 1)
	{
		CommonItemData commonItemData = InventoryModel.Instance.GetCommonItemData(itemId, 0);
		if (commonItemData == null)
		{
			return false;
		}
		if (!commonItemData.GetConfig().ShowTypes.Contains(58))
		{
			return false;
		}
		VisionRefineTabViewParam param = new VisionRefineTabViewParam
		{
			ViewState = ERefineViewState.Choose,
			RefineType = new EVisionRefineRefineType?(EVisionRefineRefineType.Sub)
		};
		CalabashController.Instance.JumpToCalabashRootView(EUiTabViewName.VisionRefineTabView, param);
		return true;
	}

	// Token: 0x0600FE3A RID: 65082 RVA: 0x003DB26C File Offset: 0x003D946C
	public static bool TryUseBuffEquipItem(int itemId, int num = 1)
	{
		ItemUseLogic.<>c__DisplayClass17_0 CS$<>8__locals1 = new ItemUseLogic.<>c__DisplayClass17_0();
		CS$<>8__locals1.itemId = itemId;
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(CS$<>8__locals1.itemId);
		if (itemConfig == null)
		{
			return false;
		}
		if (itemConfig.Value.Parameters().Count == 0)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Inventory;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "使用道具失败,使用参数为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ItemId", CS$<>8__locals1.itemId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return false;
		}
		BuffItemConfig instance2 = BuffItemConfig.Instance;
		BuffItemModel instance3 = BuffItemModel.Instance;
		if (instance2.IsEquipBuffItem(CS$<>8__locals1.itemId) && !instance3.IsEquippedBuffItem(CS$<>8__locals1.itemId))
		{
			int buffEquipItemCategory = instance2.GetBuffEquipItemCategory(CS$<>8__locals1.itemId);
			int? equippedBuffItemId = instance3.GetEquippedBuffItemId((EBuffItemEquipCategory)buffEquipItemCategory);
			if (equippedBuffItemId != null)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ReplaceBuffEquipItemConfirm);
				confirmBoxDataNew.FunctionMap.Add(1, delegate
				{
				});
				confirmBoxDataNew.FunctionMap.Add(2, new Action(CS$<>8__locals1.<TryUseBuffEquipItem>g__confirmCallback|0));
				string name = InventoryConfig.Instance.GetItemConfig(equippedBuffItemId.Value).Value.Name;
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew(name, null)
				});
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return true;
			}
		}
		InventoryController.Instance.RequestItemUse(CS$<>8__locals1.itemId, 1);
		return true;
	}

	// Token: 0x0600FE3B RID: 65083 RVA: 0x003DB3F0 File Offset: 0x003D95F0
	public static bool TryUseTotalTopUpRolePickItem(int itemId, int num = 1)
	{
		TotalTopUpRolePackageData totalTopUpRolePackageData = TotalTopUpRolePackageData.TryParsePackageData(itemId);
		if (totalTopUpRolePackageData == null)
		{
			return false;
		}
		TotalTopUpPickRoleViewModel totalTopUpPickRoleViewModel = new TotalTopUpPickRoleViewModel();
		totalTopUpPickRoleViewModel.LoadFromGiftPackageInBag(totalTopUpRolePackageData);
		UiManager.Instance.OpenView(EUiViewName.TotalTopUpPickRoleRewardView, totalTopUpPickRoleViewModel, null);
		return true;
	}

	// Token: 0x0600FE3C RID: 65084 RVA: 0x003DB428 File Offset: 0x003D9628
	public static bool TryUseOrnamentItem(int itemId, int num = 1)
	{
		if (!RoleOrnamentModel.Instance.IsOwnOrnament(itemId))
		{
			return false;
		}
		RoleController.Instance.SkipToRoleOrnamentViewByItemId(itemId, true);
		return true;
	}

	// Token: 0x0600FE3D RID: 65085 RVA: 0x003DB448 File Offset: 0x003D9648
	public static bool TryUseBrochureItem(int itemId, int num = 1)
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("SpringManorBrochureItemId");
		if (intArrayConfig == null)
		{
			return false;
		}
		if (intArrayConfig[0] != itemId)
		{
			return false;
		}
		int activityId = intArrayConfig[1];
		SpringManorBrochureViewOpenParam param = new SpringManorBrochureViewOpenParam
		{
			IsHideReward = true,
			ActivityId = activityId
		};
		UiManager.Instance.OpenView(EUiViewName.SpringManorBrochureView, param, null);
		return true;
	}

	// Token: 0x0600FE3E RID: 65086 RVA: 0x003DB49F File Offset: 0x003D969F
	public static void ParametersItemUse(int configId, int count, int parametersType, int parametersValue)
	{
		if (parametersType == 26)
		{
			ItemUseLogic.ParametersItemUseSkipTask(configId, count, parametersValue);
		}
	}

	// Token: 0x0600FE3F RID: 65087 RVA: 0x003DB4AE File Offset: 0x003D96AE
	private static void ParametersItemUseSkipTask(int itemId, int count, int parametersValue)
	{
		SkipTaskManager.RunByConfigId(parametersValue, null);
	}

	// Token: 0x0600FE40 RID: 65088 RVA: 0x003DB4B8 File Offset: 0x003D96B8
	public static bool TryUseResonantChainOptionalItem(int itemId, int num = 1)
	{
		ItemInfo? itemConfig = InventoryConfig.Instance.GetItemConfig(itemId);
		if (itemConfig == null)
		{
			return false;
		}
		if (itemConfig.Value.Parameters().Count == 0)
		{
			return false;
		}
		int num3;
		int num2 = itemConfig.Value.Parameters().TryGetValue(2, out num3) ? num3 : 0;
		if (num2 == 0)
		{
			return false;
		}
		if (GiftPackageConfig.Instance.GetGiftPackageConfig(num2).Value.Type != GiftType.ResonantChainOptional)
		{
			return false;
		}
		ItemRewardSelectViewOpenParam itemRewardSelectViewOpenParam = new ItemRewardSelectViewOpenParam();
		itemRewardSelectViewOpenParam.GiftPackageId = num2;
		Action<int, int> onSelectItemCallBack = delegate(int index, int selectItem)
		{
			InventoryGiftController.Instance.SendItemGiftUseRequest(itemId, 1, new int[]
			{
				selectItem
			});
		};
		itemRewardSelectViewOpenParam.OnSelectItemCallBack = onSelectItemCallBack;
		UiManager.Instance.OpenView(EUiViewName.ItemRewardSelectView, itemRewardSelectViewOpenParam, null);
		return true;
	}
}
