using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x0200323E RID: 12862
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class SPhotoCameraMoveConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602020F RID: 131599 RVA: 0x0093DFC6 File Offset: 0x0093C1C6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraMoveConfig._ScriptStructPtr != 0) ? SPhotoCameraMoveConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig", ref SPhotoCameraMoveConfig._ScriptStructPtr);
		}

		// Token: 0x17003D7A RID: 15738
		// (get) Token: 0x06020210 RID: 131600 RVA: 0x0093DFEA File Offset: 0x0093C1EA
		// (set) Token: 0x06020211 RID: 131601 RVA: 0x0093DFFA File Offset: 0x0093C1FA
		public unsafe float UpAndDownSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_UpAndDownSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_UpAndDownSpeed) = value;
			}
		}

		// Token: 0x17003D7B RID: 15739
		// (get) Token: 0x06020212 RID: 131602 RVA: 0x0093E00B File Offset: 0x0093C20B
		// (set) Token: 0x06020213 RID: 131603 RVA: 0x0093E01B File Offset: 0x0093C21B
		public unsafe float LeftAndRightSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_LeftAndRightSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_LeftAndRightSpeed) = value;
			}
		}

		// Token: 0x17003D7C RID: 15740
		// (get) Token: 0x06020214 RID: 131604 RVA: 0x0093E02C File Offset: 0x0093C22C
		// (set) Token: 0x06020215 RID: 131605 RVA: 0x0093E03C File Offset: 0x0093C23C
		public unsafe float ForwardAndBackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_ForwardAndBackSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_ForwardAndBackSpeed) = value;
			}
		}

		// Token: 0x17003D7D RID: 15741
		// (get) Token: 0x06020216 RID: 131606 RVA: 0x0093E04D File Offset: 0x0093C24D
		// (set) Token: 0x06020217 RID: 131607 RVA: 0x0093E061 File Offset: 0x0093C261
		public unsafe FVector2D UpAndDownDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_UpAndDownDistanceRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_UpAndDownDistanceRange) = value;
			}
		}

		// Token: 0x17003D7E RID: 15742
		// (get) Token: 0x06020218 RID: 131608 RVA: 0x0093E076 File Offset: 0x0093C276
		// (set) Token: 0x06020219 RID: 131609 RVA: 0x0093E08A File Offset: 0x0093C28A
		public unsafe FVector2D LeftAndRightDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_LeftAndRightDistanceRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_LeftAndRightDistanceRange) = value;
			}
		}

		// Token: 0x17003D7F RID: 15743
		// (get) Token: 0x0602021A RID: 131610 RVA: 0x0093E09F File Offset: 0x0093C29F
		// (set) Token: 0x0602021B RID: 131611 RVA: 0x0093E0B3 File Offset: 0x0093C2B3
		public unsafe FVector2D ForwardAndBackDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_ForwardAndBackDistanceRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_ForwardAndBackDistanceRange) = value;
			}
		}

		// Token: 0x17003D80 RID: 15744
		// (get) Token: 0x0602021C RID: 131612 RVA: 0x0093E0C8 File Offset: 0x0093C2C8
		// (set) Token: 0x0602021D RID: 131613 RVA: 0x0093E0DC File Offset: 0x0093C2DC
		public unsafe FVector2D RoleHideDistanceRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_RoleHideDistanceRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_RoleHideDistanceRange) = value;
			}
		}

		// Token: 0x17003D81 RID: 15745
		// (get) Token: 0x0602021E RID: 131614 RVA: 0x0093E0F1 File Offset: 0x0093C2F1
		// (set) Token: 0x0602021F RID: 131615 RVA: 0x0093E105 File Offset: 0x0093C305
		public unsafe FVector2D HidePitchRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_HidePitchRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_HidePitchRange) = value;
			}
		}

		// Token: 0x17003D82 RID: 15746
		// (get) Token: 0x06020220 RID: 131616 RVA: 0x0093E11A File Offset: 0x0093C31A
		// (set) Token: 0x06020221 RID: 131617 RVA: 0x0093E12E File Offset: 0x0093C32E
		public unsafe FVector2D HideSizeInFrameRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_HideSizeInFrameRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMoveConfig.__PropertyOffset_HideSizeInFrameRange) = value;
			}
		}

		// Token: 0x06020222 RID: 131618 RVA: 0x0093E143 File Offset: 0x0093C343
		public SPhotoCameraMoveConfig()
		{
		}

		// Token: 0x06020223 RID: 131619 RVA: 0x0093E14B File Offset: 0x0093C34B
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraMoveConfig.StaticStruct();
		}

		// Token: 0x06020224 RID: 131620 RVA: 0x0093E157 File Offset: 0x0093C357
		[NullableContext(2)]
		public SPhotoCameraMoveConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020225 RID: 131621 RVA: 0x0093E161 File Offset: 0x0093C361
		public SPhotoCameraMoveConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020226 RID: 131622 RVA: 0x0093E16C File Offset: 0x0093C36C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraMoveConfig(Pointer, false, true);
		}

		// Token: 0x06020227 RID: 131623 RVA: 0x0093E176 File Offset: 0x0093C376
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraMoveConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040114A5 RID: 70821
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMoveConfig.SPhotoCameraMoveConfig";

		// Token: 0x040114A6 RID: 70822
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040114A7 RID: 70823
		internal static int __PropertyOffset_UpAndDownSpeed;

		// Token: 0x040114A8 RID: 70824
		internal static int __PropertyOffset_LeftAndRightSpeed;

		// Token: 0x040114A9 RID: 70825
		internal static int __PropertyOffset_ForwardAndBackSpeed;

		// Token: 0x040114AA RID: 70826
		internal static int __PropertyOffset_UpAndDownDistanceRange;

		// Token: 0x040114AB RID: 70827
		internal static int __PropertyOffset_LeftAndRightDistanceRange;

		// Token: 0x040114AC RID: 70828
		internal static int __PropertyOffset_ForwardAndBackDistanceRange;

		// Token: 0x040114AD RID: 70829
		internal static int __PropertyOffset_RoleHideDistanceRange;

		// Token: 0x040114AE RID: 70830
		internal static int __PropertyOffset_HidePitchRange;

		// Token: 0x040114AF RID: 70831
		internal static int __PropertyOffset_HideSizeInFrameRange;
	}
}
