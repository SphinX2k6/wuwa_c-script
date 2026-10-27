using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

// Token: 0x02002318 RID: 8984
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PayItemConfig : ConfigBase
{
	// Token: 0x06011BF5 RID: 72693 RVA: 0x0045E627 File Offset: 0x0045C827
	public IReadOnlyList<PayItem> GetPayItemList()
	{
		return ConfigPayItemAll.GetConfigList(true);
	}

	// Token: 0x06011BF6 RID: 72694 RVA: 0x0045E630 File Offset: 0x0045C830
	public string GetProductIdByPayId(int id)
	{
		Pay? config = ConfigPayById.GetConfig(id, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().ProductId;
	}

	// Token: 0x06011BF7 RID: 72695 RVA: 0x0045E660 File Offset: 0x0045C860
	public string GetProductIdByPayItemId(int payItemId)
	{
		PayItem? payItem;
		int? num = (ConfigPayItemById.GetConfig(payItemId, true) != null) ? new int?(payItem.GetValueOrDefault().PayId) : null;
		if (num == null)
		{
			return null;
		}
		Pay? config = ConfigPayById.GetConfig(num.Value, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().ProductId;
	}

	// Token: 0x06011BF8 RID: 72696 RVA: 0x0045E6D4 File Offset: 0x0045C8D4
	public Pay? GetPayConf(int payId)
	{
		string currentSelectPayServerName = LoginServerModel.Instance.GetCurrentSelectPayServerName();
		if (KuroSdkController.Instance.CanUseSdk())
		{
			IReadOnlyList<Pay> configList = ConfigPayByPayIdAndRegion.GetConfigList(payId, currentSelectPayServerName, true);
			if (configList != null && configList.Count > 0)
			{
				return new Pay?(configList[0]);
			}
		}
		IReadOnlyList<Pay> configList2 = ConfigPayByPayIdAndRegion.GetConfigList(payId, currentSelectPayServerName, true);
		if (configList2 != null && configList2.Count > 0)
		{
			return new Pay?(configList2[0]);
		}
		return null;
	}

	// Token: 0x06011BF9 RID: 72697 RVA: 0x0045E745 File Offset: 0x0045C945
	public IReadOnlyList<Pay> GetCurrentRegionPayConfigList()
	{
		return ConfigPayByRegion.GetConfigList(LoginServerModel.Instance.GetCurrentSelectPayServerName(), true);
	}

	// Token: 0x06011BFA RID: 72698 RVA: 0x0045E757 File Offset: 0x0045C957
	[NullableContext(1)]
	public string GetPayShowCurrency()
	{
		if (KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return this.GetGlobalCurrencyChar();
		}
		return this.GetMainlandCurrencyChar();
	}

	// Token: 0x06011BFB RID: 72699 RVA: 0x0045E774 File Offset: 0x0045C974
	[NullableContext(1)]
	public string GetPayShow(int payId)
	{
		KuroSdkModel instance = KuroSdkModel.Instance;
		string text = (instance != null) ? instance.GetQueryProductShowPrice(payId.ToString()) : null;
		if (text != null)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder();
		string payShowCurrency = this.GetPayShowCurrency();
		stringBuilder.Append(payShowCurrency);
		string payIdAmount = RechargeModel.Instance.GetPayIdAmount(payId);
		stringBuilder.Append(payIdAmount);
		return stringBuilder.ToString();
	}

	// Token: 0x06011BFC RID: 72700 RVA: 0x0045E7CC File Offset: 0x0045C9CC
	public int? GetPayIdByPayItemId(int payItemId)
	{
		if (ConfigPayItemById.GetConfig(payItemId, true) == null)
		{
			return null;
		}
		PayItem? payItem;
		return new int?(payItem.GetValueOrDefault().PayId);
	}

	// Token: 0x06011BFD RID: 72701 RVA: 0x0045E808 File Offset: 0x0045CA08
	public PayItem? GetPayItem(int payItemId)
	{
		return ConfigPayItemById.GetConfig(payItemId, true);
	}

	// Token: 0x06011BFE RID: 72702 RVA: 0x0045E811 File Offset: 0x0045CA11
	public int? GetWaitPaySuccessTime()
	{
		return ConfigCommonParamById.GetIntConfig("MaxWaitSuccessTime");
	}

	// Token: 0x06011BFF RID: 72703 RVA: 0x0045E81D File Offset: 0x0045CA1D
	public string GetMainlandCurrencyChar()
	{
		return ConfigCommonParamById.GetStringConfig("MainlandCurrencyChar");
	}

	// Token: 0x06011C00 RID: 72704 RVA: 0x0045E829 File Offset: 0x0045CA29
	public string GetGlobalCurrencyChar()
	{
		return ConfigCommonParamById.GetStringConfig("GlobalCurrencyChar");
	}

	// Token: 0x06011C01 RID: 72705 RVA: 0x0045E838 File Offset: 0x0045CA38
	public PayGift? GetRechargeGiftConfig(int id)
	{
		foreach (PayGift value in ConfigPayGiftAll.GetConfigList(true))
		{
			if (value.Id == id)
			{
				return new PayGift?(value);
			}
		}
		return null;
	}

	// Token: 0x06011C02 RID: 72706 RVA: 0x0045E89C File Offset: 0x0045CA9C
	public int GetRechargeItemRate()
	{
		return ConfigCommonParamById.GetIntConfig("RechargeItemRate").GetValueOrDefault();
	}

	// Token: 0x06011C03 RID: 72707 RVA: 0x0045E8BC File Offset: 0x0045CABC
	[NullableContext(1)]
	public string GetRegionMainCurrency()
	{
		IReadOnlyList<string> readOnlyList = ConfigCommonParamById.GetStringArrayConfig("RegionMainCurrency") ?? Array.Empty<string>();
		string currentSelectPayServerName = LoginServerModel.Instance.GetCurrentSelectPayServerName();
		int count = readOnlyList.Count;
		for (int i = 0; i < count; i++)
		{
			string[] array = readOnlyList[i].Split(":", StringSplitOptions.None);
			if (array.Length == 2 && array[0] == currentSelectPayServerName)
			{
				return array[1];
			}
		}
		return "";
	}

	// Token: 0x170016B1 RID: 5809
	// (get) Token: 0x06011C04 RID: 72708 RVA: 0x0045E92C File Offset: 0x0045CB2C
	[Nullable(1)]
	public static PayItemConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PayItemConfig._Instance;
		}
	}

	// Token: 0x06011C05 RID: 72709 RVA: 0x0045E933 File Offset: 0x0045CB33
	[NullableContext(1)]
	public static PayItemConfig GetOrCreateInstance()
	{
		if (PayItemConfig._Instance == null)
		{
			PayItemConfig.CreateInstance();
		}
		return PayItemConfig._Instance;
	}

	// Token: 0x06011C06 RID: 72710 RVA: 0x0045E947 File Offset: 0x0045CB47
	public static bool CreateInstance()
	{
		if (PayItemConfig._Instance != null)
		{
			return true;
		}
		PayItemConfig._Instance = new PayItemConfig();
		return true;
	}

	// Token: 0x06011C07 RID: 72711 RVA: 0x0045E95D File Offset: 0x0045CB5D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011C08 RID: 72712 RVA: 0x0045E95F File Offset: 0x0045CB5F
	public static void ResetStaticDefaultValue()
	{
		PayItemConfig._Instance = null;
	}

	// Token: 0x06011C09 RID: 72713 RVA: 0x0045E967 File Offset: 0x0045CB67
	static PayItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayItemConfig.CreateStaticDefaultValue), new Action(PayItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040086B4 RID: 34484
	private static PayItemConfig _Instance;
}
