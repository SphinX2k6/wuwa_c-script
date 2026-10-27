using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.PayShop;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200659F RID: 26015
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class DockyardModel : ModelBase
	{
		// Token: 0x17009571 RID: 38257
		// (get) Token: 0x060413A5 RID: 267173 RVA: 0x00FCE710 File Offset: 0x00FCC910
		public bool IsTrawlOpen
		{
			get
			{
				return FishingModel.Instance.GetFishingTechUnlockByEffectType(EFishingTechType.TrawlTech);
			}
		}

		// Token: 0x17009572 RID: 38258
		// (get) Token: 0x060413A6 RID: 267174 RVA: 0x00FCE720 File Offset: 0x00FCC920
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

		// Token: 0x060413A7 RID: 267175 RVA: 0x00FCE75C File Offset: 0x00FCC95C
		public void SetTrawlDataListFromServer(List<FishingItemInfo> dataList)
		{
			this.TrawlDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.TrawlDataMap[fishingItemInfo.IncrId] = value;
			}
		}

		// Token: 0x060413A8 RID: 267176 RVA: 0x00FCE7C8 File Offset: 0x00FCC9C8
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByTrawl(int uniqueId)
		{
			DockyardItemBlockOriginalData result;
			this.TrawlDataMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x060413A9 RID: 267177 RVA: 0x00FCE7E5 File Offset: 0x00FCC9E5
		public List<DockyardItemBlockOriginalData> GetTrawlDataList()
		{
			return this.TrawlDataMap.Values.ToList<DockyardItemBlockOriginalData>();
		}

		// Token: 0x060413AA RID: 267178 RVA: 0x00FCE7F8 File Offset: 0x00FCC9F8
		public void SetTrawlData(FishingItemInfo data)
		{
			DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(data);
			this.TrawlDataMap[data.IncrId] = value;
		}

		// Token: 0x060413AB RID: 267179 RVA: 0x00FCE820 File Offset: 0x00FCCA20
		private void SetWareHouseDataListFromServer(List<FishingItemInfo> dataList)
		{
			this.WareHouseDataMap.Clear();
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.WareHouseDataMap[fishingItemInfo.IncrId] = value;
			}
		}

		// Token: 0x060413AC RID: 267180 RVA: 0x00FCE88C File Offset: 0x00FCCA8C
		[NullableContext(2)]
		public DockyardItemBlockOriginalData GetDataByWareHouse(int uniqueId)
		{
			DockyardItemBlockOriginalData result;
			this.WareHouseDataMap.TryGetValue(uniqueId, out result);
			return result;
		}

		// Token: 0x060413AD RID: 267181 RVA: 0x00FCE8A9 File Offset: 0x00FCCAA9
		public List<DockyardItemBlockOriginalData> GetWareHouseDataList()
		{
			return this.WareHouseDataMap.Values.ToList<DockyardItemBlockOriginalData>();
		}

		// Token: 0x060413AE RID: 267182 RVA: 0x00FCE8BB File Offset: 0x00FCCABB
		public int GetWareHouseDataSize()
		{
			return this.WareHouseDataMap.Count;
		}

		// Token: 0x060413AF RID: 267183 RVA: 0x00FCE8C8 File Offset: 0x00FCCAC8
		public void SetWareHouseData(FishingItemInfo data)
		{
			DockyardItemBlockOriginalData value = new DockyardItemBlockOriginalData(data);
			this.WareHouseDataMap[data.IncrId] = value;
		}

		// Token: 0x060413B0 RID: 267184 RVA: 0x00FCE8EE File Offset: 0x00FCCAEE
		public int GetQuicklySellId()
		{
			return this.BackpackData.QuicklySellDataId;
		}

		// Token: 0x060413B1 RID: 267185 RVA: 0x00FCE8FB File Offset: 0x00FCCAFB
		public float GetQuicklySellRatio()
		{
			return (float)this.BackpackData.QuicklySellRatio;
		}

		// Token: 0x060413B2 RID: 267186 RVA: 0x00FCE909 File Offset: 0x00FCCB09
		public List<DockyardItemBlockOriginalData> GetBackpackItemList()
		{
			return this.BackpackData.GetBackpackItemList();
		}

		// Token: 0x060413B3 RID: 267187 RVA: 0x00FCE916 File Offset: 0x00FCCB16
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

		// Token: 0x060413B4 RID: 267188 RVA: 0x00FCE93E File Offset: 0x00FCCB3E
		public bool CheckListItemReadFlag(int itemId)
		{
			return NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.DockyardListItemRead, itemId);
		}

		// Token: 0x17009573 RID: 38259
		// (get) Token: 0x060413B5 RID: 267189 RVA: 0x00FCE94D File Offset: 0x00FCCB4D
		public bool IsQuicklySellOpen
		{
			get
			{
				return this.BackpackData.QuicklySellDataId != 0;
			}
		}

		// Token: 0x060413B6 RID: 267190 RVA: 0x00FCE95D File Offset: 0x00FCCB5D
		private void RefreshFishingCabinShape(int level)
		{
			this.FishingCabinShape = level;
		}

		// Token: 0x060413B7 RID: 267191 RVA: 0x00FCE966 File Offset: 0x00FCCB66
		public void SetFishingShipData(FishingShipInfo fishingShipData)
		{
			this.SetDockyardData(fishingShipData.CabinInfo);
		}

		// Token: 0x060413B8 RID: 267192 RVA: 0x00FCE974 File Offset: 0x00FCCB74
		public void SetDockyardData(CabinInfo dockyardData)
		{
			this.RefreshFishingCabinShape(dockyardData.CabinShape);
			this.BackpackData.SetBackpackDataListFromServer(dockyardData.FishingItems.ToList<FishingItemInfo>());
			this.BackpackData.SetQuicklySellData(dockyardData.QuickSellShape, dockyardData.QuickSellRatio);
			this.SetTrawlDataListFromServer(dockyardData.NetCabinItems.ToList<FishingItemInfo>());
			this.SetWareHouseDataListFromServer(dockyardData.TempCabinItems.ToList<FishingItemInfo>());
			this.BackpackData.RefreshPosData();
		}

		// Token: 0x060413B9 RID: 267193 RVA: 0x00FCE9E8 File Offset: 0x00FCCBE8
		public void UpdateDockyardData(CabinInfo dockyardData)
		{
			this.SetDockyardData(dockyardData);
			Log.Instance.Info(ELogModule.Dockyard, ELogAuthor.XXJ, "船舱数据刷新", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060413BA RID: 267194 RVA: 0x00FCEA1C File Offset: 0x00FCCC1C
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

		// Token: 0x060413BB RID: 267195 RVA: 0x00FCEA47 File Offset: 0x00FCCC47
		public List<PayShopGoods> GetShopDataList()
		{
			return PayShopModel.Instance.GetPayShopTabData((PayShopDefine.EPayShopTabType)this.ShopId, 1, true);
		}

		// Token: 0x17009574 RID: 38260
		// (get) Token: 0x060413BC RID: 267196 RVA: 0x00FCEA5B File Offset: 0x00FCCC5B
		public int BackpackUseSize
		{
			get
			{
				return this.BackpackData.BackpackUseSize;
			}
		}

		// Token: 0x17009575 RID: 38261
		// (get) Token: 0x060413BD RID: 267197 RVA: 0x00FCEA68 File Offset: 0x00FCCC68
		public int BackpackSize
		{
			get
			{
				return this.BackpackData.BackpackSize;
			}
		}

		// Token: 0x17009576 RID: 38262
		// (get) Token: 0x060413BE RID: 267198 RVA: 0x00FCEA75 File Offset: 0x00FCCC75
		public List<List<int>> BackpackPosDataDoublyList
		{
			get
			{
				return this.BackpackData.PosDataDoublyList;
			}
		}

		// Token: 0x060413BF RID: 267199 RVA: 0x00FCEA82 File Offset: 0x00FCCC82
		public int GetItemCountByItemId(int itemId)
		{
			return this.BackpackData.GetItemCountByItemId(itemId);
		}

		// Token: 0x060413C0 RID: 267200 RVA: 0x00FCEA90 File Offset: 0x00FCCC90
		public List<DockyardItemBlockOriginalData> GetItemListByItemId(int itemId)
		{
			return this.BackpackData.GetItemListByItemId(itemId);
		}

		// Token: 0x17009577 RID: 38263
		// (get) Token: 0x060413C1 RID: 267201 RVA: 0x00FCEAA0 File Offset: 0x00FCCCA0
		public int ShopId
		{
			get
			{
				int dockId = FishingModel.Instance.DockId;
				return FishingConfig.Instance.GetFishingPortConfig(dockId).ShopId;
			}
		}

		// Token: 0x17009578 RID: 38264
		// (get) Token: 0x060413C2 RID: 267202 RVA: 0x00FCEACB File Offset: 0x00FCCCCB
		public static DockyardModel Instance
		{
			get
			{
				return DockyardModel._Instance;
			}
		}

		// Token: 0x060413C3 RID: 267203 RVA: 0x00FCEAD2 File Offset: 0x00FCCCD2
		public static DockyardModel GetOrCreateInstance()
		{
			if (DockyardModel._Instance == null)
			{
				DockyardModel.CreateInstance();
			}
			return DockyardModel._Instance;
		}

		// Token: 0x060413C4 RID: 267204 RVA: 0x00FCEAE6 File Offset: 0x00FCCCE6
		public static bool CreateInstance()
		{
			if (DockyardModel._Instance != null)
			{
				return true;
			}
			DockyardModel._Instance = new DockyardModel();
			return true;
		}

		// Token: 0x060413C5 RID: 267205 RVA: 0x00FCEAFC File Offset: 0x00FCCCFC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060413C6 RID: 267206 RVA: 0x00FCEAFE File Offset: 0x00FCCCFE
		public static void ResetStaticDefaultValue()
		{
			DockyardModel._Instance = null;
		}

		// Token: 0x060413C7 RID: 267207 RVA: 0x00FCEB06 File Offset: 0x00FCCD06
		static DockyardModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(DockyardModel.CreateStaticDefaultValue), new Action(DockyardModel.ResetStaticDefaultValue));
		}

		// Token: 0x04021F52 RID: 139090
		private Dictionary<int, DockyardItemBlockOriginalData> TrawlDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x04021F53 RID: 139091
		private Dictionary<int, DockyardItemBlockOriginalData> WareHouseDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x04021F54 RID: 139092
		private DockyardBackpackOriginalData BackpackData = new DockyardBackpackOriginalData();

		// Token: 0x04021F55 RID: 139093
		public bool IsPrintLog;

		// Token: 0x04021F56 RID: 139094
		public bool IsNeedShowExitConfirmBox;

		// Token: 0x04021F57 RID: 139095
		public int FishingCabinShape;

		// Token: 0x04021F58 RID: 139096
		[Nullable(2)]
		private static DockyardModel _Instance;
	}
}
