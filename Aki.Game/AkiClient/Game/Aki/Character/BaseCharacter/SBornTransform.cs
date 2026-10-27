using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x020042F2 RID: 17138
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class SBornTransform : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C42A RID: 181290 RVA: 0x00A1B9C4 File Offset: 0x00A19BC4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SBornTransform._ScriptStructPtr != 0) ? SBornTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform", ref SBornTransform._ScriptStructPtr);
		}

		// Token: 0x17006E65 RID: 28261
		// (get) Token: 0x0602C42B RID: 181291 RVA: 0x00A1B9E8 File Offset: 0x00A19BE8
		// (set) Token: 0x0602C42C RID: 181292 RVA: 0x00A1B9FC File Offset: 0x00A19BFC
		public unsafe FVector Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006E66 RID: 28262
		// (get) Token: 0x0602C42D RID: 181293 RVA: 0x00A1BA11 File Offset: 0x00A19C11
		// (set) Token: 0x0602C42E RID: 181294 RVA: 0x00A1BA25 File Offset: 0x00A19C25
		public unsafe TEnumAsByte<EOffsetTargetType> OffsetTargetType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006E67 RID: 28263
		// (get) Token: 0x0602C42F RID: 181295 RVA: 0x00A1BA3A File Offset: 0x00A19C3A
		// (set) Token: 0x0602C430 RID: 181296 RVA: 0x00A1BA4E File Offset: 0x00A19C4E
		public unsafe TEnumAsByte<EBornRotateType> RotateType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006E68 RID: 28264
		// (get) Token: 0x0602C431 RID: 181297 RVA: 0x00A1BA63 File Offset: 0x00A19C63
		// (set) Token: 0x0602C432 RID: 181298 RVA: 0x00A1BA73 File Offset: 0x00A19C73
		public unsafe int RotateCameraDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006E69 RID: 28265
		// (get) Token: 0x0602C433 RID: 181299 RVA: 0x00A1BA84 File Offset: 0x00A19C84
		// (set) Token: 0x0602C434 RID: 181300 RVA: 0x00A1BAC7 File Offset: 0x00A19CC7
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
					result = (this._RotateInvalidAxis = new TArray<TEnumAsByte<ECommonAxis>>(base.NativePtr + (IntPtr)SBornTransform.__PropertyOffset_4, base.MemoryOwner ?? this));
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

		// Token: 0x0602C435 RID: 181301 RVA: 0x00A1BAD5 File Offset: 0x00A19CD5
		public SBornTransform()
		{
		}

		// Token: 0x0602C436 RID: 181302 RVA: 0x00A1BADD File Offset: 0x00A19CDD
		public SBornTransform(FVector Offset, TEnumAsByte<EOffsetTargetType> OffsetTargetType, TEnumAsByte<EBornRotateType> RotateType, int RotateCameraDistance, [Nullable(new byte[]
		{
			1,
			0
		})] TArray<TEnumAsByte<ECommonAxis>> RotateInvalidAxis)
		{
			this.Offset = Offset;
			this.OffsetTargetType = OffsetTargetType;
			this.RotateType = RotateType;
			this.RotateCameraDistance = RotateCameraDistance;
			this.RotateInvalidAxis = RotateInvalidAxis;
		}

		// Token: 0x0602C437 RID: 181303 RVA: 0x00A1BB0A File Offset: 0x00A19D0A
		protected override IntPtr GetUStructPtr()
		{
			return SBornTransform.StaticStruct();
		}

		// Token: 0x0602C438 RID: 181304 RVA: 0x00A1BB16 File Offset: 0x00A19D16
		[NullableContext(2)]
		public SBornTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C439 RID: 181305 RVA: 0x00A1BB20 File Offset: 0x00A19D20
		public SBornTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C43A RID: 181306 RVA: 0x00A1BB2B File Offset: 0x00A19D2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SBornTransform(Pointer, false, true);
		}

		// Token: 0x0602C43B RID: 181307 RVA: 0x00A1BB35 File Offset: 0x00A19D35
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SBornTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04017575 RID: 95605
		[Nullable(1)]
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SBornTransform.SBornTransform";

		// Token: 0x04017576 RID: 95606
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017577 RID: 95607
		internal static int __PropertyOffset_0;

		// Token: 0x04017578 RID: 95608
		internal static int __PropertyOffset_1;

		// Token: 0x04017579 RID: 95609
		internal static int __PropertyOffset_2;

		// Token: 0x0401757A RID: 95610
		internal static int __PropertyOffset_3;

		// Token: 0x0401757B RID: 95611
		internal static int __PropertyOffset_4;

		// Token: 0x0401757C RID: 95612
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private TArray<TEnumAsByte<ECommonAxis>> _RotateInvalidAxis;
	}
}
