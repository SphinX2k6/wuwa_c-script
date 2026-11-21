using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.SkipInterface;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005177 RID: 20855
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookVehicleTaskView : UiViewBase
	{
		// Token: 0x06034147 RID: 213319 RVA: 0x00E91BB0 File Offset: 0x00E8FDB0
		public RoadBookVehicleTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06034148 RID: 213320 RVA: 0x00E91BC0 File Offset: 0x00E8FDC0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickBtnJump))
			};
		}

		// Token: 0x06034149 RID: 213321 RVA: 0x00E91CC4 File Offset: 0x00E8FEC4
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookVehicleTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookVehicleTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603414A RID: 213322 RVA: 0x00E91D07 File Offset: 0x00E8FF07
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoadBookMotorRefresh, new Action(this.OnRoadBookMotorRefresh));
		}

		// Token: 0x0603414B RID: 213323 RVA: 0x00E91D25 File Offset: 0x00E8FF25
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoadBookMotorRefresh, new Action(this.OnRoadBookMotorRefresh));
		}

		// Token: 0x0603414C RID: 213324 RVA: 0x00E91D44 File Offset: 0x00E8FF44
		private void OnRoadBookMotorRefresh()
		{
			MotorChallengePlayData tabData = this.ActivityBaseData.GetAllMotorTabData()[this.SelectedTabIndex];
			this.RefreshTabGroup().Forget();
			this.RefreshContent(tabData);
		}

		// Token: 0x0603414D RID: 213325 RVA: 0x00E91D7A File Offset: 0x00E8FF7A
		private TabGroupGridItem OnCreateMenuItem()
		{
			return new TabGroupGridItem
			{
				OnChildToggleCallback = new Action<MotorChallengePlayData, MenuTabToggleItem>(this.OnClickChildToggle)
			};
		}

		// Token: 0x0603414E RID: 213326 RVA: 0x00E91D93 File Offset: 0x00E8FF93
		private MotorChallengeItem OnCreateTaskItem()
		{
			MotorChallengeItem motorChallengeItem = new MotorChallengeItem(this.ActivityBaseData);
			motorChallengeItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return motorChallengeItem;
		}

		// Token: 0x0603414F RID: 213327 RVA: 0x00E91DB4 File Offset: 0x00E8FFB4
		private void OnClickRewardCb()
		{
			MotorChallengePlayData motorChallengePlayData = this.ActivityBaseData.GetAllMotorTabData()[this.SelectedTabIndex];
			List<int> list = new List<int>();
			foreach (ActivityTaskData activityTaskData in this.ActivityBaseData.GetMotorItemDataList(motorChallengePlayData.RewardIds))
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			ActivityRoadBookController.Instance.RequestMultiTakeMotorChallengeReward(list.ToArray());
		}

		// Token: 0x06034150 RID: 213328 RVA: 0x00E91E4C File Offset: 0x00E9004C
		private void OnClickChildToggle(MotorChallengePlayData tabData, MenuTabToggleItem tabItem)
		{
			if (this.SelectChildToggle != null)
			{
				this.SelectChildToggle.SetIsSelect(false, false);
			}
			this.SelectChildToggle = tabItem;
			this.SelectChildToggle.SetIsSelect(true, false);
			if (this.SelectedTabIndex == tabData.TabIndex)
			{
				return;
			}
			this.SelectedTabIndex = tabData.TabIndex;
			if (tabData.IsUnlock && !this.ActivityBaseData.SaveFirstCheckRedDotState(ERoadBookSaveFlag.MotorChallengeNewUnlock, tabData.TabIndex))
			{
				tabItem.SetItemNewVisible(false);
			}
			this.RefreshContent(tabData);
		}

		// Token: 0x06034151 RID: 213329 RVA: 0x00E91EC8 File Offset: 0x00E900C8
		private UniTask RefreshTabGroup()
		{
			RoadBookVehicleTaskView.<RefreshTabGroup>d__17 <RefreshTabGroup>d__;
			<RefreshTabGroup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabGroup>d__.<>4__this = this;
			<RefreshTabGroup>d__.<>1__state = -1;
			<RefreshTabGroup>d__.<>t__builder.Start<RoadBookVehicleTaskView.<RefreshTabGroup>d__17>(ref <RefreshTabGroup>d__);
			return <RefreshTabGroup>d__.<>t__builder.Task;
		}

		// Token: 0x06034152 RID: 213330 RVA: 0x00E91F0C File Offset: 0x00E9010C
		private void RefreshContent(MotorChallengePlayData tabData)
		{
			bool isUnlock = tabData.IsUnlock;
			List<ActivityTaskData> data = isUnlock ? this.ActivityBaseData.GetMotorItemDataList(tabData.RewardIds) : new List<ActivityTaskData>();
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!isUnlock);
			}
			if (!isUnlock)
			{
				UUIText text = base.GetText(6);
				if (text != null)
				{
					text.ShowTextNew(this.ActivityBaseData.GetMotorPlayLockTips(tabData.PlayId));
				}
			}
			UUIItem item2 = base.GetItem(7);
			if (item2 != null)
			{
				item2.SetUIActive(isUnlock);
			}
			this.TaskScroll.RefreshByData(data, null, true);
		}

		// Token: 0x06034153 RID: 213331 RVA: 0x00E91F9C File Offset: 0x00E9019C
		private void OnClickBtnJump()
		{
			foreach (MotorChallengePlayData motorChallengePlayData in this.ActivityBaseData.GetAllMotorTabData())
			{
				if (motorChallengePlayData.TabIndex == this.SelectedTabIndex)
				{
					SkipTaskManager.RunByConfigId(motorChallengePlayData.JumpId, null);
					break;
				}
			}
		}

		// Token: 0x06034154 RID: 213332 RVA: 0x00E9200C File Offset: 0x00E9020C
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0401B95A RID: 112986
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401B95B RID: 112987
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x0401B95C RID: 112988
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401B95D RID: 112989
		private GenericScrollViewNew<TabGroupGridItem, ITabGroupData> MenuScroll;

		// Token: 0x0401B95E RID: 112990
		private GenericScrollViewNew<MotorChallengeItem, ActivityTaskData> TaskScroll;

		// Token: 0x0401B95F RID: 112991
		private int SelectedTabIndex = -1;

		// Token: 0x0401B960 RID: 112992
		[Nullable(2)]
		private MenuTabToggleItem SelectChildToggle;
	}
}
