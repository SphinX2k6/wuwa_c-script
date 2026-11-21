using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200183A RID: 6202
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PayShopConfig : ConfigBase
{
	// Token: 0x0600F4E5 RID: 62693 RVA: 0x00477D1D File Offset: 0x00475F1D
	public string GetPayShopGoodsLocalText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x0600F4E6 RID: 62694 RVA: 0x00477D28 File Offset: 0x00475F28
	public PayShop GetPayShopConfig(int payShopId)
	{
		PayShop? config = ConfigPayShopById.GetConfig(payShopId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查询商城数据失败,查看商业化商城表格PayShop";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("商城ID", payShopId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600F4E7 RID: 62695 RVA: 0x00477D7C File Offset: 0x00475F7C
	public PayShopDirectGoods GetPayShopDirectGoods(int goodsId)
	{
		PayShopDirectGoods? config = ConfigPayShopDirectGoodsByGoodsId.GetConfig(goodsId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查询直购商品ID数据失败,查看商业化商城表格PayShopDirectGoods";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("直购商品ID", goodsId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600F4E8 RID: 62696 RVA: 0x00477DD0 File Offset: 0x00475FD0
	public PayShopCondition GetPayShopCondition(int conditionId)
	{
		PayShopCondition? config = ConfigPayShopConditionById.GetConfig(conditionId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Config;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查询商品条件ID数据失败,查看商业化商城表格PayShopCondition";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("商品条件ID", conditionId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return config.Value;
	}

	// Token: 0x0600F4E9 RID: 62697 RVA: 0x00477E21 File Offset: 0x00476021
	public string GetPayShopConditionLocalText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x0600F4EA RID: 62698 RVA: 0x00477E2C File Offset: 0x0047602C
	public string GetShopDiscountLabel(int type)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("ShopDiscountLabel_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(type);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600F4EB RID: 62699 RVA: 0x00477E60 File Offset: 0x00476060
	public int GetMonthCardShopId()
	{
		return ConfigCommonParamById.GetIntConfig("MonthCardPayItemId").Value;
	}

	// Token: 0x0600F4EC RID: 62700 RVA: 0x00477E80 File Offset: 0x00476080
	public int GetMonthCardRewardId()
	{
		return ConfigCommonParamById.GetIntConfig("MonthCardRewardId").Value;
	}

	// Token: 0x0600F4ED RID: 62701 RVA: 0x00477E9F File Offset: 0x0047609F
	public IReadOnlyList<int> GetRecommendRoleSkinIdList()
	{
		return ConfigCommonParamById.GetIntArrayConfig("RecommendRoleSkinId");
	}

	// Token: 0x0600F4EE RID: 62702 RVA: 0x00477EAC File Offset: 0x004760AC
	public PayShopRecommend GetRecommendDataById(int id)
	{
		return ConfigPayShopRecommendById.GetConfig(id, true).Value;
	}

	// Token: 0x0600F4EF RID: 62703 RVA: 0x00477EC8 File Offset: 0x004760C8
	public int GetBuySkinDetailWeaponCameraId()
	{
		return ConfigCommonParamById.GetIntConfig("BuySkinDetailWeaponCameraId").Value;
	}

	// Token: 0x0600F4F0 RID: 62704 RVA: 0x00477EE8 File Offset: 0x004760E8
	public int GetBuySkinDetailRoleCameraId()
	{
		return ConfigCommonParamById.GetIntConfig("BuySkinDetailRoleCameraId").Value;
	}

	// Token: 0x0600F4F1 RID: 62705 RVA: 0x00477F07 File Offset: 0x00476107
	public string GetBuySkinDetailRoleCameraConfigId()
	{
		return ConfigCommonParamById.GetStringConfig("BuySkinDetailRoleCameraConfigId");
	}

	// Token: 0x0600F4F2 RID: 62706 RVA: 0x00477F13 File Offset: 0x00476113
	public string GetBuySkinDetailWeaponCameraConfigId()
	{
		return ConfigCommonParamById.GetStringConfig("BuySkinDetailWeaponCameraConfigId");
	}

	// Token: 0x0600F4F3 RID: 62707 RVA: 0x00477F20 File Offset: 0x00476120
	public int GetPreviewPayGiftItemTemplateId()
	{
		return ConfigCommonParamById.GetIntConfig("PayGiftTemplateId").Value;
	}

	// Token: 0x170017C8 RID: 6088
	// (get) Token: 0x0600F4F4 RID: 62708 RVA: 0x00477F3F File Offset: 0x0047613F
	public static PayShopConfig Instance
	{
		get
		{
			return PayShopConfig._Instance;
		}
	}

	// Token: 0x0600F4F5 RID: 62709 RVA: 0x00477F46 File Offset: 0x00476146
	public static PayShopConfig GetOrCreateInstance()
	{
		if (PayShopConfig._Instance == null)
		{
			PayShopConfig.CreateInstance();
		}
		return PayShopConfig._Instance;
	}

	// Token: 0x0600F4F6 RID: 62710 RVA: 0x00477F5A File Offset: 0x0047615A
	public static bool CreateInstance()
	{
		if (PayShopConfig._Instance != null)
		{
			return true;
		}
		PayShopConfig._Instance = new PayShopConfig();
		return true;
	}

	// Token: 0x0600F4F7 RID: 62711 RVA: 0x00477F70 File Offset: 0x00476170
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F4F8 RID: 62712 RVA: 0x00477F72 File Offset: 0x00476172
	public static void ResetStaticDefaultValue()
	{
		PayShopConfig._Instance = null;
	}

	// Token: 0x0600F4F9 RID: 62713 RVA: 0x00477F7A File Offset: 0x0047617A
	static PayShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopConfig.CreateStaticDefaultValue), new Action(PayShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400894A RID: 35146
	[Nullable(2)]
	private static PayShopConfig _Instance;
}
