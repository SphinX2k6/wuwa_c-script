using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F0 RID: 17136
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SBatchBulletPositionPointMatrix : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C3F6 RID: 181238 RVA: 0x00A1B524 File Offset: 0x00A19724
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionPointMatrix._ScriptStructPtr != 0) ? SBatchBulletPositionPointMatrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix", ref SBatchBulletPositionPointMatrix._ScriptStructPtr);
		}

		// Token: 0x17006E53 RID: 28243
		// (get) Token: 0x0602C3F7 RID: 181239 RVA: 0x00A1B548 File Offset: 0x00A19748
		// (set) Token: 0x0602C3F8 RID: 181240 RVA: 0x00A1B58B File Offset: 0x00A1978B
		public TArray<FVector> PositionOffset
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PositionOffset) == null)
				{
					result = (this._PositionOffset = new TArray<FVector>(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_0, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PositionOffset.CopyAssign(value);
			}
		}

		// Token: 0x17006E54 RID: 28244
		// (get) Token: 0x0602C3F9 RID: 181241 RVA: 0x00A1B599 File Offset: 0x00A19799
		// (set) Token: 0x0602C3FA RID: 181242 RVA: 0x00A1B5AD File Offset: 0x00A197AD
		public unsafe string CenterKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_1)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_1)), value);
			}
		}

		// Token: 0x17006E55 RID: 28245
		// (get) Token: 0x0602C3FB RID: 181243 RVA: 0x00A1B5C2 File Offset: 0x00A197C2
		// (set) Token: 0x0602C3FC RID: 181244 RVA: 0x00A1B5D6 File Offset: 0x00A197D6
		public unsafe string RotatorKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_2)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_2)), value);
			}
		}

		// Token: 0x17006E56 RID: 28246
		// (get) Token: 0x0602C3FD RID: 181245 RVA: 0x00A1B5EB File Offset: 0x00A197EB
		// (set) Token: 0x0602C3FE RID: 181246 RVA: 0x00A1B5FB File Offset: 0x00A197FB
		public unsafe float PositionOffsetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E57 RID: 28247
		// (get) Token: 0x0602C3FF RID: 181247 RVA: 0x00A1B60C File Offset: 0x00A1980C
		// (set) Token: 0x0602C400 RID: 181248 RVA: 0x00A1B620 File Offset: 0x00A19820
		public unsafe FRotator RotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006E58 RID: 28248
		// (get) Token: 0x0602C401 RID: 181249 RVA: 0x00A1B635 File Offset: 0x00A19835
		// (set) Token: 0x0602C402 RID: 181250 RVA: 0x00A1B649 File Offset: 0x00A19849
		[Nullable(0)]
		public unsafe TEnumAsByte<EBatchBulletBeginRotator> BeginRotator
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_5);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x0602C403 RID: 181251 RVA: 0x00A1B65E File Offset: 0x00A1985E
		public SBatchBulletPositionPointMatrix()
		{
		}

		// Token: 0x0602C404 RID: 181252 RVA: 0x00A1B666 File Offset: 0x00A19866
		public SBatchBulletPositionPointMatrix(TArray<FVector> PositionOffset, string CenterKey, string RotatorKey, float PositionOffsetScale, FRotator RotatorOffset, [Nullable(0)] TEnumAsByte<EBatchBulletBeginRotator> BeginRotator)
		{
			this.PositionOffset = PositionOffset;
			this.CenterKey = CenterKey;
			this.RotatorKey = RotatorKey;
			this.PositionOffsetScale = PositionOffsetScale;
			this.RotatorOffset = RotatorOffset;
			this.BeginRotator = BeginRotator;
		}

		// Token: 0x0602C405 RID: 181253 RVA: 0x00A1B69B File Offset: 0x00A1989B
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionPointMatrix.StaticStruct();
		}

		// Token: 0x0602C406 RID: 181254 RVA: 0x00A1B6A7 File Offset: 0x00A198A7
		[NullableContext(2)]
		public SBatchBulletPositionPointMatrix(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C407 RID: 181255 RVA: 0x00A1B6B1 File Offset: 0x00A198B1
		public SBatchBulletPositionPointMatrix(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C408 RID: 181256 RVA: 0x00A1B6BC File Offset: 0x00A198BC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionPointMatrix(Pointer, false, true);
		}

		// Token: 0x0602C409 RID: 181257 RVA: 0x00A1B6C6 File Offset: 0x00A198C6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionPointMatrix(Pointer, MemoryOwner);
		}

		// Token: 0x0401755E RID: 95582
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix";

		// Token: 0x0401755F RID: 95583
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017560 RID: 95584
		internal static int __PropertyOffset_0;

		// Token: 0x04017561 RID: 95585
		[Nullable(2)]
		private TArray<FVector> _PositionOffset;

		// Token: 0x04017562 RID: 95586
		internal static int __PropertyOffset_1;

		// Token: 0x04017563 RID: 95587
		internal static int __PropertyOffset_2;

		// Token: 0x04017564 RID: 95588
		internal static int __PropertyOffset_3;

		// Token: 0x04017565 RID: 95589
		internal static int __PropertyOffset_4;

		// Token: 0x04017566 RID: 95590
		internal static int __PropertyOffset_5;
	}
}
