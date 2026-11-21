using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E0A RID: 24074
	public class IRangeConstraint_UnionUnion
	{
		// Token: 0x1700B175 RID: 45429
		// (get) Token: 0x06028325 RID: 164645 RVA: 0x0057F67D File Offset: 0x0057D87D
		// (set) Token: 0x06028326 RID: 164646 RVA: 0x0057F685 File Offset: 0x0057D885
		public IRangeConstraint_Union Type { get; set; }

		// Token: 0x1700B176 RID: 45430
		// (get) Token: 0x06028327 RID: 164647 RVA: 0x0057F68E File Offset: 0x0057D88E
		// (set) Token: 0x06028328 RID: 164648 RVA: 0x0057F696 File Offset: 0x0057D896
		public object Value { get; set; }

		// Token: 0x06028329 RID: 164649 RVA: 0x0057F69F File Offset: 0x0057D89F
		public IRangeConstraint_UnionUnion()
		{
			this.Type = IRangeConstraint_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602832A RID: 164650 RVA: 0x0057F6B5 File Offset: 0x0057D8B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602832B RID: 164651 RVA: 0x0057F6C7 File Offset: 0x0057D8C7
		public IRangeConstraintT AsIRangeConstraint()
		{
			return this.As<IRangeConstraintT>();
		}

		// Token: 0x0602832C RID: 164652 RVA: 0x0057F6CF File Offset: 0x0057D8CF
		public static IRangeConstraint_UnionUnion FromIRangeConstraint(IRangeConstraintT _irangeconstraint)
		{
			return new IRangeConstraint_UnionUnion
			{
				Type = IRangeConstraint_Union.IRangeConstraint,
				Value = _irangeconstraint
			};
		}

		// Token: 0x0602832D RID: 164653 RVA: 0x0057F6E4 File Offset: 0x0057D8E4
		public ISearchSpawnMonsterPointT AsISearchSpawnMonsterPoint()
		{
			return this.As<ISearchSpawnMonsterPointT>();
		}

		// Token: 0x0602832E RID: 164654 RVA: 0x0057F6EC File Offset: 0x0057D8EC
		public static IRangeConstraint_UnionUnion FromISearchSpawnMonsterPoint(ISearchSpawnMonsterPointT _isearchspawnmonsterpoint)
		{
			return new IRangeConstraint_UnionUnion
			{
				Type = IRangeConstraint_Union.ISearchSpawnMonsterPoint,
				Value = _isearchspawnmonsterpoint
			};
		}

		// Token: 0x0602832F RID: 164655 RVA: 0x0057F704 File Offset: 0x0057D904
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
