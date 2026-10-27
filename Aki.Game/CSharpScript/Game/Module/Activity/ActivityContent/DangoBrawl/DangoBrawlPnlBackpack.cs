using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067F1 RID: 26609
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBackpack : UiPanelBase, IDangoBrawlBagDropZoneExtra, IDangoBrawlItemZone
	{
		// Token: 0x17009707 RID: 38663
		// (get) Token: 0x060424CE RID: 271566 RVA: 0x01018C12 File Offset: 0x01016E12
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17009708 RID: 38664
		// (get) Token: 0x060424CF RID: 271567 RVA: 0x01018C1E File Offset: 0x01016E1E
		private DangoBrawlItemViewRegistry ViewRegistry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x060424D0 RID: 271568 RVA: 0x01018C2C File Offset: 0x01016E2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 20;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(16, new Action(this.OnClickWeightDetail));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(18, new Action(this.OnClickUniqueWeaponDetail));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060424D1 RID: 271569 RVA: 0x01018F58 File Offset: 0x01017158
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBackpack.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060424D2 RID: 271570 RVA: 0x01018F9C File Offset: 0x0101719C
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopSold, new Action<int>(this.OnShopSold));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopComposed, new Action<int, int, int, bool, int[], EDragSourceKind[]>(this.OnDangoBrawlShopComposed));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagOperated, new Action<EBagOpKind, int>(this.OnBagOperated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBackpackModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBackpackModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBenchModified, new Action<EDangoBrawlModifyType, int>(this.OnDangoBrawlBenchModified));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlCostChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlFighterAttrChanged, new Action(this.OnCostChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlBagUpdated, new Action(this.OnBagUpdated));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEndAnyWay, new Action(this.OnDragEndAnyWay));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlLayerModeChanged, new Action<bool>(this.OnLayerModeChanged));
			this.ClearHighlight();
			this.ClearCombineList();
			this.ClearCombineEnsureLineHost();
			this.ClearSmallTipsHover();
		}

		// Token: 0x17009709 RID: 38665
		// (get) Token: 0x060424D3 RID: 271571 RVA: 0x0101912D File Offset: 0x0101732D
		public UUIItem HitItem
		{
			get
			{
				return base.GetItem(5);
			}
		}

		// Token: 0x060424D4 RID: 271572 RVA: 0x01019136 File Offset: 0x01017336
		public void SetBagTemplate(UUIItem template)
		{
			this.BagTemplate = template;
		}

		// Token: 0x060424D5 RID: 271573 RVA: 0x0101913F File Offset: 0x0101733F
		public void SetBagItemTemplate(UUIItem template)
		{
			this.BagItemTemplate = template;
		}

		// Token: 0x060424D6 RID: 271574 RVA: 0x01019148 File Offset: 0x01017348
		public void SetItemTips(DangoBrawlItemTipsBase tips)
		{
			this.ItemTips = tips;
		}

		// Token: 0x060424D7 RID: 271575 RVA: 0x01019151 File Offset: 0x01017351
		public void SetOffsetY(float offsetY)
		{
			this.ItemTipsOffsetY = offsetY;
		}

		// Token: 0x060424D8 RID: 271576 RVA: 0x0101915A File Offset: 0x0101735A
		public void SetGridSize(int size)
		{
			this.GridSize = size;
		}

		// Token: 0x060424D9 RID: 271577 RVA: 0x01019163 File Offset: 0x01017363
		public void SetCombineActive(bool active)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x060424DA RID: 271578 RVA: 0x01019178 File Offset: 0x01017378
		public void SetDragOtherVisualState(bool enable, IReadOnlySet<int> excludeUids = null)
		{
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels)
			{
				if (excludeUids == null || !excludeUids.Contains(dangoBrawlPnlBagView.MyUid))
				{
					dangoBrawlPnlBagView.SetDragOtherVisualState(enable);
				}
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				if (excludeUids == null || !excludeUids.Contains(dangoBrawlPnlBagItemView.MyUid))
				{
					dangoBrawlPnlBagItemView.SetDragOtherVisualState(enable);
				}
			}
		}

		// Token: 0x060424DB RID: 271579 RVA: 0x01019230 File Offset: 0x01017430
		private void RefreshWeight()
		{
			DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
			int num = (dataController != null) ? dataController.GetDisplayCost() : 0;
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			UUIText text = base.GetText(2);
			if (text != null)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted<int>(num);
				defaultInterpolatedStringHandler.AppendLiteral("/");
				defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
				text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
			}
			bool flag = num > num2;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUIText text2 = base.GetText(2);
			if (text2 == null)
			{
				return;
			}
			text2.SetColor(FColor.FromHex(flag ? "ee4d4d" : "ffffff"));
		}

		// Token: 0x060424DC RID: 271580 RVA: 0x01019304 File Offset: 0x01017504
		private void RefreshUniqueWeapon()
		{
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int id = (selfFighter != null) ? selfFighter.RoleConfigId : 0;
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(id);
			bool flag = roleConfigById != null && roleConfigById.GetValueOrDefault().NoSpeItemLimit;
			UUIItem item2 = base.GetItem(14);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIText text = base.GetText(13);
			if (text != null)
			{
				text.SetUIActive(!flag);
			}
			if (!flag)
			{
				int num = 0;
				DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
				List<DangoBrawlBackpackItemData> list = (bagpackData != null) ? bagpackData.GetItemList() : null;
				if (list != null)
				{
					num += list.Count(delegate(DangoBrawlBackpackItemData item)
					{
						DangoBrawlItem? dangoBrawlItem;
						return DangoBrawlConfig.Instance.GetItemConfigById(item.MyConfigId) != null && dangoBrawlItem.GetValueOrDefault().IsSpeItem;
					});
				}
				DangoBrawlBenchData benchData = this.ActData.BenchData;
				List<DangoBrawlBenchItemData> list2 = (benchData != null) ? benchData.GetItemList() : null;
				if (list2 != null)
				{
					num += list2.Count(delegate(DangoBrawlBenchItemData item)
					{
						DangoBrawlItem? dangoBrawlItem;
						return DangoBrawlConfig.Instance.GetItemConfigById(item.MyConfigId) != null && dangoBrawlItem.GetValueOrDefault().IsSpeItem;
					});
				}
				UUIText text2 = base.GetText(13);
				if (text2 != null)
				{
					UUIText uuitext = text2;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					defaultInterpolatedStringHandler.AppendLiteral("/1");
					uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
				}
				if (text2 != null)
				{
					UUIItem uuiitem = text2;
					bool bUseChangeColor = num >= 1;
					FColor? fcolor = new FColor?(text2.changeColor);
					uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				}
			}
		}

		// Token: 0x060424DD RID: 271581 RVA: 0x01019478 File Offset: 0x01017678
		public void RefreshItemTips(int selectedUid, EDangoBrawlTipsOperationMode operationMode)
		{
			if (selectedUid == -1 || this.ItemTips == null)
			{
				return;
			}
			DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindItemPanel(selectedUid);
			if (dangoBrawlViewItemBase == null)
			{
				return;
			}
			DangoBrawlItemTipsData data = new DangoBrawlItemTipsData
			{
				ItemId = dangoBrawlViewItemBase.MyConfigId,
				ItemUid = new int?(selectedUid),
				From = EDangoBrawlItemTipsFrom.Bag,
				GridItem = dangoBrawlViewItemBase.GetRootItem(),
				GridSize = new float?((float)this.GridSize),
				ChangeY = new float?(this.ItemTipsOffsetY),
				ShowCombine = new bool?(true),
				OperationMode = operationMode
			};
			this.ItemTips.RefreshAndShow(data).Forget();
		}

		// Token: 0x060424DE RID: 271582 RVA: 0x01019518 File Offset: 0x01017718
		[NullableContext(1)]
		private void ReparentBackToContent(DangoBrawlViewItemBase panel)
		{
			UUIItem rootItem = panel.GetRootItem();
			if (rootItem == null || !rootItem.IsValid())
			{
				return;
			}
			UUIItem item = base.GetItem((panel.MyType == EDangoBrawlTemplateType.Bag) ? 3 : 4);
			if (item == null || !item.IsValid())
			{
				return;
			}
			if (rootItem.GetParentAsUIItem() != item)
			{
				DangoBrawlUtil.ReparentMoveKeepWorld(rootItem, item);
			}
		}

		// Token: 0x060424DF RID: 271583 RVA: 0x0101956C File Offset: 0x0101776C
		private DangoBrawlViewItemBase FindItemPanel(int uid)
		{
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels)
			{
				if (dangoBrawlPnlBagView.MyUid == uid)
				{
					return dangoBrawlPnlBagView;
				}
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				if (dangoBrawlPnlBagItemView.MyUid == uid)
				{
					return dangoBrawlPnlBagItemView;
				}
			}
			return null;
		}

		// Token: 0x060424E0 RID: 271584 RVA: 0x01019614 File Offset: 0x01017814
		[NullableContext(1)]
		private UniTask RebuildBagViewAsync(Dictionary<int, DangoBrawlBackpackItemData> newDataMap, HashSet<int> oldUids)
		{
			DangoBrawlPnlBackpack.<RebuildBagViewAsync>d__42 <RebuildBagViewAsync>d__;
			<RebuildBagViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RebuildBagViewAsync>d__.<>4__this = this;
			<RebuildBagViewAsync>d__.newDataMap = newDataMap;
			<RebuildBagViewAsync>d__.oldUids = oldUids;
			<RebuildBagViewAsync>d__.<>1__state = -1;
			<RebuildBagViewAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<RebuildBagViewAsync>d__42>(ref <RebuildBagViewAsync>d__);
			return <RebuildBagViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060424E1 RID: 271585 RVA: 0x01019668 File Offset: 0x01017868
		private int GetSelectedBagUid()
		{
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			DangoBrawlSelection dangoBrawlSelection;
			if (instance == null)
			{
				dangoBrawlSelection = null;
			}
			else
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				dangoBrawlSelection = ((touchController != null) ? touchController.GetContext().GetSelection() : null);
			}
			DangoBrawlSelection dangoBrawlSelection2 = dangoBrawlSelection;
			if (dangoBrawlSelection2 == null || dangoBrawlSelection2.Source != EDragSourceKind.Bag)
			{
				return -1;
			}
			return dangoBrawlSelection2.Id;
		}

		// Token: 0x060424E2 RID: 271586 RVA: 0x010196AC File Offset: 0x010178AC
		public UUIItem GetFirstCombineItemRootItem()
		{
			if (this.CombineItemPanels.Count <= 0)
			{
				return null;
			}
			return this.CombineItemPanels[0].GetRootItem();
		}

		// Token: 0x060424E3 RID: 271587 RVA: 0x010196CF File Offset: 0x010178CF
		public UUIItem GetCombineItemRootItem(int index)
		{
			if (index < 0 || index >= this.CombineItemPanels.Count)
			{
				return null;
			}
			return this.CombineItemPanels[index].GetRootItem();
		}

		// Token: 0x060424E4 RID: 271588 RVA: 0x010196F8 File Offset: 0x010178F8
		public UUIItem GetBagRootItem(int index)
		{
			if (index < 0)
			{
				return null;
			}
			List<DangoBrawlPnlBagView> list = new List<DangoBrawlPnlBagView>(this.BagPanels);
			list.Sort(delegate(DangoBrawlPnlBagView a, DangoBrawlPnlBagView b)
			{
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData = a.MyItemData as DangoBrawlBackpackItemData;
				PanelPos panelPos = (dangoBrawlBackpackItemData != null) ? dangoBrawlBackpackItemData.MyLeftTopPos : default(PanelPos);
				DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = b.MyItemData as DangoBrawlBackpackItemData;
				PanelPos panelPos2 = (dangoBrawlBackpackItemData2 != null) ? dangoBrawlBackpackItemData2.MyLeftTopPos : default(PanelPos);
				if (panelPos.RowIndex != panelPos2.RowIndex)
				{
					return panelPos.RowIndex - panelPos2.RowIndex;
				}
				return panelPos.ColIndex - panelPos2.ColIndex;
			});
			if (index >= list.Count)
			{
				return null;
			}
			return list[index].GetRootItem();
		}

		// Token: 0x060424E5 RID: 271589 RVA: 0x01019754 File Offset: 0x01017954
		public UUIItem GetFirstWeaponWeightRootItem()
		{
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				DangoBrawlItemBase myItemData = dangoBrawlPnlBagItemView.MyItemData;
				if (myItemData != null && myItemData.MyType == EDangoBrawlItemType.Weapon)
				{
					return dangoBrawlPnlBagItemView.GetWeightRootItem();
				}
			}
			return null;
		}

		// Token: 0x060424E6 RID: 271590 RVA: 0x010197C4 File Offset: 0x010179C4
		private UniTask CreateGridPanels()
		{
			DangoBrawlPnlBackpack.<CreateGridPanels>d__48 <CreateGridPanels>d__;
			<CreateGridPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGridPanels>d__.<>4__this = this;
			<CreateGridPanels>d__.<>1__state = -1;
			<CreateGridPanels>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateGridPanels>d__48>(ref <CreateGridPanels>d__);
			return <CreateGridPanels>d__.<>t__builder.Task;
		}

		// Token: 0x060424E7 RID: 271591 RVA: 0x01019808 File Offset: 0x01017A08
		private UniTask CreateBagAndBagItemPanels()
		{
			DangoBrawlPnlBackpack.<CreateBagAndBagItemPanels>d__49 <CreateBagAndBagItemPanels>d__;
			<CreateBagAndBagItemPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagAndBagItemPanels>d__.<>4__this = this;
			<CreateBagAndBagItemPanels>d__.<>1__state = -1;
			<CreateBagAndBagItemPanels>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateBagAndBagItemPanels>d__49>(ref <CreateBagAndBagItemPanels>d__);
			return <CreateBagAndBagItemPanels>d__.<>t__builder.Task;
		}

		// Token: 0x060424E8 RID: 271592 RVA: 0x0101984C File Offset: 0x01017A4C
		[NullableContext(1)]
		private UniTask CreateBagPanel(DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlPnlBackpack.<CreateBagPanel>d__50 <CreateBagPanel>d__;
			<CreateBagPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagPanel>d__.<>4__this = this;
			<CreateBagPanel>d__.itemData = itemData;
			<CreateBagPanel>d__.<>1__state = -1;
			<CreateBagPanel>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateBagPanel>d__50>(ref <CreateBagPanel>d__);
			return <CreateBagPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060424E9 RID: 271593 RVA: 0x01019898 File Offset: 0x01017A98
		[NullableContext(1)]
		private UniTask CreateBagItemPanel(DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlPnlBackpack.<CreateBagItemPanel>d__51 <CreateBagItemPanel>d__;
			<CreateBagItemPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagItemPanel>d__.<>4__this = this;
			<CreateBagItemPanel>d__.itemData = itemData;
			<CreateBagItemPanel>d__.<>1__state = -1;
			<CreateBagItemPanel>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateBagItemPanel>d__51>(ref <CreateBagItemPanel>d__);
			return <CreateBagItemPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060424EA RID: 271594 RVA: 0x010198E4 File Offset: 0x01017AE4
		[NullableContext(1)]
		private UniTask AddItemPanel(DangoBrawlBackpackItemData itemData)
		{
			DangoBrawlPnlBackpack.<AddItemPanel>d__52 <AddItemPanel>d__;
			<AddItemPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AddItemPanel>d__.<>4__this = this;
			<AddItemPanel>d__.itemData = itemData;
			<AddItemPanel>d__.<>1__state = -1;
			<AddItemPanel>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<AddItemPanel>d__52>(ref <AddItemPanel>d__);
			return <AddItemPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060424EB RID: 271595 RVA: 0x0101992F File Offset: 0x01017B2F
		public void RemoveItemPanel(int uid)
		{
			if (this.RemoveFromList<DangoBrawlPnlBagView>(this.BagPanels, uid) || this.RemoveFromList<DangoBrawlPnlBagItemView>(this.BagItemPanels, uid))
			{
				DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
				if (viewRegistry == null)
				{
					return;
				}
				viewRegistry.Unregister(uid);
			}
		}

		// Token: 0x060424EC RID: 271596 RVA: 0x01019960 File Offset: 0x01017B60
		[NullableContext(1)]
		public void CollectPanelUids(List<int> result)
		{
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels)
			{
				result.Add(dangoBrawlPnlBagView.MyUid);
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				result.Add(dangoBrawlPnlBagItemView.MyUid);
			}
		}

		// Token: 0x060424ED RID: 271597 RVA: 0x01019A00 File Offset: 0x01017C00
		[NullableContext(1)]
		private bool RemoveFromList<[Nullable(0)] T>(List<T> list, int uid) where T : DangoBrawlViewItemBase
		{
			int num = list.FindIndex((T p) => p.MyUid == uid);
			if (num < 0)
			{
				return false;
			}
			list[num].Destroy(null);
			list.RemoveAt(num);
			DangoBrawlModel instance = DangoBrawlModel.Instance;
			if (instance != null)
			{
				DangoBrawlTouchController touchController = instance.GetTouchController();
				if (touchController != null)
				{
					touchController.GetContext().ClearSelectionIfMatch(EDragSourceKind.Bag, uid);
				}
			}
			return true;
		}

		// Token: 0x060424EE RID: 271598 RVA: 0x01019A74 File Offset: 0x01017C74
		private UniTask CreateSmallTips()
		{
			DangoBrawlPnlBackpack.<CreateSmallTips>d__56 <CreateSmallTips>d__;
			<CreateSmallTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSmallTips>d__.<>4__this = this;
			<CreateSmallTips>d__.<>1__state = -1;
			<CreateSmallTips>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateSmallTips>d__56>(ref <CreateSmallTips>d__);
			return <CreateSmallTips>d__.<>t__builder.Task;
		}

		// Token: 0x060424EF RID: 271599 RVA: 0x01019AB8 File Offset: 0x01017CB8
		private void ClearSmallTipsHover()
		{
			this.CancelWeightTipsHoverHideTimer();
			this.CancelUniqueWeaponTipsHoverHideTimer();
			this.WeightTipsLocked = false;
			this.UniqueWeaponTipsLocked = false;
			UUIButtonComponent button = base.GetButton(16);
			if (button != null)
			{
				button.OnPointEnterCallBack.Unbind();
			}
			if (button != null)
			{
				button.OnPointExitCallBack.Unbind();
			}
			UUIButtonComponent button2 = base.GetButton(18);
			if (button2 != null)
			{
				button2.OnPointEnterCallBack.Unbind();
			}
			if (button2 != null)
			{
				button2.OnPointExitCallBack.Unbind();
			}
			if (this.WeightDetailTips != null)
			{
				this.WeightDetailTips.OnTipsClosed = null;
			}
			if (this.UniqueWeaponDetailTips != null)
			{
				this.UniqueWeaponDetailTips.OnTipsClosed = null;
			}
		}

		// Token: 0x060424F0 RID: 271600 RVA: 0x01019B59 File Offset: 0x01017D59
		private static bool CanHoverSmallTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x060424F1 RID: 271601 RVA: 0x01019B68 File Offset: 0x01017D68
		private void OnWeightTipsPointEnter()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.WeightTipsLocked)
			{
				return;
			}
			this.CancelWeightTipsHoverHideTimer();
			this.CloseUniqueWeaponSmallTips();
			DangoBrawlSmallTips weightDetailTips = this.WeightDetailTips;
			if (weightDetailTips == null)
			{
				return;
			}
			weightDetailTips.Show(false);
		}

		// Token: 0x060424F2 RID: 271602 RVA: 0x01019B97 File Offset: 0x01017D97
		private void OnWeightTipsPointExit()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.WeightTipsLocked)
			{
				return;
			}
			this.ScheduleWeightTipsHoverHide();
		}

		// Token: 0x060424F3 RID: 271603 RVA: 0x01019BAF File Offset: 0x01017DAF
		private void OnUniqueWeaponTipsPointEnter()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.UniqueWeaponTipsLocked)
			{
				return;
			}
			this.CancelUniqueWeaponTipsHoverHideTimer();
			this.CloseWeightSmallTips();
			DangoBrawlSmallTips uniqueWeaponDetailTips = this.UniqueWeaponDetailTips;
			if (uniqueWeaponDetailTips == null)
			{
				return;
			}
			uniqueWeaponDetailTips.Show(false);
		}

		// Token: 0x060424F4 RID: 271604 RVA: 0x01019BDE File Offset: 0x01017DDE
		private void OnUniqueWeaponTipsPointExit()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.UniqueWeaponTipsLocked)
			{
				return;
			}
			this.ScheduleUniqueWeaponTipsHoverHide();
		}

		// Token: 0x060424F5 RID: 271605 RVA: 0x01019BF6 File Offset: 0x01017DF6
		private void ScheduleWeightTipsHoverHide()
		{
			this.CancelWeightTipsHoverHideTimer();
			this.WeightTipsHoverHideTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.WeightTipsHoverHideTimer = null;
				if (!this.WeightTipsLocked)
				{
					DangoBrawlSmallTips weightDetailTips = this.WeightDetailTips;
					if (weightDetailTips == null)
					{
						return;
					}
					weightDetailTips.Hide();
				}
			}, 50f, null, null, true, 1f);
		}

		// Token: 0x060424F6 RID: 271606 RVA: 0x01019C27 File Offset: 0x01017E27
		private void ScheduleUniqueWeaponTipsHoverHide()
		{
			this.CancelUniqueWeaponTipsHoverHideTimer();
			this.UniqueWeaponTipsHoverHideTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.UniqueWeaponTipsHoverHideTimer = null;
				if (!this.UniqueWeaponTipsLocked)
				{
					DangoBrawlSmallTips uniqueWeaponDetailTips = this.UniqueWeaponDetailTips;
					if (uniqueWeaponDetailTips == null)
					{
						return;
					}
					uniqueWeaponDetailTips.Hide();
				}
			}, 50f, null, null, true, 1f);
		}

		// Token: 0x060424F7 RID: 271607 RVA: 0x01019C58 File Offset: 0x01017E58
		private void CancelWeightTipsHoverHideTimer()
		{
			TimerHandle weightTipsHoverHideTimer = this.WeightTipsHoverHideTimer;
			if (weightTipsHoverHideTimer != null)
			{
				weightTipsHoverHideTimer.Remove();
			}
			this.WeightTipsHoverHideTimer = null;
		}

		// Token: 0x060424F8 RID: 271608 RVA: 0x01019C73 File Offset: 0x01017E73
		private void CancelUniqueWeaponTipsHoverHideTimer()
		{
			TimerHandle uniqueWeaponTipsHoverHideTimer = this.UniqueWeaponTipsHoverHideTimer;
			if (uniqueWeaponTipsHoverHideTimer != null)
			{
				uniqueWeaponTipsHoverHideTimer.Remove();
			}
			this.UniqueWeaponTipsHoverHideTimer = null;
		}

		// Token: 0x060424F9 RID: 271609 RVA: 0x01019C8E File Offset: 0x01017E8E
		private void CloseWeightSmallTips()
		{
			this.CancelWeightTipsHoverHideTimer();
			this.WeightTipsLocked = false;
			DangoBrawlSmallTips weightDetailTips = this.WeightDetailTips;
			if (weightDetailTips != null && weightDetailTips.GetActive())
			{
				this.WeightDetailTips.Hide();
			}
		}

		// Token: 0x060424FA RID: 271610 RVA: 0x01019CBC File Offset: 0x01017EBC
		private void CloseUniqueWeaponSmallTips()
		{
			this.CancelUniqueWeaponTipsHoverHideTimer();
			this.UniqueWeaponTipsLocked = false;
			DangoBrawlSmallTips uniqueWeaponDetailTips = this.UniqueWeaponDetailTips;
			if (uniqueWeaponDetailTips != null && uniqueWeaponDetailTips.GetActive())
			{
				this.UniqueWeaponDetailTips.Hide();
			}
		}

		// Token: 0x060424FB RID: 271611 RVA: 0x01019CEA File Offset: 0x01017EEA
		private void OnWeightTipsClosed()
		{
			this.WeightTipsLocked = false;
			this.CancelWeightTipsHoverHideTimer();
		}

		// Token: 0x060424FC RID: 271612 RVA: 0x01019CF9 File Offset: 0x01017EF9
		private void OnUniqueWeaponTipsClosed()
		{
			this.UniqueWeaponTipsLocked = false;
			this.CancelUniqueWeaponTipsHoverHideTimer();
		}

		// Token: 0x060424FD RID: 271613 RVA: 0x01019D08 File Offset: 0x01017F08
		private void CreateCombineEnsureLineHost()
		{
			this.CombineEnsureLineHost = new DangoBrawlCombineEnsureLineHost(this.ActData, base.GetItem(11), base.GetItem(10), base.GetItem(5), this.GridSize);
		}

		// Token: 0x060424FE RID: 271614 RVA: 0x01019D38 File Offset: 0x01017F38
		private void ClearCombineEnsureLineHost()
		{
			DangoBrawlCombineEnsureLineHost combineEnsureLineHost = this.CombineEnsureLineHost;
			if (combineEnsureLineHost != null)
			{
				combineEnsureLineHost.Destroy();
			}
			this.CombineEnsureLineHost = null;
		}

		// Token: 0x060424FF RID: 271615 RVA: 0x01019D54 File Offset: 0x01017F54
		[NullableContext(1)]
		private UniTask PlayComposeFxAsync(int uid, bool toBench, int mainUid, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			DangoBrawlPnlBackpack.<PlayComposeFxAsync>d__73 <PlayComposeFxAsync>d__;
			<PlayComposeFxAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayComposeFxAsync>d__.<>4__this = this;
			<PlayComposeFxAsync>d__.uid = uid;
			<PlayComposeFxAsync>d__.toBench = toBench;
			<PlayComposeFxAsync>d__.mainUid = mainUid;
			<PlayComposeFxAsync>d__.sourceUids = sourceUids;
			<PlayComposeFxAsync>d__.sourceKinds = sourceKinds;
			<PlayComposeFxAsync>d__.<>1__state = -1;
			<PlayComposeFxAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<PlayComposeFxAsync>d__73>(ref <PlayComposeFxAsync>d__);
			return <PlayComposeFxAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042500 RID: 271616 RVA: 0x01019DC4 File Offset: 0x01017FC4
		[NullableContext(1)]
		private UniTask PlayMainAndRemoveSourcesAsync([Nullable(2)] DangoBrawlPnlBagItemView mainItem, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			DangoBrawlPnlBackpack.<PlayMainAndRemoveSourcesAsync>d__74 <PlayMainAndRemoveSourcesAsync>d__;
			<PlayMainAndRemoveSourcesAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayMainAndRemoveSourcesAsync>d__.<>4__this = this;
			<PlayMainAndRemoveSourcesAsync>d__.mainItem = mainItem;
			<PlayMainAndRemoveSourcesAsync>d__.sourceUids = sourceUids;
			<PlayMainAndRemoveSourcesAsync>d__.sourceKinds = sourceKinds;
			<PlayMainAndRemoveSourcesAsync>d__.<>1__state = -1;
			<PlayMainAndRemoveSourcesAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<PlayMainAndRemoveSourcesAsync>d__74>(ref <PlayMainAndRemoveSourcesAsync>d__);
			return <PlayMainAndRemoveSourcesAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042501 RID: 271617 RVA: 0x01019E20 File Offset: 0x01018020
		private UniTask SpawnNewAndPlayFinishAsync(int uid, bool toBench)
		{
			DangoBrawlPnlBackpack.<SpawnNewAndPlayFinishAsync>d__75 <SpawnNewAndPlayFinishAsync>d__;
			<SpawnNewAndPlayFinishAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SpawnNewAndPlayFinishAsync>d__.<>4__this = this;
			<SpawnNewAndPlayFinishAsync>d__.uid = uid;
			<SpawnNewAndPlayFinishAsync>d__.toBench = toBench;
			<SpawnNewAndPlayFinishAsync>d__.<>1__state = -1;
			<SpawnNewAndPlayFinishAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<SpawnNewAndPlayFinishAsync>d__75>(ref <SpawnNewAndPlayFinishAsync>d__);
			return <SpawnNewAndPlayFinishAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042502 RID: 271618 RVA: 0x01019E73 File Offset: 0x01018073
		private void RequestRefreshCombineList()
		{
			if (this.CombineListRefreshScheduled)
			{
				return;
			}
			this.CombineListRefreshScheduled = true;
			this.FlushRefreshCombineListAsync().Forget();
		}

		// Token: 0x06042503 RID: 271619 RVA: 0x01019E90 File Offset: 0x01018090
		private UniTask FlushRefreshCombineListAsync()
		{
			DangoBrawlPnlBackpack.<FlushRefreshCombineListAsync>d__78 <FlushRefreshCombineListAsync>d__;
			<FlushRefreshCombineListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushRefreshCombineListAsync>d__.<>4__this = this;
			<FlushRefreshCombineListAsync>d__.<>1__state = -1;
			<FlushRefreshCombineListAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<FlushRefreshCombineListAsync>d__78>(ref <FlushRefreshCombineListAsync>d__);
			return <FlushRefreshCombineListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042504 RID: 271620 RVA: 0x01019ED4 File Offset: 0x010180D4
		private UniTask RefreshCombineList()
		{
			DangoBrawlPnlBackpack.<RefreshCombineList>d__79 <RefreshCombineList>d__;
			<RefreshCombineList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCombineList>d__.<>4__this = this;
			<RefreshCombineList>d__.<>1__state = -1;
			<RefreshCombineList>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<RefreshCombineList>d__79>(ref <RefreshCombineList>d__);
			return <RefreshCombineList>d__.<>t__builder.Task;
		}

		// Token: 0x06042505 RID: 271621 RVA: 0x01019F18 File Offset: 0x01018118
		private void ClearCombineList()
		{
			foreach (DangoBrawlCombineItem dangoBrawlCombineItem in this.CombineItemPanels)
			{
				dangoBrawlCombineItem.Destroy(null);
			}
			this.CombineItemPanels.Clear();
		}

		// Token: 0x06042506 RID: 271622 RVA: 0x01019F74 File Offset: 0x01018174
		private void MarkStarActive(int uid)
		{
			if (uid <= 0)
			{
				return;
			}
			this.PendingStarActiveUids.Add(uid);
			this.FlushStarActiveAsync().Forget();
		}

		// Token: 0x06042507 RID: 271623 RVA: 0x01019F94 File Offset: 0x01018194
		private UniTask FlushStarActiveAsync()
		{
			DangoBrawlPnlBackpack.<FlushStarActiveAsync>d__84 <FlushStarActiveAsync>d__;
			<FlushStarActiveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushStarActiveAsync>d__.<>4__this = this;
			<FlushStarActiveAsync>d__.<>1__state = -1;
			<FlushStarActiveAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<FlushStarActiveAsync>d__84>(ref <FlushStarActiveAsync>d__);
			return <FlushStarActiveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042508 RID: 271624 RVA: 0x01019FD7 File Offset: 0x010181D7
		private void OnCostChanged()
		{
			this.RefreshWeight();
		}

		// Token: 0x06042509 RID: 271625 RVA: 0x01019FDF File Offset: 0x010181DF
		private void OnClickWeightDetail()
		{
			this.CancelWeightTipsHoverHideTimer();
			if (this.WeightTipsLocked)
			{
				this.CloseWeightSmallTips();
				return;
			}
			this.CloseUniqueWeaponSmallTips();
			this.WeightTipsLocked = true;
			DangoBrawlSmallTips weightDetailTips = this.WeightDetailTips;
			if (weightDetailTips == null)
			{
				return;
			}
			weightDetailTips.Show(true);
		}

		// Token: 0x0604250A RID: 271626 RVA: 0x0101A014 File Offset: 0x01018214
		private void OnClickUniqueWeaponDetail()
		{
			this.CancelUniqueWeaponTipsHoverHideTimer();
			if (this.UniqueWeaponTipsLocked)
			{
				this.CloseUniqueWeaponSmallTips();
				return;
			}
			this.CloseWeightSmallTips();
			this.UniqueWeaponTipsLocked = true;
			DangoBrawlSmallTips uniqueWeaponDetailTips = this.UniqueWeaponDetailTips;
			if (uniqueWeaponDetailTips == null)
			{
				return;
			}
			uniqueWeaponDetailTips.Show(true);
		}

		// Token: 0x0604250B RID: 271627 RVA: 0x0101A049 File Offset: 0x01018249
		private void OnInteractionStateChanged(EInteractionState state)
		{
			if (state == EInteractionState.Sticky)
			{
				this.SlotBgColorMaskReason |= DangoBrawlPnlBackpack.ESlotBgColorReason.Sticky;
			}
			else
			{
				this.SlotBgColorMaskReason &= ~DangoBrawlPnlBackpack.ESlotBgColorReason.Sticky;
			}
			this.RefreshSlotBgColor();
		}

		// Token: 0x0604250C RID: 271628 RVA: 0x0101A074 File Offset: 0x01018274
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			if (DangoBrawlConfig.Instance.GetItemConfigTypeById(configId) == EDangoBrawlItemType.Bag)
			{
				this.SlotBgColorMaskReason |= DangoBrawlPnlBackpack.ESlotBgColorReason.Dragging;
			}
			this.RefreshSlotBgColor();
		}

		// Token: 0x0604250D RID: 271629 RVA: 0x0101A09A File Offset: 0x0101829A
		private void OnDragEndAnyWay()
		{
			this.SlotBgColorMaskReason &= ~DangoBrawlPnlBackpack.ESlotBgColorReason.Dragging;
			this.RefreshSlotBgColor();
		}

		// Token: 0x0604250E RID: 271630 RVA: 0x0101A0B1 File Offset: 0x010182B1
		private void OnLayerModeChanged(bool isLayerMode)
		{
			if (isLayerMode)
			{
				this.SlotBgColorMaskReason |= DangoBrawlPnlBackpack.ESlotBgColorReason.LayerMode;
			}
			else
			{
				this.SlotBgColorMaskReason &= ~DangoBrawlPnlBackpack.ESlotBgColorReason.LayerMode;
			}
			this.RefreshSlotBgColor();
		}

		// Token: 0x0604250F RID: 271631 RVA: 0x0101A0DC File Offset: 0x010182DC
		private void RefreshSlotBgColor()
		{
			UUISprite sprite = base.GetSprite(20);
			if (sprite != null)
			{
				UUIItem uuiitem = sprite;
				bool bUseChangeColor = this.SlotBgColorMaskReason > DangoBrawlPnlBackpack.ESlotBgColorReason.None;
				FColor? fcolor = new FColor?(sprite.changeColor);
				uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			}
		}

		// Token: 0x06042510 RID: 271632 RVA: 0x0101A114 File Offset: 0x01018314
		private void OnSelectionChanged()
		{
			int selectedBagUid = this.GetSelectedBagUid();
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels)
			{
				dangoBrawlPnlBagView.SetSelectedVisualState(dangoBrawlPnlBagView.MyUid == selectedBagUid);
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				dangoBrawlPnlBagItemView.SetSelectedVisualState(dangoBrawlPnlBagItemView.MyUid == selectedBagUid);
			}
		}

		// Token: 0x06042511 RID: 271633 RVA: 0x0101A1BC File Offset: 0x010183BC
		private void OnShopSold(int uid)
		{
			this.RemoveItemPanel(uid);
			this.RefreshUniqueWeapon();
		}

		// Token: 0x06042512 RID: 271634 RVA: 0x0101A1CB File Offset: 0x010183CB
		[NullableContext(1)]
		private void OnDangoBrawlShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.PlayComposeFxAsync(uid, toBench, mainUid, sourceUids, sourceKinds).Forget();
		}

		// Token: 0x06042513 RID: 271635 RVA: 0x0101A1E0 File Offset: 0x010183E0
		private void OnBagOperated(EBagOpKind kind, int uid)
		{
			if (kind == EBagOpKind.BagToBag)
			{
				DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindItemPanel(uid);
				if (dangoBrawlViewItemBase != null)
				{
					this.ReparentBackToContent(dangoBrawlViewItemBase);
					dangoBrawlViewItemBase.RefreshView();
				}
				else
				{
					this.FallbackAddItemPanel(uid, true);
				}
			}
			this.RefreshUniqueWeapon();
			this.MarkStarActive(uid);
		}

		// Token: 0x06042514 RID: 271636 RVA: 0x0101A220 File Offset: 0x01018420
		private void OnBagUpdated()
		{
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			Dictionary<int, DangoBrawlBackpackItemData> dictionary;
			if (bagpackData == null)
			{
				dictionary = null;
			}
			else
			{
				dictionary = bagpackData.GetItemList().ToDictionary((DangoBrawlBackpackItemData d) => d.MyUid);
			}
			Dictionary<int, DangoBrawlBackpackItemData> dictionary2 = dictionary ?? new Dictionary<int, DangoBrawlBackpackItemData>();
			HashSet<int> hashSet = new HashSet<int>();
			foreach (DangoBrawlPnlBagView dangoBrawlPnlBagView in this.BagPanels)
			{
				hashSet.Add(dangoBrawlPnlBagView.MyUid);
			}
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				hashSet.Add(dangoBrawlPnlBagItemView.MyUid);
			}
			foreach (int num in hashSet)
			{
				if (!dictionary2.ContainsKey(num))
				{
					this.RemoveItemPanel(num);
				}
			}
			foreach (KeyValuePair<int, DangoBrawlBackpackItemData> keyValuePair in dictionary2)
			{
				if (hashSet.Contains(keyValuePair.Key))
				{
					DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindItemPanel(keyValuePair.Key);
					if (dangoBrawlViewItemBase != null)
					{
						DangoBrawlBackpackItemData dangoBrawlBackpackItemData = dangoBrawlViewItemBase.MyItemData as DangoBrawlBackpackItemData;
						bool flag = dangoBrawlBackpackItemData == null || dangoBrawlBackpackItemData.MyLeftTopPos.RowIndex != keyValuePair.Value.MyLeftTopPos.RowIndex || dangoBrawlBackpackItemData.MyLeftTopPos.ColIndex != keyValuePair.Value.MyLeftTopPos.ColIndex || dangoBrawlBackpackItemData.MyRotation != keyValuePair.Value.MyRotation || dangoBrawlBackpackItemData.MyConfigId != keyValuePair.Value.MyConfigId;
						dangoBrawlViewItemBase.BindData(this.ActData, keyValuePair.Value, this.GridSize);
						if (flag)
						{
							dangoBrawlViewItemBase.RefreshView();
						}
					}
				}
			}
			this.RebuildBagViewAsync(dictionary2, hashSet).Forget();
		}

		// Token: 0x06042515 RID: 271637 RVA: 0x0101A470 File Offset: 0x01018670
		private void OnDangoBrawlBackpackModified(EDangoBrawlModifyType type, int uid)
		{
			if (type == EDangoBrawlModifyType.Add || type == EDangoBrawlModifyType.Modify)
			{
				this.MarkStarActive(uid);
			}
			if (type != EDangoBrawlModifyType.Modify)
			{
				this.RequestRefreshCombineList();
				this.RefreshBagItemGuideLines();
			}
		}

		// Token: 0x06042516 RID: 271638 RVA: 0x0101A490 File Offset: 0x01018690
		private void OnDangoBrawlBenchModified(EDangoBrawlModifyType type, int uid)
		{
			if (type != EDangoBrawlModifyType.Modify)
			{
				this.RequestRefreshCombineList();
				this.RefreshBagItemGuideLines();
			}
		}

		// Token: 0x06042517 RID: 271639 RVA: 0x0101A4A4 File Offset: 0x010186A4
		private void RefreshBagItemGuideLines()
		{
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				dangoBrawlPnlBagItemView.RebuildCombineGuideLinesIfShowing();
			}
		}

		// Token: 0x06042518 RID: 271640 RVA: 0x0101A4F4 File Offset: 0x010186F4
		public UUIItem GetGridContainer()
		{
			return base.GetItem(5);
		}

		// Token: 0x06042519 RID: 271641 RVA: 0x0101A500 File Offset: 0x01018700
		[NullableContext(1)]
		public void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState state)
		{
			EDangoBrawlGridState[] array = new EDangoBrawlGridState[positions.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = state;
			}
			this.HighlightGrids(positions, array);
		}

		// Token: 0x0604251A RID: 271642 RVA: 0x0101A530 File Offset: 0x01018730
		[NullableContext(1)]
		public void HighlightGrids(PanelPos[] positions, EDangoBrawlGridState[] states)
		{
			List<DangoBrawlPnlBackpackGrid> list = new List<DangoBrawlPnlBackpackGrid>();
			List<EDangoBrawlGridState> list2 = new List<EDangoBrawlGridState>();
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			PanelPos[][] array = (bagpackData != null) ? bagpackData.GetPanelPosDoublyList() : null;
			for (int i = 0; i < positions.Length; i++)
			{
				PanelPos panelPos = positions[i];
				if (array != null && panelPos.RowIndex >= 0 && panelPos.RowIndex < array.Length)
				{
					PanelPos[] array2 = array[panelPos.RowIndex];
					if (panelPos.ColIndex >= 0 && panelPos.ColIndex < array2.Length)
					{
						PanelPos key = array2[panelPos.ColIndex];
						DangoBrawlPnlBackpackGrid item;
						if (this.GridPanels.TryGetValue(key, out item))
						{
							list.Add(item);
							list2.Add((i < states.Length) ? states[i] : EDangoBrawlGridState.Default);
						}
					}
				}
			}
			foreach (DangoBrawlPnlBackpackGrid dangoBrawlPnlBackpackGrid in this.HighlightedGrids)
			{
				if (!list.Contains(dangoBrawlPnlBackpackGrid))
				{
					dangoBrawlPnlBackpackGrid.SetGridState(EDangoBrawlGridState.Default);
				}
			}
			for (int j = 0; j < list.Count; j++)
			{
				list[j].SetGridState(list2[j]);
			}
			this.HighlightedGrids.Clear();
			this.HighlightedGrids.AddRange(list);
		}

		// Token: 0x0604251B RID: 271643 RVA: 0x0101A688 File Offset: 0x01018888
		public void ClearHighlight()
		{
			foreach (DangoBrawlPnlBackpackGrid dangoBrawlPnlBackpackGrid in this.HighlightedGrids)
			{
				dangoBrawlPnlBackpackGrid.SetGridState(EDangoBrawlGridState.Default);
			}
			this.HighlightedGrids.Clear();
		}

		// Token: 0x0604251C RID: 271644 RVA: 0x0101A6E4 File Offset: 0x010188E4
		public DangoBrawlViewItemBase DetachPanel(int uid)
		{
			DangoBrawlViewItemBase dangoBrawlViewItemBase = null;
			int num = this.BagPanels.FindIndex((DangoBrawlPnlBagView p) => p.MyUid == uid);
			int num2 = this.BagItemPanels.FindIndex((DangoBrawlPnlBagItemView p) => p.MyUid == uid);
			if (num >= 0)
			{
				dangoBrawlViewItemBase = this.BagPanels[num];
				this.BagPanels.RemoveAt(num);
			}
			else if (num2 >= 0)
			{
				dangoBrawlViewItemBase = this.BagItemPanels[num2];
				this.BagItemPanels.RemoveAt(num2);
			}
			if (dangoBrawlViewItemBase == null)
			{
				return null;
			}
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.Unregister(uid);
			}
			DangoBrawlTouchController touch = this.Touch;
			if (touch != null)
			{
				touch.GetContext().ClearSelectionIfMatch(EDragSourceKind.Bag, uid);
			}
			return dangoBrawlViewItemBase;
		}

		// Token: 0x0604251D RID: 271645 RVA: 0x0101A7A8 File Offset: 0x010189A8
		[NullableContext(1)]
		public void AcceptPanel(DangoBrawlViewItemBase panel, DangoBrawlItemBase itemData, bool playEnterSeq = true)
		{
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = itemData as DangoBrawlBackpackItemData;
			if (dangoBrawlBackpackItemData == null)
			{
				return;
			}
			UUIItem item = base.GetItem((dangoBrawlBackpackItemData.MyTemplateType == EDangoBrawlTemplateType.Bag) ? 3 : 4);
			if (item == null)
			{
				return;
			}
			panel.Migrate(item, EDragSourceKind.Bag, dangoBrawlBackpackItemData, this.GridSize);
			DangoBrawlPnlBagView dangoBrawlPnlBagView = panel as DangoBrawlPnlBagView;
			if (dangoBrawlPnlBagView == null)
			{
				DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView = panel as DangoBrawlPnlBagItemView;
				if (dangoBrawlPnlBagItemView != null)
				{
					this.BagItemPanels.Add(dangoBrawlPnlBagItemView);
				}
			}
			else
			{
				this.BagPanels.Add(dangoBrawlPnlBagView);
			}
			DangoBrawlItemViewRegistry viewRegistry = this.ViewRegistry;
			if (viewRegistry != null)
			{
				viewRegistry.Register(dangoBrawlBackpackItemData.MyUid, panel);
			}
			ICombineLineOwner combineLineOwner = panel as ICombineLineOwner;
			if (combineLineOwner != null)
			{
				DangoBrawlItemViewRegistry viewRegistry2 = this.ViewRegistry;
				if (viewRegistry2 == null)
				{
					return;
				}
				viewRegistry2.RegisterLineOwner(dangoBrawlBackpackItemData.MyUid, combineLineOwner);
			}
		}

		// Token: 0x0604251E RID: 271646 RVA: 0x0101A854 File Offset: 0x01018A54
		public bool TryRefreshPanel(int uid)
		{
			DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindItemPanel(uid);
			if (dangoBrawlViewItemBase == null)
			{
				return false;
			}
			this.ReparentBackToContent(dangoBrawlViewItemBase);
			dangoBrawlViewItemBase.RefreshView();
			return true;
		}

		// Token: 0x0604251F RID: 271647 RVA: 0x0101A87C File Offset: 0x01018A7C
		public void FallbackAddItemPanel(int uid, bool playEnterSeq = true)
		{
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(uid) : null;
			if (dangoBrawlBackpackItemData != null)
			{
				this.AddItemPanel(dangoBrawlBackpackItemData).Forget();
			}
		}

		// Token: 0x04022970 RID: 141680
		[Nullable(1)]
		public ActivityDangoBrawlData ActData;

		// Token: 0x04022971 RID: 141681
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBagView> BagPanels = new List<DangoBrawlPnlBagView>();

		// Token: 0x04022972 RID: 141682
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBagItemView> BagItemPanels = new List<DangoBrawlPnlBagItemView>();

		// Token: 0x04022973 RID: 141683
		[Nullable(1)]
		private readonly List<DangoBrawlCombineItem> CombineItemPanels = new List<DangoBrawlCombineItem>();

		// Token: 0x04022974 RID: 141684
		[Nullable(1)]
		private readonly Dictionary<PanelPos, DangoBrawlPnlBackpackGrid> GridPanels = new Dictionary<PanelPos, DangoBrawlPnlBackpackGrid>();

		// Token: 0x04022975 RID: 141685
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBackpackGrid> HighlightedGrids = new List<DangoBrawlPnlBackpackGrid>();

		// Token: 0x04022976 RID: 141686
		private int GridSize;

		// Token: 0x04022977 RID: 141687
		private float ItemTipsOffsetY;

		// Token: 0x04022978 RID: 141688
		private DangoBrawlPnlBackpack.ESlotBgColorReason SlotBgColorMaskReason;

		// Token: 0x04022979 RID: 141689
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0402297A RID: 141690
		private DangoBrawlSmallTips WeightDetailTips;

		// Token: 0x0402297B RID: 141691
		private DangoBrawlSmallTips UniqueWeaponDetailTips;

		// Token: 0x0402297C RID: 141692
		private bool WeightTipsLocked;

		// Token: 0x0402297D RID: 141693
		private bool UniqueWeaponTipsLocked;

		// Token: 0x0402297E RID: 141694
		private TimerHandle WeightTipsHoverHideTimer;

		// Token: 0x0402297F RID: 141695
		private TimerHandle UniqueWeaponTipsHoverHideTimer;

		// Token: 0x04022980 RID: 141696
		private DangoBrawlCombineEnsureLineHost CombineEnsureLineHost;

		// Token: 0x04022981 RID: 141697
		private UUIItem BagTemplate;

		// Token: 0x04022982 RID: 141698
		private UUIItem BagItemTemplate;

		// Token: 0x04022983 RID: 141699
		private bool CombineListRefreshScheduled;

		// Token: 0x04022984 RID: 141700
		[Nullable(1)]
		private readonly HashSet<int> PendingStarActiveUids = new HashSet<int>();

		// Token: 0x04022985 RID: 141701
		private bool StarActiveFlushScheduled;

		// Token: 0x0200C932 RID: 51506
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x0403CBDE RID: 248798
			PnlWeightRed,
			// Token: 0x0403CBDF RID: 248799
			PnlWeightBlue,
			// Token: 0x0403CBE0 RID: 248800
			TxtWeight,
			// Token: 0x0403CBE1 RID: 248801
			ContentBag,
			// Token: 0x0403CBE2 RID: 248802
			ContentBagItem,
			// Token: 0x0403CBE3 RID: 248803
			ContentGrid,
			// Token: 0x0403CBE4 RID: 248804
			ItemGrid,
			// Token: 0x0403CBE5 RID: 248805
			PnlCombine,
			// Token: 0x0403CBE6 RID: 248806
			ContentCombine,
			// Token: 0x0403CBE7 RID: 248807
			TemplateCombine,
			// Token: 0x0403CBE8 RID: 248808
			ContentCombineLine,
			// Token: 0x0403CBE9 RID: 248809
			TemplateCombineLine,
			// Token: 0x0403CBEA RID: 248810
			PnlUniqueWeapon,
			// Token: 0x0403CBEB RID: 248811
			TxtUniqueWeapon,
			// Token: 0x0403CBEC RID: 248812
			SprUniqueWeapon,
			// Token: 0x0403CBED RID: 248813
			ItemDetailTips,
			// Token: 0x0403CBEE RID: 248814
			BtnWeightDetail,
			// Token: 0x0403CBEF RID: 248815
			WeightDetailTips,
			// Token: 0x0403CBF0 RID: 248816
			BtnUniqueWeaponDetail,
			// Token: 0x0403CBF1 RID: 248817
			UniqueWeaponDetailTips,
			// Token: 0x0403CBF2 RID: 248818
			SprSlotBg
		}

		// Token: 0x0200C933 RID: 51507
		[NullableContext(0)]
		[Flags]
		private enum ESlotBgColorReason
		{
			// Token: 0x0403CBF4 RID: 248820
			None = 0,
			// Token: 0x0403CBF5 RID: 248821
			Dragging = 1,
			// Token: 0x0403CBF6 RID: 248822
			Sticky = 2,
			// Token: 0x0403CBF7 RID: 248823
			LayerMode = 4
		}
	}
}
