using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020032E2 RID: 13026
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C")]
	[UnrealStructLayout(904, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 904)]
	public class BP_FloatingMovementConfig_C : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602113A RID: 135482 RVA: 0x0095884F File Offset: 0x00956A4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			if (BP_FloatingMovementConfig_C._ClassPtr == IntPtr.Zero)
			{
				UObjectGlobals.StaticLoadClass(null, "/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C");
			}
			return BP_FloatingMovementConfig_C._ClassPtr;
		}

		// Token: 0x0602113B RID: 135483 RVA: 0x00958874 File Offset: 0x00956A74
		public BP_FloatingMovementConfig_C() : this(BuiltinUtils.AllocNativeUObject(BP_FloatingMovementConfig_C.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602113C RID: 135484 RVA: 0x0095889C File Offset: 0x00956A9C
		public BP_FloatingMovementConfig_C(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(BP_FloatingMovementConfig_C.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x0602113D RID: 135485 RVA: 0x009588CF File Offset: 0x00956ACF
		// (set) Token: 0x0602113E RID: 135486 RVA: 0x009588DF File Offset: 0x00956ADF
		public unsafe int MoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_MoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_MoveSpeed) = value;
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x0602113F RID: 135487 RVA: 0x009588F0 File Offset: 0x00956AF0
		// (set) Token: 0x06021140 RID: 135488 RVA: 0x00958900 File Offset: 0x00956B00
		public unsafe int SprintSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SprintSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SprintSpeed) = value;
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x06021141 RID: 135489 RVA: 0x00958911 File Offset: 0x00956B11
		// (set) Token: 0x06021142 RID: 135490 RVA: 0x00958921 File Offset: 0x00956B21
		public unsafe int TurnSpeedDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_TurnSpeedDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_TurnSpeedDeg) = value;
			}
		}

		// Token: 0x17004272 RID: 17010
		// (get) Token: 0x06021143 RID: 135491 RVA: 0x00958932 File Offset: 0x00956B32
		// (set) Token: 0x06021144 RID: 135492 RVA: 0x00958942 File Offset: 0x00956B42
		public unsafe int AirEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AirEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AirEnergyConsumption) = value;
			}
		}

		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x06021145 RID: 135493 RVA: 0x00958953 File Offset: 0x00956B53
		// (set) Token: 0x06021146 RID: 135494 RVA: 0x00958963 File Offset: 0x00956B63
		public unsafe int RiseEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseEnergyConsumption) = value;
			}
		}

		// Token: 0x17004274 RID: 17012
		// (get) Token: 0x06021147 RID: 135495 RVA: 0x00958974 File Offset: 0x00956B74
		// (set) Token: 0x06021148 RID: 135496 RVA: 0x00958984 File Offset: 0x00956B84
		public unsafe int DropEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropEnergyConsumption) = value;
			}
		}

		// Token: 0x17004275 RID: 17013
		// (get) Token: 0x06021149 RID: 135497 RVA: 0x00958995 File Offset: 0x00956B95
		// (set) Token: 0x0602114A RID: 135498 RVA: 0x009589A5 File Offset: 0x00956BA5
		public unsafe int DodgeEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DodgeEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DodgeEnergyConsumption) = value;
			}
		}

		// Token: 0x17004276 RID: 17014
		// (get) Token: 0x0602114B RID: 135499 RVA: 0x009589B6 File Offset: 0x00956BB6
		// (set) Token: 0x0602114C RID: 135500 RVA: 0x009589C6 File Offset: 0x00956BC6
		public unsafe int MoveEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_MoveEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_MoveEnergyConsumption) = value;
			}
		}

		// Token: 0x17004277 RID: 17015
		// (get) Token: 0x0602114D RID: 135501 RVA: 0x009589D7 File Offset: 0x00956BD7
		// (set) Token: 0x0602114E RID: 135502 RVA: 0x009589E7 File Offset: 0x00956BE7
		public unsafe int FastMoveEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_FastMoveEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_FastMoveEnergyConsumption) = value;
			}
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x0602114F RID: 135503 RVA: 0x009589F8 File Offset: 0x00956BF8
		// (set) Token: 0x06021150 RID: 135504 RVA: 0x00958A08 File Offset: 0x00956C08
		public unsafe int SprintEnergyConsumption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SprintEnergyConsumption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SprintEnergyConsumption) = value;
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x06021151 RID: 135505 RVA: 0x00958A19 File Offset: 0x00956C19
		// (set) Token: 0x06021152 RID: 135506 RVA: 0x00958A29 File Offset: 0x00956C29
		public unsafe int EnergyRecoverSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_EnergyRecoverSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_EnergyRecoverSpeed) = value;
			}
		}

		// Token: 0x1700427A RID: 17018
		// (get) Token: 0x06021153 RID: 135507 RVA: 0x00958A3A File Offset: 0x00956C3A
		// (set) Token: 0x06021154 RID: 135508 RVA: 0x00958A4A File Offset: 0x00956C4A
		public unsafe int EnergyRecoverCoolDownTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_EnergyRecoverCoolDownTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_EnergyRecoverCoolDownTime) = value;
			}
		}

		// Token: 0x1700427B RID: 17019
		// (get) Token: 0x06021155 RID: 135509 RVA: 0x00958A5B File Offset: 0x00956C5B
		// (set) Token: 0x06021156 RID: 135510 RVA: 0x00958A6B File Offset: 0x00956C6B
		public unsafe int AirCriticalHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AirCriticalHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AirCriticalHeight) = value;
			}
		}

		// Token: 0x1700427C RID: 17020
		// (get) Token: 0x06021157 RID: 135511 RVA: 0x00958A7C File Offset: 0x00956C7C
		// (set) Token: 0x06021158 RID: 135512 RVA: 0x00958A8C File Offset: 0x00956C8C
		public unsafe int CloseToGroundHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_CloseToGroundHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_CloseToGroundHeight) = value;
			}
		}

		// Token: 0x1700427D RID: 17021
		// (get) Token: 0x06021159 RID: 135513 RVA: 0x00958A9D File Offset: 0x00956C9D
		// (set) Token: 0x0602115A RID: 135514 RVA: 0x00958AAD File Offset: 0x00956CAD
		public unsafe int RiseSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseSpeed) = value;
			}
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0602115B RID: 135515 RVA: 0x00958ABE File Offset: 0x00956CBE
		// (set) Token: 0x0602115C RID: 135516 RVA: 0x00958ACE File Offset: 0x00956CCE
		public unsafe int DropSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropSpeed) = value;
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0602115D RID: 135517 RVA: 0x00958ADF File Offset: 0x00956CDF
		// (set) Token: 0x0602115E RID: 135518 RVA: 0x00958AEF File Offset: 0x00956CEF
		public unsafe float AnimLerpAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AnimLerpAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_AnimLerpAlpha) = value;
			}
		}

		// Token: 0x17004280 RID: 17024
		// (get) Token: 0x0602115F RID: 135519 RVA: 0x00958B00 File Offset: 0x00956D00
		// (set) Token: 0x06021160 RID: 135520 RVA: 0x00958B10 File Offset: 0x00956D10
		public unsafe float SpeedAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SpeedAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_SpeedAcceleration) = value;
			}
		}

		// Token: 0x17004281 RID: 17025
		// (get) Token: 0x06021161 RID: 135521 RVA: 0x00958B21 File Offset: 0x00956D21
		// (set) Token: 0x06021162 RID: 135522 RVA: 0x00958B31 File Offset: 0x00956D31
		public unsafe float DirectionLerpAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DirectionLerpAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DirectionLerpAlpha) = value;
			}
		}

		// Token: 0x17004282 RID: 17026
		// (get) Token: 0x06021163 RID: 135523 RVA: 0x00958B44 File Offset: 0x00956D44
		// (set) Token: 0x06021164 RID: 135524 RVA: 0x00958B7D File Offset: 0x00956D7D
		public FGameplayTagContainer ForbidRotationTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidRotationTagList) == null)
				{
					result = (this._ForbidRotationTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_ForbidRotationTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_ForbidRotationTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004283 RID: 17027
		// (get) Token: 0x06021165 RID: 135525 RVA: 0x00958BA0 File Offset: 0x00956DA0
		// (set) Token: 0x06021166 RID: 135526 RVA: 0x00958BD9 File Offset: 0x00956DD9
		public SFloatingMovementState DefaultMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._DefaultMode) == null)
				{
					result = (this._DefaultMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DefaultMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DefaultMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004284 RID: 17028
		// (get) Token: 0x06021167 RID: 135527 RVA: 0x00958BFC File Offset: 0x00956DFC
		// (set) Token: 0x06021168 RID: 135528 RVA: 0x00958C35 File Offset: 0x00956E35
		public SFloatingMovementState FloatingMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._FloatingMode) == null)
				{
					result = (this._FloatingMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_FloatingMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_FloatingMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004285 RID: 17029
		// (get) Token: 0x06021169 RID: 135529 RVA: 0x00958C58 File Offset: 0x00956E58
		// (set) Token: 0x0602116A RID: 135530 RVA: 0x00958C91 File Offset: 0x00956E91
		public SFloatingMovementState RiseMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._RiseMode) == null)
				{
					result = (this._RiseMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_RiseMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004286 RID: 17030
		// (get) Token: 0x0602116B RID: 135531 RVA: 0x00958CB4 File Offset: 0x00956EB4
		// (set) Token: 0x0602116C RID: 135532 RVA: 0x00958CED File Offset: 0x00956EED
		public SFloatingMovementState DropMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._DropMode) == null)
				{
					result = (this._DropMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_DropMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004287 RID: 17031
		// (get) Token: 0x0602116D RID: 135533 RVA: 0x00958D10 File Offset: 0x00956F10
		// (set) Token: 0x0602116E RID: 135534 RVA: 0x00958D49 File Offset: 0x00956F49
		public SFloatingMovementState WalkMode
		{
			get
			{
				base.FastCheckIsValid();
				SFloatingMovementState result;
				if ((result = this._WalkMode) == null)
				{
					result = (this._WalkMode = new SFloatingMovementState(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_WalkMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SFloatingMovementState.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_WalkMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004288 RID: 17032
		// (get) Token: 0x0602116F RID: 135535 RVA: 0x00958D6C File Offset: 0x00956F6C
		// (set) Token: 0x06021170 RID: 135536 RVA: 0x00958DA5 File Offset: 0x00956FA5
		public FGameplayTagContainer ForbidCloseToGrounTagList
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._ForbidCloseToGrounTagList) == null)
				{
					result = (this._ForbidCloseToGrounTagList = new FGameplayTagContainer(base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_ForbidCloseToGrounTagList, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)BP_FloatingMovementConfig_C.__PropertyOffset_ForbidCloseToGrounTagList, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06021171 RID: 135537 RVA: 0x00958DC6 File Offset: 0x00956FC6
		protected BP_FloatingMovementConfig_C(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F1F RID: 73503
		public new const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/BP_FloatingMovementConfig.BP_FloatingMovementConfig_C";

		// Token: 0x04011F20 RID: 73504
		private static IntPtr _ClassPtr;

		// Token: 0x04011F21 RID: 73505
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F22 RID: 73506
		internal static int __PropertyOffset_MoveSpeed;

		// Token: 0x04011F23 RID: 73507
		internal static int __PropertyOffset_SprintSpeed;

		// Token: 0x04011F24 RID: 73508
		internal static int __PropertyOffset_TurnSpeedDeg;

		// Token: 0x04011F25 RID: 73509
		internal static int __PropertyOffset_AirEnergyConsumption;

		// Token: 0x04011F26 RID: 73510
		internal static int __PropertyOffset_RiseEnergyConsumption;

		// Token: 0x04011F27 RID: 73511
		internal static int __PropertyOffset_DropEnergyConsumption;

		// Token: 0x04011F28 RID: 73512
		internal static int __PropertyOffset_DodgeEnergyConsumption;

		// Token: 0x04011F29 RID: 73513
		internal static int __PropertyOffset_MoveEnergyConsumption;

		// Token: 0x04011F2A RID: 73514
		internal static int __PropertyOffset_FastMoveEnergyConsumption;

		// Token: 0x04011F2B RID: 73515
		internal static int __PropertyOffset_SprintEnergyConsumption;

		// Token: 0x04011F2C RID: 73516
		internal static int __PropertyOffset_EnergyRecoverSpeed;

		// Token: 0x04011F2D RID: 73517
		internal static int __PropertyOffset_EnergyRecoverCoolDownTime;

		// Token: 0x04011F2E RID: 73518
		internal static int __PropertyOffset_AirCriticalHeight;

		// Token: 0x04011F2F RID: 73519
		internal static int __PropertyOffset_CloseToGroundHeight;

		// Token: 0x04011F30 RID: 73520
		internal static int __PropertyOffset_RiseSpeed;

		// Token: 0x04011F31 RID: 73521
		internal static int __PropertyOffset_DropSpeed;

		// Token: 0x04011F32 RID: 73522
		internal static int __PropertyOffset_AnimLerpAlpha;

		// Token: 0x04011F33 RID: 73523
		internal static int __PropertyOffset_SpeedAcceleration;

		// Token: 0x04011F34 RID: 73524
		internal static int __PropertyOffset_DirectionLerpAlpha;

		// Token: 0x04011F35 RID: 73525
		internal static int __PropertyOffset_ForbidRotationTagList;

		// Token: 0x04011F36 RID: 73526
		[Nullable(2)]
		private FGameplayTagContainer _ForbidRotationTagList;

		// Token: 0x04011F37 RID: 73527
		internal static int __PropertyOffset_DefaultMode;

		// Token: 0x04011F38 RID: 73528
		[Nullable(2)]
		private SFloatingMovementState _DefaultMode;

		// Token: 0x04011F39 RID: 73529
		internal static int __PropertyOffset_FloatingMode;

		// Token: 0x04011F3A RID: 73530
		[Nullable(2)]
		private SFloatingMovementState _FloatingMode;

		// Token: 0x04011F3B RID: 73531
		internal static int __PropertyOffset_RiseMode;

		// Token: 0x04011F3C RID: 73532
		[Nullable(2)]
		private SFloatingMovementState _RiseMode;

		// Token: 0x04011F3D RID: 73533
		internal static int __PropertyOffset_DropMode;

		// Token: 0x04011F3E RID: 73534
		[Nullable(2)]
		private SFloatingMovementState _DropMode;

		// Token: 0x04011F3F RID: 73535
		internal static int __PropertyOffset_WalkMode;

		// Token: 0x04011F40 RID: 73536
		[Nullable(2)]
		private SFloatingMovementState _WalkMode;

		// Token: 0x04011F41 RID: 73537
		internal static int __PropertyOffset_ForbidCloseToGrounTagList;

		// Token: 0x04011F42 RID: 73538
		[Nullable(2)]
		private FGameplayTagContainer _ForbidCloseToGrounTagList;
	}
}
