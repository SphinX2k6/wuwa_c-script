using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x020047FB RID: 18427
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemConfig : ConfigBase
	{
		// Token: 0x0602E44F RID: 189519 RVA: 0x00CE7B94 File Offset: 0x00CE5D94
		public ItemInfo? GetConfig(int itemConfigId)
		{
			ItemInfo? config = ConfigItemInfoById.GetConfig(itemConfigId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取物品配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemConfigId", itemConfigId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0602E450 RID: 189520 RVA: 0x00CE7BE9 File Offset: 0x00CE5DE9
		[NullableContext(2)]
		public IReadOnlyList<ItemInfo> GetConfigListByItemType(int itemType)
		{
			return ConfigItemInfoByItemType.GetConfigList(itemType, true);
		}

		// Token: 0x0602E451 RID: 189521 RVA: 0x00CE7BF4 File Offset: 0x00CE5DF4
		public SpecialItem? GetSpecialItemConfig(int specialItemId)
		{
			SpecialItem? config = ConfigSpecialItemById.GetConfig(specialItemId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "获取特殊物品配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("specialItemId", specialItemId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0602E452 RID: 189522 RVA: 0x00CE7C4C File Offset: 0x00CE5E4C
		public ItemMainType? GetMainTypeConfig(int mainType)
		{
			ItemMainType? config = ConfigItemMainTypeById.GetConfig(mainType, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取物品主类型配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("mainType", mainType);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0602E453 RID: 189523 RVA: 0x00CE7CA4 File Offset: 0x00CE5EA4
		public QualityInfo? GetQualityConfig(int qualityId)
		{
			QualityInfo? config = ConfigQualityInfoById.GetConfig(qualityId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Item;
				ELogAuthor author = ELogAuthor.TL;
				string message = "获取获取物品品质配置错误";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("qualityId", qualityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0602E454 RID: 189524 RVA: 0x00CE7CFC File Offset: 0x00CE5EFC
		public int GetItemListMaxSize()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("item_list_max_size");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "外入包列表最大数量无法找到, 请检测c.参数字段\"item_list_max_size\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return intConfig.Value;
		}

		// Token: 0x0602E455 RID: 189525 RVA: 0x00CE7D40 File Offset: 0x00CE5F40
		public int GetPriorItemListMaxSize()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("item_prior_list_max_size");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.LJQ, "外入包列表最大数量无法找到, 请检测c.参数字段\"item_prior_list_max_size\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return intConfig.Value;
		}

		// Token: 0x0602E456 RID: 189526 RVA: 0x00CE7D84 File Offset: 0x00CE5F84
		public string GetItemName(int itemId)
		{
			ItemInfo? itemInfo;
			string text = (this.GetConfig(itemId) != null) ? itemInfo.GetValueOrDefault().Name : null;
			if (text != null)
			{
				return ConfigMultiTextLang.GetLocalTextNew(text, null) ?? string.Empty;
			}
			return string.Empty;
		}

		// Token: 0x0602E457 RID: 189527 RVA: 0x00CE7DD0 File Offset: 0x00CE5FD0
		[NullableContext(2)]
		public unsafe string GetItemDesc(int itemId)
		{
			ItemInfo? config = this.GetConfig(itemId);
			if (config == null)
			{
				return null;
			}
			Span<int> showTypesBytes = config.Value.GetShowTypesBytes();
			int num = (showTypesBytes.Length > 0) ? (*showTypesBytes[0]) : 0;
			if (num == 0)
			{
				return null;
			}
			ItemShowType? itemShowTypeConfig = InventoryConfig.Instance.GetItemShowTypeConfig(num);
			if (itemShowTypeConfig == null)
			{
				return null;
			}
			return ConfigMultiTextLang.GetLocalTextNew(itemShowTypeConfig.Value.Name, null);
		}

		// Token: 0x0602E458 RID: 189528 RVA: 0x00CE7E4C File Offset: 0x00CE604C
		[NullableContext(2)]
		public string GetItemAttributeDesc(int itemId)
		{
			ItemInfo? config = this.GetConfig(itemId);
			if (config == null)
			{
				return null;
			}
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.AttributesDescription, null);
		}

		// Token: 0x17005DF3 RID: 24051
		// (get) Token: 0x0602E459 RID: 189529 RVA: 0x00CE7E81 File Offset: 0x00CE6081
		public static ItemConfig Instance
		{
			get
			{
				return ItemConfig._Instance;
			}
		}

		// Token: 0x0602E45A RID: 189530 RVA: 0x00CE7E88 File Offset: 0x00CE6088
		public static ItemConfig GetOrCreateInstance()
		{
			if (ItemConfig._Instance == null)
			{
				ItemConfig.CreateInstance();
			}
			return ItemConfig._Instance;
		}

		// Token: 0x0602E45B RID: 189531 RVA: 0x00CE7E9C File Offset: 0x00CE609C
		public static bool CreateInstance()
		{
			if (ItemConfig._Instance != null)
			{
				return true;
			}
			ItemConfig._Instance = new ItemConfig();
			return true;
		}

		// Token: 0x0602E45C RID: 189532 RVA: 0x00CE7EB2 File Offset: 0x00CE60B2
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E45D RID: 189533 RVA: 0x00CE7EB4 File Offset: 0x00CE60B4
		public static void ResetStaticDefaultValue()
		{
			ItemConfig._Instance = null;
		}

		// Token: 0x0602E45E RID: 189534 RVA: 0x00CE7EBC File Offset: 0x00CE60BC
		static ItemConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemConfig.CreateStaticDefaultValue), new Action(ItemConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018A52 RID: 100946
		[Nullable(2)]
		private static ItemConfig _Instance;
	}
}
