using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorDecalLink
{
	// Token: 0x02006432 RID: 25650
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MotorDecalLinkController : ActivityControllerBase
	{
		// Token: 0x060407DF RID: 264159 RVA: 0x00F9BC9A File Offset: 0x00F99E9A
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorDecalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorDecalUpdateNotify));
		}

		// Token: 0x060407E0 RID: 264160 RVA: 0x00F9BCB8 File Offset: 0x00F99EB8
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorDecalUpdateNotify);
		}

		// Token: 0x060407E1 RID: 264161 RVA: 0x00F9BCCC File Offset: 0x00F99ECC
		[NullableContext(2)]
		private void OnMotorDecalUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			MotorDecalUpdateNotify motorDecalUpdateNotify = (MotorDecalUpdateNotify)msg;
			ConditionTask task = motorDecalUpdateNotify.Task;
			if (task == null)
			{
				return;
			}
			int id = task.Id;
			List<ActivityBaseData> currentActivitiesByType = ActivityModel.Instance.GetCurrentActivitiesByType(ActivityType.MotorDecalActivity);
			if (currentActivitiesByType == null)
			{
				return;
			}
			foreach (ActivityBaseData activityBaseData in currentActivitiesByType)
			{
				MotorDecalLinkData motorDecalLinkData = activityBaseData as MotorDecalLinkData;
				if (motorDecalLinkData != null && motorDecalLinkData.ContainsTaskId(id))
				{
					motorDecalLinkData.OnTaskUpdateNotify(motorDecalUpdateNotify);
					EventSystem.Instance.Emit<int>(EEventName.ActivityViewRefreshCurrent, motorDecalLinkData.Id);
					EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, motorDecalLinkData.Id);
					break;
				}
			}
		}

		// Token: 0x060407E2 RID: 264162 RVA: 0x00F9BD8C File Offset: 0x00F99F8C
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060407E3 RID: 264163 RVA: 0x00F9BD8E File Offset: 0x00F99F8E
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_MotoLinkageActivityMain33";
		}

		// Token: 0x060407E4 RID: 264164 RVA: 0x00F9BD95 File Offset: 0x00F99F95
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MotorDecalLinkView();
		}

		// Token: 0x060407E5 RID: 264165 RVA: 0x00F9BD9C File Offset: 0x00F99F9C
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new MotorDecalLinkData(data.Id);
		}

		// Token: 0x060407E6 RID: 264166 RVA: 0x00F9BDA9 File Offset: 0x00F99FA9
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060407E7 RID: 264167 RVA: 0x00F9BDAC File Offset: 0x00F99FAC
		public UniTask RequestRandomMotorIpAndRefreshView(int activityId)
		{
			MotorDecalLinkController.<RequestRandomMotorIpAndRefreshView>d__8 <RequestRandomMotorIpAndRefreshView>d__;
			<RequestRandomMotorIpAndRefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRandomMotorIpAndRefreshView>d__.activityId = activityId;
			<RequestRandomMotorIpAndRefreshView>d__.<>1__state = -1;
			<RequestRandomMotorIpAndRefreshView>d__.<>t__builder.Start<MotorDecalLinkController.<RequestRandomMotorIpAndRefreshView>d__8>(ref <RequestRandomMotorIpAndRefreshView>d__);
			return <RequestRandomMotorIpAndRefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x060407E8 RID: 264168 RVA: 0x00F9BDF0 File Offset: 0x00F99FF0
		public UniTask ReceiveRewardByIpRequest(int activityId, int ipId)
		{
			MotorDecalLinkController.<ReceiveRewardByIpRequest>d__9 <ReceiveRewardByIpRequest>d__;
			<ReceiveRewardByIpRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ReceiveRewardByIpRequest>d__.activityId = activityId;
			<ReceiveRewardByIpRequest>d__.ipId = ipId;
			<ReceiveRewardByIpRequest>d__.<>1__state = -1;
			<ReceiveRewardByIpRequest>d__.<>t__builder.Start<MotorDecalLinkController.<ReceiveRewardByIpRequest>d__9>(ref <ReceiveRewardByIpRequest>d__);
			return <ReceiveRewardByIpRequest>d__.<>t__builder.Task;
		}

		// Token: 0x060407E9 RID: 264169 RVA: 0x00F9BE3C File Offset: 0x00F9A03C
		public void OnFirstRead(int activityId)
		{
			MotorDecalLinkData motorDecalLinkData = ActivityModel.Instance.GetActivityById(activityId) as MotorDecalLinkData;
			if (motorDecalLinkData == null)
			{
				return;
			}
			motorDecalLinkData.SetHasFirstRead();
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, activityId);
		}

		// Token: 0x1700947D RID: 38013
		// (get) Token: 0x060407EA RID: 264170 RVA: 0x00F9BE75 File Offset: 0x00F9A075
		public static MotorDecalLinkController Instance
		{
			get
			{
				return MotorDecalLinkController._Instance;
			}
		}

		// Token: 0x060407EB RID: 264171 RVA: 0x00F9BE7C File Offset: 0x00F9A07C
		public static MotorDecalLinkController GetOrCreateInstance()
		{
			if (MotorDecalLinkController._Instance == null)
			{
				MotorDecalLinkController.CreateInstance();
			}
			return MotorDecalLinkController._Instance;
		}

		// Token: 0x060407EC RID: 264172 RVA: 0x00F9BE90 File Offset: 0x00F9A090
		public static bool CreateInstance()
		{
			if (MotorDecalLinkController._Instance != null)
			{
				return true;
			}
			MotorDecalLinkController._Instance = new MotorDecalLinkController();
			return true;
		}

		// Token: 0x060407ED RID: 264173 RVA: 0x00F9BEA6 File Offset: 0x00F9A0A6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060407EE RID: 264174 RVA: 0x00F9BEA8 File Offset: 0x00F9A0A8
		public static void ResetStaticDefaultValue()
		{
			MotorDecalLinkController._Instance = null;
		}

		// Token: 0x060407EF RID: 264175 RVA: 0x00F9BEB0 File Offset: 0x00F9A0B0
		static MotorDecalLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorDecalLinkController.CreateStaticDefaultValue), new Action(MotorDecalLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x0402186A RID: 137322
		[Nullable(2)]
		private static MotorDecalLinkController _Instance;
	}
}
