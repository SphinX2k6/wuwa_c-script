using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005528 RID: 21800
	[NullableContext(1)]
	[Nullable(0)]
	public class DockyardInteractPanelModel
	{
		// Token: 0x170068DE RID: 26846
		// (get) Token: 0x060360DF RID: 221407 RVA: 0x00F1753C File Offset: 0x00F1573C
		[Nullable(2)]
		public DockyardItemBlock InSelectItemBlock
		{
			[NullableContext(2)]
			get
			{
				return this.BackpackPanelModel.Panel.InSelectItemBlock;
			}
		}

		// Token: 0x060360E0 RID: 221408 RVA: 0x00F17550 File Offset: 0x00F15750
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

		// Token: 0x060360E1 RID: 221409 RVA: 0x00F175CB File Offset: 0x00F157CB
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

		// Token: 0x060360E2 RID: 221410 RVA: 0x00F175F4 File Offset: 0x00F157F4
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

		// Token: 0x060360E3 RID: 221411 RVA: 0x00F17694 File Offset: 0x00F15894
		public void InitPanel(DockyardInteractPanel panel)
		{
			this.Panel = panel;
			this.InitShowItemMap();
			this.InitGridData();
		}

		// Token: 0x060360E4 RID: 221412 RVA: 0x00F176A9 File Offset: 0x00F158A9
		public void RegisterViewModel(DockyardInteractViewModel viewModel)
		{
			this.ViewModel = viewModel;
		}

		// Token: 0x060360E5 RID: 221413 RVA: 0x00F176B2 File Offset: 0x00F158B2
		public void RegisterBackpackPanel(DockyardBackpackPanelModelBase backpackPanel)
		{
			this.BackpackPanelModel = (DockyardInteractBackpackPanelModel)backpackPanel;
		}

		// Token: 0x060360E6 RID: 221414 RVA: 0x00F176C0 File Offset: 0x00F158C0
		public DockyardInteractGridData GetInteractGridData(IPanelPos pos)
		{
			return this.GridDataMap[pos];
		}

		// Token: 0x060360E7 RID: 221415 RVA: 0x00F176CE File Offset: 0x00F158CE
		public IPanelPos GetInteractPosByPos(int rowIndex, int colIndex)
		{
			return this.PosDataDoublyList[rowIndex][colIndex];
		}

		// Token: 0x060360E8 RID: 221416 RVA: 0x00F176E4 File Offset: 0x00F158E4
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

		// Token: 0x060360E9 RID: 221417 RVA: 0x00F1778C File Offset: 0x00F1598C
		public bool CanConfirm()
		{
			return this.IsAllMatch;
		}

		// Token: 0x060360EA RID: 221418 RVA: 0x00F17794 File Offset: 0x00F15994
		public bool IsOverlap()
		{
			return this.IsOverlapAnother;
		}

		// Token: 0x060360EB RID: 221419 RVA: 0x00F1779C File Offset: 0x00F1599C
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

		// Token: 0x060360EC RID: 221420 RVA: 0x00F17810 File Offset: 0x00F15A10
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

		// Token: 0x060360ED RID: 221421 RVA: 0x00F17894 File Offset: 0x00F15A94
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

		// Token: 0x060360EE RID: 221422 RVA: 0x00F17939 File Offset: 0x00F15B39
		public void ShowScrollingTips()
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_MatchFail", Array.Empty<object>());
		}

		// Token: 0x060360EF RID: 221423 RVA: 0x00F17950 File Offset: 0x00F15B50
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

		// Token: 0x060360F0 RID: 221424 RVA: 0x00F179F0 File Offset: 0x00F15BF0
		private bool CanClick(int id)
		{
			return this.BackpackPanelModel.IsWareHouseItemCanClick(id);
		}

		// Token: 0x0401C8B9 RID: 116921
		public int ConfigId;

		// Token: 0x0401C8BA RID: 116922
		public DockyardInteractPanel Panel;

		// Token: 0x0401C8BB RID: 116923
		public bool IsOutOfRange = true;

		// Token: 0x0401C8BC RID: 116924
		public bool IsAllMatch;

		// Token: 0x0401C8BD RID: 116925
		public bool IsOverlapAnother;

		// Token: 0x0401C8BE RID: 116926
		private readonly List<List<IPanelPos>> PosDataDoublyList = new List<List<IPanelPos>>();

		// Token: 0x0401C8BF RID: 116927
		public readonly List<IPanelPos> PosDataList = new List<IPanelPos>();

		// Token: 0x0401C8C0 RID: 116928
		private readonly Dictionary<IPanelPos, DockyardInteractGridData> GridDataMap = new Dictionary<IPanelPos, DockyardInteractGridData>();

		// Token: 0x0401C8C1 RID: 116929
		public bool LastCanTickState;

		// Token: 0x0401C8C2 RID: 116930
		[Nullable(2)]
		protected DockyardInteractViewModel ViewModel;

		// Token: 0x0401C8C3 RID: 116931
		public DockyardInteractBackpackPanelModel BackpackPanelModel;

		// Token: 0x0401C8C4 RID: 116932
		public Dictionary<int, DockyardInteractItemBlockData> ShowItemMap = new Dictionary<int, DockyardInteractItemBlockData>();

		// Token: 0x0401C8C5 RID: 116933
		public IPanelPos MatchPos = new DockyardInteractPanelModel.PanelPos
		{
			RowIndex = -1,
			ColIndex = -1
		};

		// Token: 0x0200B18F RID: 45455
		[NullableContext(0)]
		private class PanelPos : IPanelPos
		{
			// Token: 0x17007A2B RID: 31275
			// (get) Token: 0x060474B6 RID: 292022 RVA: 0x0159DD1E File Offset: 0x0159BF1E
			// (set) Token: 0x060474B7 RID: 292023 RVA: 0x0159DD26 File Offset: 0x0159BF26
			public int RowIndex { get; set; }

			// Token: 0x17007A2C RID: 31276
			// (get) Token: 0x060474B8 RID: 292024 RVA: 0x0159DD2F File Offset: 0x0159BF2F
			// (set) Token: 0x060474B9 RID: 292025 RVA: 0x0159DD37 File Offset: 0x0159BF37
			public int ColIndex { get; set; }
		}
	}
}
