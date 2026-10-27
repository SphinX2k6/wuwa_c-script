using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F8B RID: 24459
	public class TotalTopUpWeaponPackageData
	{
		// Token: 0x0603E11D RID: 254237 RVA: 0x00EFC994 File Offset: 0x00EFAB94
		[NullableContext(2)]
		public unsafe static TotalTopUpWeaponPackageData TryParseWeaponPackageData(int itemId)
		{
			ItemInfo? config = CSharpScript.Game.Module.Item.ItemConfig.Instance.GetConfig(itemId);
			if (config == null)
			{
				return null;
			}
			int num;
			if (!config.Value.Parameters().TryGetValue(2, out num))
			{
				return null;
			}
			GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(num);
			if (giftPackageConfig == null)
			{
				return null;
			}
			TotalTopUpWeaponPackageData totalTopUpWeaponPackageData = new TotalTopUpWeaponPackageData();
			foreach (DicIntInt dicIntInt in giftPackageConfig.Value.ContentIter())
			{
				int key = dicIntInt.Key;
				CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(key);
				if (itemConfigData == null || itemConfigData.ItemDataType != InventoryDefine.EItemDataType.WeaponItem)
				{
					string message = "TotalTopUpWeaponPackageData解析错误，包含非武器道具";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GiftBagId", num);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ItemId", key);
					TotalTopUpUtil.Error(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return null;
				}
				WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(key);
				if (weaponConfigByItemId != null)
				{
					totalTopUpWeaponPackageData.WeaponTrialIdList.Add(weaponConfigByItemId.Value.HandBookTrialId);
				}
			}
			if (totalTopUpWeaponPackageData.WeaponTrialIdList.Count == 0)
			{
				return null;
			}
			string message2 = "TotalTopUpWeaponPackageData解析成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("TrialIds", string.Join<int>(",", totalTopUpWeaponPackageData.WeaponTrialIdList));
			TotalTopUpUtil.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return totalTopUpWeaponPackageData;
		}

		// Token: 0x04020699 RID: 132761
		[Nullable(1)]
		public List<int> WeaponTrialIdList = new List<int>();
	}
}
