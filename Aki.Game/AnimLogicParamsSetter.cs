using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move;
using UnrealEngine;

// Token: 0x02002E37 RID: 11831
[NullableContext(1)]
[Nullable(0)]
public class AnimLogicParamsSetter
{
	// Token: 0x0400BB24 RID: 47908
	public bool AcceptedNewBeHit;

	// Token: 0x0400BB25 RID: 47909
	public EHitAnim BeHitAnim;

	// Token: 0x0400BB26 RID: 47910
	public bool EnterFk;

	// Token: 0x0400BB27 RID: 47911
	public bool DoubleHitInAir;

	// Token: 0x0400BB28 RID: 47912
	public Vector BeHitDirect = Vector.Create();

	// Token: 0x0400BB29 RID: 47913
	public Vector BeHitLocation = Vector.Create();

	// Token: 0x0400BB2A RID: 47914
	public FName BeHitSocketName = FNameUtil.EMPTY;

	// Token: 0x0400BB2B RID: 47915
	public FName BeHitBone = FNameUtil.EMPTY;

	// Token: 0x0400BB2C RID: 47916
	public ECharMoveState CharMoveState;

	// Token: 0x0400BB2D RID: 47917
	public ECharPositionState CharPositionState;

	// Token: 0x0400BB2E RID: 47918
	public ECharDirectionState CharCameraState = ECharDirectionState.FaceDirection;

	// Token: 0x0400BB2F RID: 47919
	public float BattleIdleTime = --0f;

	// Token: 0x0400BB30 RID: 47920
	public float DegMovementSlope;

	// Token: 0x0400BB31 RID: 47921
	public Vector SightDirect = Vector.Create();

	// Token: 0x0400BB32 RID: 47922
	public bool RagQuitState;

	// Token: 0x0400BB33 RID: 47923
	public bool IsJump;

	// Token: 0x0400BB34 RID: 47924
	public Vector Acceleration = Vector.Create();

	// Token: 0x0400BB35 RID: 47925
	public bool IsMoving;

	// Token: 0x0400BB36 RID: 47926
	public bool ForceExitStateStop;

	// Token: 0x0400BB37 RID: 47927
	public float Speed;

	// Token: 0x0400BB38 RID: 47928
	public bool EnableAdditiveTurn;

	// Token: 0x0400BB39 RID: 47929
	public Vector InputDirect = Vector.Create();

	// Token: 0x0400BB3A RID: 47930
	public bool IsFallingIntoWater;

	// Token: 0x0400BB3B RID: 47931
	public float GroundedTime = --0f;

	// Token: 0x0400BB3C RID: 47932
	public bool HasMoveInput;

	// Token: 0x0400BB3D RID: 47933
	public CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbInfo ClimbInfo = new CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbInfo(null, null, null);

	// Token: 0x0400BB3E RID: 47934
	public CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState ClimbState = new CSharpScript.Game.NewWorld.Character.Common.Component.Move.SClimbState(null, null, null);

	// Token: 0x0400BB3F RID: 47935
	public float ClimbRadius;

	// Token: 0x0400BB40 RID: 47936
	public Rotator InputRotator = Rotator.Create();

	// Token: 0x0400BB41 RID: 47937
	public float ClimbOnWallAngle;

	// Token: 0x0400BB42 RID: 47938
	public float SprintSwimOffset;

	// Token: 0x0400BB43 RID: 47939
	public float SprintSwimOffsetLerpSpeed;

	// Token: 0x0400BB44 RID: 47940
	public Vector SlideForward = Vector.Create();

	// Token: 0x0400BB45 RID: 47941
	public bool SlideSwitchThisFrame;

	// Token: 0x0400BB46 RID: 47942
	public bool SlideStandMode;

	// Token: 0x0400BB47 RID: 47943
	public float JumpUpRate = --0f;

	// Token: 0x0400BB48 RID: 47944
	public int SkillTarget;

	// Token: 0x0400BB49 RID: 47945
	public int HateTarget;

	// Token: 0x0400BB4A RID: 47946
	public double LastActiveSkillTime;

	// Token: 0x0400BB4B RID: 47947
	public int SitDownDirect = -1;

	// Token: 0x0400BB4C RID: 47948
	public int StandUpDirect = -1;

	// Token: 0x0400BB4D RID: 47949
	public int SitDownType;

	// Token: 0x0400BB4E RID: 47950
	public bool SitDown;

	// Token: 0x0400BB4F RID: 47951
	public bool IsInPerformingPlot;

	// Token: 0x0400BB50 RID: 47952
	public bool IsInSequence;

	// Token: 0x0400BB51 RID: 47953
	public bool IsInSplineMove;

	// Token: 0x0400BB52 RID: 47954
	public bool IsInUiCamera;

	// Token: 0x0400BB53 RID: 47955
	public Vector2D LookAt = Vector2D.Create();

	// Token: 0x0400BB54 RID: 47956
	public bool EnableBlendSpaceLookAt;

	// Token: 0x0400BB55 RID: 47957
	public SightLockMode CameraMode;

	// Token: 0x0400BB56 RID: 47958
	public bool IsDriver;

	// Token: 0x0400BB57 RID: 47959
	public bool IsOnVehicle;

	// Token: 0x0400BB58 RID: 47960
	public bool IsOnVehicleWithOther;

	// Token: 0x0400BB59 RID: 47961
	public bool IsLeavingVehicle;

	// Token: 0x0400BB5A RID: 47962
	public int VehicleType;

	// Token: 0x0400BB5B RID: 47963
	public bool EnableLowerBlend;

	// Token: 0x0400BB5C RID: 47964
	public bool EnableLeftArmBlend;

	// Token: 0x0400BB5D RID: 47965
	public bool EnableRightArmBlend;

	// Token: 0x0400BB5E RID: 47966
	public bool IsHoldingHands;

	// Token: 0x0400BB5F RID: 47967
	public bool IsBeHoldingHands;

	// Token: 0x0400BB60 RID: 47968
	public bool IsHoldingHandsReachable;

	// Token: 0x0400BB61 RID: 47969
	public bool IsAcceptingInvitation;

	// Token: 0x0400BB62 RID: 47970
	public IkTarget LeftHandIkTarget = new IkTarget(null, null, null);

	// Token: 0x0400BB63 RID: 47971
	public IkTarget RightHandIkTarget = new IkTarget(null, null, null);

	// Token: 0x0400BB64 RID: 47972
	public bool IgnoreMontageBlinkCurve;

	// Token: 0x0400BB65 RID: 47973
	public bool DisableBlink;

	// Token: 0x0400BB66 RID: 47974
	public bool DisableHumanIk;

	// Token: 0x0400BB67 RID: 47975
	public bool IsRegionMoveMode;

	// Token: 0x0400BB68 RID: 47976
	public Vector FloatingLocalDirection = Vector.Create();

	// Token: 0x0400BB69 RID: 47977
	public float FloatingMoveMix;

	// Token: 0x0400BB6A RID: 47978
	public Vector HookTargetLocation = Vector.Create();

	// Token: 0x0400BB6B RID: 47979
	public bool IsVehicleImpact;

	// Token: 0x0400BB6C RID: 47980
	public float VehicleCollisionAngle;

	// Token: 0x0400BB6D RID: 47981
	public float VehicleCollisionStrength;

	// Token: 0x0400BB6E RID: 47982
	public float YawInPassengerCoordinate;

	// Token: 0x0400BB6F RID: 47983
	public Vector VehicleVelocity = Vector.Create();

	// Token: 0x0400BB70 RID: 47984
	public bool IsRailSlideMove;

	// Token: 0x0400BB71 RID: 47985
	public bool IsAirRailSlideMove;

	// Token: 0x0400BB72 RID: 47986
	public ERailSlideJumpType RailSlideJumpType;

	// Token: 0x0400BB73 RID: 47987
	public bool UseLandAnimation;

	// Token: 0x0400BB74 RID: 47988
	public ERailSlideAnimType RailSlideAnimType;
}
