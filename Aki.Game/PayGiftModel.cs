using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02002354 RID: 9044
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayGiftModel : ModelBase
{
	// Token: 0x06012024 RID: 73764 RVA: 0x0046A7D8 File Offset: 0x004689D8
	public void InitDataByServer(List<PayGiftInfo> infos, bool needRefreshEvent = false)
	{
		if (infos.Count == 0)
		{
			return;
		}
		this.PayShopGoodsList = new List<PayShopGoods>();
		this.PayGiftDataList = new List<PayPackageData>();
		this.TabList = new List<int>();
		this.PayShopGoodsMap.Clear();
		this.PayGiftMap.Clear();
		List<string> list = new List<string>();
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		foreach (PayGiftInfo payGiftInfo in infos)
		{
			PayPackageData payPackageData = new PayPackageData();
			payPackageData.Phrase(payGiftInfo);
			list.Add(payGiftInfo.ProductId);
			this.PayGiftDataList.Add(payPackageData);
			this.PayShopGoodsList.Add(payPackageData.GetPayShopGoods());
			this.PayShopGoodsMap.Add(payPackageData.Id, payPackageData.GetPayShopGoods());
			this.PayGiftMap.Add(payPackageData.Id, payPackageData);
			if (!this.TabList.Contains(payPackageData.TabId) && payPackageData.ShowInShop())
			{
				this.TabList.Add(payPackageData.TabId);
			}
			if (payPackageData.ShopId == PayShopDefine.EPayShopTabType.GiftBag)
			{
				num++;
			}
			else if (payPackageData.ShopId == PayShopDefine.EPayShopTabType.NewPlayerShop)
			{
				num2++;
			}
			else
			{
				num3++;
			}
		}
		if (needRefreshEvent)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in this.TabList)
			{
				hashSet.Add(item);
			}
			EventSystem.Instance.Emit<IReadOnlySet<int>>(EEventName.RefreshGoodsList, hashSet);
		}
	}

	// Token: 0x06012025 RID: 73765 RVA: 0x0046A994 File Offset: 0x00468B94
	public bool IfHaveFreeGift()
	{
		using (List<PayPackageData>.Enumerator enumerator = this.PayGiftDataList.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Amount == "0")
				{
					return true;
				}
			}
		}
		return false;
	}

	// Token: 0x06012026 RID: 73766 RVA: 0x0046A9F8 File Offset: 0x00468BF8
	public List<int> GetTabList()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PayShopGoods payShopGoods in this.GetPayShopGoodsList())
		{
			if (payShopGoods.GetGetPayGiftData().ShowInShop() && payShopGoods.GetGetPayGiftData().CanShowInShopTab() && payShopGoods.CheckGoodIfShow())
			{
				hashSet.Add(payShopGoods.GetTabId());
			}
		}
		return hashSet.ToList<int>();
	}

	// Token: 0x06012027 RID: 73767 RVA: 0x0046AA80 File Offset: 0x00468C80
	public List<int> GetSkinTabList()
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (PayPackageData payPackageData in this.GetDataList())
		{
			if (payPackageData.ShowInSkinTab() && payPackageData.CanShowInShopTab())
			{
				hashSet.Add(payPackageData.TabId);
			}
		}
		return hashSet.ToList<int>();
	}

	// Token: 0x06012028 RID: 73768 RVA: 0x0046AAF8 File Offset: 0x00468CF8
	[NullableContext(2)]
	public PayShopGoods GetPayShopGoodsById(int id)
	{
		PayShopGoods result;
		if (this.PayShopGoodsMap.TryGetValue(id, out result))
		{
			return result;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Pay;
		ELogAuthor author = ELogAuthor.YZY;
		string message = "找不到对应的商品，检查配置或者协议顺序";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x06012029 RID: 73769 RVA: 0x0046AB47 File Offset: 0x00468D47
	public List<PayPackageData> GetPayGiftDataList()
	{
		return this.PayGiftDataList;
	}

	// Token: 0x0601202A RID: 73770 RVA: 0x0046AB50 File Offset: 0x00468D50
	[NullableContext(2)]
	public PayPackageData GetPayGiftDataById(int id)
	{
		PayPackageData result;
		if (this.PayGiftMap.TryGetValue(id, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x0601202B RID: 73771 RVA: 0x0046AB70 File Offset: 0x00468D70
	public List<PayPackageData> GetPayGiftDataByType(EPayGiftType type)
	{
		return this.PayGiftDataList.FindAll((PayPackageData item) => item.Type == type);
	}

	// Token: 0x0601202C RID: 73772 RVA: 0x0046ABA1 File Offset: 0x00468DA1
	public List<PayShopGoods> GetPayShopGoodsList()
	{
		return this.PayShopGoodsList;
	}

	// Token: 0x0601202D RID: 73773 RVA: 0x0046ABA9 File Offset: 0x00468DA9
	public List<PayPackageData> GetDataList()
	{
		return this.PayGiftDataList;
	}

	// Token: 0x1700178D RID: 6029
	// (get) Token: 0x0601202E RID: 73774 RVA: 0x0046ABB1 File Offset: 0x00468DB1
	public static PayGiftModel Instance
	{
		get
		{
			return PayGiftModel._Instance;
		}
	}

	// Token: 0x0601202F RID: 73775 RVA: 0x0046ABB8 File Offset: 0x00468DB8
	public static PayGiftModel GetOrCreateInstance()
	{
		if (PayGiftModel._Instance == null)
		{
			PayGiftModel.CreateInstance();
		}
		return PayGiftModel._Instance;
	}

	// Token: 0x06012030 RID: 73776 RVA: 0x0046ABCC File Offset: 0x00468DCC
	public static bool CreateInstance()
	{
		if (PayGiftModel._Instance != null)
		{
			return true;
		}
		PayGiftModel._Instance = new PayGiftModel();
		return true;
	}

	// Token: 0x06012031 RID: 73777 RVA: 0x0046ABE2 File Offset: 0x00468DE2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012032 RID: 73778 RVA: 0x0046ABE4 File Offset: 0x00468DE4
	public static void ResetStaticDefaultValue()
	{
		PayGiftModel._Instance = null;
	}

	// Token: 0x06012033 RID: 73779 RVA: 0x0046ABEC File Offset: 0x00468DEC
	static PayGiftModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayGiftModel.CreateStaticDefaultValue), new Action(PayGiftModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008800 RID: 34816
	public string Version = "";

	// Token: 0x04008801 RID: 34817
	private List<PayPackageData> PayGiftDataList = new List<PayPackageData>();

	// Token: 0x04008802 RID: 34818
	private List<PayShopGoods> PayShopGoodsList = new List<PayShopGoods>();

	// Token: 0x04008803 RID: 34819
	private readonly Dictionary<int, PayShopGoods> PayShopGoodsMap = new Dictionary<int, PayShopGoods>();

	// Token: 0x04008804 RID: 34820
	private readonly Dictionary<int, PayPackageData> PayGiftMap = new Dictionary<int, PayPackageData>();

	// Token: 0x04008805 RID: 34821
	private List<int> TabList = new List<int>();

	// Token: 0x04008806 RID: 34822
	[Nullable(2)]
	private static PayGiftModel _Instance;
}
