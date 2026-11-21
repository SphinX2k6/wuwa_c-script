using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003205 RID: 12805
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SDeadEyeConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FE32 RID: 130610 RVA: 0x009384CD File Offset: 0x009366CD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDeadEyeConfig._ScriptStructPtr != 0) ? SDeadEyeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig", ref SDeadEyeConfig._ScriptStructPtr);
		}

		// Token: 0x17003C05 RID: 15365
		// (get) Token: 0x0601FE33 RID: 130611 RVA: 0x009384F1 File Offset: 0x009366F1
		// (set) Token: 0x0601FE34 RID: 130612 RVA: 0x00938501 File Offset: 0x00936701
		public unsafe float AimToleranceDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_AimToleranceDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_AimToleranceDeg) = value;
			}
		}

		// Token: 0x17003C06 RID: 15366
		// (get) Token: 0x0601FE35 RID: 130613 RVA: 0x00938512 File Offset: 0x00936712
		// (set) Token: 0x0601FE36 RID: 130614 RVA: 0x00938522 File Offset: 0x00936722
		public unsafe float AimSpeedDegPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_AimSpeedDegPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_AimSpeedDegPerSec) = value;
			}
		}

		// Token: 0x17003C07 RID: 15367
		// (get) Token: 0x0601FE37 RID: 130615 RVA: 0x00938533 File Offset: 0x00936733
		// (set) Token: 0x0601FE38 RID: 130616 RVA: 0x00938543 File Offset: 0x00936743
		public unsafe float PostFireDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_PostFireDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_PostFireDelay) = value;
			}
		}

		// Token: 0x17003C08 RID: 15368
		// (get) Token: 0x0601FE39 RID: 130617 RVA: 0x00938554 File Offset: 0x00936754
		// (set) Token: 0x0601FE3A RID: 130618 RVA: 0x00938564 File Offset: 0x00936764
		public unsafe bool EaseOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_EaseOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_EaseOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C09 RID: 15369
		// (get) Token: 0x0601FE3B RID: 130619 RVA: 0x00938575 File Offset: 0x00936775
		// (set) Token: 0x0601FE3C RID: 130620 RVA: 0x00938585 File Offset: 0x00936785
		public unsafe bool EaseIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_EaseIn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_EaseIn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C0A RID: 15370
		// (get) Token: 0x0601FE3D RID: 130621 RVA: 0x00938596 File Offset: 0x00936796
		// (set) Token: 0x0601FE3E RID: 130622 RVA: 0x009385A6 File Offset: 0x009367A6
		public unsafe bool ForceShortestRoute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_ForceShortestRoute) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_ForceShortestRoute) = (value ? 1 : 0);
			}
		}

		// Token: 0x17003C0B RID: 15371
		// (get) Token: 0x0601FE3F RID: 130623 RVA: 0x009385B7 File Offset: 0x009367B7
		// (set) Token: 0x0601FE40 RID: 130624 RVA: 0x009385C7 File Offset: 0x009367C7
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_SkillId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_SkillId) = value;
			}
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0601FE41 RID: 130625 RVA: 0x009385D8 File Offset: 0x009367D8
		// (set) Token: 0x0601FE42 RID: 130626 RVA: 0x009385EC File Offset: 0x009367EC
		public unsafe FRotator RotateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_RotateOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_RotateOffset) = value;
			}
		}

		// Token: 0x0601FE43 RID: 130627 RVA: 0x00938601 File Offset: 0x00936801
		public SDeadEyeConfig()
		{
		}

		// Token: 0x0601FE44 RID: 130628 RVA: 0x00938609 File Offset: 0x00936809
		protected override IntPtr GetUStructPtr()
		{
			return SDeadEyeConfig.StaticStruct();
		}

		// Token: 0x0601FE45 RID: 130629 RVA: 0x00938615 File Offset: 0x00936815
		[NullableContext(2)]
		public SDeadEyeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FE46 RID: 130630 RVA: 0x0093861F File Offset: 0x0093681F
		public SDeadEyeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FE47 RID: 130631 RVA: 0x0093862A File Offset: 0x0093682A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDeadEyeConfig(Pointer, false, true);
		}

		// Token: 0x0601FE48 RID: 130632 RVA: 0x00938634 File Offset: 0x00936834
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDeadEyeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x040111FF RID: 70143
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig";

		// Token: 0x04011200 RID: 70144
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011201 RID: 70145
		internal static int __PropertyOffset_AimToleranceDeg;

		// Token: 0x04011202 RID: 70146
		internal static int __PropertyOffset_AimSpeedDegPerSec;

		// Token: 0x04011203 RID: 70147
		internal static int __PropertyOffset_PostFireDelay;

		// Token: 0x04011204 RID: 70148
		internal static int __PropertyOffset_EaseOut;

		// Token: 0x04011205 RID: 70149
		internal static int __PropertyOffset_EaseIn;

		// Token: 0x04011206 RID: 70150
		internal static int __PropertyOffset_ForceShortestRoute;

		// Token: 0x04011207 RID: 70151
		internal static int __PropertyOffset_SkillId;

		// Token: 0x04011208 RID: 70152
		internal static int __PropertyOffset_RotateOffset;
	}
}
