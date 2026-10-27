using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;
using Google.Protobuf;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem
{
	// Token: 0x0200716E RID: 29038
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBeamReceiveComponent : EntityComponent
	{
		// Token: 0x06046E46 RID: 290374 RVA: 0x011E45D8 File Offset: 0x011E27D8
		protected override bool OnInitData(IEntityArgs args = null)
		{
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			BeamReceiveComponent beamReceiveComponent = args.GetP1<CreateEntityData>().GetParam<SceneItemBeamReceiveComponent>() as BeamReceiveComponent;
			if (beamReceiveComponent == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[BeamReceiveComp] 组件配置缺失";
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			this.Config = beamReceiveComponent;
			this.ReceiveDurationMs = this.Config.Duration * 1000f;
			return true;
		}

		// Token: 0x06046E47 RID: 290375 RVA: 0x011E4678 File Offset: 0x011E2878
		protected override void OnActivate()
		{
			this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
			this.TagComp = base.Entity.GetComponent<LevelTagComponent>();
			if (!this.ActorComp.GetIsSceneInteractionLoadCompleted())
			{
				EventSystem.Instance.OnceWithTarget(base.Entity, EEventName.OnSceneInteractionShowCompleted, new Action(this.OnSceneInteractionLoadCompleted));
			}
			else
			{
				this.OnSceneInteractionLoadCompleted();
			}
			EventSystem.Instance.AddWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStart, new Action<EntityHandle>(this.OnStartReceiveBeam));
			EventSystem.Instance.AddWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStop, new Action<EntityHandle>(this.OnStopReceiveBeam));
		}

		// Token: 0x06046E48 RID: 290376 RVA: 0x011E4724 File Offset: 0x011E2924
		private unsafe void OnSceneInteractionLoadCompleted()
		{
			BeamReceiveComponent config = this.Config;
			if (((config != null) ? config.ReceiveTarget : null) != null)
			{
				AActor referenceActor = this.ActorComp.GetReferenceActor(this.Config.ReceiveTarget);
				if (referenceActor == null || !referenceActor.IsValid())
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.FJH;
					string message = "[BeamReceiveComp] 限定光线接收对象不存在，将不设置接收对象限制";
					<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
					string item = "PbDataId";
					CreatureDataComponent creatureDataComp = this.CreatureDataComp;
					ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item2 = "CreatureDataId";
					CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
					ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new long?(creatureDataComp2.GetCreatureDataId()) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ReceiveTarget", this.Config.ReceiveTarget);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					return;
				}
				this.CanReceiveBeamActor = referenceActor;
			}
		}

		// Token: 0x06046E49 RID: 290377 RVA: 0x011E4838 File Offset: 0x011E2A38
		protected override bool OnEnd()
		{
			if (EventSystem.Instance.HasWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStart, new Action<EntityHandle>(this.OnStartReceiveBeam)))
			{
				EventSystem.Instance.RemoveWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStart, new Action<EntityHandle>(this.OnStartReceiveBeam));
			}
			if (EventSystem.Instance.HasWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStop, new Action<EntityHandle>(this.OnStopReceiveBeam)))
			{
				EventSystem.Instance.RemoveWithTarget<EntityHandle>(base.Entity, EEventName.BeamCastStop, new Action<EntityHandle>(this.OnStopReceiveBeam));
			}
			if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange)))
			{
				EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange));
			}
			this.BeamCastComp = null;
			this.CanReceiveBeamActor = null;
			return true;
		}

		// Token: 0x06046E4A RID: 290378 RVA: 0x011E4924 File Offset: 0x011E2B24
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			if (this.ReceiveTimerHandle == null || !TimerSystem.Instance.Has(this.ReceiveTimerHandle))
			{
				return;
			}
			PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
			float num = (component != null) ? component.CurrentTimeScale : 1f;
			float num2 = timeDilation * num;
			if (num2 == 0f)
			{
				if (!TimerSystem.Instance.IsPause(this.ReceiveTimerHandle))
				{
					TimerSystem.Instance.Pause(this.ReceiveTimerHandle, null);
					return;
				}
			}
			else if (num2 > 0f)
			{
				if (TimerSystem.Instance.IsPause(this.ReceiveTimerHandle))
				{
					TimerSystem.Instance.Resume(this.ReceiveTimerHandle);
				}
				TimerSystem.Instance.ChangeDilation(this.ReceiveTimerHandle, num2, null);
			}
		}

		// Token: 0x06046E4B RID: 290379 RVA: 0x011E49D8 File Offset: 0x011E2BD8
		private void ChangePerformByState(SceneItemBeamReceiveComponent.ECastingState castingState)
		{
			switch (castingState)
			{
			case SceneItemBeamReceiveComponent.ECastingState.NotCasting:
			{
				LevelTagComponent tagComp = this.TagComp;
				if (tagComp != null && tagComp.HasTag(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp2 = this.TagComp;
					if (tagComp2 != null)
					{
						tagComp2.RemoveTag(new int?(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG));
					}
				}
				LevelTagComponent tagComp3 = this.TagComp;
				if (tagComp3 == null || !tagComp3.HasTag(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp4 = this.TagComp;
					if (tagComp4 != null)
					{
						tagComp4.AddTag(new int?(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG));
					}
				}
				SceneItemActorComponent actorComp = this.ActorComp;
				if (actorComp == null)
				{
					return;
				}
				actorComp.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG).Value, 1f);
				return;
			}
			case SceneItemBeamReceiveComponent.ECastingState.Casting:
			{
				LevelTagComponent tagComp5 = this.TagComp;
				if (tagComp5 != null && tagComp5.HasTag(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp6 = this.TagComp;
					if (tagComp6 != null)
					{
						tagComp6.RemoveTag(new int?(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG));
					}
				}
				LevelTagComponent tagComp7 = this.TagComp;
				if (tagComp7 == null || !tagComp7.HasTag(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp8 = this.TagComp;
					if (tagComp8 != null)
					{
						tagComp8.AddTag(new int?(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG));
					}
				}
				SceneItemActorComponent actorComp2 = this.ActorComp;
				if (actorComp2 != null)
				{
					actorComp2.SetActiveTagSequenceDurationTime(GameplayTagUtils.GetGameplayTagById(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG).Value, this.Config.Duration);
				}
				SceneItemActorComponent actorComp3 = this.ActorComp;
				if (actorComp3 == null)
				{
					return;
				}
				actorComp3.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG).Value, 0f);
				return;
			}
			case SceneItemBeamReceiveComponent.ECastingState.WaitingCompleteCondition:
				break;
			case SceneItemBeamReceiveComponent.ECastingState.Complete:
			{
				SceneItemActorComponent actorComp4 = this.ActorComp;
				if (actorComp4 != null)
				{
					actorComp4.SetActiveTagSequencePlaybackProgress(GameplayTagUtils.GetGameplayTagById(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG).Value, 1f);
				}
				LevelTagComponent tagComp9 = this.TagComp;
				if (tagComp9 != null && tagComp9.HasTag(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp10 = this.TagComp;
					if (tagComp10 != null)
					{
						tagComp10.RemoveTag(new int?(SceneItemBeamReceiveComponent.CASTING_PERFORM_TAG));
					}
				}
				LevelTagComponent tagComp11 = this.TagComp;
				if (tagComp11 != null && tagComp11.HasTag(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG))
				{
					LevelTagComponent tagComp12 = this.TagComp;
					if (tagComp12 == null)
					{
						return;
					}
					tagComp12.RemoveTag(new int?(SceneItemBeamReceiveComponent.STOP_CASTING_PERFORM_TAG));
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06046E4C RID: 290380 RVA: 0x011E4BE4 File Offset: 0x011E2DE4
		[NullableContext(1)]
		private void OnStartReceiveBeam(EntityHandle instigator)
		{
			EOnlineInteractType entityOnlineInteractType = this.CreatureDataComp.GetEntityOnlineInteractType();
			if (!LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(entityOnlineInteractType, true))
			{
				return;
			}
			if (this.CastingState == SceneItemBeamReceiveComponent.ECastingState.Casting)
			{
				return;
			}
			this.BeamCastInstigator = instigator;
			EntityHandle beamCastInstigator = this.BeamCastInstigator;
			SceneItemBeamCastComponent sceneItemBeamCastComponent;
			if (beamCastInstigator == null)
			{
				sceneItemBeamCastComponent = null;
			}
			else
			{
				WorldEntity entity = beamCastInstigator.Entity;
				sceneItemBeamCastComponent = ((entity != null) ? entity.GetComponent<SceneItemBeamCastComponent>() : null);
			}
			SceneItemBeamCastComponent sceneItemBeamCastComponent2 = sceneItemBeamCastComponent;
			if (sceneItemBeamCastComponent2 != null)
			{
				this.BeamCastComp = sceneItemBeamCastComponent2;
			}
			if (this.CanReceiveBeamActor != null)
			{
				if (this.CheckCastingActor())
				{
					this.OnStartReceiveBeamInternal();
				}
				if (!EventSystem.Instance.HasWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange)))
				{
					EventSystem.Instance.AddWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange));
					return;
				}
			}
			else
			{
				this.OnStartReceiveBeamInternal();
			}
		}

		// Token: 0x06046E4D RID: 290381 RVA: 0x011E4CA8 File Offset: 0x011E2EA8
		private void OnStartReceiveBeamInternal()
		{
			if (this.CastingState == SceneItemBeamReceiveComponent.ECastingState.Complete)
			{
				return;
			}
			this.CastingState = SceneItemBeamReceiveComponent.ECastingState.Casting;
			this.ChangePerformByState(SceneItemBeamReceiveComponent.ECastingState.Casting);
			this.RequestBeamReceiveAction(EntityBeamReceiveType.BeginAction);
			BeamReceiveComponent config = this.Config;
			if (((config != null) ? config.ReceiveCondition : null) != null)
			{
				this.CastingState = SceneItemBeamReceiveComponent.ECastingState.WaitingCompleteCondition;
			}
			else
			{
				this.OnCompleteReceiveBeam();
			}
			if (this.BeamCastComp != null)
			{
				EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.BeamReflectStart);
			}
		}

		// Token: 0x06046E4E RID: 290382 RVA: 0x011E4D18 File Offset: 0x011E2F18
		private void OnBeamCastActorChange()
		{
			if (this.CanReceiveBeamActor == null || this.BeamCastComp == null)
			{
				return;
			}
			bool flag = this.CanReceiveBeamActor == this.BeamCastComp.GetBeamCastingActor(0);
			if (flag && this.CastingState == SceneItemBeamReceiveComponent.ECastingState.NotCasting)
			{
				this.OnStartReceiveBeamInternal();
				return;
			}
			if (!flag && this.CastingState != SceneItemBeamReceiveComponent.ECastingState.NotCasting)
			{
				this.StopReceiveBeamInternal(false, true, this.BeamCastInstigator);
			}
		}

		// Token: 0x06046E4F RID: 290383 RVA: 0x011E4D76 File Offset: 0x011E2F76
		[NullableContext(1)]
		private void OnStopReceiveBeam(EntityHandle instigator)
		{
			this.StopReceiveBeamInternal(true, true, instigator);
		}

		// Token: 0x06046E50 RID: 290384 RVA: 0x011E4D84 File Offset: 0x011E2F84
		[NullableContext(1)]
		private void StopReceiveBeamInternal(bool beamLeave, bool needRequest, EntityHandle instigator)
		{
			EOnlineInteractType entityOnlineInteractType = this.CreatureDataComp.GetEntityOnlineInteractType();
			if (!LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(entityOnlineInteractType, true))
			{
				return;
			}
			if (this.CastingState == SceneItemBeamReceiveComponent.ECastingState.NotCasting)
			{
				return;
			}
			this.CastingState = SceneItemBeamReceiveComponent.ECastingState.NotCasting;
			this.ChangePerformByState(SceneItemBeamReceiveComponent.ECastingState.NotCasting);
			if (this.ReceiveTimerHandle != null && TimerSystem.Instance.Has(this.ReceiveTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ReceiveTimerHandle);
			}
			if (beamLeave)
			{
				if (EventSystem.Instance.HasWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange)))
				{
					EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.BeamCastActorChange, new Action(this.OnBeamCastActorChange));
				}
				this.BeamCastComp = null;
				this.BeamCastInstigator = null;
			}
			this.ReceiveTimerHandle = null;
			if (needRequest)
			{
				this.RequestBeamReceiveAction(EntityBeamReceiveType.StopAction);
			}
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.BeamReflectStop);
		}

		// Token: 0x06046E51 RID: 290385 RVA: 0x011E4E6C File Offset: 0x011E306C
		private void OnCompleteReceiveBeam()
		{
			if (this.CastingState == SceneItemBeamReceiveComponent.ECastingState.Complete)
			{
				return;
			}
			if (this.ReceiveDurationMs == 0f)
			{
				this.OnCompleteReceiveBeamInternal(this.BeamCastInstigator);
				return;
			}
			if (this.ReceiveTimerHandle == null || !TimerSystem.Instance.Has(this.ReceiveTimerHandle))
			{
				this.ReceiveTimerHandle = TimerSystem.Instance.Delay(delegate(float _)
				{
					this.OnCompleteReceiveBeamInternal(this.BeamCastInstigator);
				}, this.ReceiveDurationMs, null, null, true, 1f);
				if (this.ReceiveTimerHandle == null)
				{
					return;
				}
				PawnTimeScaleComponent component = base.Entity.GetComponent<PawnTimeScaleComponent>();
				float num = (component != null) ? component.CurrentTimeScale : 1f;
				float num2 = base.TimeDilation * num;
				if (num2 == 0f)
				{
					TimerSystem.Instance.Pause(this.ReceiveTimerHandle, null);
					return;
				}
				if (num2 > 0f)
				{
					TimerSystem.Instance.ChangeDilation(this.ReceiveTimerHandle, num2, null);
				}
			}
		}

		// Token: 0x06046E52 RID: 290386 RVA: 0x011E4F48 File Offset: 0x011E3148
		[NullableContext(1)]
		private void OnCompleteReceiveBeamInternal(EntityHandle instigator)
		{
			EOnlineInteractType entityOnlineInteractType = this.CreatureDataComp.GetEntityOnlineInteractType();
			if (!LevelGamePlayController.Instance.MultiplayerLimitTypeCheck(entityOnlineInteractType, true))
			{
				return;
			}
			this.CastingState = SceneItemBeamReceiveComponent.ECastingState.Complete;
			this.ChangePerformByState(SceneItemBeamReceiveComponent.ECastingState.Complete);
			if (this.ReceiveTimerHandle != null && TimerSystem.Instance.Has(this.ReceiveTimerHandle))
			{
				TimerSystem.Instance.Remove(this.ReceiveTimerHandle);
			}
			this.ReceiveTimerHandle = null;
			this.RequestBeamReceiveAction(EntityBeamReceiveType.CompleteAction);
		}

		// Token: 0x06046E53 RID: 290387 RVA: 0x011E4FB7 File Offset: 0x011E31B7
		[NullableContext(1)]
		public void OnNotifyBeamReceive(BeamReceiveNotify notify)
		{
			if (notify.IsSatisfied)
			{
				if (this.CheckCastingActor())
				{
					this.OnCompleteReceiveBeam();
					return;
				}
			}
			else
			{
				this.StopReceiveBeamInternal(false, false, this.BeamCastInstigator);
				this.CastingState = SceneItemBeamReceiveComponent.ECastingState.WaitingCompleteCondition;
			}
		}

		// Token: 0x06046E54 RID: 290388 RVA: 0x011E4FE8 File Offset: 0x011E31E8
		private unsafe void RequestBeamReceiveAction(EntityBeamReceiveType actionType)
		{
			EntityBeamReceiveRequest entityBeamReceiveRequest = EntityBeamReceiveRequest.Create();
			entityBeamReceiveRequest.EntityId = this.CreatureDataComp.GetCreatureDataId();
			entityBeamReceiveRequest.ReceiveType = actionType;
			Net.Instance.Call(ERequestMessageId.EntityBeamReceiveRequest, entityBeamReceiveRequest, delegate(IMessage msg, Net.CallbackStatus _)
			{
				EntityBeamReceiveResponse entityBeamReceiveResponse = (EntityBeamReceiveResponse)msg;
				if (entityBeamReceiveResponse != null && entityBeamReceiveResponse.ErrorCode == ErrorCode.Success)
				{
					return;
				}
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.ZYL;
				string message = "[BeamReceiveComp] 请求执行光线接收行为出错";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
				string item = "PbDataId";
				CreatureDataComponent creatureDataComp = this.CreatureDataComp;
				ptr = new ValueTuple<string, object>(item, (creatureDataComp != null) ? new int?(creatureDataComp.GetPbDataId()) : null);
				ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
				string item2 = "CreatureDataId";
				CreatureDataComponent creatureDataComp2 = this.CreatureDataComp;
				ptr2 = new ValueTuple<string, object>(item2, (creatureDataComp2 != null) ? new long?(creatureDataComp2.GetCreatureDataId()) : null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("EntityBeamReceiveType", actionType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Response", entityBeamReceiveResponse);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			}, 0);
		}

		// Token: 0x06046E55 RID: 290389 RVA: 0x011E5049 File Offset: 0x011E3249
		private bool CheckCastingActor()
		{
			return this.BeamCastComp != null && this.BeamCastComp.GetBeamCastingActor(0) == this.CanReceiveBeamActor;
		}

		// Token: 0x06046E56 RID: 290390 RVA: 0x011E506C File Offset: 0x011E326C
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ActionInfo> GetBeamReceiveActions(EntityBeamReceiveType receiveType)
		{
			switch (receiveType)
			{
			case EntityBeamReceiveType.BeginAction:
			{
				BeamReceiveComponent config = this.Config;
				if (config == null)
				{
					return null;
				}
				return config.BeginActions;
			}
			case EntityBeamReceiveType.CompleteAction:
			{
				BeamReceiveComponent config2 = this.Config;
				if (config2 == null)
				{
					return null;
				}
				return config2.CompleteActions;
			}
			case EntityBeamReceiveType.StopAction:
			{
				BeamReceiveComponent config3 = this.Config;
				if (config3 == null)
				{
					return null;
				}
				return config3.StopActions;
			}
			default:
				return null;
			}
		}

		// Token: 0x06046E57 RID: 290391 RVA: 0x011E50C4 File Offset: 0x011E32C4
		public global::Vector GetBeamReceiveDirection()
		{
			if (this.BeamCastComp == null)
			{
				return null;
			}
			return this.BeamCastComp.GetBeamCastWorldDir(0);
		}

		// Token: 0x06046E58 RID: 290392 RVA: 0x011E50DC File Offset: 0x011E32DC
		public global::Vector GetBeamReceiveEndPoint()
		{
			if (this.BeamCastComp == null)
			{
				return null;
			}
			return this.BeamCastComp.GetBeamCastEndPoint(0);
		}

		// Token: 0x06046E59 RID: 290393 RVA: 0x011E50F4 File Offset: 0x011E32F4
		public bool CanReceiveBeam()
		{
			return this.CastingState > SceneItemBeamReceiveComponent.ECastingState.NotCasting;
		}

		// Token: 0x06046E5A RID: 290394 RVA: 0x011E5100 File Offset: 0x011E3300
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBeamReceiveComponent sceneItemBeamReceiveComponent = (SceneItemBeamReceiveComponent)componentTemplate;
			if (base.CanResetComponentProperty("Config"))
			{
				if (sceneItemBeamReceiveComponent.Config == null)
				{
					this.Config = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BeamReceiveComponent>(this.Config), "Config"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (sceneItemBeamReceiveComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (sceneItemBeamReceiveComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (sceneItemBeamReceiveComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<LevelTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CastingState"))
			{
				this.CastingState = sceneItemBeamReceiveComponent.CastingState;
			}
			if (base.CanResetComponentProperty("ReceiveDurationMs"))
			{
				this.ReceiveDurationMs = sceneItemBeamReceiveComponent.ReceiveDurationMs;
			}
			if (base.CanResetComponentProperty("ReceiveTimerHandle"))
			{
				if (sceneItemBeamReceiveComponent.ReceiveTimerHandle == null)
				{
					this.ReceiveTimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.ReceiveTimerHandle), "ReceiveTimerHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BeamCastInstigator"))
			{
				if (sceneItemBeamReceiveComponent.BeamCastInstigator == null)
				{
					this.BeamCastInstigator = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.BeamCastInstigator), "BeamCastInstigator"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("BeamCastComp"))
			{
				if (sceneItemBeamReceiveComponent.BeamCastComp == null)
				{
					this.BeamCastComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemBeamCastComponent>(this.BeamCastComp), "BeamCastComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("CanReceiveBeamActor"))
			{
				if (sceneItemBeamReceiveComponent.CanReceiveBeamActor == null)
				{
					this.CanReceiveBeamActor = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.CanReceiveBeamActor), "CanReceiveBeamActor"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04025370 RID: 152432
		private static readonly int CASTING_PERFORM_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.光线接收中"];

		// Token: 0x04025371 RID: 152433
		private static readonly int STOP_CASTING_PERFORM_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.光线离开中"];

		// Token: 0x04025372 RID: 152434
		private BeamReceiveComponent Config;

		// Token: 0x04025373 RID: 152435
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04025374 RID: 152436
		private SceneItemActorComponent ActorComp;

		// Token: 0x04025375 RID: 152437
		private LevelTagComponent TagComp;

		// Token: 0x04025376 RID: 152438
		private SceneItemBeamReceiveComponent.ECastingState CastingState;

		// Token: 0x04025377 RID: 152439
		private float ReceiveDurationMs;

		// Token: 0x04025378 RID: 152440
		private TimerHandle ReceiveTimerHandle;

		// Token: 0x04025379 RID: 152441
		private EntityHandle BeamCastInstigator;

		// Token: 0x0402537A RID: 152442
		private SceneItemBeamCastComponent BeamCastComp;

		// Token: 0x0402537B RID: 152443
		private AActor CanReceiveBeamActor;

		// Token: 0x0200CEA9 RID: 52905
		[NullableContext(0)]
		private enum ECastingState
		{
			// Token: 0x0403E315 RID: 254741
			NotCasting,
			// Token: 0x0403E316 RID: 254742
			Casting,
			// Token: 0x0403E317 RID: 254743
			WaitingCompleteCondition,
			// Token: 0x0403E318 RID: 254744
			Complete
		}
	}
}
