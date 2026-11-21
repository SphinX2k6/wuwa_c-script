using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Level.KeepFollowing
{
	// Token: 0x020031CB RID: 12747
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 69)]
	public class SFreeFollowingConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601F930 RID: 129328 RVA: 0x00930BAE File Offset: 0x0092EDAE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SFreeFollowingConfig._ScriptStructPtr != 0) ? SFreeFollowingConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig", ref SFreeFollowingConfig._ScriptStructPtr);
		}

		// Token: 0x17003A29 RID: 14889
		// (get) Token: 0x0601F931 RID: 129329 RVA: 0x00930BD2 File Offset: 0x0092EDD2
		// (set) Token: 0x0601F932 RID: 129330 RVA: 0x00930BE2 File Offset: 0x0092EDE2
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A2A RID: 14890
		// (get) Token: 0x0601F933 RID: 129331 RVA: 0x00930BF3 File Offset: 0x0092EDF3
		// (set) Token: 0x0601F934 RID: 129332 RVA: 0x00930C03 File Offset: 0x0092EE03
		public unsafe bool FollowOnRight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FollowOnRight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FollowOnRight) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A2B RID: 14891
		// (get) Token: 0x0601F935 RID: 129333 RVA: 0x00930C14 File Offset: 0x0092EE14
		// (set) Token: 0x0601F936 RID: 129334 RVA: 0x00930C24 File Offset: 0x0092EE24
		public unsafe bool AutoChangeSide
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_AutoChangeSide) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_AutoChangeSide) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A2C RID: 14892
		// (get) Token: 0x0601F937 RID: 129335 RVA: 0x00930C35 File Offset: 0x0092EE35
		// (set) Token: 0x0601F938 RID: 129336 RVA: 0x00930C45 File Offset: 0x0092EE45
		public unsafe float StartFollowingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_StartFollowingRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_StartFollowingRadius) = value;
			}
		}

		// Token: 0x17003A2D RID: 14893
		// (get) Token: 0x0601F939 RID: 129337 RVA: 0x00930C56 File Offset: 0x0092EE56
		// (set) Token: 0x0601F93A RID: 129338 RVA: 0x00930C66 File Offset: 0x0092EE66
		public unsafe float WalkStartFollowingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkStartFollowingRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkStartFollowingRadius) = value;
			}
		}

		// Token: 0x17003A2E RID: 14894
		// (get) Token: 0x0601F93B RID: 129339 RVA: 0x00930C77 File Offset: 0x0092EE77
		// (set) Token: 0x0601F93C RID: 129340 RVA: 0x00930C87 File Offset: 0x0092EE87
		public unsafe float FollowRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FollowRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FollowRadius) = value;
			}
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0601F93D RID: 129341 RVA: 0x00930C98 File Offset: 0x0092EE98
		// (set) Token: 0x0601F93E RID: 129342 RVA: 0x00930CA8 File Offset: 0x0092EEA8
		public unsafe float WalkFollowRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkFollowRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkFollowRadius) = value;
			}
		}

		// Token: 0x17003A30 RID: 14896
		// (get) Token: 0x0601F93F RID: 129343 RVA: 0x00930CB9 File Offset: 0x0092EEB9
		// (set) Token: 0x0601F940 RID: 129344 RVA: 0x00930CC9 File Offset: 0x0092EEC9
		public unsafe float MaxForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_MaxForwardOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_MaxForwardOffset) = value;
			}
		}

		// Token: 0x17003A31 RID: 14897
		// (get) Token: 0x0601F941 RID: 129345 RVA: 0x00930CDA File Offset: 0x0092EEDA
		// (set) Token: 0x0601F942 RID: 129346 RVA: 0x00930CEA File Offset: 0x0092EEEA
		public unsafe float FullForwardOffsetSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FullForwardOffsetSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_FullForwardOffsetSpeed) = value;
			}
		}

		// Token: 0x17003A32 RID: 14898
		// (get) Token: 0x0601F943 RID: 129347 RVA: 0x00930CFB File Offset: 0x0092EEFB
		// (set) Token: 0x0601F944 RID: 129348 RVA: 0x00930D0B File Offset: 0x0092EF0B
		public unsafe float SideAngleTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_SideAngleTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_SideAngleTolerance) = value;
			}
		}

		// Token: 0x17003A33 RID: 14899
		// (get) Token: 0x0601F945 RID: 129349 RVA: 0x00930D1C File Offset: 0x0092EF1C
		// (set) Token: 0x0601F946 RID: 129350 RVA: 0x00930D2C File Offset: 0x0092EF2C
		public unsafe float OffsetAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_OffsetAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_OffsetAngle) = value;
			}
		}

		// Token: 0x17003A34 RID: 14900
		// (get) Token: 0x0601F947 RID: 129351 RVA: 0x00930D3D File Offset: 0x0092EF3D
		// (set) Token: 0x0601F948 RID: 129352 RVA: 0x00930D4D File Offset: 0x0092EF4D
		public unsafe float MovementIntentSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_MovementIntentSmoothingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_MovementIntentSmoothingTime) = value;
			}
		}

		// Token: 0x17003A35 RID: 14901
		// (get) Token: 0x0601F949 RID: 129353 RVA: 0x00930D5E File Offset: 0x0092EF5E
		// (set) Token: 0x0601F94A RID: 129354 RVA: 0x00930D6E File Offset: 0x0092EF6E
		public unsafe float StopConfirmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_StopConfirmTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_StopConfirmTime) = value;
			}
		}

		// Token: 0x17003A36 RID: 14902
		// (get) Token: 0x0601F94B RID: 129355 RVA: 0x00930D7F File Offset: 0x0092EF7F
		// (set) Token: 0x0601F94C RID: 129356 RVA: 0x00930D8F File Offset: 0x0092EF8F
		public unsafe float WalkBehindTargetPauseTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkBehindTargetPauseTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_WalkBehindTargetPauseTime) = value;
			}
		}

		// Token: 0x17003A37 RID: 14903
		// (get) Token: 0x0601F94D RID: 129357 RVA: 0x00930DA0 File Offset: 0x0092EFA0
		// (set) Token: 0x0601F94E RID: 129358 RVA: 0x00930DB0 File Offset: 0x0092EFB0
		public unsafe float RunReferenceDirectionSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_RunReferenceDirectionSmoothingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_RunReferenceDirectionSmoothingTime) = value;
			}
		}

		// Token: 0x17003A38 RID: 14904
		// (get) Token: 0x0601F94F RID: 129359 RVA: 0x00930DC1 File Offset: 0x0092EFC1
		// (set) Token: 0x0601F950 RID: 129360 RVA: 0x00930DD1 File Offset: 0x0092EFD1
		public unsafe float SprintReferenceDirectionSmoothingTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_SprintReferenceDirectionSmoothingTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_SprintReferenceDirectionSmoothingTime) = value;
			}
		}

		// Token: 0x17003A39 RID: 14905
		// (get) Token: 0x0601F951 RID: 129361 RVA: 0x00930DE2 File Offset: 0x0092EFE2
		// (set) Token: 0x0601F952 RID: 129362 RVA: 0x00930DF2 File Offset: 0x0092EFF2
		public unsafe bool EnableNavMeshPath
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_EnableNavMeshPath) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_EnableNavMeshPath) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A3A RID: 14906
		// (get) Token: 0x0601F953 RID: 129363 RVA: 0x00930E03 File Offset: 0x0092F003
		// (set) Token: 0x0601F954 RID: 129364 RVA: 0x00930E13 File Offset: 0x0092F013
		public unsafe bool EnableLocalMovementHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_EnableLocalMovementHold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_EnableLocalMovementHold) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003A3B RID: 14907
		// (get) Token: 0x0601F955 RID: 129365 RVA: 0x00930E24 File Offset: 0x0092F024
		// (set) Token: 0x0601F956 RID: 129366 RVA: 0x00930E34 File Offset: 0x0092F034
		public unsafe float LocalMovementEnterRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_LocalMovementEnterRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_LocalMovementEnterRate) = value;
			}
		}

		// Token: 0x17003A3C RID: 14908
		// (get) Token: 0x0601F957 RID: 129367 RVA: 0x00930E45 File Offset: 0x0092F045
		// (set) Token: 0x0601F958 RID: 129368 RVA: 0x00930E55 File Offset: 0x0092F055
		public unsafe float LocalMovementEnterConfirmTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_LocalMovementEnterConfirmTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_LocalMovementEnterConfirmTime) = value;
			}
		}

		// Token: 0x17003A3D RID: 14909
		// (get) Token: 0x0601F959 RID: 129369 RVA: 0x00930E66 File Offset: 0x0092F066
		// (set) Token: 0x0601F95A RID: 129370 RVA: 0x00930E76 File Offset: 0x0092F076
		public unsafe bool DebugDraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_DebugDraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SFreeFollowingConfig.__PropertyOffset_DebugDraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F95B RID: 129371 RVA: 0x00930E87 File Offset: 0x0092F087
		public SFreeFollowingConfig()
		{
		}

		// Token: 0x0601F95C RID: 129372 RVA: 0x00930E8F File Offset: 0x0092F08F
		protected override IntPtr GetUStructPtr()
		{
			return SFreeFollowingConfig.StaticStruct();
		}

		// Token: 0x0601F95D RID: 129373 RVA: 0x00930E9B File Offset: 0x0092F09B
		[NullableContext(2)]
		public SFreeFollowingConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601F95E RID: 129374 RVA: 0x00930EA5 File Offset: 0x0092F0A5
		public SFreeFollowingConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601F95F RID: 129375 RVA: 0x00930EB0 File Offset: 0x0092F0B0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SFreeFollowingConfig(Pointer, false, true);
		}

		// Token: 0x0601F960 RID: 129376 RVA: 0x00930EBA File Offset: 0x0092F0BA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SFreeFollowingConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04010F01 RID: 69377
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Level/KeepFollowing/SFreeFollowingConfig.SFreeFollowingConfig";

		// Token: 0x04010F02 RID: 69378
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010F03 RID: 69379
		internal static int __PropertyOffset_Enable;

		// Token: 0x04010F04 RID: 69380
		internal static int __PropertyOffset_FollowOnRight;

		// Token: 0x04010F05 RID: 69381
		internal static int __PropertyOffset_AutoChangeSide;

		// Token: 0x04010F06 RID: 69382
		internal static int __PropertyOffset_StartFollowingRadius;

		// Token: 0x04010F07 RID: 69383
		internal static int __PropertyOffset_WalkStartFollowingRadius;

		// Token: 0x04010F08 RID: 69384
		internal static int __PropertyOffset_FollowRadius;

		// Token: 0x04010F09 RID: 69385
		internal static int __PropertyOffset_WalkFollowRadius;

		// Token: 0x04010F0A RID: 69386
		internal static int __PropertyOffset_MaxForwardOffset;

		// Token: 0x04010F0B RID: 69387
		internal static int __PropertyOffset_FullForwardOffsetSpeed;

		// Token: 0x04010F0C RID: 69388
		internal static int __PropertyOffset_SideAngleTolerance;

		// Token: 0x04010F0D RID: 69389
		internal static int __PropertyOffset_OffsetAngle;

		// Token: 0x04010F0E RID: 69390
		internal static int __PropertyOffset_MovementIntentSmoothingTime;

		// Token: 0x04010F0F RID: 69391
		internal static int __PropertyOffset_StopConfirmTime;

		// Token: 0x04010F10 RID: 69392
		internal static int __PropertyOffset_WalkBehindTargetPauseTime;

		// Token: 0x04010F11 RID: 69393
		internal static int __PropertyOffset_RunReferenceDirectionSmoothingTime;

		// Token: 0x04010F12 RID: 69394
		internal static int __PropertyOffset_SprintReferenceDirectionSmoothingTime;

		// Token: 0x04010F13 RID: 69395
		internal static int __PropertyOffset_EnableNavMeshPath;

		// Token: 0x04010F14 RID: 69396
		internal static int __PropertyOffset_EnableLocalMovementHold;

		// Token: 0x04010F15 RID: 69397
		internal static int __PropertyOffset_LocalMovementEnterRate;

		// Token: 0x04010F16 RID: 69398
		internal static int __PropertyOffset_LocalMovementEnterConfirmTime;

		// Token: 0x04010F17 RID: 69399
		internal static int __PropertyOffset_DebugDraw;
	}
}
