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
	// Token: 0x02005760 RID: 22368
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlOccupationTabView : UiTabViewBase
	{
		// Token: 0x17006A76 RID: 27254
		// (get) Token: 0x0603729D RID: 225949 RVA: 0x00F66005 File Offset: 0x00F64205
		private ActivityDangoBrawlData ActivityData
		{
			get
			{
				return ActivityDangoBrawlController.Instance.MyActivityData;
			}
		}

		// Token: 0x0603729E RID: 225950 RVA: 0x00F66014 File Offset: 0x00F64214
		protected override void OnShowUiTabViewFromToggle()
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0603729F RID: 225951 RVA: 0x00F66040 File Offset: 0x00F64240
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

		// Token: 0x060372A0 RID: 225952 RVA: 0x00F66070 File Offset: 0x00F64270
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

		// Token: 0x060372A1 RID: 225953 RVA: 0x00F66310 File Offset: 0x00F64510
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlOccupationTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlOccupationTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060372A2 RID: 225954 RVA: 0x00F66353 File Offset: 0x00F64553
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

		// Token: 0x060372A3 RID: 225955 RVA: 0x00F66389 File Offset: 0x00F64589
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify, new Action(this.OnOpenItemTipsHotkey));
		}

		// Token: 0x060372A4 RID: 225956 RVA: 0x00F663A7 File Offset: 0x00F645A7
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangobrawlOpenItemTipsHotkeyNotify, new Action(this.OnOpenItemTipsHotkey));
		}

		// Token: 0x060372A5 RID: 225957 RVA: 0x00F663C5 File Offset: 0x00F645C5
		protected override void OnBeforeDestroy()
		{
			ActivityDangoBrawlController.Instance.UnRegisterTermHyperlink(base.GetText(10));
		}

		// Token: 0x060372A6 RID: 225958 RVA: 0x00F663D9 File Offset: 0x00F645D9
		private void OnViewStartSequence(string _)
		{
			GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> titleScroll = this.TitleScroll;
			if (titleScroll != null)
			{
				titleScroll.PlayTurnAnimation();
			}
			this.PlaySelectedTitleSpine();
		}

		// Token: 0x060372A7 RID: 225959 RVA: 0x00F663F4 File Offset: 0x00F645F4
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

		// Token: 0x060372A8 RID: 225960 RVA: 0x00F66434 File Offset: 0x00F64634
		private DangoBrawlOccupationTitleItem InitTitleItem()
		{
			return new DangoBrawlOccupationTitleItem
			{
				OnClickToggleBack = new Action<int, int>(this.OnClickTitleItem),
				IsCurrentOccupation = ((int occupationId) => occupationId == this.SelectedOccupationId)
			};
		}

		// Token: 0x060372A9 RID: 225961 RVA: 0x00F6645F File Offset: 0x00F6465F
		private DangoBrawlOccupationTagItem InitTagItem()
		{
			return new DangoBrawlOccupationTagItem();
		}

		// Token: 0x060372AA RID: 225962 RVA: 0x00F66466 File Offset: 0x00F64666
		private DangoBrawlOccupationWeaponItem InitWeaponItem()
		{
			return new DangoBrawlOccupationWeaponItem
			{
				OnClickToggleBack = new Action<int, DangoBrawlOccupationWeaponItemData>(this.OnClickWeaponItem)
			};
		}

		// Token: 0x060372AB RID: 225963 RVA: 0x00F66480 File Offset: 0x00F64680
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

		// Token: 0x060372AC RID: 225964 RVA: 0x00F6655C File Offset: 0x00F6475C
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

		// Token: 0x060372AD RID: 225965 RVA: 0x00F665BC File Offset: 0x00F647BC
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

		// Token: 0x060372AE RID: 225966 RVA: 0x00F66600 File Offset: 0x00F64800
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

		// Token: 0x060372AF RID: 225967 RVA: 0x00F6666C File Offset: 0x00F6486C
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

		// Token: 0x060372B0 RID: 225968 RVA: 0x00F666C0 File Offset: 0x00F648C0
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

		// Token: 0x060372B1 RID: 225969 RVA: 0x00F66718 File Offset: 0x00F64918
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

		// Token: 0x060372B2 RID: 225970 RVA: 0x00F667A0 File Offset: 0x00F649A0
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

		// Token: 0x060372B3 RID: 225971 RVA: 0x00F667F0 File Offset: 0x00F649F0
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

		// Token: 0x060372B4 RID: 225972 RVA: 0x00F66888 File Offset: 0x00F64A88
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

		// Token: 0x060372B5 RID: 225973 RVA: 0x00F66900 File Offset: 0x00F64B00
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

		// Token: 0x060372B6 RID: 225974 RVA: 0x00F6695B File Offset: 0x00F64B5B
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

		// Token: 0x060372B7 RID: 225975 RVA: 0x00F6698D File Offset: 0x00F64B8D
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

		// Token: 0x060372B8 RID: 225976 RVA: 0x00F669A5 File Offset: 0x00F64BA5
		private void OnMaskBtnClick()
		{
			this.HideAllTips();
		}

		// Token: 0x060372B9 RID: 225977 RVA: 0x00F669B0 File Offset: 0x00F64BB0
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

		// Token: 0x060372BA RID: 225978 RVA: 0x00F66A08 File Offset: 0x00F64C08
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

		// Token: 0x060372BB RID: 225979 RVA: 0x00F66A9C File Offset: 0x00F64C9C
		[NullableContext(2)]
		public UUIItem GetWeaponItemRootItem(int oneBasedIndex)
		{
			if (this.WeaponScroll == null || oneBasedIndex < 1)
			{
				return null;
			}
			return this.WeaponScroll.GetGrid(oneBasedIndex - 1);
		}

		// Token: 0x060372BC RID: 225980 RVA: 0x00F66ABA File Offset: 0x00F64CBA
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

		// Token: 0x0401D283 RID: 119427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<DangoBrawlOccupationTitleItem, int> TitleScroll;

		// Token: 0x0401D284 RID: 119428
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<DangoBrawlOccupationTagItem, int> TagLayout;

		// Token: 0x0401D285 RID: 119429
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<DangoBrawlOccupationWeaponItem, DangoBrawlOccupationWeaponItemData> WeaponScroll;

		// Token: 0x0401D286 RID: 119430
		[Nullable(2)]
		private DangoBrawlOccupationBackpackPanel BackpackPanel;

		// Token: 0x0401D287 RID: 119431
		[Nullable(2)]
		private DangoBrawlItemTipsBase ItemTips;

		// Token: 0x0401D288 RID: 119432
		private int SelectedOccupationId;

		// Token: 0x0200B365 RID: 45925
		[NullableContext(0)]
		private enum ETabViewComponent
		{
			// Token: 0x0403770D RID: 227085
			TitleScroll,
			// Token: 0x0403770E RID: 227086
			TitleScrollItem,
			// Token: 0x0403770F RID: 227087
			TxtOccupationName,
			// Token: 0x04037710 RID: 227088
			TxtRoleDesc,
			// Token: 0x04037711 RID: 227089
			SprRole,
			// Token: 0x04037712 RID: 227090
			TagLayout,
			// Token: 0x04037713 RID: 227091
			TagItem,
			// Token: 0x04037714 RID: 227092
			BackpackPanel,
			// Token: 0x04037715 RID: 227093
			TxtPrice,
			// Token: 0x04037716 RID: 227094
			RightContentItem,
			// Token: 0x04037717 RID: 227095
			TxtDesc,
			// Token: 0x04037718 RID: 227096
			WeaponScroll,
			// Token: 0x04037719 RID: 227097
			WeaponItem,
			// Token: 0x0403771A RID: 227098
			Unused,
			// Token: 0x0403771B RID: 227099
			BtnMask,
			// Token: 0x0403771C RID: 227100
			ItemTips,
			// Token: 0x0403771D RID: 227101
			BackpackBag,
			// Token: 0x0403771E RID: 227102
			BackpackBagItem
		}
	}
}
