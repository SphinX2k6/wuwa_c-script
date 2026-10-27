using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x02006456 RID: 25686
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMotorDevelopController : ActivityControllerBase
	{
		// Token: 0x060408DF RID: 264415 RVA: 0x00FA01A6 File Offset: 0x00F9E3A6
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060408E0 RID: 264416 RVA: 0x00FA01A8 File Offset: 0x00F9E3A8
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMotoCultivate";
		}

		// Token: 0x060408E1 RID: 264417 RVA: 0x00FA01AF File Offset: 0x00F9E3AF
		public override void OnActivityFirstUnlock(ActivityBaseData data)
		{
			((ActivityMotorDevelopData)data).SetActivityFirstUnlockUnReadFlag(1);
		}

		// Token: 0x060408E2 RID: 264418 RVA: 0x00FA01C0 File Offset: 0x00F9E3C0
		public void RefreshFirstUnlockUnReadRedDot()
		{
			ActivityMotorDevelopData activityData = this.GetActivityData();
			ActivityModel instance = ActivityModel.Instance;
			int? num = (instance != null) ? new int?(instance.GetActivityCacheData(this.ActivityId, 0, 2, 0, 0)) : null;
			if (activityData.IsUnLock() && num != null)
			{
				int? num2 = num;
				int num3 = 0;
				if (!(num2.GetValueOrDefault() == num3 & num2 != null))
				{
					activityData.SetActivityFirstUnlockUnReadFlag(0);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
				}
			}
		}

		// Token: 0x060408E3 RID: 264419 RVA: 0x00FA0243 File Offset: 0x00F9E443
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewMotorDevelop();
		}

		// Token: 0x060408E4 RID: 264420 RVA: 0x00FA024A File Offset: 0x00F9E44A
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityMotorDevelopData();
		}

		// Token: 0x060408E5 RID: 264421 RVA: 0x00FA025D File Offset: 0x00F9E45D
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060408E6 RID: 264422 RVA: 0x00FA0260 File Offset: 0x00F9E460
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorDevelopTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorDevelopTaskUpdateNotify));
		}

		// Token: 0x060408E7 RID: 264423 RVA: 0x00FA027E File Offset: 0x00F9E47E
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorDevelopTaskUpdateNotify);
		}

		// Token: 0x060408E8 RID: 264424 RVA: 0x00FA0290 File Offset: 0x00F9E490
		[NullableContext(2)]
		public ActivityMotorDevelopData GetActivityData()
		{
			ActivityMotorDevelopData activityMotorDevelopData = ActivityModel.Instance.GetActivityById(this.ActivityId) as ActivityMotorDevelopData;
			if (activityMotorDevelopData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "摩托开发任务活动数据更新错误，没有活动数据:";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActivityId:", this.ActivityId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return activityMotorDevelopData;
		}

		// Token: 0x060408E9 RID: 264425 RVA: 0x00FA02F0 File Offset: 0x00F9E4F0
		[NullableContext(2)]
		protected void OnMotorDevelopTaskUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MotorDevelopTaskUpdateNotify motorDevelopTaskUpdateNotify = (MotorDevelopTaskUpdateNotify)msg;
			ActivityMotorDevelopData activityData = this.GetActivityData();
			if (activityData == null)
			{
				return;
			}
			activityData.UpdateMotorDevelopTask(motorDevelopTaskUpdateNotify.Task);
			EventSystem.Instance.Emit(EEventName.OnMotorDevelopTaskUpdate);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
		}

		// Token: 0x060408EA RID: 264426 RVA: 0x00FA0344 File Offset: 0x00F9E544
		public void RewardReceiveRequest(List<int> taskIds)
		{
			MotorDevelopTaskRewardRequest motorDevelopTaskRewardRequest = MotorDevelopTaskRewardRequest.Create();
			motorDevelopTaskRewardRequest.Ids.AddRange(taskIds);
			Net.Instance.Call(ERequestMessageId.MotorDevelopTaskRewardRequest, motorDevelopTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MotorDevelopTaskRewardResponse motorDevelopTaskRewardResponse = (MotorDevelopTaskRewardResponse)msg;
				if (motorDevelopTaskRewardResponse == null)
				{
					return;
				}
				if (motorDevelopTaskRewardResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorDevelopTaskRewardResponse.ErrorCode, 28453, null, true, true);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}, 0);
		}

		// Token: 0x17009485 RID: 38021
		// (get) Token: 0x060408EB RID: 264427 RVA: 0x00FA0380 File Offset: 0x00F9E580
		public static ActivityMotorDevelopController Instance
		{
			get
			{
				return ActivityMotorDevelopController._Instance;
			}
		}

		// Token: 0x060408EC RID: 264428 RVA: 0x00FA0387 File Offset: 0x00F9E587
		public static ActivityMotorDevelopController GetOrCreateInstance()
		{
			if (ActivityMotorDevelopController._Instance == null)
			{
				ActivityMotorDevelopController.CreateInstance();
			}
			return ActivityMotorDevelopController._Instance;
		}

		// Token: 0x060408ED RID: 264429 RVA: 0x00FA039B File Offset: 0x00F9E59B
		public static bool CreateInstance()
		{
			if (ActivityMotorDevelopController._Instance != null)
			{
				return true;
			}
			ActivityMotorDevelopController._Instance = new ActivityMotorDevelopController();
			return true;
		}

		// Token: 0x060408EE RID: 264430 RVA: 0x00FA03B1 File Offset: 0x00F9E5B1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060408EF RID: 264431 RVA: 0x00FA03B3 File Offset: 0x00F9E5B3
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorDevelopController._Instance = null;
		}

		// Token: 0x060408F0 RID: 264432 RVA: 0x00FA03BB File Offset: 0x00F9E5BB
		static ActivityMotorDevelopController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorDevelopController.CreateStaticDefaultValue), new Action(ActivityMotorDevelopController.ResetStaticDefaultValue));
		}

		// Token: 0x04021925 RID: 137509
		private const int FIRSTUNLOCK = 2;

		// Token: 0x04021926 RID: 137510
		public int ActivityId;

		// Token: 0x04021927 RID: 137511
		[Nullable(2)]
		private static ActivityMotorDevelopController _Instance;
	}
}
