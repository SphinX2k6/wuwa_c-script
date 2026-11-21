using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F65 RID: 8037
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ShopConfig : ConfigBase
{
	// Token: 0x06013E18 RID: 81432 RVA: 0x005CC1D4 File Offset: 0x005CA3D4
	[return: Nullable(2)]
	public string GetTextConfig(string key)
	{
		return TextConfig.Instance.GetTextById(key);
	}

	// Token: 0x06013E19 RID: 81433 RVA: 0x005CC1E1 File Offset: 0x005CA3E1
	[return: Nullable(2)]
	public string GetShopName(string shopNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(shopNameId, null);
	}

	// Token: 0x06013E1A RID: 81434 RVA: 0x005CC1EC File Offset: 0x005CA3EC
	public ShopInfo GetShopInfoConfig(int shopId)
	{
		ShopInfo? config = ConfigShopInfoById.GetConfig(shopId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "查表ShopInfo错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", shopId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x06013E1B RID: 81435 RVA: 0x005CC240 File Offset: 0x005CA440
	public IReadOnlyList<ShopFixed> GetFixedShopList(int shopId)
	{
		IReadOnlyList<ShopFixed> configList = ConfigShopFixedByShopId.GetConfigList(shopId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "表ShopFixed配置找不到";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ShopId", shopId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return configList;
	}

	// Token: 0x06013E1C RID: 81436 RVA: 0x005CC284 File Offset: 0x005CA484
	public unsafe ShopFixed? GetShopFixedInfoByItemId(int shopId, int id)
	{
		ShopFixed? config = ConfigShopFixedByShopIdAndId.GetConfig(shopId, id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Shop;
			ELogAuthor author = ELogAuthor.YSQ;
			string message = "表ShopFixed配置找不到";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ShopId", shopId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", id);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		return config;
	}

	// Token: 0x17001E0F RID: 7695
	// (get) Token: 0x06013E1D RID: 81437 RVA: 0x005CC301 File Offset: 0x005CA501
	public static ShopConfig Instance
	{
		get
		{
			return ShopConfig._Instance;
		}
	}

	// Token: 0x06013E1E RID: 81438 RVA: 0x005CC308 File Offset: 0x005CA508
	public static ShopConfig GetOrCreateInstance()
	{
		if (ShopConfig._Instance == null)
		{
			ShopConfig.CreateInstance();
		}
		return ShopConfig._Instance;
	}

	// Token: 0x06013E1F RID: 81439 RVA: 0x005CC31C File Offset: 0x005CA51C
	public static bool CreateInstance()
	{
		if (ShopConfig._Instance != null)
		{
			return true;
		}
		ShopConfig._Instance = new ShopConfig();
		return true;
	}

	// Token: 0x06013E20 RID: 81440 RVA: 0x005CC332 File Offset: 0x005CA532
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013E21 RID: 81441 RVA: 0x005CC334 File Offset: 0x005CA534
	public static void ResetStaticDefaultValue()
	{
		ShopConfig._Instance = null;
	}

	// Token: 0x06013E22 RID: 81442 RVA: 0x005CC33C File Offset: 0x005CA53C
	static ShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopConfig.CreateStaticDefaultValue), new Action(ShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A97C RID: 43388
	[Nullable(2)]
	private static ShopConfig _Instance;
}
