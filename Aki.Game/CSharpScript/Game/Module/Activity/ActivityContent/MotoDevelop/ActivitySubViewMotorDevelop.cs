using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x0200645A RID: 25690
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewMotorDevelop : ActivitySubViewBase
	{
		// Token: 0x06040905 RID: 264453 RVA: 0x00FA0740 File Offset: 0x00F9E940
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickBtnGo))
			};
		}

		// Token: 0x06040906 RID: 264454 RVA: 0x00FA07EC File Offset: 0x00F9E9EC
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewMotorDevelop.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMotorDevelop.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040907 RID: 264455 RVA: 0x00FA082F File Offset: 0x00F9EA2F
		protected override void OnStart()
		{
			ActivityMotorDevelopController.Instance.RefreshFirstUnlockUnReadRedDot();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		}

		// Token: 0x06040908 RID: 264456 RVA: 0x00FA0862 File Offset: 0x00F9EA62
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMotorDevelopTaskUpdate, new Action(this.OnMotorDevelopTaskUpdate));
		}

		// Token: 0x06040909 RID: 264457 RVA: 0x00FA0880 File Offset: 0x00F9EA80
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMotorDevelopTaskUpdate, new Action(this.OnMotorDevelopTaskUpdate));
		}

		// Token: 0x0604090A RID: 264458 RVA: 0x00FA089E File Offset: 0x00F9EA9E
		protected override void OnRefreshView()
		{
			this.RefreshTimerText();
			this.RefreshTaskLayout(true);
			this.RefreshCondition();
		}

		// Token: 0x0604090B RID: 264459 RVA: 0x00FA08B3 File Offset: 0x00F9EAB3
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x0604090C RID: 264460 RVA: 0x00FA08BC File Offset: 0x00F9EABC
		private void RefreshCondition()
		{
			bool flag = this.ActivityBaseData.IsUnLock();
			base.GetItem(3).SetUIActive(!flag);
			base.GetButton(4).RootUIComp.Get().SetUIActive(flag);
			if (!flag)
			{
				string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(this.ActivityBaseData.ConditionGroupId);
				if (!string.IsNullOrEmpty(conditionGroupHintText))
				{
					this.PanelLock.SetTextByTextId(conditionGroupHintText, Array.Empty<string>());
				}
				this.PanelLock.ButtonCallBack = delegate()
				{
					ActivityController instance = ActivityController.Instance;
					if (instance == null)
					{
						return;
					}
					instance.OpenActivityConditionView(this.ActivityBaseData.Id);
				};
			}
		}

		// Token: 0x0604090D RID: 264461 RVA: 0x00FA0943 File Offset: 0x00F9EB43
		private void OnClickBtnGo()
		{
			ActivityController.Instance.JumpAndLog(this.ActivityBaseData, delegate()
			{
				ActivityMotorDevelopConfig instance = ActivityMotorDevelopConfig.Instance;
				MotorDevelopActivity? motorDevelopActivity = (instance != null) ? instance.GetActivityDataById(ActivityMotorDevelopController.Instance.ActivityId) : null;
				if (motorDevelopActivity == null)
				{
					return;
				}
				MotorcycleDevelopController instance2 = MotorcycleDevelopController.Instance;
				if (instance2 == null)
				{
					return;
				}
				instance2.OpenMotorDevelopTechTreeTabView(motorDevelopActivity.Value.SkillTreeId);
			});
		}

		// Token: 0x0604090E RID: 264462 RVA: 0x00FA0974 File Offset: 0x00F9EB74
		public void RefreshTimerText()
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

		// Token: 0x0604090F RID: 264463 RVA: 0x00FA09B0 File Offset: 0x00F9EBB0
		public void RefreshTaskLayout(bool isPlayGridAnim = false)
		{
			ActivityMotorDevelopData activityData = ActivityMotorDevelopController.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			this.TaskGenericLayout.RefreshByDataAsync(activityData.GetMotorDevelopTaskList() ?? new List<ConditionTask>(), isPlayGridAnim, null).Forget();
		}

		// Token: 0x06040910 RID: 264464 RVA: 0x00FA09F5 File Offset: 0x00F9EBF5
		private void OnMotorDevelopTaskUpdate()
		{
			this.RefreshTaskLayout(false);
		}

		// Token: 0x06040911 RID: 264465 RVA: 0x00FA09FE File Offset: 0x00F9EBFE
		[NullableContext(1)]
		private ActivitySubViewMotorDevelopMonsterItem CreateGrid()
		{
			return new ActivitySubViewMotorDevelopMonsterItem();
		}

		// Token: 0x04021932 RID: 137522
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<ActivitySubViewMotorDevelopMonsterItem, ConditionTask> TaskGenericLayout;

		// Token: 0x04021933 RID: 137523
		public FunctionalPanelConditionLock PanelLock;

		// Token: 0x04021934 RID: 137524
		public ActivityMotorDevelopData ActivityData;

		// Token: 0x04021935 RID: 137525
		public ActivityTitleTypeA TitleComponent;
	}
}
