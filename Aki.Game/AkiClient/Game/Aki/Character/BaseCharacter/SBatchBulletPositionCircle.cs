using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042EF RID: 17135
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class SBatchBulletPositionCircle : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C3DC RID: 181212 RVA: 0x00A1B30A File Offset: 0x00A1950A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionCircle._ScriptStructPtr != 0) ? SBatchBulletPositionCircle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle", ref SBatchBulletPositionCircle._ScriptStructPtr);
		}

		// Token: 0x17006E4A RID: 28234
		// (get) Token: 0x0602C3DD RID: 181213 RVA: 0x00A1B32E File Offset: 0x00A1952E
		// (set) Token: 0x0602C3DE RID: 181214 RVA: 0x00A1B342 File Offset: 0x00A19542
		public unsafe string CenterKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_0)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_0)), value);
			}
		}

		// Token: 0x17006E4B RID: 28235
		// (get) Token: 0x0602C3DF RID: 181215 RVA: 0x00A1B357 File Offset: 0x00A19557
		// (set) Token: 0x0602C3E0 RID: 181216 RVA: 0x00A1B36B File Offset: 0x00A1956B
		public unsafe string RadiusKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006E4C RID: 28236
		// (get) Token: 0x0602C3E1 RID: 181217 RVA: 0x00A1B380 File Offset: 0x00A19580
		// (set) Token: 0x0602C3E2 RID: 181218 RVA: 0x00A1B394 File Offset: 0x00A19594
		public unsafe string ForwardKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006E4D RID: 28237
		// (get) Token: 0x0602C3E3 RID: 181219 RVA: 0x00A1B3A9 File Offset: 0x00A195A9
		// (set) Token: 0x0602C3E4 RID: 181220 RVA: 0x00A1B3B9 File Offset: 0x00A195B9
		public unsafe bool Clockwise
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_3) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_3) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006E4E RID: 28238
		// (get) Token: 0x0602C3E5 RID: 181221 RVA: 0x00A1B3CA File Offset: 0x00A195CA
		// (set) Token: 0x0602C3E6 RID: 181222 RVA: 0x00A1B3DA File Offset: 0x00A195DA
		public unsafe float BeginAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006E4F RID: 28239
		// (get) Token: 0x0602C3E7 RID: 181223 RVA: 0x00A1B3EB File Offset: 0x00A195EB
		// (set) Token: 0x0602C3E8 RID: 181224 RVA: 0x00A1B3FF File Offset: 0x00A195FF
		public unsafe string AngleIntervalKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_5)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_5)), value);
			}
		}

		// Token: 0x17006E50 RID: 28240
		// (get) Token: 0x0602C3E9 RID: 181225 RVA: 0x00A1B414 File Offset: 0x00A19614
		// (set) Token: 0x0602C3EA RID: 181226 RVA: 0x00A1B428 File Offset: 0x00A19628
		[Nullable(0)]
		public unsafe TEnumAsByte<EBatchBulletBeginRotator> BeginRotator
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_6);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionCircle.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006E51 RID: 28241
		// (get) Token: 0x0602C3EB RID: 181227 RVA: 0x00A1B43D File Offset: 0x00A1963D
		// (set) Token: 0x0602C3EC RID: 181228 RVA: 0x00A1B451 File Offset: 0x00A19651
		public unsafe string StartPosKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_7)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_7)), value);
			}
		}

		// Token: 0x17006E52 RID: 28242
		// (get) Token: 0x0602C3ED RID: 181229 RVA: 0x00A1B466 File Offset: 0x00A19666
		// (set) Token: 0x0602C3EE RID: 181230 RVA: 0x00A1B47A File Offset: 0x00A1967A
		public unsafe string DistToTarget
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionCircle.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x0602C3EF RID: 181231 RVA: 0x00A1B48F File Offset: 0x00A1968F
		public SBatchBulletPositionCircle()
		{
		}

		// Token: 0x0602C3F0 RID: 181232 RVA: 0x00A1B498 File Offset: 0x00A19698
		public SBatchBulletPositionCircle(string CenterKey, string RadiusKey, string ForwardKey, bool Clockwise, float BeginAngle, string AngleIntervalKey, [Nullable(0)] TEnumAsByte<EBatchBulletBeginRotator> BeginRotator, string StartPosKey, string DistToTarget)
		{
			this.CenterKey = CenterKey;
			this.RadiusKey = RadiusKey;
			this.ForwardKey = ForwardKey;
			this.Clockwise = Clockwise;
			this.BeginAngle = BeginAngle;
			this.AngleIntervalKey = AngleIntervalKey;
			this.BeginRotator = BeginRotator;
			this.StartPosKey = StartPosKey;
			this.DistToTarget = DistToTarget;
		}

		// Token: 0x0602C3F1 RID: 181233 RVA: 0x00A1B4F0 File Offset: 0x00A196F0
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionCircle.StaticStruct();
		}

		// Token: 0x0602C3F2 RID: 181234 RVA: 0x00A1B4FC File Offset: 0x00A196FC
		[NullableContext(2)]
		public SBatchBulletPositionCircle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C3F3 RID: 181235 RVA: 0x00A1B506 File Offset: 0x00A19706
		public SBatchBulletPositionCircle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C3F4 RID: 181236 RVA: 0x00A1B511 File Offset: 0x00A19711
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionCircle(Pointer, false, true);
		}

		// Token: 0x0602C3F5 RID: 181237 RVA: 0x00A1B51B File Offset: 0x00A1971B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionCircle(Pointer, MemoryOwner);
		}

		// Token: 0x04017553 RID: 95571
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionCircle.SBatchBulletPositionCircle";

		// Token: 0x04017554 RID: 95572
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017555 RID: 95573
		internal static int __PropertyOffset_0;

		// Token: 0x04017556 RID: 95574
		internal static int __PropertyOffset_1;

		// Token: 0x04017557 RID: 95575
		internal static int __PropertyOffset_2;

		// Token: 0x04017558 RID: 95576
		internal static int __PropertyOffset_3;

		// Token: 0x04017559 RID: 95577
		internal static int __PropertyOffset_4;

		// Token: 0x0401755A RID: 95578
		internal static int __PropertyOffset_5;

		// Token: 0x0401755B RID: 95579
		internal static int __PropertyOffset_6;

		// Token: 0x0401755C RID: 95580
		internal static int __PropertyOffset_7;

		// Token: 0x0401755D RID: 95581
		internal static int __PropertyOffset_8;
	}
}
