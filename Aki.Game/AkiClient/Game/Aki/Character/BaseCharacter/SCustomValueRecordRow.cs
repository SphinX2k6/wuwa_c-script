using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x0200430A RID: 17162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SCustomValueRecordRow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602C627 RID: 181799 RVA: 0x00A1E9AD File Offset: 0x00A1CBAD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCustomValueRecordRow._ScriptStructPtr != 0) ? SCustomValueRecordRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow", ref SCustomValueRecordRow._ScriptStructPtr);
		}

		// Token: 0x17006F05 RID: 28421
		// (get) Token: 0x0602C628 RID: 181800 RVA: 0x00A1E9D1 File Offset: 0x00A1CBD1
		// (set) Token: 0x0602C629 RID: 181801 RVA: 0x00A1E9E5 File Offset: 0x00A1CBE5
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueReturn> ReturnType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_0);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x17006F06 RID: 28422
		// (get) Token: 0x0602C62A RID: 181802 RVA: 0x00A1E9FA File Offset: 0x00A1CBFA
		// (set) Token: 0x0602C62B RID: 181803 RVA: 0x00A1EA0E File Offset: 0x00A1CC0E
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceNum> NumSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_1);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_1) = value;
			}
		}

		// Token: 0x17006F07 RID: 28423
		// (get) Token: 0x0602C62C RID: 181804 RVA: 0x00A1EA23 File Offset: 0x00A1CC23
		// (set) Token: 0x0602C62D RID: 181805 RVA: 0x00A1EA37 File Offset: 0x00A1CC37
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceVector> VecSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_2);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_2) = value;
			}
		}

		// Token: 0x17006F08 RID: 28424
		// (get) Token: 0x0602C62E RID: 181806 RVA: 0x00A1EA4C File Offset: 0x00A1CC4C
		// (set) Token: 0x0602C62F RID: 181807 RVA: 0x00A1EA60 File Offset: 0x00A1CC60
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceRotator> RotSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_3);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_3) = value;
			}
		}

		// Token: 0x17006F09 RID: 28425
		// (get) Token: 0x0602C630 RID: 181808 RVA: 0x00A1EA78 File Offset: 0x00A1CC78
		// (set) Token: 0x0602C631 RID: 181809 RVA: 0x00A1EABB File Offset: 0x00A1CCBB
		public TArray<float> NumberValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._NumberValue) == null)
				{
					result = (this._NumberValue = new TArray<float>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_4, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NumberValue.CopyAssign(value);
			}
		}

		// Token: 0x17006F0A RID: 28426
		// (get) Token: 0x0602C632 RID: 181810 RVA: 0x00A1EACC File Offset: 0x00A1CCCC
		// (set) Token: 0x0602C633 RID: 181811 RVA: 0x00A1EB0F File Offset: 0x00A1CD0F
		public TArray<FVectorDouble> VectorValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._VectorValue) == null)
				{
					result = (this._VectorValue = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_5, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorValue.CopyAssign(value);
			}
		}

		// Token: 0x17006F0B RID: 28427
		// (get) Token: 0x0602C634 RID: 181812 RVA: 0x00A1EB20 File Offset: 0x00A1CD20
		// (set) Token: 0x0602C635 RID: 181813 RVA: 0x00A1EB63 File Offset: 0x00A1CD63
		public TArray<FRotator> RotatorValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotator> result;
				if ((result = this._RotatorValue) == null)
				{
					result = (this._RotatorValue = new TArray<FRotator>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_6, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotatorValue.CopyAssign(value);
			}
		}

		// Token: 0x17006F0C RID: 28428
		// (get) Token: 0x0602C636 RID: 181814 RVA: 0x00A1EB74 File Offset: 0x00A1CD74
		// (set) Token: 0x0602C637 RID: 181815 RVA: 0x00A1EBB7 File Offset: 0x00A1CDB7
		public TArray<SCustomValueFormula> FormulaList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCustomValueFormula> result;
				if ((result = this._FormulaList) == null)
				{
					result = (this._FormulaList = new TArray<SCustomValueFormula>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_7, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FormulaList.CopyAssign(value);
			}
		}

		// Token: 0x17006F0D RID: 28429
		// (get) Token: 0x0602C638 RID: 181816 RVA: 0x00A1EBC5 File Offset: 0x00A1CDC5
		// (set) Token: 0x0602C639 RID: 181817 RVA: 0x00A1EBD9 File Offset: 0x00A1CDD9
		public unsafe string Notes
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueRecordRow.__PropertyOffset_8)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueRecordRow.__PropertyOffset_8)), value);
			}
		}

		// Token: 0x0602C63A RID: 181818 RVA: 0x00A1EBEE File Offset: 0x00A1CDEE
		public SCustomValueRecordRow()
		{
		}

		// Token: 0x0602C63B RID: 181819 RVA: 0x00A1EBF8 File Offset: 0x00A1CDF8
		public SCustomValueRecordRow([Nullable(0)] TEnumAsByte<ECustomValueReturn> ReturnType, [Nullable(0)] TEnumAsByte<ECustomValueSourceNum> NumSource, [Nullable(0)] TEnumAsByte<ECustomValueSourceVector> VecSource, [Nullable(0)] TEnumAsByte<ECustomValueSourceRotator> RotSource, TArray<float> NumberValue, TArray<FVectorDouble> VectorValue, TArray<FRotator> RotatorValue, TArray<SCustomValueFormula> FormulaList, string Notes)
		{
			this.ReturnType = ReturnType;
			this.NumSource = NumSource;
			this.VecSource = VecSource;
			this.RotSource = RotSource;
			this.NumberValue = NumberValue;
			this.VectorValue = VectorValue;
			this.RotatorValue = RotatorValue;
			this.FormulaList = FormulaList;
			this.Notes = Notes;
		}

		// Token: 0x0602C63C RID: 181820 RVA: 0x00A1EC50 File Offset: 0x00A1CE50
		protected override IntPtr GetUStructPtr()
		{
			return SCustomValueRecordRow.StaticStruct();
		}

		// Token: 0x0602C63D RID: 181821 RVA: 0x00A1EC5C File Offset: 0x00A1CE5C
		[NullableContext(2)]
		public SCustomValueRecordRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602C63E RID: 181822 RVA: 0x00A1EC66 File Offset: 0x00A1CE66
		public SCustomValueRecordRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602C63F RID: 181823 RVA: 0x00A1EC71 File Offset: 0x00A1CE71
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCustomValueRecordRow(Pointer, false, true);
		}

		// Token: 0x0602C640 RID: 181824 RVA: 0x00A1EC7B File Offset: 0x00A1CE7B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCustomValueRecordRow(Pointer, MemoryOwner);
		}

		// Token: 0x04017673 RID: 95859
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow";

		// Token: 0x04017674 RID: 95860
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04017675 RID: 95861
		internal static int __PropertyOffset_0;

		// Token: 0x04017676 RID: 95862
		internal static int __PropertyOffset_1;

		// Token: 0x04017677 RID: 95863
		internal static int __PropertyOffset_2;

		// Token: 0x04017678 RID: 95864
		internal static int __PropertyOffset_3;

		// Token: 0x04017679 RID: 95865
		internal static int __PropertyOffset_4;

		// Token: 0x0401767A RID: 95866
		[Nullable(2)]
		private TArray<float> _NumberValue;

		// Token: 0x0401767B RID: 95867
		internal static int __PropertyOffset_5;

		// Token: 0x0401767C RID: 95868
		[Nullable(2)]
		private TArray<FVectorDouble> _VectorValue;

		// Token: 0x0401767D RID: 95869
		internal static int __PropertyOffset_6;

		// Token: 0x0401767E RID: 95870
		[Nullable(2)]
		private TArray<FRotator> _RotatorValue;

		// Token: 0x0401767F RID: 95871
		internal static int __PropertyOffset_7;

		// Token: 0x04017680 RID: 95872
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCustomValueFormula> _FormulaList;

		// Token: 0x04017681 RID: 95873
		internal static int __PropertyOffset_8;
	}
}
