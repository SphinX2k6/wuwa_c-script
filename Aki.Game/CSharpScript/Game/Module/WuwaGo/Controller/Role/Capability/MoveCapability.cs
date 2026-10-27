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
	// Token: 0x02004765 RID: 18277
	[NullableContext(1)]
	[Nullable(0)]
	public class MoveCapability : CapabilityBase
	{
		// Token: 0x0602FC6F RID: 195695 RVA: 0x00B11B07 File Offset: 0x00B0FD07
		public MoveCapability(WuWaGoRole role) : base(role)
		{
		}

		// Token: 0x0602FC70 RID: 195696 RVA: 0x00B11B10 File Offset: 0x00B0FD10
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

		// Token: 0x0602FC71 RID: 195697 RVA: 0x00B11B5C File Offset: 0x00B0FD5C
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

		// Token: 0x0602FC72 RID: 195698 RVA: 0x00B11BA8 File Offset: 0x00B0FDA8
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

		// Token: 0x0602FC73 RID: 195699 RVA: 0x00B11BFC File Offset: 0x00B0FDFC
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

		// Token: 0x0602FC74 RID: 195700 RVA: 0x00B11C40 File Offset: 0x00B0FE40
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

		// Token: 0x0602FC75 RID: 195701 RVA: 0x00B11C8C File Offset: 0x00B0FE8C
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

		// Token: 0x0602FC76 RID: 195702 RVA: 0x00B11CEE File Offset: 0x00B0FEEE
		private static bool HasKuroAnimInstance(WuWaGoRole role)
		{
			UKuroAnimInstanceChar animInstance = role.GetAnimInstance();
			return ((animInstance != null) ? animInstance.LogicParams : null) != null;
		}

		// Token: 0x0602FC77 RID: 195703 RVA: 0x00B11D08 File Offset: 0x00B0FF08
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

		// Token: 0x0602FC78 RID: 195704 RVA: 0x00B11D54 File Offset: 0x00B0FF54
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

		// Token: 0x04019C64 RID: 105572
		private const int ARRIVE_TOLERANCE = 5;

		// Token: 0x04019C65 RID: 105573
		private const int FALLBACK_WALK_SPEED = 200;

		// Token: 0x04019C66 RID: 105574
		private const int TICK_INTERVAL_MS = 20;

		// Token: 0x04019C67 RID: 105575
		private const int SETTLE_DURATION_MS = 60;

		// Token: 0x04019C68 RID: 105576
		private const float SAFE_TIMEOUT_RATIO = 1.5f;

		// Token: 0x04019C69 RID: 105577
		private const string MAIN_CONTROL_MOVE_AUDIO_KEY = "play_interact_waves_go_move";

		// Token: 0x04019C6A RID: 105578
		[StaticVariableRuleIgnore]
		private static readonly Rotator WorldRotationTemp = Rotator.Create();

		// Token: 0x04019C6B RID: 105579
		[StaticVariableRuleIgnore]
		private static readonly Rotator LocalRotationTemp = Rotator.Create();
	}
}
