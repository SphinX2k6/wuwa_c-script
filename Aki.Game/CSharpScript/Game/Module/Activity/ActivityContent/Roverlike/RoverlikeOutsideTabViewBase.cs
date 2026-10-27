using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006133 RID: 24883
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoverlikeOutsideTabViewBase : UiTabViewBase
	{
		// Token: 0x17009193 RID: 37267
		// (get) Token: 0x0603EE61 RID: 257633 RVA: 0x00F3195E File Offset: 0x00F2FB5E
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

		// Token: 0x17009194 RID: 37268
		// (get) Token: 0x0603EE62 RID: 257634
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

		// Token: 0x0603EE63 RID: 257635 RVA: 0x00F31970 File Offset: 0x00F2FB70
		protected override void OnRegisterComponent()
		{
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>();
			this.SlotIndexMap.Clear();
			for (int i = 0; i < this.Layout.Count; i++)
			{
				list.Add(new ValueTuple<int, Type>(i, this.Layout[i].Item2));
				this.SlotIndexMap[this.Layout[i].Item1] = i;
			}
			this.ComponentRegisterInfos = (from entry in list
			select new ValueTuple<int, Type>(entry.Item1, entry.Item2)).ToList<ValueTuple<int, Type>>();
		}

		// Token: 0x0603EE64 RID: 257636 RVA: 0x00F31A10 File Offset: 0x00F2FC10
		protected int SlotIndex(EOutsideSlot slot)
		{
			int result;
			if (!this.SlotIndexMap.TryGetValue(slot, out result))
			{
				return -1;
			}
			return result;
		}

		// Token: 0x0603EE65 RID: 257637 RVA: 0x00F31A30 File Offset: 0x00F2FC30
		[NullableContext(2)]
		protected UUIItem GetSlotItem(EOutsideSlot slot)
		{
			return base.GetItem(this.SlotIndex(slot));
		}

		// Token: 0x0603EE66 RID: 257638 RVA: 0x00F31A40 File Offset: 0x00F2FC40
		protected override UniTask OnBeforeStartAsync()
		{
			RoverlikeOutsideTabViewBase.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoverlikeOutsideTabViewBase.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603EE67 RID: 257639 RVA: 0x00F31A83 File Offset: 0x00F2FC83
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

		// Token: 0x0603EE68 RID: 257640 RVA: 0x00F31AB3 File Offset: 0x00F2FCB3
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

		// Token: 0x0603EE69 RID: 257641 RVA: 0x00F31AE0 File Offset: 0x00F2FCE0
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

		// Token: 0x0603EE6A RID: 257642 RVA: 0x00F31B4C File Offset: 0x00F2FD4C
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

		// Token: 0x0603EE6B RID: 257643 RVA: 0x00F31BBC File Offset: 0x00F2FDBC
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

		// Token: 0x0603EE6C RID: 257644 RVA: 0x00F31BE8 File Offset: 0x00F2FDE8
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

		// Token: 0x0603EE6D RID: 257645 RVA: 0x00F31C49 File Offset: 0x00F2FE49
		private RoverlikeOutsideRoleItem CreateRoleProxy()
		{
			return new RoverlikeOutsideRoleItem
			{
				OnClickCb = new Action<RoverlikeOutsideRoleData, int>(this.OnRoleClick),
				IsGridSelected = new Func<RoverlikeOutsideRoleData, int, bool>(this.IsRoleSelected),
				GetHasRedDot = new Func<RoverlikeOutsideRoleData, int, bool>(this.IsRoleRedDotVisible)
			};
		}

		// Token: 0x0603EE6E RID: 257646 RVA: 0x00F31C88 File Offset: 0x00F2FE88
		private void RefreshRoleListData()
		{
			this.RoleDataList = this.BuildRoleDataList();
			if (this.RoleDataList.Count == 0)
			{
				return;
			}
			if (!this.RoleDataList.Any((RoverlikeOutsideRoleData data) => data.RoleId == this.SelectedRoleId))
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

		// Token: 0x0603EE6F RID: 257647 RVA: 0x00F31CF8 File Offset: 0x00F2FEF8
		protected virtual List<RoverlikeOutsideRoleData> BuildRoleDataList()
		{
			return new List<RoverlikeOutsideRoleData>();
		}

		// Token: 0x0603EE70 RID: 257648 RVA: 0x00F31D00 File Offset: 0x00F2FF00
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

		// Token: 0x0603EE71 RID: 257649 RVA: 0x00F31D61 File Offset: 0x00F2FF61
		protected virtual void OnRoleSelected()
		{
		}

		// Token: 0x0603EE72 RID: 257650 RVA: 0x00F31D63 File Offset: 0x00F2FF63
		protected virtual bool IsRoleRedDotVisible(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return data.HasRedDot;
		}

		// Token: 0x0603EE73 RID: 257651 RVA: 0x00F31D6B File Offset: 0x00F2FF6B
		protected virtual void OnRoleRedDotClear(int roleId)
		{
		}

		// Token: 0x0603EE74 RID: 257652 RVA: 0x00F31D6D File Offset: 0x00F2FF6D
		protected void RefreshRoleGrids()
		{
			LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> roleList = this.RoleList;
			if (roleList == null)
			{
				return;
			}
			roleList.RefreshAllGridProxies();
		}

		// Token: 0x0603EE75 RID: 257653 RVA: 0x00F31D7F File Offset: 0x00F2FF7F
		private bool IsRoleSelected(RoverlikeOutsideRoleData data, int gridIndex)
		{
			return data.RoleId == this.SelectedRoleId;
		}

		// Token: 0x0603EE76 RID: 257654 RVA: 0x00F31D8F File Offset: 0x00F2FF8F
		protected bool IsSelectedRoleUnlocked()
		{
			RoverlikeOutsideRoleData roverlikeOutsideRoleData = this.RoleDataList.FirstOrDefault((RoverlikeOutsideRoleData item) => item.RoleId == this.SelectedRoleId);
			return roverlikeOutsideRoleData == null || roverlikeOutsideRoleData.Unlocked;
		}

		// Token: 0x0603EE77 RID: 257655 RVA: 0x00F31DB3 File Offset: 0x00F2FFB3
		protected int GetSelectedRoleId()
		{
			return this.SelectedRoleId;
		}

		// Token: 0x0603EE78 RID: 257656 RVA: 0x00F31DBC File Offset: 0x00F2FFBC
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

		// Token: 0x0603EE79 RID: 257657 RVA: 0x00F31E05 File Offset: 0x00F30005
		private void OnToggleStateChanged(EToggleState state)
		{
			this.ShowAllChecked = (state == EToggleState.ETT_Checked);
			this.RefreshList();
		}

		// Token: 0x0603EE7A RID: 257658 RVA: 0x00F31E17 File Offset: 0x00F30017
		protected bool IsShowAllChecked()
		{
			return this.ShowAllChecked;
		}

		// Token: 0x0603EE7B RID: 257659 RVA: 0x00F31E20 File Offset: 0x00F30020
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

		// Token: 0x0603EE7C RID: 257660 RVA: 0x00F31EA0 File Offset: 0x00F300A0
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

		// Token: 0x0603EE7D RID: 257661 RVA: 0x00F31F34 File Offset: 0x00F30134
		private void ShowRoleLocked()
		{
			RoverlikeOutsideRoleData roverlikeOutsideRoleData = this.RoleDataList.FirstOrDefault((RoverlikeOutsideRoleData item) => item.RoleId == this.SelectedRoleId);
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

		// Token: 0x0603EE7E RID: 257662 RVA: 0x00F31FB9 File Offset: 0x00F301B9
		protected virtual void OnRefreshRoleLockedDesc(string unlockDesc)
		{
		}

		// Token: 0x0603EE7F RID: 257663 RVA: 0x00F31FBC File Offset: 0x00F301BC
		protected void PushTitle(string titleKey)
		{
			RoverlikeOutsideTitleTemplateData roverlikeOutsideTitleTemplateData = new RoverlikeOutsideTitleTemplateData();
			roverlikeOutsideTitleTemplateData.Data = new RoverlikeOutsideTitleData
			{
				TitleKey = titleKey
			};
			this.ScrollDataList.Add(roverlikeOutsideTitleTemplateData);
		}

		// Token: 0x0603EE80 RID: 257664 RVA: 0x00F31FF0 File Offset: 0x00F301F0
		protected void PushTitleIcon(string iconPath)
		{
			RoverlikeOutsideTitleTemplateData roverlikeOutsideTitleTemplateData = new RoverlikeOutsideTitleTemplateData();
			roverlikeOutsideTitleTemplateData.Data = new RoverlikeOutsideTitleData
			{
				IconPath = iconPath
			};
			this.ScrollDataList.Add(roverlikeOutsideTitleTemplateData);
		}

		// Token: 0x0603EE81 RID: 257665 RVA: 0x00F32024 File Offset: 0x00F30224
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

		// Token: 0x0603EE82 RID: 257666 RVA: 0x00F3205C File Offset: 0x00F3025C
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

		// Token: 0x0603EE83 RID: 257667 RVA: 0x00F320C8 File Offset: 0x00F302C8
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

		// Token: 0x0603EE84 RID: 257668 RVA: 0x00F32123 File Offset: 0x00F30323
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

		// Token: 0x0603EE85 RID: 257669 RVA: 0x00F32151 File Offset: 0x00F30351
		private void ShowEmptyDetail()
		{
			UUIItem detailItemComponent = this.GetDetailItemComponent();
			if (detailItemComponent == null)
			{
				return;
			}
			detailItemComponent.SetUIActive(false);
		}

		// Token: 0x0603EE86 RID: 257670 RVA: 0x00F32164 File Offset: 0x00F30364
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

		// Token: 0x0603EE87 RID: 257671 RVA: 0x00F321B6 File Offset: 0x00F303B6
		private void OnGridClick(RoverlikeGainEntry data, int gridIndex)
		{
			if (gridIndex == this.SelectedGridIndex)
			{
				return;
			}
			this.PlaySequence("Switch");
			this.SelectByGridIndex(gridIndex);
		}

		// Token: 0x0603EE88 RID: 257672 RVA: 0x00F321D4 File Offset: 0x00F303D4
		private bool IsGridSelected(RoverlikeGainEntry data, int gridIndex)
		{
			return gridIndex == this.SelectedGridIndex;
		}

		// Token: 0x0603EE89 RID: 257673 RVA: 0x00F321DF File Offset: 0x00F303DF
		private bool IsGridLocked(RoverlikeGainEntry data, int gridIndex)
		{
			return this.IsEntryLocked(data);
		}

		// Token: 0x0603EE8A RID: 257674 RVA: 0x00F321E8 File Offset: 0x00F303E8
		protected void PlaySequence(string sequenceName)
		{
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName(sequenceName, false, null);
		}

		// Token: 0x0603EE8B RID: 257675 RVA: 0x00F32210 File Offset: 0x00F30410
		private void PlayListInturnAnimation()
		{
			UUIInturnAnimController multiListAnimController = this.MultiListAnimController;
			if (multiListAnimController == null)
			{
				return;
			}
			multiListAnimController.Play("", -1, true);
		}

		// Token: 0x0603EE8C RID: 257676
		protected abstract UniTask CreateDetailCardAsync();

		// Token: 0x0603EE8D RID: 257677
		protected abstract void RefreshDetailCard(RoverlikeGainEntry entry);

		// Token: 0x0603EE8E RID: 257678
		[NullableContext(2)]
		protected abstract UUIItem GetDetailItemComponent();

		// Token: 0x0603EE8F RID: 257679
		protected abstract int BuildScrollDataList();

		// Token: 0x0603EE90 RID: 257680
		protected abstract bool IsEntryLocked(RoverlikeGainEntry entry);

		// Token: 0x0603EE91 RID: 257681 RVA: 0x00F32229 File Offset: 0x00F30429
		protected virtual bool ShouldShowRoleList()
		{
			return false;
		}

		// Token: 0x0603EE92 RID: 257682 RVA: 0x00F3222C File Offset: 0x00F3042C
		protected virtual bool ShouldShowToggle()
		{
			return false;
		}

		// Token: 0x0603EE93 RID: 257683 RVA: 0x00F3222F File Offset: 0x00F3042F
		protected virtual bool ShouldShowCollectProgress()
		{
			return false;
		}

		// Token: 0x04020D7C RID: 134524
		[Nullable(2)]
		protected MultiTemplateScrollView MultiList;

		// Token: 0x04020D7D RID: 134525
		[Nullable(2)]
		private UUIInturnAnimController MultiListAnimController;

		// Token: 0x04020D7E RID: 134526
		protected readonly List<IMultiTemplateGridData> ScrollDataList = new List<IMultiTemplateGridData>();

		// Token: 0x04020D7F RID: 134527
		protected int SelectedGridIndex = -1;

		// Token: 0x04020D80 RID: 134528
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<RoverlikeOutsideRoleItem, RoverlikeOutsideRoleData> RoleList;

		// Token: 0x04020D81 RID: 134529
		private List<RoverlikeOutsideRoleData> RoleDataList = new List<RoverlikeOutsideRoleData>();

		// Token: 0x04020D82 RID: 134530
		private int SelectedRoleId;

		// Token: 0x04020D83 RID: 134531
		private bool ShowAllChecked;

		// Token: 0x04020D84 RID: 134532
		private readonly Dictionary<EOutsideSlot, int> SlotIndexMap = new Dictionary<EOutsideSlot, int>();
	}
}
