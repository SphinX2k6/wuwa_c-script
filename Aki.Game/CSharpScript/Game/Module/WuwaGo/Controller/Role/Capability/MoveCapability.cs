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
	// Token: 0x02003696 RID: 13974
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveCapability : CapabilityBase
	{
		// Token: 0x06024439 RID: 148537 RVA: 0x00A41AC7 File Offset: 0x00A3FCC7
		public MoveCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x0602443A RID: 148538 RVA: 0x00A41AD0 File Offset: 0x00A3FCD0
		[NullableContext(2)]
		public UniTask MoveToGrid(WuWaGoGrid grid)
		{
			MoveCapability.<MoveToGrid>d__9 <MoveToGrid>d__;
			<MoveToGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveToGrid>d__.<>4__this = this;
			<MoveToGrid>d__.grid = grid;
			<MoveToGrid>d__.<>1__state = -1;
			<MoveToGrid>d__.<>t__builder.Start<MoveCapability.<MoveToGrid>d__9>(ref <MoveToGrid>d__);
			return <MoveToGrid>d__.<>t__builder.Task;
		}

		// Token: 0x0602443B RID: 148539 RVA: 0x00A41B1C File Offset: 0x00A3FD1C
		public UniTask MoveToWorldPosition(Vector targetWorldPosition)
		{
			MoveCapability.<MoveToWorldPosition>d__10 <MoveToWorldPosition>d__;
			<MoveToWorldPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveToWorldPosition>d__.<>4__this = this;
			<MoveToWorldPosition>d__.targetWorldPosition = targetWorldPosition;
			<MoveToWorldPosition>d__.<>1__state = -1;
			<MoveToWorldPosition>d__.<>t__builder.Start<MoveCapability.<MoveToWorldPosition>d__10>(ref <MoveToWorldPosition>d__);
			return <MoveToWorldPosition>d__.<>t__builder.Task;
		}

		// Token: 0x0602443C RID: 148540 RVA: 0x00A41B68 File Offset: 0x00A3FD68
		public UniTask MoveActorVisuallyTowardsAsync(Vector targetWorldPosition, float maxStepDistance)
		{
			MoveCapability.<MoveActorVisuallyTowardsAsync>d__11 <MoveActorVisuallyTowardsAsync>d__;
			<MoveActorVisuallyTowardsAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<MoveActorVisuallyTowardsAsync>d__.<>4__this = this;
			<MoveActorVisuallyTowardsAsync>d__.targetWorldPosition = targetWorldPosition;
			<MoveActorVisuallyTowardsAsync>d__.maxStepDistance = maxStepDistance;
			<MoveActorVisuallyTowardsAsync>d__.<>1__state = -1;
			<MoveActorVisuallyTowardsAsync>d__.<>t__builder.Start<MoveCapability.<MoveActorVisuallyTowardsAsync>d__11>(ref <MoveActorVisuallyTowardsAsync>d__);
			return <MoveActorVisuallyTowardsAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602443D RID: 148541 RVA: 0x00A41BBC File Offset: 0x00A3FDBC
		[NullableContext(2)]
		public void FaceTowardsGrid(WuWaGoGrid grid)
		{
			if (!this.Role.IsActorValid() || grid == null)
			{
				return;
			}
			Vector worldPositionByCoordinate = WuWaGoUtil.GetWorldPositionByCoordinate(WuWaGoModel.Instance.GameData.OriginTransform, grid.Coordinate, null);
			this.FaceActorTowardsWorldPosition(worldPositionByCoordinate);
		}

		// Token: 0x0602443E RID: 148542 RVA: 0x00A41C00 File Offset: 0x00A3FE00
		[NullableContext(0)]
		private UniTask<bool> MoveActorToWorldPosition([Nullable(1)] Vector targetWorldPosition)
		{
			MoveCapability.<MoveActorToWorldPosition>d__13 <MoveActorToWorldPosition>d__;
			<MoveActorToWorldPosition>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<MoveActorToWorldPosition>d__.<>4__this = this;
			<MoveActorToWorldPosition>d__.targetWorldPosition = targetWorldPosition;
			<MoveActorToWorldPosition>d__.<>1__state = -1;
			<MoveActorToWorldPosition>d__.<>t__builder.Start<MoveCapability.<MoveActorToWorldPosition>d__13>(ref <MoveActorToWorldPosition>d__);
			return <MoveActorToWorldPosition>d__.<>t__builder.Task;
		}

		// Token: 0x0602443F RID: 148543 RVA: 0x00A41C4C File Offset: 0x00A3FE4C
		private void FaceActorTowardsWorldPosition(Vector targetWorldPosition)
		{
			if (!this.Role.IsActorValid())
			{
				return;
			}
			Transform originTransform = WuWaGoModel.Instance.GameData.OriginTransform;
			WuWaGoUtil.ComputeFaceTowardsRotations(this.Role, targetWorldPosition, originTransform, MoveCapability.WorldRotationTemp, MoveCapability.LocalRotationTemp);
			this.Role.SetActorWorldRotation(MoveCapability.WorldRotationTemp);
			this.Role.SetRotator(MoveCapability.LocalRotationTemp);
		}

		// Token: 0x06024440 RID: 148544 RVA: 0x00A41CAE File Offset: 0x00A3FEAE
		private static bool HasKuroAnimInstance(WuWaGoRole role)
		{
			UKuroAnimInstanceChar animInstance = role.GetAnimInstance();
			return ((animInstance != null) ? animInstance.LogicParams : null) != null;
		}

		// Token: 0x06024441 RID: 148545 RVA: 0x00A41CC8 File Offset: 0x00A3FEC8
		[NullableContext(0)]
		private UniTask<bool> PerformMoveAnim([Nullable(1)] Vector targetLocation)
		{
			MoveCapability.<PerformMoveAnim>d__16 <PerformMoveAnim>d__;
			<PerformMoveAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PerformMoveAnim>d__.<>4__this = this;
			<PerformMoveAnim>d__.targetLocation = targetLocation;
			<PerformMoveAnim>d__.<>1__state = -1;
			<PerformMoveAnim>d__.<>t__builder.Start<MoveCapability.<PerformMoveAnim>d__16>(ref <PerformMoveAnim>d__);
			return <PerformMoveAnim>d__.<>t__builder.Task;
		}

		// Token: 0x06024442 RID: 148546 RVA: 0x00A41D14 File Offset: 0x00A3FF14
		[NullableContext(2)]
		private float GetCharacterMoveSpeed(UCharacterMovementComponent charMove)
		{
			BP_WuWaGo_C setting = WuWaGoGlobal.Setting;
			int? num = (setting != null) ? new int?(setting.CharacterMoveSpeed) : null;
			if (num != null && num.GetValueOrDefault() > 0)
			{
				return (float)num.Value;
			}
			float? num2 = (charMove != null) ? new float?(charMove.MaxWalkSpeed) : null;
			if (num2 != null && num2.GetValueOrDefault() > 0f)
			{
				return charMove.MaxWalkSpeed;
			}
			return 200f;
		}

		// Token: 0x04014314 RID: 82708
		private const int ARRIVE_TOLERANCE = 5;

		// Token: 0x04014315 RID: 82709
		private const int FALLBACK_WALK_SPEED = 200;

		// Token: 0x04014316 RID: 82710
		private const int TICK_INTERVAL_MS = 20;

		// Token: 0x04014317 RID: 82711
		private const int SETTLE_DURATION_MS = 60;

		// Token: 0x04014318 RID: 82712
		private const float SAFE_TIMEOUT_RATIO = 1.5f;

		// Token: 0x04014319 RID: 82713
		private const string MAIN_CONTROL_MOVE_AUDIO_KEY = "play_interact_waves_go_move";

		// Token: 0x0401431A RID: 82714
		[StaticVariableRuleIgnore]
		private static readonly Rotator WorldRotationTemp = Rotator.Create();

		// Token: 0x0401431B RID: 82715
		[StaticVariableRuleIgnore]
		private static readonly Rotator LocalRotationTemp = Rotator.Create();
	}
}
