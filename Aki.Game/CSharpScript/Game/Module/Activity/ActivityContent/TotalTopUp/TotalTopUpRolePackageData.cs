using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F8A RID: 24458
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpRolePackageData
	{
		// Token: 0x0603E11A RID: 254234 RVA: 0x00EFC774 File Offset: 0x00EFA974
		[NullableContext(2)]
		public static TotalTopUpRolePackageData TryParsePackageData(int itemId)
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
			if (giftPackageConfig == null || giftPackageConfig.Value.Type != GiftType.TotalTopUpRole)
			{
				return null;
			}
			TotalTopUpRolePackageData totalTopUpRolePackageData = new TotalTopUpRolePackageData();
			foreach (DicIntInt dicIntInt in giftPackageConfig.Value.ContentIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(key);
				if (itemConfigData != null && itemConfigData.ItemDataType == InventoryDefine.EItemDataType.RoleItem)
				{
					RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(key);
					totalTopUpRolePackageData.RoleList.Add((roleConfig != null) ? key : 0);
				}
				else if (totalTopUpRolePackageData.ItemId > 0)
				{
					string message = "TotalTopUpRolePackageData解析错误，包含多个非角色道具";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("GiftBagId", num);
					TotalTopUpUtil.Error(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					totalTopUpRolePackageData.ItemId = key;
					totalTopUpRolePackageData.ItemCount = value;
				}
			}
			totalTopUpRolePackageData.GiftBagItemId = itemId;
			totalTopUpRolePackageData.RoleTrialIdList = new List<int>();
			foreach (int roleId in totalTopUpRolePackageData.RoleList)
			{
				totalTopUpRolePackageData.RoleTrialIdList.Add(TotalTopUpRolePackageData.RoleIdToTrialId(roleId));
			}
			TotalTopUpUtil.Debug("TotalTopUpRolePackageData解析成功", default(ReadOnlySpan<ValueTuple<string, object>>));
			return totalTopUpRolePackageData;
		}

		// Token: 0x0603E11B RID: 254235 RVA: 0x00EFC940 File Offset: 0x00EFAB40
		private static int RoleIdToTrialId(int roleId)
		{
			GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleId);
			if (gachaTextureInfo == null)
			{
				return 0;
			}
			return gachaTextureInfo.GetValueOrDefault().TrialId;
		}

		// Token: 0x04020694 RID: 132756
		public int GiftBagItemId;

		// Token: 0x04020695 RID: 132757
		public List<int> RoleList = new List<int>();

		// Token: 0x04020696 RID: 132758
		public List<int> RoleTrialIdList = new List<int>();

		// Token: 0x04020697 RID: 132759
		public int ItemId;

		// Token: 0x04020698 RID: 132760
		public int ItemCount;
	}
}
