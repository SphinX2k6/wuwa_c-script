using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Character.Npc.Logics;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005C9A RID: 23706
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventEntityTurnTo : LevelEventBase
	{
		// Token: 0x0603A21D RID: 238109 RVA: 0x01064227 File Offset: 0x01062427
		public LevelEventEntityTurnTo(int id) : base(id)
		{
		}

		// Token: 0x0603A21E RID: 238110 RVA: 0x01064230 File Offset: 0x01062430
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			this.Param = (inParams as EntityTurnTo);
			base.CreateWaitEntityTask(this.Param.EntityId);
		}

		// Token: 0x0603A21F RID: 238111 RVA: 0x01064250 File Offset: 0x01062450
		protected override void ExecuteWhenEntitiesReady()
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.Param.EntityId);
			if (entityByPbDataId == null || !entityByPbDataId.IsInit)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			BasePerformComponent component = entityByPbDataId.Entity.GetComponent<BasePerformComponent>();
			if (component == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			global::Vector vector = null;
			OneOf<BaseActorComponent, global::Vector, AActor>? oneOf = null;
			switch (this.Param.Target.Type)
			{
			case EActorTurnToMode.Entity:
			{
				EntityHandle entityByPbDataId2 = CreatureModel.Instance.GetEntityByPbDataId((this.Param.Target as IActorTurnToEntityData).EntityId);
				BaseActorComponent baseActorComponent;
				if (entityByPbDataId2 == null)
				{
					baseActorComponent = null;
				}
				else
				{
					WorldEntity entity = entityByPbDataId2.Entity;
					baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
				}
				BaseActorComponent baseActorComponent2 = baseActorComponent;
				if (baseActorComponent2 != null)
				{
					vector = global::Vector.Create(baseActorComponent2.ActorLocationProxy);
					oneOf = new OneOf<BaseActorComponent, global::Vector, AActor>?(baseActorComponent2);
				}
				break;
			}
			case EActorTurnToMode.Position:
				vector = global::Vector.Create();
				vector.FromConfigVector((this.Param.Target as IActorTurnToPositionData).Pos);
				oneOf = new OneOf<BaseActorComponent, global::Vector, AActor>?(vector);
				break;
			case EActorTurnToMode.Player:
			{
				EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
				BaseActorComponent baseActorComponent3;
				if (getCurrentEntity == null)
				{
					baseActorComponent3 = null;
				}
				else
				{
					WorldEntity entity2 = getCurrentEntity.Entity;
					baseActorComponent3 = ((entity2 != null) ? entity2.GetComponent<BaseActorComponent>() : null);
				}
				BaseActorComponent baseActorComponent4 = baseActorComponent3;
				if (baseActorComponent4 != null)
				{
					vector = global::Vector.Create(baseActorComponent4.ActorLocationProxy);
					oneOf = new OneOf<BaseActorComponent, global::Vector, AActor>?(baseActorComponent4);
				}
				break;
			}
			}
			if (vector == null)
			{
				base.FinishExecute(true, false, true);
				return;
			}
			CharacterActorComponent component2 = entityByPbDataId.Entity.GetComponent<CharacterActorComponent>();
			CommonNpcPerformComponent component3 = entityByPbDataId.Entity.GetComponent<CommonNpcPerformComponent>();
			bool flag = this.Param.UseLookAtForSmallAngle.GetValueOrDefault() && component2 != null && component3 != null && NpcTurnToLookAtUtils.ShouldUseLookAtForSmallAngle(component2, vector, 30);
			if (!flag)
			{
				BaseActorComponent component4 = entityByPbDataId.Entity.GetComponent<BaseActorComponent>();
				global::Vector vector2 = global::Vector.Create();
				global::Rotator rotator = global::Rotator.Create();
				vector.Subtraction(component4.ActorLocationProxy, vector2);
				vector2.ToOrientationRotator(rotator);
				rotator.Pitch = 0f;
				rotator.Roll = 0f;
				EntitySimplyMoveInfoPackagePush entitySimplyMoveInfoPackagePush = EntitySimplyMoveInfoPackagePush.Create();
				EntitySimplyMoveInfo entitySimplyMoveInfo = EntitySimplyMoveInfo.Create();
				entitySimplyMoveInfo.EntityId = entityByPbDataId.CreatureDataId;
				entitySimplyMoveInfo.Location = component4.ActorLocationProxy.ToProtocolVector();
				entitySimplyMoveInfo.Rotation = rotator.ToProtocolRotator();
				entitySimplyMoveInfoPackagePush.MoveInfos.Add(entitySimplyMoveInfo);
				Net.Instance.Send(EPushMessageId.EntitySimplyMoveInfoPackagePush, entitySimplyMoveInfoPackagePush);
			}
			TurnParam param = new TurnParam
			{
				TargetLocation = vector,
				UseLookAtForThisTurn = new bool?(flag),
				SightTarget = new OneOf<BaseActorComponent, global::Vector, AActor>?(oneOf ?? vector)
			};
			if (!this.IsAsync)
			{
				this.EntityHandle = entityByPbDataId;
				EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(entityByPbDataId, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
				component.PerformTurn(EPerformMode.Action, param, null, new Action<int>(this.OnEnd));
				return;
			}
			component.PerformTurn(EPerformMode.Action, param, null, null);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A220 RID: 238112 RVA: 0x0106454C File Offset: 0x0106274C
		private void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
		{
			if (this.EntityHandle != handle)
			{
				return;
			}
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelEvent;
			ELogAuthor author = ELogAuthor.FZX;
			string message = "实体被移除 LevelEventEntityTurnTo保底结束";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("PbDataId", handle.PbDataId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.OnEnd(0);
		}

		// Token: 0x0603A221 RID: 238113 RVA: 0x0106459C File Offset: 0x0106279C
		private void OnEnd(int _)
		{
			if (EventSystem.Instance.HasWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
			{
				EventSystem.Instance.RemoveWithTarget<ERemoveEntityType, EntityHandle>(this.EntityHandle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
			}
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0401EB97 RID: 125847
		[Nullable(2)]
		private EntityTurnTo Param;

		// Token: 0x0401EB98 RID: 125848
		[Nullable(2)]
		private EntityHandle EntityHandle;
	}
}
