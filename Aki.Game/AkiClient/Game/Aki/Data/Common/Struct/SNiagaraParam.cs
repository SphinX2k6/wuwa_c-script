using System;
using System.Runtime.CompilerServices;
using UnrealEngine;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace AkiClient.Game.Aki.Data.Common.Struct
{
	// Token: 0x0200322D RID: 12845
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class SNiagaraParam : UnrealUserDefinedStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020119 RID: 131353 RVA: 0x0093C791 File Offset: 0x0093A991
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (SNiagaraParam._ScriptStructPtr != 0) ? SNiagaraParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam", ref SNiagaraParam._ScriptStructPtr);
		}

		// Token: 0x17003D1E RID: 15646
		// (get) Token: 0x0602011A RID: 131354 RVA: 0x0093C7B5 File Offset: 0x0093A9B5
		// (set) Token: 0x0602011B RID: 131355 RVA: 0x0093C7C5 File Offset: 0x0093A9C5
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x0602011C RID: 131356 RVA: 0x0093C7D8 File Offset: 0x0093A9D8
		// (set) Token: 0x0602011D RID: 131357 RVA: 0x0093C81B File Offset: 0x0093AA1B
		public TMap<FName, FKuroCurveFloat> FloatParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveFloat> result;
				if ((result = this._FloatParameters) == null)
				{
					result = (this._FloatParameters = new TMap<FName, FKuroCurveFloat>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_FloatParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x0602011E RID: 131358 RVA: 0x0093C82C File Offset: 0x0093AA2C
		// (set) Token: 0x0602011F RID: 131359 RVA: 0x0093C86F File Offset: 0x0093AA6F
		public TMap<FName, FKuroCurveLinearColor> ColorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveLinearColor> result;
				if ((result = this._ColorParameters) == null)
				{
					result = (this._ColorParameters = new TMap<FName, FKuroCurveLinearColor>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_ColorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ColorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x06020120 RID: 131360 RVA: 0x0093C880 File Offset: 0x0093AA80
		// (set) Token: 0x06020121 RID: 131361 RVA: 0x0093C8C3 File Offset: 0x0093AAC3
		public TMap<FName, FKuroCurveVector> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FKuroCurveVector> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TMap<FName, FKuroCurveVector>(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_VectorParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x17003D22 RID: 15650
		// (get) Token: 0x06020122 RID: 131362 RVA: 0x0093C8D1 File Offset: 0x0093AAD1
		// (set) Token: 0x06020123 RID: 131363 RVA: 0x0093C8E1 File Offset: 0x0093AAE1
		public unsafe float StartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_StartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_StartTime) = value;
			}
		}

		// Token: 0x17003D23 RID: 15651
		// (get) Token: 0x06020124 RID: 131364 RVA: 0x0093C8F2 File Offset: 0x0093AAF2
		// (set) Token: 0x06020125 RID: 131365 RVA: 0x0093C902 File Offset: 0x0093AB02
		public unsafe float LoopTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_LoopTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_LoopTime) = value;
			}
		}

		// Token: 0x17003D24 RID: 15652
		// (get) Token: 0x06020126 RID: 131366 RVA: 0x0093C913 File Offset: 0x0093AB13
		// (set) Token: 0x06020127 RID: 131367 RVA: 0x0093C923 File Offset: 0x0093AB23
		public unsafe float EndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_EndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_EndTime) = value;
			}
		}

		// Token: 0x17003D25 RID: 15653
		// (get) Token: 0x06020128 RID: 131368 RVA: 0x0093C934 File Offset: 0x0093AB34
		// (set) Token: 0x06020129 RID: 131369 RVA: 0x0093C944 File Offset: 0x0093AB44
		public unsafe float ManualLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_ManualLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)SNiagaraParam.__PropertyOffset_ManualLifeTime) = value;
			}
		}

		// Token: 0x0602012A RID: 131370 RVA: 0x0093C955 File Offset: 0x0093AB55
		public SNiagaraParam()
		{
		}

		// Token: 0x0602012B RID: 131371 RVA: 0x0093C95D File Offset: 0x0093AB5D
		protected override IntPtr GetUStructPtr()
		{
			return SNiagaraParam.StaticStruct();
		}

		// Token: 0x0602012C RID: 131372 RVA: 0x0093C969 File Offset: 0x0093AB69
		[NullableContext(2)]
		public SNiagaraParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602012D RID: 131373 RVA: 0x0093C973 File Offset: 0x0093AB73
		public SNiagaraParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602012E RID: 131374 RVA: 0x0093C97E File Offset: 0x0093AB7E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new SNiagaraParam(Pointer, false, true);
		}

		// Token: 0x0602012F RID: 131375 RVA: 0x0093C988 File Offset: 0x0093AB88
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new SNiagaraParam(Pointer, MemoryOwner);
		}

		// Token: 0x040113DF RID: 70623
		public const string __ObjectPath = "/Game/Aki/Data/Common/Struct/SNiagaraParam.SNiagaraParam";

		// Token: 0x040113E0 RID: 70624
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040113E1 RID: 70625
		internal static int __PropertyOffset_ID;

		// Token: 0x040113E2 RID: 70626
		internal static int __PropertyOffset_FloatParameters;

		// Token: 0x040113E3 RID: 70627
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveFloat> _FloatParameters;

		// Token: 0x040113E4 RID: 70628
		internal static int __PropertyOffset_ColorParameters;

		// Token: 0x040113E5 RID: 70629
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveLinearColor> _ColorParameters;

		// Token: 0x040113E6 RID: 70630
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x040113E7 RID: 70631
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FKuroCurveVector> _VectorParameters;

		// Token: 0x040113E8 RID: 70632
		internal static int __PropertyOffset_StartTime;

		// Token: 0x040113E9 RID: 70633
		internal static int __PropertyOffset_LoopTime;

		// Token: 0x040113EA RID: 70634
		internal static int __PropertyOffset_EndTime;

		// Token: 0x040113EB RID: 70635
		internal static int __PropertyOffset_ManualLifeTime;
	}
}
