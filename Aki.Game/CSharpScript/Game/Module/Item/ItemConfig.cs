using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

namespace CSharpScript.Game.Module.Item
{
	// Token: 0x02005824 RID: 22564
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemConfig : ConfigBase
	{
		// Token: 0x0603953B RID: 234811 RVA: 0x00D98D08 File Offset: 0x00D96F08
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

		// Token: 0x0603953C RID: 234812 RVA: 0x00D98D5D File Offset: 0x00D96F5D
		[NullableContext(2)]
		public IReadOnlyList<ItemInfo> GetConfigListByItemType(int itemType)
		{
			return ConfigItemInfoByItemType.GetConfigList(itemType, true);
		}

		// Token: 0x0603953D RID: 234813 RVA: 0x00D98D68 File Offset: 0x00D96F68
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

		// Token: 0x0603953E RID: 234814 RVA: 0x00D98DC0 File Offset: 0x00D96FC0
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

		// Token: 0x0603953F RID: 234815 RVA: 0x00D98E18 File Offset: 0x00D97018
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

		// Token: 0x06039540 RID: 234816 RVA: 0x00D98E70 File Offset: 0x00D97070
		public int GetItemListMaxSize()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("item_list_max_size");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.ZJC, "外入包列表最大数量无法找到, 请检测c.参数字段\"item_list_max_size\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return intConfig.Value;
		}

		// Token: 0x06039541 RID: 234817 RVA: 0x00D98EB4 File Offset: 0x00D970B4
		public int GetPriorItemListMaxSize()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("item_prior_list_max_size");
			if (intConfig == null)
			{
				Log.Instance.Error(ELogModule.Reward, ELogAuthor.LJQ, "外入包列表最大数量无法找到, 请检测c.参数字段\"item_prior_list_max_size\"", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			return intConfig.Value;
		}

		// Token: 0x06039542 RID: 234818 RVA: 0x00D98EF8 File Offset: 0x00D970F8
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

		// Token: 0x06039543 RID: 234819 RVA: 0x00D98F44 File Offset: 0x00D97144
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

		// Token: 0x06039544 RID: 234820 RVA: 0x00D98FC0 File Offset: 0x00D971C0
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

		// Token: 0x17008A29 RID: 35369
		// (get) Token: 0x06039545 RID: 234821 RVA: 0x00D98FF5 File Offset: 0x00D971F5
		public static ItemConfig Instance
		{
			get
			{
				return ItemConfig._Instance;
			}
		}

		// Token: 0x06039546 RID: 234822 RVA: 0x00D98FFC File Offset: 0x00D971FC
		public static ItemConfig GetOrCreateInstance()
		{
			if (ItemConfig._Instance == null)
			{
				ItemConfig.CreateInstance();
			}
			return ItemConfig._Instance;
		}

		// Token: 0x06039547 RID: 234823 RVA: 0x00D99010 File Offset: 0x00D97210
		public static bool CreateInstance()
		{
			if (ItemConfig._Instance != null)
			{
				return true;
			}
			ItemConfig._Instance = new ItemConfig();
			return true;
		}

		// Token: 0x06039548 RID: 234824 RVA: 0x00D99026 File Offset: 0x00D97226
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039549 RID: 234825 RVA: 0x00D99028 File Offset: 0x00D97228
		public static void ResetStaticDefaultValue()
		{
			ItemConfig._Instance = null;
		}

		// Token: 0x0603954A RID: 234826 RVA: 0x00D99030 File Offset: 0x00D97230
		static ItemConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemConfig.CreateStaticDefaultValue), new Action(ItemConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DFBB RID: 122811
		[Nullable(2)]
		private static ItemConfig _Instance;
	}
}
