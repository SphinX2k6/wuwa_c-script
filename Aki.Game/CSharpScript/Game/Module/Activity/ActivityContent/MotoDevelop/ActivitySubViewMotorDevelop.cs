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
	// Token: 0x020053D8 RID: 21464
	[NullableContext(2)]
	[Nullable(0)]
	public class ActivitySubViewMotorDevelop : ActivitySubViewBase
	{
		// Token: 0x060355C6 RID: 218566 RVA: 0x00EE76BC File Offset: 0x00EE58BC
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

		// Token: 0x060355C7 RID: 218567 RVA: 0x00EE7768 File Offset: 0x00EE5968
		protected override UniTask OnBeforeStartAsync()
		{
			ActivitySubViewMotorDevelop.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ActivitySubViewMotorDevelop.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060355C8 RID: 218568 RVA: 0x00EE77AB File Offset: 0x00EE59AB
		protected override void OnStart()
		{
			ActivityMotorDevelopController.Instance.RefreshFirstUnlockUnReadRedDot();
			this.TitleComponent.SetActivityBaseData(this.ActivityBaseData);
			this.TitleComponent.SetTitleByText(this.ActivityBaseData.GetTitle());
		}

		// Token: 0x060355C9 RID: 218569 RVA: 0x00EE77DE File Offset: 0x00EE59DE
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnMotorDevelopTaskUpdate, new Action(this.OnMotorDevelopTaskUpdate));
		}

		// Token: 0x060355CA RID: 218570 RVA: 0x00EE77FC File Offset: 0x00EE59FC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnMotorDevelopTaskUpdate, new Action(this.OnMotorDevelopTaskUpdate));
		}

		// Token: 0x060355CB RID: 218571 RVA: 0x00EE781A File Offset: 0x00EE5A1A
		protected override void OnRefreshView()
		{
			this.RefreshTimerText();
			this.RefreshTaskLayout(true);
			this.RefreshCondition();
		}

		// Token: 0x060355CC RID: 218572 RVA: 0x00EE782F File Offset: 0x00EE5A2F
		protected override void OnTimer(float gap)
		{
			this.RefreshTimerText();
		}

		// Token: 0x060355CD RID: 218573 RVA: 0x00EE7838 File Offset: 0x00EE5A38
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

		// Token: 0x060355CE RID: 218574 RVA: 0x00EE78BF File Offset: 0x00EE5ABF
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

		// Token: 0x060355CF RID: 218575 RVA: 0x00EE78F0 File Offset: 0x00EE5AF0
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

		// Token: 0x060355D0 RID: 218576 RVA: 0x00EE792C File Offset: 0x00EE5B2C
		public void RefreshTaskLayout(bool isPlayGridAnim = false)
		{
			ActivityMotorDevelopData activityData = ActivityMotorDevelopController.Instance.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			this.TaskGenericLayout.RefreshByDataAsync(activityData.GetMotorDevelopTaskList() ?? new List<ConditionTask>(), isPlayGridAnim, null).Forget();
		}

		// Token: 0x060355D1 RID: 218577 RVA: 0x00EE7971 File Offset: 0x00EE5B71
		private void OnMotorDevelopTaskUpdate()
		{
			this.RefreshTaskLayout(false);
		}

		// Token: 0x060355D2 RID: 218578 RVA: 0x00EE797A File Offset: 0x00EE5B7A
		[NullableContext(1)]
		private ActivitySubViewMotorDevelopMonsterItem CreateGrid()
		{
			return new ActivitySubViewMotorDevelopMonsterItem();
		}

		// Token: 0x0401C261 RID: 115297
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public GenericLayout<ActivitySubViewMotorDevelopMonsterItem, ConditionTask> TaskGenericLayout;

		// Token: 0x0401C262 RID: 115298
		public FunctionalPanelConditionLock PanelLock;

		// Token: 0x0401C263 RID: 115299
		public ActivityMotorDevelopData ActivityData;

		// Token: 0x0401C264 RID: 115300
		public ActivityTitleTypeA TitleComponent;
	}
}
