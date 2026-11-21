using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006489 RID: 25737
	public class IProcessedValueType_UnionUnion
	{
		// Token: 0x1700BDDD RID: 48605
		// (get) Token: 0x0602BBAF RID: 179119 RVA: 0x005F3185 File Offset: 0x005F1385
		// (set) Token: 0x0602BBB0 RID: 179120 RVA: 0x005F318D File Offset: 0x005F138D
		public IProcessedValueType_Union Type { get; set; }

		// Token: 0x1700BDDE RID: 48606
		// (get) Token: 0x0602BBB1 RID: 179121 RVA: 0x005F3196 File Offset: 0x005F1396
		// (set) Token: 0x0602BBB2 RID: 179122 RVA: 0x005F319E File Offset: 0x005F139E
		public object Value { get; set; }

		// Token: 0x0602BBB3 RID: 179123 RVA: 0x005F31A7 File Offset: 0x005F13A7
		public IProcessedValueType_UnionUnion()
		{
			this.Type = IProcessedValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602BBB4 RID: 179124 RVA: 0x005F31BD File Offset: 0x005F13BD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BBB5 RID: 179125 RVA: 0x005F31CF File Offset: 0x005F13CF
		public IProcessedValueTypeT AsIProcessedValueType()
		{
			return this.As<IProcessedValueTypeT>();
		}

		// Token: 0x0602BBB6 RID: 179126 RVA: 0x005F31D7 File Offset: 0x005F13D7
		public static IProcessedValueType_UnionUnion FromIProcessedValueType(IProcessedValueTypeT _iprocessedvaluetype)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueType,
				Value = _iprocessedvaluetype
			};
		}

		// Token: 0x0602BBB7 RID: 179127 RVA: 0x005F31EC File Offset: 0x005F13EC
		public IProcessedValueConstantT AsIProcessedValueConstant()
		{
			return this.As<IProcessedValueConstantT>();
		}

		// Token: 0x0602BBB8 RID: 179128 RVA: 0x005F31F4 File Offset: 0x005F13F4
		public static IProcessedValueType_UnionUnion FromIProcessedValueConstant(IProcessedValueConstantT _iprocessedvalueconstant)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueConstant,
				Value = _iprocessedvalueconstant
			};
		}

		// Token: 0x0602BBB9 RID: 179129 RVA: 0x005F3209 File Offset: 0x005F1409
		public IProcessedValueConstraintT AsIProcessedValueConstraint()
		{
			return this.As<IProcessedValueConstraintT>();
		}

		// Token: 0x0602BBBA RID: 179130 RVA: 0x005F3211 File Offset: 0x005F1411
		public static IProcessedValueType_UnionUnion FromIProcessedValueConstraint(IProcessedValueConstraintT _iprocessedvalueconstraint)
		{
			return new IProcessedValueType_UnionUnion
			{
				Type = IProcessedValueType_Union.IProcessedValueConstraint,
				Value = _iprocessedvalueconstraint
			};
		}

		// Token: 0x0602BBBB RID: 179131 RVA: 0x005F3228 File Offset: 0x005F1428
		public static int Pack(FlatBufferBuilder builder, IProcessedValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IProcessedValueType_Union.IProcessedValueType:
				return IProcessedValueType.Pack(builder, _o.AsIProcessedValueType()).Value;
			case IProcessedValueType_Union.IProcessedValueConstant:
				return IProcessedValueConstant.Pack(builder, _o.AsIProcessedValueConstant()).Value;
			case IProcessedValueType_Union.IProcessedValueConstraint:
				return IProcessedValueConstraint.Pack(builder, _o.AsIProcessedValueConstraint()).Value;
			default:
				return 0;
			}
		}
	}
}
