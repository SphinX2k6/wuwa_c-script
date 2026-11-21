using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B62 RID: 23394
	public class IMotorInteractConstraintType_UnionUnion
	{
		// Token: 0x1700AAC8 RID: 43720
		// (get) Token: 0x060267FC RID: 157692 RVA: 0x00545999 File Offset: 0x00543B99
		// (set) Token: 0x060267FD RID: 157693 RVA: 0x005459A1 File Offset: 0x00543BA1
		public IMotorInteractConstraintType_Union Type { get; set; }

		// Token: 0x1700AAC9 RID: 43721
		// (get) Token: 0x060267FE RID: 157694 RVA: 0x005459AA File Offset: 0x00543BAA
		// (set) Token: 0x060267FF RID: 157695 RVA: 0x005459B2 File Offset: 0x00543BB2
		public object Value { get; set; }

		// Token: 0x06026800 RID: 157696 RVA: 0x005459BB File Offset: 0x00543BBB
		public IMotorInteractConstraintType_UnionUnion()
		{
			this.Type = IMotorInteractConstraintType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026801 RID: 157697 RVA: 0x005459D1 File Offset: 0x00543BD1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026802 RID: 157698 RVA: 0x005459E3 File Offset: 0x00543BE3
		public IMotorInteractConstraintTypeT AsIMotorInteractConstraintType()
		{
			return this.As<IMotorInteractConstraintTypeT>();
		}

		// Token: 0x06026803 RID: 157699 RVA: 0x005459EB File Offset: 0x00543BEB
		public static IMotorInteractConstraintType_UnionUnion FromIMotorInteractConstraintType(IMotorInteractConstraintTypeT _imotorinteractconstrainttype)
		{
			return new IMotorInteractConstraintType_UnionUnion
			{
				Type = IMotorInteractConstraintType_Union.IMotorInteractConstraintType,
				Value = _imotorinteractconstrainttype
			};
		}

		// Token: 0x06026804 RID: 157700 RVA: 0x00545A00 File Offset: 0x00543C00
		public IFaceToTargetMotorInteractConstraintT AsIFaceToTargetMotorInteractConstraint()
		{
			return this.As<IFaceToTargetMotorInteractConstraintT>();
		}

		// Token: 0x06026805 RID: 157701 RVA: 0x00545A08 File Offset: 0x00543C08
		public static IMotorInteractConstraintType_UnionUnion FromIFaceToTargetMotorInteractConstraint(IFaceToTargetMotorInteractConstraintT _ifacetotargetmotorinteractconstraint)
		{
			return new IMotorInteractConstraintType_UnionUnion
			{
				Type = IMotorInteractConstraintType_Union.IFaceToTargetMotorInteractConstraint,
				Value = _ifacetotargetmotorinteractconstraint
			};
		}

		// Token: 0x06026806 RID: 157702 RVA: 0x00545A20 File Offset: 0x00543C20
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
