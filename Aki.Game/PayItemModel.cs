using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Item;
using CSharpScript.Launcher.Platform.PlatformSdk;

// Token: 0x02001801 RID: 6145
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayItemModel : ModelBase
{
	// Token: 0x0600F0E3 RID: 61667 RVA: 0x0046C5BC File Offset: 0x0046A7BC
	public void UpdateProductInfoMap(IEnumerable<DisplayProductInfo> data)
	{
		foreach (DisplayProductInfo displayProductInfo in data)
		{
			this.ProductInfoMap[displayProductInfo.GoodId] = displayProductInfo;
		}
	}

	// Token: 0x0600F0E4 RID: 61668 RVA: 0x0046C610 File Offset: 0x0046A810
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

	// Token: 0x0600F0E5 RID: 61669 RVA: 0x0046C638 File Offset: 0x0046A838
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

	// Token: 0x0600F0E6 RID: 61670 RVA: 0x0046C660 File Offset: 0x0046A860
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

	// Token: 0x0600F0E7 RID: 61671 RVA: 0x0046C680 File Offset: 0x0046A880
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

	// Token: 0x0600F0E8 RID: 61672 RVA: 0x0046C6D8 File Offset: 0x0046A8D8
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

	// Token: 0x0600F0E9 RID: 61673 RVA: 0x0046C730 File Offset: 0x0046A930
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<PayItemData> GetDataList()
	{
		return this.CurrentPayItemDataList;
	}

	// Token: 0x0600F0EA RID: 61674 RVA: 0x0046C738 File Offset: 0x0046A938
	[NullableContext(2)]
	public string GetPayingItemName()
	{
		return this.PayingItemName;
	}

	// Token: 0x0600F0EB RID: 61675 RVA: 0x0046C740 File Offset: 0x0046A940
	public void CleanPayingItemName()
	{
		this.PayingItemName = null;
	}

	// Token: 0x0600F0EC RID: 61676 RVA: 0x0046C749 File Offset: 0x0046A949
	public PayShopItemBaseSt ConvertPayItemDataToPayShopItemBaseSt(PayItemData source)
	{
		return source.ConvertPayItemDataToPayShopItemBaseSt();
	}

	// Token: 0x0600F0ED RID: 61677 RVA: 0x0046C754 File Offset: 0x0046A954
	public void UpdatePayingItemName(int payItemId)
	{
		PayItem? payItem = PayItemConfig.Instance.GetPayItem(payItemId);
		string itemName = ItemConfig.Instance.GetItemName(payItem.Value.ItemId);
		this.PayingItemName = itemName;
	}

	// Token: 0x0600F0EE RID: 61678 RVA: 0x0046C790 File Offset: 0x0046A990
	public void ResetSpecialBonus(IReadOnlyList<int> ids)
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

	// Token: 0x0600F0EF RID: 61679 RVA: 0x0046C7E8 File Offset: 0x0046A9E8
	public void InitDataListByServer(IReadOnlyList<PayItemInfo> infos)
	{
		if (this.CurrentPayItemDataList.Count != 0 && infos.Count != 0)
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

	// Token: 0x0600F0F0 RID: 61680 RVA: 0x0046C874 File Offset: 0x0046AA74
	protected override bool OnClear()
	{
		this.CurrentPayItemDataList.Clear();
		this.CurrentPayItemDataList = null;
		this.CurrencyPayItemMap.Clear();
		this.Version = "";
		this.PayingItemName = null;
		return true;
	}

	// Token: 0x0600F0F1 RID: 61681 RVA: 0x0046C8A8 File Offset: 0x0046AAA8
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

	// Token: 0x0600F0F2 RID: 61682 RVA: 0x0046C9CC File Offset: 0x0046ABCC
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

	// Token: 0x170016ED RID: 5869
	// (get) Token: 0x0600F0F3 RID: 61683 RVA: 0x0046CA34 File Offset: 0x0046AC34
	public static PayItemModel Instance
	{
		get
		{
			return PayItemModel._Instance;
		}
	}

	// Token: 0x0600F0F4 RID: 61684 RVA: 0x0046CA3B File Offset: 0x0046AC3B
	public static PayItemModel GetOrCreateInstance()
	{
		if (PayItemModel._Instance == null)
		{
			PayItemModel.CreateInstance();
		}
		return PayItemModel._Instance;
	}

	// Token: 0x0600F0F5 RID: 61685 RVA: 0x0046CA4F File Offset: 0x0046AC4F
	public static bool CreateInstance()
	{
		if (PayItemModel._Instance != null)
		{
			return true;
		}
		PayItemModel._Instance = new PayItemModel();
		return true;
	}

	// Token: 0x0600F0F6 RID: 61686 RVA: 0x0046CA65 File Offset: 0x0046AC65
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F0F7 RID: 61687 RVA: 0x0046CA67 File Offset: 0x0046AC67
	public static void ResetStaticDefaultValue()
	{
		PayItemModel._Instance = null;
	}

	// Token: 0x0600F0F8 RID: 61688 RVA: 0x0046CA6F File Offset: 0x0046AC6F
	static PayItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayItemModel.CreateStaticDefaultValue), new Action(PayItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400880D RID: 34829
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<PayItemData> CurrentPayItemDataList = new List<PayItemData>();

	// Token: 0x0400880E RID: 34830
	private readonly Dictionary<int, PayItemData> CurrencyPayItemMap = new Dictionary<int, PayItemData>();

	// Token: 0x0400880F RID: 34831
	public string Version = "";

	// Token: 0x04008810 RID: 34832
	[Nullable(2)]
	private string PayingItemName;

	// Token: 0x04008811 RID: 34833
	private readonly Dictionary<string, DisplayProductInfo> ProductInfoMap = new Dictionary<string, DisplayProductInfo>();

	// Token: 0x04008812 RID: 34834
	[Nullable(2)]
	private static PayItemModel _Instance;
}
