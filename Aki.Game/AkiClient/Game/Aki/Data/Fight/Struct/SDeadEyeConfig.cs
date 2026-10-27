using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Fight.Struct
{
	// Token: 0x02003F64 RID: 16228
	[UnrealObjectPath("/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class SDeadEyeConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060295A8 RID: 169384 RVA: 0x009C233A File Offset: 0x009C053A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SDeadEyeConfig._ScriptStructPtr != 0) ? SDeadEyeConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig", ref SDeadEyeConfig._ScriptStructPtr);
		}

		// Token: 0x170062C9 RID: 25289
		// (get) Token: 0x060295A9 RID: 169385 RVA: 0x009C235E File Offset: 0x009C055E
		// (set) Token: 0x060295AA RID: 169386 RVA: 0x009C236E File Offset: 0x009C056E
		public unsafe float AimToleranceDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x170062CA RID: 25290
		// (get) Token: 0x060295AB RID: 169387 RVA: 0x009C237F File Offset: 0x009C057F
		// (set) Token: 0x060295AC RID: 169388 RVA: 0x009C238F File Offset: 0x009C058F
		public unsafe float AimSpeedDegPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x170062CB RID: 25291
		// (get) Token: 0x060295AD RID: 169389 RVA: 0x009C23A0 File Offset: 0x009C05A0
		// (set) Token: 0x060295AE RID: 169390 RVA: 0x009C23B0 File Offset: 0x009C05B0
		public unsafe float PostFireDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x170062CC RID: 25292
		// (get) Token: 0x060295AF RID: 169391 RVA: 0x009C23C1 File Offset: 0x009C05C1
		// (set) Token: 0x060295B0 RID: 169392 RVA: 0x009C23D1 File Offset: 0x009C05D1
		public unsafe bool EaseOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062CD RID: 25293
		// (get) Token: 0x060295B1 RID: 169393 RVA: 0x009C23E2 File Offset: 0x009C05E2
		// (set) Token: 0x060295B2 RID: 169394 RVA: 0x009C23F2 File Offset: 0x009C05F2
		public unsafe bool EaseIn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_4) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_4) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062CE RID: 25294
		// (get) Token: 0x060295B3 RID: 169395 RVA: 0x009C2403 File Offset: 0x009C0603
		// (set) Token: 0x060295B4 RID: 169396 RVA: 0x009C2413 File Offset: 0x009C0613
		public unsafe bool ForceShortestRoute
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_5) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_5) = (value ? 1 : 0);
			}
		}

		// Token: 0x170062CF RID: 25295
		// (get) Token: 0x060295B5 RID: 169397 RVA: 0x009C2424 File Offset: 0x009C0624
		// (set) Token: 0x060295B6 RID: 169398 RVA: 0x009C2434 File Offset: 0x009C0634
		public unsafe int SkillId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x170062D0 RID: 25296
		// (get) Token: 0x060295B7 RID: 169399 RVA: 0x009C2445 File Offset: 0x009C0645
		// (set) Token: 0x060295B8 RID: 169400 RVA: 0x009C2459 File Offset: 0x009C0659
		public unsafe FRotator RotateOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SDeadEyeConfig.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060295B9 RID: 169401 RVA: 0x009C246E File Offset: 0x009C066E
		public SDeadEyeConfig()
		{
		}

		// Token: 0x060295BA RID: 169402 RVA: 0x009C2478 File Offset: 0x009C0678
		public SDeadEyeConfig(float AimToleranceDeg, float AimSpeedDegPerSec, float PostFireDelay, bool EaseOut, bool EaseIn, bool ForceShortestRoute, int SkillId, FRotator RotateOffset)
		{
			this.AimToleranceDeg = AimToleranceDeg;
			this.AimSpeedDegPerSec = AimSpeedDegPerSec;
			this.PostFireDelay = PostFireDelay;
			this.EaseOut = EaseOut;
			this.EaseIn = EaseIn;
			this.ForceShortestRoute = ForceShortestRoute;
			this.SkillId = SkillId;
			this.RotateOffset = RotateOffset;
		}

		// Token: 0x060295BB RID: 169403 RVA: 0x009C24C8 File Offset: 0x009C06C8
		protected override IntPtr GetUStructPtr()
		{
			return SDeadEyeConfig.StaticStruct();
		}

		// Token: 0x060295BC RID: 169404 RVA: 0x009C24D4 File Offset: 0x009C06D4
		[NullableContext(2)]
		public SDeadEyeConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060295BD RID: 169405 RVA: 0x009C24DE File Offset: 0x009C06DE
		public SDeadEyeConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060295BE RID: 169406 RVA: 0x009C24E9 File Offset: 0x009C06E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SDeadEyeConfig(Pointer, false, true);
		}

		// Token: 0x060295BF RID: 169407 RVA: 0x009C24F3 File Offset: 0x009C06F3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SDeadEyeConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0401530B RID: 86795
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Data/Fight/Struct/SDeadEyeConfig.SDeadEyeConfig";

		// Token: 0x0401530C RID: 86796
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401530D RID: 86797
		internal static int __PropertyOffset_0;

		// Token: 0x0401530E RID: 86798
		internal static int __PropertyOffset_1;

		// Token: 0x0401530F RID: 86799
		internal static int __PropertyOffset_2;

		// Token: 0x04015310 RID: 86800
		internal static int __PropertyOffset_3;

		// Token: 0x04015311 RID: 86801
		internal static int __PropertyOffset_4;

		// Token: 0x04015312 RID: 86802
		internal static int __PropertyOffset_5;

		// Token: 0x04015313 RID: 86803
		internal static int __PropertyOffset_6;

		// Token: 0x04015314 RID: 86804
		internal static int __PropertyOffset_7;
	}
}
