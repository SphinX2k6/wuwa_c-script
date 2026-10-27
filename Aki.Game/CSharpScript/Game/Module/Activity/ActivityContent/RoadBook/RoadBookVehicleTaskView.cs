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
	// Token: 0x020061F9 RID: 25081
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookVehicleTaskView : UiViewBase
	{
		// Token: 0x0603F486 RID: 259206 RVA: 0x00F4AC58 File Offset: 0x00F48E58
		public RoadBookVehicleTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F487 RID: 259207 RVA: 0x00F4AC68 File Offset: 0x00F48E68
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

		// Token: 0x0603F488 RID: 259208 RVA: 0x00F4AD6C File Offset: 0x00F48F6C
		protected override UniTask OnBeforeStartAsync()
		{
			RoadBookVehicleTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoadBookVehicleTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F489 RID: 259209 RVA: 0x00F4ADAF File Offset: 0x00F48FAF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RoadBookMotorRefresh, new Action(this.OnRoadBookMotorRefresh));
		}

		// Token: 0x0603F48A RID: 259210 RVA: 0x00F4ADCD File Offset: 0x00F48FCD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RoadBookMotorRefresh, new Action(this.OnRoadBookMotorRefresh));
		}

		// Token: 0x0603F48B RID: 259211 RVA: 0x00F4ADEC File Offset: 0x00F48FEC
		private void OnRoadBookMotorRefresh()
		{
			MotorChallengePlayData tabData = this.ActivityBaseData.GetAllMotorTabData()[this.SelectedTabIndex];
			this.RefreshTabGroup().Forget();
			this.RefreshContent(tabData);
		}

		// Token: 0x0603F48C RID: 259212 RVA: 0x00F4AE22 File Offset: 0x00F49022
		private TabGroupGridItem OnCreateMenuItem()
		{
			return new TabGroupGridItem
			{
				OnChildToggleCallback = new Action<MotorChallengePlayData, MenuTabToggleItem>(this.OnClickChildToggle)
			};
		}

		// Token: 0x0603F48D RID: 259213 RVA: 0x00F4AE3B File Offset: 0x00F4903B
		private MotorChallengeItem OnCreateTaskItem()
		{
			MotorChallengeItem motorChallengeItem = new MotorChallengeItem(this.ActivityBaseData);
			motorChallengeItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return motorChallengeItem;
		}

		// Token: 0x0603F48E RID: 259214 RVA: 0x00F4AE5C File Offset: 0x00F4905C
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

		// Token: 0x0603F48F RID: 259215 RVA: 0x00F4AEF4 File Offset: 0x00F490F4
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

		// Token: 0x0603F490 RID: 259216 RVA: 0x00F4AF70 File Offset: 0x00F49170
		private UniTask RefreshTabGroup()
		{
			RoadBookVehicleTaskView.<RefreshTabGroup>d__17 <RefreshTabGroup>d__;
			<RefreshTabGroup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshTabGroup>d__.<>4__this = this;
			<RefreshTabGroup>d__.<>1__state = -1;
			<RefreshTabGroup>d__.<>t__builder.Start<RoadBookVehicleTaskView.<RefreshTabGroup>d__17>(ref <RefreshTabGroup>d__);
			return <RefreshTabGroup>d__.<>t__builder.Task;
		}

		// Token: 0x0603F491 RID: 259217 RVA: 0x00F4AFB4 File Offset: 0x00F491B4
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

		// Token: 0x0603F492 RID: 259218 RVA: 0x00F4B044 File Offset: 0x00F49244
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

		// Token: 0x0603F493 RID: 259219 RVA: 0x00F4B0B4 File Offset: 0x00F492B4
		private void OnClickHelpBtn()
		{
			HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
		}

		// Token: 0x0402102B RID: 135211
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0402102C RID: 135212
		private ActivityRoadBookData ActivityBaseData;

		// Token: 0x0402102D RID: 135213
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0402102E RID: 135214
		private GenericScrollViewNew<TabGroupGridItem, ITabGroupData> MenuScroll;

		// Token: 0x0402102F RID: 135215
		private GenericScrollViewNew<MotorChallengeItem, ActivityTaskData> TaskScroll;

		// Token: 0x04021030 RID: 135216
		private int SelectedTabIndex = -1;

		// Token: 0x04021031 RID: 135217
		[Nullable(2)]
		private MenuTabToggleItem SelectChildToggle;
	}
}
