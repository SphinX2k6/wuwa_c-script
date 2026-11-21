using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x0200323B RID: 12859
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class SPhotoCameraCommonConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060201B6 RID: 131510 RVA: 0x0093D9B4 File Offset: 0x0093BBB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraCommonConfig._ScriptStructPtr != 0) ? SPhotoCameraCommonConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig", ref SPhotoCameraCommonConfig._ScriptStructPtr);
		}

		// Token: 0x17003D58 RID: 15704
		// (get) Token: 0x060201B7 RID: 131511 RVA: 0x0093D9D8 File Offset: 0x0093BBD8
		// (set) Token: 0x060201B8 RID: 131512 RVA: 0x0093D9EC File Offset: 0x0093BBEC
		public unsafe string CenterLocationSocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_CenterLocationSocketName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_CenterLocationSocketName)), value);
			}
		}

		// Token: 0x17003D59 RID: 15705
		// (get) Token: 0x060201B9 RID: 131513 RVA: 0x0093DA01 File Offset: 0x0093BC01
		// (set) Token: 0x060201BA RID: 131514 RVA: 0x0093DA15 File Offset: 0x0093BC15
		public unsafe FVector InitCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitCenterOffset) = value;
			}
		}

		// Token: 0x17003D5A RID: 15706
		// (get) Token: 0x060201BB RID: 131515 RVA: 0x0093DA2A File Offset: 0x0093BC2A
		// (set) Token: 0x060201BC RID: 131516 RVA: 0x0093DA3E File Offset: 0x0093BC3E
		public unsafe FVector InitPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitPosition) = value;
			}
		}

		// Token: 0x17003D5B RID: 15707
		// (get) Token: 0x060201BD RID: 131517 RVA: 0x0093DA53 File Offset: 0x0093BC53
		// (set) Token: 0x060201BE RID: 131518 RVA: 0x0093DA67 File Offset: 0x0093BC67
		public unsafe FVector InitRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitRotation) = value;
			}
		}

		// Token: 0x17003D5C RID: 15708
		// (get) Token: 0x060201BF RID: 131519 RVA: 0x0093DA7C File Offset: 0x0093BC7C
		// (set) Token: 0x060201C0 RID: 131520 RVA: 0x0093DA8C File Offset: 0x0093BC8C
		public unsafe float InitFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitFov);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitFov) = value;
			}
		}

		// Token: 0x17003D5D RID: 15709
		// (get) Token: 0x060201C1 RID: 131521 RVA: 0x0093DA9D File Offset: 0x0093BC9D
		// (set) Token: 0x060201C2 RID: 131522 RVA: 0x0093DAB1 File Offset: 0x0093BCB1
		public unsafe FVector2D FovRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_FovRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_FovRange) = value;
			}
		}

		// Token: 0x17003D5E RID: 15710
		// (get) Token: 0x060201C3 RID: 131523 RVA: 0x0093DAC6 File Offset: 0x0093BCC6
		// (set) Token: 0x060201C4 RID: 131524 RVA: 0x0093DAD6 File Offset: 0x0093BCD6
		public unsafe float ZoomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_ZoomSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_ZoomSpeed) = value;
			}
		}

		// Token: 0x17003D5F RID: 15711
		// (get) Token: 0x060201C5 RID: 131525 RVA: 0x0093DAE7 File Offset: 0x0093BCE7
		// (set) Token: 0x060201C6 RID: 131526 RVA: 0x0093DAFB File Offset: 0x0093BCFB
		public unsafe FVector2D PitchRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_PitchRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_PitchRange) = value;
			}
		}

		// Token: 0x17003D60 RID: 15712
		// (get) Token: 0x060201C7 RID: 131527 RVA: 0x0093DB10 File Offset: 0x0093BD10
		// (set) Token: 0x060201C8 RID: 131528 RVA: 0x0093DB24 File Offset: 0x0093BD24
		public unsafe FVector2D YawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_YawRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_YawRange) = value;
			}
		}

		// Token: 0x17003D61 RID: 15713
		// (get) Token: 0x060201C9 RID: 131529 RVA: 0x0093DB39 File Offset: 0x0093BD39
		// (set) Token: 0x060201CA RID: 131530 RVA: 0x0093DB4D File Offset: 0x0093BD4D
		public unsafe FVector2D RollRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_RollRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_RollRange) = value;
			}
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x060201CB RID: 131531 RVA: 0x0093DB62 File Offset: 0x0093BD62
		// (set) Token: 0x060201CC RID: 131532 RVA: 0x0093DB72 File Offset: 0x0093BD72
		public unsafe float PitchRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_PitchRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_PitchRotateSpeed) = value;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x060201CD RID: 131533 RVA: 0x0093DB83 File Offset: 0x0093BD83
		// (set) Token: 0x060201CE RID: 131534 RVA: 0x0093DB93 File Offset: 0x0093BD93
		public unsafe float YawRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_YawRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_YawRotateSpeed) = value;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x060201CF RID: 131535 RVA: 0x0093DBA4 File Offset: 0x0093BDA4
		// (set) Token: 0x060201D0 RID: 131536 RVA: 0x0093DBB4 File Offset: 0x0093BDB4
		public unsafe float RollRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_RollRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_RollRotateSpeed) = value;
			}
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x060201D1 RID: 131537 RVA: 0x0093DBC5 File Offset: 0x0093BDC5
		// (set) Token: 0x060201D2 RID: 131538 RVA: 0x0093DBD5 File Offset: 0x0093BDD5
		public unsafe bool OpenCameraAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_OpenCameraAdaptive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_OpenCameraAdaptive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x060201D3 RID: 131539 RVA: 0x0093DBE6 File Offset: 0x0093BDE6
		// (set) Token: 0x060201D4 RID: 131540 RVA: 0x0093DBF6 File Offset: 0x0093BDF6
		public unsafe float AdaptiveMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_AdaptiveMoveSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_AdaptiveMoveSpeed) = value;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x060201D5 RID: 131541 RVA: 0x0093DC07 File Offset: 0x0093BE07
		// (set) Token: 0x060201D6 RID: 131542 RVA: 0x0093DC1B File Offset: 0x0093BE1B
		public unsafe FVector2D CenterRollRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_CenterRollRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_CenterRollRange) = value;
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x060201D7 RID: 131543 RVA: 0x0093DC30 File Offset: 0x0093BE30
		// (set) Token: 0x060201D8 RID: 131544 RVA: 0x0093DC40 File Offset: 0x0093BE40
		public unsafe bool IsInheritPrevModeCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_IsInheritPrevModeCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_IsInheritPrevModeCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x060201D9 RID: 131545 RVA: 0x0093DC51 File Offset: 0x0093BE51
		// (set) Token: 0x060201DA RID: 131546 RVA: 0x0093DC65 File Offset: 0x0093BE65
		public unsafe FVector InheritCameraLocalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InheritCameraLocalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InheritCameraLocalOffset) = value;
			}
		}

		// Token: 0x17003D6A RID: 15722
		// (get) Token: 0x060201DB RID: 131547 RVA: 0x0093DC7A File Offset: 0x0093BE7A
		// (set) Token: 0x060201DC RID: 131548 RVA: 0x0093DC8A File Offset: 0x0093BE8A
		public unsafe float InitFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitFocusDistance) = value;
			}
		}

		// Token: 0x17003D6B RID: 15723
		// (get) Token: 0x060201DD RID: 131549 RVA: 0x0093DC9B File Offset: 0x0093BE9B
		// (set) Token: 0x060201DE RID: 131550 RVA: 0x0093DCAB File Offset: 0x0093BEAB
		public unsafe float InitAperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitAperture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_InitAperture) = value;
			}
		}

		// Token: 0x060201DF RID: 131551 RVA: 0x0093DCBC File Offset: 0x0093BEBC
		public SPhotoCameraCommonConfig()
		{
		}

		// Token: 0x060201E0 RID: 131552 RVA: 0x0093DCC4 File Offset: 0x0093BEC4
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraCommonConfig.StaticStruct();
		}

		// Token: 0x060201E1 RID: 131553 RVA: 0x0093DCD0 File Offset: 0x0093BED0
		[NullableContext(2)]
		public SPhotoCameraCommonConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060201E2 RID: 131554 RVA: 0x0093DCDA File Offset: 0x0093BEDA
		public SPhotoCameraCommonConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060201E3 RID: 131555 RVA: 0x0093DCE5 File Offset: 0x0093BEE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraCommonConfig(Pointer, false, true);
		}

		// Token: 0x060201E4 RID: 131556 RVA: 0x0093DCEF File Offset: 0x0093BEEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraCommonConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401147D RID: 70781
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig";

		// Token: 0x0401147E RID: 70782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401147F RID: 70783
		internal static int __PropertyOffset_CenterLocationSocketName;

		// Token: 0x04011480 RID: 70784
		internal static int __PropertyOffset_InitCenterOffset;

		// Token: 0x04011481 RID: 70785
		internal static int __PropertyOffset_InitPosition;

		// Token: 0x04011482 RID: 70786
		internal static int __PropertyOffset_InitRotation;

		// Token: 0x04011483 RID: 70787
		internal static int __PropertyOffset_InitFov;

		// Token: 0x04011484 RID: 70788
		internal static int __PropertyOffset_FovRange;

		// Token: 0x04011485 RID: 70789
		internal static int __PropertyOffset_ZoomSpeed;

		// Token: 0x04011486 RID: 70790
		internal static int __PropertyOffset_PitchRange;

		// Token: 0x04011487 RID: 70791
		internal static int __PropertyOffset_YawRange;

		// Token: 0x04011488 RID: 70792
		internal static int __PropertyOffset_RollRange;

		// Token: 0x04011489 RID: 70793
		internal static int __PropertyOffset_PitchRotateSpeed;

		// Token: 0x0401148A RID: 70794
		internal static int __PropertyOffset_YawRotateSpeed;

		// Token: 0x0401148B RID: 70795
		internal static int __PropertyOffset_RollRotateSpeed;

		// Token: 0x0401148C RID: 70796
		internal static int __PropertyOffset_OpenCameraAdaptive;

		// Token: 0x0401148D RID: 70797
		internal static int __PropertyOffset_AdaptiveMoveSpeed;

		// Token: 0x0401148E RID: 70798
		internal static int __PropertyOffset_CenterRollRange;

		// Token: 0x0401148F RID: 70799
		internal static int __PropertyOffset_IsInheritPrevModeCamera;

		// Token: 0x04011490 RID: 70800
		internal static int __PropertyOffset_InheritCameraLocalOffset;

		// Token: 0x04011491 RID: 70801
		internal static int __PropertyOffset_InitFocusDistance;

		// Token: 0x04011492 RID: 70802
		internal static int __PropertyOffset_InitAperture;
	}
}
