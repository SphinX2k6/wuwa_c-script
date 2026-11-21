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
	// Token: 0x02006222 RID: 25122
	[NullableContext(2)]
	[Nullable(0)]
	public class SceneItemBeamReceiveComponent : EntityComponent
	{
		// Token: 0x0603C6A1 RID: 247457 RVA: 0x0113FD28 File Offset: 0x0113DF28
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

		// Token: 0x0603C6A2 RID: 247458 RVA: 0x0113FDC8 File Offset: 0x0113DFC8
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

		// Token: 0x0603C6A3 RID: 247459 RVA: 0x0113FE74 File Offset: 0x0113E074
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

		// Token: 0x0603C6A4 RID: 247460 RVA: 0x0113FF88 File Offset: 0x0113E188
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

		// Token: 0x0603C6A5 RID: 247461 RVA: 0x01140074 File Offset: 0x0113E274
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

		// Token: 0x0603C6A6 RID: 247462 RVA: 0x01140128 File Offset: 0x0113E328
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

		// Token: 0x0603C6A7 RID: 247463 RVA: 0x01140334 File Offset: 0x0113E534
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

		// Token: 0x0603C6A8 RID: 247464 RVA: 0x011403F8 File Offset: 0x0113E5F8
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

		// Token: 0x0603C6A9 RID: 247465 RVA: 0x01140468 File Offset: 0x0113E668
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

		// Token: 0x0603C6AA RID: 247466 RVA: 0x011404C6 File Offset: 0x0113E6C6
		[NullableContext(1)]
		private void OnStopReceiveBeam(EntityHandle instigator)
		{
			this.StopReceiveBeamInternal(true, true, instigator);
		}

		// Token: 0x0603C6AB RID: 247467 RVA: 0x011404D4 File Offset: 0x0113E6D4
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

		// Token: 0x0603C6AC RID: 247468 RVA: 0x011405BC File Offset: 0x0113E7BC
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

		// Token: 0x0603C6AD RID: 247469 RVA: 0x01140698 File Offset: 0x0113E898
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

		// Token: 0x0603C6AE RID: 247470 RVA: 0x01140707 File Offset: 0x0113E907
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

		// Token: 0x0603C6AF RID: 247471 RVA: 0x01140738 File Offset: 0x0113E938
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

		// Token: 0x0603C6B0 RID: 247472 RVA: 0x01140799 File Offset: 0x0113E999
		private bool CheckCastingActor()
		{
			return this.BeamCastComp != null && this.BeamCastComp.GetBeamCastingActor(0) == this.CanReceiveBeamActor;
		}

		// Token: 0x0603C6B1 RID: 247473 RVA: 0x011407BC File Offset: 0x0113E9BC
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

		// Token: 0x0603C6B2 RID: 247474 RVA: 0x01140814 File Offset: 0x0113EA14
		public global::Vector GetBeamReceiveDirection()
		{
			if (this.BeamCastComp == null)
			{
				return null;
			}
			return this.BeamCastComp.GetBeamCastWorldDir(0);
		}

		// Token: 0x0603C6B3 RID: 247475 RVA: 0x0114082C File Offset: 0x0113EA2C
		public global::Vector GetBeamReceiveEndPoint()
		{
			if (this.BeamCastComp == null)
			{
				return null;
			}
			return this.BeamCastComp.GetBeamCastEndPoint(0);
		}

		// Token: 0x0603C6B4 RID: 247476 RVA: 0x01140844 File Offset: 0x0113EA44
		public bool CanReceiveBeam()
		{
			return this.CastingState > SceneItemBeamReceiveComponent.ECastingState.NotCasting;
		}

		// Token: 0x0603C6B5 RID: 247477 RVA: 0x01140850 File Offset: 0x0113EA50
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			SceneItemBeamReceiveComponent sceneItemBeamReceiveComponent = (SceneItemBeamReceiveComponent)componentTemplate;
			if (sceneItemBeamReceiveComponent.Config == null)
			{
				this.Config = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Config), "Config"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.CastingState = sceneItemBeamReceiveComponent.CastingState;
			this.ReceiveDurationMs = sceneItemBeamReceiveComponent.ReceiveDurationMs;
			if (sceneItemBeamReceiveComponent.ReceiveTimerHandle == null)
			{
				this.ReceiveTimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReceiveTimerHandle), "ReceiveTimerHandle"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.BeamCastInstigator == null)
			{
				this.BeamCastInstigator = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BeamCastInstigator), "BeamCastInstigator"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.BeamCastComp == null)
			{
				this.BeamCastComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BeamCastComp), "BeamCastComp"))
			{
				return false;
			}
			if (sceneItemBeamReceiveComponent.CanReceiveBeamActor == null)
			{
				this.CanReceiveBeamActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CanReceiveBeamActor), "CanReceiveBeamActor"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x1700721A RID: 29210
		// (get) Token: 0x0603C6B6 RID: 247478 RVA: 0x011409E0 File Offset: 0x0113EBE0
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700721B RID: 29211
		// (get) Token: 0x0603C6B7 RID: 247479 RVA: 0x011409E3 File Offset: 0x0113EBE3
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700721C RID: 29212
		// (get) Token: 0x0603C6B8 RID: 247480 RVA: 0x011409E6 File Offset: 0x0113EBE6
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FFD7 RID: 131031
		private static readonly int CASTING_PERFORM_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.光线接收中"];

		// Token: 0x0401FFD8 RID: 131032
		private static readonly int STOP_CASTING_PERFORM_TAG = GameplayTagDefine.EGameplayTagId["关卡.Common.表现.光线离开中"];

		// Token: 0x0401FFD9 RID: 131033
		private BeamReceiveComponent Config;

		// Token: 0x0401FFDA RID: 131034
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x0401FFDB RID: 131035
		private SceneItemActorComponent ActorComp;

		// Token: 0x0401FFDC RID: 131036
		private LevelTagComponent TagComp;

		// Token: 0x0401FFDD RID: 131037
		private SceneItemBeamReceiveComponent.ECastingState CastingState;

		// Token: 0x0401FFDE RID: 131038
		private float ReceiveDurationMs;

		// Token: 0x0401FFDF RID: 131039
		private TimerHandle ReceiveTimerHandle;

		// Token: 0x0401FFE0 RID: 131040
		private EntityHandle BeamCastInstigator;

		// Token: 0x0401FFE1 RID: 131041
		private SceneItemBeamCastComponent BeamCastComp;

		// Token: 0x0401FFE2 RID: 131042
		private AActor CanReceiveBeamActor;

		// Token: 0x0200BA3F RID: 47679
		[NullableContext(0)]
		private enum ECastingState
		{
			// Token: 0x0403963B RID: 235067
			NotCasting,
			// Token: 0x0403963C RID: 235068
			Casting,
			// Token: 0x0403963D RID: 235069
			WaitingCompleteCondition,
			// Token: 0x0403963E RID: 235070
			Complete
		}
	}
}
