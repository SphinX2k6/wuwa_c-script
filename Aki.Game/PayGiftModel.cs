using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.PayShop;

// Token: 0x02001839 RID: 6201
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class PayGiftModel : ModelBase
{
	// Token: 0x0600F4D4 RID: 62676 RVA: 0x00477898 File Offset: 0x00475A98
	public void InitDataByServer(IReadOnlyList<PayGiftInfo> infos, bool needRefreshEvent = false)
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

	// Token: 0x0600F4D5 RID: 62677 RVA: 0x00477A50 File Offset: 0x00475C50
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

	// Token: 0x0600F4D6 RID: 62678 RVA: 0x00477AB4 File Offset: 0x00475CB4
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
		return new List<int>(hashSet);
	}

	// Token: 0x0600F4D7 RID: 62679 RVA: 0x00477B3C File Offset: 0x00475D3C
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
		return new List<int>(hashSet);
	}

	// Token: 0x0600F4D8 RID: 62680 RVA: 0x00477BB4 File Offset: 0x00475DB4
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

	// Token: 0x0600F4D9 RID: 62681 RVA: 0x00477C03 File Offset: 0x00475E03
	public List<PayPackageData> GetPayGiftDataList()
	{
		return this.PayGiftDataList;
	}

	// Token: 0x0600F4DA RID: 62682 RVA: 0x00477C0C File Offset: 0x00475E0C
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

	// Token: 0x0600F4DB RID: 62683 RVA: 0x00477C2C File Offset: 0x00475E2C
	public List<PayPackageData> GetPayGiftDataByType(EPayGiftType type)
	{
		return this.PayGiftDataList.FindAll((PayPackageData item) => item.Type == type);
	}

	// Token: 0x0600F4DC RID: 62684 RVA: 0x00477C5D File Offset: 0x00475E5D
	public List<PayShopGoods> GetPayShopGoodsList()
	{
		return this.PayShopGoodsList;
	}

	// Token: 0x0600F4DD RID: 62685 RVA: 0x00477C65 File Offset: 0x00475E65
	public List<PayPackageData> GetDataList()
	{
		return this.PayGiftDataList;
	}

	// Token: 0x170017C7 RID: 6087
	// (get) Token: 0x0600F4DE RID: 62686 RVA: 0x00477C6D File Offset: 0x00475E6D
	public static PayGiftModel Instance
	{
		get
		{
			return PayGiftModel._Instance;
		}
	}

	// Token: 0x0600F4DF RID: 62687 RVA: 0x00477C74 File Offset: 0x00475E74
	public static PayGiftModel GetOrCreateInstance()
	{
		if (PayGiftModel._Instance == null)
		{
			PayGiftModel.CreateInstance();
		}
		return PayGiftModel._Instance;
	}

	// Token: 0x0600F4E0 RID: 62688 RVA: 0x00477C88 File Offset: 0x00475E88
	public static bool CreateInstance()
	{
		if (PayGiftModel._Instance != null)
		{
			return true;
		}
		PayGiftModel._Instance = new PayGiftModel();
		return true;
	}

	// Token: 0x0600F4E1 RID: 62689 RVA: 0x00477C9E File Offset: 0x00475E9E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F4E2 RID: 62690 RVA: 0x00477CA0 File Offset: 0x00475EA0
	public static void ResetStaticDefaultValue()
	{
		PayGiftModel._Instance = null;
	}

	// Token: 0x0600F4E3 RID: 62691 RVA: 0x00477CA8 File Offset: 0x00475EA8
	static PayGiftModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PayGiftModel.CreateStaticDefaultValue), new Action(PayGiftModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008943 RID: 35139
	public string Version = "";

	// Token: 0x04008944 RID: 35140
	private List<PayPackageData> PayGiftDataList = new List<PayPackageData>();

	// Token: 0x04008945 RID: 35141
	private List<PayShopGoods> PayShopGoodsList = new List<PayShopGoods>();

	// Token: 0x04008946 RID: 35142
	private readonly Dictionary<int, PayShopGoods> PayShopGoodsMap = new Dictionary<int, PayShopGoods>();

	// Token: 0x04008947 RID: 35143
	private readonly Dictionary<int, PayPackageData> PayGiftMap = new Dictionary<int, PayPackageData>();

	// Token: 0x04008948 RID: 35144
	private List<int> TabList = new List<int>();

	// Token: 0x04008949 RID: 35145
	[Nullable(2)]
	private static PayGiftModel _Instance;
}
