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

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200598A RID: 22922
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolBagView : SolarSchoolHideHudViewBase
	{
		// Token: 0x06038840 RID: 231488 RVA: 0x00FCF95C File Offset: 0x00FCDB5C
		public SolarSchoolBagView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038841 RID: 231489 RVA: 0x00FCF9D4 File Offset: 0x00FCDBD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnTogCommonChanged));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnTogGiftChanged));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.OnTogSpecialChanged));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038842 RID: 231490 RVA: 0x00FCFD40 File Offset: 0x00FCDF40
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolBagView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolBagView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038843 RID: 231491 RVA: 0x00FCFD84 File Offset: 0x00FCDF84
		protected override void OnStart()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(6);
			this.ItemScroll = new LoopScrollView<SolarSchoolBagItemGrid, SolarSchoolBagItemData>(loopScrollViewComponent, loopScrollViewComponent.TemplateGrid.Get(), new Func<SolarSchoolBagItemGrid>(this.CreateItemGrid), false);
			this.AttrLayout = new GenericLayout<SolarSchoolBagAttrItem, SolarSchoolAttrDeltaItemData>(base.GetVerticalLayout(9), new Func<SolarSchoolBagAttrItem>(this.CreateAttrItem), base.GetItem(10).GetOwner() as AUIBaseActor, false, true);
			this.RoleLayout = new GenericLayout<SolarSchoolBagRoleItem, int>(base.GetHorizontalLayout(14), new Func<SolarSchoolBagRoleItem>(this.CreateRoleItem), base.GetItem(15).GetOwner() as AUIBaseActor, false, true);
			this.RefreshKeychain();
		}

		// Token: 0x06038844 RID: 231492 RVA: 0x00FCFE2C File Offset: 0x00FCE02C
		private void RefreshKeychain()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			UUITexture texture = base.GetTexture(19);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUITexture texture2 = base.GetTexture(20);
			if (texture2 == null)
			{
				return;
			}
			texture2.SetUIActive(!flag);
		}

		// Token: 0x06038845 RID: 231493 RVA: 0x00FCFE74 File Offset: 0x00FCE074
		protected override void OnBeforeShow()
		{
			SolarSchoolAttrPanel attrPanel = this.AttrPanel;
			if (attrPanel != null)
			{
				attrPanel.RefreshAttr();
			}
			bool flag = this.GiftParam != null;
			foreach (ValueTuple<int, ESolarSchoolItemType> valueTuple in this.Tabs)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(valueTuple.Item1);
				if (extendToggle != null)
				{
					UUIItem uuiitem = extendToggle.RootUIComp.Get();
					if (uuiitem != null)
					{
						uuiitem.SetUIActive(!flag || valueTuple.Item2 == ESolarSchoolItemType.Gift);
					}
				}
			}
			this.SwitchTab((this.GiftParam == null) ? ESolarSchoolItemType.Common : ESolarSchoolItemType.Gift);
		}

		// Token: 0x06038846 RID: 231494 RVA: 0x00FCFF08 File Offset: 0x00FCE108
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Add<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Add(EEventName.SolarSchoolBagGridSequenceEnd, new Action(this.OnGridSequenceClose));
		}

		// Token: 0x06038847 RID: 231495 RVA: 0x00FCFF6C File Offset: 0x00FCE16C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<ESolarSchoolSecondAttr>(EEventName.SolarSchoolAttrChanged, new Action<ESolarSchoolSecondAttr>(this.OnAttrChanged));
			EventSystem.Instance.Remove<int>(EEventName.SolarSchoolItemChanged, new Action<int>(this.OnItemChanged));
			EventSystem.Instance.Remove(EEventName.SolarSchoolBagGridSequenceEnd, new Action(this.OnGridSequenceClose));
		}

		// Token: 0x06038848 RID: 231496 RVA: 0x00FCFFCD File Offset: 0x00FCE1CD
		protected override void OnBeforeDestroy()
		{
			SolarSchoolBagGiftParam giftParam = this.GiftParam;
			object obj = (giftParam != null) ? giftParam.OnCancel : null;
			this.GiftParam = null;
			object obj2 = obj;
			if (obj2 == null)
			{
				return;
			}
			obj2();
		}

		// Token: 0x06038849 RID: 231497 RVA: 0x00FCFFF2 File Offset: 0x00FCE1F2
		private void OnTogCommonChanged(EToggleState state)
		{
			this.OnTabToggleChanged(state, ESolarSchoolItemType.Common);
		}

		// Token: 0x0603884A RID: 231498 RVA: 0x00FCFFFC File Offset: 0x00FCE1FC
		private void OnTogGiftChanged(EToggleState state)
		{
			this.OnTabToggleChanged(state, ESolarSchoolItemType.Gift);
		}

		// Token: 0x0603884B RID: 231499 RVA: 0x00FD0006 File Offset: 0x00FCE206
		private void OnTogSpecialChanged(EToggleState state)
		{
			this.OnTabToggleChanged(state, ESolarSchoolItemType.Special);
		}

		// Token: 0x0603884C RID: 231500 RVA: 0x00FD0010 File Offset: 0x00FCE210
		private void OnTabToggleChanged(EToggleState state, ESolarSchoolItemType type)
		{
			if (state != EToggleState.ETT_Checked || type == this.CurTabType)
			{
				return;
			}
			this.SwitchTab(type);
		}

		// Token: 0x0603884D RID: 231501 RVA: 0x00FD0028 File Offset: 0x00FCE228
		private void SwitchTab(ESolarSchoolItemType type)
		{
			this.CurTabType = type;
			this.SelectedItemId = 0;
			foreach (ValueTuple<int, ESolarSchoolItemType> valueTuple in this.Tabs)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(valueTuple.Item1);
				if (extendToggle != null)
				{
					extendToggle.SetToggleStateForce((valueTuple.Item2 == type) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
				}
			}
			this.RefreshItemListAsync(false, true).Forget();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x0603884E RID: 231502 RVA: 0x00FD00B0 File Offset: 0x00FCE2B0
		private UniTask RefreshItemListAsync(bool keepContentPosition = false, bool playGridAnim = true)
		{
			SolarSchoolBagView.<RefreshItemListAsync>d__32 <RefreshItemListAsync>d__;
			<RefreshItemListAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshItemListAsync>d__.<>4__this = this;
			<RefreshItemListAsync>d__.keepContentPosition = keepContentPosition;
			<RefreshItemListAsync>d__.playGridAnim = playGridAnim;
			<RefreshItemListAsync>d__.<>1__state = -1;
			<RefreshItemListAsync>d__.<>t__builder.Start<SolarSchoolBagView.<RefreshItemListAsync>d__32>(ref <RefreshItemListAsync>d__);
			return <RefreshItemListAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603884F RID: 231503 RVA: 0x00FD0104 File Offset: 0x00FCE304
		private void FillItemDataList(List<SolarSchoolBagItemData> bagItems)
		{
			this.ItemDataList.Clear();
			SolarSchoolBagGiftParam giftParam = this.GiftParam;
			int num = (giftParam != null) ? giftParam.RoleId : 0;
			if (num <= 0)
			{
				this.ItemDataList.AddRange(bagItems);
				return;
			}
			foreach (SolarSchoolBagItemData solarSchoolBagItemData in bagItems)
			{
				if (this.IsRoleFavorItem(solarSchoolBagItemData, num))
				{
					this.ItemDataList.Add(solarSchoolBagItemData);
				}
			}
			foreach (SolarSchoolBagItemData solarSchoolBagItemData2 in bagItems)
			{
				if (!this.IsRoleFavorItem(solarSchoolBagItemData2, num))
				{
					this.ItemDataList.Add(solarSchoolBagItemData2);
				}
			}
		}

		// Token: 0x06038850 RID: 231504 RVA: 0x00FD01DC File Offset: 0x00FCE3DC
		private bool IsRoleFavorItem(SolarSchoolBagItemData data, int roleId)
		{
			return Array.IndexOf<int>(data.Config.GetFavorRoleListArray(), roleId) >= 0;
		}

		// Token: 0x06038851 RID: 231505 RVA: 0x00FD0204 File Offset: 0x00FCE404
		private int FindItemIndex(int itemId)
		{
			int num = this.IndexOfItem(itemId);
			if (num < 0)
			{
				return 0;
			}
			return num;
		}

		// Token: 0x06038852 RID: 231506 RVA: 0x00FD0220 File Offset: 0x00FCE420
		private int IndexOfItem(int itemId)
		{
			for (int i = 0; i < this.ItemDataList.Count; i++)
			{
				if (this.ItemDataList[i].ItemId == itemId)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06038853 RID: 231507 RVA: 0x00FD025D File Offset: 0x00FCE45D
		private SolarSchoolBagItemGrid CreateItemGrid()
		{
			SolarSchoolBagItemGrid solarSchoolBagItemGrid = new SolarSchoolBagItemGrid();
			solarSchoolBagItemGrid.ClickCallback = new Action<SolarSchoolBagItemData>(this.RefreshDetail);
			SolarSchoolBagGiftParam giftParam = this.GiftParam;
			solarSchoolBagItemGrid.GiftRoleId = ((giftParam != null) ? giftParam.RoleId : 0);
			return solarSchoolBagItemGrid;
		}

		// Token: 0x06038854 RID: 231508 RVA: 0x00FD028E File Offset: 0x00FCE48E
		private SolarSchoolBagAttrItem CreateAttrItem()
		{
			return new SolarSchoolBagAttrItem();
		}

		// Token: 0x06038855 RID: 231509 RVA: 0x00FD0295 File Offset: 0x00FCE495
		private SolarSchoolBagRoleItem CreateRoleItem()
		{
			return new SolarSchoolBagRoleItem();
		}

		// Token: 0x06038856 RID: 231510 RVA: 0x00FD029C File Offset: 0x00FCE49C
		private void RefreshDetail(SolarSchoolBagItemData data)
		{
			this.SelectedItemId = data.ItemId;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), data.Config.Name, Array.Empty<object>());
			SolarSchoolGamePlayModel instance = SolarSchoolGamePlayModel.Instance;
			this.AttrDataList.Clear();
			foreach (ValueTuple<ESolarSchoolSecondAttr, int> valueTuple in instance.GetItemAttrDeltas(data.Config))
			{
				ESolarSchoolSecondAttr item = valueTuple.Item1;
				int item2 = valueTuple.Item2;
				this.AttrDataList.Add(new SolarSchoolAttrDeltaItemData(item, item2));
			}
			bool flag = this.AttrDataList.Count > 0;
			GenericLayout<SolarSchoolBagAttrItem, SolarSchoolAttrDeltaItemData> attrLayout = this.AttrLayout;
			if (attrLayout != null)
			{
				UUIItem rootUiItem = attrLayout.GetRootUiItem();
				if (rootUiItem != null)
				{
					rootUiItem.SetUIActive(flag);
				}
			}
			if (flag)
			{
				GenericLayout<SolarSchoolBagAttrItem, SolarSchoolAttrDeltaItemData> attrLayout2 = this.AttrLayout;
				if (attrLayout2 != null)
				{
					attrLayout2.RefreshByData(this.AttrDataList, null, false);
				}
			}
			bool flag2 = !string.IsNullOrEmpty(data.Config.Desc);
			UUIItem item3 = base.GetItem(11);
			if (item3 != null)
			{
				item3.SetUIActive(flag2);
			}
			if (flag2)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(12), data.Config.Desc, Array.Empty<object>());
			}
			this.RefreshRolePreference(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(17), "SolarSchool_BagNum", new <>z__ReadOnlySingleElementList<object>(data.Count));
			bool uiactive = this.GiftParam != null || instance.CanUseItem(data.ItemId);
			UUIItem item4 = base.GetItem(18);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(uiactive);
		}

		// Token: 0x06038857 RID: 231511 RVA: 0x00FD044C File Offset: 0x00FCE64C
		private void RefreshRolePreference(SolarSchoolBagItemData data)
		{
			this.FavorRoleIdList.Clear();
			this.CollectFavorRoles(data.ItemId);
			bool flag = this.FavorRoleIdList.Count > 0;
			UUIItem item = base.GetItem(13);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (flag)
			{
				GenericLayout<SolarSchoolBagRoleItem, int> roleLayout = this.RoleLayout;
				if (roleLayout == null)
				{
					return;
				}
				roleLayout.RefreshByData(this.FavorRoleIdList, null, false);
			}
		}

		// Token: 0x06038858 RID: 231512 RVA: 0x00FD04B0 File Offset: 0x00FCE6B0
		private void CollectFavorRoles(int itemId)
		{
			SolarSchoolItem? item = SolarSchoolConfig.Instance.GetItem(itemId);
			if (item == null)
			{
				return;
			}
			this.FavorRoleIdList.AddRange(item.Value.GetFavorRoleListArray());
		}

		// Token: 0x06038859 RID: 231513 RVA: 0x00FD04F0 File Offset: 0x00FCE6F0
		private void OnUseClick()
		{
			if (this.IsRefreshingAfterUse || this.SelectedItemId <= 0 || this.UsedUpItemIds.Contains(this.SelectedItemId))
			{
				return;
			}
			int selectedItemId = this.SelectedItemId;
			this.UsingItemId = selectedItemId;
			bool flag;
			if (this.GiftParam != null)
			{
				Func<int, int> onGiftSelected = this.GiftParam.OnGiftSelected;
				flag = (onGiftSelected != null && onGiftSelected(selectedItemId) > 0);
			}
			else
			{
				flag = SolarSchoolGamePlayModel.Instance.UseItem(selectedItemId);
			}
			this.UsingItemId = 0;
			if (flag)
			{
				this.OnItemUsed(selectedItemId);
			}
		}

		// Token: 0x0603885A RID: 231514 RVA: 0x00FD0570 File Offset: 0x00FCE770
		private void OnAttrChanged(ESolarSchoolSecondAttr attr)
		{
			SolarSchoolAttrPanel attrPanel = this.AttrPanel;
			if (attrPanel == null)
			{
				return;
			}
			attrPanel.RefreshAttr();
		}

		// Token: 0x0603885B RID: 231515 RVA: 0x00FD0582 File Offset: 0x00FCE782
		private void OnItemChanged(int itemId)
		{
			if (this.UsingItemId > 0 || this.PlayingUseSequenceCount > 0)
			{
				return;
			}
			this.RefreshItemListAsync(false, true).Forget();
		}

		// Token: 0x0603885C RID: 231516 RVA: 0x00FD05A4 File Offset: 0x00FCE7A4
		private void OnItemUsed(int itemId)
		{
			int num = this.IndexOfItem(itemId);
			int itemCount = SolarSchoolGamePlayModel.Instance.InventoryData.GetItemCount(itemId);
			if (itemCount > 0)
			{
				this.UpdateItemCount(num, itemCount);
				return;
			}
			this.UsedUpItemIds.Add(itemId);
			LoopScrollView<SolarSchoolBagItemGrid, SolarSchoolBagItemData> itemScroll = this.ItemScroll;
			SolarSchoolBagItemGrid solarSchoolBagItemGrid = (itemScroll != null) ? itemScroll.UnsafeGetGridProxy(num, false) : null;
			this.SelectNextItem(num);
			if (solarSchoolBagItemGrid == null)
			{
				if (this.PlayingUseSequenceCount == 0)
				{
					this.RefreshAfterUsedUpAsync().Forget();
				}
				return;
			}
			if (!solarSchoolBagItemGrid.IsPlayingUsedSequence)
			{
				this.PlayingUseSequenceCount++;
			}
			solarSchoolBagItemGrid.PlayUsedSequence();
		}

		// Token: 0x0603885D RID: 231517 RVA: 0x00FD0634 File Offset: 0x00FCE834
		private void UpdateItemCount(int index, int count)
		{
			SolarSchoolBagItemData solarSchoolBagItemData = new SolarSchoolBagItemData(this.ItemDataList[index].Config, count);
			this.ItemDataList[index] = solarSchoolBagItemData;
			this.ItemScroll.UpdateData(this.ItemDataList);
			this.RefreshDetail(solarSchoolBagItemData);
		}

		// Token: 0x0603885E RID: 231518 RVA: 0x00FD0680 File Offset: 0x00FCE880
		private void SelectNextItem(int fromIndex)
		{
			for (int i = fromIndex + 1; i < this.ItemDataList.Count; i++)
			{
				if (!this.UsedUpItemIds.Contains(this.ItemDataList[i].ItemId))
				{
					this.SelectItem(i);
					return;
				}
			}
			for (int j = fromIndex - 1; j >= 0; j--)
			{
				if (!this.UsedUpItemIds.Contains(this.ItemDataList[j].ItemId))
				{
					this.SelectItem(j);
					return;
				}
			}
			this.SelectedItemId = 0;
			UUIItem item = base.GetItem(18);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603885F RID: 231519 RVA: 0x00FD071F File Offset: 0x00FCE91F
		private void SelectItem(int index)
		{
			this.ItemScroll.SelectGridProxy(index, false);
			this.RefreshDetail(this.ItemDataList[index]);
		}

		// Token: 0x06038860 RID: 231520 RVA: 0x00FD0740 File Offset: 0x00FCE940
		private void OnGridSequenceClose()
		{
			if (this.PlayingUseSequenceCount <= 0)
			{
				return;
			}
			this.PlayingUseSequenceCount--;
			if (this.PlayingUseSequenceCount == 0)
			{
				this.RefreshAfterUsedUpAsync().Forget();
			}
		}

		// Token: 0x06038861 RID: 231521 RVA: 0x00FD0770 File Offset: 0x00FCE970
		private UniTask RefreshAfterUsedUpAsync()
		{
			SolarSchoolBagView.<RefreshAfterUsedUpAsync>d__51 <RefreshAfterUsedUpAsync>d__;
			<RefreshAfterUsedUpAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshAfterUsedUpAsync>d__.<>4__this = this;
			<RefreshAfterUsedUpAsync>d__.<>1__state = -1;
			<RefreshAfterUsedUpAsync>d__.<>t__builder.Start<SolarSchoolBagView.<RefreshAfterUsedUpAsync>d__51>(ref <RefreshAfterUsedUpAsync>d__);
			return <RefreshAfterUsedUpAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401DC5D RID: 121949
		[TupleElementNames(new string[]
		{
			"Component",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0
		})]
		private readonly ValueTuple<int, ESolarSchoolItemType>[] Tabs = new ValueTuple<int, ESolarSchoolItemType>[]
		{
			new ValueTuple<int, ESolarSchoolItemType>(2, ESolarSchoolItemType.Common),
			new ValueTuple<int, ESolarSchoolItemType>(3, ESolarSchoolItemType.Gift),
			new ValueTuple<int, ESolarSchoolItemType>(4, ESolarSchoolItemType.Special)
		};

		// Token: 0x0401DC5E RID: 121950
		[Nullable(2)]
		private SolarSchoolCaptionItem Caption;

		// Token: 0x0401DC5F RID: 121951
		[Nullable(2)]
		private SolarSchoolAttrPanel AttrPanel;

		// Token: 0x0401DC60 RID: 121952
		[Nullable(2)]
		private SolarSchoolBtnItem UseBtn;

		// Token: 0x0401DC61 RID: 121953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<SolarSchoolBagItemGrid, SolarSchoolBagItemData> ItemScroll;

		// Token: 0x0401DC62 RID: 121954
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolBagAttrItem, SolarSchoolAttrDeltaItemData> AttrLayout;

		// Token: 0x0401DC63 RID: 121955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolBagRoleItem, int> RoleLayout;

		// Token: 0x0401DC64 RID: 121956
		[Nullable(2)]
		private SolarSchoolBagGiftParam GiftParam;

		// Token: 0x0401DC65 RID: 121957
		private readonly List<SolarSchoolBagItemData> ItemDataList = new List<SolarSchoolBagItemData>();

		// Token: 0x0401DC66 RID: 121958
		private readonly List<SolarSchoolAttrDeltaItemData> AttrDataList = new List<SolarSchoolAttrDeltaItemData>();

		// Token: 0x0401DC67 RID: 121959
		private readonly List<int> FavorRoleIdList = new List<int>();

		// Token: 0x0401DC68 RID: 121960
		private ESolarSchoolItemType CurTabType;

		// Token: 0x0401DC69 RID: 121961
		private int SelectedItemId;

		// Token: 0x0401DC6A RID: 121962
		private int UsingItemId;

		// Token: 0x0401DC6B RID: 121963
		private bool IsRefreshingAfterUse;

		// Token: 0x0401DC6C RID: 121964
		private int PlayingUseSequenceCount;

		// Token: 0x0401DC6D RID: 121965
		private readonly HashSet<int> UsedUpItemIds = new HashSet<int>();

		// Token: 0x0200B52C RID: 46380
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403802E RID: 229422
			public const int Caption = 0;

			// Token: 0x0403802F RID: 229423
			public const int AttrPanel = 1;

			// Token: 0x04038030 RID: 229424
			public const int TogCommon = 2;

			// Token: 0x04038031 RID: 229425
			public const int TogGift = 3;

			// Token: 0x04038032 RID: 229426
			public const int TogSpecial = 4;

			// Token: 0x04038033 RID: 229427
			public const int EmptyTips = 5;

			// Token: 0x04038034 RID: 229428
			public const int ItemScroll = 6;

			// Token: 0x04038035 RID: 229429
			public const int DetailRoot = 7;

			// Token: 0x04038036 RID: 229430
			public const int TxtName = 8;

			// Token: 0x04038037 RID: 229431
			public const int AttrLayout = 9;

			// Token: 0x04038038 RID: 229432
			public const int AttrItem = 10;

			// Token: 0x04038039 RID: 229433
			public const int PnlDesc = 11;

			// Token: 0x0403803A RID: 229434
			public const int TxtDesc = 12;

			// Token: 0x0403803B RID: 229435
			public const int RolePreference = 13;

			// Token: 0x0403803C RID: 229436
			public const int RoleLayout = 14;

			// Token: 0x0403803D RID: 229437
			public const int RoleItem = 15;

			// Token: 0x0403803E RID: 229438
			public const int PnlSource = 16;

			// Token: 0x0403803F RID: 229439
			public const int TxtGot = 17;

			// Token: 0x04038040 RID: 229440
			public const int BtnUse = 18;

			// Token: 0x04038041 RID: 229441
			public const int TexKeychainMale = 19;

			// Token: 0x04038042 RID: 229442
			public const int TexKeychainFemale = 20;
		}
	}
}
