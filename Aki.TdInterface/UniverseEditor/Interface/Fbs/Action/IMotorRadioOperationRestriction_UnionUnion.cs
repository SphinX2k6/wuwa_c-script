using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007271 RID: 29297
	public class IMotorRadioOperationRestriction_UnionUnion
	{
		// Token: 0x1700D6C7 RID: 54983
		// (get) Token: 0x060330C0 RID: 209088 RVA: 0x006E3CA5 File Offset: 0x006E1EA5
		// (set) Token: 0x060330C1 RID: 209089 RVA: 0x006E3CAD File Offset: 0x006E1EAD
		public IMotorRadioOperationRestriction_Union Type { get; set; }

		// Token: 0x1700D6C8 RID: 54984
		// (get) Token: 0x060330C2 RID: 209090 RVA: 0x006E3CB6 File Offset: 0x006E1EB6
		// (set) Token: 0x060330C3 RID: 209091 RVA: 0x006E3CBE File Offset: 0x006E1EBE
		public object Value { get; set; }

		// Token: 0x060330C4 RID: 209092 RVA: 0x006E3CC7 File Offset: 0x006E1EC7
		public IMotorRadioOperationRestriction_UnionUnion()
		{
			this.Type = IMotorRadioOperationRestriction_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060330C5 RID: 209093 RVA: 0x006E3CDD File Offset: 0x006E1EDD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060330C6 RID: 209094 RVA: 0x006E3CEF File Offset: 0x006E1EEF
		public IMotorRadioOperationRestrictionT AsIMotorRadioOperationRestriction()
		{
			return this.As<IMotorRadioOperationRestrictionT>();
		}

		// Token: 0x060330C7 RID: 209095 RVA: 0x006E3CF7 File Offset: 0x006E1EF7
		public static IMotorRadioOperationRestriction_UnionUnion FromIMotorRadioOperationRestriction(IMotorRadioOperationRestrictionT _imotorradiooperationrestriction)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IMotorRadioOperationRestriction,
				Value = _imotorradiooperationrestriction
			};
		}

		// Token: 0x060330C8 RID: 209096 RVA: 0x006E3D0C File Offset: 0x006E1F0C
		public IEnableAllMotorRadioOperationT AsIEnableAllMotorRadioOperation()
		{
			return this.As<IEnableAllMotorRadioOperationT>();
		}

		// Token: 0x060330C9 RID: 209097 RVA: 0x006E3D14 File Offset: 0x006E1F14
		public static IMotorRadioOperationRestriction_UnionUnion FromIEnableAllMotorRadioOperation(IEnableAllMotorRadioOperationT _ienableallmotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IEnableAllMotorRadioOperation,
				Value = _ienableallmotorradiooperation
			};
		}

		// Token: 0x060330CA RID: 209098 RVA: 0x006E3D29 File Offset: 0x006E1F29
		public IDisableAllMotorRadioOperationT AsIDisableAllMotorRadioOperation()
		{
			return this.As<IDisableAllMotorRadioOperationT>();
		}

		// Token: 0x060330CB RID: 209099 RVA: 0x006E3D31 File Offset: 0x006E1F31
		public static IMotorRadioOperationRestriction_UnionUnion FromIDisableAllMotorRadioOperation(IDisableAllMotorRadioOperationT _idisableallmotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IDisableAllMotorRadioOperation,
				Value = _idisableallmotorradiooperation
			};
		}

		// Token: 0x060330CC RID: 209100 RVA: 0x006E3D46 File Offset: 0x006E1F46
		public IEnableInRangeMotorRadioOperationT AsIEnableInRangeMotorRadioOperation()
		{
			return this.As<IEnableInRangeMotorRadioOperationT>();
		}

		// Token: 0x060330CD RID: 209101 RVA: 0x006E3D4E File Offset: 0x006E1F4E
		public static IMotorRadioOperationRestriction_UnionUnion FromIEnableInRangeMotorRadioOperation(IEnableInRangeMotorRadioOperationT _ienableinrangemotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IEnableInRangeMotorRadioOperation,
				Value = _ienableinrangemotorradiooperation
			};
		}

		// Token: 0x060330CE RID: 209102 RVA: 0x006E3D63 File Offset: 0x006E1F63
		public IDisableInRangeMotorRadioOperationT AsIDisableInRangeMotorRadioOperation()
		{
			return this.As<IDisableInRangeMotorRadioOperationT>();
		}

		// Token: 0x060330CF RID: 209103 RVA: 0x006E3D6B File Offset: 0x006E1F6B
		public static IMotorRadioOperationRestriction_UnionUnion FromIDisableInRangeMotorRadioOperation(IDisableInRangeMotorRadioOperationT _idisableinrangemotorradiooperation)
		{
			return new IMotorRadioOperationRestriction_UnionUnion
			{
				Type = IMotorRadioOperationRestriction_Union.IDisableInRangeMotorRadioOperation,
				Value = _idisableinrangemotorradiooperation
			};
		}

		// Token: 0x060330D0 RID: 209104 RVA: 0x006E3D80 File Offset: 0x006E1F80
		public static int Pack(FlatBufferBuilder builder, IMotorRadioOperationRestriction_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IMotorRadioOperationRestriction_Union.IMotorRadioOperationRestriction:
				return IMotorRadioOperationRestriction.Pack(builder, _o.AsIMotorRadioOperationRestriction()).Value;
			case IMotorRadioOperationRestriction_Union.IEnableAllMotorRadioOperation:
				return IEnableAllMotorRadioOperation.Pack(builder, _o.AsIEnableAllMotorRadioOperation()).Value;
			case IMotorRadioOperationRestriction_Union.IDisableAllMotorRadioOperation:
				return IDisableAllMotorRadioOperation.Pack(builder, _o.AsIDisableAllMotorRadioOperation()).Value;
			case IMotorRadioOperationRestriction_Union.IEnableInRangeMotorRadioOperation:
				return IEnableInRangeMotorRadioOperation.Pack(builder, _o.AsIEnableInRangeMotorRadioOperation()).Value;
			case IMotorRadioOperationRestriction_Union.IDisableInRangeMotorRadioOperation:
				return IDisableInRangeMotorRadioOperation.Pack(builder, _o.AsIDisableInRangeMotorRadioOperation()).Value;
			default:
				return 0;
			}
		}
	}
}
