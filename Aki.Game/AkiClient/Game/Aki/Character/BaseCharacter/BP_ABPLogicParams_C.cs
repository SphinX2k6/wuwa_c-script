using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032DF RID: 13023
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C")]
	[UnrealStructLayout(368, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 361)]
	public class BP_ABPLogicParams_C : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060210B0 RID: 135344 RVA: 0x00957BA3 File Offset: 0x00955DA3
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_ABPLogicParams_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C");
			}
			return BP_ABPLogicParams_C._ClassPtr;
		}

		// Token: 0x060210B1 RID: 135345 RVA: 0x00957BC8 File Offset: 0x00955DC8
		public BP_ABPLogicParams_C() : this(BuiltinUtils.AllocNativeUObject(BP_ABPLogicParams_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060210B2 RID: 135346 RVA: 0x00957BF0 File Offset: 0x00955DF0
		[NullableContext(1)]
		public BP_ABPLogicParams_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_ABPLogicParams_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004234 RID: 16948
		// (get) Token: 0x060210B3 RID: 135347 RVA: 0x00957C23 File Offset: 0x00955E23
		// (set) Token: 0x060210B4 RID: 135348 RVA: 0x00957C33 File Offset: 0x00955E33
		public unsafe bool AcceptedNewBeHitRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_AcceptedNewBeHitRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_AcceptedNewBeHitRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004235 RID: 16949
		// (get) Token: 0x060210B5 RID: 135349 RVA: 0x00957C44 File Offset: 0x00955E44
		// (set) Token: 0x060210B6 RID: 135350 RVA: 0x00957C58 File Offset: 0x00955E58
		public unsafe TEnumAsByte<EHitAnim> BeHitAnimRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitAnimRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitAnimRef) = value;
			}
		}

		// Token: 0x17004236 RID: 16950
		// (get) Token: 0x060210B7 RID: 135351 RVA: 0x00957C6D File Offset: 0x00955E6D
		// (set) Token: 0x060210B8 RID: 135352 RVA: 0x00957C7D File Offset: 0x00955E7D
		public unsafe bool EnterFkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnterFkRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnterFkRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004237 RID: 16951
		// (get) Token: 0x060210B9 RID: 135353 RVA: 0x00957C8E File Offset: 0x00955E8E
		// (set) Token: 0x060210BA RID: 135354 RVA: 0x00957C9E File Offset: 0x00955E9E
		public unsafe bool DoubleHitInAirRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DoubleHitInAirRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DoubleHitInAirRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x060210BB RID: 135355 RVA: 0x00957CAF File Offset: 0x00955EAF
		// (set) Token: 0x060210BC RID: 135356 RVA: 0x00957CC3 File Offset: 0x00955EC3
		public unsafe FVector BeHitDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitDirectRef) = value;
			}
		}

		// Token: 0x17004239 RID: 16953
		// (get) Token: 0x060210BD RID: 135357 RVA: 0x00957CD8 File Offset: 0x00955ED8
		// (set) Token: 0x060210BE RID: 135358 RVA: 0x00957CEC File Offset: 0x00955EEC
		public unsafe FVector BeHitLocationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitLocationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BeHitLocationRef) = value;
			}
		}

		// Token: 0x1700423A RID: 16954
		// (get) Token: 0x060210BF RID: 135359 RVA: 0x00957D01 File Offset: 0x00955F01
		// (set) Token: 0x060210C0 RID: 135360 RVA: 0x00957D15 File Offset: 0x00955F15
		public unsafe TEnumAsByte<ECharState> CharMoveStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharMoveStateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharMoveStateRef) = value;
			}
		}

		// Token: 0x1700423B RID: 16955
		// (get) Token: 0x060210C1 RID: 135361 RVA: 0x00957D2A File Offset: 0x00955F2A
		// (set) Token: 0x060210C2 RID: 135362 RVA: 0x00957D3E File Offset: 0x00955F3E
		public unsafe TEnumAsByte<ECharParentMoveState> CharPositionStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharPositionStateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharPositionStateRef) = value;
			}
		}

		// Token: 0x1700423C RID: 16956
		// (get) Token: 0x060210C3 RID: 135363 RVA: 0x00957D53 File Offset: 0x00955F53
		// (set) Token: 0x060210C4 RID: 135364 RVA: 0x00957D67 File Offset: 0x00955F67
		public unsafe TEnumAsByte<ECharViewDirectionState> CharCameraStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharCameraStateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_CharCameraStateRef) = value;
			}
		}

		// Token: 0x1700423D RID: 16957
		// (get) Token: 0x060210C5 RID: 135365 RVA: 0x00957D7C File Offset: 0x00955F7C
		// (set) Token: 0x060210C6 RID: 135366 RVA: 0x00957D8C File Offset: 0x00955F8C
		public unsafe float BattleIdleTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BattleIdleTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_BattleIdleTimeRef) = value;
			}
		}

		// Token: 0x1700423E RID: 16958
		// (get) Token: 0x060210C7 RID: 135367 RVA: 0x00957D9D File Offset: 0x00955F9D
		// (set) Token: 0x060210C8 RID: 135368 RVA: 0x00957DAD File Offset: 0x00955FAD
		public unsafe float DegMovementSlopeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DegMovementSlopeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DegMovementSlopeRef) = value;
			}
		}

		// Token: 0x1700423F RID: 16959
		// (get) Token: 0x060210C9 RID: 135369 RVA: 0x00957DBE File Offset: 0x00955FBE
		// (set) Token: 0x060210CA RID: 135370 RVA: 0x00957DD2 File Offset: 0x00955FD2
		public unsafe FVector SightDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SightDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SightDirectRef) = value;
			}
		}

		// Token: 0x17004240 RID: 16960
		// (get) Token: 0x060210CB RID: 135371 RVA: 0x00957DE7 File Offset: 0x00955FE7
		// (set) Token: 0x060210CC RID: 135372 RVA: 0x00957DF7 File Offset: 0x00955FF7
		public unsafe bool RagQuitStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_RagQuitStateRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_RagQuitStateRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004241 RID: 16961
		// (get) Token: 0x060210CD RID: 135373 RVA: 0x00957E08 File Offset: 0x00956008
		// (set) Token: 0x060210CE RID: 135374 RVA: 0x00957E18 File Offset: 0x00956018
		public unsafe bool IsJumpRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsJumpRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsJumpRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004242 RID: 16962
		// (get) Token: 0x060210CF RID: 135375 RVA: 0x00957E29 File Offset: 0x00956029
		// (set) Token: 0x060210D0 RID: 135376 RVA: 0x00957E3D File Offset: 0x0095603D
		public unsafe FVector AccelerationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_AccelerationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_AccelerationRef) = value;
			}
		}

		// Token: 0x17004243 RID: 16963
		// (get) Token: 0x060210D1 RID: 135377 RVA: 0x00957E52 File Offset: 0x00956052
		// (set) Token: 0x060210D2 RID: 135378 RVA: 0x00957E62 File Offset: 0x00956062
		public unsafe bool IsMovingRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsMovingRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsMovingRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004244 RID: 16964
		// (get) Token: 0x060210D3 RID: 135379 RVA: 0x00957E73 File Offset: 0x00956073
		// (set) Token: 0x060210D4 RID: 135380 RVA: 0x00957E83 File Offset: 0x00956083
		public unsafe float SpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SpeedRef) = value;
			}
		}

		// Token: 0x17004245 RID: 16965
		// (get) Token: 0x060210D5 RID: 135381 RVA: 0x00957E94 File Offset: 0x00956094
		// (set) Token: 0x060210D6 RID: 135382 RVA: 0x00957EA8 File Offset: 0x009560A8
		public unsafe FVector InputDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_InputDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_InputDirectRef) = value;
			}
		}

		// Token: 0x17004246 RID: 16966
		// (get) Token: 0x060210D7 RID: 135383 RVA: 0x00957EBD File Offset: 0x009560BD
		// (set) Token: 0x060210D8 RID: 135384 RVA: 0x00957ECD File Offset: 0x009560CD
		public unsafe bool IsFallingIntoWaterRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsFallingIntoWaterRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsFallingIntoWaterRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004247 RID: 16967
		// (get) Token: 0x060210D9 RID: 135385 RVA: 0x00957EDE File Offset: 0x009560DE
		// (set) Token: 0x060210DA RID: 135386 RVA: 0x00957EEE File Offset: 0x009560EE
		public unsafe float GroundedTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_GroundedTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_GroundedTimeRef) = value;
			}
		}

		// Token: 0x17004248 RID: 16968
		// (get) Token: 0x060210DB RID: 135387 RVA: 0x00957EFF File Offset: 0x009560FF
		// (set) Token: 0x060210DC RID: 135388 RVA: 0x00957F0F File Offset: 0x0095610F
		public unsafe bool HasMoveInputRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_HasMoveInputRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_HasMoveInputRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004249 RID: 16969
		// (get) Token: 0x060210DD RID: 135389 RVA: 0x00957F20 File Offset: 0x00956120
		// (set) Token: 0x060210DE RID: 135390 RVA: 0x00957F34 File Offset: 0x00956134
		public unsafe SClimbInfo ClimbInfoRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbInfoRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbInfoRef) = value;
			}
		}

		// Token: 0x1700424A RID: 16970
		// (get) Token: 0x060210DF RID: 135391 RVA: 0x00957F49 File Offset: 0x00956149
		// (set) Token: 0x060210E0 RID: 135392 RVA: 0x00957F5D File Offset: 0x0095615D
		public unsafe SClimbState ClimbStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbStateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbStateRef) = value;
			}
		}

		// Token: 0x1700424B RID: 16971
		// (get) Token: 0x060210E1 RID: 135393 RVA: 0x00957F72 File Offset: 0x00956172
		// (set) Token: 0x060210E2 RID: 135394 RVA: 0x00957F82 File Offset: 0x00956182
		public unsafe float ClimbRadiusRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbRadiusRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbRadiusRef) = value;
			}
		}

		// Token: 0x1700424C RID: 16972
		// (get) Token: 0x060210E3 RID: 135395 RVA: 0x00957F93 File Offset: 0x00956193
		// (set) Token: 0x060210E4 RID: 135396 RVA: 0x00957FA7 File Offset: 0x009561A7
		public unsafe FRotator InputRotatorRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_InputRotatorRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_InputRotatorRef) = value;
			}
		}

		// Token: 0x1700424D RID: 16973
		// (get) Token: 0x060210E5 RID: 135397 RVA: 0x00957FBC File Offset: 0x009561BC
		// (set) Token: 0x060210E6 RID: 135398 RVA: 0x00957FCC File Offset: 0x009561CC
		public unsafe float ClimbOnWallAngleRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbOnWallAngleRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_ClimbOnWallAngleRef) = value;
			}
		}

		// Token: 0x1700424E RID: 16974
		// (get) Token: 0x060210E7 RID: 135399 RVA: 0x00957FDD File Offset: 0x009561DD
		// (set) Token: 0x060210E8 RID: 135400 RVA: 0x00957FED File Offset: 0x009561ED
		public unsafe float SprintSwimOffsetRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SprintSwimOffsetRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SprintSwimOffsetRef) = value;
			}
		}

		// Token: 0x1700424F RID: 16975
		// (get) Token: 0x060210E9 RID: 135401 RVA: 0x00957FFE File Offset: 0x009561FE
		// (set) Token: 0x060210EA RID: 135402 RVA: 0x0095800E File Offset: 0x0095620E
		public unsafe float SprintSwimOffsetLerpSpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SprintSwimOffsetLerpSpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SprintSwimOffsetLerpSpeedRef) = value;
			}
		}

		// Token: 0x17004250 RID: 16976
		// (get) Token: 0x060210EB RID: 135403 RVA: 0x0095801F File Offset: 0x0095621F
		// (set) Token: 0x060210EC RID: 135404 RVA: 0x00958033 File Offset: 0x00956233
		public unsafe FVector SlideForwardRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideForwardRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideForwardRef) = value;
			}
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x060210ED RID: 135405 RVA: 0x00958048 File Offset: 0x00956248
		// (set) Token: 0x060210EE RID: 135406 RVA: 0x00958058 File Offset: 0x00956258
		public unsafe bool SlideSwitchThisFrameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideSwitchThisFrameRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideSwitchThisFrameRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x060210EF RID: 135407 RVA: 0x00958069 File Offset: 0x00956269
		// (set) Token: 0x060210F0 RID: 135408 RVA: 0x00958079 File Offset: 0x00956279
		public unsafe bool SlideStandModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideStandModeRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_SlideStandModeRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x060210F1 RID: 135409 RVA: 0x0095808A File Offset: 0x0095628A
		// (set) Token: 0x060210F2 RID: 135410 RVA: 0x0095809A File Offset: 0x0095629A
		public unsafe float JumpUpRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_JumpUpRateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_JumpUpRateRef) = value;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x060210F3 RID: 135411 RVA: 0x009580AB File Offset: 0x009562AB
		// (set) Token: 0x060210F4 RID: 135412 RVA: 0x009580BF File Offset: 0x009562BF
		public unsafe FVector2D LookAtRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_LookAtRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_LookAtRef) = value;
			}
		}

		// Token: 0x17004255 RID: 16981
		// (get) Token: 0x060210F5 RID: 135413 RVA: 0x009580D4 File Offset: 0x009562D4
		// (set) Token: 0x060210F6 RID: 135414 RVA: 0x009580E4 File Offset: 0x009562E4
		public unsafe bool EnableBlendSpaceLookAtRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnableBlendSpaceLookAtRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnableBlendSpaceLookAtRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004256 RID: 16982
		// (get) Token: 0x060210F7 RID: 135415 RVA: 0x009580F5 File Offset: 0x009562F5
		// (set) Token: 0x060210F8 RID: 135416 RVA: 0x00958105 File Offset: 0x00956305
		public unsafe bool IsDriver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsDriver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsDriver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004257 RID: 16983
		// (get) Token: 0x060210F9 RID: 135417 RVA: 0x00958116 File Offset: 0x00956316
		// (set) Token: 0x060210FA RID: 135418 RVA: 0x00958126 File Offset: 0x00956326
		public unsafe bool IsOnVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsOnVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsOnVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004258 RID: 16984
		// (get) Token: 0x060210FB RID: 135419 RVA: 0x00958138 File Offset: 0x00956338
		// (set) Token: 0x060210FC RID: 135420 RVA: 0x00958171 File Offset: 0x00956371
		[Nullable(1)]
		public FIKTarget LeftHandIKTargetCS
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._LeftHandIKTargetCS) == null)
				{
					result = (this._LeftHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_LeftHandIKTargetCS, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_LeftHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004259 RID: 16985
		// (get) Token: 0x060210FD RID: 135421 RVA: 0x00958194 File Offset: 0x00956394
		// (set) Token: 0x060210FE RID: 135422 RVA: 0x009581CD File Offset: 0x009563CD
		[Nullable(1)]
		public FIKTarget RightHandIKTargetCS
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._RightHandIKTargetCS) == null)
				{
					result = (this._RightHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_RightHandIKTargetCS, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_RightHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700425A RID: 16986
		// (get) Token: 0x060210FF RID: 135423 RVA: 0x009581EE File Offset: 0x009563EE
		// (set) Token: 0x06021100 RID: 135424 RVA: 0x009581FE File Offset: 0x009563FE
		public unsafe bool StateLowerBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateLowerBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateLowerBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700425B RID: 16987
		// (get) Token: 0x06021101 RID: 135425 RVA: 0x0095820F File Offset: 0x0095640F
		// (set) Token: 0x06021102 RID: 135426 RVA: 0x0095821F File Offset: 0x0095641F
		public unsafe bool StateLeftArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateLeftArmBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateLeftArmBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700425C RID: 16988
		// (get) Token: 0x06021103 RID: 135427 RVA: 0x00958230 File Offset: 0x00956430
		// (set) Token: 0x06021104 RID: 135428 RVA: 0x00958240 File Offset: 0x00956440
		public unsafe bool StateRightArmBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateRightArmBlend) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_StateRightArmBlend) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700425D RID: 16989
		// (get) Token: 0x06021105 RID: 135429 RVA: 0x00958251 File Offset: 0x00956451
		// (set) Token: 0x06021106 RID: 135430 RVA: 0x00958261 File Offset: 0x00956461
		public unsafe bool IsHoldingHands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsHoldingHands) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsHoldingHands) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700425E RID: 16990
		// (get) Token: 0x06021107 RID: 135431 RVA: 0x00958272 File Offset: 0x00956472
		// (set) Token: 0x06021108 RID: 135432 RVA: 0x00958282 File Offset: 0x00956482
		public unsafe bool IsBeHoldingHands
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsBeHoldingHands) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsBeHoldingHands) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700425F RID: 16991
		// (get) Token: 0x06021109 RID: 135433 RVA: 0x00958293 File Offset: 0x00956493
		// (set) Token: 0x0602110A RID: 135434 RVA: 0x009582A3 File Offset: 0x009564A3
		public unsafe bool IsHoldingHandsReachable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsHoldingHandsReachable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsHoldingHandsReachable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004260 RID: 16992
		// (get) Token: 0x0602110B RID: 135435 RVA: 0x009582B4 File Offset: 0x009564B4
		// (set) Token: 0x0602110C RID: 135436 RVA: 0x009582C4 File Offset: 0x009564C4
		public unsafe bool IsAcceptingInvitation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsAcceptingInvitation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsAcceptingInvitation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004261 RID: 16993
		// (get) Token: 0x0602110D RID: 135437 RVA: 0x009582D5 File Offset: 0x009564D5
		// (set) Token: 0x0602110E RID: 135438 RVA: 0x009582E5 File Offset: 0x009564E5
		public unsafe bool DisableBlinkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DisableBlinkRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DisableBlinkRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004262 RID: 16994
		// (get) Token: 0x0602110F RID: 135439 RVA: 0x009582F6 File Offset: 0x009564F6
		// (set) Token: 0x06021110 RID: 135440 RVA: 0x00958306 File Offset: 0x00956506
		public unsafe bool IsOnVehicleWithOther
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsOnVehicleWithOther) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsOnVehicleWithOther) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004263 RID: 16995
		// (get) Token: 0x06021111 RID: 135441 RVA: 0x00958317 File Offset: 0x00956517
		// (set) Token: 0x06021112 RID: 135442 RVA: 0x00958327 File Offset: 0x00956527
		public unsafe int VehicleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_VehicleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_VehicleType) = value;
			}
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x06021113 RID: 135443 RVA: 0x00958338 File Offset: 0x00956538
		// (set) Token: 0x06021114 RID: 135444 RVA: 0x00958348 File Offset: 0x00956548
		public unsafe bool IgnoreMontageBlinkCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IgnoreMontageBlinkCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IgnoreMontageBlinkCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004265 RID: 16997
		// (get) Token: 0x06021115 RID: 135445 RVA: 0x00958359 File Offset: 0x00956559
		// (set) Token: 0x06021116 RID: 135446 RVA: 0x00958369 File Offset: 0x00956569
		public unsafe bool IsRegionMoveModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsRegionMoveModeRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_IsRegionMoveModeRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x06021117 RID: 135447 RVA: 0x0095837A File Offset: 0x0095657A
		// (set) Token: 0x06021118 RID: 135448 RVA: 0x0095838A File Offset: 0x0095658A
		public unsafe bool DisableHumanIkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DisableHumanIkRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_DisableHumanIkRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x06021119 RID: 135449 RVA: 0x0095839B File Offset: 0x0095659B
		// (set) Token: 0x0602111A RID: 135450 RVA: 0x009583AB File Offset: 0x009565AB
		public unsafe float TurnYawRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_TurnYawRateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_TurnYawRateRef) = value;
			}
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x0602111B RID: 135451 RVA: 0x009583BC File Offset: 0x009565BC
		// (set) Token: 0x0602111C RID: 135452 RVA: 0x009583CC File Offset: 0x009565CC
		public unsafe bool EnableAdditiveTurnRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnableAdditiveTurnRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_ABPLogicParams_C.__PropertyOffset_EnableAdditiveTurnRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602111D RID: 135453 RVA: 0x009583DD File Offset: 0x009565DD
		protected BP_ABPLogicParams_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011ED4 RID: 73428
		[Nullable(1)]
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_ABPLogicParams.BP_ABPLogicParams_C";

		// Token: 0x04011ED5 RID: 73429
		private static IntPtr _ClassPtr;

		// Token: 0x04011ED6 RID: 73430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011ED7 RID: 73431
		internal static int __PropertyOffset_AcceptedNewBeHitRef;

		// Token: 0x04011ED8 RID: 73432
		internal static int __PropertyOffset_BeHitAnimRef;

		// Token: 0x04011ED9 RID: 73433
		internal static int __PropertyOffset_EnterFkRef;

		// Token: 0x04011EDA RID: 73434
		internal static int __PropertyOffset_DoubleHitInAirRef;

		// Token: 0x04011EDB RID: 73435
		internal static int __PropertyOffset_BeHitDirectRef;

		// Token: 0x04011EDC RID: 73436
		internal static int __PropertyOffset_BeHitLocationRef;

		// Token: 0x04011EDD RID: 73437
		internal static int __PropertyOffset_CharMoveStateRef;

		// Token: 0x04011EDE RID: 73438
		internal static int __PropertyOffset_CharPositionStateRef;

		// Token: 0x04011EDF RID: 73439
		internal static int __PropertyOffset_CharCameraStateRef;

		// Token: 0x04011EE0 RID: 73440
		internal static int __PropertyOffset_BattleIdleTimeRef;

		// Token: 0x04011EE1 RID: 73441
		internal static int __PropertyOffset_DegMovementSlopeRef;

		// Token: 0x04011EE2 RID: 73442
		internal static int __PropertyOffset_SightDirectRef;

		// Token: 0x04011EE3 RID: 73443
		internal static int __PropertyOffset_RagQuitStateRef;

		// Token: 0x04011EE4 RID: 73444
		internal static int __PropertyOffset_IsJumpRef;

		// Token: 0x04011EE5 RID: 73445
		internal static int __PropertyOffset_AccelerationRef;

		// Token: 0x04011EE6 RID: 73446
		internal static int __PropertyOffset_IsMovingRef;

		// Token: 0x04011EE7 RID: 73447
		internal static int __PropertyOffset_SpeedRef;

		// Token: 0x04011EE8 RID: 73448
		internal static int __PropertyOffset_InputDirectRef;

		// Token: 0x04011EE9 RID: 73449
		internal static int __PropertyOffset_IsFallingIntoWaterRef;

		// Token: 0x04011EEA RID: 73450
		internal static int __PropertyOffset_GroundedTimeRef;

		// Token: 0x04011EEB RID: 73451
		internal static int __PropertyOffset_HasMoveInputRef;

		// Token: 0x04011EEC RID: 73452
		internal static int __PropertyOffset_ClimbInfoRef;

		// Token: 0x04011EED RID: 73453
		internal static int __PropertyOffset_ClimbStateRef;

		// Token: 0x04011EEE RID: 73454
		internal static int __PropertyOffset_ClimbRadiusRef;

		// Token: 0x04011EEF RID: 73455
		internal static int __PropertyOffset_InputRotatorRef;

		// Token: 0x04011EF0 RID: 73456
		internal static int __PropertyOffset_ClimbOnWallAngleRef;

		// Token: 0x04011EF1 RID: 73457
		internal static int __PropertyOffset_SprintSwimOffsetRef;

		// Token: 0x04011EF2 RID: 73458
		internal static int __PropertyOffset_SprintSwimOffsetLerpSpeedRef;

		// Token: 0x04011EF3 RID: 73459
		internal static int __PropertyOffset_SlideForwardRef;

		// Token: 0x04011EF4 RID: 73460
		internal static int __PropertyOffset_SlideSwitchThisFrameRef;

		// Token: 0x04011EF5 RID: 73461
		internal static int __PropertyOffset_SlideStandModeRef;

		// Token: 0x04011EF6 RID: 73462
		internal static int __PropertyOffset_JumpUpRateRef;

		// Token: 0x04011EF7 RID: 73463
		internal static int __PropertyOffset_LookAtRef;

		// Token: 0x04011EF8 RID: 73464
		internal static int __PropertyOffset_EnableBlendSpaceLookAtRef;

		// Token: 0x04011EF9 RID: 73465
		internal static int __PropertyOffset_IsDriver;

		// Token: 0x04011EFA RID: 73466
		internal static int __PropertyOffset_IsOnVehicle;

		// Token: 0x04011EFB RID: 73467
		internal static int __PropertyOffset_LeftHandIKTargetCS;

		// Token: 0x04011EFC RID: 73468
		[Nullable(2)]
		private FIKTarget _LeftHandIKTargetCS;

		// Token: 0x04011EFD RID: 73469
		internal static int __PropertyOffset_RightHandIKTargetCS;

		// Token: 0x04011EFE RID: 73470
		[Nullable(2)]
		private FIKTarget _RightHandIKTargetCS;

		// Token: 0x04011EFF RID: 73471
		internal static int __PropertyOffset_StateLowerBlend;

		// Token: 0x04011F00 RID: 73472
		internal static int __PropertyOffset_StateLeftArmBlend;

		// Token: 0x04011F01 RID: 73473
		internal static int __PropertyOffset_StateRightArmBlend;

		// Token: 0x04011F02 RID: 73474
		internal static int __PropertyOffset_IsHoldingHands;

		// Token: 0x04011F03 RID: 73475
		internal static int __PropertyOffset_IsBeHoldingHands;

		// Token: 0x04011F04 RID: 73476
		internal static int __PropertyOffset_IsHoldingHandsReachable;

		// Token: 0x04011F05 RID: 73477
		internal static int __PropertyOffset_IsAcceptingInvitation;

		// Token: 0x04011F06 RID: 73478
		internal static int __PropertyOffset_DisableBlinkRef;

		// Token: 0x04011F07 RID: 73479
		internal static int __PropertyOffset_IsOnVehicleWithOther;

		// Token: 0x04011F08 RID: 73480
		internal static int __PropertyOffset_VehicleType;

		// Token: 0x04011F09 RID: 73481
		internal static int __PropertyOffset_IgnoreMontageBlinkCurve;

		// Token: 0x04011F0A RID: 73482
		internal static int __PropertyOffset_IsRegionMoveModeRef;

		// Token: 0x04011F0B RID: 73483
		internal static int __PropertyOffset_DisableHumanIkRef;

		// Token: 0x04011F0C RID: 73484
		internal static int __PropertyOffset_TurnYawRateRef;

		// Token: 0x04011F0D RID: 73485
		internal static int __PropertyOffset_EnableAdditiveTurnRef;
	}
}
