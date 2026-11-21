using System;
using System.Collections.Generic;
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
	// Token: 0x020040D5 RID: 16597
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class PhantomArenaController : ActivityControllerBase
	{
		// Token: 0x06029FF1 RID: 172017 RVA: 0x00BDFC5F File Offset: 0x00BDDE5F
		protected override bool OnGetIsOpeningActivityRelativeView()
		{
			return false;
		}

		// Token: 0x06029FF2 RID: 172018 RVA: 0x00BDFC64 File Offset: 0x00BDDE64
		protected override void OnOpenView(ActivityBaseData data)
		{
			if (!data.GetPreGuideQuestFinishState())
			{
				UiManager.Instance.OpenView(EUiViewName.QuestView, data.GetUnFinishPreGuideQuestId(), null);
				return;
			}
			PhantomArenaBattleController.OpenPhantomArenaMapEntrance(null, null);
		}

		// Token: 0x06029FF3 RID: 172019 RVA: 0x00BDFCAC File Offset: 0x00BDDEAC
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

		// Token: 0x06029FF4 RID: 172020 RVA: 0x00BDFCF7 File Offset: 0x00BDDEF7
		protected override string OnGetActivityResource(ActivityBaseData data)
		{
			return "UiItem_SoundRemnantArenaMain";
		}

		// Token: 0x06029FF5 RID: 172021 RVA: 0x00BDFCFE File Offset: 0x00BDDEFE
		protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
		{
			return new PhantomArenaSubView();
		}

		// Token: 0x06029FF6 RID: 172022 RVA: 0x00BDFD05 File Offset: 0x00BDDF05
		protected override ActivityBaseData OnCreateActivityData(ActivityData data)
		{
			return new PhantomArenaActivityData();
		}

		// Token: 0x06029FF7 RID: 172023 RVA: 0x00BDFD0C File Offset: 0x00BDDF0C
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

		// Token: 0x06029FF8 RID: 172024 RVA: 0x00BDFE30 File Offset: 0x00BDE030
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

		// Token: 0x06029FF9 RID: 172025 RVA: 0x00BDFEE5 File Offset: 0x00BDE0E5
		protected override void OnAddEvents()
		{
			if (PhantomArenaController.Instance.EventsRegistered)
			{
				return;
			}
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			PhantomArenaController.Instance.EventsRegistered = true;
		}

		// Token: 0x06029FFA RID: 172026 RVA: 0x00BDFF1B File Offset: 0x00BDE11B
		protected override void OnRemoveEvents()
		{
			if (!PhantomArenaController.Instance.EventsRegistered)
			{
				return;
			}
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			PhantomArenaController.Instance.EventsRegistered = false;
		}

		// Token: 0x06029FFB RID: 172027 RVA: 0x00BDFF51 File Offset: 0x00BDE151
		private void OnWorldDone()
		{
			PhantomArenaController.Instance.PostUnlockView();
		}

		// Token: 0x06029FFC RID: 172028 RVA: 0x00BDFF60 File Offset: 0x00BDE160
		public override void OnShowActivityFirstUnlockView(ActivityBaseData data)
		{
			GenericPromptController.Instance.ShowPromptByItsType<object>(EPromptSubViewType.PhantomArenaOpen, null, null, null, null, null, null, null, null, false, null);
		}

		// Token: 0x06029FFD RID: 172029 RVA: 0x00BDFF94 File Offset: 0x00BDE194
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

		// Token: 0x06029FFE RID: 172030 RVA: 0x00BDFFB8 File Offset: 0x00BDE1B8
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
					permanentPhantomArenaActivityData.UpdateChallengeFinishConditions(phantomBattleChallengeInfo.PhantomBattleChallengeId, phantomBattleChallengeInfo.FinishConditions);
				}
			}
		}

		// Token: 0x06029FFF RID: 172031 RVA: 0x00BE0060 File Offset: 0x00BDE260
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

		// Token: 0x0602A000 RID: 172032 RVA: 0x00BE0084 File Offset: 0x00BDE284
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

		// Token: 0x0602A001 RID: 172033 RVA: 0x00BE010C File Offset: 0x00BDE30C
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

		// Token: 0x0602A002 RID: 172034 RVA: 0x00BE0130 File Offset: 0x00BDE330
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

		// Token: 0x0602A003 RID: 172035 RVA: 0x00BE0154 File Offset: 0x00BDE354
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

		// Token: 0x0602A004 RID: 172036 RVA: 0x00BE0210 File Offset: 0x00BDE410
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

		// Token: 0x0602A005 RID: 172037 RVA: 0x00BE0260 File Offset: 0x00BDE460
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

		// Token: 0x0602A006 RID: 172038 RVA: 0x00BE0334 File Offset: 0x00BDE534
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

		// Token: 0x0602A007 RID: 172039 RVA: 0x00BE0358 File Offset: 0x00BDE558
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleTaskRewardResponse.ErrorCode, 24417, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateTaskByIds(new List<int>
				{
					taskId
				});
			}, 0);
		}

		// Token: 0x0602A008 RID: 172040 RVA: 0x00BE03A4 File Offset: 0x00BDE5A4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleRepeatedTaskRewardResponse.ErrorCode, 16815, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateTaskByIds(taskIds);
			}, 0);
		}

		// Token: 0x0602A009 RID: 172041 RVA: 0x00BE0430 File Offset: 0x00BDE630
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(mulPhantomBattleMasterLevelRewardResponse.ErrorCode, 15639, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateMasterLevelByConfigIds(levelConfigIds, activityId);
			}, 0);
		}

		// Token: 0x0602A00A RID: 172042 RVA: 0x00BE0494 File Offset: 0x00BDE694
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleBadgeRewardResponse.ErrorCode, 24417, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateBadgeRewardByIds(new List<int>(rewardIds));
			}, 0);
		}

		// Token: 0x0602A00B RID: 172043 RVA: 0x00BE04EC File Offset: 0x00BDE6EC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardOutLookUpResponse.ErrorCode, 26978, null, true, true);
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

		// Token: 0x0602A00C RID: 172044 RVA: 0x00BE053C File Offset: 0x00BDE73C
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardRewardResponse.ErrorCode, 24417, null, true, true);
					return;
				}
				PhantomArenaModel.Instance.UpdateCardRewardByIds(new List<int>(rewardIds));
			}, 0);
		}

		// Token: 0x0602A00D RID: 172045 RVA: 0x00BE0594 File Offset: 0x00BDE794
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleRoleRewardResponse.ErrorCode, 26978, null, true, true);
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

		// Token: 0x0602A00E RID: 172046 RVA: 0x00BE05E4 File Offset: 0x00BDE7E4
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupAddResponse.ErrorCode, 16063, null, true, true);
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

		// Token: 0x0602A00F RID: 172047 RVA: 0x00BE0648 File Offset: 0x00BDE848
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupDeleteResponse.ErrorCode, 25229, null, true, true);
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

		// Token: 0x0602A010 RID: 172048 RVA: 0x00BE06AC File Offset: 0x00BDE8AC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardGroupUpdateResponse.ErrorCode, 19388, null, true, true);
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

		// Token: 0x0602A011 RID: 172049 RVA: 0x00BE071C File Offset: 0x00BDE91C
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

		// Token: 0x0602A012 RID: 172050 RVA: 0x00BE0770 File Offset: 0x00BDE970
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCardUnlockResponse.ErrorCode, 23550, null, true, true);
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

		// Token: 0x0602A013 RID: 172051 RVA: 0x00BE07C0 File Offset: 0x00BDE9C0
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

		// Token: 0x0602A014 RID: 172052 RVA: 0x00BE0804 File Offset: 0x00BDEA04
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

		// Token: 0x0602A015 RID: 172053 RVA: 0x00BE0966 File Offset: 0x00BDEB66
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

		// Token: 0x0602A016 RID: 172054 RVA: 0x00BE099C File Offset: 0x00BDEB9C
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

		// Token: 0x0602A017 RID: 172055 RVA: 0x00BE0B94 File Offset: 0x00BDED94
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
			PhantomArenaReportCardInfo[] array = new PhantomArenaReportCardInfo[dictionary.Count];
			dictionary.Values.CopyTo(array, 0);
			phantomArenaDeckUpdateEvent.o_deck_info = array;
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

		// Token: 0x0602A018 RID: 172056 RVA: 0x00BE0D88 File Offset: 0x00BDEF88
		public void OpenDeckBuilderCardInfoViewWithoutOutlookTab(int cardId)
		{
			DeckBuilderCardInfoViewData param = new DeckBuilderCardInfoViewData
			{
				CurCardId = cardId,
				NeedOutlookTab = false
			};
			UiManager.Instance.OpenView(EUiViewName.DeckBuilderCardInfoView, param, null);
		}

		// Token: 0x0602A019 RID: 172057 RVA: 0x00BE0DBC File Offset: 0x00BDEFBC
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
					ErrorCodeController.Instance.OpenErrorCodeTipView(phantomBattleCheckCardSkillUnlockResponse.ErrorCode, 22143, null, true, true);
					return;
				}
				deckInfo.SetFieldCardConditionProgress(phantomBattleCheckCardSkillUnlockResponse.CurNum, phantomBattleCheckCardSkillUnlockResponse.TargetNum);
				callback(phantomBattleCheckCardSkillUnlockResponse);
			}, 0);
		}

		// Token: 0x0602A01A RID: 172058 RVA: 0x00BE0E28 File Offset: 0x00BDF028
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

		// Token: 0x1700545D RID: 21597
		// (get) Token: 0x0602A01B RID: 172059 RVA: 0x00BE0E6D File Offset: 0x00BDF06D
		public static PhantomArenaController Instance
		{
			get
			{
				return PhantomArenaController._Instance;
			}
		}

		// Token: 0x0602A01C RID: 172060 RVA: 0x00BE0E74 File Offset: 0x00BDF074
		public static PhantomArenaController GetOrCreateInstance()
		{
			if (PhantomArenaController._Instance == null)
			{
				PhantomArenaController.CreateInstance();
			}
			return PhantomArenaController._Instance;
		}

		// Token: 0x0602A01D RID: 172061 RVA: 0x00BE0E88 File Offset: 0x00BDF088
		public static bool CreateInstance()
		{
			if (PhantomArenaController._Instance != null)
			{
				return true;
			}
			PhantomArenaController._Instance = new PhantomArenaController();
			return true;
		}

		// Token: 0x0602A01E RID: 172062 RVA: 0x00BE0E9E File Offset: 0x00BDF09E
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602A01F RID: 172063 RVA: 0x00BE0EA0 File Offset: 0x00BDF0A0
		public static void ResetStaticDefaultValue()
		{
			PhantomArenaController._Instance = null;
		}

		// Token: 0x0602A020 RID: 172064 RVA: 0x00BE0EA8 File Offset: 0x00BDF0A8
		static PhantomArenaController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PhantomArenaController.CreateStaticDefaultValue), new Action(PhantomArenaController.ResetStaticDefaultValue));
		}

		// Token: 0x04016DE4 RID: 93668
		private bool EventsRegistered;

		// Token: 0x04016DE5 RID: 93669
		private bool NetRegistered;

		// Token: 0x04016DE6 RID: 93670
		private int OpenEntranceViewActivityId;

		// Token: 0x04016DE7 RID: 93671
		[Nullable(2)]
		private static PhantomArenaController _Instance;
	}
}
