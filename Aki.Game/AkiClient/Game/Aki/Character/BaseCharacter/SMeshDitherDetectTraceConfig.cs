using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335C RID: 13148
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 69)]
	public class SMeshDitherDetectTraceConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214EE RID: 136430 RVA: 0x0095DA98 File Offset: 0x0095BC98
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMeshDitherDetectTraceConfig._ScriptStructPtr != 0) ? SMeshDitherDetectTraceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig", ref SMeshDitherDetectTraceConfig._ScriptStructPtr);
		}

		// Token: 0x170043AD RID: 17325
		// (get) Token: 0x060214EF RID: 136431 RVA: 0x0095DABC File Offset: 0x0095BCBC
		// (set) Token: 0x060214F0 RID: 136432 RVA: 0x0095DAD0 File Offset: 0x0095BCD0
		public unsafe FName BaseBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_BaseBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_BaseBoneName) = value;
			}
		}

		// Token: 0x170043AE RID: 17326
		// (get) Token: 0x060214F1 RID: 136433 RVA: 0x0095DAE5 File Offset: 0x0095BCE5
		// (set) Token: 0x060214F2 RID: 136434 RVA: 0x0095DAF9 File Offset: 0x0095BCF9
		public unsafe FName TargetBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_TargetBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_TargetBoneName) = value;
			}
		}

		// Token: 0x170043AF RID: 17327
		// (get) Token: 0x060214F3 RID: 136435 RVA: 0x0095DB0E File Offset: 0x0095BD0E
		// (set) Token: 0x060214F4 RID: 136436 RVA: 0x0095DB22 File Offset: 0x0095BD22
		public unsafe FName BasisBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_BasisBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_BasisBoneName) = value;
			}
		}

		// Token: 0x170043B0 RID: 17328
		// (get) Token: 0x060214F5 RID: 136437 RVA: 0x0095DB37 File Offset: 0x0095BD37
		// (set) Token: 0x060214F6 RID: 136438 RVA: 0x0095DB4B File Offset: 0x0095BD4B
		public unsafe FVector2D AdditionCapsuleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleSize) = value;
			}
		}

		// Token: 0x170043B1 RID: 17329
		// (get) Token: 0x060214F7 RID: 136439 RVA: 0x0095DB60 File Offset: 0x0095BD60
		// (set) Token: 0x060214F8 RID: 136440 RVA: 0x0095DB74 File Offset: 0x0095BD74
		public unsafe FVector AdditionCapsuleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleOffset) = value;
			}
		}

		// Token: 0x170043B2 RID: 17330
		// (get) Token: 0x060214F9 RID: 136441 RVA: 0x0095DB89 File Offset: 0x0095BD89
		// (set) Token: 0x060214FA RID: 136442 RVA: 0x0095DB9D File Offset: 0x0095BD9D
		public unsafe FRotator AdditionCapsuleRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleRotator);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_AdditionCapsuleRotator) = value;
			}
		}

		// Token: 0x170043B3 RID: 17331
		// (get) Token: 0x060214FB RID: 136443 RVA: 0x0095DBB2 File Offset: 0x0095BDB2
		// (set) Token: 0x060214FC RID: 136444 RVA: 0x0095DBC2 File Offset: 0x0095BDC2
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_Debug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_Debug) = (value ? 1 : 0);
			}
		}

		// Token: 0x060214FD RID: 136445 RVA: 0x0095DBD3 File Offset: 0x0095BDD3
		public SMeshDitherDetectTraceConfig()
		{
		}

		// Token: 0x060214FE RID: 136446 RVA: 0x0095DBDB File Offset: 0x0095BDDB
		protected override IntPtr GetUStructPtr()
		{
			return SMeshDitherDetectTraceConfig.StaticStruct();
		}

		// Token: 0x060214FF RID: 136447 RVA: 0x0095DBE7 File Offset: 0x0095BDE7
		[NullableContext(2)]
		public SMeshDitherDetectTraceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021500 RID: 136448 RVA: 0x0095DBF1 File Offset: 0x0095BDF1
		public SMeshDitherDetectTraceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021501 RID: 136449 RVA: 0x0095DBFC File Offset: 0x0095BDFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMeshDitherDetectTraceConfig(Pointer, false, true);
		}

		// Token: 0x06021502 RID: 136450 RVA: 0x0095DC06 File Offset: 0x0095BE06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMeshDitherDetectTraceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04012347 RID: 74567
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig";

		// Token: 0x04012348 RID: 74568
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012349 RID: 74569
		internal static int __PropertyOffset_BaseBoneName;

		// Token: 0x0401234A RID: 74570
		internal static int __PropertyOffset_TargetBoneName;

		// Token: 0x0401234B RID: 74571
		internal static int __PropertyOffset_BasisBoneName;

		// Token: 0x0401234C RID: 74572
		internal static int __PropertyOffset_AdditionCapsuleSize;

		// Token: 0x0401234D RID: 74573
		internal static int __PropertyOffset_AdditionCapsuleOffset;

		// Token: 0x0401234E RID: 74574
		internal static int __PropertyOffset_AdditionCapsuleRotator;

		// Token: 0x0401234F RID: 74575
		internal static int __PropertyOffset_Debug;
	}
}
