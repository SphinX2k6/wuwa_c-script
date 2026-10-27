using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x020072E7 RID: 29415
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraFollowTargetRotator : SceneCameraRotatorBase
	{
		// Token: 0x0604831E RID: 295710 RVA: 0x0128A4A1 File Offset: 0x012886A1
		public SceneCameraFollowTargetRotator(SceneCameraFollowConfig config)
		{
			this.CapturedConfig.DeepCopy(config);
		}

		// Token: 0x0604831F RID: 295711 RVA: 0x0128A4C0 File Offset: 0x012886C0
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x06048320 RID: 295712 RVA: 0x0128A4C4 File Offset: 0x012886C4
		public override void ComputeExpectRotation()
		{
			this.HasValidExpectation = false;
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				return;
			}
			Vector vector = this.ResolveTargetPosition();
			if (vector == null)
			{
				return;
			}
			this.ScratchVector1.DeepCopy(vector);
			Vector scratchVector = this.ScratchVector2;
			FVectorDouble fvectorDouble = bp_CineCamera_C.D_K2_GetActorLocation();
			scratchVector.DeepCopy(fvectorDouble);
			this.ScratchVector1.SubtractionEqual(this.ScratchVector2);
			if (MathUtils.Instance.IsNearlyZero(this.ScratchVector1.SizeSquared(), null))
			{
				return;
			}
			MathUtils.Instance.LookRotationForwardFirst(this.ScratchVector1, this.GravityUp, this.WorkingQuat);
			this.HasValidExpectation = true;
		}

		// Token: 0x06048321 RID: 295713 RVA: 0x0128A578 File Offset: 0x01288778
		public override void ApplyRotationLimit()
		{
		}

		// Token: 0x06048322 RID: 295714 RVA: 0x0128A57C File Offset: 0x0128877C
		public override void ApplyRotationToCameraActor()
		{
			if (!this.HasValidExpectation)
			{
				return;
			}
			SceneSubCamera subCamera = this.SubCamera;
			BP_CineCamera_C bp_CineCamera_C = (subCamera != null) ? subCamera.Camera : null;
			if (bp_CineCamera_C == null || !bp_CineCamera_C.IsValid())
			{
				return;
			}
			if (!this.IsNormalGravity)
			{
				base.ClearCameraGravityRoll();
			}
			this.WorkingQuat.Rotator(this.WorkingRotator);
			base.WriteCameraRotation();
		}

		// Token: 0x06048323 RID: 295715 RVA: 0x0128A5D8 File Offset: 0x012887D8
		[NullableContext(2)]
		private Vector ResolveTargetPosition()
		{
			ESceneCameraFollowTargetType targetType = this.CapturedConfig.TargetType;
			if (targetType != ESceneCameraFollowTargetType.Player)
			{
				if (targetType != ESceneCameraFollowTargetType.Entity)
				{
					return null;
				}
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(this.CapturedConfig.EntityId);
				if (entityByPbDataId == null || !entityByPbDataId.Valid)
				{
					return null;
				}
				WorldEntity entity = entityByPbDataId.Entity;
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent == null)
				{
					return null;
				}
				return baseActorComponent.ActorLocationProxy;
			}
			else
			{
				FightCameraLogicComponent fightCameraLogicComp = this.FightCameraLogicComp;
				EntityHandle entityHandle = (fightCameraLogicComp != null) ? fightCameraLogicComp.CharacterEntityHandle : null;
				if (entityHandle == null || !entityHandle.Valid)
				{
					return null;
				}
				WorldEntity entity2 = entityHandle.Entity;
				CharacterActorComponent characterActorComponent = (entity2 != null) ? entity2.GetComponent<CharacterActorComponent>() : null;
				if (characterActorComponent == null)
				{
					return null;
				}
				return characterActorComponent.ActorLocationProxy;
			}
		}

		// Token: 0x040261FF RID: 156159
		private readonly SceneCameraFollowConfig CapturedConfig = new SceneCameraFollowConfig();

		// Token: 0x04026200 RID: 156160
		private bool HasValidExpectation;
	}
}
