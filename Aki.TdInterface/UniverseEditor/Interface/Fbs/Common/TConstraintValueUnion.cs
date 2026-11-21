using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064B3 RID: 25779
	public class TConstraintValueUnion
	{
		// Token: 0x1700BE27 RID: 48679
		// (get) Token: 0x0602BD37 RID: 179511 RVA: 0x005F5DA6 File Offset: 0x005F3FA6
		// (set) Token: 0x0602BD38 RID: 179512 RVA: 0x005F5DAE File Offset: 0x005F3FAE
		public TConstraintValue Type { get; set; }

		// Token: 0x1700BE28 RID: 48680
		// (get) Token: 0x0602BD39 RID: 179513 RVA: 0x005F5DB7 File Offset: 0x005F3FB7
		// (set) Token: 0x0602BD3A RID: 179514 RVA: 0x005F5DBF File Offset: 0x005F3FBF
		public object Value { get; set; }

		// Token: 0x0602BD3B RID: 179515 RVA: 0x005F5DC8 File Offset: 0x005F3FC8
		public TConstraintValueUnion()
		{
			this.Type = TConstraintValue.NONE;
			this.Value = null;
		}

		// Token: 0x0602BD3C RID: 179516 RVA: 0x005F5DDE File Offset: 0x005F3FDE
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BD3D RID: 179517 RVA: 0x005F5DF0 File Offset: 0x005F3FF0
		public IConstraintValueClampT AsIConstraintValueClamp()
		{
			return this.As<IConstraintValueClampT>();
		}

		// Token: 0x0602BD3E RID: 179518 RVA: 0x005F5DF8 File Offset: 0x005F3FF8
		public static TConstraintValueUnion FromIConstraintValueClamp(IConstraintValueClampT _iconstraintvalueclamp)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueClamp,
				Value = _iconstraintvalueclamp
			};
		}

		// Token: 0x0602BD3F RID: 179519 RVA: 0x005F5E0D File Offset: 0x005F400D
		public IConstraintValueMaxT AsIConstraintValueMax()
		{
			return this.As<IConstraintValueMaxT>();
		}

		// Token: 0x0602BD40 RID: 179520 RVA: 0x005F5E15 File Offset: 0x005F4015
		public static TConstraintValueUnion FromIConstraintValueMax(IConstraintValueMaxT _iconstraintvaluemax)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueMax,
				Value = _iconstraintvaluemax
			};
		}

		// Token: 0x0602BD41 RID: 179521 RVA: 0x005F5E2A File Offset: 0x005F402A
		public IConstraintValueMinT AsIConstraintValueMin()
		{
			return this.As<IConstraintValueMinT>();
		}

		// Token: 0x0602BD42 RID: 179522 RVA: 0x005F5E32 File Offset: 0x005F4032
		public static TConstraintValueUnion FromIConstraintValueMin(IConstraintValueMinT _iconstraintvaluemin)
		{
			return new TConstraintValueUnion
			{
				Type = TConstraintValue.IConstraintValueMin,
				Value = _iconstraintvaluemin
			};
		}

		// Token: 0x0602BD43 RID: 179523 RVA: 0x005F5E48 File Offset: 0x005F4048
		public static int Pack(FlatBufferBuilder builder, TConstraintValueUnion _o)
		{
			switch (_o.Type)
			{
			case TConstraintValue.IConstraintValueClamp:
				return IConstraintValueClamp.Pack(builder, _o.AsIConstraintValueClamp()).Value;
			case TConstraintValue.IConstraintValueMax:
				return IConstraintValueMax.Pack(builder, _o.AsIConstraintValueMax()).Value;
			case TConstraintValue.IConstraintValueMin:
				return IConstraintValueMin.Pack(builder, _o.AsIConstraintValueMin()).Value;
			default:
				return 0;
			}
		}
	}
}
