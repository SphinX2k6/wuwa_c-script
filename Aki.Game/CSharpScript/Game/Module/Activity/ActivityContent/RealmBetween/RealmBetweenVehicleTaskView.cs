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

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006299 RID: 25241
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenVehicleTaskView : UiViewBase
	{
		// Token: 0x0603F7FC RID: 260092 RVA: 0x00F5A43D File Offset: 0x00F5863D
		public RealmBetweenVehicleTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603F7FD RID: 260093 RVA: 0x00F5A450 File Offset: 0x00F58650
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
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
		}

		// Token: 0x0603F7FE RID: 260094 RVA: 0x00F5A530 File Offset: 0x00F58730
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenVehicleTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenVehicleTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603F7FF RID: 260095 RVA: 0x00F5A573 File Offset: 0x00F58773
		protected override void OnStart()
		{
			this.RefreshTabList(delegate
			{
				MenuTabToggleItem scrollItemByIndex = this.MenuScroll.GetScrollItemByIndex(0);
				if (scrollItemByIndex == null)
				{
					return;
				}
				scrollItemByIndex.SetIsSelect(true, true);
			});
		}

		// Token: 0x0603F800 RID: 260096 RVA: 0x00F5A587 File Offset: 0x00F58787
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RealmBetweenMotorRefresh, new Action(this.OnMotorRefresh));
		}

		// Token: 0x0603F801 RID: 260097 RVA: 0x00F5A5A5 File Offset: 0x00F587A5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RealmBetweenMotorRefresh, new Action(this.OnMotorRefresh));
		}

		// Token: 0x0603F802 RID: 260098 RVA: 0x00F5A5C4 File Offset: 0x00F587C4
		private void OnMotorRefresh()
		{
			List<MotorChallengePlayData> allMotorTabData = this.ActivityBaseData.GetAllMotorTabData();
			MotorChallengePlayData motorChallengePlayData = (this.SelectedTabIndex >= 0 && this.SelectedTabIndex < allMotorTabData.Count) ? allMotorTabData[this.SelectedTabIndex] : null;
			this.RefreshTabList(null);
			if (motorChallengePlayData != null)
			{
				this.RefreshContent(motorChallengePlayData);
			}
		}

		// Token: 0x0603F803 RID: 260099 RVA: 0x00F5A615 File Offset: 0x00F58815
		private MenuTabToggleItem OnCreateMenuItem()
		{
			return new MenuTabToggleItem
			{
				OnChildToggleCallback = new Action<MotorChallengePlayData, MenuTabToggleItem>(this.OnClickChildToggle)
			};
		}

		// Token: 0x0603F804 RID: 260100 RVA: 0x00F5A62E File Offset: 0x00F5882E
		private MissionToggleItem OnCreateTaskItem()
		{
			MissionToggleItem missionToggleItem = new MissionToggleItem();
			missionToggleItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return missionToggleItem;
		}

		// Token: 0x0603F805 RID: 260101 RVA: 0x00F5A648 File Offset: 0x00F58848
		private void OnClickRewardCb()
		{
			List<MotorChallengePlayData> allMotorTabData = this.ActivityBaseData.GetAllMotorTabData();
			if (this.SelectedTabIndex < 0 || this.SelectedTabIndex >= allMotorTabData.Count)
			{
				return;
			}
			MotorChallengePlayData motorChallengePlayData = allMotorTabData[this.SelectedTabIndex];
			List<int> list = new List<int>();
			foreach (ActivityTaskData activityTaskData in this.ActivityBaseData.GetMotorItemDataList(motorChallengePlayData.RewardIds))
			{
				if (activityTaskData.Status == EActivityTaskState.FinishedAndUnclaimed)
				{
					list.Add(activityTaskData.Id);
				}
			}
			ActivityRealmBetweenController.Instance.RequestMultiMotorChallengeReward(list.ToArray());
		}

		// Token: 0x0603F806 RID: 260102 RVA: 0x00F5A700 File Offset: 0x00F58900
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
			if (tabData.IsUnlock && !this.ActivityBaseData.SaveFirstCheckRedDotState(ERealmBetweenSaveFlag.MotorChallengeNewUnlock, tabData.TabIndex))
			{
				tabItem.SetItemNewVisible(false);
			}
			this.RefreshContent(tabData);
		}

		// Token: 0x0603F807 RID: 260103 RVA: 0x00F5A77C File Offset: 0x00F5897C
		[NullableContext(2)]
		private void RefreshTabList(Action onComplete = null)
		{
			List<MotorChallengePlayData> list = new List<MotorChallengePlayData>(this.ActivityBaseData.GetAllMotorTabData());
			list.Sort(delegate(MotorChallengePlayData a, MotorChallengePlayData b)
			{
				if (a.IsFinished == b.IsFinished)
				{
					return a.TabIndex - b.TabIndex;
				}
				if (!a.IsFinished)
				{
					return -1;
				}
				return 1;
			});
			this.MenuScroll.RefreshByData(list, onComplete, false);
		}

		// Token: 0x0603F808 RID: 260104 RVA: 0x00F5A7D0 File Offset: 0x00F589D0
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

		// Token: 0x0603F809 RID: 260105 RVA: 0x00F5A860 File Offset: 0x00F58A60
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

		// Token: 0x0603F80A RID: 260106 RVA: 0x00F5A8D0 File Offset: 0x00F58AD0
		private void OnClickHelpBtn()
		{
			if (this.ActivityBaseData.LocalConfig != null)
			{
				HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
			}
		}

		// Token: 0x0402132C RID: 135980
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0402132D RID: 135981
		private ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0402132E RID: 135982
		private GenericScrollViewNew<MenuTabToggleItem, MotorChallengePlayData> MenuScroll;

		// Token: 0x0402132F RID: 135983
		private GenericScrollViewNew<MissionToggleItem, ActivityTaskData> TaskScroll;

		// Token: 0x04021330 RID: 135984
		private int SelectedTabIndex = -1;

		// Token: 0x04021331 RID: 135985
		[Nullable(2)]
		private MenuTabToggleItem SelectChildToggle;

		// Token: 0x04021332 RID: 135986
		private ActivityButtonItem BtnJump;
	}
}
