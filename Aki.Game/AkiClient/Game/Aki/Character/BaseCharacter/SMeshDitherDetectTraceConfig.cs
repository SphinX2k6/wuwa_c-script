using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02004323 RID: 17187
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig")]
	[UnrealStructLayout(72, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 69)]
	public class SMeshDitherDetectTraceConfig : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C7E4 RID: 182244 RVA: 0x00A20FE5 File Offset: 0x00A1F1E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SMeshDitherDetectTraceConfig._ScriptStructPtr != 0) ? SMeshDitherDetectTraceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig", ref SMeshDitherDetectTraceConfig._ScriptStructPtr);
		}

		// Token: 0x17006F82 RID: 28546
		// (get) Token: 0x0602C7E5 RID: 182245 RVA: 0x00A21009 File Offset: 0x00A1F209
		// (set) Token: 0x0602C7E6 RID: 182246 RVA: 0x00A2101D File Offset: 0x00A1F21D
		public unsafe FName BaseBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F83 RID: 28547
		// (get) Token: 0x0602C7E7 RID: 182247 RVA: 0x00A21032 File Offset: 0x00A1F232
		// (set) Token: 0x0602C7E8 RID: 182248 RVA: 0x00A21046 File Offset: 0x00A1F246
		public unsafe FName TargetBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F84 RID: 28548
		// (get) Token: 0x0602C7E9 RID: 182249 RVA: 0x00A2105B File Offset: 0x00A1F25B
		// (set) Token: 0x0602C7EA RID: 182250 RVA: 0x00A2106F File Offset: 0x00A1F26F
		public unsafe FName BasisBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F85 RID: 28549
		// (get) Token: 0x0602C7EB RID: 182251 RVA: 0x00A21084 File Offset: 0x00A1F284
		// (set) Token: 0x0602C7EC RID: 182252 RVA: 0x00A21098 File Offset: 0x00A1F298
		public unsafe FVector2D AdditionCapsuleSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F86 RID: 28550
		// (get) Token: 0x0602C7ED RID: 182253 RVA: 0x00A210AD File Offset: 0x00A1F2AD
		// (set) Token: 0x0602C7EE RID: 182254 RVA: 0x00A210C1 File Offset: 0x00A1F2C1
		public unsafe FVector AdditionCapsuleOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006F87 RID: 28551
		// (get) Token: 0x0602C7EF RID: 182255 RVA: 0x00A210D6 File Offset: 0x00A1F2D6
		// (set) Token: 0x0602C7F0 RID: 182256 RVA: 0x00A210EA File Offset: 0x00A1F2EA
		public unsafe FRotator AdditionCapsuleRotator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006F88 RID: 28552
		// (get) Token: 0x0602C7F1 RID: 182257 RVA: 0x00A210FF File Offset: 0x00A1F2FF
		// (set) Token: 0x0602C7F2 RID: 182258 RVA: 0x00A2110F File Offset: 0x00A1F30F
		public unsafe bool Debug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_6) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SMeshDitherDetectTraceConfig.__PropertyOffset_6) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602C7F3 RID: 182259 RVA: 0x00A21120 File Offset: 0x00A1F320
		public SMeshDitherDetectTraceConfig()
		{
		}

		// Token: 0x0602C7F4 RID: 182260 RVA: 0x00A21128 File Offset: 0x00A1F328
		public SMeshDitherDetectTraceConfig(FName BaseBoneName, FName TargetBoneName, FName BasisBoneName, FVector2D AdditionCapsuleSize, FVector AdditionCapsuleOffset, FRotator AdditionCapsuleRotator, bool Debug)
		{
			this.BaseBoneName = BaseBoneName;
			this.TargetBoneName = TargetBoneName;
			this.BasisBoneName = BasisBoneName;
			this.AdditionCapsuleSize = AdditionCapsuleSize;
			this.AdditionCapsuleOffset = AdditionCapsuleOffset;
			this.AdditionCapsuleRotator = AdditionCapsuleRotator;
			this.Debug = Debug;
		}

		// Token: 0x0602C7F5 RID: 182261 RVA: 0x00A21165 File Offset: 0x00A1F365
		protected override IntPtr GetUStructPtr()
		{
			return SMeshDitherDetectTraceConfig.StaticStruct();
		}

		// Token: 0x0602C7F6 RID: 182262 RVA: 0x00A21171 File Offset: 0x00A1F371
		[NullableContext(2)]
		public SMeshDitherDetectTraceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C7F7 RID: 182263 RVA: 0x00A2117B File Offset: 0x00A1F37B
		public SMeshDitherDetectTraceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C7F8 RID: 182264 RVA: 0x00A21186 File Offset: 0x00A1F386
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SMeshDitherDetectTraceConfig(Pointer, false, true);
		}

		// Token: 0x0602C7F9 RID: 182265 RVA: 0x00A21190 File Offset: 0x00A1F390
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SMeshDitherDetectTraceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04017743 RID: 96067
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SMeshDitherDetectTraceConfig.SMeshDitherDetectTraceConfig";

		// Token: 0x04017744 RID: 96068
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017745 RID: 96069
		internal static int __PropertyOffset_0;

		// Token: 0x04017746 RID: 96070
		internal static int __PropertyOffset_1;

		// Token: 0x04017747 RID: 96071
		internal static int __PropertyOffset_2;

		// Token: 0x04017748 RID: 96072
		internal static int __PropertyOffset_3;

		// Token: 0x04017749 RID: 96073
		internal static int __PropertyOffset_4;

		// Token: 0x0401774A RID: 96074
		internal static int __PropertyOffset_5;

		// Token: 0x0401774B RID: 96075
		internal static int __PropertyOffset_6;
	}
}
