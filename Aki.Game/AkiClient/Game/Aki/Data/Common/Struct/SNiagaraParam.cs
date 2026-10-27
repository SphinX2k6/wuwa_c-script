using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x02003FA4 RID: 16292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SNiagaraParam : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060299EE RID: 170478 RVA: 0x009C8D9E File Offset: 0x009C6F9E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNiagaraParam._ScriptStructPtr != 0) ? SNiagaraParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam", ref SNiagaraParam._ScriptStructPtr);
		}

		// Token: 0x1700643D RID: 25661
		// (get) Token: 0x060299EF RID: 170479 RVA: 0x009C8DC2 File Offset: 0x009C6FC2
		// (set) Token: 0x060299F0 RID: 170480 RVA: 0x009C8DD2 File Offset: 0x009C6FD2
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_0) = value;
			}
		}

		// Token: 0x1700643E RID: 25662
		// (get) Token: 0x060299F1 RID: 170481 RVA: 0x009C8DE4 File Offset: 0x009C6FE4
		// (set) Token: 0x060299F2 RID: 170482 RVA: 0x009C8E27 File Offset: 0x009C7027
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_1, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x1700643F RID: 25663
		// (get) Token: 0x060299F3 RID: 170483 RVA: 0x009C8E38 File Offset: 0x009C7038
		// (set) Token: 0x060299F4 RID: 170484 RVA: 0x009C8E7B File Offset: 0x009C707B
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_2, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006440 RID: 25664
		// (get) Token: 0x060299F5 RID: 170485 RVA: 0x009C8E8C File Offset: 0x009C708C
		// (set) Token: 0x060299F6 RID: 170486 RVA: 0x009C8ECF File Offset: 0x009C70CF
		public TMap<FName, FKuroCurveVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FKuroCurveVector>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17006441 RID: 25665
		// (get) Token: 0x060299F7 RID: 170487 RVA: 0x009C8EDD File Offset: 0x009C70DD
		// (set) Token: 0x060299F8 RID: 170488 RVA: 0x009C8EED File Offset: 0x009C70ED
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_4) = value;
			}
		}

		// Token: 0x17006442 RID: 25666
		// (get) Token: 0x060299F9 RID: 170489 RVA: 0x009C8EFE File Offset: 0x009C70FE
		// (set) Token: 0x060299FA RID: 170490 RVA: 0x009C8F0E File Offset: 0x009C710E
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_5) = value;
			}
		}

		// Token: 0x17006443 RID: 25667
		// (get) Token: 0x060299FB RID: 170491 RVA: 0x009C8F1F File Offset: 0x009C711F
		// (set) Token: 0x060299FC RID: 170492 RVA: 0x009C8F2F File Offset: 0x009C712F
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_6) = value;
			}
		}

		// Token: 0x17006444 RID: 25668
		// (get) Token: 0x060299FD RID: 170493 RVA: 0x009C8F40 File Offset: 0x009C7140
		// (set) Token: 0x060299FE RID: 170494 RVA: 0x009C8F50 File Offset: 0x009C7150
		public unsafe float ManualLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_7);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_7) = value;
			}
		}

		// Token: 0x060299FF RID: 170495 RVA: 0x009C8F61 File Offset: 0x009C7161
		public SNiagaraParam()
		{
		}

		// Token: 0x06029A00 RID: 170496 RVA: 0x009C8F6C File Offset: 0x009C716C
		public SNiagaraParam(int ID, TMap<FName, FKuroCurveFloat> FloatParameters, TMap<FName, FKuroCurveLinearColor> ColorParameters, TMap<FName, FKuroCurveVector> VectorParameters, float StartTime, float LoopTime, float EndTime, float ManualLifeTime)
		{
			this.ID = ID;
			this.FloatParameters = FloatParameters;
			this.ColorParameters = ColorParameters;
			this.VectorParameters = VectorParameters;
			this.StartTime = StartTime;
			this.LoopTime = LoopTime;
			this.EndTime = EndTime;
			this.ManualLifeTime = ManualLifeTime;
		}

		// Token: 0x06029A01 RID: 170497 RVA: 0x009C8FBC File Offset: 0x009C71BC
		protected override IntPtr GetUStructPtr()
		{
			return SNiagaraParam.StaticStruct();
		}

		// Token: 0x06029A02 RID: 170498 RVA: 0x009C8FC8 File Offset: 0x009C71C8
		[NullableContext(2)]
		public SNiagaraParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06029A03 RID: 170499 RVA: 0x009C8FD2 File Offset: 0x009C71D2
		public SNiagaraParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06029A04 RID: 170500 RVA: 0x009C8FDD File Offset: 0x009C71DD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNiagaraParam(Pointer, false, true);
		}

		// Token: 0x06029A05 RID: 170501 RVA: 0x009C8FE7 File Offset: 0x009C71E7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNiagaraParam(Pointer, MemoryOwner);
		}

		// Token: 0x040155BA RID: 87482
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam";

		// Token: 0x040155BB RID: 87483
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155BC RID: 87484
		internal static int __PropertyOffset_0;

		// Token: 0x040155BD RID: 87485
		internal static int __PropertyOffset_1;

		// Token: 0x040155BE RID: 87486
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x040155BF RID: 87487
		internal static int __PropertyOffset_2;

		// Token: 0x040155C0 RID: 87488
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x040155C1 RID: 87489
		internal static int __PropertyOffset_3;

		// Token: 0x040155C2 RID: 87490
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;

		// Token: 0x040155C3 RID: 87491
		internal static int __PropertyOffset_4;

		// Token: 0x040155C4 RID: 87492
		internal static int __PropertyOffset_5;

		// Token: 0x040155C5 RID: 87493
		internal static int __PropertyOffset_6;

		// Token: 0x040155C6 RID: 87494
		internal static int __PropertyOffset_7;
	}
}
