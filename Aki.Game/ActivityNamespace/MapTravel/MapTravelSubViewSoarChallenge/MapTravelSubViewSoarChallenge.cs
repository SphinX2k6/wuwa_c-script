using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace ActivityNamespace.MapTravel.MapTravelSubViewSoarChallenge
{
	// Token: 0x02002F67 RID: 12135
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewSoarChallenge : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x17002D76 RID: 11638
		// (get) Token: 0x0601CBD1 RID: 117713 RVA: 0x008C589A File Offset: 0x008C3A9A
		// (set) Token: 0x0601CBD2 RID: 117714 RVA: 0x008C58A2 File Offset: 0x008C3AA2
		public bool NeedDestroySelf { get; set; }

		// Token: 0x0601CBD3 RID: 117715 RVA: 0x008C58AB File Offset: 0x008C3AAB
		public MapTravelSubViewSoarChallenge(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x17002D77 RID: 11639
		// (get) Token: 0x0601CBD4 RID: 117716 RVA: 0x008C58C1 File Offset: 0x008C3AC1
		// (set) Token: 0x0601CBD5 RID: 117717 RVA: 0x008C58C9 File Offset: 0x008C3AC9
		protected ActivityMapTravelData ActivityBaseData { get; set; }

		// Token: 0x0601CBD6 RID: 117718 RVA: 0x008C58D4 File Offset: 0x008C3AD4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDynScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.JumpButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601CBD7 RID: 117719 RVA: 0x008C5A40 File Offset: 0x008C3C40
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelSubViewSoarChallenge.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBD8 RID: 117720 RVA: 0x008C5A83 File Offset: 0x008C3C83
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.MapTravelSoarRefresh, new Action(this.OnMapTravelSoarRefresh));
		}

		// Token: 0x0601CBD9 RID: 117721 RVA: 0x008C5AA1 File Offset: 0x008C3CA1
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.MapTravelSoarRefresh, new Action(this.OnMapTravelSoarRefresh));
		}

		// Token: 0x0601CBDA RID: 117722 RVA: 0x008C5ABF File Offset: 0x008C3CBF
		private SoarChallengeTabDynamicScrollItem CreateTabItem(SoarChallengePlayData data, UUIItem uiItem, int index)
		{
			SoarChallengeTabDynamicScrollItem soarChallengeTabDynamicScrollItem = new SoarChallengeTabDynamicScrollItem();
			soarChallengeTabDynamicScrollItem.BindSelectedCallBack(new Action<SoarChallengePlayData>(this.TabSelectedCallBack));
			soarChallengeTabDynamicScrollItem.BindIsSelectedOn(new Func<SoarChallengePlayData, bool>(this.IsSelectOn));
			return soarChallengeTabDynamicScrollItem;
		}

		// Token: 0x0601CBDB RID: 117723 RVA: 0x008C5AEA File Offset: 0x008C3CEA
		private SoarChallengeItem InitItem()
		{
			SoarChallengeItem soarChallengeItem = new SoarChallengeItem(this.ActivityBaseData);
			soarChallengeItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return soarChallengeItem;
		}

		// Token: 0x0601CBDC RID: 117724 RVA: 0x008C5B0C File Offset: 0x008C3D0C
		private void OnClickRewardCb()
		{
			SoarChallengePlayData soarChallengePlayData = this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex];
			List<int> list = new List<int>();
			foreach (ActivityTaskData activityTaskData in this.ActivityBaseData.GetSoarItemDataList(soarChallengePlayData.RewardIds))
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			ActivityMapTravelController.Instance.RequestMultiTakeSoarChallengeReward(list);
		}

		// Token: 0x0601CBDD RID: 117725 RVA: 0x008C5BA0 File Offset: 0x008C3DA0
		private void OnMapTravelSoarRefresh()
		{
			SoarChallengePlayData soarChallengePlayData = this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex];
			this.TabLayout.GetScrollItemFromIndex(this.SelectedTabIndex).Update(soarChallengePlayData, this.SelectedTabIndex);
			this.RefreshContent(soarChallengePlayData);
		}

		// Token: 0x0601CBDE RID: 117726 RVA: 0x008C5BE8 File Offset: 0x008C3DE8
		protected UniTask Refresh()
		{
			MapTravelSubViewSoarChallenge.<Refresh>d__22 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<Refresh>d__22>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBDF RID: 117727 RVA: 0x008C5C2C File Offset: 0x008C3E2C
		private void TabSelectedCallBack(SoarChallengePlayData tabData)
		{
			if (this.SelectedTabIndex >= 0 && tabData.TabIndex != this.SelectedTabIndex)
			{
				this.SelectTab(this.SelectedTabIndex, false, false);
			}
			this.SelectedTabIndex = tabData.TabIndex;
			if (tabData.IsUnlock && !this.ActivityBaseData.SaveFirstCheckRedDotState(EMapTravelSaveFlag.SoarChallengeNewUnlock, tabData.PlayId))
			{
				SoarChallengeTabDynamicScrollItem scrollItemFromIndex = this.TabLayout.GetScrollItemFromIndex(this.SelectedTabIndex);
				if (scrollItemFromIndex != null)
				{
					scrollItemFromIndex.SetItemNewVisible(false);
				}
			}
			this.RefreshContent(tabData);
		}

		// Token: 0x0601CBE0 RID: 117728 RVA: 0x008C5CAA File Offset: 0x008C3EAA
		private bool IsSelectOn(SoarChallengePlayData tabData)
		{
			return this.SelectedTabIndex == tabData.TabIndex;
		}

		// Token: 0x0601CBE1 RID: 117729 RVA: 0x008C5CBA File Offset: 0x008C3EBA
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			this.TabLayout.GetScrollItemFromIndex(index).SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0601CBE2 RID: 117730 RVA: 0x008C5CCF File Offset: 0x008C3ECF
		private void JumpButtonClicked()
		{
			SkipTaskManager.RunByConfigId(this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex].JumpId, null);
		}

		// Token: 0x0601CBE3 RID: 117731 RVA: 0x008C5CF4 File Offset: 0x008C3EF4
		private void RefreshContent(SoarChallengePlayData tabData)
		{
			bool isUnlock = tabData.IsUnlock;
			List<ActivityTaskData> data = isUnlock ? this.ActivityBaseData.GetSoarItemDataList(tabData.RewardIds) : new List<ActivityTaskData>();
			this.LayoutList.RefreshByData(data, null, true);
			base.GetItem(4).SetUIActive(!isUnlock);
			if (!isUnlock)
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), this.ActivityBaseData.GetSoarPlayLockTips(tabData.PlayId), Array.Empty<object>());
			}
			base.GetButton(6).RootUIComp.Get().SetUIActive(isUnlock);
		}

		// Token: 0x0601CBE4 RID: 117732 RVA: 0x008C5D88 File Offset: 0x008C3F88
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewSoarChallenge.<PlayStartSequence>d__28 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<PlayStartSequence>d__28>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0601CBE5 RID: 117733 RVA: 0x008C5DCC File Offset: 0x008C3FCC
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewSoarChallenge.<PlayCloseSequence>d__29 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<PlayCloseSequence>d__29>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0400F23B RID: 62011
		private GenericScrollViewNew<SoarChallengeItem, ActivityTaskData> LayoutList;

		// Token: 0x0400F23C RID: 62012
		protected DynamicScrollView<SoarChallengeTabDynamicScrollItem, SoarTabDynamicItem, SoarChallengePlayData> TabLayout;

		// Token: 0x0400F23D RID: 62013
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0400F23E RID: 62014
		private int SelectedTabIndex = -1;

		// Token: 0x02008BFE RID: 35838
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0402C583 RID: 181635
			public const int TabLayout = 0;

			// Token: 0x0402C584 RID: 181636
			public const int TabItem = 1;

			// Token: 0x0402C585 RID: 181637
			public const int Content = 2;

			// Token: 0x0402C586 RID: 181638
			public const int Item = 3;

			// Token: 0x0402C587 RID: 181639
			public const int LockItem = 4;

			// Token: 0x0402C588 RID: 181640
			public const int LockText = 5;

			// Token: 0x0402C589 RID: 181641
			public const int ButtonGo = 6;
		}
	}
}
