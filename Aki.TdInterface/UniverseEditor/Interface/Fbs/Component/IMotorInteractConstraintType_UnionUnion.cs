using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C4 RID: 21956
	public class IMotorInteractConstraintType_UnionUnion
	{
		// Token: 0x1700A240 RID: 41536
		// (get) Token: 0x060245EF RID: 148975 RVA: 0x00505421 File Offset: 0x00503621
		// (set) Token: 0x060245F0 RID: 148976 RVA: 0x00505429 File Offset: 0x00503629
		public IMotorInteractConstraintType_Union Type { get; set; }

		// Token: 0x1700A241 RID: 41537
		// (get) Token: 0x060245F1 RID: 148977 RVA: 0x00505432 File Offset: 0x00503632
		// (set) Token: 0x060245F2 RID: 148978 RVA: 0x0050543A File Offset: 0x0050363A
		public object Value { get; set; }

		// Token: 0x060245F3 RID: 148979 RVA: 0x00505443 File Offset: 0x00503643
		public IMotorInteractConstraintType_UnionUnion()
		{
			this.Type = IMotorInteractConstraintType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060245F4 RID: 148980 RVA: 0x00505459 File Offset: 0x00503659
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060245F5 RID: 148981 RVA: 0x0050546B File Offset: 0x0050366B
		public IMotorInteractConstraintTypeT AsIMotorInteractConstraintType()
		{
			return this.As<IMotorInteractConstraintTypeT>();
		}

		// Token: 0x060245F6 RID: 148982 RVA: 0x00505473 File Offset: 0x00503673
		public static IMotorInteractConstraintType_UnionUnion FromIMotorInteractConstraintType(IMotorInteractConstraintTypeT _imotorinteractconstrainttype)
		{
			return new IMotorInteractConstraintType_UnionUnion
			{
				Type = IMotorInteractConstraintType_Union.IMotorInteractConstraintType,
				Value = _imotorinteractconstrainttype
			};
		}

		// Token: 0x060245F7 RID: 148983 RVA: 0x00505488 File Offset: 0x00503688
		public IFaceToTargetMotorInteractConstraintT AsIFaceToTargetMotorInteractConstraint()
		{
			return this.As<IFaceToTargetMotorInteractConstraintT>();
		}

		// Token: 0x060245F8 RID: 148984 RVA: 0x00505490 File Offset: 0x00503690
		public static IMotorInteractConstraintType_UnionUnion FromIFaceToTargetMotorInteractConstraint(IFaceToTargetMotorInteractConstraintT _ifacetotargetmotorinteractconstraint)
		{
			return new IMotorInteractConstraintType_UnionUnion
			{
				Type = IMotorInteractConstraintType_Union.IFaceToTargetMotorInteractConstraint,
				Value = _ifacetotargetmotorinteractconstraint
			};
		}

		// Token: 0x060245F9 RID: 148985 RVA: 0x005054A8 File Offset: 0x005036A8
		public static int Pack(FlatBufferBuilder builder, IMotorInteractConstraintType_UnionUnion _o)
		{
			IMotorInteractConstraintType_Union type = _o.Type;
			if (type == IMotorInteractConstraintType_Union.IMotorInteractConstraintType)
			{
				return IMotorInteractConstraintType.Pack(builder, _o.AsIMotorInteractConstraintType()).Value;
			}
			if (type != IMotorInteractConstraintType_Union.IFaceToTargetMotorInteractConstraint)
			{
				return 0;
			}
			return IFaceToTargetMotorInteractConstraint.Pack(builder, _o.AsIFaceToTargetMotorInteractConstraint()).Value;
		}
	}
}
