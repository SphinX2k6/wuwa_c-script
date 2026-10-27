using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002355 RID: 9045
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PayShopConfig : ConfigBase
{
	// Token: 0x06012035 RID: 73781 RVA: 0x0046AC61 File Offset: 0x00468E61
	public string GetPayShopGoodsLocalText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x06012036 RID: 73782 RVA: 0x0046AC6C File Offset: 0x00468E6C
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

	// Token: 0x06012037 RID: 73783 RVA: 0x0046ACC0 File Offset: 0x00468EC0
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

	// Token: 0x06012038 RID: 73784 RVA: 0x0046AD14 File Offset: 0x00468F14
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

	// Token: 0x06012039 RID: 73785 RVA: 0x0046AD65 File Offset: 0x00468F65
	public string GetPayShopConditionLocalText(string textId)
	{
		return ConfigMultiTextLang.GetLocalTextNew(textId, null);
	}

	// Token: 0x0601203A RID: 73786 RVA: 0x0046AD70 File Offset: 0x00468F70
	public string GetShopDiscountLabel(int type)
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
		defaultInterpolatedStringHandler.AppendLiteral("ShopDiscountLabel_");
		defaultInterpolatedStringHandler.AppendFormatted<int>(type);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0601203B RID: 73787 RVA: 0x0046ADA4 File Offset: 0x00468FA4
	public int GetMonthCardShopId()
	{
		return ConfigCommonParamById.GetIntConfig("MonthCardPayItemId").Value;
	}

	// Token: 0x0601203C RID: 73788 RVA: 0x0046ADC4 File Offset: 0x00468FC4
	public int GetMonthCardRewardId()
	{
		return ConfigCommonParamById.GetIntConfig("MonthCardRewardId").Value;
	}

	// Token: 0x0601203D RID: 73789 RVA: 0x0046ADE3 File Offset: 0x00468FE3
	public IReadOnlyList<int> GetRecommendRoleSkinIdList()
	{
		return ConfigCommonParamById.GetIntArrayConfig("RecommendRoleSkinId");
	}

	// Token: 0x0601203E RID: 73790 RVA: 0x0046ADF0 File Offset: 0x00468FF0
	public PayShopRecommend GetRecommendDataById(int id)
	{
		return ConfigPayShopRecommendById.GetConfig(id, true).Value;
	}

	// Token: 0x0601203F RID: 73791 RVA: 0x0046AE0C File Offset: 0x0046900C
	public int GetBuySkinDetailWeaponCameraId()
	{
		return ConfigCommonParamById.GetIntConfig("BuySkinDetailWeaponCameraId").Value;
	}

	// Token: 0x06012040 RID: 73792 RVA: 0x0046AE2C File Offset: 0x0046902C
	public int GetBuySkinDetailRoleCameraId()
	{
		return ConfigCommonParamById.GetIntConfig("BuySkinDetailRoleCameraId").Value;
	}

	// Token: 0x06012041 RID: 73793 RVA: 0x0046AE4B File Offset: 0x0046904B
	public string GetBuySkinDetailRoleCameraConfigId()
	{
		return ConfigCommonParamById.GetStringConfig("BuySkinDetailRoleCameraConfigId");
	}

	// Token: 0x06012042 RID: 73794 RVA: 0x0046AE57 File Offset: 0x00469057
	public string GetBuySkinDetailWeaponCameraConfigId()
	{
		return ConfigCommonParamById.GetStringConfig("BuySkinDetailWeaponCameraConfigId");
	}

	// Token: 0x06012043 RID: 73795 RVA: 0x0046AE64 File Offset: 0x00469064
	public int GetPreviewPayGiftItemTemplateId()
	{
		return ConfigCommonParamById.GetIntConfig("PayGiftTemplateId").Value;
	}

	// Token: 0x1700178E RID: 6030
	// (get) Token: 0x06012044 RID: 73796 RVA: 0x0046AE83 File Offset: 0x00469083
	public static PayShopConfig Instance
	{
		get
		{
			return PayShopConfig._Instance;
		}
	}

	// Token: 0x06012045 RID: 73797 RVA: 0x0046AE8A File Offset: 0x0046908A
	public static PayShopConfig GetOrCreateInstance()
	{
		if (PayShopConfig._Instance == null)
		{
			PayShopConfig.CreateInstance();
		}
		return PayShopConfig._Instance;
	}

	// Token: 0x06012046 RID: 73798 RVA: 0x0046AE9E File Offset: 0x0046909E
	public static bool CreateInstance()
	{
		if (PayShopConfig._Instance != null)
		{
			return true;
		}
		PayShopConfig._Instance = new PayShopConfig();
		return true;
	}

	// Token: 0x06012047 RID: 73799 RVA: 0x0046AEB4 File Offset: 0x004690B4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012048 RID: 73800 RVA: 0x0046AEB6 File Offset: 0x004690B6
	public static void ResetStaticDefaultValue()
	{
		PayShopConfig._Instance = null;
	}

	// Token: 0x06012049 RID: 73801 RVA: 0x0046AEBE File Offset: 0x004690BE
	static PayShopConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayShopConfig.CreateStaticDefaultValue), new Action(PayShopConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008807 RID: 34823
	[Nullable(2)]
	private static PayShopConfig _Instance;
}
