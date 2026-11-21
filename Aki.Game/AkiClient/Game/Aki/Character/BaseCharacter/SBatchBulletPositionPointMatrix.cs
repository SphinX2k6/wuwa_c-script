using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003338 RID: 13112
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 65)]
	public class SBatchBulletPositionPointMatrix : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602120C RID: 135692 RVA: 0x00959E0A File Offset: 0x0095800A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBatchBulletPositionPointMatrix._ScriptStructPtr != 0) ? SBatchBulletPositionPointMatrix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix", ref SBatchBulletPositionPointMatrix._ScriptStructPtr);
		}

		// Token: 0x170042BA RID: 17082
		// (get) Token: 0x0602120D RID: 135693 RVA: 0x00959E30 File Offset: 0x00958030
		// (set) Token: 0x0602120E RID: 135694 RVA: 0x00959E73 File Offset: 0x00958073
		public TArray<FVector> PositionOffset
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PositionOffset) == null)
				{
					result = (this._PositionOffset = new TArray<FVector>(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_PositionOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PositionOffset.CopyAssign(value);
			}
		}

		// Token: 0x170042BB RID: 17083
		// (get) Token: 0x0602120F RID: 135695 RVA: 0x00959E81 File Offset: 0x00958081
		// (set) Token: 0x06021210 RID: 135696 RVA: 0x00959E95 File Offset: 0x00958095
		public unsafe string CenterKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_CenterKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_CenterKey)), value);
			}
		}

		// Token: 0x170042BC RID: 17084
		// (get) Token: 0x06021211 RID: 135697 RVA: 0x00959EAA File Offset: 0x009580AA
		// (set) Token: 0x06021212 RID: 135698 RVA: 0x00959EBE File Offset: 0x009580BE
		public unsafe string RotatorKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_RotatorKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_RotatorKey)), value);
			}
		}

		// Token: 0x170042BD RID: 17085
		// (get) Token: 0x06021213 RID: 135699 RVA: 0x00959ED3 File Offset: 0x009580D3
		// (set) Token: 0x06021214 RID: 135700 RVA: 0x00959EE3 File Offset: 0x009580E3
		public unsafe float PositionOffsetScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_PositionOffsetScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_PositionOffsetScale) = value;
			}
		}

		// Token: 0x170042BE RID: 17086
		// (get) Token: 0x06021215 RID: 135701 RVA: 0x00959EF4 File Offset: 0x009580F4
		// (set) Token: 0x06021216 RID: 135702 RVA: 0x00959F08 File Offset: 0x00958108
		public unsafe FRotator RotatorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_RotatorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_RotatorOffset) = value;
			}
		}

		// Token: 0x170042BF RID: 17087
		// (get) Token: 0x06021217 RID: 135703 RVA: 0x00959F1D File Offset: 0x0095811D
		// (set) Token: 0x06021218 RID: 135704 RVA: 0x00959F31 File Offset: 0x00958131
		[Nullable(0)]
		public unsafe TEnumAsByte<EBatchBulletBeginRotator> BeginRotator
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_BeginRotator);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SBatchBulletPositionPointMatrix.__PropertyOffset_BeginRotator) = value;
			}
		}

		// Token: 0x06021219 RID: 135705 RVA: 0x00959F46 File Offset: 0x00958146
		public SBatchBulletPositionPointMatrix()
		{
		}

		// Token: 0x0602121A RID: 135706 RVA: 0x00959F4E File Offset: 0x0095814E
		protected override IntPtr GetUStructPtr()
		{
			return SBatchBulletPositionPointMatrix.StaticStruct();
		}

		// Token: 0x0602121B RID: 135707 RVA: 0x00959F5A File Offset: 0x0095815A
		[NullableContext(2)]
		public SBatchBulletPositionPointMatrix(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602121C RID: 135708 RVA: 0x00959F64 File Offset: 0x00958164
		public SBatchBulletPositionPointMatrix(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602121D RID: 135709 RVA: 0x00959F6F File Offset: 0x0095816F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBatchBulletPositionPointMatrix(Pointer, false, true);
		}

		// Token: 0x0602121E RID: 135710 RVA: 0x00959F79 File Offset: 0x00958179
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBatchBulletPositionPointMatrix(Pointer, MemoryOwner);
		}

		// Token: 0x040121D2 RID: 74194
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBatchBulletPositionPointMatrix.SBatchBulletPositionPointMatrix";

		// Token: 0x040121D3 RID: 74195
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121D4 RID: 74196
		internal static int __PropertyOffset_PositionOffset;

		// Token: 0x040121D5 RID: 74197
		[Nullable(2)]
		private TArray<FVector> _PositionOffset;

		// Token: 0x040121D6 RID: 74198
		internal static int __PropertyOffset_CenterKey;

		// Token: 0x040121D7 RID: 74199
		internal static int __PropertyOffset_RotatorKey;

		// Token: 0x040121D8 RID: 74200
		internal static int __PropertyOffset_PositionOffsetScale;

		// Token: 0x040121D9 RID: 74201
		internal static int __PropertyOffset_RotatorOffset;

		// Token: 0x040121DA RID: 74202
		internal static int __PropertyOffset_BeginRotator;
	}
}
