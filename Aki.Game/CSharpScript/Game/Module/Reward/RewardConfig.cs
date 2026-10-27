using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;

namespace CSharpScript.Game.Module.Reward
{
	// Token: 0x02004F08 RID: 20232
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class RewardConfig : ConfigBase
	{
		// Token: 0x06033E02 RID: 212482 RVA: 0x00C275D7 File Offset: 0x00C257D7
		public DropPackage? GetDropPackage(int id)
		{
			return ConfigDropPackageById.GetConfig(id, true);
		}

		// Token: 0x06033E03 RID: 212483 RVA: 0x00C275E0 File Offset: 0x00C257E0
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

		// Token: 0x06033E04 RID: 212484 RVA: 0x00C27610 File Offset: 0x00C25810
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

		// Token: 0x06033E05 RID: 212485 RVA: 0x00C276A4 File Offset: 0x00C258A4
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
			List<TItem> list = (from kvp in dictionary
			select new TItem
			{
				ItemData = new InventoryDefine.GetItemData(kvp.Key, 0),
				Count = kvp.Value
			}).ToList<TItem>();
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

		// Token: 0x06033E06 RID: 212486 RVA: 0x00C277B0 File Offset: 0x00C259B0
		public DropShowPlan? GetDropShowPlan(int id)
		{
			return ConfigDropShowPlanById.GetConfig(id, true);
		}

		// Token: 0x06033E07 RID: 212487 RVA: 0x00C277BC File Offset: 0x00C259BC
		public int GetSpeed()
		{
			if (this.AdsorptionSpeed == null)
			{
				this.AdsorptionSpeed = new int?(ConfigCommonParamById.GetIntConfig("adsorption_speed").Value);
			}
			return this.AdsorptionSpeed.Value;
		}

		// Token: 0x06033E08 RID: 212488 RVA: 0x00C27800 File Offset: 0x00C25A00
		public int GetMaxAdsorption()
		{
			if (this.AdsorptionMaxTime == null)
			{
				this.AdsorptionMaxTime = new int?(ConfigCommonParamById.GetIntConfig("adsorption_time").Value);
			}
			return this.AdsorptionMaxTime.Value;
		}

		// Token: 0x06033E09 RID: 212489 RVA: 0x00C27844 File Offset: 0x00C25A44
		public int GetHeightProtect()
		{
			if (this.DropHeightProtect == null)
			{
				this.DropHeightProtect = new int?(ConfigCommonParamById.GetIntConfig("drop_height_protect").Value);
			}
			return this.DropHeightProtect.Value;
		}

		// Token: 0x06033E0A RID: 212490 RVA: 0x00C27888 File Offset: 0x00C25A88
		public float GetRestitution()
		{
			if (this.DropBounceCoefficient == null)
			{
				this.DropBounceCoefficient = new float?(ConfigCommonParamById.GetFloatConfig("drop_bounce_coefficient").Value);
			}
			return this.DropBounceCoefficient.Value;
		}

		// Token: 0x06033E0B RID: 212491 RVA: 0x00C278CC File Offset: 0x00C25ACC
		public float GetFriction()
		{
			if (this.DropFriction == null)
			{
				this.DropFriction = new float?(ConfigCommonParamById.GetFloatConfig("drop_friction").Value);
			}
			return this.DropFriction.Value;
		}

		// Token: 0x06033E0C RID: 212492 RVA: 0x00C27910 File Offset: 0x00C25B10
		public int GetDropItemPickUpRange()
		{
			if (this.DropPickUpRange == null)
			{
				this.DropPickUpRange = new int?(ConfigCommonParamById.GetIntConfig("drop_item_pickup_range").Value);
			}
			return this.DropPickUpRange.Value;
		}

		// Token: 0x06033E0D RID: 212493 RVA: 0x00C27954 File Offset: 0x00C25B54
		public int GetPickUpInBagRange()
		{
			if (this.DropPickUpInBagRange == null)
			{
				this.DropPickUpInBagRange = new int?(ConfigCommonParamById.GetIntConfig("drop_pickup_in_bag_range").Value);
			}
			return this.DropPickUpInBagRange.Value;
		}

		// Token: 0x06033E0E RID: 212494 RVA: 0x00C27998 File Offset: 0x00C25B98
		public int GetDropItemAcceleration()
		{
			if (this.AdsorptionAcceleration == null)
			{
				this.AdsorptionAcceleration = new int?(ConfigCommonParamById.GetIntConfig("adsorption_acceleration").Value);
			}
			return this.AdsorptionAcceleration.Value;
		}

		// Token: 0x06033E0F RID: 212495 RVA: 0x00C279DC File Offset: 0x00C25BDC
		public int GetFallToGroundSpeed()
		{
			if (this.FallToGroundSpeed == null)
			{
				this.FallToGroundSpeed = new int?(ConfigCommonParamById.GetIntConfig("drop_fall_ground_speed").Value);
			}
			return this.FallToGroundSpeed.Value;
		}

		// Token: 0x06033E10 RID: 212496 RVA: 0x00C27A20 File Offset: 0x00C25C20
		public int GetDropChestOffsetZ()
		{
			if (this.DropChestOffsetZ == null)
			{
				this.DropChestOffsetZ = new int?(ConfigCommonParamById.GetIntConfig("drop_chest_zaxis_offset").Value);
			}
			return this.DropChestOffsetZ.Value;
		}

		// Token: 0x06033E11 RID: 212497 RVA: 0x00C27A64 File Offset: 0x00C25C64
		public int GetDropBornRadius()
		{
			if (this.DropBornRadius == null)
			{
				this.DropBornRadius = new int?(ConfigCommonParamById.GetIntConfig("drop_born_radius").Value);
			}
			return this.DropBornRadius.Value;
		}

		// Token: 0x06033E12 RID: 212498 RVA: 0x00C27AA8 File Offset: 0x00C25CA8
		public int GetDropRotationProtectTime()
		{
			if (this.DropRotationProtectTime == null)
			{
				this.DropRotationProtectTime = new int?(ConfigCommonParamById.GetIntConfig("drop_lock_rotation_time").Value);
			}
			return this.DropRotationProtectTime.Value;
		}

		// Token: 0x06033E13 RID: 212499 RVA: 0x00C27AEC File Offset: 0x00C25CEC
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

		// Token: 0x06033E14 RID: 212500 RVA: 0x00C27BA8 File Offset: 0x00C25DA8
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

		// Token: 0x06033E15 RID: 212501 RVA: 0x00C27C00 File Offset: 0x00C25E00
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

		// Token: 0x06033E16 RID: 212502 RVA: 0x00C27C58 File Offset: 0x00C25E58
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

		// Token: 0x06033E17 RID: 212503 RVA: 0x00C27CB0 File Offset: 0x00C25EB0
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

		// Token: 0x06033E18 RID: 212504 RVA: 0x00C27D08 File Offset: 0x00C25F08
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

		// Token: 0x06033E19 RID: 212505 RVA: 0x00C27D60 File Offset: 0x00C25F60
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

		// Token: 0x06033E1A RID: 212506 RVA: 0x00C27DBC File Offset: 0x00C25FBC
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

		// Token: 0x06033E1B RID: 212507 RVA: 0x00C27E18 File Offset: 0x00C26018
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

		// Token: 0x06033E1C RID: 212508 RVA: 0x00C27E74 File Offset: 0x00C26074
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

		// Token: 0x17007F33 RID: 32563
		// (get) Token: 0x06033E1D RID: 212509 RVA: 0x00C27F12 File Offset: 0x00C26112
		public static RewardConfig Instance
		{
			get
			{
				return RewardConfig._Instance;
			}
		}

		// Token: 0x06033E1E RID: 212510 RVA: 0x00C27F19 File Offset: 0x00C26119
		public static RewardConfig GetOrCreateInstance()
		{
			if (RewardConfig._Instance == null)
			{
				RewardConfig.CreateInstance();
			}
			return RewardConfig._Instance;
		}

		// Token: 0x06033E1F RID: 212511 RVA: 0x00C27F2D File Offset: 0x00C2612D
		public static bool CreateInstance()
		{
			if (RewardConfig._Instance != null)
			{
				return true;
			}
			RewardConfig._Instance = new RewardConfig();
			return true;
		}

		// Token: 0x06033E20 RID: 212512 RVA: 0x00C27F43 File Offset: 0x00C26143
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033E21 RID: 212513 RVA: 0x00C27F45 File Offset: 0x00C26145
		public static void ResetStaticDefaultValue()
		{
			RewardConfig._Instance = null;
		}

		// Token: 0x06033E22 RID: 212514 RVA: 0x00C27F4D File Offset: 0x00C2614D
		static RewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RewardConfig.CreateStaticDefaultValue), new Action(RewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B933 RID: 112947
		private int? AdsorptionSpeed;

		// Token: 0x0401B934 RID: 112948
		private int? AdsorptionMaxTime;

		// Token: 0x0401B935 RID: 112949
		private int? DropHeightProtect;

		// Token: 0x0401B936 RID: 112950
		private float? DropBounceCoefficient;

		// Token: 0x0401B937 RID: 112951
		private float? DropFriction;

		// Token: 0x0401B938 RID: 112952
		private int? DropPickUpRange;

		// Token: 0x0401B939 RID: 112953
		private int? DropPickUpInBagRange;

		// Token: 0x0401B93A RID: 112954
		private int? AdsorptionAcceleration;

		// Token: 0x0401B93B RID: 112955
		private int? FallToGroundSpeed;

		// Token: 0x0401B93C RID: 112956
		private int? DropChestOffsetZ;

		// Token: 0x0401B93D RID: 112957
		private int? DropBornRadius;

		// Token: 0x0401B93E RID: 112958
		private int? DropRotationProtectTime;

		// Token: 0x0401B93F RID: 112959
		[Nullable(2)]
		private static RewardConfig _Instance;
	}
}
