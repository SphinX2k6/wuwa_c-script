using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065B6 RID: 26038
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class DockyardItemListPanelModel
	{
		// Token: 0x17009586 RID: 38278
		// (get) Token: 0x060414EA RID: 267498 RVA: 0x00FD3E36 File Offset: 0x00FD2036
		// (set) Token: 0x060414EB RID: 267499 RVA: 0x00FD3E3E File Offset: 0x00FD203E
		public DockyardItemListPanel Panel { get; set; }

		// Token: 0x17009587 RID: 38279
		// (get) Token: 0x060414EC RID: 267500 RVA: 0x00FD3E47 File Offset: 0x00FD2047
		// (set) Token: 0x060414ED RID: 267501 RVA: 0x00FD3E4F File Offset: 0x00FD204F
		protected IDockyardWareHouseInterface BackpackPanelModel { get; set; }

		// Token: 0x17009588 RID: 38280
		// (get) Token: 0x060414EE RID: 267502 RVA: 0x00FD3E58 File Offset: 0x00FD2058
		// (set) Token: 0x060414EF RID: 267503 RVA: 0x00FD3E60 File Offset: 0x00FD2060
		public List<DockyardItemBlockOriginalData> ShowItemList { get; set; } = new List<DockyardItemBlockOriginalData>();

		// Token: 0x17009589 RID: 38281
		// (get) Token: 0x060414F0 RID: 267504 RVA: 0x00FD3E69 File Offset: 0x00FD2069
		// (set) Token: 0x060414F1 RID: 267505 RVA: 0x00FD3E71 File Offset: 0x00FD2071
		public int InSelectedBlockId { get; set; } = -1;

		// Token: 0x1700958A RID: 38282
		// (get) Token: 0x060414F2 RID: 267506 RVA: 0x00FD3E7A File Offset: 0x00FD207A
		// (set) Token: 0x060414F3 RID: 267507 RVA: 0x00FD3E82 File Offset: 0x00FD2082
		public IPanelComponentData ComponentData { get; set; } = new PanelComponentData
		{
			TitleText = "",
			GetCountText = null,
			HelpBtnId = 0,
			TimeText = ""
		};

		// Token: 0x060414F4 RID: 267508 RVA: 0x00FD3E8B File Offset: 0x00FD208B
		public void RegisterPanel(DockyardItemListPanel panel)
		{
			this.Panel = panel;
			this.OnInit();
		}

		// Token: 0x060414F5 RID: 267509 RVA: 0x00FD3E9C File Offset: 0x00FD209C
		public void RefreshShowItemList()
		{
			this.ShowItemMap.Clear();
			this.ShowItemList = this.GetShowItemList();
			foreach (DockyardItemBlockOriginalData dockyardItemBlockOriginalData in this.ShowItemList)
			{
				this.ShowItemMap.Add(dockyardItemBlockOriginalData.IncId, dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x060414F6 RID: 267510 RVA: 0x00FD3F14 File Offset: 0x00FD2114
		public void RegisterBackpackPanelModel(IDockyardWareHouseInterface backpackPanelModel)
		{
			this.BackpackPanelModel = backpackPanelModel;
		}

		// Token: 0x060414F7 RID: 267511 RVA: 0x00FD3F20 File Offset: 0x00FD2120
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

		// Token: 0x060414F8 RID: 267512 RVA: 0x00FD3F6B File Offset: 0x00FD216B
		public void DragClick(DockyardItemBlockOriginalData data)
		{
			this.DragClickAsync(data);
		}

		// Token: 0x060414F9 RID: 267513 RVA: 0x00FD3F78 File Offset: 0x00FD2178
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

		// Token: 0x060414FA RID: 267514 RVA: 0x00FD3FF0 File Offset: 0x00FD21F0
		private bool CanClick(int id)
		{
			if (id == this.InSelectedBlockId)
			{
				return false;
			}
			IDockyardWareHouseInterface backpackPanelModel = this.BackpackPanelModel;
			return backpackPanelModel == null || backpackPanelModel.IsWareHouseItemCanClick(id);
		}

		// Token: 0x060414FB RID: 267515 RVA: 0x00FD400F File Offset: 0x00FD220F
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

		// Token: 0x060414FC RID: 267516 RVA: 0x00FD402F File Offset: 0x00FD222F
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

		// Token: 0x060414FD RID: 267517 RVA: 0x00FD4050 File Offset: 0x00FD2250
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

		// Token: 0x060414FE RID: 267518 RVA: 0x00FD40BC File Offset: 0x00FD22BC
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

		// Token: 0x060414FF RID: 267519 RVA: 0x00FD40D7 File Offset: 0x00FD22D7
		public void ResetSelectedBlock()
		{
			this.InSelectedBlockId = -1;
		}

		// Token: 0x06041500 RID: 267520 RVA: 0x00FD40E0 File Offset: 0x00FD22E0
		public bool HasItemBlockInWareHouse(int incId)
		{
			return this.ShowItemMap.ContainsKey(incId);
		}

		// Token: 0x06041501 RID: 267521 RVA: 0x00FD40EE File Offset: 0x00FD22EE
		private void AddShowListData(DockyardItemBlockOriginalData data)
		{
			this.ShowItemList.Insert(0, data);
			this.ShowItemMap.Add(data.IncId, data);
		}

		// Token: 0x06041502 RID: 267522 RVA: 0x00FD4110 File Offset: 0x00FD2310
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

		// Token: 0x06041503 RID: 267523 RVA: 0x00FD4153 File Offset: 0x00FD2353
		private bool CheckOpenFunction()
		{
			return FunctionModel.Instance.IsOpen(10076);
		}

		// Token: 0x06041504 RID: 267524 RVA: 0x00FD4164 File Offset: 0x00FD2364
		protected bool CheckSelectedInList()
		{
			DockyardItemListPanelModel.<>c__DisplayClass37_0 CS$<>8__locals1 = new DockyardItemListPanelModel.<>c__DisplayClass37_0();
			DockyardItemListPanelModel.<>c__DisplayClass37_0 CS$<>8__locals2 = CS$<>8__locals1;
			IDockyardWareHouseInterface backpackPanelModel = this.BackpackPanelModel;
			CS$<>8__locals2.selected = ((backpackPanelModel != null) ? new int?(backpackPanelModel.GetSelectedId()) : null);
			return CS$<>8__locals1.selected.GetValueOrDefault() != -1 && this.GetShowItemList().Any(delegate(DockyardItemBlockOriginalData item)
			{
				int incId = item.IncId;
				int? selected = CS$<>8__locals1.selected;
				return incId == selected.GetValueOrDefault() & selected != null;
			});
		}

		// Token: 0x06041505 RID: 267525 RVA: 0x00FD41C4 File Offset: 0x00FD23C4
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

		// Token: 0x06041506 RID: 267526 RVA: 0x00FD4220 File Offset: 0x00FD2420
		public void RefreshDragTips(bool isInDrag, bool isInBackpack)
		{
			if (this.Panel != null)
			{
				bool flag = this.Panel.CheckInViewport() && this.CheckOtherCanDragCondition(false);
				this.Panel.SetDragTipsActive(isInDrag && !isInBackpack && flag);
			}
		}

		// Token: 0x06041507 RID: 267527 RVA: 0x00FD4264 File Offset: 0x00FD2464
		protected virtual bool CheckOtherCanDragCondition(bool fromDragResult)
		{
			return true;
		}

		// Token: 0x06041508 RID: 267528
		public abstract List<DockyardItemBlockOriginalData> GetShowItemList();

		// Token: 0x06041509 RID: 267529 RVA: 0x00FD4267 File Offset: 0x00FD2467
		protected virtual void OnInit()
		{
		}

		// Token: 0x04021FE3 RID: 139235
		private readonly Dictionary<int, DockyardItemBlockOriginalData> ShowItemMap = new Dictionary<int, DockyardItemBlockOriginalData>();
	}
}
