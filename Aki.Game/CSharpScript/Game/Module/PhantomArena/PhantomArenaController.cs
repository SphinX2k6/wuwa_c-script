using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder;
using CSharpScript.Game.Module.PhantomArena.Prepare.Entrance;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;

namespace CSharpScript.Game.Module.PhantomArena
{
	// Token: 0x02005105 RID: 20741
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PhantomArenaController : ActivityControllerBase
	{
		// Token: 0x060350F8 RID: 217336 RVA: 0x00C9285B File Offset: 0x00C90A5B
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x060350F9 RID: 217337 RVA: 0x00C92860 File Offset: 0x00C90A60
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (!data.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, data.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(null, null);
		}

		// Token: 0x060350FA RID: 217338 RVA: 0x00C928A8 File Offset: 0x00C90AA8
		[NullableContext(0)]
		protected override UniTask<bool> OnOpenSubView(EUiViewName viewName, int activityId)
		{
			PhantomArenaController.<OnOpenSubView>d__5 <OnOpenSubView>d__;
			<OnOpenSubView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnOpenSubView>d__.viewName = viewName;
			<OnOpenSubView>d__.activityId = activityId;
			<OnOpenSubView>d__.<>1__state = -1;
			<OnOpenSubView>d__.<>t__builder.Start<PhantomArenaController.<OnOpenSubView>d__5>(ref <OnOpenSubView>d__);
			return <OnOpenSubView>d__.<>t__builder.Task;
		}

		// Token: 0x060350FB RID: 217339 RVA: 0x00C928F3 File Offset: 0x00C90AF3
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_SoundRemnantArenaMain";
		}

		// Token: 0x060350FC RID: 217340 RVA: 0x00C928FA File Offset: 0x00C90AFA
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PhantomArenaSubView();
		}

		// Token: 0x060350FD RID: 217341 RVA: 0x00C92901 File Offset: 0x00C90B01
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PhantomArenaActivityData();
		}

		// Token: 0x060350FE RID: 217342 RVA: 0x00C92908 File Offset: 0x00C90B08
		protected override void OnRegisterNetEvent()
		{
			if (PhantomArenaController.Instance.NetRegistered)
			{
				return;
			}
			Net.Instance.Register(ENotifyMessageId.PhantomBattleChallengeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleChallengeUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnChallengeUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleMasterInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnMasterInfoNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleBadgeInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBadgeInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleBadgeRewardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnBadgeRewardInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleCardRewardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCardRewardInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleRoleInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnRoleInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleCardInfoUpdateNotify, new Action<IMessage, Net.CallbackStatus>(this.OnCardInfoUpdateNotify));
			Net.Instance.Register(ENotifyMessageId.PhantomBattleTaskInfoNotify, new Action<IMessage, Net.CallbackStatus>(this.OnTaskInfoUpdateNotify));
			PhantomArenaController.Instance.NetRegistered = true;
		}

		// Token: 0x060350FF RID: 217343 RVA: 0x00C92A2C File Offset: 0x00C90C2C
		protected override void OnUnRegisterNetEvent()
		{
			if (!PhantomArenaController.Instance.NetRegistered)
			{
				return;
			}
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleChallengeInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleChallengeUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleMasterInfoNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleBadgeInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleBadgeRewardInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleCardRewardInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleRoleInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleCardInfoUpdateNotify);
			Net.Instance.UnRegister(ENotifyMessageId.PhantomBattleTaskInfoNotify);
			PhantomArenaController.Instance.NetRegistered = false;
		}

		// Token: 0x06035100 RID: 217344 RVA: 0x00C92AE1 File Offset: 0x00C90CE1
		protected override void OnAddEvents()
		{
			if (PhantomArenaController.Instance.EventsRegistered)
			{
				return;
			}
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			PhantomArenaController.Instance.EventsRegistered = true;
		}

		// Token: 0x06035101 RID: 217345 RVA: 0x00C92B17 File Offset: 0x00C90D17
		protected override void OnRemoveEvents()
		{
			if (!PhantomArenaController.Instance.EventsRegistered)
			{
				return;
			}
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			PhantomArenaController.Instance.EventsRegistered = false;
		}

		// Token: 0x06035102 RID: 217346 RVA: 0x00C92B4D File Offset: 0x00C90D4D
		private void OnWorldDone()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x06035103 RID: 217347 RVA: 0x00C92B5C File Offset: 0x00C90D5C
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.PhantomArenaOpen, null, null, null, null, null, null, null, null, false, null);
		}

		// Token: 0x06035104 RID: 217348 RVA: 0x00C92B90 File Offset: 0x00C90D90
		[NullableContext(2)]
		private void OnChallengeInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleChallengeInfoUpdateNotify phantomBattleChallengeInfoUpdateNotify = (PhantomBattleChallengeInfoUpdateNotify)msg;
			if (phantomBattleChallengeInfoUpdateNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.UpdateChallengeInfoByNotify(phantomBattleChallengeInfoUpdateNotify);
		}

		// Token: 0x06035105 RID: 217349 RVA: 0x00C92BB4 File Offset: 0x00C90DB4
		[NullableContext(2)]
		private void OnChallengeUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleChallengeUpdateNotify phantomBattleChallengeUpdateNotify = (PhantomBattleChallengeUpdateNotify)msg;
			if (phantomBattleChallengeUpdateNotify == null)
			{
				return;
			}
			int challengeId = phantomBattleChallengeUpdateNotify.ChallengeId;
			bool unlock = phantomBattleChallengeUpdateNotify.Unlock;
			bool isPassRewarded = phantomBattleChallengeUpdateNotify.IsPassRewarded;
			bool isUncover = phantomBattleChallengeUpdateNotify.IsUncover;
			PhantomArenaModel.Instance.UpdateChallengeInfoBySettleResult(challengeId, unlock, isPassRewarded, isUncover);
			foreach (PhantomBattleChallengeInfo phantomBattleChallengeInfo in phantomBattleChallengeUpdateNotify.ChallengeInfo)
			{
				PhantomArenaActivityData permanentPhantomArenaActivityData = PhantomArenaModel.Instance.GetPermanentPhantomArenaActivityData();
				if (permanentPhantomArenaActivityData != null)
				{
					permanentPhantomArenaActivityData.UpdateChallengeFinishConditions(phantomBattleChallengeInfo.PhantomBattleChallengeId, phantomBattleChallengeInfo.FinishConditions.ToList<int>());
				}
			}
		}

		// Token: 0x06035106 RID: 217350 RVA: 0x00C92C60 File Offset: 0x00C90E60
		[NullableContext(2)]
		private void OnMasterInfoNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleMasterInfoNotify phantomBattleMasterInfoNotify = (PhantomBattleMasterInfoNotify)msg;
			if (phantomBattleMasterInfoNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.UpdateMasterInfoByNotify(phantomBattleMasterInfoNotify);
		}

		// Token: 0x06035107 RID: 217351 RVA: 0x00C92C84 File Offset: 0x00C90E84
		[NullableContext(2)]
		private void OnBadgeInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleBadgeInfoUpdateNotify phantomBattleBadgeInfoUpdateNotify = (PhantomBattleBadgeInfoUpdateNotify)msg;
			if (phantomBattleBadgeInfoUpdateNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.AddBadgeListByNotify(phantomBattleBadgeInfoUpdateNotify);
			foreach (PhantomBattleBadgeInfo phantomBattleBadgeInfo in phantomBattleBadgeInfoUpdateNotify.PhantomBattleBadgeInfos)
			{
				PhantomArenaModel.Instance.BadgeUnlockQueue.Add(phantomBattleBadgeInfo.PhantomBattleBadgeId);
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				PhantomArenaController.Instance.PostUnlockView();
			}
		}

		// Token: 0x06035108 RID: 217352 RVA: 0x00C92D0C File Offset: 0x00C90F0C
		[NullableContext(2)]
		private void OnBadgeRewardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleBadgeRewardInfoUpdateNotify phantomBattleBadgeRewardInfoUpdateNotify = (PhantomBattleBadgeRewardInfoUpdateNotify)msg;
			if (phantomBattleBadgeRewardInfoUpdateNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.UpdateBadgeRewardByNotify(phantomBattleBadgeRewardInfoUpdateNotify);
		}

		// Token: 0x06035109 RID: 217353 RVA: 0x00C92D30 File Offset: 0x00C90F30
		[NullableContext(2)]
		private void OnCardRewardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleCardRewardInfoUpdateNotify phantomBattleCardRewardInfoUpdateNotify = (PhantomBattleCardRewardInfoUpdateNotify)msg;
			if (phantomBattleCardRewardInfoUpdateNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.UpdateCardRewardByNotify(phantomBattleCardRewardInfoUpdateNotify);
		}

		// Token: 0x0603510A RID: 217354 RVA: 0x00C92D54 File Offset: 0x00C90F54
		[NullableContext(2)]
		private void OnRoleInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleRoleInfoUpdateNotify phantomBattleRoleInfoUpdateNotify = (PhantomBattleRoleInfoUpdateNotify)msg;
			if (phantomBattleRoleInfoUpdateNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.AddRoleByNotify(phantomBattleRoleInfoUpdateNotify);
			if (!GameModeController.Instance.IsInInstance() || PhantomArenaController.Instance.CheckInPhantomArenaDungeon())
			{
				foreach (PhantomBattleRoleInfo phantomBattleRoleInfo in phantomBattleRoleInfoUpdateNotify.PhantomBattleRoleInfos)
				{
					if (!PhantomArenaConfig.Instance.GetPhantomBattleCardRole(phantomBattleRoleInfo.PhantomBattleRoleId).IsTrail)
					{
						PhantomArenaModel.Instance.RoleUnlockQueue.Add(phantomBattleRoleInfo.PhantomBattleRoleId);
					}
				}
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				PhantomArenaController.Instance.PostUnlockView();
			}
		}

		// Token: 0x0603510B RID: 217355 RVA: 0x00C92E10 File Offset: 0x00C91010
		public bool CheckInPhantomArenaDungeon()
		{
			if (GameModeController.Instance.IsInInstance())
			{
				int instanceId = CreatureModel.Instance.GetInstanceId();
				InstanceDungeon? config = InstanceDungeonConfig.Instance.GetConfig(instanceId);
				return config != null && config.GetValueOrDefault().InstSubType == 36;
			}
			return false;
		}

		// Token: 0x0603510C RID: 217356 RVA: 0x00C92E60 File Offset: 0x00C91060
		[NullableContext(2)]
		private void OnCardInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleCardInfoUpdateNotify phantomBattleCardInfoUpdateNotify = (PhantomBattleCardInfoUpdateNotify)msg;
			if (phantomBattleCardInfoUpdateNotify == null)
			{
				return;
			}
			if (!GameModeController.Instance.IsInInstance())
			{
				foreach (PhantomBattleCardInfo phantomBattleCardInfo in phantomBattleCardInfoUpdateNotify.PhantomBattleCardInfos)
				{
					int phantomBattleCardId = phantomBattleCardInfo.PhantomBattleCardId;
					int num = PhantomArenaModel.Instance.IsCardUnlock(phantomBattleCardId) ? 1 : 0;
					bool isUnlock = phantomBattleCardInfo.IsUnlock;
					if (num == 0 && isUnlock)
					{
						PhantomArenaModel.Instance.CardUnlockQueue.Add(phantomBattleCardId);
					}
					int num2 = PhantomArenaModel.Instance.IsCardOutlookUnlock(phantomBattleCardId) ? 1 : 0;
					bool isUnlockOutLook = phantomBattleCardInfo.IsUnlockOutLook;
					if (num2 == 0 && isUnlockOutLook)
					{
						PhantomArenaModel.Instance.CardOutlookUnlockQueue.Add(phantomBattleCardId);
					}
				}
			}
			PhantomArenaModel.Instance.AddCardListByNotify(phantomBattleCardInfoUpdateNotify);
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x0603510D RID: 217357 RVA: 0x00C92F34 File Offset: 0x00C91134
		[NullableContext(2)]
		private void OnTaskInfoUpdateNotify(IMessage msg, Net.CallbackStatus status)
		{
			PhantomBattleTaskInfoNotify phantomBattleTaskInfoNotify = (PhantomBattleTaskInfoNotify)msg;
			if (phantomBattleTaskInfoNotify == null)
			{
				return;
			}
			PhantomArenaModel.Instance.UpdateTaskInfo(phantomBattleTaskInfoNotify);
		}

		// Token: 0x0603510E RID: 217358 RVA: 0x00C92F58 File Offset: 0x00C91158
		public void TaskRewardRequest(int taskId)
		{
			PhantomBattleTaskRewardRequest phantomBattleTaskRewardRequest = PhantomBattleTaskRewardRequest.Create();
			phantomBattleTaskRewardRequest.TaskId = taskId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleTaskRewardRequest, phantomBattleTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleTaskRewardResponse phantomBattleTaskRewardResponse = (PhantomBattleTaskRewardResponse)msg;
				if (phantomBattleTaskRewardResponse == null)
				{
					return;
				}
				if (phantomBattleTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleTaskRewardResponse.ErrorCode, 23918, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateTaskByIds(new List<int>
				{
					taskId
				});
			}, 0);
		}

		// Token: 0x0603510F RID: 217359 RVA: 0x00C92FA4 File Offset: 0x00C911A4
		public void TaskAllRewardRequest(int taskId)
		{
			PhantomBattleTask? taskConfigById = PhantomArenaConfig.Instance.GetTaskConfigById(taskId);
			if (taskConfigById == null)
			{
				return;
			}
			List<int> taskIds = PhantomArenaModel.Instance.GetAllCanReceiveTaskIdsByTabId(taskConfigById.Value.ActivityId, taskConfigById.Value.TaskType);
			PhantomBattleRepeatedTaskRewardRequest phantomBattleRepeatedTaskRewardRequest = PhantomBattleRepeatedTaskRewardRequest.Create();
			phantomBattleRepeatedTaskRewardRequest.TaskId.Add(taskIds);
			Net.Instance.Call(ERequestMessageId.PhantomBattleRepeatedTaskRewardRequest, phantomBattleRepeatedTaskRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleRepeatedTaskRewardResponse phantomBattleRepeatedTaskRewardResponse = (PhantomBattleRepeatedTaskRewardResponse)msg;
				if (phantomBattleRepeatedTaskRewardResponse == null)
				{
					return;
				}
				if (phantomBattleRepeatedTaskRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleRepeatedTaskRewardResponse.ErrorCode, 29535, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateTaskByIds(taskIds);
			}, 0);
		}

		// Token: 0x06035110 RID: 217360 RVA: 0x00C93030 File Offset: 0x00C91230
		public void MasterLevelMultiRewardRequest(int[] levelConfigIds, int activityId)
		{
			MulPhantomBattleMasterLevelRewardRequest mulPhantomBattleMasterLevelRewardRequest = MulPhantomBattleMasterLevelRewardRequest.Create();
			mulPhantomBattleMasterLevelRewardRequest.PhantomBattleMasterLevelId.Add(levelConfigIds);
			mulPhantomBattleMasterLevelRewardRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.MulPhantomBattleMasterLevelRewardRequest, mulPhantomBattleMasterLevelRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				MulPhantomBattleMasterLevelRewardResponse mulPhantomBattleMasterLevelRewardResponse = (MulPhantomBattleMasterLevelRewardResponse)msg;
				if (mulPhantomBattleMasterLevelRewardResponse == null)
				{
					return;
				}
				if (mulPhantomBattleMasterLevelRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulPhantomBattleMasterLevelRewardResponse.ErrorCode, 21948, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateMasterLevelByConfigIds(levelConfigIds.ToList<int>(), activityId);
			}, 0);
		}

		// Token: 0x06035111 RID: 217361 RVA: 0x00C93094 File Offset: 0x00C91294
		public void BadgeRewardRequest(int[] rewardIds, int activityId)
		{
			PhantomBattleBadgeRewardRequest phantomBattleBadgeRewardRequest = PhantomBattleBadgeRewardRequest.Create();
			phantomBattleBadgeRewardRequest.ActivityId = activityId;
			phantomBattleBadgeRewardRequest.BadgeRewardId.Add(rewardIds);
			Net.Instance.Call(ERequestMessageId.PhantomBattleBadgeRewardRequest, phantomBattleBadgeRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleBadgeRewardResponse phantomBattleBadgeRewardResponse = (PhantomBattleBadgeRewardResponse)msg;
				if (phantomBattleBadgeRewardResponse == null)
				{
					return;
				}
				if (phantomBattleBadgeRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleBadgeRewardResponse.ErrorCode, 23918, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateBadgeRewardByIds(rewardIds.ToList<int>());
			}, 0);
		}

		// Token: 0x06035112 RID: 217362 RVA: 0x00C930EC File Offset: 0x00C912EC
		[NullableContext(2)]
		public void CardOutLookUpRequest(int cardId, Action<int> successCallBack = null)
		{
			PhantomBattleCardOutLookUpRequest phantomBattleCardOutLookUpRequest = PhantomBattleCardOutLookUpRequest.Create();
			phantomBattleCardOutLookUpRequest.CardId = cardId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardOutLookUpRequest, phantomBattleCardOutLookUpRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardOutLookUpResponse phantomBattleCardOutLookUpResponse = (PhantomBattleCardOutLookUpResponse)msg;
				if (phantomBattleCardOutLookUpResponse == null)
				{
					return;
				}
				if (phantomBattleCardOutLookUpResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardOutLookUpResponse.ErrorCode, 21447, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.OnCardOutlookUnlock(cardId);
				PhantomArenaModel.Instance.CardOutlookUnlockQueue.Add(cardId);
				PhantomArenaController.Instance.PostUnlockView();
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(cardId);
			}, 0);
		}

		// Token: 0x06035113 RID: 217363 RVA: 0x00C9313C File Offset: 0x00C9133C
		public void CardRewardRequest(int[] rewardIds, int activityId)
		{
			PhantomBattleCardRewardRequest phantomBattleCardRewardRequest = PhantomBattleCardRewardRequest.Create();
			phantomBattleCardRewardRequest.ActivityId = activityId;
			phantomBattleCardRewardRequest.CardRewardId.Add(rewardIds);
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardRewardRequest, phantomBattleCardRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardRewardResponse phantomBattleCardRewardResponse = (PhantomBattleCardRewardResponse)msg;
				if (phantomBattleCardRewardResponse == null)
				{
					return;
				}
				if (phantomBattleCardRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardRewardResponse.ErrorCode, 23918, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateCardRewardByIds(rewardIds.ToList<int>());
			}, 0);
		}

		// Token: 0x06035114 RID: 217364 RVA: 0x00C93194 File Offset: 0x00C91394
		[NullableContext(2)]
		public void RoleRewardRequest(int cardRoleId, Action<int> successCallBack = null)
		{
			PhantomBattleRoleRewardRequest phantomBattleRoleRewardRequest = PhantomBattleRoleRewardRequest.Create();
			phantomBattleRoleRewardRequest.PhantomBattleRoleId = cardRoleId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleRoleRewardRequest, phantomBattleRoleRewardRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleRoleRewardResponse phantomBattleRoleRewardResponse = (PhantomBattleRoleRewardResponse)msg;
				if (phantomBattleRoleRewardResponse == null)
				{
					return;
				}
				if (phantomBattleRoleRewardResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleRoleRewardResponse.ErrorCode, 21447, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.OnRoleReward(cardRoleId);
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(cardRoleId);
			}, 0);
		}

		// Token: 0x06035115 RID: 217365 RVA: 0x00C931E4 File Offset: 0x00C913E4
		public void CardGroupAddRequest(string name, int[] cardIdList, int activityId, [Nullable(2)] Action<int> successCallBack = null)
		{
			PhantomBattleCardGroupAddRequest phantomBattleCardGroupAddRequest = PhantomBattleCardGroupAddRequest.Create();
			phantomBattleCardGroupAddRequest.Name = name;
			phantomBattleCardGroupAddRequest.EquipCardIds.Add(cardIdList);
			phantomBattleCardGroupAddRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardGroupAddRequest, phantomBattleCardGroupAddRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardGroupAddResponse phantomBattleCardGroupAddResponse = (PhantomBattleCardGroupAddResponse)msg;
				if (phantomBattleCardGroupAddResponse == null)
				{
					return;
				}
				if (phantomBattleCardGroupAddResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupAddResponse.ErrorCode, 17478, null, true, true);
					return;
				}
				if (phantomBattleCardGroupAddResponse.PhantomBattleCardGroupInfo == null)
				{
					Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "创建卡组时服务器返回数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				Aki.Protocol.PhantomBattleCardGroupInfo phantomBattleCardGroupInfo = phantomBattleCardGroupAddResponse.PhantomBattleCardGroupInfo;
				PhantomArenaModel.Instance.AddProtocolDeckInfo(phantomBattleCardGroupInfo, activityId);
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(phantomBattleCardGroupInfo.Index);
			}, 0);
		}

		// Token: 0x06035116 RID: 217366 RVA: 0x00C93248 File Offset: 0x00C91448
		[NullableContext(2)]
		public void CardGroupDeleteRequest(int deckServerId, int activityId, Action<int> successCallBack = null)
		{
			PhantomBattleCardGroupDeleteRequest phantomBattleCardGroupDeleteRequest = PhantomBattleCardGroupDeleteRequest.Create();
			phantomBattleCardGroupDeleteRequest.Index = deckServerId;
			phantomBattleCardGroupDeleteRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardGroupDeleteRequest, phantomBattleCardGroupDeleteRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardGroupDeleteResponse phantomBattleCardGroupDeleteResponse = (PhantomBattleCardGroupDeleteResponse)msg;
				if (phantomBattleCardGroupDeleteResponse == null)
				{
					return;
				}
				if (phantomBattleCardGroupDeleteResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupDeleteResponse.ErrorCode, 29932, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateDeckList(phantomBattleCardGroupDeleteResponse.PhantomBattleCardGroupInfo, activityId);
				PhantomArenaModel.Instance.SetLastUsedCardDeckServerId(phantomBattleCardGroupDeleteResponse.LastUseCardGroupIndex, activityId);
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(deckServerId);
			}, 0);
		}

		// Token: 0x06035117 RID: 217367 RVA: 0x00C932AC File Offset: 0x00C914AC
		public void CardGroupUpdateRequest(int deckServerId, int[] cardIds, int activityId, [Nullable(2)] Action<int> successCallBack = null)
		{
			PhantomBattleCardGroupUpdateRequest phantomBattleCardGroupUpdateRequest = PhantomBattleCardGroupUpdateRequest.Create();
			phantomBattleCardGroupUpdateRequest.Index = deckServerId;
			phantomBattleCardGroupUpdateRequest.EquipCardIds.Add(cardIds);
			phantomBattleCardGroupUpdateRequest.ActivityId = activityId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardGroupUpdateRequest, phantomBattleCardGroupUpdateRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardGroupUpdateResponse phantomBattleCardGroupUpdateResponse = (PhantomBattleCardGroupUpdateResponse)msg;
				if (phantomBattleCardGroupUpdateResponse == null)
				{
					return;
				}
				if (phantomBattleCardGroupUpdateResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupUpdateResponse.ErrorCode, 26320, null, true, true);
					return;
				}
				Aki.Protocol.PhantomBattleCardGroupInfo phantomBattleCardGroupInfo = phantomBattleCardGroupUpdateResponse.PhantomBattleCardGroupInfo;
				if (phantomBattleCardGroupInfo == null)
				{
					Log.Instance.Error(ELogModule.PhantomArena, ELogAuthor.LZK, "更新卡组时服务器返回数据为空", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				PhantomArenaModel.Instance.UpdateProtocolDeckInfo(phantomBattleCardGroupInfo, activityId);
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(deckServerId);
			}, 0);
		}

		// Token: 0x06035118 RID: 217368 RVA: 0x00C9331C File Offset: 0x00C9151C
		[NullableContext(0)]
		public UniTask<Aki.Protocol.ErrorCode> CardGroupNameRequest([Nullable(1)] string newName, int deckServerId, int activityId)
		{
			PhantomArenaController.<CardGroupNameRequest>d__35 <CardGroupNameRequest>d__;
			<CardGroupNameRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<Aki.Protocol.ErrorCode>.Create();
			<CardGroupNameRequest>d__.newName = newName;
			<CardGroupNameRequest>d__.deckServerId = deckServerId;
			<CardGroupNameRequest>d__.activityId = activityId;
			<CardGroupNameRequest>d__.<>1__state = -1;
			<CardGroupNameRequest>d__.<>t__builder.Start<PhantomArenaController.<CardGroupNameRequest>d__35>(ref <CardGroupNameRequest>d__);
			return <CardGroupNameRequest>d__.<>t__builder.Task;
		}

		// Token: 0x06035119 RID: 217369 RVA: 0x00C93370 File Offset: 0x00C91570
		[NullableContext(2)]
		public void CardUnlockRequest(int cardId, Action<int> successCallBack = null)
		{
			PhantomBattleCardUnlockRequest phantomBattleCardUnlockRequest = PhantomBattleCardUnlockRequest.Create();
			phantomBattleCardUnlockRequest.CardId = cardId;
			Net.Instance.Call(ERequestMessageId.PhantomBattleCardUnlockRequest, phantomBattleCardUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCardUnlockResponse phantomBattleCardUnlockResponse = (PhantomBattleCardUnlockResponse)msg;
				if (phantomBattleCardUnlockResponse == null)
				{
					return;
				}
				if (phantomBattleCardUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardUnlockResponse.ErrorCode, 16683, null, true, true);
					return;
				}
				Action<int> successCallBack2 = successCallBack;
				if (successCallBack2 == null)
				{
					return;
				}
				successCallBack2(cardId);
			}, 0);
		}

		// Token: 0x0603511A RID: 217370 RVA: 0x00C933C0 File Offset: 0x00C915C0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<PhantomBattleReChallengeResponse> ReChallengeRequestAsync(int challengeId)
		{
			PhantomArenaController.<ReChallengeRequestAsync>d__37 <ReChallengeRequestAsync>d__;
			<ReChallengeRequestAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<PhantomBattleReChallengeResponse>.Create();
			<ReChallengeRequestAsync>d__.challengeId = challengeId;
			<ReChallengeRequestAsync>d__.<>1__state = -1;
			<ReChallengeRequestAsync>d__.<>t__builder.Start<PhantomArenaController.<ReChallengeRequestAsync>d__37>(ref <ReChallengeRequestAsync>d__);
			return <ReChallengeRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603511B RID: 217371 RVA: 0x00C93404 File Offset: 0x00C91604
		public bool PostUnlockView()
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.PhantomArenaRoleUnlockView) || UiManager.Instance.IsViewOpen(EUiViewName.PhantomArenaBadgeUnlockView) || UiManager.Instance.IsViewOpen(EUiViewName.PhantomArenaCardsRewardView) || UiManager.Instance.IsViewOpen(EUiViewName.PhantomArenaCardOutlookRewardView))
			{
				return false;
			}
			if (GameModeController.Instance.IsInInstance())
			{
				return false;
			}
			if (PhantomArenaModel.Instance.RoleUnlockQueue.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaRoleUnlockView, null, null);
				return true;
			}
			List<int> cardUnlockQueue = PhantomArenaModel.Instance.CardUnlockQueue;
			if (cardUnlockQueue.Count > 0)
			{
				Action callbackClose = delegate()
				{
					PhantomArenaController.Instance.PostUnlockView();
				};
				PhantomArenaBattleController.Instance.PhantomBattleResultShowCards(cardUnlockQueue, callbackClose);
				return true;
			}
			if (PhantomArenaModel.Instance.CardOutlookUnlockQueue.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaCardOutlookRewardView, null, null);
				return true;
			}
			if (PhantomArenaModel.Instance.BadgeUnlockQueue.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaBadgeUnlockView, null, null);
				return true;
			}
			if (PhantomArenaModel.Instance.EntranceOpenQueue && PhantomArenaController.Instance.OpenEntranceViewActivityId != 0)
			{
				UiManager.Instance.OpenView(EUiViewName.PhantomArenaEntranceView, PhantomArenaController.Instance.OpenEntranceViewActivityId, null);
				PhantomArenaModel.Instance.EntranceOpenQueue = false;
				PhantomArenaController.Instance.OpenEntranceViewActivityId = 0;
				return true;
			}
			return true;
		}

		// Token: 0x0603511C RID: 217372 RVA: 0x00C93566 File Offset: 0x00C91766
		public void OpenPhantomArenaConfirmBoxView(ConfirmBoxDataNew data, bool isNew = false)
		{
			data.CustomPopType = new EUiBehaviourPopType?(EUiBehaviourPopType.PhantomArenaSmall);
			if (isNew)
			{
				data.CustomResourceId = "UiItem_SoundRemnantArenaTipsInfo_New";
			}
			else
			{
				data.CustomResourceId = "UiItem_SoundRemnantArenaTipsInfo";
			}
			ConfirmBoxController.Instance.ShowConfirmBoxNew(data);
		}

		// Token: 0x0603511D RID: 217373 RVA: 0x00C9359C File Offset: 0x00C9179C
		public void UpdateCardDetailLockState(UpdateCardDetailLockStateContext context)
		{
			if (context.IsUnLocked)
			{
				context.UnlockBtnItem.SetActive(false);
				context.TipText.SetUIActive(false);
				context.LockTipItem.SetUIActive(false);
				return;
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(context.CardId);
			if (!phantomBattleCardConfig.EnableBuy)
			{
				context.LockTipItem.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(context.LockTipText, phantomBattleCardConfig.ConditionDesc, Array.Empty<object>());
				context.TipText.SetUIActive(false);
				context.UnlockBtnItem.SetActive(false);
				return;
			}
			EFunctionType functionId = PhantomArenaModel.Instance.IsNewPhantomArenaActivity(phantomBattleCardConfig.ActivityId) ? EFunctionType.PermanentPhantomArenaCardUnlock : EFunctionType.PhantomArenaCardUnlock;
			if (!FunctionModel.Instance.IsOpen(functionId))
			{
				context.TipText.SetUIActive(false);
				context.LockTipItem.SetUIActive(false);
				context.UnlockBtnItem.SetActive(true);
				context.UnlockBtnItem.SetEnableClick(false);
				context.UnlockBtnItem.SetLocalTextNew("GenericPrompt_Unlocked_TipsText", Array.Empty<object>());
				return;
			}
			int itemId = phantomBattleCardConfig.UnlockConsumeItems()[0].ItemId;
			int count = phantomBattleCardConfig.UnlockConsumeItems()[0].Count;
			bool flag = InventoryModel.Instance.GetItemCountByConfigId(itemId, 0) >= count;
			context.TipText.SetUIActive(true);
			context.LockTipItem.SetUIActive(false);
			context.UnlockBtnItem.SetActive(true);
			context.UnlockBtnItem.SetEnableClick(flag);
			context.UnlockBtnItem.SetRedDotVisible(context.ShowUnlockRedDotWhenCanUnlock && flag);
			context.UnlockBtnItem.SetLocalTextNew("PhantomBattle_1010", Array.Empty<object>());
			string iconSmall = ItemConfig.Instance.GetConfig(itemId).Value.IconSmall;
			string textStringId = flag ? "PhantomBattle_1012" : "PhantomBattle_1011";
			LguiUtil.Instance.SetLocalTextNew(context.TipText, textStringId, new <>z__ReadOnlyArray<object>(new object[]
			{
				iconSmall,
				count
			}));
		}

		// Token: 0x0603511E RID: 217374 RVA: 0x00C93794 File Offset: 0x00C91994
		public void ReportDeckUpdate(PhantomArenaReportDeckUpdateContext context)
		{
			PhantomArenaDeckUpdateEvent phantomArenaDeckUpdateEvent = new PhantomArenaDeckUpdateEvent();
			DeckInfo deckInfo = context.DeckInfo;
			phantomArenaDeckUpdateEvent.i_activity_id = context.ActivityId;
			phantomArenaDeckUpdateEvent.i_deck_order = deckInfo.GetDeckServerId() + 1;
			phantomArenaDeckUpdateEvent.s_deck_name = deckInfo.GetDeckName();
			phantomArenaDeckUpdateEvent.i_operation = (int)context.Operation;
			List<DeckCardSlotInfo> cardSlotList = deckInfo.GetCardSlotList();
			Dictionary<int, PhantomArenaReportCardInfo> dictionary = new Dictionary<int, PhantomArenaReportCardInfo>();
			foreach (DeckCardSlotInfo deckCardSlotInfo in cardSlotList)
			{
				int cardId = deckCardSlotInfo.CardId;
				int cost = deckCardSlotInfo.Cost;
				PhantomArenaReportCardInfo phantomArenaReportCardInfo;
				if (!dictionary.TryGetValue(cost, out phantomArenaReportCardInfo))
				{
					phantomArenaReportCardInfo = new PhantomArenaReportCardInfo(cost);
					dictionary[cost] = phantomArenaReportCardInfo;
				}
				for (int i = 0; i < deckCardSlotInfo.Count; i++)
				{
					phantomArenaReportCardInfo.CardIdList.Add(cardId);
				}
			}
			phantomArenaDeckUpdateEvent.o_deck_info = dictionary.Values.ToArray<PhantomArenaReportCardInfo>();
			phantomArenaDeckUpdateEvent.i_build_id = context.LastQuicklyBuildId;
			List<string> list = new List<string>();
			foreach (KeyValuePair<int, int> keyValuePair in context.QuicklyBuildDeckUseTimes)
			{
				if (keyValuePair.Value > 0)
				{
					List<string> list2 = list;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Key);
					defaultInterpolatedStringHandler.AppendLiteral(":");
					defaultInterpolatedStringHandler.AppendFormatted<int>(keyValuePair.Value);
					list2.Add(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
			phantomArenaDeckUpdateEvent.o_build_click = string.Join("", list);
			phantomArenaDeckUpdateEvent.i_deck_status = ((deckInfo.GetCanUse() > false) ? 1 : 0);
			int fieldCardConditionCurNum = deckInfo.GetFieldCardConditionCurNum();
			int fieldCardConditionTargetNum = deckInfo.GetFieldCardConditionTargetNum();
			phantomArenaDeckUpdateEvent.i_special_effect = ((fieldCardConditionTargetNum != 0 && fieldCardConditionCurNum >= fieldCardConditionTargetNum) ? 1 : 0);
			LogReportController.Instance.LogReport(phantomArenaDeckUpdateEvent);
		}

		// Token: 0x0603511F RID: 217375 RVA: 0x00C93974 File Offset: 0x00C91B74
		public void OpenDeckBuilderCardInfoViewWithoutOutlookTab(int cardId)
		{
			DeckBuilderCardInfoViewData param = new DeckBuilderCardInfoViewData
			{
				CurCardId = cardId,
				NeedOutlookTab = false
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x06035120 RID: 217376 RVA: 0x00C939A8 File Offset: 0x00C91BA8
		public void RequestCheckCardSkillUnlock(DeckInfo deckInfo, Action<PhantomBattleCheckCardSkillUnlockResponse> callback)
		{
			if (deckInfo.GetFieldCardSlot() == null)
			{
				return;
			}
			PhantomBattleCheckCardSkillUnlockRequest phantomBattleCheckCardSkillUnlockRequest = PhantomBattleCheckCardSkillUnlockRequest.Create();
			List<int> cardIdList = deckInfo.GetCardIdList();
			phantomBattleCheckCardSkillUnlockRequest.CardConfig.Add(cardIdList);
			Net.Instance.Call(ERequestMessageId.PhantomBattleCheckCardSkillUnlockRequest, phantomBattleCheckCardSkillUnlockRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				PhantomBattleCheckCardSkillUnlockResponse phantomBattleCheckCardSkillUnlockResponse = (PhantomBattleCheckCardSkillUnlockResponse)msg;
				if (phantomBattleCheckCardSkillUnlockResponse == null)
				{
					return;
				}
				if (phantomBattleCheckCardSkillUnlockResponse.ErrorCode != Aki.Protocol.ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCheckCardSkillUnlockResponse.ErrorCode, 18934, null, true, true);
					return;
				}
				deckInfo.SetFieldCardConditionProgress(phantomBattleCheckCardSkillUnlockResponse.CurNum, phantomBattleCheckCardSkillUnlockResponse.TargetNum);
				callback(phantomBattleCheckCardSkillUnlockResponse);
			}, 0);
		}

		// Token: 0x06035121 RID: 217377 RVA: 0x00C93A14 File Offset: 0x00C91C14
		public void CreateTempActivityData()
		{
			ActivityData activityData = ActivityData.Create();
			activityData.Id = 105200001;
			activityData.Type = ActivityType.PhantomBattle;
			activityData.PhantomBattleActivityInfo = PhantomBattleActivityInfo.Create();
			ActivityModel.Instance.OnActivityUpdate(new ActivityData[]
			{
				activityData
			});
		}

		// Token: 0x1700809D RID: 32925
		// (get) Token: 0x06035122 RID: 217378 RVA: 0x00C93A59 File Offset: 0x00C91C59
		public static PhantomArenaController Instance
		{
			get
			{
				return PhantomArenaController._Instance;
			}
		}

		// Token: 0x06035123 RID: 217379 RVA: 0x00C93A60 File Offset: 0x00C91C60
		public static PhantomArenaController GetOrCreateInstance()
		{
			if (PhantomArenaController._Instance == null)
			{
				PhantomArenaController.CreateInstance();
			}
			return PhantomArenaController._Instance;
		}

		// Token: 0x06035124 RID: 217380 RVA: 0x00C93A74 File Offset: 0x00C91C74
		public static bool CreateInstance()
		{
			if (PhantomArenaController._Instance != null)
			{
				return true;
			}
			PhantomArenaController._Instance = new PhantomArenaController();
			return true;
		}

		// Token: 0x06035125 RID: 217381 RVA: 0x00C93A8A File Offset: 0x00C91C8A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035126 RID: 217382 RVA: 0x00C93A8C File Offset: 0x00C91C8C
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaController._Instance = null;
		}

		// Token: 0x06035127 RID: 217383 RVA: 0x00C93A94 File Offset: 0x00C91C94
		static PhantomArenaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaController.CreateStaticDefaultValue), new Action(PhantomArenaController.ResetStaticDefaultValue));
		}

		// Token: 0x0401C3B1 RID: 115633
		private bool EventsRegistered;

		// Token: 0x0401C3B2 RID: 115634
		private bool NetRegistered;

		// Token: 0x0401C3B3 RID: 115635
		private int OpenEntranceViewActivityId;

		// Token: 0x0401C3B4 RID: 115636
		[Nullable(2)]
		private static PhantomArenaController _Instance;
	}
}
