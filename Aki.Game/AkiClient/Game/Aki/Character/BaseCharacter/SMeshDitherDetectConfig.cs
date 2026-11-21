using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200335B RID: 13147
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig")]
	[UnrealStructLayout(92, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 92)]
	public class SMeshDitherDetectConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060214E1 RID: 136417 RVA: 0x0095D94F File Offset: 0x0095BB4F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMeshDitherDetectConfig._ScriptStructPtr != 0) ? SMeshDitherDetectConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig", ref SMeshDitherDetectConfig._ScriptStructPtr);
		}

		// Token: 0x170043AA RID: 17322
		// (get) Token: 0x060214E2 RID: 136418 RVA: 0x0095D973 File Offset: 0x0095BB73
		// (set) Token: 0x060214E3 RID: 136419 RVA: 0x0095D983 File Offset: 0x0095BB83
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170043AB RID: 17323
		// (get) Token: 0x060214E4 RID: 136420 RVA: 0x0095D994 File Offset: 0x0095BB94
		// (set) Token: 0x060214E5 RID: 136421 RVA: 0x0095D9D7 File Offset: 0x0095BBD7
		public SMeshDitherDetectTraceConfig TraceConfig
		{
			get
			{
				base.FastCheckIsValid();
				SMeshDitherDetectTraceConfig result;
				if ((result = this._TraceConfig) == null)
				{
					result = (this._TraceConfig = new SMeshDitherDetectTraceConfig(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_TraceConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SMeshDitherDetectTraceConfig.StaticStruct(), base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_TraceConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043AC RID: 17324
		// (get) Token: 0x060214E6 RID: 136422 RVA: 0x0095D9F8 File Offset: 0x0095BBF8
		// (set) Token: 0x060214E7 RID: 136423 RVA: 0x0095DA3B File Offset: 0x0095BC3B
		public SDitherDistanceConfig DitherConfig
		{
			get
			{
				base.FastCheckIsValid();
				SDitherDistanceConfig result;
				if ((result = this._DitherConfig) == null)
				{
					result = (this._DitherConfig = new SDitherDistanceConfig(base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_DitherConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(SDitherDistanceConfig.StaticStruct(), base.NativePtr + (IntPtr)SMeshDitherDetectConfig.__PropertyOffset_DitherConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060214E8 RID: 136424 RVA: 0x0095DA5C File Offset: 0x0095BC5C
		public SMeshDitherDetectConfig()
		{
		}

		// Token: 0x060214E9 RID: 136425 RVA: 0x0095DA64 File Offset: 0x0095BC64
		protected override IntPtr GetUStructPtr()
		{
			return SMeshDitherDetectConfig.StaticStruct();
		}

		// Token: 0x060214EA RID: 136426 RVA: 0x0095DA70 File Offset: 0x0095BC70
		[NullableContext(2)]
		public SMeshDitherDetectConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060214EB RID: 136427 RVA: 0x0095DA7A File Offset: 0x0095BC7A
		public SMeshDitherDetectConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060214EC RID: 136428 RVA: 0x0095DA85 File Offset: 0x0095BC85
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMeshDitherDetectConfig(Pointer, false, true);
		}

		// Token: 0x060214ED RID: 136429 RVA: 0x0095DA8F File Offset: 0x0095BC8F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMeshDitherDetectConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04012340 RID: 74560
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMeshDitherDetectConfig.SMeshDitherDetectConfig";

		// Token: 0x04012341 RID: 74561
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012342 RID: 74562
		internal static int __PropertyOffset_Priority;

		// Token: 0x04012343 RID: 74563
		internal static int __PropertyOffset_TraceConfig;

		// Token: 0x04012344 RID: 74564
		[Nullable(2)]
		private SMeshDitherDetectTraceConfig _TraceConfig;

		// Token: 0x04012345 RID: 74565
		internal static int __PropertyOffset_DitherConfig;

		// Token: 0x04012346 RID: 74566
		[Nullable(2)]
		private SDitherDistanceConfig _DitherConfig;
	}
}
