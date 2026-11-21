using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F43 RID: 24387
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskSitDown : LevelAiTask
	{
		// Token: 0x0603AA36 RID: 240182 RVA: 0x01092144 File Offset: 0x01090344
		public unsafe override void MakePlanExpansions(PlanningContext context, LevelAiWorldState worldState)
		{
			string reason = "Sit Down Task Make Plan Expansions";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelIndex", context.CurrentLevelIndex);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("StepIndex", context.CurrentStepIndex);
			base.PrintDescription(reason, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (!this.IsInit)
			{
				this.Init();
			}
			this.CreatePlanSteps(context, worldState.MakeCopy());
		}

		// Token: 0x0603AA37 RID: 240183 RVA: 0x010921CC File Offset: 0x010903CC
		public void Init()
		{
			if (this.IsInit)
			{
				return;
			}
			NpcLeisureInteract npcLeisureInteract = this.Params as NpcLeisureInteract;
			if (npcLeisureInteract == null)
			{
				return;
			}
			this.NotifyTick = false;
			this.NotifyTaskFinished = false;
			switch (npcLeisureInteract.Option.Type)
			{
			case ENpcLeisureInteract.SitDown:
				this.SitDown((INpcSitDown)npcLeisureInteract.Option);
				this.NotifyTick = this.ChairNeedSetMorph;
				this.NotifyTaskFinished = this.ChairNeedSetMorph;
				return;
			case ENpcLeisureInteract.Swing:
				this.Swing((INpcSwing)npcLeisureInteract.Option);
				return;
			case ENpcLeisureInteract.SwingGetUp:
				this.SwingGetUp((INpcSwingGetUp)npcLeisureInteract.Option);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603AA38 RID: 240184 RVA: 0x0109226C File Offset: 0x0109046C
		private void Swing(INpcSwing option)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(option.TargetNpcId);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (worldEntity == null)
			{
				return;
			}
			CharacterSwingComponent component = worldEntity.GetComponent<CharacterSwingComponent>();
			if (component == null)
			{
				return;
			}
			component.StartSwing(option.SwingDa, option.EntityId, new bool?(option.SkipSitDown.GetValueOrDefault()));
		}

		// Token: 0x0603AA39 RID: 240185 RVA: 0x010922C8 File Offset: 0x010904C8
		private void SwingGetUp(INpcSwingGetUp option)
		{
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(option.TargetNpcId);
			WorldEntity worldEntity = (entityByPbDataId != null) ? entityByPbDataId.Entity : null;
			if (worldEntity == null)
			{
				return;
			}
			CharacterSwingComponent component = worldEntity.GetComponent<CharacterSwingComponent>();
			if (component == null)
			{
				return;
			}
			component.ExitLoopSwing();
		}

		// Token: 0x0603AA3A RID: 240186 RVA: 0x010922FC File Offset: 0x010904FC
		private void SitDown(INpcSitDown option)
		{
			int posEntityId = option.PosEntityId;
			this.ItemEntity = CreatureModel.Instance.GetEntityByPbDataId(posEntityId);
			if (this.ItemEntity == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelAi;
				ELogAuthor author = ELogAuthor.YJX;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(64, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[LevelAiTaskSitDown] Cannot Find Corresponding Item Entity for: ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(posEntityId);
				instance.Info(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PawnInteractNewComponent component = this.ItemEntity.Entity.GetComponent<PawnInteractNewComponent>();
			if (component == null)
			{
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.LevelAi;
				ELogAuthor author2 = ELogAuthor.YJX;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(65, 1);
				defaultInterpolatedStringHandler.AppendLiteral("[LevelAiTaskSitDown] Item Entity ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(posEntityId);
				defaultInterpolatedStringHandler.AppendLiteral(" has no PawnInteractNewComponent");
				instance2.Error(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			PawnChairController pawnChairController = component.GetSubEntityInteractLogicController() as PawnChairController;
			if (pawnChairController == null || !pawnChairController.IsSceneInteractionLoadCompleted())
			{
				return;
			}
			BaseActorComponent component2 = base.CreatureDataComponent.Entity.GetComponent<BaseActorComponent>();
			int pbDataId = base.CreatureDataComponent.GetPbDataId();
			LevelAiTaskSuccess levelAiTaskSuccess = new LevelAiTaskSuccess();
			levelAiTaskSuccess.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description, null);
			pawnChairController.Possess(base.CreatureDataComponent.Entity, false);
			Vector sitLocation = pawnChairController.GetSitLocation();
			Vector forwardDirection = pawnChairController.GetForwardDirection();
			Vector vector = Vector.Create();
			Vector vector2 = Vector.Create();
			forwardDirection.Multiply(100.0, vector);
			sitLocation.Addition(vector, vector2);
			LevelAiTaskMoveTo levelAiTaskMoveTo = new LevelAiTaskMoveTo();
			levelAiTaskMoveTo.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Move To Nearby Chair Location: " + vector2.ToString(), null);
			levelAiTaskMoveTo.Target = Vector.Create();
			levelAiTaskMoveTo.Target.DeepCopy(vector2);
			levelAiTaskMoveTo.MoveState = EMoveSpeed.Walk;
			levelAiTaskMoveTo.MoveSpeed = 100f;
			levelAiTaskSuccess.NextNodes.Add(levelAiTaskMoveTo);
			LevelAiTaskSetItemCollision levelAiTaskSetItemCollision = new LevelAiTaskSetItemCollision();
			levelAiTaskSetItemCollision.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Ignore Actor Collision", null);
			levelAiTaskSetItemCollision.ItemEntity = this.ItemEntity;
			levelAiTaskSetItemCollision.IsIgnore = true;
			levelAiTaskMoveTo.NextNodes.Add(levelAiTaskSetItemCollision);
			Vector actorLocationProxy = component2.ActorLocationProxy;
			Vector vector3 = Vector.Create(sitLocation.X, sitLocation.Y, actorLocationProxy.Z);
			LevelAiTaskMoveTo levelAiTaskMoveTo2 = new LevelAiTaskMoveTo();
			levelAiTaskMoveTo2.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Move To Interact Location: " + vector3.ToString(), null);
			levelAiTaskMoveTo2.Target = Vector.Create();
			levelAiTaskMoveTo2.Target.DeepCopy(vector3);
			levelAiTaskMoveTo2.MoveState = EMoveSpeed.Walk;
			levelAiTaskMoveTo2.MoveSpeed = 70f;
			levelAiTaskSetItemCollision.NextNodes.Add(levelAiTaskMoveTo2);
			Vector vector4 = Vector.Create();
			Vector vector5 = Vector.Create();
			forwardDirection.Multiply(200.0, vector5);
			vector2.Addition(vector5, vector4);
			TurnAndPlayMontageParam @params = new TurnAndPlayMontageParam
			{
				EntityId = pbDataId,
				Pos = vector4,
				MontageId = option.MontageId.MontageId,
				IsAbpMontage = option.MontageId.IsAbp,
				LoopDuration = option.Duration
			};
			LevelAiTaskTurnAndPlayMontage levelAiTaskTurnAndPlayMontage = new LevelAiTaskTurnAndPlayMontage();
			levelAiTaskTurnAndPlayMontage.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Turn To Chair And Play Sit Down Montage", @params);
			levelAiTaskMoveTo2.NextNodes.Add(levelAiTaskTurnAndPlayMontage);
			pawnChairController.UnPossess(base.CreatureDataComponent.Entity);
			LevelAiTaskMoveTo levelAiTaskMoveTo3 = new LevelAiTaskMoveTo();
			levelAiTaskMoveTo3.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Move Back To Nearby Chair Location: " + vector2.ToString(), null);
			levelAiTaskMoveTo3.Target = Vector.Create();
			levelAiTaskMoveTo3.Target.DeepCopy(vector2);
			levelAiTaskMoveTo3.MoveState = EMoveSpeed.Walk;
			levelAiTaskMoveTo3.MoveSpeed = 70f;
			levelAiTaskTurnAndPlayMontage.NextNodes.Add(levelAiTaskMoveTo3);
			LevelAiTaskSetItemCollision levelAiTaskSetItemCollision2 = new LevelAiTaskSetItemCollision();
			levelAiTaskSetItemCollision2.Serialize(base.CharacterPlanComponent, base.CreatureDataComponent, this.Description + " Reset Actor Collision", null);
			levelAiTaskSetItemCollision2.ItemEntity = this.ItemEntity;
			levelAiTaskSetItemCollision2.IsIgnore = false;
			levelAiTaskMoveTo3.NextNodes.Add(levelAiTaskSetItemCollision2);
			if (this.NextNodes.Count > 0)
			{
				foreach (LevelAiStandaloneNode item in this.NextNodes)
				{
					levelAiTaskSetItemCollision2.NextNodes.Add(item);
				}
				this.NextNodes.Clear();
			}
			this.NextNodes.Add(levelAiTaskSuccess);
			this.IsInit = true;
			EntityHandle itemEntity = this.ItemEntity;
			bool? flag;
			if (itemEntity == null)
			{
				flag = null;
			}
			else
			{
				WorldEntity entity = itemEntity.Entity;
				if (entity == null)
				{
					flag = null;
				}
				else
				{
					SceneItemProceduralMaterialComponent component3 = entity.GetComponent<SceneItemProceduralMaterialComponent>();
					flag = ((component3 != null) ? new bool?(component3.HasCustomType(SceneItemProceduralMaterialComponent.ECustomPrimitiveDataSceneItemType.Chair)) : null);
				}
			}
			bool? flag2 = flag;
			this.ChairNeedSetMorph = flag2.GetValueOrDefault();
		}

		// Token: 0x0603AA3B RID: 240187 RVA: 0x01092808 File Offset: 0x01090A08
		protected override void TickTask(float deltaTime)
		{
			base.TickTask(deltaTime);
			if (this.ChairNeedSetMorph)
			{
				CharacterAnimationComponent component = base.CreatureDataComponent.Entity.GetComponent<CharacterAnimationComponent>();
				float? num;
				if (component == null)
				{
					num = null;
				}
				else
				{
					UAnimInstance animInstance = component.GetAnimInstance();
					num = ((animInstance != null) ? new float?(animInstance.GetCurveValue(CharacterNameDefines.Instance.SEAT_MORPH)) : null);
				}
				float? num2 = num;
				float valueOrDefault = num2.GetValueOrDefault();
				AnimController.Instance.SetSeatMorph(this.ItemEntity.Entity, base.CreatureDataComponent.Entity.Id, (double)valueOrDefault);
			}
		}

		// Token: 0x0603AA3C RID: 240188 RVA: 0x0109289C File Offset: 0x01090A9C
		protected override void OnTaskFinished(ELevelAiNodeResult result)
		{
			base.OnTaskFinished(result);
			if (this.ChairNeedSetMorph)
			{
				this.ChairNeedSetMorph = false;
				EntityHandle itemEntity = this.ItemEntity;
				if (((itemEntity != null) ? itemEntity.Entity : null) != null)
				{
					AnimController.Instance.SetSeatMorph(this.ItemEntity.Entity, base.CreatureDataComponent.Entity.Id, 0.0);
				}
			}
		}

		// Token: 0x0401ED02 RID: 126210
		private const float NEARBY_CHAIR_OFFSET = 100f;

		// Token: 0x0401ED03 RID: 126211
		private const float MOVE_TO_NEARBY_CHAIR_SPEED = 100f;

		// Token: 0x0401ED04 RID: 126212
		private const float MOVE_TO_CHAIR_SPEED = 70f;

		// Token: 0x0401ED05 RID: 126213
		public bool CanRecordPlanProgress;

		// Token: 0x0401ED06 RID: 126214
		public int Cost;

		// Token: 0x0401ED07 RID: 126215
		private bool IsInit;

		// Token: 0x0401ED08 RID: 126216
		[Nullable(2)]
		private EntityHandle ItemEntity;

		// Token: 0x0401ED09 RID: 126217
		private bool ChairNeedSetMorph;
	}
}
