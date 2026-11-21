using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Aki.Config;

// Token: 0x020017FD RID: 6141
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class PayItemConfig : ConfigBase
{
	// Token: 0x0600F0A5 RID: 61605 RVA: 0x0046B693 File Offset: 0x00469893
	public IReadOnlyList<PayItem> GetPayItemList()
	{
		return ConfigPayItemAll.GetConfigList(true);
	}

	// Token: 0x0600F0A6 RID: 61606 RVA: 0x0046B69C File Offset: 0x0046989C
	public string GetProductIdByPayId(int id)
	{
		Pay? config = ConfigPayById.GetConfig(id, true);
		if (config == null)
		{
			return null;
		}
		return config.GetValueOrDefault().ProductId;
	}

	// Token: 0x0600F0A7 RID: 61607 RVA: 0x0046B6CC File Offset: 0x004698CC
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

	// Token: 0x0600F0A8 RID: 61608 RVA: 0x0046B740 File Offset: 0x00469940
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

	// Token: 0x0600F0A9 RID: 61609 RVA: 0x0046B7B1 File Offset: 0x004699B1
	public IReadOnlyList<Pay> GetCurrentRegionPayConfigList()
	{
		return ConfigPayByRegion.GetConfigList(LoginServerModel.Instance.GetCurrentSelectPayServerName(), true);
	}

	// Token: 0x0600F0AA RID: 61610 RVA: 0x0046B7C3 File Offset: 0x004699C3
	[NullableContext(1)]
	public string GetPayShowCurrency()
	{
		if (KuroSdkController.Instance.GetIfGlobalSdk())
		{
			return this.GetGlobalCurrencyChar();
		}
		return this.GetMainlandCurrencyChar();
	}

	// Token: 0x0600F0AB RID: 61611 RVA: 0x0046B7E0 File Offset: 0x004699E0
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

	// Token: 0x0600F0AC RID: 61612 RVA: 0x0046B838 File Offset: 0x00469A38
	public int? GetPayIdByPayItemId(int payItemId)
	{
		if (ConfigPayItemById.GetConfig(payItemId, true) == null)
		{
			return null;
		}
		PayItem? payItem;
		return new int?(payItem.GetValueOrDefault().PayId);
	}

	// Token: 0x0600F0AD RID: 61613 RVA: 0x0046B874 File Offset: 0x00469A74
	public PayItem? GetPayItem(int payItemId)
	{
		return ConfigPayItemById.GetConfig(payItemId, true);
	}

	// Token: 0x0600F0AE RID: 61614 RVA: 0x0046B87D File Offset: 0x00469A7D
	public int? GetWaitPaySuccessTime()
	{
		return ConfigCommonParamById.GetIntConfig("MaxWaitSuccessTime");
	}

	// Token: 0x0600F0AF RID: 61615 RVA: 0x0046B889 File Offset: 0x00469A89
	public string GetMainlandCurrencyChar()
	{
		return ConfigCommonParamById.GetStringConfig("MainlandCurrencyChar");
	}

	// Token: 0x0600F0B0 RID: 61616 RVA: 0x0046B895 File Offset: 0x00469A95
	public string GetGlobalCurrencyChar()
	{
		return ConfigCommonParamById.GetStringConfig("GlobalCurrencyChar");
	}

	// Token: 0x0600F0B1 RID: 61617 RVA: 0x0046B8A4 File Offset: 0x00469AA4
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

	// Token: 0x0600F0B2 RID: 61618 RVA: 0x0046B908 File Offset: 0x00469B08
	public int GetRechargeItemRate()
	{
		return ConfigCommonParamById.GetIntConfig("RechargeItemRate").GetValueOrDefault();
	}

	// Token: 0x0600F0B3 RID: 61619 RVA: 0x0046B928 File Offset: 0x00469B28
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

	// Token: 0x170016EB RID: 5867
	// (get) Token: 0x0600F0B4 RID: 61620 RVA: 0x0046B998 File Offset: 0x00469B98
	[Nullable(1)]
	public static PayItemConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return PayItemConfig._Instance;
		}
	}

	// Token: 0x0600F0B5 RID: 61621 RVA: 0x0046B99F File Offset: 0x00469B9F
	[NullableContext(1)]
	public static PayItemConfig GetOrCreateInstance()
	{
		if (PayItemConfig._Instance == null)
		{
			PayItemConfig.CreateInstance();
		}
		return PayItemConfig._Instance;
	}

	// Token: 0x0600F0B6 RID: 61622 RVA: 0x0046B9B3 File Offset: 0x00469BB3
	public static bool CreateInstance()
	{
		if (PayItemConfig._Instance != null)
		{
			return true;
		}
		PayItemConfig._Instance = new PayItemConfig();
		return true;
	}

	// Token: 0x0600F0B7 RID: 61623 RVA: 0x0046B9C9 File Offset: 0x00469BC9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F0B8 RID: 61624 RVA: 0x0046B9CB File Offset: 0x00469BCB
	public static void ResetStaticDefaultValue()
	{
		PayItemConfig._Instance = null;
	}

	// Token: 0x0600F0B9 RID: 61625 RVA: 0x0046B9D3 File Offset: 0x00469BD3
	static PayItemConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayItemConfig.CreateStaticDefaultValue), new Action(PayItemConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040087F7 RID: 34807
	private static PayItemConfig _Instance;
}
