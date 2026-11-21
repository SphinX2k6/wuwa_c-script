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
	// Token: 0x020053B0 RID: 21424
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class MotorDecalLinkController : ActivityControllerBase
	{
		// Token: 0x060354A0 RID: 218272 RVA: 0x00EE2C16 File Offset: 0x00EE0E16
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.MotorDecalUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMotorDecalUpdateNotify));
		}

		// Token: 0x060354A1 RID: 218273 RVA: 0x00EE2C34 File Offset: 0x00EE0E34
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.MotorDecalUpdateNotify);
		}

		// Token: 0x060354A2 RID: 218274 RVA: 0x00EE2C48 File Offset: 0x00EE0E48
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

		// Token: 0x060354A3 RID: 218275 RVA: 0x00EE2D08 File Offset: 0x00EE0F08
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060354A4 RID: 218276 RVA: 0x00EE2D0A File Offset: 0x00EE0F0A
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiView_MotoLinkageActivityMain33";
		}

		// Token: 0x060354A5 RID: 218277 RVA: 0x00EE2D11 File Offset: 0x00EE0F11
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new MotorDecalLinkView();
		}

		// Token: 0x060354A6 RID: 218278 RVA: 0x00EE2D18 File Offset: 0x00EE0F18
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new MotorDecalLinkData(data.Id);
		}

		// Token: 0x060354A7 RID: 218279 RVA: 0x00EE2D25 File Offset: 0x00EE0F25
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060354A8 RID: 218280 RVA: 0x00EE2D28 File Offset: 0x00EE0F28
		public UniTask RequestRandomMotorIpAndRefreshView(int activityId)
		{
			MotorDecalLinkController.<RequestRandomMotorIpAndRefreshView>d__8 <RequestRandomMotorIpAndRefreshView>d__;
			<RequestRandomMotorIpAndRefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RequestRandomMotorIpAndRefreshView>d__.activityId = activityId;
			<RequestRandomMotorIpAndRefreshView>d__.<>1__state = -1;
			<RequestRandomMotorIpAndRefreshView>d__.<>t__builder.Start<MotorDecalLinkController.<RequestRandomMotorIpAndRefreshView>d__8>(ref <RequestRandomMotorIpAndRefreshView>d__);
			return <RequestRandomMotorIpAndRefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x060354A9 RID: 218281 RVA: 0x00EE2D6C File Offset: 0x00EE0F6C
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

		// Token: 0x060354AA RID: 218282 RVA: 0x00EE2DB8 File Offset: 0x00EE0FB8
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

		// Token: 0x170067DF RID: 26591
		// (get) Token: 0x060354AB RID: 218283 RVA: 0x00EE2DF1 File Offset: 0x00EE0FF1
		public static MotorDecalLinkController Instance
		{
			get
			{
				return MotorDecalLinkController._Instance;
			}
		}

		// Token: 0x060354AC RID: 218284 RVA: 0x00EE2DF8 File Offset: 0x00EE0FF8
		public static MotorDecalLinkController GetOrCreateInstance()
		{
			if (MotorDecalLinkController._Instance == null)
			{
				MotorDecalLinkController.CreateInstance();
			}
			return MotorDecalLinkController._Instance;
		}

		// Token: 0x060354AD RID: 218285 RVA: 0x00EE2E0C File Offset: 0x00EE100C
		public static bool CreateInstance()
		{
			if (MotorDecalLinkController._Instance != null)
			{
				return true;
			}
			MotorDecalLinkController._Instance = new MotorDecalLinkController();
			return true;
		}

		// Token: 0x060354AE RID: 218286 RVA: 0x00EE2E22 File Offset: 0x00EE1022
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060354AF RID: 218287 RVA: 0x00EE2E24 File Offset: 0x00EE1024
		public static void ResetStaticDefaultValue()
		{
			MotorDecalLinkController._Instance = null;
		}

		// Token: 0x060354B0 RID: 218288 RVA: 0x00EE2E2C File Offset: 0x00EE102C
		static MotorDecalLinkController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorDecalLinkController.CreateStaticDefaultValue), new Action(MotorDecalLinkController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C199 RID: 115097
		[Nullable(2)]
		private static MotorDecalLinkController _Instance;
	}
}
