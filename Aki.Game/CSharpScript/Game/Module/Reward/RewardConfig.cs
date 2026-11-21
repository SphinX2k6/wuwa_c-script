using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02003ED1 RID: 16081
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RewardConfig : ConfigBase
	{
		// Token: 0x06028C6D RID: 167021 RVA: 0x00B70B77 File Offset: 0x00B6ED77
		public DropPackage? GetDropPackage(int id)
		{
			return ConfigDropPackageById.GetConfig(id, true);
		}

		// Token: 0x06028C6E RID: 167022 RVA: 0x00B70B80 File Offset: 0x00B6ED80
		[NullableContext(2)]
		public Dictionary<int, int> GetDropPackagePreview(int id)
		{
			DropPackage? config = ConfigDropPackageById.GetConfig(id, true);
			if (config == null)
			{
				return null;
			}
			return config.Value.DropPreview();
		}

		// Token: 0x06028C6F RID: 167023 RVA: 0x00B70BB0 File Offset: 0x00B6EDB0
		public List<TItem> GetDropPackagePreviewItemList(int id)
		{
			List<TItem> list = new List<TItem>();
			DropPackage? config = ConfigDropPackageById.GetConfig(id, true);
			if (config == null)
			{
				return list;
			}
			foreach (DicIntInt dicIntInt in config.Value.DropPreviewIter())
			{
				int key = dicIntInt.Key;
				int value = dicIntInt.Value;
				list.Add(new TItem(new InventoryDefine.GetItemData(key, 0), value));
			}
			return list;
		}

		// Token: 0x06028C70 RID: 167024 RVA: 0x00B70C44 File Offset: 0x00B6EE44
		public List<TItem> GetDropPackagePreviewItemListByIdList(IReadOnlyList<int> idList)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (int id in idList)
			{
				foreach (TItem titem in this.GetDropPackagePreviewItemList(id))
				{
					int itemId = titem.ItemData.ItemId;
					int count = titem.Count;
					if (!dictionary.TryAdd(itemId, count))
					{
						Dictionary<int, int> dictionary2 = dictionary;
						int key = itemId;
						dictionary2[key] += count;
					}
				}
			}
			CSharpScript.Game.Module.Item.ItemConfig itemConfig = CSharpScript.Game.Module.Item.ItemConfig.Instance;
			List<TItem> list = new List<TItem>(dictionary.Count);
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				list.Add(new TItem
				{
					ItemData = new InventoryDefine.GetItemData(keyValuePair.Key, 0),
					Count = keyValuePair.Value
				});
			}
			list.Sort(delegate(TItem a, TItem b)
			{
				ItemInfo? config = itemConfig.GetConfig(a.ItemData.ItemId);
				ItemInfo? config2 = itemConfig.GetConfig(b.ItemData.ItemId);
				if (config != null && config2 != null && config.Value.QualityId != config2.Value.QualityId)
				{
					return config2.Value.QualityId - config.Value.QualityId;
				}
				return a.ItemData.ItemId - b.ItemData.ItemId;
			});
			return list;
		}

		// Token: 0x06028C71 RID: 167025 RVA: 0x00B70DA0 File Offset: 0x00B6EFA0
		public DropShowPlan? GetDropShowPlan(int id)
		{
			return ConfigDropShowPlanById.GetConfig(id, true);
		}

		// Token: 0x06028C72 RID: 167026 RVA: 0x00B70DAC File Offset: 0x00B6EFAC
		public int GetSpeed()
		{
			if (this.AdsorptionSpeed == null)
			{
				this.AdsorptionSpeed = new int?(ConfigCommonParamById.GetIntConfig("adsorption_speed").Value);
			}
			return this.AdsorptionSpeed.Value;
		}

		// Token: 0x06028C73 RID: 167027 RVA: 0x00B70DF0 File Offset: 0x00B6EFF0
		public int GetMaxAdsorption()
		{
			if (this.AdsorptionMaxTime == null)
			{
				this.AdsorptionMaxTime = new int?(ConfigCommonParamById.GetIntConfig("adsorption_time").Value);
			}
			return this.AdsorptionMaxTime.Value;
		}

		// Token: 0x06028C74 RID: 167028 RVA: 0x00B70E34 File Offset: 0x00B6F034
		public int GetHeightProtect()
		{
			if (this.DropHeightProtect == null)
			{
				this.DropHeightProtect = new int?(ConfigCommonParamById.GetIntConfig("drop_height_protect").Value);
			}
			return this.DropHeightProtect.Value;
		}

		// Token: 0x06028C75 RID: 167029 RVA: 0x00B70E78 File Offset: 0x00B6F078
		public float GetRestitution()
		{
			if (this.DropBounceCoefficient == null)
			{
				this.DropBounceCoefficient = new float?(ConfigCommonParamById.GetFloatConfig("drop_bounce_coefficient").Value);
			}
			return this.DropBounceCoefficient.Value;
		}

		// Token: 0x06028C76 RID: 167030 RVA: 0x00B70EBC File Offset: 0x00B6F0BC
		public float GetFriction()
		{
			if (this.DropFriction == null)
			{
				this.DropFriction = new float?(ConfigCommonParamById.GetFloatConfig("drop_friction").Value);
			}
			return this.DropFriction.Value;
		}

		// Token: 0x06028C77 RID: 167031 RVA: 0x00B70F00 File Offset: 0x00B6F100
		public int GetDropItemPickUpRange()
		{
			if (this.DropPickUpRange == null)
			{
				this.DropPickUpRange = new int?(ConfigCommonParamById.GetIntConfig("drop_item_pickup_range").Value);
			}
			return this.DropPickUpRange.Value;
		}

		// Token: 0x06028C78 RID: 167032 RVA: 0x00B70F44 File Offset: 0x00B6F144
		public int GetPickUpInBagRange()
		{
			if (this.DropPickUpInBagRange == null)
			{
				this.DropPickUpInBagRange = new int?(ConfigCommonParamById.GetIntConfig("drop_pickup_in_bag_range").Value);
			}
			return this.DropPickUpInBagRange.Value;
		}

		// Token: 0x06028C79 RID: 167033 RVA: 0x00B70F88 File Offset: 0x00B6F188
		public int GetDropItemAcceleration()
		{
			if (this.AdsorptionAcceleration == null)
			{
				this.AdsorptionAcceleration = new int?(ConfigCommonParamById.GetIntConfig("adsorption_acceleration").Value);
			}
			return this.AdsorptionAcceleration.Value;
		}

		// Token: 0x06028C7A RID: 167034 RVA: 0x00B70FCC File Offset: 0x00B6F1CC
		public int GetFallToGroundSpeed()
		{
			if (this.FallToGroundSpeed == null)
			{
				this.FallToGroundSpeed = new int?(ConfigCommonParamById.GetIntConfig("drop_fall_ground_speed").Value);
			}
			return this.FallToGroundSpeed.Value;
		}

		// Token: 0x06028C7B RID: 167035 RVA: 0x00B71010 File Offset: 0x00B6F210
		public int GetDropChestOffsetZ()
		{
			if (this.DropChestOffsetZ == null)
			{
				this.DropChestOffsetZ = new int?(ConfigCommonParamById.GetIntConfig("drop_chest_zaxis_offset").Value);
			}
			return this.DropChestOffsetZ.Value;
		}

		// Token: 0x06028C7C RID: 167036 RVA: 0x00B71054 File Offset: 0x00B6F254
		public int GetDropBornRadius()
		{
			if (this.DropBornRadius == null)
			{
				this.DropBornRadius = new int?(ConfigCommonParamById.GetIntConfig("drop_born_radius").Value);
			}
			return this.DropBornRadius.Value;
		}

		// Token: 0x06028C7D RID: 167037 RVA: 0x00B71098 File Offset: 0x00B6F298
		public int GetDropRotationProtectTime()
		{
			if (this.DropRotationProtectTime == null)
			{
				this.DropRotationProtectTime = new int?(ConfigCommonParamById.GetIntConfig("drop_lock_rotation_time").Value);
			}
			return this.DropRotationProtectTime.Value;
		}

		// Token: 0x06028C7E RID: 167038 RVA: 0x00B710DC File Offset: 0x00B6F2DC
		public List<TItem> GetMergedDropPackagePreviewItemList(int[] dropPackageIdList)
		{
			List<TItem> list = new List<TItem>();
			if (dropPackageIdList == null)
			{
				return list;
			}
			foreach (int id in dropPackageIdList)
			{
				DropPackage? dropPackage;
				IEnumerable<DicIntInt> enumerable = (this.GetDropPackage(id) != null) ? dropPackage.GetValueOrDefault().DropPreviewIter() : null;
				if (enumerable != null)
				{
					foreach (DicIntInt dicIntInt in enumerable)
					{
						TItem item = new TItem(new InventoryDefine.GetItemData(dicIntInt.Key, 0), dicIntInt.Value);
						list.Add(item);
					}
				}
			}
			return list;
		}

		// Token: 0x06028C7F RID: 167039 RVA: 0x00B71198 File Offset: 0x00B6F398
		public int GetLowModeCount()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_list_low_count");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "慢速模式最大数量无法找到, 请检测c.参数字段\"into_bag_list_low_count\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 1;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C80 RID: 167040 RVA: 0x00B711F0 File Offset: 0x00B6F3F0
		public int GetFastModeCount()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_list_fast_count");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "快速模式最大数量无法找到, 请检测c.参数字段\"into_bag_list_fast_count\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 1;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C81 RID: 167041 RVA: 0x00B71248 File Offset: 0x00B6F448
		public int GetLowModeNextAddItemTime()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_next_item_low_time");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "慢速模式下一个物品进包时间无法找到, 请检测c.参数字段\"into_bag_next_item_low_time\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 1;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C82 RID: 167042 RVA: 0x00B712A0 File Offset: 0x00B6F4A0
		public int GetFastModeNextAddItemTime()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_next_item_fast_time");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "快速模式下一个物品进包时间无法找到, 请检测c.参数字段\"into_bag_next_item_fast_time\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 1;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C83 RID: 167043 RVA: 0x00B712F8 File Offset: 0x00B6F4F8
		public int GetIntoBagMaxCount()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("item_list_max_size");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "外入包列表最大数量无法找到, 请检测c.参数字段\"item_list_max_size\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 1;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C84 RID: 167044 RVA: 0x00B71350 File Offset: 0x00B6F550
		public int GetShowTime()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_show_time");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "入包每个物品的显示时间无法找到, 请检测c.参数字段\"into_bag_show_time\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 3000;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C85 RID: 167045 RVA: 0x00B713AC File Offset: 0x00B6F5AC
		public int GetNextItemTime()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_next_item_time");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "下一个物品添加进来的时间无法找到, 请检测c.参数字段\"into_bag_next_item_time\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 300;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C86 RID: 167046 RVA: 0x00B71408 File Offset: 0x00B6F608
		public int GetSliderTime()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("into_bag_slide_time");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "上滑时间无法找到, 请检测c.参数字段\"into_bag_slide_time\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (intConfig == null || intConfig.Value < 0)
			{
				return 200;
			}
			return intConfig.Value;
		}

		// Token: 0x06028C87 RID: 167047 RVA: 0x00B71464 File Offset: 0x00B6F664
		protected override bool OnClear()
		{
			this.AdsorptionSpeed = null;
			this.AdsorptionMaxTime = null;
			this.DropHeightProtect = null;
			this.DropBounceCoefficient = null;
			this.DropFriction = null;
			this.DropPickUpRange = null;
			this.DropPickUpInBagRange = null;
			this.AdsorptionAcceleration = null;
			this.FallToGroundSpeed = null;
			this.DropChestOffsetZ = null;
			this.DropBornRadius = null;
			this.DropRotationProtectTime = null;
			return true;
		}

		// Token: 0x170052E3 RID: 21219
		// (get) Token: 0x06028C88 RID: 167048 RVA: 0x00B71502 File Offset: 0x00B6F702
		public static RewardConfig Instance
		{
			get
			{
				return RewardConfig._Instance;
			}
		}

		// Token: 0x06028C89 RID: 167049 RVA: 0x00B71509 File Offset: 0x00B6F709
		public static RewardConfig GetOrCreateInstance()
		{
			if (RewardConfig._Instance == null)
			{
				RewardConfig.CreateInstance();
			}
			return RewardConfig._Instance;
		}

		// Token: 0x06028C8A RID: 167050 RVA: 0x00B7151D File Offset: 0x00B6F71D
		public static bool CreateInstance()
		{
			if (RewardConfig._Instance != null)
			{
				return true;
			}
			RewardConfig._Instance = new RewardConfig();
			return true;
		}

		// Token: 0x06028C8B RID: 167051 RVA: 0x00B71533 File Offset: 0x00B6F733
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06028C8C RID: 167052 RVA: 0x00B71535 File Offset: 0x00B6F735
		public static void ResetStaticDefaultValue()
		{
			RewardConfig._Instance = null;
		}

		// Token: 0x06028C8D RID: 167053 RVA: 0x00B7153D File Offset: 0x00B6F73D
		static RewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RewardConfig.CreateStaticDefaultValue), new Action(RewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04016306 RID: 90886
		private int? AdsorptionSpeed;

		// Token: 0x04016307 RID: 90887
		private int? AdsorptionMaxTime;

		// Token: 0x04016308 RID: 90888
		private int? DropHeightProtect;

		// Token: 0x04016309 RID: 90889
		private float? DropBounceCoefficient;

		// Token: 0x0401630A RID: 90890
		private float? DropFriction;

		// Token: 0x0401630B RID: 90891
		private int? DropPickUpRange;

		// Token: 0x0401630C RID: 90892
		private int? DropPickUpInBagRange;

		// Token: 0x0401630D RID: 90893
		private int? AdsorptionAcceleration;

		// Token: 0x0401630E RID: 90894
		private int? FallToGroundSpeed;

		// Token: 0x0401630F RID: 90895
		private int? DropChestOffsetZ;

		// Token: 0x04016310 RID: 90896
		private int? DropBornRadius;

		// Token: 0x04016311 RID: 90897
		private int? DropRotationProtectTime;

		// Token: 0x04016312 RID: 90898
		[Nullable(2)]
		private static RewardConfig _Instance;
	}
}
