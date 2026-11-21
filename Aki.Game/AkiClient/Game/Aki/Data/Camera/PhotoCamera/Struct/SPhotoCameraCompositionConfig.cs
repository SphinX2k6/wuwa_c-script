using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x0200323C RID: 12860
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SPhotoCameraCompositionConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060201E5 RID: 131557 RVA: 0x0093DCF8 File Offset: 0x0093BEF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraCompositionConfig._ScriptStructPtr != 0) ? SPhotoCameraCompositionConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig", ref SPhotoCameraCompositionConfig._ScriptStructPtr);
		}

		// Token: 0x17003D6C RID: 15724
		// (get) Token: 0x060201E6 RID: 131558 RVA: 0x0093DD1C File Offset: 0x0093BF1C
		// (set) Token: 0x060201E7 RID: 131559 RVA: 0x0093DD2C File Offset: 0x0093BF2C
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003D6D RID: 15725
		// (get) Token: 0x060201E8 RID: 131560 RVA: 0x0093DD3D File Offset: 0x0093BF3D
		// (set) Token: 0x060201E9 RID: 131561 RVA: 0x0093DD4D File Offset: 0x0093BF4D
		public unsafe float BaseAspectRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_BaseAspectRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_BaseAspectRatio) = value;
			}
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x060201EA RID: 131562 RVA: 0x0093DD5E File Offset: 0x0093BF5E
		// (set) Token: 0x060201EB RID: 131563 RVA: 0x0093DD6E File Offset: 0x0093BF6E
		public unsafe float MaxCompensateDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_MaxCompensateDegree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_MaxCompensateDegree) = value;
			}
		}

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x060201EC RID: 131564 RVA: 0x0093DD7F File Offset: 0x0093BF7F
		// (set) Token: 0x060201ED RID: 131565 RVA: 0x0093DD8F File Offset: 0x0093BF8F
		public unsafe float MinAnchorDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_MinAnchorDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_MinAnchorDistance) = value;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x060201EE RID: 131566 RVA: 0x0093DDA0 File Offset: 0x0093BFA0
		// (set) Token: 0x060201EF RID: 131567 RVA: 0x0093DDB4 File Offset: 0x0093BFB4
		public unsafe FVectorDouble AnchorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_AnchorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraCompositionConfig.__PropertyOffset_AnchorOffset) = value;
			}
		}

		// Token: 0x060201F0 RID: 131568 RVA: 0x0093DDC9 File Offset: 0x0093BFC9
		public SPhotoCameraCompositionConfig()
		{
		}

		// Token: 0x060201F1 RID: 131569 RVA: 0x0093DDD1 File Offset: 0x0093BFD1
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraCompositionConfig.StaticStruct();
		}

		// Token: 0x060201F2 RID: 131570 RVA: 0x0093DDDD File Offset: 0x0093BFDD
		[NullableContext(2)]
		public SPhotoCameraCompositionConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060201F3 RID: 131571 RVA: 0x0093DDE7 File Offset: 0x0093BFE7
		public SPhotoCameraCompositionConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060201F4 RID: 131572 RVA: 0x0093DDF2 File Offset: 0x0093BFF2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraCompositionConfig(Pointer, false, true);
		}

		// Token: 0x060201F5 RID: 131573 RVA: 0x0093DDFC File Offset: 0x0093BFFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraCompositionConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04011493 RID: 70803
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraCompositionConfig.SPhotoCameraCompositionConfig";

		// Token: 0x04011494 RID: 70804
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011495 RID: 70805
		internal static int __PropertyOffset_Enable;

		// Token: 0x04011496 RID: 70806
		internal static int __PropertyOffset_BaseAspectRatio;

		// Token: 0x04011497 RID: 70807
		internal static int __PropertyOffset_MaxCompensateDegree;

		// Token: 0x04011498 RID: 70808
		internal static int __PropertyOffset_MinAnchorDistance;

		// Token: 0x04011499 RID: 70809
		internal static int __PropertyOffset_AnchorOffset;
	}
}
