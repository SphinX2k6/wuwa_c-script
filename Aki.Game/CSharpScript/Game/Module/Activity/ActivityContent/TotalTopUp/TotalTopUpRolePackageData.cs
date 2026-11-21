using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F71 RID: 20337
	[NullableContext(1)]
	[Nullable(0)]
	public class TotalTopUpRolePackageData
	{
		// Token: 0x060330B4 RID: 209076 RVA: 0x00E4E42C File Offset: 0x00E4C62C
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

		// Token: 0x060330B5 RID: 209077 RVA: 0x00E4E5F8 File Offset: 0x00E4C7F8
		private static int RoleIdToTrialId(int roleId)
		{
			GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(roleId);
			if (gachaTextureInfo == null)
			{
				return 0;
			}
			return gachaTextureInfo.GetValueOrDefault().TrialId;
		}

		// Token: 0x0401B166 RID: 110950
		public int GiftBagItemId;

		// Token: 0x0401B167 RID: 110951
		public List<int> RoleList = new List<int>();

		// Token: 0x0401B168 RID: 110952
		public List<int> RoleTrialIdList = new List<int>();

		// Token: 0x0401B169 RID: 110953
		public int ItemId;

		// Token: 0x0401B16A RID: 110954
		public int ItemCount;
	}
}
