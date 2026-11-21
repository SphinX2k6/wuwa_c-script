using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005534 RID: 21812
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardItemListPanelModel
	{
		// Token: 0x170068E8 RID: 26856
		// (get) Token: 0x060361AF RID: 221615 RVA: 0x00F1AE3A File Offset: 0x00F1903A
		// (set) Token: 0x060361B0 RID: 221616 RVA: 0x00F1AE42 File Offset: 0x00F19042
		public DockyardItemListPanel Panel { get; set; }

		// Token: 0x170068E9 RID: 26857
		// (get) Token: 0x060361B1 RID: 221617 RVA: 0x00F1AE4B File Offset: 0x00F1904B
		// (set) Token: 0x060361B2 RID: 221618 RVA: 0x00F1AE53 File Offset: 0x00F19053
		protected IDockyardWareHouseInterface BackpackPanelModel { get; set; }

		// Token: 0x170068EA RID: 26858
		// (get) Token: 0x060361B3 RID: 221619 RVA: 0x00F1AE5C File Offset: 0x00F1905C
		// (set) Token: 0x060361B4 RID: 221620 RVA: 0x00F1AE64 File Offset: 0x00F19064
		public List<DockyardItemBlockOriginalData> ShowItemList { get; set; } = new List<DockyardItemBlockOriginalData>();

		// Token: 0x170068EB RID: 26859
		// (get) Token: 0x060361B5 RID: 221621 RVA: 0x00F1AE6D File Offset: 0x00F1906D
		// (set) Token: 0x060361B6 RID: 221622 RVA: 0x00F1AE75 File Offset: 0x00F19075
		public int InSelectedBlockId { get; set; } = -1;

		// Token: 0x170068EC RID: 26860
		// (get) Token: 0x060361B7 RID: 221623 RVA: 0x00F1AE7E File Offset: 0x00F1907E
		// (set) Token: 0x060361B8 RID: 221624 RVA: 0x00F1AE86 File Offset: 0x00F19086
		public IPanelComponentData ComponentData { get; set; } = new PanelComponentData
		{
			TitleText = "",
			GetCountText = null,
			HelpBtnId = 0,
			TimeText = ""
		};

		// Token: 0x060361B9 RID: 221625 RVA: 0x00F1AE8F File Offset: 0x00F1908F
		public void RegisterPanel(DockyardItemListPanel panel)
		{
			this.Panel = panel;
			this.OnInit();
		}

		// Token: 0x060361BA RID: 221626 RVA: 0x00F1AEA0 File Offset: 0x00F190A0
		public void RefreshShowItemList()
		{
			this.ShowItemMap.Clear();
			this.ShowItemList = this.GetShowItemList();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ShowItemList)
			{
				this.ShowItemMap.Add(dockyardItemBlockOriginalData.IncId, dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x060361BB RID: 221627 RVA: 0x00F1AF18 File Offset: 0x00F19118
		public void RegisterBackpackPanelModel(IDockyardWareHouseInterface backpackPanelModel)
		{
			this.BackpackPanelModel = backpackPanelModel;
		}

		// Token: 0x060361BC RID: 221628 RVA: 0x00F1AF24 File Offset: 0x00F19124
		private UniTask DragClickAsync(DockyardItemBlockOriginalData data)
		{
			DockyardItemListPanelModel.<DragClickAsync>d__24 <DragClickAsync>d__;
			<DragClickAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<DragClickAsync>d__.<>4__this = this;
			<DragClickAsync>d__.data = data;
			<DragClickAsync>d__.<>1__state = -1;
			<DragClickAsync>d__.<>t__builder.Start<DockyardItemListPanelModel.<DragClickAsync>d__24>(ref <DragClickAsync>d__);
			return <DragClickAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060361BD RID: 221629 RVA: 0x00F1AF6F File Offset: 0x00F1916F
		public void DragClick(DockyardItemBlockOriginalData data)
		{
			this.DragClickAsync(data);
		}

		// Token: 0x060361BE RID: 221630 RVA: 0x00F1AF7C File Offset: 0x00F1917C
		public void DragBegin(DockyardItemBlockOriginalData data)
		{
			if (!this.CanClick(data.IncId))
			{
				return;
			}
			this.InSelectedBlockId = data.IncId;
			DockyardModel.Instance.AddListItemReadFlag(data.ItemId);
			IDockyardWareHouseInterface backpackPanelModel = this.BackpackPanelModel;
			if (backpackPanelModel != null)
			{
				backpackPanelModel.WareHouseItemDragBegin(data);
			}
			this.Panel.RefreshListItemRedDot(data.ItemId);
			this.Panel.RefreshListItemStateByIncId(data.IncId);
			this.Panel.RefreshListItem();
		}

		// Token: 0x060361BF RID: 221631 RVA: 0x00F1AFF4 File Offset: 0x00F191F4
		private bool CanClick(int id)
		{
			if (id == this.InSelectedBlockId)
			{
				return false;
			}
			IDockyardWareHouseInterface backpackPanelModel = this.BackpackPanelModel;
			return backpackPanelModel == null || backpackPanelModel.IsWareHouseItemCanClick(id);
		}

		// Token: 0x060361C0 RID: 221632 RVA: 0x00F1B013 File Offset: 0x00F19213
		private bool DeleteSelectedItemBlock()
		{
			if (this.InSelectedBlockId == -1)
			{
				return false;
			}
			bool result = this.RemoveShowListData(this.InSelectedBlockId);
			this.InSelectedBlockId = -1;
			return result;
		}

		// Token: 0x060361C1 RID: 221633 RVA: 0x00F1B033 File Offset: 0x00F19233
		public void SetItemBlockToWareHouse(DockyardItemBlockOriginalData data)
		{
			this.DeleteSelectedItemBlock();
			this.AddShowListData(data);
			DockyardItemListPanel panel = this.Panel;
			if (panel == null)
			{
				return;
			}
			panel.RefreshListItem();
		}

		// Token: 0x060361C2 RID: 221634 RVA: 0x00F1B054 File Offset: 0x00F19254
		public void DeleteItemBlockListFromWareHouse(List<int> incIdList)
		{
			bool flag = false;
			foreach (int id in incIdList)
			{
				bool flag2 = this.RemoveShowListData(id);
				flag = (flag || flag2);
			}
			if (flag)
			{
				DockyardItemListPanel panel = this.Panel;
				if (panel == null)
				{
					return;
				}
				panel.RefreshListItem();
			}
		}

		// Token: 0x060361C3 RID: 221635 RVA: 0x00F1B0C0 File Offset: 0x00F192C0
		public void DeleteSelectedItemBlockAndRefresh()
		{
			if (this.DeleteSelectedItemBlock())
			{
				DockyardItemListPanel panel = this.Panel;
				if (panel == null)
				{
					return;
				}
				panel.RefreshListItem();
			}
		}

		// Token: 0x060361C4 RID: 221636 RVA: 0x00F1B0DB File Offset: 0x00F192DB
		public void ResetSelectedBlock()
		{
			this.InSelectedBlockId = -1;
		}

		// Token: 0x060361C5 RID: 221637 RVA: 0x00F1B0E4 File Offset: 0x00F192E4
		public bool HasItemBlockInWareHouse(int incId)
		{
			return this.ShowItemMap.ContainsKey(incId);
		}

		// Token: 0x060361C6 RID: 221638 RVA: 0x00F1B0F2 File Offset: 0x00F192F2
		private void AddShowListData(DockyardItemBlockOriginalData data)
		{
			this.ShowItemList.Insert(0, data);
			this.ShowItemMap.Add(data.IncId, data);
		}

		// Token: 0x060361C7 RID: 221639 RVA: 0x00F1B114 File Offset: 0x00F19314
		private bool RemoveShowListData(int id)
		{
			DockyardItemBlockOriginalData item = this.ShowItemMap[id];
			int num = this.ShowItemList.IndexOf(item);
			if (num >= 0)
			{
				this.ShowItemList.RemoveAt(num);
			}
			return this.ShowItemMap.Remove(id);
		}

		// Token: 0x060361C8 RID: 221640 RVA: 0x00F1B157 File Offset: 0x00F19357
		private bool CheckOpenFunction()
		{
			return FunctionModel.Instance.IsOpen(10076);
		}

		// Token: 0x060361C9 RID: 221641 RVA: 0x00F1B168 File Offset: 0x00F19368
		protected bool CheckSelectedInList()
		{
			IDockyardWareHouseInterface backpackPanelModel = this.BackpackPanelModel;
			int? num = (backpackPanelModel != null) ? new int?(backpackPanelModel.GetSelectedId()) : null;
			if (num.GetValueOrDefault() == -1)
			{
				return false;
			}
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.GetShowItemList())
			{
				int incId = dockyardItemBlockOriginalData.IncId;
				int? num2 = num;
				if (incId == num2.GetValueOrDefault() & num2 != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060361CA RID: 221642 RVA: 0x00F1B200 File Offset: 0x00F19400
		public bool CanDragToListPanel(bool ignoreViewportCheck)
		{
			if (!ignoreViewportCheck && this.Panel != null && !this.Panel.CheckInViewport())
			{
				return false;
			}
			if (!this.CheckOtherCanDragCondition(true))
			{
				return false;
			}
			if (!this.CheckOpenFunction() && !this.CheckSelectedInList())
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("Fishing_FishingBanMoveBack", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x060361CB RID: 221643 RVA: 0x00F1B25C File Offset: 0x00F1945C
		public void RefreshDragTips(bool isInDrag, bool isInBackpack)
		{
			if (this.Panel != null)
			{
				bool flag = this.Panel.CheckInViewport() && this.CheckOtherCanDragCondition(false);
				this.Panel.SetDragTipsActive(isInDrag && !isInBackpack && flag);
			}
		}

		// Token: 0x060361CC RID: 221644 RVA: 0x00F1B2A0 File Offset: 0x00F194A0
		protected virtual bool CheckOtherCanDragCondition(bool fromDragResult)
		{
			return true;
		}

		// Token: 0x060361CD RID: 221645
		public abstract List<DockyardItemBlockOriginalData> GetShowItemList();

		// Token: 0x060361CE RID: 221646 RVA: 0x00F1B2A3 File Offset: 0x00F194A3
		protected virtual void OnInit()
		{
		}

		// Token: 0x0401C914 RID: 117012
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ShowItemMap = new Dictionary<int, DockyardItemBlockOriginalData>();
	}
}
