using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200658B RID: 25995
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackData
	{
		// Token: 0x0604126B RID: 266859 RVA: 0x00FCA21C File Offset: 0x00FC841C
		public DockyardBackpackData(bool isQuicklySellOpen)
		{
			this.InitQuicklySellData(isQuicklySellOpen);
			this.InitGridDataMap();
			this.InitItemBlockDataMap();
		}

		// Token: 0x0604126C RID: 266860 RVA: 0x00FCA270 File Offset: 0x00FC8470
		private void InitQuicklySellData(bool isQuicklySellOpen)
		{
			if (isQuicklySellOpen)
			{
				int quicklySellId = DockyardModel.Instance.GetQuicklySellId();
				if (quicklySellId > 0)
				{
					this.QuicklySellData = new DockyardQuicklySellData(quicklySellId);
				}
			}
		}

		// Token: 0x0604126D RID: 266861 RVA: 0x00FCA29C File Offset: 0x00FC849C
		private void InitGridDataMap()
		{
			int fishingCabinShape = DockyardModel.Instance.FishingCabinShape;
			FishingGridItemShape fishingShapeConfig = FishingConfig.Instance.GetFishingShapeConfig(fishingCabinShape);
			for (int i = 0; i < 7; i++)
			{
				this.PosDataDoublyList.Add(new List<IPanelPos>());
				for (int j = 0; j < 8; j++)
				{
					PanelPos panelPos = new PanelPos
					{
						RowIndex = i,
						ColIndex = j
					};
					DockyardBackpackGridData dockyardBackpackGridData = new DockyardBackpackGridData(panelPos);
					DockyardQuicklySellData quicklySellData = this.QuicklySellData;
					bool isQuicklySell = quicklySellData != null && quicklySellData.PosDataDoublyList[i][j] == 1;
					if (dockyardBackpackGridData != null)
					{
						dockyardBackpackGridData.SetIsQuicklySell(isQuicklySell);
					}
					if (fishingShapeConfig.FillState()[i].ArrayInt(j) == 1)
					{
						if (dockyardBackpackGridData != null)
						{
							dockyardBackpackGridData.SetGridType(EBackpackGridType.Enable);
						}
					}
					else if (dockyardBackpackGridData != null)
					{
						dockyardBackpackGridData.SetGridType(EBackpackGridType.Disable);
					}
					this.PosDataList.Add(panelPos);
					this.PosDataDoublyList[i].Add(panelPos);
					this.GridDataMap.Add(panelPos, dockyardBackpackGridData);
				}
			}
		}

		// Token: 0x0604126E RID: 266862 RVA: 0x00FCA3A4 File Offset: 0x00FC85A4
		private void ClearGridDataMapItemBlockId()
		{
			for (int i = 0; i < 7; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					DockyardBackpackGridData valueOrDefault = this.GridDataMap.GetValueOrDefault(this.PosDataDoublyList[i][j]);
					if (valueOrDefault != null)
					{
						valueOrDefault.SetItemBlockId(-1);
					}
				}
			}
		}

		// Token: 0x0604126F RID: 266863 RVA: 0x00FCA3F4 File Offset: 0x00FC85F4
		private void InitItemBlockDataMap()
		{
			this.ItemBlockDataMap.Clear();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in DockyardModel.Instance.GetBackpackItemList())
			{
				DockyardItemBlockData dockyardItemBlockData = new DockyardItemBlockData(dockyardItemBlockOriginalData);
				this.ItemBlockDataMap.Add(dockyardItemBlockOriginalData.IncId, dockyardItemBlockData);
				this.RefreshBackpackGrid(dockyardItemBlockData);
			}
		}

		// Token: 0x06041270 RID: 266864 RVA: 0x00FCA470 File Offset: 0x00FC8670
		public void RefreshBackpackData()
		{
			this.ClearGridDataMapItemBlockId();
			this.InitItemBlockDataMap();
		}

		// Token: 0x06041271 RID: 266865 RVA: 0x00FCA480 File Offset: 0x00FC8680
		private void RefreshBackpackGrid(DockyardItemBlockData itemBlockData)
		{
			IPanelPosRange panelRange = itemBlockData.PanelRange;
			for (int i = panelRange.RowStartIndex; i <= panelRange.RowEndIndex; i++)
			{
				for (int j = panelRange.ColStartIndex; j <= panelRange.ColEndIndex; j++)
				{
					if (i >= 0 && i < 7 && j >= 0 && j < 8)
					{
						DockyardBackpackGridData valueOrDefault = this.GridDataMap.GetValueOrDefault(this.PosDataDoublyList[i][j]);
						if (valueOrDefault != null)
						{
							valueOrDefault.SetItemBlockId(itemBlockData.Data.IncId);
						}
					}
				}
			}
		}

		// Token: 0x06041272 RID: 266866 RVA: 0x00FCA504 File Offset: 0x00FC8704
		private void SetGridDataInQuicklySellType()
		{
			int count = this.QuicklySellData.PosDataDoublyList.Count;
			for (int i = 0; i < count; i++)
			{
				int count2 = this.QuicklySellData.PosDataDoublyList[i].Count;
				for (int j = 0; j < count2; j++)
				{
					DockyardQuicklySellData quicklySellData = this.QuicklySellData;
					bool isQuicklySell = quicklySellData != null && quicklySellData.PosDataDoublyList[i][j] == 1;
					IPanelPos key = this.PosDataDoublyList[i][j];
					DockyardBackpackGridData valueOrDefault = this.GridDataMap.GetValueOrDefault(key);
					if (valueOrDefault != null)
					{
						valueOrDefault.SetIsQuicklySell(isQuicklySell);
					}
				}
			}
		}

		// Token: 0x06041273 RID: 266867 RVA: 0x00FCA5A4 File Offset: 0x00FC87A4
		private void ResetGridDataInQuicklySellType()
		{
			foreach (DockyardBackpackGridData dockyardBackpackGridData in this.GridDataMap.Values)
			{
				dockyardBackpackGridData.SetIsQuicklySell(false);
			}
		}

		// Token: 0x06041274 RID: 266868 RVA: 0x00FCA5FC File Offset: 0x00FC87FC
		public void RefreshQuicklySellOpen(bool isQuicklySellOpen)
		{
			if (isQuicklySellOpen)
			{
				int quicklySellId = DockyardModel.Instance.GetQuicklySellId();
				this.QuicklySellData = new DockyardQuicklySellData(quicklySellId);
				this.SetGridDataInQuicklySellType();
				return;
			}
			this.ResetGridDataInQuicklySellType();
		}

		// Token: 0x06041275 RID: 266869 RVA: 0x00FCA630 File Offset: 0x00FC8830
		public List<IPanelPos> GetBackpackDataList()
		{
			return this.PosDataList;
		}

		// Token: 0x06041276 RID: 266870 RVA: 0x00FCA638 File Offset: 0x00FC8838
		public IPanelPos GetBackpackPosByPos(int rowIndex, int colIndex)
		{
			return this.PosDataDoublyList[rowIndex][colIndex];
		}

		// Token: 0x06041277 RID: 266871 RVA: 0x00FCA64C File Offset: 0x00FC884C
		public List<DockyardItemBlockData> GetBackpackItemList()
		{
			return this.ItemBlockDataMap.Values.ToList<DockyardItemBlockData>();
		}

		// Token: 0x06041278 RID: 266872 RVA: 0x00FCA65E File Offset: 0x00FC885E
		public Dictionary<int, DockyardItemBlockData> GetBackpackItemMap()
		{
			return this.ItemBlockDataMap;
		}

		// Token: 0x06041279 RID: 266873 RVA: 0x00FCA666 File Offset: 0x00FC8866
		public DockyardBackpackGridData GetBackpackGridData(IPanelPos pos)
		{
			return this.GridDataMap[pos];
		}

		// Token: 0x0604127A RID: 266874 RVA: 0x00FCA674 File Offset: 0x00FC8874
		public DockyardItemBlockData AddItemBlockData(DockyardItemBlockOriginalData data)
		{
			DockyardItemBlockData dockyardItemBlockData = new DockyardItemBlockData(data);
			this.ItemBlockDataMap.Add(data.IncId, dockyardItemBlockData);
			return dockyardItemBlockData;
		}

		// Token: 0x0604127B RID: 266875 RVA: 0x00FCA69B File Offset: 0x00FC889B
		public void DeleteItemBlockData(int incId)
		{
			this.ItemBlockDataMap.Remove(incId);
		}

		// Token: 0x0604127C RID: 266876 RVA: 0x00FCA6AA File Offset: 0x00FC88AA
		[NullableContext(2)]
		public DockyardItemBlockData GetItemBlockData(int incId)
		{
			return this.ItemBlockDataMap.GetValueOrDefault(incId);
		}

		// Token: 0x04021F01 RID: 139009
		private readonly Dictionary<IPanelPos, DockyardBackpackGridData> GridDataMap = new Dictionary<IPanelPos, DockyardBackpackGridData>();

		// Token: 0x04021F02 RID: 139010
		private readonly List<List<IPanelPos>> PosDataDoublyList = new List<List<IPanelPos>>();

		// Token: 0x04021F03 RID: 139011
		private readonly Dictionary<int, DockyardItemBlockData> ItemBlockDataMap = new Dictionary<int, DockyardItemBlockData>();

		// Token: 0x04021F04 RID: 139012
		[Nullable(2)]
		private DockyardQuicklySellData QuicklySellData;

		// Token: 0x04021F05 RID: 139013
		private readonly List<IPanelPos> PosDataList = new List<IPanelPos>();
	}
}
