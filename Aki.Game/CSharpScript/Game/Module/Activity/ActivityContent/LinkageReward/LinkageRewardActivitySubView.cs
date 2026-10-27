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
	// Token: 0x02006555 RID: 25941
	[NullableContext(2)]
	[Nullable(0)]
	public class LinkageRewardActivitySubView : ActivitySubViewBase
	{
		// Token: 0x06041007 RID: 266247 RVA: 0x00FC0A44 File Offset: 0x00FBEC44
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

		// Token: 0x06041008 RID: 266248 RVA: 0x00FC0B52 File Offset: 0x00FBED52
		protected override void OnSetData()
		{
			this.LinkageRewardData = (this.ActivityBaseData as LinkageRewardActivityData);
		}

		// Token: 0x06041009 RID: 266249 RVA: 0x00FC0B68 File Offset: 0x00FBED68
		protected override UniTask OnBeforeStartAsync()
		{
			LinkageRewardActivitySubView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<LinkageRewardActivitySubView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604100A RID: 266250 RVA: 0x00FC0BAC File Offset: 0x00FBEDAC
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

		// Token: 0x0604100B RID: 266251 RVA: 0x00FC0C49 File Offset: 0x00FBEE49
		protected override void OnRefreshView()
		{
			EventSystem.Instance.Emit<int>(EEventName.RefreshActivityTab, this.ActivityBaseData.Id);
		}

		// Token: 0x0604100C RID: 266252 RVA: 0x00FC0C66 File Offset: 0x00FBEE66
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0604100D RID: 266253 RVA: 0x00FC0C84 File Offset: 0x00FBEE84
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnRefreshCommonActivityRedDot));
		}

		// Token: 0x0604100E RID: 266254 RVA: 0x00FC0CA4 File Offset: 0x00FBEEA4
		protected override UniTask OnBeforeShowSelfAsync()
		{
			LinkageRewardActivitySubView.<OnBeforeShowSelfAsync>d__23 <OnBeforeShowSelfAsync>d__;
			<OnBeforeShowSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowSelfAsync>d__.<>4__this = this;
			<OnBeforeShowSelfAsync>d__.<>1__state = -1;
			<OnBeforeShowSelfAsync>d__.<>t__builder.Start<LinkageRewardActivitySubView.<OnBeforeShowSelfAsync>d__23>(ref <OnBeforeShowSelfAsync>d__);
			return <OnBeforeShowSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604100F RID: 266255 RVA: 0x00FC0CE7 File Offset: 0x00FBEEE7
		public override void SetActive(bool visibility)
		{
			if (!visibility)
			{
				this.PendingFocusRequestId++;
			}
			base.SetActive(visibility);
		}

		// Token: 0x06041010 RID: 266256 RVA: 0x00FC0D01 File Offset: 0x00FBEF01
		public override void OnCommonViewStateChange(bool show)
		{
			this.CanApplyGamepadFocus = !show;
			if (this.CanApplyGamepadFocus && this.PendingFocusRewardIndex >= 0)
			{
				this.ScheduleApplyPendingFocus(this.LinkageRewardData.GetRewardDataList().Count);
			}
		}

		// Token: 0x06041011 RID: 266257 RVA: 0x00FC0D34 File Offset: 0x00FBEF34
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x06041012 RID: 266258 RVA: 0x00FC0D3C File Offset: 0x00FBEF3C
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

		// Token: 0x06041013 RID: 266259 RVA: 0x00FC0D77 File Offset: 0x00FBEF77
		private void OnRefreshCommonActivityRedDot(int id)
		{
			if (this.ActivityBaseData.Id != id)
			{
				return;
			}
			this.ScheduleRefreshRewardLayout();
		}

		// Token: 0x06041014 RID: 266260 RVA: 0x00FC0D8E File Offset: 0x00FBEF8E
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

		// Token: 0x06041015 RID: 266261 RVA: 0x00FC0DBC File Offset: 0x00FBEFBC
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

		// Token: 0x06041016 RID: 266262 RVA: 0x00FC0EAC File Offset: 0x00FBF0AC
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

		// Token: 0x06041017 RID: 266263 RVA: 0x00FC0F44 File Offset: 0x00FBF144
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

		// Token: 0x06041018 RID: 266264 RVA: 0x00FC0F9F File Offset: 0x00FBF19F
		[NullableContext(1)]
		private LinkageRewardRewardItem InitRewardItemB()
		{
			return new LinkageRewardRewardItem
			{
				OnClickToGet = new Action<int, int, bool>(this.OnGetReward)
			};
		}

		// Token: 0x06041019 RID: 266265 RVA: 0x00FC0FB8 File Offset: 0x00FBF1B8
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

		// Token: 0x0604101A RID: 266266 RVA: 0x00FC1038 File Offset: 0x00FBF238
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

		// Token: 0x0604101B RID: 266267 RVA: 0x00FC1114 File Offset: 0x00FBF314
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

		// Token: 0x0604101C RID: 266268 RVA: 0x00FC115C File Offset: 0x00FBF35C
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

		// Token: 0x0604101D RID: 266269 RVA: 0x00FC11A4 File Offset: 0x00FBF3A4
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

		// Token: 0x0604101E RID: 266270 RVA: 0x00FC11E0 File Offset: 0x00FBF3E0
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

		// Token: 0x0604101F RID: 266271 RVA: 0x00FC1214 File Offset: 0x00FBF414
		private void OnGetReward(int id, int gridIndex, bool isKeepReward)
		{
			LinkageCheckInType fallbackType = isKeepReward ? LinkageCheckInType.KeepCheckIn : LinkageCheckInType.NormalCheckIn;
			LinkageRewardActivityController.ClaimAllRewardsByController(this.LinkageRewardData.Id, id, fallbackType, delegate
			{
				this.RefreshRewardLayout(false);
			});
		}

		// Token: 0x04021E4A RID: 138826
		private const int FocusRetryMaxCount = 600;

		// Token: 0x04021E4B RID: 138827
		private LinkageRewardActivityData LinkageRewardData;

		// Token: 0x04021E4C RID: 138828
		private LinkageRewardActivityTitle TitleComponent;

		// Token: 0x04021E4D RID: 138829
		private LinkageRewardRewardItemA RewardItemA1;

		// Token: 0x04021E4E RID: 138830
		private LinkageRewardRewardItemA RewardItemA2;

		// Token: 0x04021E4F RID: 138831
		private LinkageRewardRewardItemA RewardItemA3;

		// Token: 0x04021E50 RID: 138832
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<LinkageRewardRewardItem, TimePointRewardData> RewardItemBLayout;

		// Token: 0x04021E51 RID: 138833
		private UUIScrollViewWithScrollbarComponent RewardItemBScrollView;

		// Token: 0x04021E52 RID: 138834
		private LinkageRewardProgressPanel ProgressPanel;

		// Token: 0x04021E53 RID: 138835
		private bool HasAutoScrolledRewardItemB;

		// Token: 0x04021E54 RID: 138836
		private int AutoScrollRewardItemBRequestId;

		// Token: 0x04021E55 RID: 138837
		private bool HasPendingRefreshRewardLayout;

		// Token: 0x04021E56 RID: 138838
		private int PendingFocusRewardIndex = -1;

		// Token: 0x04021E57 RID: 138839
		private int PendingFocusRequestId;

		// Token: 0x04021E58 RID: 138840
		private bool CanApplyGamepadFocus = true;

		// Token: 0x0200C745 RID: 51013
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403C34B RID: 246603
			public const int TitleItem = 0;

			// Token: 0x0403C34C RID: 246604
			public const int RewardItemA1 = 1;

			// Token: 0x0403C34D RID: 246605
			public const int RewardItemA2 = 2;

			// Token: 0x0403C34E RID: 246606
			public const int RewardItemA3 = 3;

			// Token: 0x0403C34F RID: 246607
			public const int Progress = 4;

			// Token: 0x0403C350 RID: 246608
			public const int Content = 5;

			// Token: 0x0403C351 RID: 246609
			public const int RewardItemB = 6;
		}
	}
}
