using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.NewWorld.Pawn.Controllers;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC4 RID: 28100
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelAiTaskSitDown : LevelAiTask
	{
		// Token: 0x060448D2 RID: 280786 RVA: 0x010E7F04 File Offset: 0x010E6104
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

		// Token: 0x060448D3 RID: 280787 RVA: 0x010E7F8C File Offset: 0x010E618C
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

		// Token: 0x060448D4 RID: 280788 RVA: 0x010E802C File Offset: 0x010E622C
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

		// Token: 0x060448D5 RID: 280789 RVA: 0x010E8088 File Offset: 0x010E6288
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

		// Token: 0x060448D6 RID: 280790 RVA: 0x010E80BC File Offset: 0x010E62BC
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

		// Token: 0x060448D7 RID: 280791 RVA: 0x010E85B8 File Offset: 0x010E67B8
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

		// Token: 0x060448D8 RID: 280792 RVA: 0x010E864C File Offset: 0x010E684C
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

		// Token: 0x04023A60 RID: 146016
		private const float NEARBY_CHAIR_OFFSET = 100f;

		// Token: 0x04023A61 RID: 146017
		private const float MOVE_TO_NEARBY_CHAIR_SPEED = 100f;

		// Token: 0x04023A62 RID: 146018
		private const float MOVE_TO_CHAIR_SPEED = 70f;

		// Token: 0x04023A63 RID: 146019
		public bool CanRecordPlanProgress;

		// Token: 0x04023A64 RID: 146020
		public int Cost;

		// Token: 0x04023A65 RID: 146021
		private bool IsInit;

		// Token: 0x04023A66 RID: 146022
		[Nullable(2)]
		private EntityHandle ItemEntity;

		// Token: 0x04023A67 RID: 146023
		private bool ChairNeedSetMorph;
	}
}
