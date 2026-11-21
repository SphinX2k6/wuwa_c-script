using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using UnrealEngine;

namespace CSharpScript.Game.Camera.SceneCameraRotator
{
	// Token: 0x0200646A RID: 25706
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneCameraFollowTargetRotator : SceneCameraRotatorBase
	{
		// Token: 0x0603E76A RID: 255850 RVA: 0x0122CE4D File Offset: 0x0122B04D
		public SceneCameraFollowTargetRotator(SceneCameraFollowConfig config)
		{
			this.CapturedConfig.DeepCopy(config);
		}

		// Token: 0x0603E76B RID: 255851 RVA: 0x0122CE6C File Offset: 0x0122B06C
		public override bool IsValid()
		{
			return true;
		}

		// Token: 0x0603E76C RID: 255852 RVA: 0x0122CE70 File Offset: 0x0122B070
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

		// Token: 0x0603E76D RID: 255853 RVA: 0x0122CF24 File Offset: 0x0122B124
		public override void ApplyRotationLimit()
		{
		}

		// Token: 0x0603E76E RID: 255854 RVA: 0x0122CF28 File Offset: 0x0122B128
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

		// Token: 0x0603E76F RID: 255855 RVA: 0x0122CF84 File Offset: 0x0122B184
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

		// Token: 0x040214EA RID: 136426
		private readonly SceneCameraFollowConfig CapturedConfig = new SceneCameraFollowConfig();

		// Token: 0x040214EB RID: 136427
		private bool HasValidExpectation;
	}
}
