using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotoDevelop
{
	// Token: 0x020053D4 RID: 21460
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class ActivityMotorDevelopController : ActivityControllerBase
	{
		// Token: 0x060355A0 RID: 218528 RVA: 0x00EE7122 File Offset: 0x00EE5322
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060355A1 RID: 218529 RVA: 0x00EE7124 File Offset: 0x00EE5324
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityMotoCultivate";
		}

		// Token: 0x060355A2 RID: 218530 RVA: 0x00EE712B File Offset: 0x00EE532B
		public override void OnActivityFirstUnlock(ActivityBaseData data)
		{
			((ActivityMotorDevelopData)data).SetActivityFirstUnlockUnReadFlag(1);
		}

		// Token: 0x060355A3 RID: 218531 RVA: 0x00EE713C File Offset: 0x00EE533C
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

		// Token: 0x060355A4 RID: 218532 RVA: 0x00EE71BF File Offset: 0x00EE53BF
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new ActivitySubViewMotorDevelop();
		}

		// Token: 0x060355A5 RID: 218533 RVA: 0x00EE71C6 File Offset: 0x00EE53C6
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			this.ActivityId = data.Id;
			return new ActivityMotorDevelopData();
		}

		// Token: 0x060355A6 RID: 218534 RVA: 0x00EE71D9 File Offset: 0x00EE53D9
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060355A7 RID: 218535 RVA: 0x00EE71DC File Offset: 0x00EE53DC
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorDevelopTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorDevelopTaskUpdateNotify));
		}

		// Token: 0x060355A8 RID: 218536 RVA: 0x00EE71FA File Offset: 0x00EE53FA
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorDevelopTaskUpdateNotify);
		}

		// Token: 0x060355A9 RID: 218537 RVA: 0x00EE720C File Offset: 0x00EE540C
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

		// Token: 0x060355AA RID: 218538 RVA: 0x00EE726C File Offset: 0x00EE546C
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

		// Token: 0x060355AB RID: 218539 RVA: 0x00EE72C0 File Offset: 0x00EE54C0
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(motorDevelopTaskRewardResponse.ErrorCode, 29442, null, true, true);
				}
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, this.ActivityId);
			}, 0);
		}

		// Token: 0x170067E7 RID: 26599
		// (get) Token: 0x060355AC RID: 218540 RVA: 0x00EE72FC File Offset: 0x00EE54FC
		public static ActivityMotorDevelopController Instance
		{
			get
			{
				return ActivityMotorDevelopController._Instance;
			}
		}

		// Token: 0x060355AD RID: 218541 RVA: 0x00EE7303 File Offset: 0x00EE5503
		public static ActivityMotorDevelopController GetOrCreateInstance()
		{
			if (ActivityMotorDevelopController._Instance == null)
			{
				ActivityMotorDevelopController.CreateInstance();
			}
			return ActivityMotorDevelopController._Instance;
		}

		// Token: 0x060355AE RID: 218542 RVA: 0x00EE7317 File Offset: 0x00EE5517
		public static bool CreateInstance()
		{
			if (ActivityMotorDevelopController._Instance != null)
			{
				return true;
			}
			ActivityMotorDevelopController._Instance = new ActivityMotorDevelopController();
			return true;
		}

		// Token: 0x060355AF RID: 218543 RVA: 0x00EE732D File Offset: 0x00EE552D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060355B0 RID: 218544 RVA: 0x00EE732F File Offset: 0x00EE552F
		public static void ResetStaticDefaultValue()
		{
			ActivityMotorDevelopController._Instance = null;
		}

		// Token: 0x060355B1 RID: 218545 RVA: 0x00EE7337 File Offset: 0x00EE5537
		static ActivityMotorDevelopController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityMotorDevelopController.CreateStaticDefaultValue), new Action(ActivityMotorDevelopController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C254 RID: 115284
		private const int FIRSTUNLOCK = 2;

		// Token: 0x0401C255 RID: 115285
		public int ActivityId;

		// Token: 0x0401C256 RID: 115286
		[Nullable(2)]
		private static ActivityMotorDevelopController _Instance;
	}
}
