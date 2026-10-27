using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x02003FB5 RID: 16309
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class SPhotoCameraMorphDeltaConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029BC8 RID: 170952 RVA: 0x009CB5BE File Offset: 0x009C97BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraMorphDeltaConfig._ScriptStructPtr != 0) ? SPhotoCameraMorphDeltaConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig", ref SPhotoCameraMorphDeltaConfig._ScriptStructPtr);
		}

		// Token: 0x1700650A RID: 25866
		// (get) Token: 0x06029BC9 RID: 170953 RVA: 0x009CB5E2 File Offset: 0x009C97E2
		// (set) Token: 0x06029BCA RID: 170954 RVA: 0x009CB5F6 File Offset: 0x009C97F6
		public unsafe string CenterLocationSocketNameOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x1700650B RID: 25867
		// (get) Token: 0x06029BCB RID: 170955 RVA: 0x009CB60B File Offset: 0x009C980B
		// (set) Token: 0x06029BCC RID: 170956 RVA: 0x009CB61F File Offset: 0x009C981F
		public unsafe FVector InitCenterOffsetDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x1700650C RID: 25868
		// (get) Token: 0x06029BCD RID: 170957 RVA: 0x009CB634 File Offset: 0x009C9834
		// (set) Token: 0x06029BCE RID: 170958 RVA: 0x009CB648 File Offset: 0x009C9848
		public unsafe FVector InitPositionDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x1700650D RID: 25869
		// (get) Token: 0x06029BCF RID: 170959 RVA: 0x009CB65D File Offset: 0x009C985D
		// (set) Token: 0x06029BD0 RID: 170960 RVA: 0x009CB671 File Offset: 0x009C9871
		public unsafe FVector InitRotationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x1700650E RID: 25870
		// (get) Token: 0x06029BD1 RID: 170961 RVA: 0x009CB686 File Offset: 0x009C9886
		// (set) Token: 0x06029BD2 RID: 170962 RVA: 0x009CB696 File Offset: 0x009C9896
		public unsafe float InitFocusDistanceDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x06029BD3 RID: 170963 RVA: 0x009CB6A7 File Offset: 0x009C98A7
		// (set) Token: 0x06029BD4 RID: 170964 RVA: 0x009CB6B7 File Offset: 0x009C98B7
		public unsafe float InitApertureDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x06029BD5 RID: 170965 RVA: 0x009CB6C8 File Offset: 0x009C98C8
		// (set) Token: 0x06029BD6 RID: 170966 RVA: 0x009CB6DC File Offset: 0x009C98DC
		public unsafe FVector2D ForwardAndBackDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x06029BD7 RID: 170967 RVA: 0x009CB6F1 File Offset: 0x009C98F1
		// (set) Token: 0x06029BD8 RID: 170968 RVA: 0x009CB705 File Offset: 0x009C9905
		public unsafe FVector2D LeftAndRightDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x17006512 RID: 25874
		// (get) Token: 0x06029BD9 RID: 170969 RVA: 0x009CB71A File Offset: 0x009C991A
		// (set) Token: 0x06029BDA RID: 170970 RVA: 0x009CB72E File Offset: 0x009C992E
		public unsafe FVector2D UpAndDownDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06029BDB RID: 170971 RVA: 0x009CB743 File Offset: 0x009C9943
		public SPhotoCameraMorphDeltaConfig()
		{
		}

		// Token: 0x06029BDC RID: 170972 RVA: 0x009CB74C File Offset: 0x009C994C
		public SPhotoCameraMorphDeltaConfig(string CenterLocationSocketNameOverride, FVector InitCenterOffsetDelta, FVector InitPositionDelta, FVector InitRotationDelta, float InitFocusDistanceDelta, float InitApertureDelta, FVector2D ForwardAndBackDistanceRangeDelta, FVector2D LeftAndRightDistanceRangeDelta, FVector2D UpAndDownDistanceRangeDelta)
		{
			this.CenterLocationSocketNameOverride = CenterLocationSocketNameOverride;
			this.InitCenterOffsetDelta = InitCenterOffsetDelta;
			this.InitPositionDelta = InitPositionDelta;
			this.InitRotationDelta = InitRotationDelta;
			this.InitFocusDistanceDelta = InitFocusDistanceDelta;
			this.InitApertureDelta = InitApertureDelta;
			this.ForwardAndBackDistanceRangeDelta = ForwardAndBackDistanceRangeDelta;
			this.LeftAndRightDistanceRangeDelta = LeftAndRightDistanceRangeDelta;
			this.UpAndDownDistanceRangeDelta = UpAndDownDistanceRangeDelta;
		}

		// Token: 0x06029BDD RID: 170973 RVA: 0x009CB7A4 File Offset: 0x009C99A4
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraMorphDeltaConfig.StaticStruct();
		}

		// Token: 0x06029BDE RID: 170974 RVA: 0x009CB7B0 File Offset: 0x009C99B0
		[NullableContext(2)]
		public SPhotoCameraMorphDeltaConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029BDF RID: 170975 RVA: 0x009CB7BA File Offset: 0x009C99BA
		public SPhotoCameraMorphDeltaConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029BE0 RID: 170976 RVA: 0x009CB7C5 File Offset: 0x009C99C5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraMorphDeltaConfig(Pointer, false, true);
		}

		// Token: 0x06029BE1 RID: 170977 RVA: 0x009CB7CF File Offset: 0x009C99CF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraMorphDeltaConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040156F2 RID: 87794
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig";

		// Token: 0x040156F3 RID: 87795
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156F4 RID: 87796
		internal static int __PropertyOffset_0;

		// Token: 0x040156F5 RID: 87797
		internal static int __PropertyOffset_1;

		// Token: 0x040156F6 RID: 87798
		internal static int __PropertyOffset_2;

		// Token: 0x040156F7 RID: 87799
		internal static int __PropertyOffset_3;

		// Token: 0x040156F8 RID: 87800
		internal static int __PropertyOffset_4;

		// Token: 0x040156F9 RID: 87801
		internal static int __PropertyOffset_5;

		// Token: 0x040156FA RID: 87802
		internal static int __PropertyOffset_6;

		// Token: 0x040156FB RID: 87803
		internal static int __PropertyOffset_7;

		// Token: 0x040156FC RID: 87804
		internal static int __PropertyOffset_8;
	}
}
