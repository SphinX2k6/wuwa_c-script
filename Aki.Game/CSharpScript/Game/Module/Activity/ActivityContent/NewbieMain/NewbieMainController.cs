using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x020052FA RID: 21242
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class NewbieMainController : ActivityControllerBase
	{
		// Token: 0x06034DAC RID: 216492 RVA: 0x00EC6D52 File Offset: 0x00EC4F52
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.NewbieMainTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewbieMainTaskUpdate));
		}

		// Token: 0x06034DAD RID: 216493 RVA: 0x00EC6D70 File Offset: 0x00EC4F70
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.NewbieMainTaskUpdateNotify);
		}

		// Token: 0x06034DAE RID: 216494 RVA: 0x00EC6D84 File Offset: 0x00EC4F84
		[NullableContext(2)]
		private void OnNewbieMainTaskUpdate(IMessage msg, Net.CallbackStatus status)
		{
			NewbieMainTaskUpdateNotify newbieMainTaskUpdateNotify = (NewbieMainTaskUpdateNotify)msg;
			NewbieMainData newbieMainData = ActivityModel.Instance.GetActivityById(newbieMainTaskUpdateNotify.ActivityId) as NewbieMainData;
			if (newbieMainData == null)
			{
				return;
			}
			if (newbieMainTaskUpdateNotify.NewbieMainTabs != null)
			{
				newbieMainData.UpdateTabs(newbieMainTaskUpdateNotify.NewbieMainTabs);
			}
			newbieMainData.UpdateProgressScore(newbieMainTaskUpdateNotify.ProgressScore);
			EventSystem.Instance.Emit<int>(EEventName.RefreshCommonActivityRedDot, newbieMainData.Id);
			EventSystem.Instance.Emit(EEventName.OnNewbieMainTaskUpdate);
		}

		// Token: 0x06034DAF RID: 216495 RVA: 0x00EC6DF8 File Offset: 0x00EC4FF8
		public static void RequestFetchScoreRewardAsync(int activityId, List<int> rewardIds, Action<bool> callback)
		{
			NewbieFetchScoreRewardRequest newbieFetchScoreRewardRequest = NewbieFetchScoreRewardRequest.Create();
			newbieFetchScoreRewardRequest.ActivityId = activityId;
			newbieFetchScoreRewardRequest.ScoreRewardIds.AddRange(rewardIds);
			Net.Instance.Call(ERequestMessageId.NewbieFetchScoreRewardRequest, newbieFetchScoreRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				NewbieFetchScoreRewardResponse newbieFetchScoreRewardResponse = (NewbieFetchScoreRewardResponse)msg;
				if (newbieFetchScoreRewardResponse == null)
				{
					Action<bool> callback2 = callback;
					if (callback2 == null)
					{
						return;
					}
					callback2(false);
					return;
				}
				else if (newbieFetchScoreRewardResponse.Code != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(newbieFetchScoreRewardResponse.Code, 29217, null, true, true);
					Action<bool> callback3 = callback;
					if (callback3 == null)
					{
						return;
					}
					callback3(false);
					return;
				}
				else
				{
					NewbieMainData newbieMainData = ActivityModel.Instance.GetActivityById(activityId) as NewbieMainData;
					if (newbieMainData != null)
					{
						newbieMainData.AddTakenScoreRewardIds(rewardIds);
					}
					Action<bool> callback4 = callback;
					if (callback4 == null)
					{
						return;
					}
					callback4(true);
					return;
				}
			}, 0);
		}

		// Token: 0x06034DB0 RID: 216496 RVA: 0x00EC6E60 File Offset: 0x00EC5060
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x06034DB1 RID: 216497 RVA: 0x00EC6E62 File Offset: 0x00EC5062
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_NewcomerMainSignin";
		}

		// Token: 0x06034DB2 RID: 216498 RVA: 0x00EC6E69 File Offset: 0x00EC5069
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new NewbieMainSubView();
		}

		// Token: 0x06034DB3 RID: 216499 RVA: 0x00EC6E70 File Offset: 0x00EC5070
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new NewbieMainData();
		}

		// Token: 0x06034DB4 RID: 216500 RVA: 0x00EC6E77 File Offset: 0x00EC5077
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x170066B2 RID: 26290
		// (get) Token: 0x06034DB5 RID: 216501 RVA: 0x00EC6E7A File Offset: 0x00EC507A
		public static NewbieMainController Instance
		{
			get
			{
				return NewbieMainController._Instance;
			}
		}

		// Token: 0x06034DB6 RID: 216502 RVA: 0x00EC6E81 File Offset: 0x00EC5081
		public static NewbieMainController GetOrCreateInstance()
		{
			if (NewbieMainController._Instance == null)
			{
				NewbieMainController.CreateInstance();
			}
			return NewbieMainController._Instance;
		}

		// Token: 0x06034DB7 RID: 216503 RVA: 0x00EC6E95 File Offset: 0x00EC5095
		public static bool CreateInstance()
		{
			if (NewbieMainController._Instance != null)
			{
				return true;
			}
			NewbieMainController._Instance = new NewbieMainController();
			return true;
		}

		// Token: 0x06034DB8 RID: 216504 RVA: 0x00EC6EAB File Offset: 0x00EC50AB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034DB9 RID: 216505 RVA: 0x00EC6EAD File Offset: 0x00EC50AD
		public static void ResetStaticDefaultValue()
		{
			NewbieMainController._Instance = null;
		}

		// Token: 0x06034DBA RID: 216506 RVA: 0x00EC6EB5 File Offset: 0x00EC50B5
		static NewbieMainController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NewbieMainController.CreateStaticDefaultValue), new Action(NewbieMainController.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF45 RID: 114501
		[Nullable(2)]
		private static NewbieMainController _Instance;
	}
}
