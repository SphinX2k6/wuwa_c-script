using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x02003FB6 RID: 16310
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SPhotoCameraMoveConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06029BE2 RID: 170978 RVA: 0x009CB7D8 File Offset: 0x009C99D8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraMoveConfig._ScriptStructPtr != 0) ? SPhotoCameraMoveConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig", ref SPhotoCameraMoveConfig._ScriptStructPtr);
		}

		// Token: 0x17006513 RID: 25875
		// (get) Token: 0x06029BE3 RID: 170979 RVA: 0x009CB7FC File Offset: 0x009C99FC
		// (set) Token: 0x06029BE4 RID: 170980 RVA: 0x009CB80C File Offset: 0x009C9A0C
		public unsafe float UpAndDownSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006514 RID: 25876
		// (get) Token: 0x06029BE5 RID: 170981 RVA: 0x009CB81D File Offset: 0x009C9A1D
		// (set) Token: 0x06029BE6 RID: 170982 RVA: 0x009CB82D File Offset: 0x009C9A2D
		public unsafe float LeftAndRightSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006515 RID: 25877
		// (get) Token: 0x06029BE7 RID: 170983 RVA: 0x009CB83E File Offset: 0x009C9A3E
		// (set) Token: 0x06029BE8 RID: 170984 RVA: 0x009CB84E File Offset: 0x009C9A4E
		public unsafe float ForwardAndBackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006516 RID: 25878
		// (get) Token: 0x06029BE9 RID: 170985 RVA: 0x009CB85F File Offset: 0x009C9A5F
		// (set) Token: 0x06029BEA RID: 170986 RVA: 0x009CB873 File Offset: 0x009C9A73
		public unsafe FVector2D UpAndDownDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006517 RID: 25879
		// (get) Token: 0x06029BEB RID: 170987 RVA: 0x009CB888 File Offset: 0x009C9A88
		// (set) Token: 0x06029BEC RID: 170988 RVA: 0x009CB89C File Offset: 0x009C9A9C
		public unsafe FVector2D LeftAndRightDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006518 RID: 25880
		// (get) Token: 0x06029BED RID: 170989 RVA: 0x009CB8B1 File Offset: 0x009C9AB1
		// (set) Token: 0x06029BEE RID: 170990 RVA: 0x009CB8C5 File Offset: 0x009C9AC5
		public unsafe FVector2D ForwardAndBackDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006519 RID: 25881
		// (get) Token: 0x06029BEF RID: 170991 RVA: 0x009CB8DA File Offset: 0x009C9ADA
		// (set) Token: 0x06029BF0 RID: 170992 RVA: 0x009CB8EE File Offset: 0x009C9AEE
		public unsafe FVector2D RoleHideDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x1700651A RID: 25882
		// (get) Token: 0x06029BF1 RID: 170993 RVA: 0x009CB903 File Offset: 0x009C9B03
		// (set) Token: 0x06029BF2 RID: 170994 RVA: 0x009CB917 File Offset: 0x009C9B17
		public unsafe FVector2D HidePitchRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x1700651B RID: 25883
		// (get) Token: 0x06029BF3 RID: 170995 RVA: 0x009CB92C File Offset: 0x009C9B2C
		// (set) Token: 0x06029BF4 RID: 170996 RVA: 0x009CB940 File Offset: 0x009C9B40
		public unsafe FVector2D HideSizeInFrameRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_8);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_8) = value;
			}
		}

		// Token: 0x06029BF5 RID: 170997 RVA: 0x009CB955 File Offset: 0x009C9B55
		public SPhotoCameraMoveConfig()
		{
		}

		// Token: 0x06029BF6 RID: 170998 RVA: 0x009CB960 File Offset: 0x009C9B60
		public SPhotoCameraMoveConfig(float UpAndDownSpeed, float LeftAndRightSpeed, float ForwardAndBackSpeed, FVector2D UpAndDownDistanceRange, FVector2D LeftAndRightDistanceRange, FVector2D ForwardAndBackDistanceRange, FVector2D RoleHideDistanceRange, FVector2D HidePitchRange, FVector2D HideSizeInFrameRange)
		{
			this.UpAndDownSpeed = UpAndDownSpeed;
			this.LeftAndRightSpeed = LeftAndRightSpeed;
			this.ForwardAndBackSpeed = ForwardAndBackSpeed;
			this.UpAndDownDistanceRange = UpAndDownDistanceRange;
			this.LeftAndRightDistanceRange = LeftAndRightDistanceRange;
			this.ForwardAndBackDistanceRange = ForwardAndBackDistanceRange;
			this.RoleHideDistanceRange = RoleHideDistanceRange;
			this.HidePitchRange = HidePitchRange;
			this.HideSizeInFrameRange = HideSizeInFrameRange;
		}

		// Token: 0x06029BF7 RID: 170999 RVA: 0x009CB9B8 File Offset: 0x009C9BB8
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraMoveConfig.StaticStruct();
		}

		// Token: 0x06029BF8 RID: 171000 RVA: 0x009CB9C4 File Offset: 0x009C9BC4
		[NullableContext(2)]
		public SPhotoCameraMoveConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029BF9 RID: 171001 RVA: 0x009CB9CE File Offset: 0x009C9BCE
		public SPhotoCameraMoveConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029BFA RID: 171002 RVA: 0x009CB9D9 File Offset: 0x009C9BD9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraMoveConfig(Pointer, false, true);
		}

		// Token: 0x06029BFB RID: 171003 RVA: 0x009CB9E3 File Offset: 0x009C9BE3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraMoveConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040156FD RID: 87805
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig";

		// Token: 0x040156FE RID: 87806
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040156FF RID: 87807
		internal static int __PropertyOffset_0;

		// Token: 0x04015700 RID: 87808
		internal static int __PropertyOffset_1;

		// Token: 0x04015701 RID: 87809
		internal static int __PropertyOffset_2;

		// Token: 0x04015702 RID: 87810
		internal static int __PropertyOffset_3;

		// Token: 0x04015703 RID: 87811
		internal static int __PropertyOffset_4;

		// Token: 0x04015704 RID: 87812
		internal static int __PropertyOffset_5;

		// Token: 0x04015705 RID: 87813
		internal static int __PropertyOffset_6;

		// Token: 0x04015706 RID: 87814
		internal static int __PropertyOffset_7;

		// Token: 0x04015707 RID: 87815
		internal static int __PropertyOffset_8;
	}
}
