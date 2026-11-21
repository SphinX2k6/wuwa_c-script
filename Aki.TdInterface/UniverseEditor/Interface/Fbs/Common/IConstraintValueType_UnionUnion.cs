using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063C0 RID: 25536
	public class IConstraintValueType_UnionUnion
	{
		// Token: 0x1700BCAD RID: 48301
		// (get) Token: 0x0602B5C2 RID: 177602 RVA: 0x005E8909 File Offset: 0x005E6B09
		// (set) Token: 0x0602B5C3 RID: 177603 RVA: 0x005E8911 File Offset: 0x005E6B11
		public IConstraintValueType_Union Type { get; set; }

		// Token: 0x1700BCAE RID: 48302
		// (get) Token: 0x0602B5C4 RID: 177604 RVA: 0x005E891A File Offset: 0x005E6B1A
		// (set) Token: 0x0602B5C5 RID: 177605 RVA: 0x005E8922 File Offset: 0x005E6B22
		public object Value { get; set; }

		// Token: 0x0602B5C6 RID: 177606 RVA: 0x005E892B File Offset: 0x005E6B2B
		public IConstraintValueType_UnionUnion()
		{
			this.Type = IConstraintValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B5C7 RID: 177607 RVA: 0x005E8941 File Offset: 0x005E6B41
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B5C8 RID: 177608 RVA: 0x005E8953 File Offset: 0x005E6B53
		public IConstraintValueTypeT AsIConstraintValueType()
		{
			return this.As<IConstraintValueTypeT>();
		}

		// Token: 0x0602B5C9 RID: 177609 RVA: 0x005E895B File Offset: 0x005E6B5B
		public static IConstraintValueType_UnionUnion FromIConstraintValueType(IConstraintValueTypeT _iconstraintvaluetype)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueType,
				Value = _iconstraintvaluetype
			};
		}

		// Token: 0x0602B5CA RID: 177610 RVA: 0x005E8970 File Offset: 0x005E6B70
		public IConstraintValueMaxT AsIConstraintValueMax()
		{
			return this.As<IConstraintValueMaxT>();
		}

		// Token: 0x0602B5CB RID: 177611 RVA: 0x005E8978 File Offset: 0x005E6B78
		public static IConstraintValueType_UnionUnion FromIConstraintValueMax(IConstraintValueMaxT _iconstraintvaluemax)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueMax,
				Value = _iconstraintvaluemax
			};
		}

		// Token: 0x0602B5CC RID: 177612 RVA: 0x005E898D File Offset: 0x005E6B8D
		public IConstraintValueMinT AsIConstraintValueMin()
		{
			return this.As<IConstraintValueMinT>();
		}

		// Token: 0x0602B5CD RID: 177613 RVA: 0x005E8995 File Offset: 0x005E6B95
		public static IConstraintValueType_UnionUnion FromIConstraintValueMin(IConstraintValueMinT _iconstraintvaluemin)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueMin,
				Value = _iconstraintvaluemin
			};
		}

		// Token: 0x0602B5CE RID: 177614 RVA: 0x005E89AA File Offset: 0x005E6BAA
		public IConstraintValueClampT AsIConstraintValueClamp()
		{
			return this.As<IConstraintValueClampT>();
		}

		// Token: 0x0602B5CF RID: 177615 RVA: 0x005E89B2 File Offset: 0x005E6BB2
		public static IConstraintValueType_UnionUnion FromIConstraintValueClamp(IConstraintValueClampT _iconstraintvalueclamp)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueClamp,
				Value = _iconstraintvalueclamp
			};
		}

		// Token: 0x0602B5D0 RID: 177616 RVA: 0x005E89C8 File Offset: 0x005E6BC8
		public static int Pack(FlatBufferBuilder builder, IConstraintValueType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IConstraintValueType_Union.IConstraintValueType:
				return IConstraintValueType.Pack(builder, _o.AsIConstraintValueType()).Value;
			case IConstraintValueType_Union.IConstraintValueMax:
				return IConstraintValueMax.Pack(builder, _o.AsIConstraintValueMax()).Value;
			case IConstraintValueType_Union.IConstraintValueMin:
				return IConstraintValueMin.Pack(builder, _o.AsIConstraintValueMin()).Value;
			case IConstraintValueType_Union.IConstraintValueClamp:
				return IConstraintValueClamp.Pack(builder, _o.AsIConstraintValueClamp()).Value;
			default:
				return 0;
			}
		}
	}
}
