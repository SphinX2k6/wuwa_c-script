using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200333A RID: 13114
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SBornTransform : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602123E RID: 135742 RVA: 0x0095A207 File Offset: 0x00958407
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBornTransform._ScriptStructPtr != 0) ? SBornTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform", ref SBornTransform._ScriptStructPtr);
		}

		// Token: 0x170042CC RID: 17100
		// (get) Token: 0x0602123F RID: 135743 RVA: 0x0095A22B File Offset: 0x0095842B
		// (set) Token: 0x06021240 RID: 135744 RVA: 0x0095A23F File Offset: 0x0095843F
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x170042CD RID: 17101
		// (get) Token: 0x06021241 RID: 135745 RVA: 0x0095A254 File Offset: 0x00958454
		// (set) Token: 0x06021242 RID: 135746 RVA: 0x0095A268 File Offset: 0x00958468
		public unsafe TEnumAsByte<EOffsetTargetType> OffsetTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_OffsetTargetType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_OffsetTargetType) = value;
			}
		}

		// Token: 0x170042CE RID: 17102
		// (get) Token: 0x06021243 RID: 135747 RVA: 0x0095A27D File Offset: 0x0095847D
		// (set) Token: 0x06021244 RID: 135748 RVA: 0x0095A291 File Offset: 0x00958491
		public unsafe TEnumAsByte<EBornRotateType> RotateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_RotateType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_RotateType) = value;
			}
		}

		// Token: 0x170042CF RID: 17103
		// (get) Token: 0x06021245 RID: 135749 RVA: 0x0095A2A6 File Offset: 0x009584A6
		// (set) Token: 0x06021246 RID: 135750 RVA: 0x0095A2B6 File Offset: 0x009584B6
		public unsafe int RotateCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_RotateCameraDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_RotateCameraDistance) = value;
			}
		}

		// Token: 0x170042D0 RID: 17104
		// (get) Token: 0x06021247 RID: 135751 RVA: 0x0095A2C8 File Offset: 0x009584C8
		// (set) Token: 0x06021248 RID: 135752 RVA: 0x0095A30B File Offset: 0x0095850B
		[Nullable(new byte[]
		{
			1,
			0
		})]
		public TArray<TEnumAsByte<ECommonAxis>> RotateInvalidAxis
		{
			[return: Nullable(new byte[]
			{
				1,
				0
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TEnumAsByte<ECommonAxis>> result;
				if ((result = this._RotateInvalidAxis) == null)
				{
					result = (this._RotateInvalidAxis = new TArray<TEnumAsByte<ECommonAxis>>(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_RotateInvalidAxis, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0
			})]
			set
			{
				this.RotateInvalidAxis.CopyAssign(value);
			}
		}

		// Token: 0x06021249 RID: 135753 RVA: 0x0095A319 File Offset: 0x00958519
		public SBornTransform()
		{
		}

		// Token: 0x0602124A RID: 135754 RVA: 0x0095A321 File Offset: 0x00958521
		protected override IntPtr GetUStructPtr()
		{
			return SBornTransform.StaticStruct();
		}

		// Token: 0x0602124B RID: 135755 RVA: 0x0095A32D File Offset: 0x0095852D
		[NullableContext(2)]
		public SBornTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602124C RID: 135756 RVA: 0x0095A337 File Offset: 0x00958537
		public SBornTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602124D RID: 135757 RVA: 0x0095A342 File Offset: 0x00958542
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBornTransform(Pointer, false, true);
		}

		// Token: 0x0602124E RID: 135758 RVA: 0x0095A34C File Offset: 0x0095854C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBornTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040121E9 RID: 74217
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform";

		// Token: 0x040121EA RID: 74218
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040121EB RID: 74219
		internal static int __PropertyOffset_Offset;

		// Token: 0x040121EC RID: 74220
		internal static int __PropertyOffset_OffsetTargetType;

		// Token: 0x040121ED RID: 74221
		internal static int __PropertyOffset_RotateType;

		// Token: 0x040121EE RID: 74222
		internal static int __PropertyOffset_RotateCameraDistance;

		// Token: 0x040121EF RID: 74223
		internal static int __PropertyOffset_RotateInvalidAxis;

		// Token: 0x040121F0 RID: 74224
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECommonAxis>> _RotateInvalidAxis;
	}
}
