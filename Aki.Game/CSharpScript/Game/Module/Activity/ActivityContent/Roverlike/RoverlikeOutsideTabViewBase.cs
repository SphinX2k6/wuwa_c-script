using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050B1 RID: 20657
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeOutsideTabViewBase : UiTabViewBase
	{
		// Token: 0x170064F5 RID: 25845
		// (get) Token: 0x06033B24 RID: 211748 RVA: 0x00E787CB File Offset: 0x00E769CB
		[Nullable(2)]
		protected RoverlikeActivityData ActivityData
		{
			[NullableContext(2)]
			get
			{
				RoverlikeActivityController instance = RoverlikeActivityController.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetCurrentActivityData();
			}
		}

		// Token: 0x170064F6 RID: 25846
		// (get) Token: 0x06033B25 RID: 211749
		[TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		protected abstract IReadOnlyList<ValueTuple<EOutsideSlot, Type>> Layout { [return: TupleElementNames(new string[]
		{
			"Slot",
			"Type"
		})] [return: Nullable(new byte[]
		{
			1,
			0,
			1
		})] get; }

		// Token: 0x06033B26 RID: 211750 RVA: 0x00E787E0 File Offset: 0x00E769E0
		protected override void OnRegisterComponent()
		{
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>();
			this.SlotIndexMap.Clear();
			for (int i = 0; i < this.Layout.Count; i++)
			{
				list.Add(new ValueTuple<int, Type>(i, this.Layout[i].Item2));
				this.SlotIndexMap[this.Layout[i].Item1] = i;
			}
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>(list);
		}

		// Token: 0x06033B27 RID: 211751 RVA: 0x00E7885C File Offset: 0x00E76A5C
		protected int SlotIndex(EOutsideSlot slot)
		{
			int result;
			if (!this.SlotIndexMap.TryGetValue(slot, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x06033B28 RID: 211752 RVA: 0x00E7887C File Offset: 0x00E76A7C
		[NullableContext(2)]
		protected UUIItem GetSlotItem(EOutsideSlot slot)
		{
			return base.GetItem(this.SlotIndex(slot));
		}

		// Token: 0x06033B29 RID: 211753 RVA: 0x00E7888C File Offset: 0x00E76A8C
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeOutsideTabViewBase.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeOutsideTabViewBase.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06033B2A RID: 211754 RVA: 0x00E788CF File Offset: 0x00E76ACF
		protected override void OnStart()
		{
			this.SetupChromeVisibility();
			this.HideOtherDetailCards();
			if (this.ShouldShowToggle())
			{
				this.SetupToggle();
			}
			if (this.ShouldShowRoleList())
			{
				this.BuildRoleList();
			}
			this.RefreshList();
		}

		// Token: 0x06033B2B RID: 211755 RVA: 0x00E788FF File Offset: 0x00E76AFF
		protected override void OnShowUiTabViewFromToggle()
		{
			if (this.MultiList == null)
			{
				return;
			}
			this.PlaySequence("Start");
			if (this.ShouldShowRoleList())
			{
				this.RefreshRoleListData();
			}
			this.RefreshList();
		}

		// Token: 0x06033B2C RID: 211756 RVA: 0x00E7892C File Offset: 0x00E76B2C
		protected override void OnBeforeDestroy()
		{
			if (this.ShouldShowToggle())
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(this.SlotIndex(EOutsideSlot.ToggleTick));
				if (extendToggle != null)
				{
					extendToggle.OnStateChange.Remove(new Action<EToggleState>(this.OnToggleStateChanged));
				}
			}
			this.MultiList = null;
			this.MultiListAnimController = null;
			this.RoleList = null;
			this.ScrollDataList.Clear();
			this.RoleDataList = new List<RoverlikeOutsideRoleData>();
		}

		// Token: 0x06033B2D RID: 211757 RVA: 0x00E78998 File Offset: 0x00E76B98
		private void SetupChromeVisibility()
		{
			UUIItem slotItem = this.GetSlotItem(EOutsideSlot.PnlRole);
			if (slotItem != null)
			{
				slotItem.SetUIActive(this.ShouldShowRoleList());
			}
			UUIItem slotItem2 = this.GetSlotItem(EOutsideSlot.PnlToggle);
			if (slotItem2 != null)
			{
				slotItem2.SetUIActive(this.ShouldShowToggle());
			}
			UUIItem slotItem3 = this.GetSlotItem(EOutsideSlot.PnlProgress);
			if (slotItem3 != null)
			{
				slotItem3.SetUIActive(this.ShouldShowCollectProgress());
			}
			this.SetRoleEmptyActive(false);
			UUIItem slotItem4 = this.GetSlotItem(EOutsideSlot.PnlRoleLock);
			if (slotItem4 == null)
			{
				return;
			}
			slotItem4.SetUIActive(false);
		}

		// Token: 0x06033B2E RID: 211758 RVA: 0x00E78A08 File Offset: 0x00E76C08
		private void SetRoleEmptyActive(bool active)
		{
			UUIItem slotItem = this.GetSlotItem(EOutsideSlot.PnlRoleEmpty);
			if (slotItem != null)
			{
				slotItem.SetUIActive(active);
			}
			UUIItem slotItem2 = this.GetSlotItem(EOutsideSlot.PnlRight);
			if (slotItem2 == null)
			{
				return;
			}
			slotItem2.SetUIActive(!active);
		}

		// Token: 0x06033B2F RID: 211759 RVA: 0x00E78A34 File Offset: 0x00E76C34
		private void BuildRoleList()
		{
			UUILoopScrollViewComponent loopScrollViewComponent = base.GetLoopScrollViewComponent(this.SlotIndex(EOutsideSlot.SvRole));
			UUIExtendToggle extendToggle = base.GetExtendToggle(this.SlotIndex(EOutsideSlot.TogRole));
			AUIBaseActor auibaseActor = ((extendToggle != null) ? extendToggle.GetOwner() : null) as AUIBaseActor;
			if (loopScrollViewComponent == null || auibaseActor == null)
			{
				return;
			}
			this.RoleList = new LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData>(loopScrollViewComponent, auibaseActor, new Func<RoverlikeOutsideRoleItem>(this.CreateRoleProxy), false);
			this.RefreshRoleListData();
		}

		// Token: 0x06033B30 RID: 211760 RVA: 0x00E78A95 File Offset: 0x00E76C95
		private RoverlikeOutsideRoleItem CreateRoleProxy()
		{
			return new RoverlikeOutsideRoleItem
			{
				OnClickCb = new Action<RoverlikeOutsideRoleData, int>(this.OnRoleClick),
				IsGridSelected = new Func<RoverlikeOutsideRoleData, int, bool>(this.IsRoleSelected),
				GetHasRedDot = new Func<RoverlikeOutsideRoleData, int, bool>(this.IsRoleRedDotVisible)
			};
		}

		// Token: 0x06033B31 RID: 211761 RVA: 0x00E78AD4 File Offset: 0x00E76CD4
		private void RefreshRoleListData()
		{
			this.RoleDataList = this.BuildRoleDataList();
			if (this.RoleDataList.Count == 0)
			{
				return;
			}
			bool flag = false;
			using (List<RoverlikeOutsideRoleData>.Enumerator enumerator = this.RoleDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.RoleId == this.SelectedRoleId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				this.SelectedRoleId = this.RoleDataList[0].RoleId;
			}
			LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> roleList = this.RoleList;
			if (roleList == null)
			{
				return;
			}
			roleList.RefreshByData(this.RoleDataList, false, null, false);
		}

		// Token: 0x06033B32 RID: 211762 RVA: 0x00E78B80 File Offset: 0x00E76D80
		protected virtual List<RoverlikeOutsideRoleData> BuildRoleDataList()
		{
			return new List<RoverlikeOutsideRoleData>();
		}

		// Token: 0x06033B33 RID: 211763 RVA: 0x00E78B88 File Offset: 0x00E76D88
		private void OnRoleClick(RoverlikeOutsideRoleData data, int gridIndex)
		{
			this.OnRoleRedDotClear(data.RoleId);
			if (data.RoleId != this.SelectedRoleId)
			{
				this.SelectedRoleId = data.RoleId;
				LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> roleList = this.RoleList;
				if (roleList != null)
				{
					roleList.RefreshAllGridProxies();
				}
				this.OnRoleSelected();
				this.RefreshList();
				return;
			}
			LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> roleList2 = this.RoleList;
			if (roleList2 == null)
			{
				return;
			}
			roleList2.RefreshAllGridProxies();
		}

		// Token: 0x06033B34 RID: 211764 RVA: 0x00E78BE9 File Offset: 0x00E76DE9
		protected virtual void OnRoleSelected()
		{
		}

		// Token: 0x06033B35 RID: 211765 RVA: 0x00E78BEB File Offset: 0x00E76DEB
		protected virtual bool IsRoleRedDotVisible(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return data.HasRedDot;
		}

		// Token: 0x06033B36 RID: 211766 RVA: 0x00E78BF3 File Offset: 0x00E76DF3
		protected virtual void OnRoleRedDotClear(int roleId)
		{
		}

		// Token: 0x06033B37 RID: 211767 RVA: 0x00E78BF5 File Offset: 0x00E76DF5
		protected void RefreshRoleGrids()
		{
			LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> roleList = this.RoleList;
			if (roleList == null)
			{
				return;
			}
			roleList.RefreshAllGridProxies();
		}

		// Token: 0x06033B38 RID: 211768 RVA: 0x00E78C07 File Offset: 0x00E76E07
		private bool IsRoleSelected(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return data.RoleId == this.SelectedRoleId;
		}

		// Token: 0x06033B39 RID: 211769 RVA: 0x00E78C18 File Offset: 0x00E76E18
		protected bool IsSelectedRoleUnlocked()
		{
			RoverlikeOutsideRoleData roverlikeOutsideRoleData = null;
			foreach (RoverlikeOutsideRoleData roverlikeOutsideRoleData2 in this.RoleDataList)
			{
				if (roverlikeOutsideRoleData2.RoleId == this.SelectedRoleId)
				{
					roverlikeOutsideRoleData = roverlikeOutsideRoleData2;
					break;
				}
			}
			return roverlikeOutsideRoleData == null || roverlikeOutsideRoleData.Unlocked;
		}

		// Token: 0x06033B3A RID: 211770 RVA: 0x00E78C84 File Offset: 0x00E76E84
		protected int GetSelectedRoleId()
		{
			return this.SelectedRoleId;
		}

		// Token: 0x06033B3B RID: 211771 RVA: 0x00E78C8C File Offset: 0x00E76E8C
		private void SetupToggle()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(this.SlotIndex(EOutsideSlot.ToggleTick));
			if (extendToggle == null)
			{
				return;
			}
			this.ShowAllChecked = false;
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChanged));
		}

		// Token: 0x06033B3C RID: 211772 RVA: 0x00E78CD5 File Offset: 0x00E76ED5
		private void OnToggleStateChanged(EToggleState state)
		{
			this.ShowAllChecked = (state == EToggleState.ETT_Checked);
			this.RefreshList();
		}

		// Token: 0x06033B3D RID: 211773 RVA: 0x00E78CE7 File Offset: 0x00E76EE7
		protected bool IsShowAllChecked()
		{
			return this.ShowAllChecked;
		}

		// Token: 0x06033B3E RID: 211774 RVA: 0x00E78CF0 File Offset: 0x00E76EF0
		private void RefreshCollectProgress()
		{
			if (!this.ShouldShowCollectProgress())
			{
				return;
			}
			RoverlikeActivityData activityData = this.ActivityData;
			ValueTuple<int, int> valueTuple = (activityData != null) ? activityData.GetItemUnlockProgress() : new ValueTuple<int, int>(0, 0);
			UUIText text = base.GetText(this.SlotIndex(EOutsideSlot.TxtProgress));
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Item1);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(valueTuple.Item2);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06033B3F RID: 211775 RVA: 0x00E78D70 File Offset: 0x00E76F70
		protected void RefreshList()
		{
			this.ScrollDataList.Clear();
			this.SelectedGridIndex = -1;
			if (this.ShouldShowRoleList() && !this.IsSelectedRoleUnlocked())
			{
				this.ShowRoleLocked();
				return;
			}
			this.SetRoleEmptyActive(false);
			UUIItem slotItem = this.GetSlotItem(EOutsideSlot.PnlItem);
			if (slotItem != null)
			{
				slotItem.SetUIActive(true);
			}
			int num = this.BuildScrollDataList();
			MultiTemplateScrollViewRefreshContext multiTemplateScrollViewRefreshContext = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			multiTemplateScrollViewRefreshContext.ScrollToGridIndex = 0;
			this.MultiList.RefreshByData(multiTemplateScrollViewRefreshContext);
			this.PlayListInturnAnimation();
			this.RefreshCollectProgress();
			if (num >= 0)
			{
				this.SelectByGridIndex(num);
				return;
			}
			this.ShowEmptyDetail();
		}

		// Token: 0x06033B40 RID: 211776 RVA: 0x00E78E04 File Offset: 0x00E77004
		private void ShowRoleLocked()
		{
			RoverlikeOutsideRoleData roverlikeOutsideRoleData = null;
			foreach (RoverlikeOutsideRoleData roverlikeOutsideRoleData2 in this.RoleDataList)
			{
				if (roverlikeOutsideRoleData2.RoleId == this.SelectedRoleId)
				{
					roverlikeOutsideRoleData = roverlikeOutsideRoleData2;
					break;
				}
			}
			UUIItem slotItem = this.GetSlotItem(EOutsideSlot.PnlItem);
			if (slotItem != null)
			{
				slotItem.SetUIActive(false);
			}
			this.SetRoleEmptyActive(true);
			MultiTemplateScrollViewRefreshContext context = new MultiTemplateScrollViewRefreshContext(this.ScrollDataList);
			this.MultiList.RefreshByData(context);
			this.ShowEmptyDetail();
			string unlockDesc = (!string.IsNullOrEmpty((roverlikeOutsideRoleData != null) ? roverlikeOutsideRoleData.UnlockDesc : null)) ? roverlikeOutsideRoleData.UnlockDesc : "RoverRogue_SystemShow_RoleLocked";
			this.OnRefreshRoleLockedDesc(unlockDesc);
		}

		// Token: 0x06033B41 RID: 211777 RVA: 0x00E78EC8 File Offset: 0x00E770C8
		protected virtual void OnRefreshRoleLockedDesc(string unlockDesc)
		{
		}

		// Token: 0x06033B42 RID: 211778 RVA: 0x00E78ECC File Offset: 0x00E770CC
		protected void PushTitle(string titleKey)
		{
			RoverlikeOutsideTitleTemplateData roverlikeOutsideTitleTemplateData = new RoverlikeOutsideTitleTemplateData();
			roverlikeOutsideTitleTemplateData.Data = new RoverlikeOutsideTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeOutsideTitleTemplateData);
		}

		// Token: 0x06033B43 RID: 211779 RVA: 0x00E78F00 File Offset: 0x00E77100
		protected void PushTitleIcon(string iconPath)
		{
			RoverlikeOutsideTitleTemplateData roverlikeOutsideTitleTemplateData = new RoverlikeOutsideTitleTemplateData();
			roverlikeOutsideTitleTemplateData.Data = new RoverlikeOutsideTitleData
			{
				IconPath = iconPath
			};
			this.ScrollDataList.Add(roverlikeOutsideTitleTemplateData);
		}

		// Token: 0x06033B44 RID: 211780 RVA: 0x00E78F34 File Offset: 0x00E77134
		protected void PushTitleIconWithText(string iconPath, string titleKey)
		{
			RoverlikeOutsideTitleTemplateData roverlikeOutsideTitleTemplateData = new RoverlikeOutsideTitleTemplateData();
			roverlikeOutsideTitleTemplateData.Data = new RoverlikeOutsideTitleData
			{
				IconPath = iconPath,
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeOutsideTitleTemplateData);
		}

		// Token: 0x06033B45 RID: 211781 RVA: 0x00E78F6C File Offset: 0x00E7716C
		protected int PushGrid(RoverlikeGainEntry entry)
		{
			RoverlikeOutsideEntryGridItemTemplateData roverlikeOutsideEntryGridItemTemplateData = new RoverlikeOutsideEntryGridItemTemplateData();
			roverlikeOutsideEntryGridItemTemplateData.Data = entry;
			roverlikeOutsideEntryGridItemTemplateData.OnClickCb = new Action<RoverlikeGainEntry, int>(this.OnGridClick);
			roverlikeOutsideEntryGridItemTemplateData.IsSelected = new Func<RoverlikeGainEntry, int, bool>(this.IsGridSelected);
			roverlikeOutsideEntryGridItemTemplateData.GetLockState = new Func<RoverlikeGainEntry, int, bool>(this.IsGridLocked);
			this.ScrollDataList.Add(roverlikeOutsideEntryGridItemTemplateData);
			return this.ScrollDataList.Count - 1;
		}

		// Token: 0x06033B46 RID: 211782 RVA: 0x00E78FD8 File Offset: 0x00E771D8
		private void SelectByGridIndex(int gridIndex)
		{
			int selectedGridIndex = this.SelectedGridIndex;
			this.SelectedGridIndex = gridIndex;
			if (selectedGridIndex >= 0 && selectedGridIndex != gridIndex)
			{
				this.MultiList.RefreshProxyDirectly(selectedGridIndex);
			}
			this.MultiList.RefreshProxyDirectly(gridIndex);
			RoverlikeGainEntry entry = this.ScrollDataList[gridIndex].Data as RoverlikeGainEntry;
			this.RefreshDetail(entry);
		}

		// Token: 0x06033B47 RID: 211783 RVA: 0x00E79033 File Offset: 0x00E77233
		[NullableContext(2)]
		private void RefreshDetail(RoverlikeGainEntry entry)
		{
			if (entry == null || entry.ConfigId <= 0)
			{
				this.ShowEmptyDetail();
				return;
			}
			UUIItem detailItemComponent = this.GetDetailItemComponent();
			if (detailItemComponent != null)
			{
				detailItemComponent.SetUIActive(true);
			}
			this.RefreshDetailCard(entry);
		}

		// Token: 0x06033B48 RID: 211784 RVA: 0x00E79061 File Offset: 0x00E77261
		private void ShowEmptyDetail()
		{
			UUIItem detailItemComponent = this.GetDetailItemComponent();
			if (detailItemComponent == null)
			{
				return;
			}
			detailItemComponent.SetUIActive(false);
		}

		// Token: 0x06033B49 RID: 211785 RVA: 0x00E79074 File Offset: 0x00E77274
		private void HideOtherDetailCards()
		{
			UUIItem detailItemComponent = this.GetDetailItemComponent();
			foreach (EOutsideSlot slot in new EOutsideSlot[]
			{
				EOutsideSlot.ItemBlessDetail,
				EOutsideSlot.ItemPropDetail,
				EOutsideSlot.ItemReinforceDetail
			})
			{
				UUIItem slotItem = this.GetSlotItem(slot);
				if (slotItem != null && slotItem != detailItemComponent)
				{
					slotItem.SetUIActive(false);
				}
			}
		}

		// Token: 0x06033B4A RID: 211786 RVA: 0x00E790C6 File Offset: 0x00E772C6
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.PlaySequence("Switch");
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x06033B4B RID: 211787 RVA: 0x00E790E4 File Offset: 0x00E772E4
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x06033B4C RID: 211788 RVA: 0x00E790EF File Offset: 0x00E772EF
		private bool IsGridLocked(RoverlikeGainEntry data, int gridIndex)
		{
			return this.IsEntryLocked(data);
		}

		// Token: 0x06033B4D RID: 211789 RVA: 0x00E790F8 File Offset: 0x00E772F8
		protected void PlaySequence(string sequenceName)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x06033B4E RID: 211790 RVA: 0x00E79120 File Offset: 0x00E77320
		private void PlayListInturnAnimation()
		{
			UUIInturnAnimController multiListAnimController = this.MultiListAnimController;
			if (multiListAnimController == null)
			{
				return;
			}
			multiListAnimController.Play("", -1, true);
		}

		// Token: 0x06033B4F RID: 211791
		protected abstract UniTask CreateDetailCardAsync();

		// Token: 0x06033B50 RID: 211792
		protected abstract void RefreshDetailCard(RoverlikeGainEntry entry);

		// Token: 0x06033B51 RID: 211793
		[NullableContext(2)]
		protected abstract UUIItem GetDetailItemComponent();

		// Token: 0x06033B52 RID: 211794
		protected abstract int BuildScrollDataList();

		// Token: 0x06033B53 RID: 211795
		protected abstract bool IsEntryLocked(RoverlikeGainEntry entry);

		// Token: 0x06033B54 RID: 211796 RVA: 0x00E79139 File Offset: 0x00E77339
		protected virtual bool ShouldShowRoleList()
		{
			return false;
		}

		// Token: 0x06033B55 RID: 211797 RVA: 0x00E7913C File Offset: 0x00E7733C
		protected virtual bool ShouldShowToggle()
		{
			return false;
		}

		// Token: 0x06033B56 RID: 211798 RVA: 0x00E7913F File Offset: 0x00E7733F
		protected virtual bool ShouldShowCollectProgress()
		{
			return false;
		}

		// Token: 0x0401B6A9 RID: 112297
		[Nullable(2)]
		protected MultiTemplateScrollView MultiList;

		// Token: 0x0401B6AA RID: 112298
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x0401B6AB RID: 112299
		protected readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x0401B6AC RID: 112300
		protected int SelectedGridIndex = -1;

		// Token: 0x0401B6AD RID: 112301
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> RoleList;

		// Token: 0x0401B6AE RID: 112302
		private List<RoverlikeOutsideRoleData> RoleDataList = new List<RoverlikeOutsideRoleData>();

		// Token: 0x0401B6AF RID: 112303
		private int SelectedRoleId;

		// Token: 0x0401B6B0 RID: 112304
		private bool ShowAllChecked;

		// Token: 0x0401B6B1 RID: 112305
		private readonly Dictionary<EOutsideSlot, int> SlotIndexMap = new Dictionary<EOutsideSlot, int>();
	}
}
