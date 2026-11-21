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
	// Token: 0x02005217 RID: 21015
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenVehicleTaskView : UiViewBase
	{
		// Token: 0x060344BD RID: 214205 RVA: 0x00EA1399 File Offset: 0x00E9F599
		public RealmBetweenVehicleTaskView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060344BE RID: 214206 RVA: 0x00EA13AC File Offset: 0x00E9F5AC
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

		// Token: 0x060344BF RID: 214207 RVA: 0x00EA148C File Offset: 0x00E9F68C
		protected override UniTask OnBeforeStartAsync()
		{
			RealmBetweenVehicleTaskView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RealmBetweenVehicleTaskView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060344C0 RID: 214208 RVA: 0x00EA14CF File Offset: 0x00E9F6CF
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

		// Token: 0x060344C1 RID: 214209 RVA: 0x00EA14E3 File Offset: 0x00E9F6E3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.RealmBetweenMotorRefresh, new Action(this.OnMotorRefresh));
		}

		// Token: 0x060344C2 RID: 214210 RVA: 0x00EA1501 File Offset: 0x00E9F701
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.RealmBetweenMotorRefresh, new Action(this.OnMotorRefresh));
		}

		// Token: 0x060344C3 RID: 214211 RVA: 0x00EA1520 File Offset: 0x00E9F720
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

		// Token: 0x060344C4 RID: 214212 RVA: 0x00EA1571 File Offset: 0x00E9F771
		private MenuTabToggleItem OnCreateMenuItem()
		{
			return new MenuTabToggleItem
			{
				OnChildToggleCallback = new Action<MotorChallengePlayData, MenuTabToggleItem>(this.OnClickChildToggle)
			};
		}

		// Token: 0x060344C5 RID: 214213 RVA: 0x00EA158A File Offset: 0x00E9F78A
		private MissionToggleItem OnCreateTaskItem()
		{
			MissionToggleItem missionToggleItem = new MissionToggleItem();
			missionToggleItem.SetClickRewardCb(new Action(this.OnClickRewardCb));
			return missionToggleItem;
		}

		// Token: 0x060344C6 RID: 214214 RVA: 0x00EA15A4 File Offset: 0x00E9F7A4
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

		// Token: 0x060344C7 RID: 214215 RVA: 0x00EA165C File Offset: 0x00E9F85C
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

		// Token: 0x060344C8 RID: 214216 RVA: 0x00EA16D8 File Offset: 0x00E9F8D8
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

		// Token: 0x060344C9 RID: 214217 RVA: 0x00EA172C File Offset: 0x00E9F92C
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

		// Token: 0x060344CA RID: 214218 RVA: 0x00EA17BC File Offset: 0x00E9F9BC
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

		// Token: 0x060344CB RID: 214219 RVA: 0x00EA182C File Offset: 0x00E9FA2C
		private void OnClickHelpBtn()
		{
			if (this.ActivityBaseData.LocalConfig != null)
			{
				HelpController.Instance.OpenHelpById(this.ActivityBaseData.LocalConfig.Value.HelpId);
			}
		}

		// Token: 0x0401BC5B RID: 113755
		[Nullable(2)]
		private PopupCaptionItem CaptionComponent;

		// Token: 0x0401BC5C RID: 113756
		private ActivityRealmBetweenData ActivityBaseData;

		// Token: 0x0401BC5D RID: 113757
		private GenericScrollViewNew<MenuTabToggleItem, MotorChallengePlayData> MenuScroll;

		// Token: 0x0401BC5E RID: 113758
		private GenericScrollViewNew<MissionToggleItem, ActivityTaskData> TaskScroll;

		// Token: 0x0401BC5F RID: 113759
		private int SelectedTabIndex = -1;

		// Token: 0x0401BC60 RID: 113760
		[Nullable(2)]
		private MenuTabToggleItem SelectChildToggle;

		// Token: 0x0401BC61 RID: 113761
		private ActivityButtonItem BtnJump;
	}
}
