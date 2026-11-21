using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02002393 RID: 9107
[NullableContext(1)]
[Nullable(0)]
public class AnimLogicParamsSetter
{
	// Token: 0x0400BEB2 RID: 48818
	public bool AcceptedNewBeHit;

	// Token: 0x0400BEB3 RID: 48819
	public EHitAnim BeHitAnim;

	// Token: 0x0400BEB4 RID: 48820
	public bool EnterFk;

	// Token: 0x0400BEB5 RID: 48821
	public bool DoubleHitInAir;

	// Token: 0x0400BEB6 RID: 48822
	public Vector BeHitDirect = Vector.Create();

	// Token: 0x0400BEB7 RID: 48823
	public Vector BeHitLocation = Vector.Create();

	// Token: 0x0400BEB8 RID: 48824
	public FName BeHitSocketName = FNameUtil.EMPTY;

	// Token: 0x0400BEB9 RID: 48825
	public FName BeHitBone = FNameUtil.EMPTY;

	// Token: 0x0400BEBA RID: 48826
	public ECharMoveState CharMoveState;

	// Token: 0x0400BEBB RID: 48827
	public ECharPositionState CharPositionState;

	// Token: 0x0400BEBC RID: 48828
	public ECharDirectionState CharCameraState = ECharDirectionState.FaceDirection;

	// Token: 0x0400BEBD RID: 48829
	public float BattleIdleTime = --0f;

	// Token: 0x0400BEBE RID: 48830
	public float DegMovementSlope;

	// Token: 0x0400BEBF RID: 48831
	public Vector SightDirect = Vector.Create();

	// Token: 0x0400BEC0 RID: 48832
	public bool RagQuitState;

	// Token: 0x0400BEC1 RID: 48833
	public bool IsJump;

	// Token: 0x0400BEC2 RID: 48834
	public Vector Acceleration = Vector.Create();

	// Token: 0x0400BEC3 RID: 48835
	public bool IsMoving;

	// Token: 0x0400BEC4 RID: 48836
	public bool ForceExitStateStop;

	// Token: 0x0400BEC5 RID: 48837
	public float Speed;

	// Token: 0x0400BEC6 RID: 48838
	public bool EnableAdditiveTurn;

	// Token: 0x0400BEC7 RID: 48839
	public Vector InputDirect = Vector.Create();

	// Token: 0x0400BEC8 RID: 48840
	public bool IsFallingIntoWater;

	// Token: 0x0400BEC9 RID: 48841
	public float GroundedTime = --0f;

	// Token: 0x0400BECA RID: 48842
	public bool HasMoveInput;

	// Token: 0x0400BECB RID: 48843
	public CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbInfo ClimbInfo = new CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbInfo(null, null, null);

	// Token: 0x0400BECC RID: 48844
	public CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState ClimbState = new CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState(null, null, null);

	// Token: 0x0400BECD RID: 48845
	public float ClimbRadius;

	// Token: 0x0400BECE RID: 48846
	public Rotator InputRotator = Rotator.Create();

	// Token: 0x0400BECF RID: 48847
	public float ClimbOnWallAngle;

	// Token: 0x0400BED0 RID: 48848
	public float SprintSwimOffset;

	// Token: 0x0400BED1 RID: 48849
	public float SprintSwimOffsetLerpSpeed;

	// Token: 0x0400BED2 RID: 48850
	public Vector SlideForward = Vector.Create();

	// Token: 0x0400BED3 RID: 48851
	public bool SlideSwitchThisFrame;

	// Token: 0x0400BED4 RID: 48852
	public bool SlideStandMode;

	// Token: 0x0400BED5 RID: 48853
	public float JumpUpRate = --0f;

	// Token: 0x0400BED6 RID: 48854
	public int SkillTarget;

	// Token: 0x0400BED7 RID: 48855
	public int HateTarget;

	// Token: 0x0400BED8 RID: 48856
	public double LastActiveSkillTime;

	// Token: 0x0400BED9 RID: 48857
	public int SitDownDirect = -1;

	// Token: 0x0400BEDA RID: 48858
	public int StandUpDirect = -1;

	// Token: 0x0400BEDB RID: 48859
	public int SitDownType;

	// Token: 0x0400BEDC RID: 48860
	public bool SitDown;

	// Token: 0x0400BEDD RID: 48861
	public bool IsInPerformingPlot;

	// Token: 0x0400BEDE RID: 48862
	public bool IsInSequence;

	// Token: 0x0400BEDF RID: 48863
	public bool IsInSplineMove;

	// Token: 0x0400BEE0 RID: 48864
	public bool IsInUiCamera;

	// Token: 0x0400BEE1 RID: 48865
	public Vector2D LookAt = Vector2D.Create();

	// Token: 0x0400BEE2 RID: 48866
	public bool EnableBlendSpaceLookAt;

	// Token: 0x0400BEE3 RID: 48867
	public SightLockMode CameraMode;

	// Token: 0x0400BEE4 RID: 48868
	public bool IsDriver;

	// Token: 0x0400BEE5 RID: 48869
	public bool IsOnVehicle;

	// Token: 0x0400BEE6 RID: 48870
	public bool IsOnVehicleWithOther;

	// Token: 0x0400BEE7 RID: 48871
	public bool IsLeavingVehicle;

	// Token: 0x0400BEE8 RID: 48872
	public int VehicleType;

	// Token: 0x0400BEE9 RID: 48873
	public bool EnableLowerBlend;

	// Token: 0x0400BEEA RID: 48874
	public bool EnableLeftArmBlend;

	// Token: 0x0400BEEB RID: 48875
	public bool EnableRightArmBlend;

	// Token: 0x0400BEEC RID: 48876
	public bool IsHoldingHands;

	// Token: 0x0400BEED RID: 48877
	public bool IsBeHoldingHands;

	// Token: 0x0400BEEE RID: 48878
	public bool IsHoldingHandsReachable;

	// Token: 0x0400BEEF RID: 48879
	public bool IsAcceptingInvitation;

	// Token: 0x0400BEF0 RID: 48880
	public IkTarget LeftHandIkTarget = new IkTarget(null, null, null);

	// Token: 0x0400BEF1 RID: 48881
	public IkTarget RightHandIkTarget = new IkTarget(null, null, null);

	// Token: 0x0400BEF2 RID: 48882
	public bool IgnoreMontageBlinkCurve;

	// Token: 0x0400BEF3 RID: 48883
	public bool DisableBlink;

	// Token: 0x0400BEF4 RID: 48884
	public bool DisableHumanIk;

	// Token: 0x0400BEF5 RID: 48885
	public bool IsRegionMoveMode;

	// Token: 0x0400BEF6 RID: 48886
	public Vector FloatingLocalDirection = Vector.Create();

	// Token: 0x0400BEF7 RID: 48887
	public float FloatingMoveMix;

	// Token: 0x0400BEF8 RID: 48888
	public Vector HookTargetLocation = Vector.Create();

	// Token: 0x0400BEF9 RID: 48889
	public bool IsVehicleImpact;

	// Token: 0x0400BEFA RID: 48890
	public float VehicleCollisionAngle;

	// Token: 0x0400BEFB RID: 48891
	public float VehicleCollisionStrength;

	// Token: 0x0400BEFC RID: 48892
	public float YawInPassengerCoordinate;

	// Token: 0x0400BEFD RID: 48893
	public Vector VehicleVelocity = Vector.Create();

	// Token: 0x0400BEFE RID: 48894
	public bool IsRailSlideMove;

	// Token: 0x0400BEFF RID: 48895
	public bool IsAirRailSlideMove;

	// Token: 0x0400BF00 RID: 48896
	public ERailSlideJumpType RailSlideJumpType;

	// Token: 0x0400BF01 RID: 48897
	public bool UseLandAnimation;

	// Token: 0x0400BF02 RID: 48898
	public ERailSlideAnimType RailSlideAnimType;
}
