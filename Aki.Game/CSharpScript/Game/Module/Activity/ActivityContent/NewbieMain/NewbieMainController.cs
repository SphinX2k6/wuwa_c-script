using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using Google.Protobuf;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x0200637C RID: 25468
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class NewbieMainController : ActivityControllerBase
	{
		// Token: 0x060400EB RID: 262379 RVA: 0x00F7FDEE File Offset: 0x00F7DFEE
		protected override void OnRegisterNetEvent()
		{
			Net.Instance.Register(ENotifyMessageId.NewbieMainTaskUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnNewbieMainTaskUpdate));
		}

		// Token: 0x060400EC RID: 262380 RVA: 0x00F7FE0C File Offset: 0x00F7E00C
		protected override void OnUnRegisterNetEvent()
		{
			Net.Instance.UnRegister(ENotifyMessageId.NewbieMainTaskUpdateNotify);
		}

		// Token: 0x060400ED RID: 262381 RVA: 0x00F7FE20 File Offset: 0x00F7E020
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

		// Token: 0x060400EE RID: 262382 RVA: 0x00F7FE94 File Offset: 0x00F7E094
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(newbieFetchScoreRewardResponse.Code, 22454, null, true, true);
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

		// Token: 0x060400EF RID: 262383 RVA: 0x00F7FEFC File Offset: 0x00F7E0FC
		protected override void OnOpenView(ActivityBaseData data)
		{
		}

		// Token: 0x060400F0 RID: 262384 RVA: 0x00F7FEFE File Offset: 0x00F7E0FE
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_NewcomerMainSignin";
		}

		// Token: 0x060400F1 RID: 262385 RVA: 0x00F7FF05 File Offset: 0x00F7E105
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new NewbieMainSubView();
		}

		// Token: 0x060400F2 RID: 262386 RVA: 0x00F7FF0C File Offset: 0x00F7E10C
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new NewbieMainData();
		}

		// Token: 0x060400F3 RID: 262387 RVA: 0x00F7FF13 File Offset: 0x00F7E113
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x17009350 RID: 37712
		// (get) Token: 0x060400F4 RID: 262388 RVA: 0x00F7FF16 File Offset: 0x00F7E116
		public static NewbieMainController Instance
		{
			get
			{
				return NewbieMainController._Instance;
			}
		}

		// Token: 0x060400F5 RID: 262389 RVA: 0x00F7FF1D File Offset: 0x00F7E11D
		public static NewbieMainController GetOrCreateInstance()
		{
			if (NewbieMainController._Instance == null)
			{
				NewbieMainController.CreateInstance();
			}
			return NewbieMainController._Instance;
		}

		// Token: 0x060400F6 RID: 262390 RVA: 0x00F7FF31 File Offset: 0x00F7E131
		public static bool CreateInstance()
		{
			if (NewbieMainController._Instance != null)
			{
				return true;
			}
			NewbieMainController._Instance = new NewbieMainController();
			return true;
		}

		// Token: 0x060400F7 RID: 262391 RVA: 0x00F7FF47 File Offset: 0x00F7E147
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060400F8 RID: 262392 RVA: 0x00F7FF49 File Offset: 0x00F7E149
		public static void ResetStaticDefaultValue()
		{
			NewbieMainController._Instance = null;
		}

		// Token: 0x060400F9 RID: 262393 RVA: 0x00F7FF51 File Offset: 0x00F7E151
		static NewbieMainController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NewbieMainController.CreateStaticDefaultValue), new Action(NewbieMainController.ResetStaticDefaultValue));
		}

		// Token: 0x04021616 RID: 136726
		[Nullable(2)]
		private static NewbieMainController _Instance;
	}
}
