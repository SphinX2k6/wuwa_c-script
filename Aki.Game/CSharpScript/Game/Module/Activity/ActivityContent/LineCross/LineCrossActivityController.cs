using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006559 RID: 25945
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LineCrossActivityController : ActivityControllerBase
	{
		// Token: 0x06041040 RID: 266304 RVA: 0x00FC2039 File Offset: 0x00FC0239
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06041041 RID: 266305 RVA: 0x00FC203B File Offset: 0x00FC023B
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCrossline";
		}

		// Token: 0x06041042 RID: 266306 RVA: 0x00FC2042 File Offset: 0x00FC0242
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new LineCrossSubView();
		}

		// Token: 0x06041043 RID: 266307 RVA: 0x00FC2049 File Offset: 0x00FC0249
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new LineCrossActivityData();
		}

		// Token: 0x06041044 RID: 266308 RVA: 0x00FC2050 File Offset: 0x00FC0250
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06041045 RID: 266309 RVA: 0x00FC2053 File Offset: 0x00FC0253
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.LineCrossActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLineCrossUpdate));
		}

		// Token: 0x06041046 RID: 266310 RVA: 0x00FC2071 File Offset: 0x00FC0271
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.LineCrossActivityUpdateNotify);
		}

		// Token: 0x06041047 RID: 266311 RVA: 0x00FC2083 File Offset: 0x00FC0283
		[NullableContext(2)]
		private LineCrossActivityData GetActivityDataById(int id)
		{
			if (ActivityModel.Instance.GetActivityById(id) == null)
			{
				return null;
			}
			return ActivityModel.Instance.GetActivityById(id) as LineCrossActivityData;
		}

		// Token: 0x06041048 RID: 266312 RVA: 0x00FC20A4 File Offset: 0x00FC02A4
		[NullableContext(2)]
		private void OnLineCrossUpdate(IMessage msg, Net.CallbackStatus _)
		{
			LineCrossActivityUpdateNotify lineCrossActivityUpdateNotify = (LineCrossActivityUpdateNotify)msg;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			foreach (LineCrossChallengeData lineCrossChallengeData in lineCrossActivityUpdateNotify.Challenges)
			{
				LineCrossChallenge value = LineCrossConfig.Instance.GetLineCrossChallengeById(lineCrossChallengeData.ChallengeId).Value;
				LineCrossActivityData activityDataById = this.GetActivityDataById(value.ActivityId);
				if (activityDataById != null)
				{
					activityDataById.OnChallengeDataUpdate(lineCrossChallengeData);
					EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossChallengeRedDot, lineCrossChallengeData.ChallengeId);
				}
				if (!list2.Contains(value.GroupId))
				{
					list2.Add(value.GroupId);
				}
				if (!list.Contains(value.ActivityId))
				{
					list.Add(value.ActivityId);
				}
			}
			foreach (int p in list)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, p);
			}
			foreach (int p2 in list2)
			{
				EventSystem.Instance.Emit<int>(EEventName.RefreshLineCrossGroupRedDot, p2);
			}
		}

		// Token: 0x06041049 RID: 266313 RVA: 0x00FC221C File Offset: 0x00FC041C
		public void RequestStartChallenge(int activityId, int challengeId)
		{
			LineCrossChallengeStartRequest lineCrossChallengeStartRequest = LineCrossChallengeStartRequest.Create();
			lineCrossChallengeStartRequest.Id = challengeId;
			LineCrossModel.Instance.CurrentChallengeFinishState = LineCrossModel.Instance.GetChallengeFinishState(activityId, challengeId);
			Net.Instance.Call(ERequestMessageId.LineCrossChallengeStartRequest, lineCrossChallengeStartRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				LineCrossChallengeStartResponse lineCrossChallengeStartResponse = (LineCrossChallengeStartResponse)msg;
				if (lineCrossChallengeStartResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(lineCrossChallengeStartResponse.ErrorCode, 19877, null, true, true);
				}
			}, 0);
		}

		// Token: 0x0604104A RID: 266314 RVA: 0x00FC227C File Offset: 0x00FC047C
		[NullableContext(0)]
		public UniTask<bool> OpenLineCrossActivityView()
		{
			LineCrossActivityController.<OpenLineCrossActivityView>d__10 <OpenLineCrossActivityView>d__;
			<OpenLineCrossActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLineCrossActivityView>d__.<>1__state = -1;
			<OpenLineCrossActivityView>d__.<>t__builder.Start<LineCrossActivityController.<OpenLineCrossActivityView>d__10>(ref <OpenLineCrossActivityView>d__);
			return <OpenLineCrossActivityView>d__.<>t__builder.Task;
		}

		// Token: 0x0604104B RID: 266315 RVA: 0x00FC22B8 File Offset: 0x00FC04B8
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId = 0)
		{
			LineCrossActivityController.<OnOpenSubView>d__11 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.<>4__this = this;
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<LineCrossActivityController.<OnOpenSubView>d__11>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x17009541 RID: 38209
		// (get) Token: 0x0604104C RID: 266316 RVA: 0x00FC2303 File Offset: 0x00FC0503
		public static LineCrossActivityController Instance
		{
			get
			{
				return LineCrossActivityController._Instance;
			}
		}

		// Token: 0x0604104D RID: 266317 RVA: 0x00FC230A File Offset: 0x00FC050A
		public static LineCrossActivityController GetOrCreateInstance()
		{
			if (LineCrossActivityController._Instance == null)
			{
				LineCrossActivityController.CreateInstance();
			}
			return LineCrossActivityController._Instance;
		}

		// Token: 0x0604104E RID: 266318 RVA: 0x00FC231E File Offset: 0x00FC051E
		public static bool CreateInstance()
		{
			if (LineCrossActivityController._Instance != null)
			{
				return true;
			}
			LineCrossActivityController._Instance = new LineCrossActivityController();
			return true;
		}

		// Token: 0x0604104F RID: 266319 RVA: 0x00FC2334 File Offset: 0x00FC0534
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041050 RID: 266320 RVA: 0x00FC2336 File Offset: 0x00FC0536
		public static void ResetStaticDefaultValue()
		{
			LineCrossActivityController._Instance = null;
		}

		// Token: 0x06041051 RID: 266321 RVA: 0x00FC233E File Offset: 0x00FC053E
		static LineCrossActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossActivityController.CreateStaticDefaultValue), new Action(LineCrossActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x04021E61 RID: 138849
		[Nullable(2)]
		private static LineCrossActivityController _Instance;
	}
}
