using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x02003FB3 RID: 16307
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class SPhotoCameraCommonConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029B86 RID: 170886 RVA: 0x009CB090 File Offset: 0x009C9290
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraCommonConfig._ScriptStructPtr != 0) ? SPhotoCameraCommonConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig", ref SPhotoCameraCommonConfig._ScriptStructPtr);
		}

		// Token: 0x170064F1 RID: 25841
		// (get) Token: 0x06029B87 RID: 170887 RVA: 0x009CB0B4 File Offset: 0x009C92B4
		// (set) Token: 0x06029B88 RID: 170888 RVA: 0x009CB0C8 File Offset: 0x009C92C8
		public unsafe string CenterLocationSocketName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x170064F2 RID: 25842
		// (get) Token: 0x06029B89 RID: 170889 RVA: 0x009CB0DD File Offset: 0x009C92DD
		// (set) Token: 0x06029B8A RID: 170890 RVA: 0x009CB0F1 File Offset: 0x009C92F1
		public unsafe FVector InitCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170064F3 RID: 25843
		// (get) Token: 0x06029B8B RID: 170891 RVA: 0x009CB106 File Offset: 0x009C9306
		// (set) Token: 0x06029B8C RID: 170892 RVA: 0x009CB11A File Offset: 0x009C931A
		public unsafe FVector InitPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170064F4 RID: 25844
		// (get) Token: 0x06029B8D RID: 170893 RVA: 0x009CB12F File Offset: 0x009C932F
		// (set) Token: 0x06029B8E RID: 170894 RVA: 0x009CB143 File Offset: 0x009C9343
		public unsafe FVector InitRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x170064F5 RID: 25845
		// (get) Token: 0x06029B8F RID: 170895 RVA: 0x009CB158 File Offset: 0x009C9358
		// (set) Token: 0x06029B90 RID: 170896 RVA: 0x009CB168 File Offset: 0x009C9368
		public unsafe float InitFov
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x170064F6 RID: 25846
		// (get) Token: 0x06029B91 RID: 170897 RVA: 0x009CB179 File Offset: 0x009C9379
		// (set) Token: 0x06029B92 RID: 170898 RVA: 0x009CB18D File Offset: 0x009C938D
		public unsafe FVector2D FovRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x170064F7 RID: 25847
		// (get) Token: 0x06029B93 RID: 170899 RVA: 0x009CB1A2 File Offset: 0x009C93A2
		// (set) Token: 0x06029B94 RID: 170900 RVA: 0x009CB1B2 File Offset: 0x009C93B2
		public unsafe float ZoomSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170064F8 RID: 25848
		// (get) Token: 0x06029B95 RID: 170901 RVA: 0x009CB1C3 File Offset: 0x009C93C3
		// (set) Token: 0x06029B96 RID: 170902 RVA: 0x009CB1D7 File Offset: 0x009C93D7
		public unsafe FVector2D PitchRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x170064F9 RID: 25849
		// (get) Token: 0x06029B97 RID: 170903 RVA: 0x009CB1EC File Offset: 0x009C93EC
		// (set) Token: 0x06029B98 RID: 170904 RVA: 0x009CB200 File Offset: 0x009C9400
		public unsafe FVector2D YawRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x170064FA RID: 25850
		// (get) Token: 0x06029B99 RID: 170905 RVA: 0x009CB215 File Offset: 0x009C9415
		// (set) Token: 0x06029B9A RID: 170906 RVA: 0x009CB229 File Offset: 0x009C9429
		public unsafe FVector2D RollRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_9);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_9) = value;
			}
		}

		// Token: 0x170064FB RID: 25851
		// (get) Token: 0x06029B9B RID: 170907 RVA: 0x009CB23E File Offset: 0x009C943E
		// (set) Token: 0x06029B9C RID: 170908 RVA: 0x009CB24E File Offset: 0x009C944E
		public unsafe float PitchRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_10);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_10) = value;
			}
		}

		// Token: 0x170064FC RID: 25852
		// (get) Token: 0x06029B9D RID: 170909 RVA: 0x009CB25F File Offset: 0x009C945F
		// (set) Token: 0x06029B9E RID: 170910 RVA: 0x009CB26F File Offset: 0x009C946F
		public unsafe float YawRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_11);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_11) = value;
			}
		}

		// Token: 0x170064FD RID: 25853
		// (get) Token: 0x06029B9F RID: 170911 RVA: 0x009CB280 File Offset: 0x009C9480
		// (set) Token: 0x06029BA0 RID: 170912 RVA: 0x009CB290 File Offset: 0x009C9490
		public unsafe float RollRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_12);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_12) = value;
			}
		}

		// Token: 0x170064FE RID: 25854
		// (get) Token: 0x06029BA1 RID: 170913 RVA: 0x009CB2A1 File Offset: 0x009C94A1
		// (set) Token: 0x06029BA2 RID: 170914 RVA: 0x009CB2B1 File Offset: 0x009C94B1
		public unsafe bool OpenCameraAdaptive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_13) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_13) = (value ? 1 : 0);
			}
		}

		// Token: 0x170064FF RID: 25855
		// (get) Token: 0x06029BA3 RID: 170915 RVA: 0x009CB2C2 File Offset: 0x009C94C2
		// (set) Token: 0x06029BA4 RID: 170916 RVA: 0x009CB2D2 File Offset: 0x009C94D2
		public unsafe float AdaptiveMoveSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_14);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_14) = value;
			}
		}

		// Token: 0x17006500 RID: 25856
		// (get) Token: 0x06029BA5 RID: 170917 RVA: 0x009CB2E3 File Offset: 0x009C94E3
		// (set) Token: 0x06029BA6 RID: 170918 RVA: 0x009CB2F7 File Offset: 0x009C94F7
		public unsafe FVector2D CenterRollRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_15);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_15) = value;
			}
		}

		// Token: 0x17006501 RID: 25857
		// (get) Token: 0x06029BA7 RID: 170919 RVA: 0x009CB30C File Offset: 0x009C950C
		// (set) Token: 0x06029BA8 RID: 170920 RVA: 0x009CB31C File Offset: 0x009C951C
		public unsafe bool IsInheritPrevModeCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_16) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_16) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006502 RID: 25858
		// (get) Token: 0x06029BA9 RID: 170921 RVA: 0x009CB32D File Offset: 0x009C952D
		// (set) Token: 0x06029BAA RID: 170922 RVA: 0x009CB341 File Offset: 0x009C9541
		public unsafe FVector InheritCameraLocalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_17);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_17) = value;
			}
		}

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x06029BAB RID: 170923 RVA: 0x009CB356 File Offset: 0x009C9556
		// (set) Token: 0x06029BAC RID: 170924 RVA: 0x009CB366 File Offset: 0x009C9566
		public unsafe float InitFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_18);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_18) = value;
			}
		}

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x06029BAD RID: 170925 RVA: 0x009CB377 File Offset: 0x009C9577
		// (set) Token: 0x06029BAE RID: 170926 RVA: 0x009CB387 File Offset: 0x009C9587
		public unsafe float InitAperture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_19);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCommonConfig.__PropertyOffset_19) = value;
			}
		}

		// Token: 0x06029BAF RID: 170927 RVA: 0x009CB398 File Offset: 0x009C9598
		public SPhotoCameraCommonConfig()
		{
		}

		// Token: 0x06029BB0 RID: 170928 RVA: 0x009CB3A0 File Offset: 0x009C95A0
		public SPhotoCameraCommonConfig(string CenterLocationSocketName, FVector InitCenterOffset, FVector InitPosition, FVector InitRotation, float InitFov, FVector2D FovRange, float ZoomSpeed, FVector2D PitchRange, FVector2D YawRange, FVector2D RollRange, float PitchRotateSpeed, float YawRotateSpeed, float RollRotateSpeed, bool OpenCameraAdaptive, float AdaptiveMoveSpeed, FVector2D CenterRollRange, bool IsInheritPrevModeCamera, FVector InheritCameraLocalOffset, float InitFocusDistance, float InitAperture)
		{
			this.CenterLocationSocketName = CenterLocationSocketName;
			this.InitCenterOffset = InitCenterOffset;
			this.InitPosition = InitPosition;
			this.InitRotation = InitRotation;
			this.InitFov = InitFov;
			this.FovRange = FovRange;
			this.ZoomSpeed = ZoomSpeed;
			this.PitchRange = PitchRange;
			this.YawRange = YawRange;
			this.RollRange = RollRange;
			this.PitchRotateSpeed = PitchRotateSpeed;
			this.YawRotateSpeed = YawRotateSpeed;
			this.RollRotateSpeed = RollRotateSpeed;
			this.OpenCameraAdaptive = OpenCameraAdaptive;
			this.AdaptiveMoveSpeed = AdaptiveMoveSpeed;
			this.CenterRollRange = CenterRollRange;
			this.IsInheritPrevModeCamera = IsInheritPrevModeCamera;
			this.InheritCameraLocalOffset = InheritCameraLocalOffset;
			this.InitFocusDistance = InitFocusDistance;
			this.InitAperture = InitAperture;
		}

		// Token: 0x06029BB1 RID: 170929 RVA: 0x009CB450 File Offset: 0x009C9650
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraCommonConfig.StaticStruct();
		}

		// Token: 0x06029BB2 RID: 170930 RVA: 0x009CB45C File Offset: 0x009C965C
		[NullableContext(2)]
		public SPhotoCameraCommonConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029BB3 RID: 170931 RVA: 0x009CB466 File Offset: 0x009C9666
		public SPhotoCameraCommonConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029BB4 RID: 170932 RVA: 0x009CB471 File Offset: 0x009C9671
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraCommonConfig(Pointer, false, true);
		}

		// Token: 0x06029BB5 RID: 170933 RVA: 0x009CB47B File Offset: 0x009C967B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraCommonConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040156D5 RID: 87765
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCommonConfig.SPhotoCameraCommonConfig";

		// Token: 0x040156D6 RID: 87766
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156D7 RID: 87767
		internal static int __PropertyOffset_0;

		// Token: 0x040156D8 RID: 87768
		internal static int __PropertyOffset_1;

		// Token: 0x040156D9 RID: 87769
		internal static int __PropertyOffset_2;

		// Token: 0x040156DA RID: 87770
		internal static int __PropertyOffset_3;

		// Token: 0x040156DB RID: 87771
		internal static int __PropertyOffset_4;

		// Token: 0x040156DC RID: 87772
		internal static int __PropertyOffset_5;

		// Token: 0x040156DD RID: 87773
		internal static int __PropertyOffset_6;

		// Token: 0x040156DE RID: 87774
		internal static int __PropertyOffset_7;

		// Token: 0x040156DF RID: 87775
		internal static int __PropertyOffset_8;

		// Token: 0x040156E0 RID: 87776
		internal static int __PropertyOffset_9;

		// Token: 0x040156E1 RID: 87777
		internal static int __PropertyOffset_10;

		// Token: 0x040156E2 RID: 87778
		internal static int __PropertyOffset_11;

		// Token: 0x040156E3 RID: 87779
		internal static int __PropertyOffset_12;

		// Token: 0x040156E4 RID: 87780
		internal static int __PropertyOffset_13;

		// Token: 0x040156E5 RID: 87781
		internal static int __PropertyOffset_14;

		// Token: 0x040156E6 RID: 87782
		internal static int __PropertyOffset_15;

		// Token: 0x040156E7 RID: 87783
		internal static int __PropertyOffset_16;

		// Token: 0x040156E8 RID: 87784
		internal static int __PropertyOffset_17;

		// Token: 0x040156E9 RID: 87785
		internal static int __PropertyOffset_18;

		// Token: 0x040156EA RID: 87786
		internal static int __PropertyOffset_19;
	}
}
