using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Gameplay.WuWaGo;
using CSharpScript.Game.Module.WuwaGo.Model;
using CSharpScript.Game.Module.WuwaGo.Model.Role;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo.Controller.Role.Capability
{
	// Token: 0x02003694 RID: 13972
	[NullableContext(1)]
	[Nullable(0)]
	public class ClimbCapability : CapabilityBase
	{
		// Token: 0x06024425 RID: 148517 RVA: 0x00A411A9 File Offset: 0x00A3F3A9
		public ClimbCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x06024426 RID: 148518 RVA: 0x00A411B4 File Offset: 0x00A3F3B4
		public UniTask GroundToWall(WuWaGoGrid targetVerticalGrid)
		{
			ClimbCapability.<GroundToWall>d__3 <GroundToWall>d__;
			<GroundToWall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<GroundToWall>d__.<>4__this = this;
			<GroundToWall>d__.targetVerticalGrid = targetVerticalGrid;
			<GroundToWall>d__.<>1__state = -1;
			<GroundToWall>d__.<>t__builder.Start<ClimbCapability.<GroundToWall>d__3>(ref <GroundToWall>d__);
			return <GroundToWall>d__.<>t__builder.Task;
		}

		// Token: 0x06024427 RID: 148519 RVA: 0x00A41200 File Offset: 0x00A3F400
		public UniTask WallToGround(WuWaGoGrid targetHorizontalGrid)
		{
			ClimbCapability.<WallToGround>d__4 <WallToGround>d__;
			<WallToGround>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<WallToGround>d__.<>4__this = this;
			<WallToGround>d__.targetHorizontalGrid = targetHorizontalGrid;
			<WallToGround>d__.<>1__state = -1;
			<WallToGround>d__.<>t__builder.Start<ClimbCapability.<WallToGround>d__4>(ref <WallToGround>d__);
			return <WallToGround>d__.<>t__builder.Task;
		}

		// Token: 0x06024428 RID: 148520 RVA: 0x00A4124C File Offset: 0x00A3F44C
		public UniTask MoveOnWall(WuWaGoGrid targetVertical)
		{
			ClimbCapability.<MoveOnWall>d__5 <MoveOnWall>d__;
			<MoveOnWall>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveOnWall>d__.<>4__this = this;
			<MoveOnWall>d__.targetVertical = targetVertical;
			<MoveOnWall>d__.<>1__state = -1;
			<MoveOnWall>d__.<>t__builder.Start<ClimbCapability.<MoveOnWall>d__5>(ref <MoveOnWall>d__);
			return <MoveOnWall>d__.<>t__builder.Task;
		}

		// Token: 0x06024429 RID: 148521 RVA: 0x00A41298 File Offset: 0x00A3F498
		public void EnterClimbIdle()
		{
			UKuroAnimInstanceMonster ukuroAnimInstanceMonster = WuWaGoUtil.GetActorAnimInstance(this.Role, "EnterClimbIdle") as UKuroAnimInstanceMonster;
			if (ukuroAnimInstanceMonster == null)
			{
				return;
			}
			ukuroAnimInstanceMonster.bIdleThreeState = true;
			UCharacterMovementComponent characterMovement = this.Role.CharacterMovement;
			if (characterMovement != null)
			{
				characterMovement.SetMovementMode(EMovementMode.MOVE_Flying, 0);
			}
			this.Role.SetIsClimbing(true);
		}

		// Token: 0x0602442A RID: 148522 RVA: 0x00A412EC File Offset: 0x00A3F4EC
		public void ExitClimbIdle()
		{
			UKuroAnimInstanceMonster ukuroAnimInstanceMonster = WuWaGoUtil.GetActorAnimInstance(this.Role, "EnterClimbIdle") as UKuroAnimInstanceMonster;
			if (ukuroAnimInstanceMonster == null)
			{
				return;
			}
			ukuroAnimInstanceMonster.bIdleThreeState = false;
			UCharacterMovementComponent characterMovement = this.Role.CharacterMovement;
			if (characterMovement != null)
			{
				characterMovement.SetMovementMode(EMovementMode.MOVE_Walking, 0);
			}
			this.Role.SetIsClimbing(false);
		}

		// Token: 0x0602442B RID: 148523 RVA: 0x00A4133D File Offset: 0x00A3F53D
		[NullableContext(2)]
		private WuWaGoGrid GetStandGrid()
		{
			return WuWaGoModel.Instance.GetGridById(this.Role.StandGridId);
		}

		// Token: 0x0602442C RID: 148524 RVA: 0x00A41354 File Offset: 0x00A3F554
		private void FaceTowardsWallNormal(WuWaGoGrid vGrid)
		{
			FVectorDouble? worldLocation = this.Role.GetWorldLocation();
			if (worldLocation == null)
			{
				return;
			}
			IWallFrame wallFrame = vGrid.WallFrame;
			if (wallFrame == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.WuWaGo;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "FaceTowardsWallNormal:拿不到wallFrame";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("vGrid", vGrid.Coordinate.ToString());
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			int num = wallFrame.WallNormalX * wallFrame.OwnerSign;
			int num2 = wallFrame.WallNormalY * wallFrame.OwnerSign;
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, vGrid.Coordinate, null);
			Vector worldPositionByCoordinate2 = WuWaGoUtil.GetWorldPositionByCoordinate(originTransform, Vector.Create(vGrid.Coordinate.X + (double)num, vGrid.Coordinate.Y + (double)num2, vGrid.Coordinate.Z), null);
			Vector targetWorldPosition = Vector.Create(worldLocation.Value.X + (worldPositionByCoordinate2.X - worldPositionByCoordinate.X), worldLocation.Value.Y + (worldPositionByCoordinate2.Y - worldPositionByCoordinate.Y), worldLocation.Value.Z);
			WuWaGoUtil.ComputeFaceTowardsRotations(this.Role, targetWorldPosition, originTransform, ClimbCapability.WorldRotationTemp, ClimbCapability.LocalRotationTemp);
			this.Role.SetActorWorldRotation(ClimbCapability.WorldRotationTemp);
			this.Role.SetRotator(ClimbCapability.LocalRotationTemp);
		}

		// Token: 0x0602442D RID: 148525 RVA: 0x00A414AC File Offset: 0x00A3F6AC
		private Vector GetCoordinateWorldPositionForActor(Vector gridCoordinate, bool bAdjustMeshZ)
		{
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(WuWaGoModel.Instance.GameData.OriginTransform, gridCoordinate, null);
			if (bAdjustMeshZ)
			{
				USkeletalMeshComponent mesh = this.Role.Mesh;
				float num = (mesh != null) ? mesh.RelativeLocation.Z : 0f;
				worldPositionByCoordinate.Z -= (double)num;
			}
			return worldPositionByCoordinate;
		}

		// Token: 0x0602442E RID: 148526 RVA: 0x00A41504 File Offset: 0x00A3F704
		private EWuWaGoClimbMontage? PickWallMoveAction(WuWaGoGrid fromV, WuWaGoGrid toV)
		{
			double num = toV.Coordinate.X - fromV.Coordinate.X;
			double num2 = toV.Coordinate.Y - fromV.Coordinate.Y;
			double num3 = toV.Coordinate.Z - fromV.Coordinate.Z;
			if (MathUtils.Instance.IsNearlyZero(num, null) && MathUtils.Instance.IsNearlyZero(num2, null) && !MathUtils.Instance.IsNearlyZero(num3, null))
			{
				return new EWuWaGoClimbMontage?((num3 > 0.0) ? EWuWaGoClimbMontage.Up : EWuWaGoClimbMontage.Down);
			}
			if (!MathUtils.Instance.IsNearlyZero(num3, null))
			{
				return null;
			}
			IWallFrame wallFrame = fromV.WallFrame;
			if (wallFrame == null)
			{
				return null;
			}
			int num4 = wallFrame.WallNormalX * wallFrame.OwnerSign;
			int num5 = -(wallFrame.WallNormalY * wallFrame.OwnerSign);
			int num6 = num4;
			double num7 = num * (double)num5 + num2 * (double)num6;
			if (MathUtils.Instance.IsNearlyZero(num7, null))
			{
				return null;
			}
			return new EWuWaGoClimbMontage?((num7 > 0.0) ? EWuWaGoClimbMontage.Right : EWuWaGoClimbMontage.Left);
		}

		// Token: 0x0401430A RID: 82698
		[StaticVariableRuleIgnore]
		private static readonly Rotator WorldRotationTemp = Rotator.Create();

		// Token: 0x0401430B RID: 82699
		[StaticVariableRuleIgnore]
		private static readonly Rotator LocalRotationTemp = Rotator.Create();
	}
}
