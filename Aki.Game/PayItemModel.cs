using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Item;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x0200231C RID: 8988
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayItemModel : ModelBase
{
	// Token: 0x06011C33 RID: 72755 RVA: 0x0045F558 File Offset: 0x0045D758
	public void UpdateProductInfoMap(IEnumerable<DisplayProductInfo> data)
	{
		foreach (DisplayProductInfo displayProductInfo in data)
		{
			this.ProductInfoMap[displayProductInfo.GoodId] = displayProductInfo;
		}
	}

	// Token: 0x06011C34 RID: 72756 RVA: 0x0045F5AC File Offset: 0x0045D7AC
	[return: Nullable(2)]
	public string GetProductLabelByGoodsId(string goodsId)
	{
		DisplayProductInfo displayProductInfo;
		if (!this.ProductInfoMap.TryGetValue(goodsId, out displayProductInfo))
		{
			return null;
		}
		return displayProductInfo.GoodLabel;
	}

	// Token: 0x06011C35 RID: 72757 RVA: 0x0045F5D4 File Offset: 0x0045D7D4
	[return: Nullable(2)]
	public string GetProductChannelGoodsIdByGoodsId(string goodsId)
	{
		DisplayProductInfo displayProductInfo;
		if (!this.ProductInfoMap.TryGetValue(goodsId, out displayProductInfo))
		{
			return null;
		}
		return displayProductInfo.ChannelGoodId;
	}

	// Token: 0x06011C36 RID: 72758 RVA: 0x0045F5FC File Offset: 0x0045D7FC
	[return: Nullable(2)]
	public DisplayProductInfo GetProductInfoByGoodsId(string goodsId)
	{
		DisplayProductInfo result;
		if (!this.ProductInfoMap.TryGetValue(goodsId, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06011C37 RID: 72759 RVA: 0x0045F61C File Offset: 0x0045D81C
	[return: Nullable(2)]
	public string GetProductCurrencyByGoodsId(string goodsId)
	{
		DisplayProductInfo displayProductInfo2;
		DisplayProductInfo displayProductInfo = this.ProductInfoMap.TryGetValue(goodsId, out displayProductInfo2) ? displayProductInfo2 : null;
		string text = (displayProductInfo != null && displayProductInfo.Price != null) ? displayProductInfo.Price : null;
		if (text == null)
		{
			return null;
		}
		Match match = Regex.Match(text, "[a-zA-Z]+$");
		if (!match.Success)
		{
			return null;
		}
		return match.Value;
	}

	// Token: 0x06011C38 RID: 72760 RVA: 0x0045F674 File Offset: 0x0045D874
	[return: Nullable(2)]
	public string GetProductPriceByGoodsId(string goodsId)
	{
		DisplayProductInfo displayProductInfo2;
		DisplayProductInfo displayProductInfo = this.ProductInfoMap.TryGetValue(goodsId, out displayProductInfo2) ? displayProductInfo2 : null;
		string text = (displayProductInfo != null && displayProductInfo.Price != null) ? displayProductInfo.Price : null;
		if (text == null)
		{
			return null;
		}
		Match match = Regex.Match(text, "^[\\d,.]+");
		if (!match.Success)
		{
			return null;
		}
		return match.Value;
	}

	// Token: 0x06011C39 RID: 72761 RVA: 0x0045F6CC File Offset: 0x0045D8CC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PayItemData> GetDataList()
	{
		return this.CurrentPayItemDataList;
	}

	// Token: 0x06011C3A RID: 72762 RVA: 0x0045F6D4 File Offset: 0x0045D8D4
	[NullableContext(2)]
	public string GetPayingItemName()
	{
		return this.PayingItemName;
	}

	// Token: 0x06011C3B RID: 72763 RVA: 0x0045F6DC File Offset: 0x0045D8DC
	public void CleanPayingItemName()
	{
		this.PayingItemName = null;
	}

	// Token: 0x06011C3C RID: 72764 RVA: 0x0045F6E5 File Offset: 0x0045D8E5
	public PayShopItemBaseSt ConvertPayItemDataToPayShopItemBaseSt(PayItemData source)
	{
		return source.ConvertPayItemDataToPayShopItemBaseSt();
	}

	// Token: 0x06011C3D RID: 72765 RVA: 0x0045F6F0 File Offset: 0x0045D8F0
	public void UpdatePayingItemName(int payItemId)
	{
		PayItem? payItem = PayItemConfig.Instance.GetPayItem(payItemId);
		string itemName = ItemConfig.Instance.GetItemName(payItem.Value.ItemId);
		this.PayingItemName = itemName;
	}

	// Token: 0x06011C3E RID: 72766 RVA: 0x0045F72C File Offset: 0x0045D92C
	public void ResetSpecialBonus(int[] ids)
	{
		foreach (int key in ids)
		{
			PayItemData payItemData;
			if (this.CurrencyPayItemMap.TryGetValue(key, out payItemData))
			{
				payItemData.CanSpecialBonus = true;
			}
		}
	}

	// Token: 0x06011C3F RID: 72767 RVA: 0x0045F764 File Offset: 0x0045D964
	public void InitDataListByServer(PayItemInfo[] infos)
	{
		if (this.CurrentPayItemDataList.Count != 0 && infos.Length != 0)
		{
			this.CurrentPayItemDataList.Clear();
		}
		foreach (PayItemInfo payItemInfo in infos)
		{
			PayItemData payItemData = new PayItemData();
			payItemData.Phrase(payItemInfo);
			this.CurrentPayItemDataList.Add(payItemData);
			this.CurrencyPayItemMap[payItemInfo.Id] = payItemData;
		}
	}

	// Token: 0x06011C40 RID: 72768 RVA: 0x0045F7CC File Offset: 0x0045D9CC
	protected override bool OnClear()
	{
		this.CurrentPayItemDataList.Clear();
		this.CurrentPayItemDataList = null;
		this.CurrencyPayItemMap.Clear();
		this.Version = "";
		this.PayingItemName = null;
		return true;
	}

	// Token: 0x06011C41 RID: 72769 RVA: 0x0045F800 File Offset: 0x0045DA00
	public ISDKPayment CreateSdkPayment(int payItemId, string orderId, string callBackUrl)
	{
		PayItem? payItem = PayItemConfig.Instance.GetPayItem(payItemId);
		string itemName = ItemConfig.Instance.GetItemName(payItem.Value.ItemId);
		string itemDesc = ItemConfig.Instance.GetItemDesc(payItem.Value.ItemId);
		int payId = payItem.Value.PayId;
		string payIdAmount = RechargeModel.Instance.GetPayIdAmount(payId);
		string payIdProductId = RechargeModel.Instance.GetPayIdProductId(payId);
		SDKPayment sdkpayment = new SDKPayment();
		sdkpayment.product_id = payIdProductId;
		sdkpayment.cpOrderId = orderId;
		sdkpayment.price = payIdAmount;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted(itemName);
		defaultInterpolatedStringHandler.AppendFormatted<int>(payItem.Value.ItemCount);
		sdkpayment.goodsName = defaultInterpolatedStringHandler.ToStringAndClear();
		defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
		defaultInterpolatedStringHandler.AppendFormatted(itemDesc);
		defaultInterpolatedStringHandler.AppendFormatted<int>(payItem.Value.ItemCount);
		sdkpayment.goodsDesc = defaultInterpolatedStringHandler.ToStringAndClear();
		sdkpayment.extraParams = " ";
		sdkpayment.callbackUrl = callBackUrl;
		sdkpayment.currency = "";
		return sdkpayment;
	}

	// Token: 0x06011C42 RID: 72770 RVA: 0x0045F924 File Offset: 0x0045DB24
	public bool HasBonusData()
	{
		if (this.CurrentPayItemDataList.Count == 0)
		{
			return false;
		}
		using (List<PayItemData>.Enumerator enumerator = this.CurrentPayItemDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.CanSpecialBonus)
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x170016B3 RID: 5811
	// (get) Token: 0x06011C43 RID: 72771 RVA: 0x0045F98C File Offset: 0x0045DB8C
	public static PayItemModel Instance
	{
		get
		{
			return PayItemModel._Instance;
		}
	}

	// Token: 0x06011C44 RID: 72772 RVA: 0x0045F993 File Offset: 0x0045DB93
	public static PayItemModel GetOrCreateInstance()
	{
		if (PayItemModel._Instance == null)
		{
			PayItemModel.CreateInstance();
		}
		return PayItemModel._Instance;
	}

	// Token: 0x06011C45 RID: 72773 RVA: 0x0045F9A7 File Offset: 0x0045DBA7
	public static bool CreateInstance()
	{
		if (PayItemModel._Instance != null)
		{
			return true;
		}
		PayItemModel._Instance = new PayItemModel();
		return true;
	}

	// Token: 0x06011C46 RID: 72774 RVA: 0x0045F9BD File Offset: 0x0045DBBD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011C47 RID: 72775 RVA: 0x0045F9BF File Offset: 0x0045DBBF
	public static void ResetStaticDefaultValue()
	{
		PayItemModel._Instance = null;
	}

	// Token: 0x06011C48 RID: 72776 RVA: 0x0045F9C7 File Offset: 0x0045DBC7
	static PayItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayItemModel.CreateStaticDefaultValue), new Action(PayItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x040086CA RID: 34506
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PayItemData> CurrentPayItemDataList = new List<PayItemData>();

	// Token: 0x040086CB RID: 34507
	private readonly Dictionary<int, PayItemData> CurrencyPayItemMap = new Dictionary<int, PayItemData>();

	// Token: 0x040086CC RID: 34508
	public string Version = "";

	// Token: 0x040086CD RID: 34509
	[Nullable(2)]
	private string PayingItemName;

	// Token: 0x040086CE RID: 34510
	private readonly Dictionary<string, DisplayProductInfo> ProductInfoMap = new Dictionary<string, DisplayProductInfo>();

	// Token: 0x040086CF RID: 34511
	[Nullable(2)]
	private static PayItemModel _Instance;
}
