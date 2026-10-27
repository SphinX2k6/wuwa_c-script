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
	// Token: 0x020069BA RID: 27066
	[NullableContext(1)]
	[Nullable(0)]
	public class UnopenedAreaPullback : IUnopenedAreaHandler
	{
		// Token: 0x1700985E RID: 39006
		// (get) Token: 0x0604358A RID: 275850 RVA: 0x01074A8A File Offset: 0x01072C8A
		public bool ForbidVehicleOnEnter
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0604358B RID: 275851 RVA: 0x01074A90 File Offset: 0x01072C90
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

		// Token: 0x0604358C RID: 275852 RVA: 0x01074B70 File Offset: 0x01072D70
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

		// Token: 0x0604358D RID: 275853 RVA: 0x01074C1C File Offset: 0x01072E1C
		private void OpenGenericPrompt()
		{
			EUiViewName? viewNameByPromptId = GenericPromptController.Instance.GetViewNameByPromptId("NotOpenArea");
			if (viewNameByPromptId != null && !UiManager.Instance.IsViewOpen(viewNameByPromptId.Value))
			{
				GenericPromptController.Instance.ShowPromptByCode("NotOpenArea", Array.Empty<object>());
			}
		}

		// Token: 0x0604358E RID: 275854 RVA: 0x01074C6C File Offset: 0x01072E6C
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

		// Token: 0x0604358F RID: 275855 RVA: 0x01074D14 File Offset: 0x01072F14
		private void OnFinishPullback()
		{
			this.IsRunningPullback = false;
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "退出拉回移动操作,恢复玩家控制", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.SetTeleportTimer(false, false);
			this.SetBattleViewVisibility(true);
			this.RegainActivity(this.PlayerEntity);
		}

		// Token: 0x06043590 RID: 275856 RVA: 0x01074D5F File Offset: 0x01072F5F
		public void Clear()
		{
			if (this.IsRunningPullback)
			{
				this.OnFinishPullback();
			}
			this.ToggleNotOpenFadeEffect(false);
			this.SetTeleportTimer(false, false);
		}

		// Token: 0x06043591 RID: 275857 RVA: 0x01074D80 File Offset: 0x01072F80
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

		// Token: 0x06043592 RID: 275858 RVA: 0x01074DFC File Offset: 0x01072FFC
		public void OnExit()
		{
			Log.Instance.Info(ELogModule.Map, ELogAuthor.CWZ, "- - - - 离开了未开放区域- - - - ", default(ReadOnlySpan<ValueTuple<string, object>>));
			this.ToggleNotOpenFadeEffect(false);
			if (this.IsRunningPullback)
			{
				this.OnFinishPullback();
			}
		}

		// Token: 0x06043593 RID: 275859 RVA: 0x01074E3C File Offset: 0x0107303C
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

		// Token: 0x06043594 RID: 275860 RVA: 0x01074E90 File Offset: 0x01073090
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

		// Token: 0x06043595 RID: 275861 RVA: 0x01074F2C File Offset: 0x0107312C
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

		// Token: 0x06043596 RID: 275862 RVA: 0x01074F7C File Offset: 0x0107317C
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

		// Token: 0x06043597 RID: 275863 RVA: 0x01074FC6 File Offset: 0x010731C6
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

		// Token: 0x06043598 RID: 275864 RVA: 0x01074FFC File Offset: 0x010731FC
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

		// Token: 0x06043599 RID: 275865 RVA: 0x01075054 File Offset: 0x01073254
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

		// Token: 0x0604359A RID: 275866 RVA: 0x01075110 File Offset: 0x01073310
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

		// Token: 0x0604359B RID: 275867 RVA: 0x01075190 File Offset: 0x01073390
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

		// Token: 0x0604359C RID: 275868 RVA: 0x01075228 File Offset: 0x01073428
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

		// Token: 0x0604359D RID: 275869 RVA: 0x01075288 File Offset: 0x01073488
		private void ToggleNotOpenFadeEffect(bool enable)
		{
			this.EnablePostProcess = enable;
			if (!enable)
			{
				SceneEffectStateManager.Instance.SetSceneEffectState(ESceneEffectStateType.AirWall, 0f);
			}
		}

		// Token: 0x0604359E RID: 275870 RVA: 0x010752A4 File Offset: 0x010734A4
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

		// Token: 0x0604359F RID: 275871 RVA: 0x01075374 File Offset: 0x01073574
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

		// Token: 0x060435A0 RID: 275872 RVA: 0x0107540C File Offset: 0x0107360C
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

		// Token: 0x1700985F RID: 39007
		// (get) Token: 0x060435A1 RID: 275873 RVA: 0x01075501 File Offset: 0x01073701
		public bool GetInPullback
		{
			get
			{
				return this.IsRunningPullback;
			}
		}

		// Token: 0x04023213 RID: 143891
		private const int DISTANCE_FACOR = 100;

		// Token: 0x04023214 RID: 143892
		private const double TOLERANCE_DISTANCE = 5.0;

		// Token: 0x04023215 RID: 143893
		private const long TELEPORT_DELAY_TIME = 20000L;

		// Token: 0x04023216 RID: 143894
		private const long TELEPORT_DELAY_TIME_GONDOLA = 5000L;

		// Token: 0x04023217 RID: 143895
		private const double END_DISTANCE = 250.0;

		// Token: 0x04023218 RID: 143896
		private const string TIPS_NAME = "NotOpenArea";

		// Token: 0x04023219 RID: 143897
		private readonly string Reason = "Input Limited Action";

		// Token: 0x0402321A RID: 143898
		private readonly double ToleranceDistance = 500.0;

		// Token: 0x0402321B RID: 143899
		private bool BattleViewHide;

		// Token: 0x0402321C RID: 143900
		private bool IsRunningPullback;

		// Token: 0x0402321D RID: 143901
		private bool EnablePostProcess;

		// Token: 0x0402321E RID: 143902
		[Nullable(2)]
		private TimerHandle TeleportTimer;

		// Token: 0x0402321F RID: 143903
		private readonly global::Vector EnterLocation = global::Vector.Create();

		// Token: 0x04023220 RID: 143904
		private readonly global::Vector PullbackDirect = global::Vector.Create();

		// Token: 0x04023221 RID: 143905
		private readonly global::Vector CacheVector = global::Vector.Create();

		// Token: 0x04023222 RID: 143906
		private readonly global::Vector CacheVector2 = global::Vector.Create();

		// Token: 0x04023223 RID: 143907
		[Nullable(2)]
		private CharacterActorComponent ActorComp;

		// Token: 0x04023224 RID: 143908
		[Nullable(2)]
		private CharacterSkillComponent SkillComp;

		// Token: 0x04023225 RID: 143909
		[Nullable(2)]
		private CharacterUnifiedStateComponent StateComp;

		// Token: 0x04023226 RID: 143910
		[Nullable(2)]
		private EntityHandle PlayerEntity;
	}
}
