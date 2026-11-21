using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LinkageReward
{
	// Token: 0x020054D3 RID: 21715
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkageRewardActivitySubView : ActivitySubViewBase
	{
		// Token: 0x06035CCC RID: 220364 RVA: 0x00F07A2C File Offset: 0x00F05C2C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06035CCD RID: 220365 RVA: 0x00F07B3A File Offset: 0x00F05D3A
		protected override void OnSetData()
		{
			this.LinkageRewardData = (this.ActivityBaseData as LinkageRewardActivityData);
		}

		// Token: 0x06035CCE RID: 220366 RVA: 0x00F07B50 File Offset: 0x00F05D50
		protected override UniTask OnBeforeStartAsync()
		{
			LinkageRewardActivitySubView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LinkageRewardActivitySubView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035CCF RID: 220367 RVA: 0x00F07B94 File Offset: 0x00F05D94
		protected override void OnStart()
		{
			this.RewardItemA1.OnClickToGet = new Action<int, int, bool>(this.OnGetReward);
			this.RewardItemA2.OnClickToGet = new Action<int, int, bool>(this.OnGetReward);
			this.RewardItemA3.OnClickToGet = new Action<int, int, bool>(this.OnGetReward);
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
			this.TitleComponent.SetSubTitleVisible(false);
			this.TitleComponent.SetSubTitleIconVisible(false);
			this.TitleComponent.ApplyLinkageSubTitleVisible(false);
		}

		// Token: 0x06035CD0 RID: 220368 RVA: 0x00F07C31 File Offset: 0x00F05E31
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
		}

		// Token: 0x06035CD1 RID: 220369 RVA: 0x00F07C4E File Offset: 0x00F05E4E
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06035CD2 RID: 220370 RVA: 0x00F07C6C File Offset: 0x00F05E6C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x06035CD3 RID: 220371 RVA: 0x00F07C8C File Offset: 0x00F05E8C
		protected override UniTask OnBeforeShowSelfAsync()
		{
			LinkageRewardActivitySubView.<OnBeforeShowSelfAsync>d__23 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<LinkageRewardActivitySubView.<OnBeforeShowSelfAsync>d__23>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035CD4 RID: 220372 RVA: 0x00F07CCF File Offset: 0x00F05ECF
		public override void SetActive(bool visibility)
		{
			if (!visibility)
			{
				this.PendingFocusRequestId++;
			}
			base.SetActive(visibility);
		}

		// Token: 0x06035CD5 RID: 220373 RVA: 0x00F07CE9 File Offset: 0x00F05EE9
		public override void OnCommonViewStateChange(bool show)
		{
			this.CanApplyGamepadFocus = !show;
			if (this.CanApplyGamepadFocus && this.PendingFocusRewardIndex >= 0)
			{
				this.ScheduleApplyPendingFocus(this.LinkageRewardData.GetRewardDataList().Count);
			}
		}

		// Token: 0x06035CD6 RID: 220374 RVA: 0x00F07D1C File Offset: 0x00F05F1C
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06035CD7 RID: 220375 RVA: 0x00F07D24 File Offset: 0x00F05F24
		private void RefreshTimerText()
		{
			ValueTuple<bool, string, long> timeVisibleAndRemainTime = this.GetTimeVisibleAndRemainTime();
			bool item = timeVisibleAndRemainTime.Item1;
			string item2 = timeVisibleAndRemainTime.Item2;
			this.TitleComponent.SetTimeTextVisible(item);
			if (item)
			{
				this.TitleComponent.SetTimeTextByText(item2);
			}
		}

		// Token: 0x06035CD8 RID: 220376 RVA: 0x00F07D5F File Offset: 0x00F05F5F
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityBaseData.Id != id)
			{
				return;
			}
			this.ScheduleRefreshRewardLayout();
		}

		// Token: 0x06035CD9 RID: 220377 RVA: 0x00F07D76 File Offset: 0x00F05F76
		private void ScheduleRefreshRewardLayout()
		{
			if (this.HasPendingRefreshRewardLayout)
			{
				return;
			}
			this.HasPendingRefreshRewardLayout = true;
			TimerSystem.Instance.Next(delegate(float _)
			{
				this.HasPendingRefreshRewardLayout = false;
				this.RefreshRewardLayout(false);
			}, null, null);
		}

		// Token: 0x06035CDA RID: 220378 RVA: 0x00F07DA4 File Offset: 0x00F05FA4
		private void RefreshRewardLayout(bool playGridAnimForListB = false)
		{
			LinkageRewardActivitySubView.<>c__DisplayClass30_0 CS$<>8__locals1 = new LinkageRewardActivitySubView.<>c__DisplayClass30_0();
			CS$<>8__locals1.<>4__this = this;
			List<TimePointRewardData> keepRewardDataList = this.LinkageRewardData.GetKeepRewardDataList();
			CS$<>8__locals1.normalRewardList = this.LinkageRewardData.GetRewardDataList();
			this.RefreshKeepRewardPanel(this.RewardItemA1, (keepRewardDataList.Count > 0) ? keepRewardDataList[0] : null, 0);
			this.RefreshKeepRewardPanel(this.RewardItemA2, (keepRewardDataList.Count > 1) ? keepRewardDataList[1] : null, 1);
			this.RefreshKeepRewardPanel(this.RewardItemA3, (keepRewardDataList.Count > 2) ? keepRewardDataList[2] : null, 2);
			LinkageRewardActivitySubView.<>c__DisplayClass30_0 CS$<>8__locals2 = CS$<>8__locals1;
			int num = this.AutoScrollRewardItemBRequestId + 1;
			this.AutoScrollRewardItemBRequestId = num;
			CS$<>8__locals2.requestId = num;
			GenericLayout<LinkageRewardRewardItem, TimePointRewardData> rewardItemBLayout = this.RewardItemBLayout;
			if (rewardItemBLayout != null)
			{
				rewardItemBLayout.RefreshByData(CS$<>8__locals1.normalRewardList, delegate
				{
					if (CS$<>8__locals1.requestId != CS$<>8__locals1.<>4__this.AutoScrollRewardItemBRequestId)
					{
						return;
					}
					int num2 = CS$<>8__locals1.<>4__this.FindPreferredRewardIndex(CS$<>8__locals1.normalRewardList);
					CS$<>8__locals1.<>4__this.PendingFocusRewardIndex = num2;
					CS$<>8__locals1.<>4__this.TryAutoScrollRewardItemB(num2);
					CS$<>8__locals1.<>4__this.ScheduleApplyPendingFocus(CS$<>8__locals1.normalRewardList.Count);
				}, playGridAnimForListB);
			}
			LinkageRewardProgressPanel progressPanel = this.ProgressPanel;
			if (progressPanel == null)
			{
				return;
			}
			progressPanel.Refresh(keepRewardDataList, this.LinkageRewardData.GetCurrentCheckInDay());
		}

		// Token: 0x06035CDB RID: 220379 RVA: 0x00F07E94 File Offset: 0x00F06094
		[NullableContext(1)]
		private void CacheRewardItemBScrollView(UUIHorizontalLayout contentLayout)
		{
			AUIBaseActor auibaseActor = contentLayout.GetOwner() as AUIBaseActor;
			UUIScrollViewWithScrollbarComponent uuiscrollViewWithScrollbarComponent = ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) : null) as UUIScrollViewWithScrollbarComponent;
			if (uuiscrollViewWithScrollbarComponent != null)
			{
				this.RewardItemBScrollView = uuiscrollViewWithScrollbarComponent;
				return;
			}
			UUIItem uuiitem = contentLayout.RootUIComp.Get();
			for (UUIItem uuiitem2 = (uuiitem != null) ? uuiitem.GetParentAsUIItem() : null; uuiitem2 != null; uuiitem2 = uuiitem2.GetParentAsUIItem())
			{
				AUIBaseActor auibaseActor2 = uuiitem2.GetOwner() as AUIBaseActor;
				UUIScrollViewWithScrollbarComponent uuiscrollViewWithScrollbarComponent2 = ((auibaseActor2 != null) ? auibaseActor2.GetComponentByClass(UUIScrollViewWithScrollbarComponent.StaticClass()) : null) as UUIScrollViewWithScrollbarComponent;
				if (uuiscrollViewWithScrollbarComponent2 != null)
				{
					this.RewardItemBScrollView = uuiscrollViewWithScrollbarComponent2;
					return;
				}
			}
		}

		// Token: 0x06035CDC RID: 220380 RVA: 0x00F07F2C File Offset: 0x00F0612C
		private void TryAutoScrollRewardItemB(int targetIndex)
		{
			if (this.HasAutoScrolledRewardItemB || targetIndex < 0)
			{
				return;
			}
			this.HasAutoScrolledRewardItemB = true;
			UUIScrollViewWithScrollbarComponent rewardItemBScrollView = this.RewardItemBScrollView;
			if (rewardItemBScrollView == null || !rewardItemBScrollView.IsValid())
			{
				return;
			}
			GenericLayout<LinkageRewardRewardItem, TimePointRewardData> rewardItemBLayout = this.RewardItemBLayout;
			UUIItem uuiitem = (rewardItemBLayout != null) ? rewardItemBLayout.GetItemByIndex(targetIndex) : null;
			if (uuiitem != null && uuiitem.IsValid())
			{
				rewardItemBScrollView.ScrollToLeftLater(uuiitem, false);
			}
		}

		// Token: 0x06035CDD RID: 220381 RVA: 0x00F07F87 File Offset: 0x00F06187
		[NullableContext(1)]
		private LinkageRewardRewardItem InitRewardItemB()
		{
			return new LinkageRewardRewardItem
			{
				OnClickToGet = new Action<int, int, bool>(this.OnGetReward)
			};
		}

		// Token: 0x06035CDE RID: 220382 RVA: 0x00F07FA0 File Offset: 0x00F061A0
		[NullableContext(1)]
		private int FindPreferredRewardIndex(List<TimePointRewardData> normalRewardList)
		{
			for (int i = 0; i < normalRewardList.Count; i++)
			{
				if (normalRewardList[i].RewardState == ETimePointRewardState.UnlockAndUnClaimed)
				{
					return i;
				}
			}
			int num = normalRewardList.FindIndex((TimePointRewardData data) => data.RewardState == ETimePointRewardState.Lock);
			if (num >= 0)
			{
				return num;
			}
			for (int j = normalRewardList.Count - 1; j >= 0; j--)
			{
				if (normalRewardList[j].RewardState == ETimePointRewardState.UnlockAndClaimed)
				{
					return j;
				}
			}
			return 0;
		}

		// Token: 0x06035CDF RID: 220383 RVA: 0x00F08020 File Offset: 0x00F06220
		private bool TryAlignGamepadEntryFocus(int targetIndex, int totalCount)
		{
			if (!Info.Instance.IsInGamepad() || totalCount <= 0 || targetIndex < 0)
			{
				return false;
			}
			if (!this.CanApplyGamepadFocus)
			{
				return false;
			}
			UUIItem uuiitem = this.FindFocusTargetRewardItem(targetIndex, totalCount);
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return false;
			}
			AActor owner = uuiitem.GetOwner();
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener = ((owner != null) ? owner.GetComponentByClass(TsUiNavigationBehaviorListener.StaticClass()) : null) as TsUiNavigationBehaviorListener;
			if (tsUiNavigationBehaviorListener == null)
			{
				return false;
			}
			GenericLayout<LinkageRewardRewardItem, TimePointRewardData> rewardItemBLayout = this.RewardItemBLayout;
			UUIItem uuiitem2 = (rewardItemBLayout != null) ? rewardItemBLayout.GetItemByIndex(targetIndex) : null;
			if (uuiitem2 != null && uuiitem2.IsValid())
			{
				UUIScrollViewWithScrollbarComponent rewardItemBScrollView = this.RewardItemBScrollView;
				if (rewardItemBScrollView != null)
				{
					rewardItemBScrollView.ScrollToLeftLater(uuiitem2, false);
				}
			}
			UiNavigationNewController instance = UiNavigationNewController.Instance;
			TsUiNavigationBehaviorListener tsUiNavigationBehaviorListener2 = (instance != null) ? instance.GetCurrentNavigationFocusListener() : null;
			if (tsUiNavigationBehaviorListener2 != null && tsUiNavigationBehaviorListener2.GroupName != tsUiNavigationBehaviorListener.GroupName)
			{
				return false;
			}
			UiNavigationNewController instance2 = UiNavigationNewController.Instance;
			if (instance2 != null)
			{
				instance2.SetNavigationFocusForView(uuiitem, true, false, false);
			}
			return true;
		}

		// Token: 0x06035CE0 RID: 220384 RVA: 0x00F080FC File Offset: 0x00F062FC
		private void ScheduleApplyPendingFocus(int totalCount)
		{
			if (!Info.Instance.IsInGamepad() || totalCount <= 0)
			{
				return;
			}
			if (!this.CanApplyGamepadFocus)
			{
				return;
			}
			int num = this.PendingFocusRequestId + 1;
			this.PendingFocusRequestId = num;
			int requestId = num;
			this.TryApplyPendingFocusWithRetry(requestId, totalCount, 600);
		}

		// Token: 0x06035CE1 RID: 220385 RVA: 0x00F08144 File Offset: 0x00F06344
		private void TryApplyPendingFocusWithRetry(int requestId, int totalCount, int remainRetryCount)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (requestId != this.PendingFocusRequestId || !this.IsUiActiveInHierarchy())
				{
					return;
				}
				if (this.TryAlignGamepadEntryFocus(this.PendingFocusRewardIndex, totalCount))
				{
					return;
				}
				if (remainRetryCount <= 0 || !this.IsUiActiveInHierarchy())
				{
					return;
				}
				this.TryApplyPendingFocusWithRetry(requestId, totalCount, remainRetryCount - 1);
			}, null, null);
		}

		// Token: 0x06035CE2 RID: 220386 RVA: 0x00F0818C File Offset: 0x00F0638C
		private UUIItem FindFocusTargetRewardItem(int index, int totalCount)
		{
			GenericLayout<LinkageRewardRewardItem, TimePointRewardData> rewardItemBLayout = this.RewardItemBLayout;
			LinkageRewardRewardItem linkageRewardRewardItem = (rewardItemBLayout != null) ? rewardItemBLayout.GetLayoutItemByIndex(index) : null;
			UUIItem uuiitem = (linkageRewardRewardItem != null) ? linkageRewardRewardItem.GetNavigationFocusItem() : null;
			if (uuiitem == null || !uuiitem.IsValid())
			{
				return null;
			}
			return uuiitem;
		}

		// Token: 0x06035CE3 RID: 220387 RVA: 0x00F081C8 File Offset: 0x00F063C8
		private void RefreshKeepRewardPanel(LinkageRewardRewardItemA panel, TimePointRewardData data, int gridIndex)
		{
			if (panel == null)
			{
				return;
			}
			if (data == null)
			{
				panel.SetUiActive(false);
				return;
			}
			panel.SetUiActive(true);
			bool hasConnector = gridIndex > 0;
			panel.RefreshWithNextState(data, false, gridIndex, hasConnector);
		}

		// Token: 0x06035CE4 RID: 220388 RVA: 0x00F081FC File Offset: 0x00F063FC
		private void OnGetReward(int id, int gridIndex, bool isKeepReward)
		{
			LinkageCheckInType fallbackType = isKeepReward ? LinkageCheckInType.KeepCheckIn : LinkageCheckInType.NormalCheckIn;
			LinkageRewardActivityController.ClaimAllRewardsByController(this.LinkageRewardData.Id, id, fallbackType, delegate
			{
				this.RefreshRewardLayout(false);
			});
		}

		// Token: 0x0401C77B RID: 116603
		private const int FocusRetryMaxCount = 600;

		// Token: 0x0401C77C RID: 116604
		private LinkageRewardActivityData LinkageRewardData;

		// Token: 0x0401C77D RID: 116605
		private LinkageRewardActivityTitle TitleComponent;

		// Token: 0x0401C77E RID: 116606
		private LinkageRewardRewardItemA RewardItemA1;

		// Token: 0x0401C77F RID: 116607
		private LinkageRewardRewardItemA RewardItemA2;

		// Token: 0x0401C780 RID: 116608
		private LinkageRewardRewardItemA RewardItemA3;

		// Token: 0x0401C781 RID: 116609
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LinkageRewardRewardItem, TimePointRewardData> RewardItemBLayout;

		// Token: 0x0401C782 RID: 116610
		private UUIScrollViewWithScrollbarComponent RewardItemBScrollView;

		// Token: 0x0401C783 RID: 116611
		private LinkageRewardProgressPanel ProgressPanel;

		// Token: 0x0401C784 RID: 116612
		private bool HasAutoScrolledRewardItemB;

		// Token: 0x0401C785 RID: 116613
		private int AutoScrollRewardItemBRequestId;

		// Token: 0x0401C786 RID: 116614
		private bool HasPendingRefreshRewardLayout;

		// Token: 0x0401C787 RID: 116615
		private int PendingFocusRewardIndex = -1;

		// Token: 0x0401C788 RID: 116616
		private int PendingFocusRequestId;

		// Token: 0x0401C789 RID: 116617
		private bool CanApplyGamepadFocus = true;

		// Token: 0x0200B12A RID: 45354
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04036C9D RID: 224413
			public const int TitleItem = 0;

			// Token: 0x04036C9E RID: 224414
			public const int RewardItemA1 = 1;

			// Token: 0x04036C9F RID: 224415
			public const int RewardItemA2 = 2;

			// Token: 0x04036CA0 RID: 224416
			public const int RewardItemA3 = 3;

			// Token: 0x04036CA1 RID: 224417
			public const int Progress = 4;

			// Token: 0x04036CA2 RID: 224418
			public const int Content = 5;

			// Token: 0x04036CA3 RID: 224419
			public const int RewardItemB = 6;
		}
	}
}
