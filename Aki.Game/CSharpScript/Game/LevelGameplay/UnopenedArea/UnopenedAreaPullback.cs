using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Scene;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Map;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using CSharpScript.Game.Render.Effect.PostProcess;
using CSharpScript.Game.Ui;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.UnopenedArea
{
	// Token: 0x02005B16 RID: 23318
	[NullableContext(1)]
	[Nullable(0)]
	public class UnopenedAreaPullback : IUnopenedAreaHandler
	{
		// Token: 0x17006D3E RID: 27966
		// (get) Token: 0x060395C6 RID: 234950 RVA: 0x01018F21 File Offset: 0x01017121
		public bool ForbidVehicleOnEnter
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060395C7 RID: 234951 RVA: 0x01018F24 File Offset: 0x01017124
		public void Tick(float delta)
		{
			EntityHandle playerEntity = this.PlayerEntity;
			if (playerEntity == null || !playerEntity.Valid)
			{
				return;
			}
			if (TeleportModel.Instance.IsTeleport || PlotModel.Instance.IsInPlot)
			{
				this.SetTeleportTimerPause(true);
				return;
			}
			this.SetTeleportTimerPause(false);
			double num = global::Vector.Dist2D(this.EnterLocation, this.ActorComp.ActorLocationProxy);
			if (this.EnablePostProcess)
			{
				float num2 = (float)MathUtils.Instance.SafeDivide(num, this.ToleranceDistance);
				num2 = MathUtils.Instance.Clamp(num2, 0f, 1f);
				SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, num2);
			}
			if (!this.IsRunningPullback && num > this.ToleranceDistance)
			{
				this.OpenGenericPrompt();
				this.OnRunPullback();
				return;
			}
			if (this.IsRunningPullback && num < 250.0 && this.CheckStopBehaviourTree())
			{
				this.OnFinishPullback();
			}
		}

		// Token: 0x060395C8 RID: 234952 RVA: 0x01019004 File Offset: 0x01017204
		private bool CheckStopBehaviourTree()
		{
			if (MapModel.Instance.IsInMapPolygon(this.ActorComp.ActorLocationProxy))
			{
				return true;
			}
			this.CacheVector.DeepCopy(this.ActorComp.ActorLocationProxy);
			this.CacheVector.Subtraction(this.EnterLocation, this.CacheVector);
			this.CacheVector.Z = 0.0;
			this.CacheVector2.DeepCopy(this.PullbackDirect);
			this.CacheVector2.Z = 0.0;
			return this.CacheVector2.DotProduct(this.CacheVector) < 0.0;
		}

		// Token: 0x060395C9 RID: 234953 RVA: 0x010190B0 File Offset: 0x010172B0
		private void OpenGenericPrompt()
		{
			EUiViewName? viewNameByPromptId = GenericPromptController.Instance.GetViewNameByPromptId("NotOpenArea");
			if (viewNameByPromptId != null && !UiManager.Instance.IsViewOpen(viewNameByPromptId.Value))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpenArea", Array.Empty<object>());
			}
		}

		// Token: 0x060395CA RID: 234954 RVA: 0x01019100 File Offset: 0x01017300
		private void OnRunPullback()
		{
			this.IsRunningPullback = true;
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "开始执行拉回移动操作,禁用玩家输入", default(ReadOnlySpan<ValueTuple<string, object>>));
			EntityHandle playerEntity = this.PlayerEntity;
			bool? flag;
			if (playerEntity == null)
			{
				flag = null;
			}
			else
			{
				WorldEntity entity = playerEntity.Entity;
				if (entity == null)
				{
					flag = null;
				}
				else
				{
					RoleDriveVehicleComponent component = entity.GetComponent<RoleDriveVehicleComponent>();
					flag = ((component != null) ? new bool?(component.IsOnVehicle) : null);
				}
			}
			bool? flag2 = flag;
			bool valueOrDefault = flag2.GetValueOrDefault();
			this.SetTeleportTimer(true, valueOrDefault);
			this.SetBattleViewVisibility(false);
			this.StopActivity();
			if (valueOrDefault)
			{
				return;
			}
			this.MoveToEnterLocation(this.PlayerEntity);
		}

		// Token: 0x060395CB RID: 234955 RVA: 0x010191A8 File Offset: 0x010173A8
		private void OnFinishPullback()
		{
			this.IsRunningPullback = false;
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "退出拉回移动操作,恢复玩家控制", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetTeleportTimer(false, false);
			this.SetBattleViewVisibility(true);
			this.RegainActivity(this.PlayerEntity);
		}

		// Token: 0x060395CC RID: 234956 RVA: 0x010191F3 File Offset: 0x010173F3
		public void Clear()
		{
			if (this.IsRunningPullback)
			{
				this.OnFinishPullback();
			}
			this.ToggleNotOpenFadeEffect(false);
			this.SetTeleportTimer(false, false);
		}

		// Token: 0x060395CD RID: 234957 RVA: 0x01019214 File Offset: 0x01017414
		public bool OnEnter()
		{
			this.EnterLocation.DeepCopy(MapModel.Instance.GetLastSafeLocation());
			if (this.EnterLocation.IsNearlyZero(9.999999747378752E-05))
			{
				return false;
			}
			this.TeleportTimer = null;
			this.UpdateEntityInfo(null);
			this.ToggleNotOpenFadeEffect(true);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Map;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "--------进入了未开放区域--------";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EnterLoc", this.EnterLocation);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return true;
		}

		// Token: 0x060395CE RID: 234958 RVA: 0x01019290 File Offset: 0x01017490
		public void OnExit()
		{
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "- - - - 离开了未开放区域- - - - ", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ToggleNotOpenFadeEffect(false);
			if (this.IsRunningPullback)
			{
				this.OnFinishPullback();
			}
		}

		// Token: 0x060395CF RID: 234959 RVA: 0x010192D0 File Offset: 0x010174D0
		public void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
		{
			this.UpdateEntityInfo(newEntityHandle);
			if (this.IsRunningPullback)
			{
				if (oldEntityHandle != null && oldEntityHandle.Valid)
				{
					oldEntityHandle.Entity.GetComponent<CharacterMoveComponent>().StopMoveToLocation("UnopenedAreaPullback.OnChangeRole");
					this.SetPlayerTag(oldEntityHandle, false);
				}
				this.SetPlayerTag(newEntityHandle, true);
				this.MoveToEnterLocation(newEntityHandle);
			}
		}

		// Token: 0x060395D0 RID: 234960 RVA: 0x01019324 File Offset: 0x01017524
		private void MoveToEnterLocation(EntityHandle handle)
		{
			this.CheckTryExitClimbState(handle);
			BaseMoveComponent component = handle.Entity.GetComponent<CharacterMoveComponent>();
			MoveCharacterPoint value = new MoveCharacterPoint
			{
				Index = 0,
				Position = this.EnterLocation
			};
			MoveCharacterConfig config = new MoveCharacterConfig
			{
				Points = value,
				Navigation = false,
				IsFly = false,
				DebugMode = true,
				Loop = false,
				Distance = new float?(0f),
				Callback = delegate(ELevelEventState result)
				{
					if (this.IsRunningPullback)
					{
						this.OnFinishPullback();
					}
				},
				ReturnFalseWhenNavigationFailed = false
			};
			component.MoveAlongPath(config, "UnopenedAreaPullback.MoveToEnterLocation");
		}

		// Token: 0x060395D1 RID: 234961 RVA: 0x010193C0 File Offset: 0x010175C0
		private void CheckTryExitClimbState(EntityHandle handle)
		{
			WorldEntity entity = handle.Entity;
			CharacterUnifiedStateComponent characterUnifiedStateComponent = (entity != null) ? entity.CheckGetComponent<CharacterUnifiedStateComponent>() : null;
			if (characterUnifiedStateComponent != null && characterUnifiedStateComponent.PositionState == global::ECharPositionState.Climb)
			{
				WorldEntity entity2 = handle.Entity;
				CharacterClimbComponent characterClimbComponent = (entity2 != null) ? entity2.GetComponent<CharacterClimbComponent>() : null;
				if (characterClimbComponent == null)
				{
					return;
				}
				characterClimbComponent.ClimbPress(true);
			}
		}

		// Token: 0x060395D2 RID: 234962 RVA: 0x01019410 File Offset: 0x01017610
		private void TeleportToEnterLocation()
		{
			if (SceneTeamModel.Instance.IsAllDid())
			{
				return;
			}
			if (this.IsRunningPullback)
			{
				this.OnFinishPullback();
			}
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "在未开放区域待太久，开始传送", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.RequestUnOpenedAreaPullback();
		}

		// Token: 0x060395D3 RID: 234963 RVA: 0x0101945A File Offset: 0x0101765A
		private void RequestUnOpenedAreaPullback()
		{
			Net.Instance.Call(ERequestMessageId.UnOpenedAreaPullbackRequest, UnOpenedAreaPullbackRequest.Create(), delegate(IMessage msg, Net.CallbackStatus _)
			{
				UnOpenedAreaPullbackResponse unOpenedAreaPullbackResponse = (UnOpenedAreaPullbackResponse)msg;
				if (unOpenedAreaPullbackResponse.ErrorCode == ErrorCode.ErrPlayerIsTeleportCanNotDoTeleport)
				{
					return;
				}
				if (unOpenedAreaPullbackResponse.ErrorCode != ErrorCode.Success)
				{
					ErrorCodeController.Instance.OpenErrorCodeTipView(unOpenedAreaPullbackResponse.ErrorCode, EResponseMessageId.UnOpenedAreaPullbackResponse, null, true, true);
				}
			}, 0);
		}

		// Token: 0x060395D4 RID: 234964 RVA: 0x01019490 File Offset: 0x01017690
		private void RegainActivity(EntityHandle entityHandle)
		{
			CharacterMoveComponent component = entityHandle.Entity.GetComponent<CharacterMoveComponent>();
			component.StopMove(false, "UnopenedAreaPullback.OnChangeRole");
			component.StopMoveWithCallback(ELevelEventState.Success, "UnopenedAreaPullback.OnChangeRole");
			CharacterInputComponent component2 = entityHandle.Entity.GetComponent<CharacterInputComponent>();
			component2.ClearMoveVectorCache();
			component2.SetActive(true);
			this.SetPlayerTag(entityHandle, false);
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x060395D5 RID: 234965 RVA: 0x010194E8 File Offset: 0x010176E8
		private void StopActivity()
		{
			EventSystem.Instance.Emit<string>(EEventName.ForceReleaseInput, this.Reason);
			if (this.StateComp.DirectionState == ECharDirectionState.AimDirection)
			{
				this.StateComp.ExitAimStatus();
			}
			else
			{
				this.StateComp.SetDirectionState(this.StateComp.DirectionState);
			}
			if (this.SkillComp != null && this.SkillComp.CurrentSkill != null)
			{
				this.SkillComp.EndOwnerAndFollowSkills();
				this.ResetCharacterState(0, 0);
			}
			this.ActorComp.ClearInput(false, true);
			CharacterInputComponent component = this.PlayerEntity.Entity.GetComponent<CharacterInputComponent>();
			component.ClearMoveVectorCache();
			component.SetActive(false);
			this.SetPlayerTag(this.PlayerEntity, true);
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x060395D6 RID: 234966 RVA: 0x010195A4 File Offset: 0x010177A4
		[NullableContext(2)]
		private void UpdateEntityInfo(EntityHandle entityHandle = null)
		{
			if (entityHandle != null && entityHandle.Valid)
			{
				this.PlayerEntity = entityHandle;
			}
			else
			{
				this.PlayerEntity = CreatureModel.Instance.GetEntityById(Global.BaseCharacter.EntityId);
			}
			this.ActorComp = this.PlayerEntity.Entity.GetComponent<CharacterActorComponent>();
			this.SkillComp = this.PlayerEntity.Entity.GetComponent<CharacterSkillComponent>();
			this.StateComp = this.PlayerEntity.Entity.GetComponent<CharacterUnifiedStateComponent>();
		}

		// Token: 0x060395D7 RID: 234967 RVA: 0x01019624 File Offset: 0x01017824
		private void ResetCharacterState(int lastMode, byte lastState)
		{
			BaseTagComponent component = this.ActorComp.Entity.GetComponent<BaseTagComponent>();
			if (lastMode == 0 || (component != null && component.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"])))
			{
				this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Walking,
					CustomMode = lastState,
					Context = "[UnopenedAreaPullback.ResetCharacterState] if true"
				});
				return;
			}
			this.ActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = (EMovementMode)lastMode,
				CustomMode = lastState,
				Context = "[UnopenedAreaPullback.ResetCharacterState]"
			});
		}

		// Token: 0x060395D8 RID: 234968 RVA: 0x010196BC File Offset: 0x010178BC
		private void SetBattleViewVisibility(bool visible)
		{
			if (visible && this.BattleViewHide)
			{
				BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.AiPullback, 0);
				this.BattleViewHide = false;
			}
			if (!visible && !this.BattleViewHide)
			{
				BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.AiPullback, new EBattleUiChild[]
				{
					EBattleUiChild.BattleFloat
				}, 0);
				this.BattleViewHide = true;
			}
		}

		// Token: 0x060395D9 RID: 234969 RVA: 0x0101971C File Offset: 0x0101791C
		private void ToggleNotOpenFadeEffect(bool enable)
		{
			this.EnablePostProcess = enable;
			if (!enable)
			{
				SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, 0f);
			}
		}

		// Token: 0x060395DA RID: 234970 RVA: 0x01019738 File Offset: 0x01017938
		private void SetTeleportTimer(bool start, bool onVehicle = false)
		{
			if (!start)
			{
				if (this.TeleportTimer != null && TimerSystem.Instance.Has(this.TeleportTimer))
				{
					Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "移除定时器传送", default(ReadOnlySpan<ValueTuple<string, object>>));
					TimerSystem.Instance.Remove(this.TeleportTimer);
				}
				this.TeleportTimer = null;
				return;
			}
			if (this.TeleportTimer == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Map;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "开启定时器传送";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Time", 20000L);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				this.TeleportTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.TeleportToEnterLocation();
					this.TeleportTimer = null;
				}, (float)(onVehicle ? 5000L : 20000L), null, null, true, 1f);
			}
		}

		// Token: 0x060395DB RID: 234971 RVA: 0x01019808 File Offset: 0x01017A08
		private void SetTeleportTimerPause(bool bPause)
		{
			if (this.TeleportTimer == null || !TimerSystem.Instance.Has(this.TeleportTimer))
			{
				return;
			}
			if (bPause)
			{
				if (!this.TeleportTimer.IsPause())
				{
					Log.Instance.Info(ELogModule.Map, ELogAuthor.ZYL, "暂停传送定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
					this.TeleportTimer.Pause();
					return;
				}
			}
			else if (this.TeleportTimer.IsPause())
			{
				Log.Instance.Info(ELogModule.Map, ELogAuthor.ZYL, "恢复传送定时器", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.TeleportTimer.Resume();
			}
		}

		// Token: 0x060395DC RID: 234972 RVA: 0x010198A0 File Offset: 0x01017AA0
		private void SetPlayerTag(EntityHandle handle, bool addTag)
		{
			if (handle == null || !handle.Valid)
			{
				return;
			}
			if (addTag)
			{
				BaseTagComponent component = handle.Entity.GetComponent<BaseTagComponent>();
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
				}
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"]));
				}
				if (component != null)
				{
					component.AddTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"]));
				}
			}
			if (!addTag)
			{
				BaseTagComponent component2 = handle.Entity.GetComponent<BaseTagComponent>();
				if (component2 != null)
				{
					component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]));
				}
				if (component2 != null)
				{
					component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止技能"]));
				}
				if (component2 == null)
				{
					return;
				}
				component2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["战斗状态.输入限制.禁止攻击"]));
			}
		}

		// Token: 0x17006D3F RID: 27967
		// (get) Token: 0x060395DD RID: 234973 RVA: 0x01019995 File Offset: 0x01017B95
		public bool GetInPullback
		{
			get
			{
				return this.IsRunningPullback;
			}
		}

		// Token: 0x0401E403 RID: 123907
		private const int DISTANCE_FACOR = 100;

		// Token: 0x0401E404 RID: 123908
		private const double TOLERANCE_DISTANCE = 5.0;

		// Token: 0x0401E405 RID: 123909
		private const long TELEPORT_DELAY_TIME = 20000L;

		// Token: 0x0401E406 RID: 123910
		private const long TELEPORT_DELAY_TIME_GONDOLA = 5000L;

		// Token: 0x0401E407 RID: 123911
		private const double END_DISTANCE = 250.0;

		// Token: 0x0401E408 RID: 123912
		private const string TIPS_NAME = "NotOpenArea";

		// Token: 0x0401E409 RID: 123913
		private readonly string Reason = "Input Limited Action";

		// Token: 0x0401E40A RID: 123914
		private readonly double ToleranceDistance = 500.0;

		// Token: 0x0401E40B RID: 123915
		private bool BattleViewHide;

		// Token: 0x0401E40C RID: 123916
		private bool IsRunningPullback;

		// Token: 0x0401E40D RID: 123917
		private bool EnablePostProcess;

		// Token: 0x0401E40E RID: 123918
		[Nullable(2)]
		private TimerHandle TeleportTimer;

		// Token: 0x0401E40F RID: 123919
		private readonly global::Vector EnterLocation = global::Vector.Create();

		// Token: 0x0401E410 RID: 123920
		private readonly global::Vector PullbackDirect = global::Vector.Create();

		// Token: 0x0401E411 RID: 123921
		private readonly global::Vector CacheVector = global::Vector.Create();

		// Token: 0x0401E412 RID: 123922
		private readonly global::Vector CacheVector2 = global::Vector.Create();

		// Token: 0x0401E413 RID: 123923
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x0401E414 RID: 123924
		[Nullable(2)]
		private CharacterSkillComponent SkillComp;

		// Token: 0x0401E415 RID: 123925
		[Nullable(2)]
		private CharacterUnifiedStateComponent StateComp;

		// Token: 0x0401E416 RID: 123926
		[Nullable(2)]
		private EntityHandle PlayerEntity;
	}
}
