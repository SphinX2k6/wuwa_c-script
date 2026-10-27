using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065AA RID: 26026
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractPanelModel
	{
		// Token: 0x1700957C RID: 38268
		// (get) Token: 0x0604141A RID: 267290 RVA: 0x00FD0538 File Offset: 0x00FCE738
		[Nullable(2)]
		public DockyardItemBlock InSelectItemBlock
		{
			[NullableContext(2)]
			get
			{
				return this.BackpackPanelModel.Panel.InSelectItemBlock;
			}
		}

		// Token: 0x0604141B RID: 267291 RVA: 0x00FD054C File Offset: 0x00FCE74C
		private void InitGridData()
		{
			for (int i = 0; i < 3; i++)
			{
				this.PosDataDoublyList.Add(new List<IPanelPos>());
				for (int j = 0; j < 6; j++)
				{
					DockyardInteractPanelModel.PanelPos panelPos = new DockyardInteractPanelModel.PanelPos
					{
						RowIndex = i,
						ColIndex = j
					};
					DockyardInteractGridData value = new DockyardInteractGridData(panelPos);
					this.PosDataList.Add(panelPos);
					this.PosDataDoublyList[i].Add(panelPos);
					this.GridDataMap.Add(panelPos, value);
				}
			}
		}

		// Token: 0x0604141C RID: 267292 RVA: 0x00FD05C7 File Offset: 0x00FCE7C7
		private DockyardInteractItemBlockData CreateItemBlock(DockyardItemBlockOriginalData data, int rowIndex, int colIndex, int rotate)
		{
			return new DockyardInteractItemBlockData(data)
			{
				Pos = 
				{
					RowIndex = rowIndex,
					ColIndex = colIndex
				},
				Rotate = rotate
			};
		}

		// Token: 0x0604141D RID: 267293 RVA: 0x00FD05F0 File Offset: 0x00FCE7F0
		private void InitShowItemMap()
		{
			Dictionary<int, DockyardItemBlockOriginalData> dataMapByInteract = FishingModel.Instance.GetDataMapByInteract(this.ConfigId);
			if (dataMapByInteract != null)
			{
				foreach (KeyValuePair<int, DockyardItemBlockOriginalData> keyValuePair in dataMapByInteract)
				{
					DockyardInteractItemBlockData value = this.CreateItemBlock(keyValuePair.Value, keyValuePair.Value.PosY, keyValuePair.Value.PosX, (int)keyValuePair.Value.Rotate);
					this.ShowItemMap.Add(keyValuePair.Key, value);
				}
			}
		}

		// Token: 0x0604141E RID: 267294 RVA: 0x00FD0690 File Offset: 0x00FCE890
		public void InitPanel(DockyardInteractPanel panel)
		{
			this.Panel = panel;
			this.InitShowItemMap();
			this.InitGridData();
		}

		// Token: 0x0604141F RID: 267295 RVA: 0x00FD06A5 File Offset: 0x00FCE8A5
		public void RegisterViewModel(DockyardInteractViewModel viewModel)
		{
			this.ViewModel = viewModel;
		}

		// Token: 0x06041420 RID: 267296 RVA: 0x00FD06AE File Offset: 0x00FCE8AE
		public void RegisterBackpackPanel(DockyardBackpackPanelModelBase backpackPanel)
		{
			this.BackpackPanelModel = (DockyardInteractBackpackPanelModel)backpackPanel;
		}

		// Token: 0x06041421 RID: 267297 RVA: 0x00FD06BC File Offset: 0x00FCE8BC
		public DockyardInteractGridData GetInteractGridData(IPanelPos pos)
		{
			return this.GridDataMap[pos];
		}

		// Token: 0x06041422 RID: 267298 RVA: 0x00FD06CA File Offset: 0x00FCE8CA
		public IPanelPos GetInteractPosByPos(int rowIndex, int colIndex)
		{
			return this.PosDataDoublyList[rowIndex][colIndex];
		}

		// Token: 0x06041423 RID: 267299 RVA: 0x00FD06E0 File Offset: 0x00FCE8E0
		public void Tick(float deltaTime)
		{
			if (!this.BackpackPanelModel.IsOutOfRange)
			{
				if (this.LastCanTickState)
				{
					this.Panel.ResetLastBackpackGridShowType();
				}
				this.LastCanTickState = false;
				return;
			}
			DockyardItemBlock inSelectItemBlock = this.InSelectItemBlock;
			if (inSelectItemBlock == null || !inSelectItemBlock.IsItemBlockInPanel(this.Panel.AttachItem))
			{
				if (this.LastCanTickState)
				{
					this.Panel.ResetLastBackpackGridShowType();
				}
				this.IsOutOfRange = true;
				this.LastCanTickState = false;
				return;
			}
			this.Panel.RefreshAllBackpackGridState(this.LastCanTickState == this.BackpackPanelModel.IsOutOfRange);
			this.LastCanTickState = this.BackpackPanelModel.IsOutOfRange;
		}

		// Token: 0x06041424 RID: 267300 RVA: 0x00FD0788 File Offset: 0x00FCE988
		public bool CanConfirm()
		{
			return this.IsAllMatch;
		}

		// Token: 0x06041425 RID: 267301 RVA: 0x00FD0790 File Offset: 0x00FCE990
		public bool IsOverlap()
		{
			return this.IsOverlapAnother;
		}

		// Token: 0x06041426 RID: 267302 RVA: 0x00FD0798 File Offset: 0x00FCE998
		public void DragClick(DockyardItemBlockOriginalData oldData, IPanelPos startPos)
		{
			if (!this.CanClick(oldData.IncId))
			{
				return;
			}
			this.LastCanTickState = true;
			this.Panel.InitAppropriatePos(oldData);
			this.ShowItemMap.Remove(oldData.IncId);
			this.Panel.DisableInteractItemBlock(oldData, startPos);
			DockyardItemBlockOriginalData dataByInteract = FishingModel.Instance.GetDataByInteract(this.ConfigId, oldData.IncId);
			this.BackpackPanelModel.WareHouseItemDragBegin(dataByInteract);
		}

		// Token: 0x06041427 RID: 267303 RVA: 0x00FD080C File Offset: 0x00FCEA0C
		public void DragBegin(DockyardItemBlockOriginalData oldData, IPanelPos startPos)
		{
			if (!this.CanClick(oldData.IncId))
			{
				return;
			}
			this.LastCanTickState = true;
			this.Panel.InitAppropriatePos(oldData);
			this.ShowItemMap.Remove(oldData.IncId);
			DockyardInteractViewModel viewModel = this.ViewModel;
			if (viewModel != null)
			{
				viewModel.HandleDragBegin();
			}
			this.Panel.DisableInteractItemBlock(oldData, startPos);
			DockyardItemBlockOriginalData dataByInteract = FishingModel.Instance.GetDataByInteract(this.ConfigId, oldData.IncId);
			this.BackpackPanelModel.WareHouseItemDragBegin(dataByInteract);
		}

		// Token: 0x06041428 RID: 267304 RVA: 0x00FD0890 File Offset: 0x00FCEA90
		public void ChangeShowItemData()
		{
			DockyardItemBlockData data = this.InSelectItemBlock.GetData();
			DockyardItemBlockOriginalData data2 = data.Data;
			DockyardInteractItemBlockData oldData = this.GetOldData(data2.ItemId, (int)data.Rotate);
			DockyardInteractItemBlockData value = this.CreateItemBlock(data2, this.MatchPos.RowIndex, this.MatchPos.ColIndex, (int)data.Rotate);
			this.ShowItemMap.Add(data2.IncId, value);
			this.Panel.EnableInteractItemBlock(data2);
			if (oldData != null)
			{
				this.BackpackPanelModel.Panel.ReplaceSelectItemBlock(oldData.Data);
				this.ShowItemMap.Remove(oldData.Data.IncId);
			}
		}

		// Token: 0x06041429 RID: 267305 RVA: 0x00FD0935 File Offset: 0x00FCEB35
		public void ShowScrollingTips()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_MatchFail", Array.Empty<object>());
		}

		// Token: 0x0604142A RID: 267306 RVA: 0x00FD094C File Offset: 0x00FCEB4C
		[NullableContext(2)]
		private DockyardInteractItemBlockData GetOldData(int itemId, int rotateType)
		{
			foreach (DockyardInteractItemBlockData dockyardInteractItemBlockData in this.ShowItemMap.Values)
			{
				if (dockyardInteractItemBlockData.Data.ItemId == itemId && dockyardInteractItemBlockData.Pos.ColIndex == this.MatchPos.ColIndex && dockyardInteractItemBlockData.Pos.RowIndex == this.MatchPos.RowIndex && rotateType == dockyardInteractItemBlockData.Rotate)
				{
					return dockyardInteractItemBlockData;
				}
			}
			return null;
		}

		// Token: 0x0604142B RID: 267307 RVA: 0x00FD09EC File Offset: 0x00FCEBEC
		private bool CanClick(int id)
		{
			return this.BackpackPanelModel.IsWareHouseItemCanClick(id);
		}

		// Token: 0x04021F88 RID: 139144
		public int ConfigId;

		// Token: 0x04021F89 RID: 139145
		public DockyardInteractPanel Panel;

		// Token: 0x04021F8A RID: 139146
		public bool IsOutOfRange = true;

		// Token: 0x04021F8B RID: 139147
		public bool IsAllMatch;

		// Token: 0x04021F8C RID: 139148
		public bool IsOverlapAnother;

		// Token: 0x04021F8D RID: 139149
		private readonly List<List<IPanelPos>> PosDataDoublyList = new List<List<IPanelPos>>();

		// Token: 0x04021F8E RID: 139150
		public readonly List<IPanelPos> PosDataList = new List<IPanelPos>();

		// Token: 0x04021F8F RID: 139151
		private readonly Dictionary<IPanelPos, DockyardInteractGridData> GridDataMap = new Dictionary<IPanelPos, DockyardInteractGridData>();

		// Token: 0x04021F90 RID: 139152
		public bool LastCanTickState;

		// Token: 0x04021F91 RID: 139153
		[Nullable(2)]
		protected DockyardInteractViewModel ViewModel;

		// Token: 0x04021F92 RID: 139154
		public DockyardInteractBackpackPanelModel BackpackPanelModel;

		// Token: 0x04021F93 RID: 139155
		public Dictionary<int, DockyardInteractItemBlockData> ShowItemMap = new Dictionary<int, DockyardInteractItemBlockData>();

		// Token: 0x04021F94 RID: 139156
		public IPanelPos MatchPos = new DockyardInteractPanelModel.PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x0200C7AA RID: 51114
		[NullableContext(0)]
		private class PanelPos : IPanelPos
		{
			// Token: 0x1700A28E RID: 41614
			// (get) Token: 0x06050FE1 RID: 331745 RVA: 0x015E5E86 File Offset: 0x015E4086
			// (set) Token: 0x06050FE2 RID: 331746 RVA: 0x015E5E8E File Offset: 0x015E408E
			public int RowIndex { get; set; }

			// Token: 0x1700A28F RID: 41615
			// (get) Token: 0x06050FE3 RID: 331747 RVA: 0x015E5E97 File Offset: 0x015E4097
			// (set) Token: 0x06050FE4 RID: 331748 RVA: 0x015E5E9F File Offset: 0x015E409F
			public int ColIndex { get; set; }
		}
	}
}
