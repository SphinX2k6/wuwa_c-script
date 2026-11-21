using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Character.BaseCharacter
{
	// Token: 0x02003348 RID: 13128
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class SCustomValueRecordRow : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602134E RID: 136014 RVA: 0x0095BA13 File Offset: 0x00959C13
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SCustomValueRecordRow._ScriptStructPtr != 0) ? SCustomValueRecordRow._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow", ref SCustomValueRecordRow._ScriptStructPtr);
		}

		// Token: 0x17004323 RID: 17187
		// (get) Token: 0x0602134F RID: 136015 RVA: 0x0095BA37 File Offset: 0x00959C37
		// (set) Token: 0x06021350 RID: 136016 RVA: 0x0095BA4B File Offset: 0x00959C4B
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueReturn> ReturnType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_ReturnType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_ReturnType) = value;
			}
		}

		// Token: 0x17004324 RID: 17188
		// (get) Token: 0x06021351 RID: 136017 RVA: 0x0095BA60 File Offset: 0x00959C60
		// (set) Token: 0x06021352 RID: 136018 RVA: 0x0095BA74 File Offset: 0x00959C74
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceNum> NumSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_NumSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_NumSource) = value;
			}
		}

		// Token: 0x17004325 RID: 17189
		// (get) Token: 0x06021353 RID: 136019 RVA: 0x0095BA89 File Offset: 0x00959C89
		// (set) Token: 0x06021354 RID: 136020 RVA: 0x0095BA9D File Offset: 0x00959C9D
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceVector> VecSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_VecSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_VecSource) = value;
			}
		}

		// Token: 0x17004326 RID: 17190
		// (get) Token: 0x06021355 RID: 136021 RVA: 0x0095BAB2 File Offset: 0x00959CB2
		// (set) Token: 0x06021356 RID: 136022 RVA: 0x0095BAC6 File Offset: 0x00959CC6
		[Nullable(0)]
		public unsafe TEnumAsByte<ECustomValueSourceRotator> RotSource
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_RotSource);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_RotSource) = value;
			}
		}

		// Token: 0x17004327 RID: 17191
		// (get) Token: 0x06021357 RID: 136023 RVA: 0x0095BADC File Offset: 0x00959CDC
		// (set) Token: 0x06021358 RID: 136024 RVA: 0x0095BB1F File Offset: 0x00959D1F
		public TArray<float> NumberValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._NumberValue) == null)
				{
					result = (this._NumberValue = new TArray<float>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_NumberValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NumberValue.CopyAssign(value);
			}
		}

		// Token: 0x17004328 RID: 17192
		// (get) Token: 0x06021359 RID: 136025 RVA: 0x0095BB30 File Offset: 0x00959D30
		// (set) Token: 0x0602135A RID: 136026 RVA: 0x0095BB73 File Offset: 0x00959D73
		public TArray<FVectorDouble> VectorValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVectorDouble> result;
				if ((result = this._VectorValue) == null)
				{
					result = (this._VectorValue = new TArray<FVectorDouble>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_VectorValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorValue.CopyAssign(value);
			}
		}

		// Token: 0x17004329 RID: 17193
		// (get) Token: 0x0602135B RID: 136027 RVA: 0x0095BB84 File Offset: 0x00959D84
		// (set) Token: 0x0602135C RID: 136028 RVA: 0x0095BBC7 File Offset: 0x00959DC7
		public TArray<FRotator> RotatorValue
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotator> result;
				if ((result = this._RotatorValue) == null)
				{
					result = (this._RotatorValue = new TArray<FRotator>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_RotatorValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RotatorValue.CopyAssign(value);
			}
		}

		// Token: 0x1700432A RID: 17194
		// (get) Token: 0x0602135D RID: 136029 RVA: 0x0095BBD8 File Offset: 0x00959DD8
		// (set) Token: 0x0602135E RID: 136030 RVA: 0x0095BC1B File Offset: 0x00959E1B
		public TArray<SCustomValueFormula> FormulaList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<SCustomValueFormula> result;
				if ((result = this._FormulaList) == null)
				{
					result = (this._FormulaList = new TArray<SCustomValueFormula>(base.NativePtr + (IntPtr)SCustomValueRecordRow.__PropertyOffset_FormulaList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FormulaList.CopyAssign(value);
			}
		}

		// Token: 0x1700432B RID: 17195
		// (get) Token: 0x0602135F RID: 136031 RVA: 0x0095BC29 File Offset: 0x00959E29
		// (set) Token: 0x06021360 RID: 136032 RVA: 0x0095BC3D File Offset: 0x00959E3D
		public unsafe string Notes
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueRecordRow.__PropertyOffset_Notes)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)SCustomValueRecordRow.__PropertyOffset_Notes)), value);
			}
		}

		// Token: 0x06021361 RID: 136033 RVA: 0x0095BC52 File Offset: 0x00959E52
		public SCustomValueRecordRow()
		{
		}

		// Token: 0x06021362 RID: 136034 RVA: 0x0095BC5A File Offset: 0x00959E5A
		protected override IntPtr GetUStructPtr()
		{
			return SCustomValueRecordRow.StaticStruct();
		}

		// Token: 0x06021363 RID: 136035 RVA: 0x0095BC66 File Offset: 0x00959E66
		[NullableContext(2)]
		public SCustomValueRecordRow(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06021364 RID: 136036 RVA: 0x0095BC70 File Offset: 0x00959E70
		public SCustomValueRecordRow(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06021365 RID: 136037 RVA: 0x0095BC7B File Offset: 0x00959E7B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SCustomValueRecordRow(Pointer, false, true);
		}

		// Token: 0x06021366 RID: 136038 RVA: 0x0095BC85 File Offset: 0x00959E85
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SCustomValueRecordRow(Pointer, MemoryOwner);
		}

		// Token: 0x0401227C RID: 74364
		public const string __ObjectPath = "/Game/Aki/Character/BaseCharacter/SCustomValueRecordRow.SCustomValueRecordRow";

		// Token: 0x0401227D RID: 74365
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401227E RID: 74366
		internal static int __PropertyOffset_ReturnType;

		// Token: 0x0401227F RID: 74367
		internal static int __PropertyOffset_NumSource;

		// Token: 0x04012280 RID: 74368
		internal static int __PropertyOffset_VecSource;

		// Token: 0x04012281 RID: 74369
		internal static int __PropertyOffset_RotSource;

		// Token: 0x04012282 RID: 74370
		internal static int __PropertyOffset_NumberValue;

		// Token: 0x04012283 RID: 74371
		[Nullable(2)]
		private TArray<float> _NumberValue;

		// Token: 0x04012284 RID: 74372
		internal static int __PropertyOffset_VectorValue;

		// Token: 0x04012285 RID: 74373
		[Nullable(2)]
		private TArray<FVectorDouble> _VectorValue;

		// Token: 0x04012286 RID: 74374
		internal static int __PropertyOffset_RotatorValue;

		// Token: 0x04012287 RID: 74375
		[Nullable(2)]
		private TArray<FRotator> _RotatorValue;

		// Token: 0x04012288 RID: 74376
		internal static int __PropertyOffset_FormulaList;

		// Token: 0x04012289 RID: 74377
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<SCustomValueFormula> _FormulaList;

		// Token: 0x0401228A RID: 74378
		internal static int __PropertyOffset_Notes;
	}
}
