using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.DeadRevive;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Ui;
using Google.Protobuf;

namespace CSharpScript.Game.LevelGamePlay.ResetPlayer
{
	// Token: 0x02005C10 RID: 23568
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerController : ControllerBase
	{
		// Token: 0x06039E09 RID: 237065 RVA: 0x01045B54 File Offset: 0x01043D54
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ActionResetPosPrePerformanceNotify, new Action<IMessage, Net.CallbackStatus>(this.ActionResetPosPrePerformanceNotify));
			return true;
		}

		// Token: 0x06039E0A RID: 237066 RVA: 0x01045B73 File Offset: 0x01043D73
		protected override bool OnLeaveLevel()
		{
			this.StopReset();
			return true;
		}

		// Token: 0x06039E0B RID: 237067 RVA: 0x01045B7C File Offset: 0x01043D7C
		protected override bool OnChangeMode()
		{
			this.StopReset();
			return true;
		}

		// Token: 0x06039E0C RID: 237068 RVA: 0x01045B85 File Offset: 0x01043D85
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ActionResetPosPrePerformanceNotify);
			return true;
		}

		// Token: 0x06039E0D RID: 237069 RVA: 0x01045B98 File Offset: 0x01043D98
		[NullableContext(2)]
		private void ActionResetPosPrePerformanceNotify(IMessage msg, Net.CallbackStatus _)
		{
			ActionResetPosPrePerformanceNotify actionResetPosPrePerformanceNotify = (ActionResetPosPrePerformanceNotify)msg;
			IActionResetReplyData replyData = new IActionResetReplyData
			{
				PlayerId = actionResetPosPrePerformanceNotify.PlayerId,
				IncId = actionResetPosPrePerformanceNotify.IncId,
				Index = actionResetPosPrePerformanceNotify.Index
			};
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			BaseTagComponent baseTagComponent;
			if (getCurrentEntity == null)
			{
				baseTagComponent = null;
			}
			else
			{
				WorldEntity entity = getCurrentEntity.Entity;
				baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (SceneTeamModel.Instance.IsAllDid() || (baseTagComponent2 != null && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"])))
			{
				global::Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.LYY, "玩家重置时正在溺水或已死亡，不执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.InterruptExecuteRequest(replyData);
				return;
			}
			ResetPlayerModel instance = ResetPlayerModel.Instance;
			if (instance.IsReseting)
			{
				global::Log.Instance.Warn(ELogModule.LevelPlay, ELogAuthor.LYY, "玩家重置中，不可重复执行", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.InterruptExecuteRequest(replyData);
				return;
			}
			if (this.GetPlayerCueComp() == null)
			{
				global::Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "执行重置时，玩家实体不存在", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.InterruptExecuteRequest(replyData);
				return;
			}
			ResetPlayerPosWithPresentation resetPlayerPosWithPresentation = Json.Parse<ResetPlayerPosWithPresentation>(actionResetPosPrePerformanceNotify.Params, null);
			if (resetPlayerPosWithPresentation == null)
			{
				global::Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "执行重置时，参数错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.InterruptExecuteRequest(replyData);
				return;
			}
			IResetPresentationFailure presentation = resetPlayerPosWithPresentation.Presentation;
			if (presentation.Type != EResetPresentationType.Failure)
			{
				this.InterruptExecuteRequest(replyData);
				return;
			}
			IResetPresentationFailure resetPresentationFailure = presentation;
			List<int> gamePlayCues = resetPresentationFailure.GamePlayCues;
			instance.IsReseting = true;
			InputDistributeController.Instance.RefreshInputTag();
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.ResetPlayer, true);
			EntityHandle getCurrentEntity2 = SceneTeamModel.Instance.GetCurrentEntity;
			UeMovementTickManageComponent ueMovementTickManageComponent;
			if (getCurrentEntity2 == null)
			{
				ueMovementTickManageComponent = null;
			}
			else
			{
				WorldEntity entity2 = getCurrentEntity2.Entity;
				ueMovementTickManageComponent = ((entity2 != null) ? entity2.GetComponent<UeMovementTickManageComponent>() : null);
			}
			UeMovementTickManageComponent ueMovementTickManageComponent2 = ueMovementTickManageComponent;
			if (ueMovementTickManageComponent2 != null)
			{
				ueMovementTickManageComponent2.DisableByKey(EEntityDisableKey.ResetPlayer, true);
				instance.DisableMoveEntityHandle = getCurrentEntity2;
			}
			if (gamePlayCues != null)
			{
				BaseGameplayCueComponent playerCueComp = this.GetPlayerCueComp();
				if (playerCueComp != null)
				{
					foreach (int num in gamePlayCues)
					{
						instance.CueHandleSet.Add(playerCueComp.AddCue((long)num, null));
					}
				}
			}
			TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				this.ContinueExecuteRequest(replyData);
			}, resetPresentationFailure.Duration * 1000f, null, null, true, 1f);
		}

		// Token: 0x06039E0E RID: 237070 RVA: 0x01045E20 File Offset: 0x01044020
		private void InterruptExecuteRequest(IActionResetReplyData data)
		{
			ActionResetPosPrePerformanceEndRequest actionResetPosPrePerformanceEndRequest = new ActionResetPosPrePerformanceEndRequest();
			actionResetPosPrePerformanceEndRequest.ContinueExecute = false;
			actionResetPosPrePerformanceEndRequest.PlayerId = data.PlayerId;
			actionResetPosPrePerformanceEndRequest.IncId = data.IncId;
			actionResetPosPrePerformanceEndRequest.Index = data.Index;
			Net.Instance.Call(ERequestMessageId.ActionResetPosPrePerformanceEndRequest, actionResetPosPrePerformanceEndRequest, null, 0);
		}

		// Token: 0x06039E0F RID: 237071 RVA: 0x01045E70 File Offset: 0x01044070
		private void ContinueExecuteRequest(IActionResetReplyData data)
		{
			ActionResetPosPrePerformanceEndRequest actionResetPosPrePerformanceEndRequest = new ActionResetPosPrePerformanceEndRequest();
			actionResetPosPrePerformanceEndRequest.ContinueExecute = true;
			actionResetPosPrePerformanceEndRequest.PlayerId = data.PlayerId;
			actionResetPosPrePerformanceEndRequest.IncId = data.IncId;
			actionResetPosPrePerformanceEndRequest.Index = data.Index;
			Net.Instance.Call(ERequestMessageId.ActionResetPosPrePerformanceEndRequest, actionResetPosPrePerformanceEndRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				ActionResetPosPrePerformanceEndResponse actionResetPosPrePerformanceEndResponse = (ActionResetPosPrePerformanceEndResponse)msg;
				if (actionResetPosPrePerformanceEndResponse == null || actionResetPosPrePerformanceEndResponse.Code != ErrorCode.Success)
				{
					global::Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.LYY, "玩家重置请求传送失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.StopReset();
					return;
				}
				if (!TeleportModel.Instance.IsTeleport)
				{
					this.StopReset();
					return;
				}
				if (GameModeModel.Instance.LoadingPhase < ELoadingPhase.OpenLoadingEnd)
				{
					EventSystem.Instance.Add(EEventName.TeleportOpenLoadingEnd, new Action(this.OnTeleportOpenLoadingEnd));
				}
				else
				{
					this.RemovePlayerCue();
				}
				EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			}, 0);
		}

		// Token: 0x06039E10 RID: 237072 RVA: 0x01045ECB File Offset: 0x010440CB
		private void OnTeleportOpenLoadingEnd()
		{
			EventSystem.Instance.Remove(EEventName.TeleportOpenLoadingEnd, new Action(this.OnTeleportOpenLoadingEnd));
			this.RemovePlayerCue();
		}

		// Token: 0x06039E11 RID: 237073 RVA: 0x01045EEF File Offset: 0x010440EF
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext _)
		{
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			this.StopReset();
		}

		// Token: 0x06039E12 RID: 237074 RVA: 0x01045F14 File Offset: 0x01044114
		private void StopReset()
		{
			ResetPlayerModel instance = ResetPlayerModel.Instance;
			if (!instance.IsReseting)
			{
				return;
			}
			instance.IsReseting = false;
			InputDistributeController.Instance.RefreshInputTag();
			this.RemovePlayerCue();
			DeadReviveModel.Instance.SetSkipFallInjure(ESkipFallInjureReason.ResetPlayer, false);
			EntityHandle disableMoveEntityHandle = instance.DisableMoveEntityHandle;
			if (disableMoveEntityHandle != null && disableMoveEntityHandle.Valid)
			{
				WorldEntity entity = disableMoveEntityHandle.Entity;
				UeMovementTickManageComponent ueMovementTickManageComponent = (entity != null) ? entity.GetComponent<UeMovementTickManageComponent>() : null;
				if (ueMovementTickManageComponent != null)
				{
					ueMovementTickManageComponent.EnableByKey(EEntityDisableKey.ResetPlayer, true);
				}
			}
			instance.DisableMoveEntityHandle = null;
		}

		// Token: 0x06039E13 RID: 237075 RVA: 0x01045F8C File Offset: 0x0104418C
		private void RemovePlayerCue()
		{
			ResetPlayerModel instance = ResetPlayerModel.Instance;
			if (instance.CueHandleSet.Count <= 0)
			{
				return;
			}
			BaseGameplayCueComponent playerCueComp = this.GetPlayerCueComp();
			if (playerCueComp == null)
			{
				instance.CueHandleSet.Clear();
				return;
			}
			foreach (int num in instance.CueHandleSet)
			{
				playerCueComp.RemoveCueByHandle((long)num);
			}
		}

		// Token: 0x06039E14 RID: 237076 RVA: 0x0104600C File Offset: 0x0104420C
		[NullableContext(2)]
		private BaseGameplayCueComponent GetPlayerCueComp()
		{
			int playerId = CreatureModel.Instance.GetPlayerId();
			WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
			if (playerEntity == null)
			{
				return null;
			}
			return playerEntity.GetComponent<PlayerGameplayCueComponent>();
		}

		// Token: 0x17006E3C RID: 28220
		// (get) Token: 0x06039E15 RID: 237077 RVA: 0x0104603A File Offset: 0x0104423A
		public static ResetPlayerController Instance
		{
			get
			{
				return ResetPlayerController._Instance;
			}
		}

		// Token: 0x06039E16 RID: 237078 RVA: 0x01046041 File Offset: 0x01044241
		public static ResetPlayerController GetOrCreateInstance()
		{
			if (ResetPlayerController._Instance == null)
			{
				ResetPlayerController.CreateInstance();
			}
			return ResetPlayerController._Instance;
		}

		// Token: 0x06039E17 RID: 237079 RVA: 0x01046055 File Offset: 0x01044255
		public static bool CreateInstance()
		{
			if (ResetPlayerController._Instance != null)
			{
				return true;
			}
			ResetPlayerController._Instance = new ResetPlayerController();
			return true;
		}

		// Token: 0x06039E18 RID: 237080 RVA: 0x0104606B File Offset: 0x0104426B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06039E19 RID: 237081 RVA: 0x0104606D File Offset: 0x0104426D
		public static void ResetStaticDefaultValue()
		{
			ResetPlayerController._Instance = null;
		}

		// Token: 0x06039E1A RID: 237082 RVA: 0x01046075 File Offset: 0x01044275
		static ResetPlayerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResetPlayerController.CreateStaticDefaultValue), new Action(ResetPlayerController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E960 RID: 125280
		[Nullable(2)]
		private static ResetPlayerController _Instance;
	}
}
