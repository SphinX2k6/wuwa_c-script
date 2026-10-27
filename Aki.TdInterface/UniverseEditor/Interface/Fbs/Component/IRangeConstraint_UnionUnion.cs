using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005803 RID: 22531
	public class IRangeConstraint_UnionUnion
	{
		// Token: 0x1700A851 RID: 43089
		// (get) Token: 0x06025E05 RID: 155141 RVA: 0x005394F1 File Offset: 0x005376F1
		// (set) Token: 0x06025E06 RID: 155142 RVA: 0x005394F9 File Offset: 0x005376F9
		public IRangeConstraint_Union Type { get; set; }

		// Token: 0x1700A852 RID: 43090
		// (get) Token: 0x06025E07 RID: 155143 RVA: 0x00539502 File Offset: 0x00537702
		// (set) Token: 0x06025E08 RID: 155144 RVA: 0x0053950A File Offset: 0x0053770A
		public object Value { get; set; }

		// Token: 0x06025E09 RID: 155145 RVA: 0x00539513 File Offset: 0x00537713
		public IRangeConstraint_UnionUnion()
		{
			this.Type = IRangeConstraint_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025E0A RID: 155146 RVA: 0x00539529 File Offset: 0x00537729
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025E0B RID: 155147 RVA: 0x0053953B File Offset: 0x0053773B
		public IRangeConstraintT AsIRangeConstraint()
		{
			return this.As<IRangeConstraintT>();
		}

		// Token: 0x06025E0C RID: 155148 RVA: 0x00539543 File Offset: 0x00537743
		public static IRangeConstraint_UnionUnion FromIRangeConstraint(IRangeConstraintT _irangeconstraint)
		{
			return new IRangeConstraint_UnionUnion
			{
				Type = IRangeConstraint_Union.IRangeConstraint,
				Value = _irangeconstraint
			};
		}

		// Token: 0x06025E0D RID: 155149 RVA: 0x00539558 File Offset: 0x00537758
		public ISearchSpawnMonsterPointT AsISearchSpawnMonsterPoint()
		{
			return this.As<ISearchSpawnMonsterPointT>();
		}

		// Token: 0x06025E0E RID: 155150 RVA: 0x00539560 File Offset: 0x00537760
		public static IRangeConstraint_UnionUnion FromISearchSpawnMonsterPoint(ISearchSpawnMonsterPointT _isearchspawnmonsterpoint)
		{
			return new IRangeConstraint_UnionUnion
			{
				Type = IRangeConstraint_Union.ISearchSpawnMonsterPoint,
				Value = _isearchspawnmonsterpoint
			};
		}

		// Token: 0x06025E0F RID: 155151 RVA: 0x00539578 File Offset: 0x00537778
		public static int Pack(FlatBufferBuilder builder, IRangeConstraint_UnionUnion _o)
		{
			IRangeConstraint_Union type = _o.Type;
			if (type == IRangeConstraint_Union.IRangeConstraint)
			{
				return IRangeConstraint.Pack(builder, _o.AsIRangeConstraint()).Value;
			}
			if (type != IRangeConstraint_Union.ISearchSpawnMonsterPoint)
			{
				return 0;
			}
			return ISearchSpawnMonsterPoint.Pack(builder, _o.AsISearchSpawnMonsterPoint()).Value;
		}
	}
}
