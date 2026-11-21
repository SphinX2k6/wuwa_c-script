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
	// Token: 0x020054D7 RID: 21719
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class LineCrossActivityController : ActivityControllerBase
	{
		// Token: 0x06035D05 RID: 220421 RVA: 0x00F09021 File Offset: 0x00F07221
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06035D06 RID: 220422 RVA: 0x00F09023 File Offset: 0x00F07223
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_ActivityCrossline";
		}

		// Token: 0x06035D07 RID: 220423 RVA: 0x00F0902A File Offset: 0x00F0722A
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new LineCrossSubView();
		}

		// Token: 0x06035D08 RID: 220424 RVA: 0x00F09031 File Offset: 0x00F07231
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new LineCrossActivityData();
		}

		// Token: 0x06035D09 RID: 220425 RVA: 0x00F09038 File Offset: 0x00F07238
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06035D0A RID: 220426 RVA: 0x00F0903B File Offset: 0x00F0723B
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.LineCrossActivityUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnLineCrossUpdate));
		}

		// Token: 0x06035D0B RID: 220427 RVA: 0x00F09059 File Offset: 0x00F07259
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.LineCrossActivityUpdateNotify);
		}

		// Token: 0x06035D0C RID: 220428 RVA: 0x00F0906B File Offset: 0x00F0726B
		[NullableContext(2)]
		private LineCrossActivityData GetActivityDataById(int id)
		{
			if (ActivityModel.Instance.GetActivityById(id) == null)
			{
				return null;
			}
			return ActivityModel.Instance.GetActivityById(id) as LineCrossActivityData;
		}

		// Token: 0x06035D0D RID: 220429 RVA: 0x00F0908C File Offset: 0x00F0728C
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

		// Token: 0x06035D0E RID: 220430 RVA: 0x00F09204 File Offset: 0x00F07404
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(lineCrossChallengeStartResponse.ErrorCode, 21987, null, true, true);
				}
			}, 0);
		}

		// Token: 0x06035D0F RID: 220431 RVA: 0x00F09264 File Offset: 0x00F07464
		[NullableContext(0)]
		public UniTask<bool> OpenLineCrossActivityView()
		{
			LineCrossActivityController.<OpenLineCrossActivityView>d__10 <OpenLineCrossActivityView>d__;
			<OpenLineCrossActivityView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OpenLineCrossActivityView>d__.<>1__state = -1;
			<OpenLineCrossActivityView>d__.<>t__builder.Start<LineCrossActivityController.<OpenLineCrossActivityView>d__10>(ref <OpenLineCrossActivityView>d__);
			return <OpenLineCrossActivityView>d__.<>t__builder.Task;
		}

		// Token: 0x06035D10 RID: 220432 RVA: 0x00F092A0 File Offset: 0x00F074A0
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

		// Token: 0x170068A3 RID: 26787
		// (get) Token: 0x06035D11 RID: 220433 RVA: 0x00F092EB File Offset: 0x00F074EB
		public static LineCrossActivityController Instance
		{
			get
			{
				return LineCrossActivityController._Instance;
			}
		}

		// Token: 0x06035D12 RID: 220434 RVA: 0x00F092F2 File Offset: 0x00F074F2
		public static LineCrossActivityController GetOrCreateInstance()
		{
			if (LineCrossActivityController._Instance == null)
			{
				LineCrossActivityController.CreateInstance();
			}
			return LineCrossActivityController._Instance;
		}

		// Token: 0x06035D13 RID: 220435 RVA: 0x00F09306 File Offset: 0x00F07506
		public static bool CreateInstance()
		{
			if (LineCrossActivityController._Instance != null)
			{
				return true;
			}
			LineCrossActivityController._Instance = new LineCrossActivityController();
			return true;
		}

		// Token: 0x06035D14 RID: 220436 RVA: 0x00F0931C File Offset: 0x00F0751C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035D15 RID: 220437 RVA: 0x00F0931E File Offset: 0x00F0751E
		public static void ResetStaticDefaultValue()
		{
			LineCrossActivityController._Instance = null;
		}

		// Token: 0x06035D16 RID: 220438 RVA: 0x00F09326 File Offset: 0x00F07526
		static LineCrossActivityController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossActivityController.CreateStaticDefaultValue), new Action(LineCrossActivityController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C792 RID: 116626
		[Nullable(2)]
		private static LineCrossActivityController _Instance;
	}
}
