using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042EC RID: 17132
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(180, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 180)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SAnimLogicParams.SAnimLogicParams")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 180)]
	public struct SAnimLogicParams : IEqualityOperators<SAnimLogicParams, SAnimLogicParams, bool>, IEquatable<SAnimLogicParams>, IUnrealScriptStruct
	{
		// Token: 0x0602C3B7 RID: 181175 RVA: 0x00A1AB18 File Offset: 0x00A18D18
		public SAnimLogicParams(bool AcceptedNewBeHit, TEnumAsByte<EHitAnim> BeHitAnim, bool EnterFk, bool DoubleHitInAir, FVector BeHitDirect, FVector BeHitLocation, TEnumAsByte<ECharState> CharMoveState, TEnumAsByte<ECharParentMoveState> CharPositionState, TEnumAsByte<ECharViewDirectionState> CharCameraState, float BattleIdleTime, float DegMovementSlope, FVector SightDirect, bool RagQuitState, bool IsJump, FVector Acceleration, bool IsMoving, float Speed, FVector InputDirect, bool IsFallingIntoWater, float GroundedTime, bool HasMoveInput, SClimbInfo ClimbInfo, SClimbState ClimbState, float ClimbRadius, FRotator InputRotator, float ClimbOnWallAngle, float SprintSwimOffset, float SprintSwimOffsetLerpSpeed, FVector SlideForward, bool SlideSwitchThisFrame, bool SlideStandMode, float JumpUpRate)
		{
			this.AcceptedNewBeHit = AcceptedNewBeHit;
			this.BeHitAnim = BeHitAnim;
			this.EnterFk = EnterFk;
			this.DoubleHitInAir = DoubleHitInAir;
			this.BeHitDirect = BeHitDirect;
			this.BeHitLocation = BeHitLocation;
			this.CharMoveState = CharMoveState;
			this.CharPositionState = CharPositionState;
			this.CharCameraState = CharCameraState;
			this.BattleIdleTime = BattleIdleTime;
			this.DegMovementSlope = DegMovementSlope;
			this.SightDirect = SightDirect;
			this.RagQuitState = RagQuitState;
			this.IsJump = IsJump;
			this.Acceleration = Acceleration;
			this.IsMoving = IsMoving;
			this.Speed = Speed;
			this.InputDirect = InputDirect;
			this.IsFallingIntoWater = IsFallingIntoWater;
			this.GroundedTime = GroundedTime;
			this.HasMoveInput = HasMoveInput;
			this.ClimbInfo = ClimbInfo;
			this.ClimbState = ClimbState;
			this.ClimbRadius = ClimbRadius;
			this.InputRotator = InputRotator;
			this.ClimbOnWallAngle = ClimbOnWallAngle;
			this.SprintSwimOffset = SprintSwimOffset;
			this.SprintSwimOffsetLerpSpeed = SprintSwimOffsetLerpSpeed;
			this.SlideForward = SlideForward;
			this.SlideSwitchThisFrame = SlideSwitchThisFrame;
			this.SlideStandMode = SlideStandMode;
			this.JumpUpRate = JumpUpRate;
		}

		// Token: 0x0602C3B8 RID: 181176 RVA: 0x00A1AC24 File Offset: 0x00A18E24
		public static bool operator ==(SAnimLogicParams left, SAnimLogicParams right)
		{
			return left.AcceptedNewBeHit == right.AcceptedNewBeHit && left.BeHitAnim == right.BeHitAnim && left.EnterFk == right.EnterFk && left.DoubleHitInAir == right.DoubleHitInAir && left.BeHitDirect == right.BeHitDirect && left.BeHitLocation == right.BeHitLocation && left.CharMoveState == right.CharMoveState && left.CharPositionState == right.CharPositionState && left.CharCameraState == right.CharCameraState && left.BattleIdleTime == right.BattleIdleTime && left.DegMovementSlope == right.DegMovementSlope && left.SightDirect == right.SightDirect && left.RagQuitState == right.RagQuitState && left.IsJump == right.IsJump && left.Acceleration == right.Acceleration && left.IsMoving == right.IsMoving && left.Speed == right.Speed && left.InputDirect == right.InputDirect && left.IsFallingIntoWater == right.IsFallingIntoWater && left.GroundedTime == right.GroundedTime && left.HasMoveInput == right.HasMoveInput && left.ClimbInfo == right.ClimbInfo && left.ClimbState == right.ClimbState && left.ClimbRadius == right.ClimbRadius && left.InputRotator == right.InputRotator && left.ClimbOnWallAngle == right.ClimbOnWallAngle && left.SprintSwimOffset == right.SprintSwimOffset && left.SprintSwimOffsetLerpSpeed == right.SprintSwimOffsetLerpSpeed && left.SlideForward == right.SlideForward && left.SlideSwitchThisFrame == right.SlideSwitchThisFrame && left.SlideStandMode == right.SlideStandMode && left.JumpUpRate == right.JumpUpRate;
		}

		// Token: 0x0602C3B9 RID: 181177 RVA: 0x00A1AE79 File Offset: 0x00A19079
		public static bool operator !=(SAnimLogicParams left, SAnimLogicParams right)
		{
			return !(left == right);
		}

		// Token: 0x0602C3BA RID: 181178 RVA: 0x00A1AE85 File Offset: 0x00A19085
		public bool Equals(SAnimLogicParams other)
		{
			return this == other;
		}

		// Token: 0x0602C3BB RID: 181179 RVA: 0x00A1AE94 File Offset: 0x00A19094
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is SAnimLogicParams)
			{
				SAnimLogicParams other = (SAnimLogicParams)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602C3BC RID: 181180 RVA: 0x00A1AEBC File Offset: 0x00A190BC
		public override int GetHashCode()
		{
			HashCode hashCode = default(HashCode);
			hashCode.Add<bool>(this.AcceptedNewBeHit);
			hashCode.Add<TEnumAsByte<EHitAnim>>(this.BeHitAnim);
			hashCode.Add<bool>(this.EnterFk);
			hashCode.Add<bool>(this.DoubleHitInAir);
			hashCode.Add<FVector>(this.BeHitDirect);
			hashCode.Add<FVector>(this.BeHitLocation);
			hashCode.Add<TEnumAsByte<ECharState>>(this.CharMoveState);
			hashCode.Add<TEnumAsByte<ECharParentMoveState>>(this.CharPositionState);
			hashCode.Add<TEnumAsByte<ECharViewDirectionState>>(this.CharCameraState);
			hashCode.Add<float>(this.BattleIdleTime);
			hashCode.Add<float>(this.DegMovementSlope);
			hashCode.Add<FVector>(this.SightDirect);
			hashCode.Add<bool>(this.RagQuitState);
			hashCode.Add<bool>(this.IsJump);
			hashCode.Add<FVector>(this.Acceleration);
			hashCode.Add<bool>(this.IsMoving);
			hashCode.Add<float>(this.Speed);
			hashCode.Add<FVector>(this.InputDirect);
			hashCode.Add<bool>(this.IsFallingIntoWater);
			hashCode.Add<float>(this.GroundedTime);
			hashCode.Add<bool>(this.HasMoveInput);
			hashCode.Add<SClimbInfo>(this.ClimbInfo);
			hashCode.Add<SClimbState>(this.ClimbState);
			hashCode.Add<float>(this.ClimbRadius);
			hashCode.Add<FRotator>(this.InputRotator);
			hashCode.Add<float>(this.ClimbOnWallAngle);
			hashCode.Add<float>(this.SprintSwimOffset);
			hashCode.Add<float>(this.SprintSwimOffsetLerpSpeed);
			hashCode.Add<FVector>(this.SlideForward);
			hashCode.Add<bool>(this.SlideSwitchThisFrame);
			hashCode.Add<bool>(this.SlideStandMode);
			hashCode.Add<float>(this.JumpUpRate);
			return hashCode.ToHashCode();
		}

		// Token: 0x0602C3BD RID: 181181 RVA: 0x00A1B078 File Offset: 0x00A19278
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SAnimLogicParams._ScriptStructPtr != 0) ? SAnimLogicParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SAnimLogicParams.SAnimLogicParams", ref SAnimLogicParams._ScriptStructPtr);
		}

		// Token: 0x04017524 RID: 95524
		[FieldOffset(0)]
		public bool AcceptedNewBeHit;

		// Token: 0x04017525 RID: 95525
		[FieldOffset(1)]
		public TEnumAsByte<EHitAnim> BeHitAnim;

		// Token: 0x04017526 RID: 95526
		[FieldOffset(2)]
		public bool EnterFk;

		// Token: 0x04017527 RID: 95527
		[FieldOffset(3)]
		public bool DoubleHitInAir;

		// Token: 0x04017528 RID: 95528
		[FieldOffset(4)]
		public FVector BeHitDirect;

		// Token: 0x04017529 RID: 95529
		[FieldOffset(16)]
		public FVector BeHitLocation;

		// Token: 0x0401752A RID: 95530
		[FieldOffset(28)]
		public TEnumAsByte<ECharState> CharMoveState;

		// Token: 0x0401752B RID: 95531
		[FieldOffset(29)]
		public TEnumAsByte<ECharParentMoveState> CharPositionState;

		// Token: 0x0401752C RID: 95532
		[FieldOffset(30)]
		public TEnumAsByte<ECharViewDirectionState> CharCameraState;

		// Token: 0x0401752D RID: 95533
		[FieldOffset(32)]
		public float BattleIdleTime;

		// Token: 0x0401752E RID: 95534
		[FieldOffset(36)]
		public float DegMovementSlope;

		// Token: 0x0401752F RID: 95535
		[FieldOffset(40)]
		public FVector SightDirect;

		// Token: 0x04017530 RID: 95536
		[FieldOffset(52)]
		public bool RagQuitState;

		// Token: 0x04017531 RID: 95537
		[FieldOffset(53)]
		public bool IsJump;

		// Token: 0x04017532 RID: 95538
		[FieldOffset(56)]
		public FVector Acceleration;

		// Token: 0x04017533 RID: 95539
		[FieldOffset(68)]
		public bool IsMoving;

		// Token: 0x04017534 RID: 95540
		[FieldOffset(72)]
		public float Speed;

		// Token: 0x04017535 RID: 95541
		[FieldOffset(76)]
		public FVector InputDirect;

		// Token: 0x04017536 RID: 95542
		[FieldOffset(88)]
		public bool IsFallingIntoWater;

		// Token: 0x04017537 RID: 95543
		[FieldOffset(92)]
		public float GroundedTime;

		// Token: 0x04017538 RID: 95544
		[FieldOffset(96)]
		public bool HasMoveInput;

		// Token: 0x04017539 RID: 95545
		[FieldOffset(100)]
		public SClimbInfo ClimbInfo;

		// Token: 0x0401753A RID: 95546
		[FieldOffset(128)]
		public SClimbState ClimbState;

		// Token: 0x0401753B RID: 95547
		[FieldOffset(132)]
		public float ClimbRadius;

		// Token: 0x0401753C RID: 95548
		[FieldOffset(136)]
		public FRotator InputRotator;

		// Token: 0x0401753D RID: 95549
		[FieldOffset(148)]
		public float ClimbOnWallAngle;

		// Token: 0x0401753E RID: 95550
		[FieldOffset(152)]
		public float SprintSwimOffset;

		// Token: 0x0401753F RID: 95551
		[FieldOffset(156)]
		public float SprintSwimOffsetLerpSpeed;

		// Token: 0x04017540 RID: 95552
		[FieldOffset(160)]
		public FVector SlideForward;

		// Token: 0x04017541 RID: 95553
		[FieldOffset(172)]
		public bool SlideSwitchThisFrame;

		// Token: 0x04017542 RID: 95554
		[FieldOffset(173)]
		public bool SlideStandMode;

		// Token: 0x04017543 RID: 95555
		[FieldOffset(176)]
		public float JumpUpRate;

		// Token: 0x04017544 RID: 95556
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SAnimLogicParams.SAnimLogicParams";

		// Token: 0x04017545 RID: 95557
		private static IntPtr _ScriptStructPtr;
	}
}
