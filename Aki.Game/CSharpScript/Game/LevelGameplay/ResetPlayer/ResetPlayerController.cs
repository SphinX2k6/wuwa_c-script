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
	// Token: 0x02006AB3 RID: 27315
	[NullableContext(1)]
	[Nullable(0)]
	public class ResetPlayerController : ControllerBase
	{
		// Token: 0x06043DB2 RID: 277938 RVA: 0x010A1434 File Offset: 0x0109F634
		protected override bool OnInit()
		{
			Net.Instance.Register(ENotifyMessageId.ActionResetPosPrePerformanceNotify, new Action<IMessage, Net.CallbackStatus>(this.ActionResetPosPrePerformanceNotify));
			return true;
		}

		// Token: 0x06043DB3 RID: 277939 RVA: 0x010A1453 File Offset: 0x0109F653
		protected override bool OnLeaveLevel()
		{
			this.StopReset();
			return true;
		}

		// Token: 0x06043DB4 RID: 277940 RVA: 0x010A145C File Offset: 0x0109F65C
		protected override bool OnChangeMode()
		{
			this.StopReset();
			return true;
		}

		// Token: 0x06043DB5 RID: 277941 RVA: 0x010A1465 File Offset: 0x0109F665
		protected override bool OnClear()
		{
			Net.Instance.UnRegister(ENotifyMessageId.ActionResetPosPrePerformanceNotify);
			return true;
		}

		// Token: 0x06043DB6 RID: 277942 RVA: 0x010A1478 File Offset: 0x0109F678
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

		// Token: 0x06043DB7 RID: 277943 RVA: 0x010A1700 File Offset: 0x0109F900
		private void InterruptExecuteRequest(IActionResetReplyData data)
		{
			ActionResetPosPrePerformanceEndRequest actionResetPosPrePerformanceEndRequest = new ActionResetPosPrePerformanceEndRequest();
			actionResetPosPrePerformanceEndRequest.ContinueExecute = false;
			actionResetPosPrePerformanceEndRequest.PlayerId = data.PlayerId;
			actionResetPosPrePerformanceEndRequest.IncId = data.IncId;
			actionResetPosPrePerformanceEndRequest.Index = data.Index;
			Net.Instance.Call(ERequestMessageId.ActionResetPosPrePerformanceEndRequest, actionResetPosPrePerformanceEndRequest, null, 0);
		}

		// Token: 0x06043DB8 RID: 277944 RVA: 0x010A1750 File Offset: 0x0109F950
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

		// Token: 0x06043DB9 RID: 277945 RVA: 0x010A17AB File Offset: 0x0109F9AB
		private void OnTeleportOpenLoadingEnd()
		{
			EventSystem.Instance.Remove(EEventName.TeleportOpenLoadingEnd, new Action(this.OnTeleportOpenLoadingEnd));
			this.RemovePlayerCue();
		}

		// Token: 0x06043DBA RID: 277946 RVA: 0x010A17CF File Offset: 0x0109F9CF
		[NullableContext(2)]
		private void OnTeleportComplete(TeleportContext _)
		{
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			this.StopReset();
		}

		// Token: 0x06043DBB RID: 277947 RVA: 0x010A17F4 File Offset: 0x0109F9F4
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

		// Token: 0x06043DBC RID: 277948 RVA: 0x010A186C File Offset: 0x0109FA6C
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

		// Token: 0x06043DBD RID: 277949 RVA: 0x010A18EC File Offset: 0x0109FAEC
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

		// Token: 0x1700994E RID: 39246
		// (get) Token: 0x06043DBE RID: 277950 RVA: 0x010A191A File Offset: 0x0109FB1A
		public static ResetPlayerController Instance
		{
			get
			{
				return ResetPlayerController._Instance;
			}
		}

		// Token: 0x06043DBF RID: 277951 RVA: 0x010A1921 File Offset: 0x0109FB21
		public static ResetPlayerController GetOrCreateInstance()
		{
			if (ResetPlayerController._Instance == null)
			{
				ResetPlayerController.CreateInstance();
			}
			return ResetPlayerController._Instance;
		}

		// Token: 0x06043DC0 RID: 277952 RVA: 0x010A1935 File Offset: 0x0109FB35
		public static bool CreateInstance()
		{
			if (ResetPlayerController._Instance != null)
			{
				return true;
			}
			ResetPlayerController._Instance = new ResetPlayerController();
			return true;
		}

		// Token: 0x06043DC1 RID: 277953 RVA: 0x010A194B File Offset: 0x0109FB4B
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06043DC2 RID: 277954 RVA: 0x010A194D File Offset: 0x0109FB4D
		public static void ResetStaticDefaultValue()
		{
			ResetPlayerController._Instance = null;
		}

		// Token: 0x06043DC3 RID: 277955 RVA: 0x010A1955 File Offset: 0x0109FB55
		static ResetPlayerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ResetPlayerController.CreateStaticDefaultValue), new Action(ResetPlayerController.ResetStaticDefaultValue));
		}

		// Token: 0x0402376E RID: 145262
		[Nullable(2)]
		private static ResetPlayerController _Instance;
	}
}
