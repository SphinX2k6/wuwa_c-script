using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005509 RID: 21769
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardBackpackData
	{
		// Token: 0x06035F30 RID: 220976 RVA: 0x00F111CC File Offset: 0x00F0F3CC
		public DockyardBackpackData(bool isQuicklySellOpen)
		{
			this.InitQuicklySellData(isQuicklySellOpen);
			this.InitGridDataMap();
			this.InitItemBlockDataMap();
		}

		// Token: 0x06035F31 RID: 220977 RVA: 0x00F11220 File Offset: 0x00F0F420
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

		// Token: 0x06035F32 RID: 220978 RVA: 0x00F1124C File Offset: 0x00F0F44C
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

		// Token: 0x06035F33 RID: 220979 RVA: 0x00F11354 File Offset: 0x00F0F554
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

		// Token: 0x06035F34 RID: 220980 RVA: 0x00F113A4 File Offset: 0x00F0F5A4
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

		// Token: 0x06035F35 RID: 220981 RVA: 0x00F11420 File Offset: 0x00F0F620
		public void RefreshBackpackData()
		{
			this.ClearGridDataMapItemBlockId();
			this.InitItemBlockDataMap();
		}

		// Token: 0x06035F36 RID: 220982 RVA: 0x00F11430 File Offset: 0x00F0F630
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

		// Token: 0x06035F37 RID: 220983 RVA: 0x00F114B4 File Offset: 0x00F0F6B4
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

		// Token: 0x06035F38 RID: 220984 RVA: 0x00F11554 File Offset: 0x00F0F754
		private void ResetGridDataInQuicklySellType()
		{
			foreach (DockyardBackpackGridData dockyardBackpackGridData in this.GridDataMap.Values)
			{
				dockyardBackpackGridData.SetIsQuicklySell(false);
			}
		}

		// Token: 0x06035F39 RID: 220985 RVA: 0x00F115AC File Offset: 0x00F0F7AC
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

		// Token: 0x06035F3A RID: 220986 RVA: 0x00F115E0 File Offset: 0x00F0F7E0
		public List<IPanelPos> GetBackpackDataList()
		{
			return this.PosDataList;
		}

		// Token: 0x06035F3B RID: 220987 RVA: 0x00F115E8 File Offset: 0x00F0F7E8
		public IPanelPos GetBackpackPosByPos(int rowIndex, int colIndex)
		{
			return this.PosDataDoublyList[rowIndex][colIndex];
		}

		// Token: 0x06035F3C RID: 220988 RVA: 0x00F115FC File Offset: 0x00F0F7FC
		public List<DockyardItemBlockData> GetBackpackItemList()
		{
			return new List<DockyardItemBlockData>(this.ItemBlockDataMap.Values);
		}

		// Token: 0x06035F3D RID: 220989 RVA: 0x00F1160E File Offset: 0x00F0F80E
		public Dictionary<int, DockyardItemBlockData> GetBackpackItemMap()
		{
			return this.ItemBlockDataMap;
		}

		// Token: 0x06035F3E RID: 220990 RVA: 0x00F11616 File Offset: 0x00F0F816
		public DockyardBackpackGridData GetBackpackGridData(IPanelPos pos)
		{
			return this.GridDataMap[pos];
		}

		// Token: 0x06035F3F RID: 220991 RVA: 0x00F11624 File Offset: 0x00F0F824
		public DockyardItemBlockData AddItemBlockData(DockyardItemBlockOriginalData data)
		{
			DockyardItemBlockData dockyardItemBlockData = new DockyardItemBlockData(data);
			this.ItemBlockDataMap.Add(data.IncId, dockyardItemBlockData);
			return dockyardItemBlockData;
		}

		// Token: 0x06035F40 RID: 220992 RVA: 0x00F1164B File Offset: 0x00F0F84B
		public void DeleteItemBlockData(int incId)
		{
			this.ItemBlockDataMap.Remove(incId);
		}

		// Token: 0x06035F41 RID: 220993 RVA: 0x00F1165A File Offset: 0x00F0F85A
		[NullableContext(2)]
		public DockyardItemBlockData GetItemBlockData(int incId)
		{
			return this.ItemBlockDataMap.GetValueOrDefault(incId);
		}

		// Token: 0x0401C832 RID: 116786
		private readonly Dictionary<IPanelPos, DockyardBackpackGridData> GridDataMap = new Dictionary<IPanelPos, DockyardBackpackGridData>();

		// Token: 0x0401C833 RID: 116787
		private readonly List<List<IPanelPos>> PosDataDoublyList = new List<List<IPanelPos>>();

		// Token: 0x0401C834 RID: 116788
		private readonly Dictionary<int, DockyardItemBlockData> ItemBlockDataMap = new Dictionary<int, DockyardItemBlockData>();

		// Token: 0x0401C835 RID: 116789
		[Nullable(2)]
		private DockyardQuicklySellData QuicklySellData;

		// Token: 0x0401C836 RID: 116790
		private readonly List<IPanelPos> PosDataList = new List<IPanelPos>();
	}
}
