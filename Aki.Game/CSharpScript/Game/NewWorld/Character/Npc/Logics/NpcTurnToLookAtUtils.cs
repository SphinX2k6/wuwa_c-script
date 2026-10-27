using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Npc.Logics
{
	// Token: 0x02007093 RID: 28819
	[NullableContext(1)]
	[Nullable(0)]
	public static class NpcTurnToLookAtUtils
	{
		// Token: 0x0604639E RID: 287646 RVA: 0x011920B8 File Offset: 0x011902B8
		public static bool ShouldUseLookAtForSmallAngle(CharacterActorComponent actorComp, Vector targetPoint, int threshold = 30)
		{
			Vector vector = Vector.Create(targetPoint);
			vector.SubtractionEqual(actorComp.ActorLocationProxy);
			vector.Z = 0.0;
			if (vector.IsNearlyZero(9.999999747378752E-05))
			{
				return false;
			}
			vector.Normalize(9.99999993922529E-09);
			Vector vector2 = Vector.Create(actorComp.ActorForwardProxy);
			vector2.Z = 0.0;
			if (vector2.IsNearlyZero(9.999999747378752E-05))
			{
				return false;
			}
			vector2.Normalize(9.99999993922529E-09);
			return MathUtils.Instance.GetAngleByVectorDot(vector2, vector) < (double)threshold;
		}

		// Token: 0x0604639F RID: 287647 RVA: 0x0119215C File Offset: 0x0119035C
		public static ETurnToTargetResult TurnToTargetOrLookAtForSmallAngle(Entity entity, CharacterActorComponent actorComp, Vector targetPoint, float turnSpeed, bool containZ = false, float minTurnTimeSeconds = 0f, bool useLookAtForThisTurn = false, [Nullable(new byte[]
		{
			0,
			1,
			1,
			1
		})] OneOf<BaseActorComponent, Vector, AActor>? sightTarget = null)
		{
			if (useLookAtForThisTurn)
			{
				CommonNpcPerformComponent component = entity.GetComponent<CommonNpcPerformComponent>();
				if (component != null)
				{
					component.SightTarget(new OneOf<BaseActorComponent, Vector, AActor>?(sightTarget ?? targetPoint), EStareActionType.TurnToTargetForSmallAngle);
					return ETurnToTargetResult.LookAt;
				}
			}
			AiControllerLibrary.TurnToTarget(actorComp, targetPoint, turnSpeed, containZ, minTurnTimeSeconds);
			return ETurnToTargetResult.TurnToTarget;
		}

		// Token: 0x060463A0 RID: 287648 RVA: 0x011921B0 File Offset: 0x011903B0
		[NullableContext(2)]
		public static void ClearSmallAngleTurnToLookAt(Entity entity)
		{
			CommonNpcPerformComponent commonNpcPerformComponent = (entity != null) ? entity.GetComponent<CommonNpcPerformComponent>() : null;
			if (commonNpcPerformComponent == null)
			{
				return;
			}
			commonNpcPerformComponent.SightTarget(null, EStareActionType.TurnToTargetForSmallAngle);
		}

		// Token: 0x04024CC0 RID: 150720
		public const int SMALL_ANGLE_TURN_TO_LOOK_AT_THRESHOLD = 30;

		// Token: 0x04024CC1 RID: 150721
		public const EStareActionType SMALL_ANGLE_TURN_TO_LOOK_AT_CONTEXT = EStareActionType.TurnToTargetForSmallAngle;
	}
}
