using System;
using System.Collections.Generic;
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
	// Token: 0x02005741 RID: 22337
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoBrawlPnlBackpack : UiPanelBase, IDangoBrawlBagDropZoneExtra, IDangoBrawlItemZone
	{
		// Token: 0x17006A48 RID: 27208
		// (get) Token: 0x06037023 RID: 225315 RVA: 0x00F5A0A2 File Offset: 0x00F582A2
		private DangoBrawlTouchController Touch
		{
			get
			{
				return DangoBrawlModel.Instance.GetTouchController();
			}
		}

		// Token: 0x17006A49 RID: 27209
		// (get) Token: 0x06037024 RID: 225316 RVA: 0x00F5A0AE File Offset: 0x00F582AE
		private DangoBrawlItemViewRegistry ViewRegistry
		{
			get
			{
				return DangoBrawlModel.Instance.GetViewRegistry();
			}
		}

		// Token: 0x06037025 RID: 225317 RVA: 0x00F5A0BC File Offset: 0x00F582BC
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

		// Token: 0x06037026 RID: 225318 RVA: 0x00F5A3E8 File Offset: 0x00F585E8
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlPnlBackpack.<OnBeforeStartAsync>d__26 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<OnBeforeStartAsync>d__26>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037027 RID: 225319 RVA: 0x00F5A42C File Offset: 0x00F5862C
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

		// Token: 0x17006A4A RID: 27210
		// (get) Token: 0x06037028 RID: 225320 RVA: 0x00F5A5BD File Offset: 0x00F587BD
		public UUIItem HitItem
		{
			get
			{
				return base.GetItem(5);
			}
		}

		// Token: 0x06037029 RID: 225321 RVA: 0x00F5A5C6 File Offset: 0x00F587C6
		public void SetBagTemplate(UUIItem template)
		{
			this.BagTemplate = template;
		}

		// Token: 0x0603702A RID: 225322 RVA: 0x00F5A5CF File Offset: 0x00F587CF
		public void SetBagItemTemplate(UUIItem template)
		{
			this.BagItemTemplate = template;
		}

		// Token: 0x0603702B RID: 225323 RVA: 0x00F5A5D8 File Offset: 0x00F587D8
		public void SetItemTips(DangoBrawlItemTipsBase tips)
		{
			this.ItemTips = tips;
		}

		// Token: 0x0603702C RID: 225324 RVA: 0x00F5A5E1 File Offset: 0x00F587E1
		public void SetOffsetY(float offsetY)
		{
			this.ItemTipsOffsetY = offsetY;
		}

		// Token: 0x0603702D RID: 225325 RVA: 0x00F5A5EA File Offset: 0x00F587EA
		public void SetGridSize(int size)
		{
			this.GridSize = size;
		}

		// Token: 0x0603702E RID: 225326 RVA: 0x00F5A5F3 File Offset: 0x00F587F3
		public void SetCombineActive(bool active)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(active);
		}

		// Token: 0x0603702F RID: 225327 RVA: 0x00F5A608 File Offset: 0x00F58808
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

		// Token: 0x06037030 RID: 225328 RVA: 0x00F5A6C0 File Offset: 0x00F588C0
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

		// Token: 0x06037031 RID: 225329 RVA: 0x00F5A794 File Offset: 0x00F58994
		private void RefreshUniqueWeapon()
		{
			DangoBrawlFighterServerData selfFighter = this.ActData.FightersServerData.GetSelfFighter();
			int id = (selfFighter != null) ? selfFighter.RoleConfigId : 0;
			DangoBrawlRole? roleConfigById = DangoBrawlConfig.Instance.GetRoleConfigById(id);
			bool flag = roleConfigById != null && roleConfigById.GetValueOrDefault().NoSpeItemLimit;
			UUIItem item = base.GetItem(14);
			if (item != null)
			{
				item.SetUIActive(flag);
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
					foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in list)
					{
						DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(dangoBrawlBackpackItemData.MyConfigId);
						if (itemConfigById != null && itemConfigById.GetValueOrDefault().IsSpeItem)
						{
							num++;
						}
					}
				}
				DangoBrawlBenchData benchData = this.ActData.BenchData;
				List<DangoBrawlBenchItemData> list2 = (benchData != null) ? benchData.GetItemList() : null;
				if (list2 != null)
				{
					foreach (DangoBrawlBenchItemData dangoBrawlBenchItemData in list2)
					{
						DangoBrawlItem? itemConfigById = DangoBrawlConfig.Instance.GetItemConfigById(dangoBrawlBenchItemData.MyConfigId);
						if (itemConfigById != null && itemConfigById.GetValueOrDefault().IsSpeItem)
						{
							num++;
						}
					}
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

		// Token: 0x06037032 RID: 225330 RVA: 0x00F5A998 File Offset: 0x00F58B98
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

		// Token: 0x06037033 RID: 225331 RVA: 0x00F5AA38 File Offset: 0x00F58C38
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

		// Token: 0x06037034 RID: 225332 RVA: 0x00F5AA8C File Offset: 0x00F58C8C
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

		// Token: 0x06037035 RID: 225333 RVA: 0x00F5AB34 File Offset: 0x00F58D34
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

		// Token: 0x06037036 RID: 225334 RVA: 0x00F5AB88 File Offset: 0x00F58D88
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

		// Token: 0x06037037 RID: 225335 RVA: 0x00F5ABCC File Offset: 0x00F58DCC
		public UUIItem GetFirstCombineItemRootItem()
		{
			if (this.CombineItemPanels.Count <= 0)
			{
				return null;
			}
			return this.CombineItemPanels[0].GetRootItem();
		}

		// Token: 0x06037038 RID: 225336 RVA: 0x00F5ABEF File Offset: 0x00F58DEF
		public UUIItem GetCombineItemRootItem(int index)
		{
			if (index < 0 || index >= this.CombineItemPanels.Count)
			{
				return null;
			}
			return this.CombineItemPanels[index].GetRootItem();
		}

		// Token: 0x06037039 RID: 225337 RVA: 0x00F5AC18 File Offset: 0x00F58E18
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

		// Token: 0x0603703A RID: 225338 RVA: 0x00F5AC74 File Offset: 0x00F58E74
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

		// Token: 0x0603703B RID: 225339 RVA: 0x00F5ACE4 File Offset: 0x00F58EE4
		private UniTask CreateGridPanels()
		{
			DangoBrawlPnlBackpack.<CreateGridPanels>d__48 <CreateGridPanels>d__;
			<CreateGridPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateGridPanels>d__.<>4__this = this;
			<CreateGridPanels>d__.<>1__state = -1;
			<CreateGridPanels>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateGridPanels>d__48>(ref <CreateGridPanels>d__);
			return <CreateGridPanels>d__.<>t__builder.Task;
		}

		// Token: 0x0603703C RID: 225340 RVA: 0x00F5AD28 File Offset: 0x00F58F28
		private UniTask CreateBagAndBagItemPanels()
		{
			DangoBrawlPnlBackpack.<CreateBagAndBagItemPanels>d__49 <CreateBagAndBagItemPanels>d__;
			<CreateBagAndBagItemPanels>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBagAndBagItemPanels>d__.<>4__this = this;
			<CreateBagAndBagItemPanels>d__.<>1__state = -1;
			<CreateBagAndBagItemPanels>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateBagAndBagItemPanels>d__49>(ref <CreateBagAndBagItemPanels>d__);
			return <CreateBagAndBagItemPanels>d__.<>t__builder.Task;
		}

		// Token: 0x0603703D RID: 225341 RVA: 0x00F5AD6C File Offset: 0x00F58F6C
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

		// Token: 0x0603703E RID: 225342 RVA: 0x00F5ADB8 File Offset: 0x00F58FB8
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

		// Token: 0x0603703F RID: 225343 RVA: 0x00F5AE04 File Offset: 0x00F59004
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

		// Token: 0x06037040 RID: 225344 RVA: 0x00F5AE4F File Offset: 0x00F5904F
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

		// Token: 0x06037041 RID: 225345 RVA: 0x00F5AE80 File Offset: 0x00F59080
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

		// Token: 0x06037042 RID: 225346 RVA: 0x00F5AF20 File Offset: 0x00F59120
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

		// Token: 0x06037043 RID: 225347 RVA: 0x00F5AF94 File Offset: 0x00F59194
		private UniTask CreateSmallTips()
		{
			DangoBrawlPnlBackpack.<CreateSmallTips>d__56 <CreateSmallTips>d__;
			<CreateSmallTips>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateSmallTips>d__.<>4__this = this;
			<CreateSmallTips>d__.<>1__state = -1;
			<CreateSmallTips>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<CreateSmallTips>d__56>(ref <CreateSmallTips>d__);
			return <CreateSmallTips>d__.<>t__builder.Task;
		}

		// Token: 0x06037044 RID: 225348 RVA: 0x00F5AFD8 File Offset: 0x00F591D8
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

		// Token: 0x06037045 RID: 225349 RVA: 0x00F5B079 File Offset: 0x00F59279
		private static bool CanHoverSmallTips()
		{
			return !Info.Instance.IsMobileInputModel();
		}

		// Token: 0x06037046 RID: 225350 RVA: 0x00F5B088 File Offset: 0x00F59288
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

		// Token: 0x06037047 RID: 225351 RVA: 0x00F5B0B7 File Offset: 0x00F592B7
		private void OnWeightTipsPointExit()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.WeightTipsLocked)
			{
				return;
			}
			this.ScheduleWeightTipsHoverHide();
		}

		// Token: 0x06037048 RID: 225352 RVA: 0x00F5B0CF File Offset: 0x00F592CF
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

		// Token: 0x06037049 RID: 225353 RVA: 0x00F5B0FE File Offset: 0x00F592FE
		private void OnUniqueWeaponTipsPointExit()
		{
			if (!DangoBrawlPnlBackpack.CanHoverSmallTips() || this.UniqueWeaponTipsLocked)
			{
				return;
			}
			this.ScheduleUniqueWeaponTipsHoverHide();
		}

		// Token: 0x0603704A RID: 225354 RVA: 0x00F5B116 File Offset: 0x00F59316
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

		// Token: 0x0603704B RID: 225355 RVA: 0x00F5B147 File Offset: 0x00F59347
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

		// Token: 0x0603704C RID: 225356 RVA: 0x00F5B178 File Offset: 0x00F59378
		private void CancelWeightTipsHoverHideTimer()
		{
			TimerHandle weightTipsHoverHideTimer = this.WeightTipsHoverHideTimer;
			if (weightTipsHoverHideTimer != null)
			{
				weightTipsHoverHideTimer.Remove();
			}
			this.WeightTipsHoverHideTimer = null;
		}

		// Token: 0x0603704D RID: 225357 RVA: 0x00F5B193 File Offset: 0x00F59393
		private void CancelUniqueWeaponTipsHoverHideTimer()
		{
			TimerHandle uniqueWeaponTipsHoverHideTimer = this.UniqueWeaponTipsHoverHideTimer;
			if (uniqueWeaponTipsHoverHideTimer != null)
			{
				uniqueWeaponTipsHoverHideTimer.Remove();
			}
			this.UniqueWeaponTipsHoverHideTimer = null;
		}

		// Token: 0x0603704E RID: 225358 RVA: 0x00F5B1AE File Offset: 0x00F593AE
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

		// Token: 0x0603704F RID: 225359 RVA: 0x00F5B1DC File Offset: 0x00F593DC
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

		// Token: 0x06037050 RID: 225360 RVA: 0x00F5B20A File Offset: 0x00F5940A
		private void OnWeightTipsClosed()
		{
			this.WeightTipsLocked = false;
			this.CancelWeightTipsHoverHideTimer();
		}

		// Token: 0x06037051 RID: 225361 RVA: 0x00F5B219 File Offset: 0x00F59419
		private void OnUniqueWeaponTipsClosed()
		{
			this.UniqueWeaponTipsLocked = false;
			this.CancelUniqueWeaponTipsHoverHideTimer();
		}

		// Token: 0x06037052 RID: 225362 RVA: 0x00F5B228 File Offset: 0x00F59428
		private void CreateCombineEnsureLineHost()
		{
			this.CombineEnsureLineHost = new DangoBrawlCombineEnsureLineHost(this.ActData, base.GetItem(11), base.GetItem(10), base.GetItem(5), this.GridSize);
		}

		// Token: 0x06037053 RID: 225363 RVA: 0x00F5B258 File Offset: 0x00F59458
		private void ClearCombineEnsureLineHost()
		{
			DangoBrawlCombineEnsureLineHost combineEnsureLineHost = this.CombineEnsureLineHost;
			if (combineEnsureLineHost != null)
			{
				combineEnsureLineHost.Destroy();
			}
			this.CombineEnsureLineHost = null;
		}

		// Token: 0x06037054 RID: 225364 RVA: 0x00F5B274 File Offset: 0x00F59474
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

		// Token: 0x06037055 RID: 225365 RVA: 0x00F5B2E4 File Offset: 0x00F594E4
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

		// Token: 0x06037056 RID: 225366 RVA: 0x00F5B340 File Offset: 0x00F59540
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

		// Token: 0x06037057 RID: 225367 RVA: 0x00F5B393 File Offset: 0x00F59593
		private void RequestRefreshCombineList()
		{
			if (this.CombineListRefreshScheduled)
			{
				return;
			}
			this.CombineListRefreshScheduled = true;
			this.FlushRefreshCombineListAsync().Forget();
		}

		// Token: 0x06037058 RID: 225368 RVA: 0x00F5B3B0 File Offset: 0x00F595B0
		private UniTask FlushRefreshCombineListAsync()
		{
			DangoBrawlPnlBackpack.<FlushRefreshCombineListAsync>d__78 <FlushRefreshCombineListAsync>d__;
			<FlushRefreshCombineListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushRefreshCombineListAsync>d__.<>4__this = this;
			<FlushRefreshCombineListAsync>d__.<>1__state = -1;
			<FlushRefreshCombineListAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<FlushRefreshCombineListAsync>d__78>(ref <FlushRefreshCombineListAsync>d__);
			return <FlushRefreshCombineListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037059 RID: 225369 RVA: 0x00F5B3F4 File Offset: 0x00F595F4
		private UniTask RefreshCombineList()
		{
			DangoBrawlPnlBackpack.<RefreshCombineList>d__79 <RefreshCombineList>d__;
			<RefreshCombineList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshCombineList>d__.<>4__this = this;
			<RefreshCombineList>d__.<>1__state = -1;
			<RefreshCombineList>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<RefreshCombineList>d__79>(ref <RefreshCombineList>d__);
			return <RefreshCombineList>d__.<>t__builder.Task;
		}

		// Token: 0x0603705A RID: 225370 RVA: 0x00F5B438 File Offset: 0x00F59638
		private void ClearCombineList()
		{
			foreach (DangoBrawlCombineItem dangoBrawlCombineItem in this.CombineItemPanels)
			{
				dangoBrawlCombineItem.Destroy(null);
			}
			this.CombineItemPanels.Clear();
		}

		// Token: 0x0603705B RID: 225371 RVA: 0x00F5B494 File Offset: 0x00F59694
		private void MarkStarActive(int uid)
		{
			if (uid <= 0)
			{
				return;
			}
			this.PendingStarActiveUids.Add(uid);
			this.FlushStarActiveAsync().Forget();
		}

		// Token: 0x0603705C RID: 225372 RVA: 0x00F5B4B4 File Offset: 0x00F596B4
		private UniTask FlushStarActiveAsync()
		{
			DangoBrawlPnlBackpack.<FlushStarActiveAsync>d__84 <FlushStarActiveAsync>d__;
			<FlushStarActiveAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<FlushStarActiveAsync>d__.<>4__this = this;
			<FlushStarActiveAsync>d__.<>1__state = -1;
			<FlushStarActiveAsync>d__.<>t__builder.Start<DangoBrawlPnlBackpack.<FlushStarActiveAsync>d__84>(ref <FlushStarActiveAsync>d__);
			return <FlushStarActiveAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603705D RID: 225373 RVA: 0x00F5B4F7 File Offset: 0x00F596F7
		private void OnCostChanged()
		{
			this.RefreshWeight();
		}

		// Token: 0x0603705E RID: 225374 RVA: 0x00F5B4FF File Offset: 0x00F596FF
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

		// Token: 0x0603705F RID: 225375 RVA: 0x00F5B534 File Offset: 0x00F59734
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

		// Token: 0x06037060 RID: 225376 RVA: 0x00F5B569 File Offset: 0x00F59769
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

		// Token: 0x06037061 RID: 225377 RVA: 0x00F5B594 File Offset: 0x00F59794
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			if (DangoBrawlConfig.Instance.GetItemConfigTypeById(configId) == EDangoBrawlItemType.Bag)
			{
				this.SlotBgColorMaskReason |= DangoBrawlPnlBackpack.ESlotBgColorReason.Dragging;
			}
			this.RefreshSlotBgColor();
		}

		// Token: 0x06037062 RID: 225378 RVA: 0x00F5B5BA File Offset: 0x00F597BA
		private void OnDragEndAnyWay()
		{
			this.SlotBgColorMaskReason &= ~DangoBrawlPnlBackpack.ESlotBgColorReason.Dragging;
			this.RefreshSlotBgColor();
		}

		// Token: 0x06037063 RID: 225379 RVA: 0x00F5B5D1 File Offset: 0x00F597D1
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

		// Token: 0x06037064 RID: 225380 RVA: 0x00F5B5FC File Offset: 0x00F597FC
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

		// Token: 0x06037065 RID: 225381 RVA: 0x00F5B634 File Offset: 0x00F59834
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

		// Token: 0x06037066 RID: 225382 RVA: 0x00F5B6DC File Offset: 0x00F598DC
		private void OnShopSold(int uid)
		{
			this.RemoveItemPanel(uid);
			this.RefreshUniqueWeapon();
		}

		// Token: 0x06037067 RID: 225383 RVA: 0x00F5B6EB File Offset: 0x00F598EB
		[NullableContext(1)]
		private void OnDangoBrawlShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds)
		{
			this.PlayComposeFxAsync(uid, toBench, mainUid, sourceUids, sourceKinds).Forget();
		}

		// Token: 0x06037068 RID: 225384 RVA: 0x00F5B700 File Offset: 0x00F59900
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

		// Token: 0x06037069 RID: 225385 RVA: 0x00F5B740 File Offset: 0x00F59940
		private void OnBagUpdated()
		{
			Dictionary<int, DangoBrawlBackpackItemData> dictionary = new Dictionary<int, DangoBrawlBackpackItemData>();
			if (this.ActData.BagpackData != null)
			{
				foreach (DangoBrawlBackpackItemData dangoBrawlBackpackItemData in this.ActData.BagpackData.GetItemList())
				{
					dictionary.Add(dangoBrawlBackpackItemData.MyUid, dangoBrawlBackpackItemData);
				}
			}
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
				if (!dictionary.ContainsKey(num))
				{
					this.RemoveItemPanel(num);
				}
			}
			foreach (KeyValuePair<int, DangoBrawlBackpackItemData> keyValuePair in dictionary)
			{
				if (hashSet.Contains(keyValuePair.Key))
				{
					DangoBrawlViewItemBase dangoBrawlViewItemBase = this.FindItemPanel(keyValuePair.Key);
					if (dangoBrawlViewItemBase != null)
					{
						DangoBrawlBackpackItemData dangoBrawlBackpackItemData2 = dangoBrawlViewItemBase.MyItemData as DangoBrawlBackpackItemData;
						bool flag = dangoBrawlBackpackItemData2 == null || dangoBrawlBackpackItemData2.MyLeftTopPos.RowIndex != keyValuePair.Value.MyLeftTopPos.RowIndex || dangoBrawlBackpackItemData2.MyLeftTopPos.ColIndex != keyValuePair.Value.MyLeftTopPos.ColIndex || dangoBrawlBackpackItemData2.MyRotation != keyValuePair.Value.MyRotation || dangoBrawlBackpackItemData2.MyConfigId != keyValuePair.Value.MyConfigId;
						dangoBrawlViewItemBase.BindData(this.ActData, keyValuePair.Value, this.GridSize);
						if (flag)
						{
							dangoBrawlViewItemBase.RefreshView();
						}
					}
				}
			}
			this.RebuildBagViewAsync(dictionary, hashSet).Forget();
		}

		// Token: 0x0603706A RID: 225386 RVA: 0x00F5B9B4 File Offset: 0x00F59BB4
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

		// Token: 0x0603706B RID: 225387 RVA: 0x00F5B9D4 File Offset: 0x00F59BD4
		private void OnDangoBrawlBenchModified(EDangoBrawlModifyType type, int uid)
		{
			if (type != EDangoBrawlModifyType.Modify)
			{
				this.RequestRefreshCombineList();
				this.RefreshBagItemGuideLines();
			}
		}

		// Token: 0x0603706C RID: 225388 RVA: 0x00F5B9E8 File Offset: 0x00F59BE8
		private void RefreshBagItemGuideLines()
		{
			foreach (DangoBrawlPnlBagItemView dangoBrawlPnlBagItemView in this.BagItemPanels)
			{
				dangoBrawlPnlBagItemView.RebuildCombineGuideLinesIfShowing();
			}
		}

		// Token: 0x0603706D RID: 225389 RVA: 0x00F5BA38 File Offset: 0x00F59C38
		public UUIItem GetGridContainer()
		{
			return base.GetItem(5);
		}

		// Token: 0x0603706E RID: 225390 RVA: 0x00F5BA44 File Offset: 0x00F59C44
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

		// Token: 0x0603706F RID: 225391 RVA: 0x00F5BA74 File Offset: 0x00F59C74
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

		// Token: 0x06037070 RID: 225392 RVA: 0x00F5BBCC File Offset: 0x00F59DCC
		public void ClearHighlight()
		{
			foreach (DangoBrawlPnlBackpackGrid dangoBrawlPnlBackpackGrid in this.HighlightedGrids)
			{
				dangoBrawlPnlBackpackGrid.SetGridState(EDangoBrawlGridState.Default);
			}
			this.HighlightedGrids.Clear();
		}

		// Token: 0x06037071 RID: 225393 RVA: 0x00F5BC28 File Offset: 0x00F59E28
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

		// Token: 0x06037072 RID: 225394 RVA: 0x00F5BCEC File Offset: 0x00F59EEC
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

		// Token: 0x06037073 RID: 225395 RVA: 0x00F5BD98 File Offset: 0x00F59F98
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

		// Token: 0x06037074 RID: 225396 RVA: 0x00F5BDC0 File Offset: 0x00F59FC0
		public void FallbackAddItemPanel(int uid, bool playEnterSeq = true)
		{
			DangoBrawlBackpackData bagpackData = this.ActData.BagpackData;
			DangoBrawlBackpackItemData dangoBrawlBackpackItemData = (bagpackData != null) ? bagpackData.GetItem(uid) : null;
			if (dangoBrawlBackpackItemData != null)
			{
				this.AddItemPanel(dangoBrawlBackpackItemData).Forget();
			}
		}

		// Token: 0x0401D1CD RID: 119245
		[Nullable(1)]
		public ActivityDangoBrawlData ActData;

		// Token: 0x0401D1CE RID: 119246
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBagView> BagPanels = new List<DangoBrawlPnlBagView>();

		// Token: 0x0401D1CF RID: 119247
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBagItemView> BagItemPanels = new List<DangoBrawlPnlBagItemView>();

		// Token: 0x0401D1D0 RID: 119248
		[Nullable(1)]
		private readonly List<DangoBrawlCombineItem> CombineItemPanels = new List<DangoBrawlCombineItem>();

		// Token: 0x0401D1D1 RID: 119249
		[Nullable(1)]
		private readonly Dictionary<PanelPos, DangoBrawlPnlBackpackGrid> GridPanels = new Dictionary<PanelPos, DangoBrawlPnlBackpackGrid>();

		// Token: 0x0401D1D2 RID: 119250
		[Nullable(1)]
		private readonly List<DangoBrawlPnlBackpackGrid> HighlightedGrids = new List<DangoBrawlPnlBackpackGrid>();

		// Token: 0x0401D1D3 RID: 119251
		private int GridSize;

		// Token: 0x0401D1D4 RID: 119252
		private float ItemTipsOffsetY;

		// Token: 0x0401D1D5 RID: 119253
		private DangoBrawlPnlBackpack.ESlotBgColorReason SlotBgColorMaskReason;

		// Token: 0x0401D1D6 RID: 119254
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D1D7 RID: 119255
		private DangoBrawlSmallTips WeightDetailTips;

		// Token: 0x0401D1D8 RID: 119256
		private DangoBrawlSmallTips UniqueWeaponDetailTips;

		// Token: 0x0401D1D9 RID: 119257
		private bool WeightTipsLocked;

		// Token: 0x0401D1DA RID: 119258
		private bool UniqueWeaponTipsLocked;

		// Token: 0x0401D1DB RID: 119259
		private TimerHandle WeightTipsHoverHideTimer;

		// Token: 0x0401D1DC RID: 119260
		private TimerHandle UniqueWeaponTipsHoverHideTimer;

		// Token: 0x0401D1DD RID: 119261
		private DangoBrawlCombineEnsureLineHost CombineEnsureLineHost;

		// Token: 0x0401D1DE RID: 119262
		private UUIItem BagTemplate;

		// Token: 0x0401D1DF RID: 119263
		private UUIItem BagItemTemplate;

		// Token: 0x0401D1E0 RID: 119264
		private bool CombineListRefreshScheduled;

		// Token: 0x0401D1E1 RID: 119265
		[Nullable(1)]
		private readonly HashSet<int> PendingStarActiveUids = new HashSet<int>();

		// Token: 0x0401D1E2 RID: 119266
		private bool StarActiveFlushScheduled;

		// Token: 0x0200B2FF RID: 45823
		[NullableContext(0)]
		private enum EComponents
		{
			// Token: 0x040374CE RID: 226510
			PnlWeightRed,
			// Token: 0x040374CF RID: 226511
			PnlWeightBlue,
			// Token: 0x040374D0 RID: 226512
			TxtWeight,
			// Token: 0x040374D1 RID: 226513
			ContentBag,
			// Token: 0x040374D2 RID: 226514
			ContentBagItem,
			// Token: 0x040374D3 RID: 226515
			ContentGrid,
			// Token: 0x040374D4 RID: 226516
			ItemGrid,
			// Token: 0x040374D5 RID: 226517
			PnlCombine,
			// Token: 0x040374D6 RID: 226518
			ContentCombine,
			// Token: 0x040374D7 RID: 226519
			TemplateCombine,
			// Token: 0x040374D8 RID: 226520
			ContentCombineLine,
			// Token: 0x040374D9 RID: 226521
			TemplateCombineLine,
			// Token: 0x040374DA RID: 226522
			PnlUniqueWeapon,
			// Token: 0x040374DB RID: 226523
			TxtUniqueWeapon,
			// Token: 0x040374DC RID: 226524
			SprUniqueWeapon,
			// Token: 0x040374DD RID: 226525
			ItemDetailTips,
			// Token: 0x040374DE RID: 226526
			BtnWeightDetail,
			// Token: 0x040374DF RID: 226527
			WeightDetailTips,
			// Token: 0x040374E0 RID: 226528
			BtnUniqueWeaponDetail,
			// Token: 0x040374E1 RID: 226529
			UniqueWeaponDetailTips,
			// Token: 0x040374E2 RID: 226530
			SprSlotBg
		}

		// Token: 0x0200B300 RID: 45824
		[NullableContext(0)]
		[Flags]
		private enum ESlotBgColorReason
		{
			// Token: 0x040374E4 RID: 226532
			None = 0,
			// Token: 0x040374E5 RID: 226533
			Dragging = 1,
			// Token: 0x040374E6 RID: 226534
			Sticky = 2,
			// Token: 0x040374E7 RID: 226535
			LayerMode = 4
		}
	}
}
