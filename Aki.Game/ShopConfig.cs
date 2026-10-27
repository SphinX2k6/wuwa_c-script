using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020029EA RID: 10730
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class ShopConfig : ConfigBase
{
	// Token: 0x06016411 RID: 91153 RVA: 0x005A11E0 File Offset: 0x0059F3E0
	[return: Nullable(2)]
	public string GetTextConfig(string key)
	{
		return TextConfig.Instance.GetTextById(key);
	}

	// Token: 0x06016412 RID: 91154 RVA: 0x005A11ED File Offset: 0x0059F3ED
	[return: Nullable(2)]
	public string GetShopName(string shopNameId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(shopNameId, null);
	}

	// Token: 0x06016413 RID: 91155 RVA: 0x005A11F8 File Offset: 0x0059F3F8
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

	// Token: 0x06016414 RID: 91156 RVA: 0x005A124C File Offset: 0x0059F44C
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

	// Token: 0x06016415 RID: 91157 RVA: 0x005A1290 File Offset: 0x0059F490
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

	// Token: 0x17001DB6 RID: 7606
	// (get) Token: 0x06016416 RID: 91158 RVA: 0x005A130D File Offset: 0x0059F50D
	public static ShopConfig Instance
	{
		get
		{
			return ShopConfig._Instance;
		}
	}

	// Token: 0x06016417 RID: 91159 RVA: 0x005A1314 File Offset: 0x0059F514
	public static ShopConfig GetOrCreateInstance()
	{
		if (ShopConfig._Instance == null)
		{
			ShopConfig.CreateInstance();
		}
		return ShopConfig._Instance;
	}

	// Token: 0x06016418 RID: 91160 RVA: 0x005A1328 File Offset: 0x0059F528
	public static bool CreateInstance()
	{
		if (ShopConfig._Instance != null)
		{
			return true;
		}
		ShopConfig._Instance = new ShopConfig();
		return true;
	}

	// Token: 0x06016419 RID: 91161 RVA: 0x005A133E File Offset: 0x0059F53E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601641A RID: 91162 RVA: 0x005A1340 File Offset: 0x0059F540
	public static void ResetStaticDefaultValue()
	{
		ShopConfig._Instance = null;
	}

	// Token: 0x0601641B RID: 91163 RVA: 0x005A1348 File Offset: 0x0059F548
	static ShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ShopConfig.CreateStaticDefaultValue), new Action(ShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400A592 RID: 42386
	[Nullable(2)]
	private static ShopConfig _Instance;
}
