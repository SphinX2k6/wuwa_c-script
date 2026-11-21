using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200551D RID: 21789
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DockyardModel : ModelBase
	{
		// Token: 0x170068D3 RID: 26835
		// (get) Token: 0x0603606A RID: 221290 RVA: 0x00F15724 File Offset: 0x00F13924
		public bool IsTrawlOpen
		{
			get
			{
				return FishingModel.Instance.GetFishingTechUnlockByEffectType(EFishingTechType.TrawlTech);
			}
		}

		// Token: 0x170068D4 RID: 26836
		// (get) Token: 0x0603606B RID: 221291 RVA: 0x00F15734 File Offset: 0x00F13934
		public int TrawlSize
		{
			get
			{
				float num = (float)FishingModel.Instance.GetFishingCurrentLevelTechEffectByEffectType(EFishingTechType.TrawlTech);
				if (num > 0f)
				{
					return FishingConfig.Instance.GetFishingTechEffectById((int)num).Params(0);
				}
				return 0;
			}
		}

		// Token: 0x0603606C RID: 221292 RVA: 0x00F15770 File Offset: 0x00F13970
		public void SetTrawlDataListFromServer(IEnumerable<FishingItemInfo> dataList)
		{
			this.TrawlDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.TrawlDataMap[fishingItemInfo.IncrId] = value;
			}
		}

		// Token: 0x0603606D RID: 221293 RVA: 0x00F157D8 File Offset: 0x00F139D8
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByTrawl(int uniqueId)
		{
			DockyardItemBlockOriginalData result;
			this.TrawlDataMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x0603606E RID: 221294 RVA: 0x00F157F5 File Offset: 0x00F139F5
		public List<DockyardItemBlockOriginalData> GetTrawlDataList()
		{
			return new List<DockyardItemBlockOriginalData>(this.TrawlDataMap.Values);
		}

		// Token: 0x0603606F RID: 221295 RVA: 0x00F15808 File Offset: 0x00F13A08
		public void SetTrawlData(FishingItemInfo data)
		{
			DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(data);
			this.TrawlDataMap[data.IncrId] = value;
		}

		// Token: 0x06036070 RID: 221296 RVA: 0x00F15830 File Offset: 0x00F13A30
		private void SetWareHouseDataListFromServer(IEnumerable<FishingItemInfo> dataList)
		{
			this.WareHouseDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.WareHouseDataMap[fishingItemInfo.IncrId] = value;
			}
		}

		// Token: 0x06036071 RID: 221297 RVA: 0x00F15898 File Offset: 0x00F13A98
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByWareHouse(int uniqueId)
		{
			DockyardItemBlockOriginalData result;
			this.WareHouseDataMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x06036072 RID: 221298 RVA: 0x00F158B5 File Offset: 0x00F13AB5
		public List<DockyardItemBlockOriginalData> GetWareHouseDataList()
		{
			return new List<DockyardItemBlockOriginalData>(this.WareHouseDataMap.Values);
		}

		// Token: 0x06036073 RID: 221299 RVA: 0x00F158C7 File Offset: 0x00F13AC7
		public int GetWareHouseDataSize()
		{
			return this.WareHouseDataMap.Count;
		}

		// Token: 0x06036074 RID: 221300 RVA: 0x00F158D4 File Offset: 0x00F13AD4
		public void SetWareHouseData(FishingItemInfo data)
		{
			DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(data);
			this.WareHouseDataMap[data.IncrId] = value;
		}

		// Token: 0x06036075 RID: 221301 RVA: 0x00F158FA File Offset: 0x00F13AFA
		public int GetQuicklySellId()
		{
			return this.BackpackData.QuicklySellDataId;
		}

		// Token: 0x06036076 RID: 221302 RVA: 0x00F15907 File Offset: 0x00F13B07
		public float GetQuicklySellRatio()
		{
			return (float)this.BackpackData.QuicklySellRatio;
		}

		// Token: 0x06036077 RID: 221303 RVA: 0x00F15915 File Offset: 0x00F13B15
		public List<DockyardItemBlockOriginalData> GetBackpackItemList()
		{
			return this.BackpackData.GetBackpackItemList();
		}

		// Token: 0x06036078 RID: 221304 RVA: 0x00F15922 File Offset: 0x00F13B22
		public void AddListItemReadFlag(int itemId)
		{
			NewFlagModel instance = NewFlagModel.Instance;
			if (instance != null)
			{
				instance.AddNewFlag(ELocalStoragePlayerKey.DockyardListItemRead, itemId);
			}
			NewFlagModel instance2 = NewFlagModel.Instance;
			if (instance2 == null)
			{
				return;
			}
			instance2.SaveNewFlagConfig(ELocalStoragePlayerKey.DockyardListItemRead);
		}

		// Token: 0x06036079 RID: 221305 RVA: 0x00F1594A File Offset: 0x00F13B4A
		public bool CheckListItemReadFlag(int itemId)
		{
			return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.DockyardListItemRead, itemId);
		}

		// Token: 0x170068D5 RID: 26837
		// (get) Token: 0x0603607A RID: 221306 RVA: 0x00F15959 File Offset: 0x00F13B59
		public bool IsQuicklySellOpen
		{
			get
			{
				return this.BackpackData.QuicklySellDataId != 0;
			}
		}

		// Token: 0x0603607B RID: 221307 RVA: 0x00F15969 File Offset: 0x00F13B69
		private void RefreshFishingCabinShape(int level)
		{
			this.FishingCabinShape = level;
		}

		// Token: 0x0603607C RID: 221308 RVA: 0x00F15972 File Offset: 0x00F13B72
		public void SetFishingShipData(FishingShipInfo fishingShipData)
		{
			this.SetDockyardData(fishingShipData.CabinInfo);
		}

		// Token: 0x0603607D RID: 221309 RVA: 0x00F15980 File Offset: 0x00F13B80
		public void SetDockyardData(CabinInfo dockyardData)
		{
			this.RefreshFishingCabinShape(dockyardData.CabinShape);
			this.BackpackData.SetBackpackDataListFromServer(dockyardData.FishingItems);
			this.BackpackData.SetQuicklySellData(dockyardData.QuickSellShape, dockyardData.QuickSellRatio);
			this.SetTrawlDataListFromServer(dockyardData.NetCabinItems);
			this.SetWareHouseDataListFromServer(dockyardData.TempCabinItems);
			this.BackpackData.RefreshPosData();
		}

		// Token: 0x0603607E RID: 221310 RVA: 0x00F159E4 File Offset: 0x00F13BE4
		public void UpdateDockyardData(CabinInfo dockyardData)
		{
			this.SetDockyardData(dockyardData);
			Log.Instance.Info(ELogModule.Dockyard, ELogAuthor.XXJ, "船舱数据刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603607F RID: 221311 RVA: 0x00F15A18 File Offset: 0x00F13C18
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetItemBlockData(int uniqueId)
		{
			DockyardItemBlockOriginalData backpackItemData = this.BackpackData.GetBackpackItemData(uniqueId);
			if (backpackItemData != null)
			{
				return backpackItemData;
			}
			return this.WareHouseDataMap.GetValueOrDefault(uniqueId);
		}

		// Token: 0x06036080 RID: 221312 RVA: 0x00F15A43 File Offset: 0x00F13C43
		public List<PayShopGoods> GetShopDataList()
		{
			return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.ShopId, 1, true);
		}

		// Token: 0x170068D6 RID: 26838
		// (get) Token: 0x06036081 RID: 221313 RVA: 0x00F15A57 File Offset: 0x00F13C57
		public int BackpackUseSize
		{
			get
			{
				return this.BackpackData.BackpackUseSize;
			}
		}

		// Token: 0x170068D7 RID: 26839
		// (get) Token: 0x06036082 RID: 221314 RVA: 0x00F15A64 File Offset: 0x00F13C64
		public int BackpackSize
		{
			get
			{
				return this.BackpackData.BackpackSize;
			}
		}

		// Token: 0x170068D8 RID: 26840
		// (get) Token: 0x06036083 RID: 221315 RVA: 0x00F15A71 File Offset: 0x00F13C71
		public List<List<int>> BackpackPosDataDoublyList
		{
			get
			{
				return this.BackpackData.PosDataDoublyList;
			}
		}

		// Token: 0x06036084 RID: 221316 RVA: 0x00F15A7E File Offset: 0x00F13C7E
		public int GetItemCountByItemId(int itemId)
		{
			return this.BackpackData.GetItemCountByItemId(itemId);
		}

		// Token: 0x06036085 RID: 221317 RVA: 0x00F15A8C File Offset: 0x00F13C8C
		public List<DockyardItemBlockOriginalData> GetItemListByItemId(int itemId)
		{
			return this.BackpackData.GetItemListByItemId(itemId);
		}

		// Token: 0x170068D9 RID: 26841
		// (get) Token: 0x06036086 RID: 221318 RVA: 0x00F15A9C File Offset: 0x00F13C9C
		public int ShopId
		{
			get
			{
				int dockId = FishingModel.Instance.DockId;
				return FishingConfig.Instance.GetFishingPortConfig(dockId).ShopId;
			}
		}

		// Token: 0x170068DA RID: 26842
		// (get) Token: 0x06036087 RID: 221319 RVA: 0x00F15AC7 File Offset: 0x00F13CC7
		public static DockyardModel Instance
		{
			get
			{
				return DockyardModel._Instance;
			}
		}

		// Token: 0x06036088 RID: 221320 RVA: 0x00F15ACE File Offset: 0x00F13CCE
		public static DockyardModel GetOrCreateInstance()
		{
			if (DockyardModel._Instance == null)
			{
				DockyardModel.CreateInstance();
			}
			return DockyardModel._Instance;
		}

		// Token: 0x06036089 RID: 221321 RVA: 0x00F15AE2 File Offset: 0x00F13CE2
		public static bool CreateInstance()
		{
			if (DockyardModel._Instance != null)
			{
				return true;
			}
			DockyardModel._Instance = new DockyardModel();
			return true;
		}

		// Token: 0x0603608A RID: 221322 RVA: 0x00F15AF8 File Offset: 0x00F13CF8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603608B RID: 221323 RVA: 0x00F15AFA File Offset: 0x00F13CFA
		public static void ResetStaticDefaultValue()
		{
			DockyardModel._Instance = null;
		}

		// Token: 0x0603608C RID: 221324 RVA: 0x00F15B02 File Offset: 0x00F13D02
		static DockyardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DockyardModel.CreateStaticDefaultValue), new Action(DockyardModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401C883 RID: 116867
		private Dictionary<int, DockyardItemBlockOriginalData> TrawlDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x0401C884 RID: 116868
		private Dictionary<int, DockyardItemBlockOriginalData> WareHouseDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x0401C885 RID: 116869
		private DockyardBackpackOriginalData BackpackData = new DockyardBackpackOriginalData();

		// Token: 0x0401C886 RID: 116870
		public bool IsPrintLog;

		// Token: 0x0401C887 RID: 116871
		public bool IsNeedShowExitConfirmBox = true;

		// Token: 0x0401C888 RID: 116872
		public int FishingCabinShape;

		// Token: 0x0401C889 RID: 116873
		[Nullable(2)]
		private static DockyardModel _Instance;
	}
}
