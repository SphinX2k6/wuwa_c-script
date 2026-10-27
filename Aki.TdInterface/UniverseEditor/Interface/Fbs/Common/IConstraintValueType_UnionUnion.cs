using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D83 RID: 23939
	public class IConstraintValueType_UnionUnion
	{
		// Token: 0x1700B347 RID: 45895
		// (get) Token: 0x06028F38 RID: 167736 RVA: 0x0059FBD9 File Offset: 0x0059DDD9
		// (set) Token: 0x06028F39 RID: 167737 RVA: 0x0059FBE1 File Offset: 0x0059DDE1
		public IConstraintValueType_Union Type { get; set; }

		// Token: 0x1700B348 RID: 45896
		// (get) Token: 0x06028F3A RID: 167738 RVA: 0x0059FBEA File Offset: 0x0059DDEA
		// (set) Token: 0x06028F3B RID: 167739 RVA: 0x0059FBF2 File Offset: 0x0059DDF2
		public object Value { get; set; }

		// Token: 0x06028F3C RID: 167740 RVA: 0x0059FBFB File Offset: 0x0059DDFB
		public IConstraintValueType_UnionUnion()
		{
			this.Type = IConstraintValueType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028F3D RID: 167741 RVA: 0x0059FC11 File Offset: 0x0059DE11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028F3E RID: 167742 RVA: 0x0059FC23 File Offset: 0x0059DE23
		public IConstraintValueTypeT AsIConstraintValueType()
		{
			return this.As<IConstraintValueTypeT>();
		}

		// Token: 0x06028F3F RID: 167743 RVA: 0x0059FC2B File Offset: 0x0059DE2B
		public static IConstraintValueType_UnionUnion FromIConstraintValueType(IConstraintValueTypeT _iconstraintvaluetype)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueType,
				Value = _iconstraintvaluetype
			};
		}

		// Token: 0x06028F40 RID: 167744 RVA: 0x0059FC40 File Offset: 0x0059DE40
		public IConstraintValueMaxT AsIConstraintValueMax()
		{
			return this.As<IConstraintValueMaxT>();
		}

		// Token: 0x06028F41 RID: 167745 RVA: 0x0059FC48 File Offset: 0x0059DE48
		public static IConstraintValueType_UnionUnion FromIConstraintValueMax(IConstraintValueMaxT _iconstraintvaluemax)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueMax,
				Value = _iconstraintvaluemax
			};
		}

		// Token: 0x06028F42 RID: 167746 RVA: 0x0059FC5D File Offset: 0x0059DE5D
		public IConstraintValueMinT AsIConstraintValueMin()
		{
			return this.As<IConstraintValueMinT>();
		}

		// Token: 0x06028F43 RID: 167747 RVA: 0x0059FC65 File Offset: 0x0059DE65
		public static IConstraintValueType_UnionUnion FromIConstraintValueMin(IConstraintValueMinT _iconstraintvaluemin)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueMin,
				Value = _iconstraintvaluemin
			};
		}

		// Token: 0x06028F44 RID: 167748 RVA: 0x0059FC7A File Offset: 0x0059DE7A
		public IConstraintValueClampT AsIConstraintValueClamp()
		{
			return this.As<IConstraintValueClampT>();
		}

		// Token: 0x06028F45 RID: 167749 RVA: 0x0059FC82 File Offset: 0x0059DE82
		public static IConstraintValueType_UnionUnion FromIConstraintValueClamp(IConstraintValueClampT _iconstraintvalueclamp)
		{
			return new IConstraintValueType_UnionUnion
			{
				Type = IConstraintValueType_Union.IConstraintValueClamp,
				Value = _iconstraintvalueclamp
			};
		}

		// Token: 0x06028F46 RID: 167750 RVA: 0x0059FC98 File Offset: 0x0059DE98
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
