using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Camera.PhotoCamera.Struct
{
	// Token: 0x0200323D RID: 12861
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 84)]
	public class SPhotoCameraMorphDeltaConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060201F6 RID: 131574 RVA: 0x0093DE05 File Offset: 0x0093C005
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SPhotoCameraMorphDeltaConfig._ScriptStructPtr != 0) ? SPhotoCameraMorphDeltaConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig", ref SPhotoCameraMorphDeltaConfig._ScriptStructPtr);
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x060201F7 RID: 131575 RVA: 0x0093DE29 File Offset: 0x0093C029
		// (set) Token: 0x060201F8 RID: 131576 RVA: 0x0093DE3D File Offset: 0x0093C03D
		public unsafe string CenterLocationSocketNameOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_CenterLocationSocketNameOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_CenterLocationSocketNameOverride)), value);
			}
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x060201F9 RID: 131577 RVA: 0x0093DE52 File Offset: 0x0093C052
		// (set) Token: 0x060201FA RID: 131578 RVA: 0x0093DE66 File Offset: 0x0093C066
		public unsafe FVector InitCenterOffsetDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitCenterOffsetDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitCenterOffsetDelta) = value;
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x060201FB RID: 131579 RVA: 0x0093DE7B File Offset: 0x0093C07B
		// (set) Token: 0x060201FC RID: 131580 RVA: 0x0093DE8F File Offset: 0x0093C08F
		public unsafe FVector InitPositionDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitPositionDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitPositionDelta) = value;
			}
		}

		// Token: 0x17003D74 RID: 15732
		// (get) Token: 0x060201FD RID: 131581 RVA: 0x0093DEA4 File Offset: 0x0093C0A4
		// (set) Token: 0x060201FE RID: 131582 RVA: 0x0093DEB8 File Offset: 0x0093C0B8
		public unsafe FVector InitRotationDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitRotationDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitRotationDelta) = value;
			}
		}

		// Token: 0x17003D75 RID: 15733
		// (get) Token: 0x060201FF RID: 131583 RVA: 0x0093DECD File Offset: 0x0093C0CD
		// (set) Token: 0x06020200 RID: 131584 RVA: 0x0093DEDD File Offset: 0x0093C0DD
		public unsafe float InitFocusDistanceDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitFocusDistanceDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitFocusDistanceDelta) = value;
			}
		}

		// Token: 0x17003D76 RID: 15734
		// (get) Token: 0x06020201 RID: 131585 RVA: 0x0093DEEE File Offset: 0x0093C0EE
		// (set) Token: 0x06020202 RID: 131586 RVA: 0x0093DEFE File Offset: 0x0093C0FE
		public unsafe float InitApertureDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitApertureDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_InitApertureDelta) = value;
			}
		}

		// Token: 0x17003D77 RID: 15735
		// (get) Token: 0x06020203 RID: 131587 RVA: 0x0093DF0F File Offset: 0x0093C10F
		// (set) Token: 0x06020204 RID: 131588 RVA: 0x0093DF23 File Offset: 0x0093C123
		public unsafe FVector2D ForwardAndBackDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_ForwardAndBackDistanceRangeDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_ForwardAndBackDistanceRangeDelta) = value;
			}
		}

		// Token: 0x17003D78 RID: 15736
		// (get) Token: 0x06020205 RID: 131589 RVA: 0x0093DF38 File Offset: 0x0093C138
		// (set) Token: 0x06020206 RID: 131590 RVA: 0x0093DF4C File Offset: 0x0093C14C
		public unsafe FVector2D LeftAndRightDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_LeftAndRightDistanceRangeDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_LeftAndRightDistanceRangeDelta) = value;
			}
		}

		// Token: 0x17003D79 RID: 15737
		// (get) Token: 0x06020207 RID: 131591 RVA: 0x0093DF61 File Offset: 0x0093C161
		// (set) Token: 0x06020208 RID: 131592 RVA: 0x0093DF75 File Offset: 0x0093C175
		public unsafe FVector2D UpAndDownDistanceRangeDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_UpAndDownDistanceRangeDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SPhotoCameraMorphDeltaConfig.__PropertyOffset_UpAndDownDistanceRangeDelta) = value;
			}
		}

		// Token: 0x06020209 RID: 131593 RVA: 0x0093DF8A File Offset: 0x0093C18A
		public SPhotoCameraMorphDeltaConfig()
		{
		}

		// Token: 0x0602020A RID: 131594 RVA: 0x0093DF92 File Offset: 0x0093C192
		protected override IntPtr GetUStructPtr()
		{
			return SPhotoCameraMorphDeltaConfig.StaticStruct();
		}

		// Token: 0x0602020B RID: 131595 RVA: 0x0093DF9E File Offset: 0x0093C19E
		[NullableContext(2)]
		public SPhotoCameraMorphDeltaConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602020C RID: 131596 RVA: 0x0093DFA8 File Offset: 0x0093C1A8
		public SPhotoCameraMorphDeltaConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602020D RID: 131597 RVA: 0x0093DFB3 File Offset: 0x0093C1B3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SPhotoCameraMorphDeltaConfig(Pointer, false, true);
		}

		// Token: 0x0602020E RID: 131598 RVA: 0x0093DFBD File Offset: 0x0093C1BD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SPhotoCameraMorphDeltaConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401149A RID: 70810
		public const string __ObjectPath = "/Game/Aki/Data/Camera/PhotoCamera/Struct/SPhotoCameraMorphDeltaConfig.SPhotoCameraMorphDeltaConfig";

		// Token: 0x0401149B RID: 70811
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401149C RID: 70812
		internal static int __PropertyOffset_CenterLocationSocketNameOverride;

		// Token: 0x0401149D RID: 70813
		internal static int __PropertyOffset_InitCenterOffsetDelta;

		// Token: 0x0401149E RID: 70814
		internal static int __PropertyOffset_InitPositionDelta;

		// Token: 0x0401149F RID: 70815
		internal static int __PropertyOffset_InitRotationDelta;

		// Token: 0x040114A0 RID: 70816
		internal static int __PropertyOffset_InitFocusDistanceDelta;

		// Token: 0x040114A1 RID: 70817
		internal static int __PropertyOffset_InitApertureDelta;

		// Token: 0x040114A2 RID: 70818
		internal static int __PropertyOffset_ForwardAndBackDistanceRangeDelta;

		// Token: 0x040114A3 RID: 70819
		internal static int __PropertyOffset_LeftAndRightDistanceRangeDelta;

		// Token: 0x040114A4 RID: 70820
		internal static int __PropertyOffset_UpAndDownDistanceRangeDelta;
	}
}
