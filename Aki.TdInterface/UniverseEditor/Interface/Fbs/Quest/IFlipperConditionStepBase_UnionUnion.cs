using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E61 RID: 15969
	public class IFlipperConditionStepBase_UnionUnion
	{
		// Token: 0x17006EB8 RID: 28344
		// (get) Token: 0x060167AC RID: 92076 RVA: 0x0033FF2D File Offset: 0x0033E12D
		// (set) Token: 0x060167AD RID: 92077 RVA: 0x0033FF35 File Offset: 0x0033E135
		public IFlipperConditionStepBase_Union Type { get; set; }

		// Token: 0x17006EB9 RID: 28345
		// (get) Token: 0x060167AE RID: 92078 RVA: 0x0033FF3E File Offset: 0x0033E13E
		// (set) Token: 0x060167AF RID: 92079 RVA: 0x0033FF46 File Offset: 0x0033E146
		public object Value { get; set; }

		// Token: 0x060167B0 RID: 92080 RVA: 0x0033FF4F File Offset: 0x0033E14F
		public IFlipperConditionStepBase_UnionUnion()
		{
			this.Type = IFlipperConditionStepBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060167B1 RID: 92081 RVA: 0x0033FF65 File Offset: 0x0033E165
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060167B2 RID: 92082 RVA: 0x0033FF77 File Offset: 0x0033E177
		public IFlipperConditionStepBaseT AsIFlipperConditionStepBase()
		{
			return this.As<IFlipperConditionStepBaseT>();
		}

		// Token: 0x060167B3 RID: 92083 RVA: 0x0033FF7F File Offset: 0x0033E17F
		public static IFlipperConditionStepBase_UnionUnion FromIFlipperConditionStepBase(IFlipperConditionStepBaseT _iflipperconditionstepbase)
		{
			return new IFlipperConditionStepBase_UnionUnion
			{
				Type = IFlipperConditionStepBase_Union.IFlipperConditionStepBase,
				Value = _iflipperconditionstepbase
			};
		}

		// Token: 0x060167B4 RID: 92084 RVA: 0x0033FF94 File Offset: 0x0033E194
		public IFlipperConditionStepFightT AsIFlipperConditionStepFight()
		{
			return this.As<IFlipperConditionStepFightT>();
		}

		// Token: 0x060167B5 RID: 92085 RVA: 0x0033FF9C File Offset: 0x0033E19C
		public static IFlipperConditionStepBase_UnionUnion FromIFlipperConditionStepFight(IFlipperConditionStepFightT _iflipperconditionstepfight)
		{
			return new IFlipperConditionStepBase_UnionUnion
			{
				Type = IFlipperConditionStepBase_Union.IFlipperConditionStepFight,
				Value = _iflipperconditionstepfight
			};
		}

		// Token: 0x060167B6 RID: 92086 RVA: 0x0033FFB4 File Offset: 0x0033E1B4
		public static int Pack(FlatBufferBuilder builder, IFlipperConditionStepBase_UnionUnion _o)
		{
			IFlipperConditionStepBase_Union type = _o.Type;
			if (type == IFlipperConditionStepBase_Union.IFlipperConditionStepBase)
			{
				return IFlipperConditionStepBase.Pack(builder, _o.AsIFlipperConditionStepBase()).Value;
			}
			if (type != IFlipperConditionStepBase_Union.IFlipperConditionStepFight)
			{
				return 0;
			}
			return IFlipperConditionStepFight.Pack(builder, _o.AsIFlipperConditionStepFight()).Value;
		}
	}
}
