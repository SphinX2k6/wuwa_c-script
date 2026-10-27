using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02006810 RID: 26640
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOccupationTabView : UiTabViewBase
	{
		// Token: 0x17009735 RID: 38709
		// (get) Token: 0x06042748 RID: 272200 RVA: 0x01024AC1 File Offset: 0x01022CC1
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x06042749 RID: 272201 RVA: 0x01024AD0 File Offset: 0x01022CD0
		protected override void OnShowUiTabViewFromToggle()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0604274A RID: 272202 RVA: 0x01024AFC File Offset: 0x01022CFC
		protected override void OnHideUiTabViewBase(bool fromToggle)
		{
			if (fromToggle)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence == null)
				{
					return;
				}
				uiViewSequence.PlaySequence("Close", false, null);
			}
		}

		// Token: 0x0604274B RID: 272203 RVA: 0x01024B2C File Offset: 0x01022D2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIMultiTemplateLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnMaskBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0604274C RID: 272204 RVA: 0x01024DCC File Offset: 0x01022FCC
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlOccupationTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlOccupationTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604274D RID: 272205 RVA: 0x01024E0F File Offset: 0x0102300F
		protected override void OnStart()
		{
			ActivityDangoBrawlController.Instance.RegisterTermHyperlink(base.GetText(10));
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.AddSequenceStartEvent("Start", new Action<string>(this.OnViewStartSequence));
		}

		// Token: 0x0604274E RID: 272206 RVA: 0x01024E45 File Offset: 0x01023045
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify, new Action(this.OnOpenItemTipsHotkey));
		}

		// Token: 0x0604274F RID: 272207 RVA: 0x01024E63 File Offset: 0x01023063
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify, new Action(this.OnOpenItemTipsHotkey));
		}

		// Token: 0x06042750 RID: 272208 RVA: 0x01024E81 File Offset: 0x01023081
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(10));
		}

		// Token: 0x06042751 RID: 272209 RVA: 0x01024E95 File Offset: 0x01023095
		private void OnViewStartSequence(string _)
		{
			GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> titleScroll = this.TitleScroll;
			if (titleScroll != null)
			{
				titleScroll.PlayTurnAnimation();
			}
			this.PlaySelectedTitleSpine();
		}

		// Token: 0x06042752 RID: 272210 RVA: 0x01024EB0 File Offset: 0x010230B0
		private void PlaySelectedTitleSpine()
		{
			GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> titleScroll = this.TitleScroll;
			int num = (titleScroll != null) ? titleScroll.GetSelectedIndex() : -1;
			if (num < 0)
			{
				return;
			}
			GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> titleScroll2 = this.TitleScroll;
			if (titleScroll2 == null)
			{
				return;
			}
			DangoBrawlOccupationTitleItem scrollItemByIndex = titleScroll2.GetScrollItemByIndex(num);
			if (scrollItemByIndex == null)
			{
				return;
			}
			scrollItemByIndex.PlaySpine();
		}

		// Token: 0x06042753 RID: 272211 RVA: 0x01024EF0 File Offset: 0x010230F0
		private DangoBrawlOccupationTitleItem InitTitleItem()
		{
			return new DangoBrawlOccupationTitleItem
			{
				OnClickToggleBack = new Action<int, int>(this.OnClickTitleItem),
				IsCurrentOccupation = ((int occupationId) => occupationId == this.SelectedOccupationId)
			};
		}

		// Token: 0x06042754 RID: 272212 RVA: 0x01024F1B File Offset: 0x0102311B
		private DangoBrawlOccupationTagItem InitTagItem()
		{
			return new DangoBrawlOccupationTagItem();
		}

		// Token: 0x06042755 RID: 272213 RVA: 0x01024F22 File Offset: 0x01023122
		private DangoBrawlOccupationWeaponItem InitWeaponItem()
		{
			return new DangoBrawlOccupationWeaponItem
			{
				OnClickToggleBack = new Action<int, DangoBrawlOccupationWeaponItemData>(this.OnClickWeaponItem)
			};
		}

		// Token: 0x06042756 RID: 272214 RVA: 0x01024F3C File Offset: 0x0102313C
		private void RefreshRightContent(int occupationId)
		{
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(occupationId);
			if (occupationConfigById == null)
			{
				return;
			}
			int iconTitleLength = occupationConfigById.Value.IconTitleLength;
			int j = 0;
			if (iconTitleLength > 1)
			{
				j = (int)PlayerInfoModel.Instance.GetPlayerGender();
			}
			string path = occupationConfigById.Value.IconTitle(j);
			this.TagLayout.RefreshByData(occupationConfigById.Value.GetTagIdListArray(), null, false);
			this.SetSpriteByPath(path, base.GetSprite(4), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), occupationConfigById.Value.RoleDesc, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), occupationConfigById.Value.Desc, Array.Empty<object>());
			this.RefreshBackpackPanel(occupationId);
		}

		// Token: 0x06042757 RID: 272215 RVA: 0x01025018 File Offset: 0x01023218
		private List<int> GetOccupationIdList()
		{
			IEnumerable<DangoBrawlOccupation> occupationConfigList = DangoBrawlConfig.Instance.GetOccupationConfigList();
			List<int> list = new List<int>();
			foreach (DangoBrawlOccupation dangoBrawlOccupation in occupationConfigList)
			{
				list.Add(dangoBrawlOccupation.Id);
			}
			return list;
		}

		// Token: 0x06042758 RID: 272216 RVA: 0x01025078 File Offset: 0x01023278
		private int GetInitialTitleIndex(List<int> occupationIdList)
		{
			DangoBrawlHandBookViewOpenData dangoBrawlHandBookViewOpenData = this.ExtraParams as DangoBrawlHandBookViewOpenData;
			int valueOrDefault = ((dangoBrawlHandBookViewOpenData != null) ? dangoBrawlHandBookViewOpenData.SelectedOccupationId : null).GetValueOrDefault();
			int num = occupationIdList.IndexOf(valueOrDefault);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06042759 RID: 272217 RVA: 0x010250BC File Offset: 0x010232BC
		private void RefreshBackpackPanel(int occupationId)
		{
			if (this.BackpackPanel == null)
			{
				return;
			}
			DangoBrawlOccupation? occupationConfigById = DangoBrawlConfig.Instance.GetOccupationConfigById(occupationId);
			if (occupationConfigById == null)
			{
				return;
			}
			int wobblePlateId = occupationConfigById.Value.WobblePlateId;
			int[] coreItemAttrArray = occupationConfigById.Value.GetCoreItemAttrArray();
			this.BackpackPanel.SetGridSize(136);
			this.RefreshBackpackPanelAsync(wobblePlateId, coreItemAttrArray).Forget();
		}

		// Token: 0x0604275A RID: 272218 RVA: 0x01025128 File Offset: 0x01023328
		private UniTask RefreshBackpackPanelAsync(int wobblePlateId, int[] allCoreItemIds)
		{
			DangoBrawlOccupationTabView.<RefreshBackpackPanelAsync>d__26 <RefreshBackpackPanelAsync>d__;
			<RefreshBackpackPanelAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshBackpackPanelAsync>d__.<>4__this = this;
			<RefreshBackpackPanelAsync>d__.wobblePlateId = wobblePlateId;
			<RefreshBackpackPanelAsync>d__.allCoreItemIds = allCoreItemIds;
			<RefreshBackpackPanelAsync>d__.<>1__state = -1;
			<RefreshBackpackPanelAsync>d__.<>t__builder.Start<DangoBrawlOccupationTabView.<RefreshBackpackPanelAsync>d__26>(ref <RefreshBackpackPanelAsync>d__);
			return <RefreshBackpackPanelAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604275B RID: 272219 RVA: 0x0102517C File Offset: 0x0102337C
		private void OnClickTitleItem(int gridIndex, int occupationId)
		{
			if (occupationId == this.SelectedOccupationId)
			{
				return;
			}
			this.HideAllTips();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("Switch", false, null);
			}
			this.SelectedOccupationId = occupationId;
			this.TitleScroll.SelectGridProxy(gridIndex, false);
			this.RefreshRightContent(occupationId);
		}

		// Token: 0x0604275C RID: 272220 RVA: 0x010251D4 File Offset: 0x010233D4
		private int GetSelectWeaponItemIndex(int weaponId, PanelPos? panelPos)
		{
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			List<DangoBrawlOccupationWeaponItemData> list = (backpackPanel != null) ? backpackPanel.GetCoreItemDataList() : null;
			if (list == null)
			{
				return -1;
			}
			for (int i = 0; i < list.Count; i++)
			{
				DangoBrawlOccupationWeaponItemData dangoBrawlOccupationWeaponItemData = list[i];
				if (dangoBrawlOccupationWeaponItemData.WeaponId == weaponId && (panelPos == null || (dangoBrawlOccupationWeaponItemData.PanelPos.ColIndex == panelPos.Value.ColIndex && dangoBrawlOccupationWeaponItemData.PanelPos.RowIndex == panelPos.Value.RowIndex)))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0604275D RID: 272221 RVA: 0x0102525C File Offset: 0x0102345C
		private void SelectWeaponItem(int weaponId, PanelPos? panelPos)
		{
			int selectWeaponItemIndex = this.GetSelectWeaponItemIndex(weaponId, panelPos);
			if (selectWeaponItemIndex < 0)
			{
				this.WeaponScroll.SelectGridProxy(-1, false);
				return;
			}
			if (!this.WeaponScroll.IsGridDisplaying(selectWeaponItemIndex))
			{
				this.WeaponScroll.ScrollToGridIndex(selectWeaponItemIndex, false);
			}
			this.WeaponScroll.SelectGridProxy(selectWeaponItemIndex, false);
		}

		// Token: 0x0604275E RID: 272222 RVA: 0x010252AC File Offset: 0x010234AC
		private void OnClickWeaponItem(int gridIndex, DangoBrawlOccupationWeaponItemData data)
		{
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel != null)
			{
				backpackPanel.CloseSmallTips();
			}
			this.SelectWeaponItem(data.WeaponId, new PanelPos?(data.PanelPos));
			DangoBrawlOccupationBackpackPanel backpackPanel2 = this.BackpackPanel;
			if (backpackPanel2 != null)
			{
				backpackPanel2.SetItemSelected(data.WeaponId, data.PanelPos);
			}
			if (this.ItemTips == null)
			{
				return;
			}
			this.ItemTips.RefreshAndShow(new DangoBrawlItemTipsData
			{
				ItemId = data.WeaponId,
				From = EDangoBrawlItemTipsFrom.Fixed,
				ShowCombine = new bool?(true),
				OperationMode = EDangoBrawlTipsOperationMode.Selected
			}).Forget();
		}

		// Token: 0x0604275F RID: 272223 RVA: 0x01025344 File Offset: 0x01023544
		private void OnBackpackItemClick(DangoBrawlOutBackpackItemData itemData)
		{
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel != null)
			{
				backpackPanel.CloseSmallTips();
			}
			this.SelectWeaponItem(itemData.MyConfigId, null);
			if (this.ItemTips == null)
			{
				return;
			}
			this.ItemTips.RefreshAndShow(new DangoBrawlItemTipsData
			{
				ItemId = itemData.MyConfigId,
				From = EDangoBrawlItemTipsFrom.Fixed,
				ShowCombine = new bool?(true),
				OperationMode = EDangoBrawlTipsOperationMode.Selected
			}).Forget();
		}

		// Token: 0x06042760 RID: 272224 RVA: 0x010253BC File Offset: 0x010235BC
		private void OnItemTipsCombineInfoClick(DangoBrawlItemTipsData data)
		{
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = data.ItemId,
				AllowCombine = false,
				FocusUid = data.ItemUid.GetValueOrDefault(),
				UseActData = false,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x06042761 RID: 272225 RVA: 0x01025417 File Offset: 0x01023617
		private void HideItemTips()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips != null)
			{
				itemTips.SetTipsVisible(false);
			}
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel != null)
			{
				backpackPanel.ClearItemSelected();
			}
			this.WeaponScroll.SelectGridProxy(-1, false);
		}

		// Token: 0x06042762 RID: 272226 RVA: 0x01025449 File Offset: 0x01023649
		private void HideAllTips()
		{
			this.HideItemTips();
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			if (backpackPanel == null)
			{
				return;
			}
			backpackPanel.CloseSmallTips();
		}

		// Token: 0x06042763 RID: 272227 RVA: 0x01025461 File Offset: 0x01023661
		private void OnMaskBtnClick()
		{
			this.HideAllTips();
		}

		// Token: 0x06042764 RID: 272228 RVA: 0x0102546C File Offset: 0x0102366C
		private void OnOpenItemTipsHotkey()
		{
			if (!base.IsUiActiveInHierarchy())
			{
				return;
			}
			DangoBrawlOccupationBackpackPanel backpackPanel = this.BackpackPanel;
			DangoBrawlOutBackpackItemBase dangoBrawlOutBackpackItemBase = (backpackPanel != null) ? backpackPanel.TryGetFocusItem() : null;
			if (dangoBrawlOutBackpackItemBase != null)
			{
				this.BackpackPanel.OnClickItem(dangoBrawlOutBackpackItemBase);
				return;
			}
			DangoBrawlOccupationWeaponItem dangoBrawlOccupationWeaponItem = this.TryGetFocusWeaponItem();
			if (dangoBrawlOccupationWeaponItem == null)
			{
				return;
			}
			this.OnClickWeaponItem(dangoBrawlOccupationWeaponItem.GridIndex, dangoBrawlOccupationWeaponItem.ItemData);
		}

		// Token: 0x06042765 RID: 272229 RVA: 0x010254C4 File Offset: 0x010236C4
		[NullableContext(2)]
		private DangoBrawlOccupationWeaponItem TryGetFocusWeaponItem()
		{
			if (this.WeaponScroll == null)
			{
				return null;
			}
			TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
			UUIItem uuiitem = (currentNavigationFocusListener != null) ? currentNavigationFocusListener.RootUIComp.Get() : null;
			if (uuiitem == null)
			{
				return null;
			}
			int displayGridStartIndex = this.WeaponScroll.GetDisplayGridStartIndex();
			int displayGridNum = this.WeaponScroll.GetDisplayGridNum();
			if (displayGridStartIndex < 0 || displayGridNum <= 0)
			{
				return null;
			}
			for (int i = displayGridStartIndex; i < displayGridStartIndex + displayGridNum; i++)
			{
				DangoBrawlOccupationWeaponItem dangoBrawlOccupationWeaponItem = this.WeaponScroll.UnsafeGetGridProxy(i, false);
				if (((dangoBrawlOccupationWeaponItem != null) ? dangoBrawlOccupationWeaponItem.GetRootItem() : null) == uuiitem)
				{
					return dangoBrawlOccupationWeaponItem;
				}
			}
			return null;
		}

		// Token: 0x06042766 RID: 272230 RVA: 0x01025558 File Offset: 0x01023758
		[NullableContext(2)]
		public UUIItem GetWeaponItemRootItem(int oneBasedIndex)
		{
			if (this.WeaponScroll == null || oneBasedIndex < 1)
			{
				return null;
			}
			return this.WeaponScroll.GetGrid(oneBasedIndex - 1);
		}

		// Token: 0x06042767 RID: 272231 RVA: 0x01025576 File Offset: 0x01023776
		[NullableContext(2)]
		public UUIItem GetItemTipsCombineInfoItem()
		{
			DangoBrawlItemTipsBase itemTips = this.ItemTips;
			if (itemTips == null)
			{
				return null;
			}
			return itemTips.GetCombineInfoBtnItem();
		}

		// Token: 0x04022A26 RID: 141862
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> TitleScroll;

		// Token: 0x04022A27 RID: 141863
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlOccupationTagItem, int> TagLayout;

		// Token: 0x04022A28 RID: 141864
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlOccupationWeaponItem, DangoBrawlOccupationWeaponItemData> WeaponScroll;

		// Token: 0x04022A29 RID: 141865
		[Nullable(2)]
		private DangoBrawlOccupationBackpackPanel BackpackPanel;

		// Token: 0x04022A2A RID: 141866
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x04022A2B RID: 141867
		private int SelectedOccupationId;

		// Token: 0x0200C998 RID: 51608
		[NullableContext(0)]
		private enum ETabViewComponent
		{
			// Token: 0x0403CE20 RID: 249376
			TitleScroll,
			// Token: 0x0403CE21 RID: 249377
			TitleScrollItem,
			// Token: 0x0403CE22 RID: 249378
			TxtOccupationName,
			// Token: 0x0403CE23 RID: 249379
			TxtRoleDesc,
			// Token: 0x0403CE24 RID: 249380
			SprRole,
			// Token: 0x0403CE25 RID: 249381
			TagLayout,
			// Token: 0x0403CE26 RID: 249382
			TagItem,
			// Token: 0x0403CE27 RID: 249383
			BackpackPanel,
			// Token: 0x0403CE28 RID: 249384
			TxtPrice,
			// Token: 0x0403CE29 RID: 249385
			RightContentItem,
			// Token: 0x0403CE2A RID: 249386
			TxtDesc,
			// Token: 0x0403CE2B RID: 249387
			WeaponScroll,
			// Token: 0x0403CE2C RID: 249388
			WeaponItem,
			// Token: 0x0403CE2D RID: 249389
			Unused,
			// Token: 0x0403CE2E RID: 249390
			BtnMask,
			// Token: 0x0403CE2F RID: 249391
			ItemTips,
			// Token: 0x0403CE30 RID: 249392
			BackpackBag,
			// Token: 0x0403CE31 RID: 249393
			BackpackBagItem
		}
	}
}
