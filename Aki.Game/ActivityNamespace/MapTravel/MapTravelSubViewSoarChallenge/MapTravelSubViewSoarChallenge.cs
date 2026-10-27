using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x020044DA RID: 17626
	[NullableContext(1)]
	[Nullable(0)]
	public class MapTravelSubViewSoarChallenge : UiPanelBase, IMapTravelSubViewInterface
	{
		// Token: 0x170073A4 RID: 29604
		// (get) Token: 0x0602D693 RID: 186003 RVA: 0x00A3FC36 File Offset: 0x00A3DE36
		// (set) Token: 0x0602D694 RID: 186004 RVA: 0x00A3FC3E File Offset: 0x00A3DE3E
		public bool NeedDestroySelf { get; set; }

		// Token: 0x0602D695 RID: 186005 RVA: 0x00A3FC47 File Offset: 0x00A3DE47
		public MapTravelSubViewSoarChallenge(ActivityMapTravelData activityBaseData)
		{
			this.ActivityBaseData = activityBaseData;
		}

		// Token: 0x170073A5 RID: 29605
		// (get) Token: 0x0602D696 RID: 186006 RVA: 0x00A3FC5D File Offset: 0x00A3DE5D
		// (set) Token: 0x0602D697 RID: 186007 RVA: 0x00A3FC65 File Offset: 0x00A3DE65
		protected ActivityMapTravelData ActivityBaseData { get; set; }

		// Token: 0x0602D698 RID: 186008 RVA: 0x00A3FC70 File Offset: 0x00A3DE70
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

		// Token: 0x0602D699 RID: 186009 RVA: 0x00A3FDDC File Offset: 0x00A3DFDC
		protected override UniTask OnBeforeStartAsync()
		{
			MapTravelSubViewSoarChallenge.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D69A RID: 186010 RVA: 0x00A3FE1F File Offset: 0x00A3E01F
		protected override void OnBeforeShow()
		{
			EventSystem.Instance.Add(EEventName.MapTravelSoarRefresh, new Action(this.OnMapTravelSoarRefresh));
		}

		// Token: 0x0602D69B RID: 186011 RVA: 0x00A3FE3D File Offset: 0x00A3E03D
		protected override void OnBeforeHide()
		{
			EventSystem.Instance.Remove(EEventName.MapTravelSoarRefresh, new Action(this.OnMapTravelSoarRefresh));
		}

		// Token: 0x0602D69C RID: 186012 RVA: 0x00A3FE5B File Offset: 0x00A3E05B
		private SoarChallengeTabDynamicScrollItem CreateTabItem(SoarChallengePlayData data, UUIItem uiItem, int index)
		{
			SoarChallengeTabDynamicScrollItem soarChallengeTabDynamicScrollItem = new SoarChallengeTabDynamicScrollItem();
			soarChallengeTabDynamicScrollItem.BindSelectedCallBack(new Action<SoarChallengePlayData>(this.TabSelectedCallBack));
			soarChallengeTabDynamicScrollItem.BindIsSelectedOn(new Func<SoarChallengePlayData, bool>(this.IsSelectOn));
			return soarChallengeTabDynamicScrollItem;
		}

		// Token: 0x0602D69D RID: 186013 RVA: 0x00A3FE86 File Offset: 0x00A3E086
		private SoarChallengeItem InitItem()
		{
			SoarChallengeItem soarChallengeItem = new SoarChallengeItem(this.ActivityBaseData);
			soarChallengeItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return soarChallengeItem;
		}

		// Token: 0x0602D69E RID: 186014 RVA: 0x00A3FEA8 File Offset: 0x00A3E0A8
		private void OnClickRewardCb()
		{
			SoarChallengePlayData soarChallengePlayData = this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex];
			List<int> rewardIds = (from taskData in this.ActivityBaseData.GetSoarItemDataList(soarChallengePlayData.RewardIds)
			where taskData.Status == EActivityTaskState.FinishedAndUnclaimed
			select taskData.Id).ToList<int>();
			ActivityMapTravelController.Instance.RequestMultiTakeSoarChallengeReward(rewardIds);
		}

		// Token: 0x0602D69F RID: 186015 RVA: 0x00A3FF38 File Offset: 0x00A3E138
		private void OnMapTravelSoarRefresh()
		{
			SoarChallengePlayData soarChallengePlayData = this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex];
			this.TabLayout.GetScrollItemFromIndex(this.SelectedTabIndex).Update(soarChallengePlayData, this.SelectedTabIndex);
			this.RefreshContent(soarChallengePlayData);
		}

		// Token: 0x0602D6A0 RID: 186016 RVA: 0x00A3FF80 File Offset: 0x00A3E180
		protected UniTask Refresh()
		{
			MapTravelSubViewSoarChallenge.<Refresh>d__22 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<Refresh>d__22>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6A1 RID: 186017 RVA: 0x00A3FFC4 File Offset: 0x00A3E1C4
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

		// Token: 0x0602D6A2 RID: 186018 RVA: 0x00A40042 File Offset: 0x00A3E242
		private bool IsSelectOn(SoarChallengePlayData tabData)
		{
			return this.SelectedTabIndex == tabData.TabIndex;
		}

		// Token: 0x0602D6A3 RID: 186019 RVA: 0x00A40052 File Offset: 0x00A3E252
		private void SelectTab(int index, bool bOn, bool bFireEvent)
		{
			this.TabLayout.GetScrollItemFromIndex(index).SetSelected(bOn, bFireEvent);
		}

		// Token: 0x0602D6A4 RID: 186020 RVA: 0x00A40067 File Offset: 0x00A3E267
		private void JumpButtonClicked()
		{
			SkipTaskManager.RunByConfigId(this.ActivityBaseData.GetAllSoarTabData()[this.SelectedTabIndex].JumpId, null);
		}

		// Token: 0x0602D6A5 RID: 186021 RVA: 0x00A4008C File Offset: 0x00A3E28C
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

		// Token: 0x0602D6A6 RID: 186022 RVA: 0x00A40120 File Offset: 0x00A3E320
		public UniTask PlayStartSequence()
		{
			MapTravelSubViewSoarChallenge.<PlayStartSequence>d__28 <PlayStartSequence>d__;
			<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayStartSequence>d__.<>4__this = this;
			<PlayStartSequence>d__.<>1__state = -1;
			<PlayStartSequence>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<PlayStartSequence>d__28>(ref <PlayStartSequence>d__);
			return <PlayStartSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602D6A7 RID: 186023 RVA: 0x00A40164 File Offset: 0x00A3E364
		public UniTask PlayCloseSequence()
		{
			MapTravelSubViewSoarChallenge.<PlayCloseSequence>d__29 <PlayCloseSequence>d__;
			<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayCloseSequence>d__.<>4__this = this;
			<PlayCloseSequence>d__.<>1__state = -1;
			<PlayCloseSequence>d__.<>t__builder.Start<MapTravelSubViewSoarChallenge.<PlayCloseSequence>d__29>(ref <PlayCloseSequence>d__);
			return <PlayCloseSequence>d__.<>t__builder.Task;
		}

		// Token: 0x04018493 RID: 99475
		private GenericScrollViewNew<SoarChallengeItem, ActivityTaskData> LayoutList;

		// Token: 0x04018494 RID: 99476
		protected DynamicScrollView<SoarChallengeTabDynamicScrollItem, SoarTabDynamicItem, SoarChallengePlayData> TabLayout;

		// Token: 0x04018495 RID: 99477
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04018496 RID: 99478
		private int SelectedTabIndex = -1;

		// Token: 0x0200A728 RID: 42792
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040327B5 RID: 206773
			public const int TabLayout = 0;

			// Token: 0x040327B6 RID: 206774
			public const int TabItem = 1;

			// Token: 0x040327B7 RID: 206775
			public const int Content = 2;

			// Token: 0x040327B8 RID: 206776
			public const int Item = 3;

			// Token: 0x040327B9 RID: 206777
			public const int LockItem = 4;

			// Token: 0x040327BA RID: 206778
			public const int LockText = 5;

			// Token: 0x040327BB RID: 206779
			public const int ButtonGo = 6;
		}
	}
}
