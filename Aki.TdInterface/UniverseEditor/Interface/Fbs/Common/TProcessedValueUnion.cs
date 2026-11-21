using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064D7 RID: 25815
	public class TProcessedValueUnion
	{
		// Token: 0x1700BE4A RID: 48714
		// (get) Token: 0x0602BE06 RID: 179718 RVA: 0x005F7482 File Offset: 0x005F5682
		// (set) Token: 0x0602BE07 RID: 179719 RVA: 0x005F748A File Offset: 0x005F568A
		public TProcessedValue Type { get; set; }

		// Token: 0x1700BE4B RID: 48715
		// (get) Token: 0x0602BE08 RID: 179720 RVA: 0x005F7493 File Offset: 0x005F5693
		// (set) Token: 0x0602BE09 RID: 179721 RVA: 0x005F749B File Offset: 0x005F569B
		public object Value { get; set; }

		// Token: 0x0602BE0A RID: 179722 RVA: 0x005F74A4 File Offset: 0x005F56A4
		public TProcessedValueUnion()
		{
			this.Type = TProcessedValue.NONE;
			this.Value = null;
		}

		// Token: 0x0602BE0B RID: 179723 RVA: 0x005F74BA File Offset: 0x005F56BA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BE0C RID: 179724 RVA: 0x005F74CC File Offset: 0x005F56CC
		public IProcessedValueConstantT AsIProcessedValueConstant()
		{
			return this.As<IProcessedValueConstantT>();
		}

		// Token: 0x0602BE0D RID: 179725 RVA: 0x005F74D4 File Offset: 0x005F56D4
		public static TProcessedValueUnion FromIProcessedValueConstant(IProcessedValueConstantT _iprocessedvalueconstant)
		{
			return new TProcessedValueUnion
			{
				Type = TProcessedValue.IProcessedValueConstant,
				Value = _iprocessedvalueconstant
			};
		}

		// Token: 0x0602BE0E RID: 179726 RVA: 0x005F74E9 File Offset: 0x005F56E9
		public IProcessedValueConstraintT AsIProcessedValueConstraint()
		{
			return this.As<IProcessedValueConstraintT>();
		}

		// Token: 0x0602BE0F RID: 179727 RVA: 0x005F74F1 File Offset: 0x005F56F1
		public static TProcessedValueUnion FromIProcessedValueConstraint(IProcessedValueConstraintT _iprocessedvalueconstraint)
		{
			return new TProcessedValueUnion
			{
				Type = TProcessedValue.IProcessedValueConstraint,
				Value = _iprocessedvalueconstraint
			};
		}

		// Token: 0x0602BE10 RID: 179728 RVA: 0x005F7508 File Offset: 0x005F5708
		public static int Pack(FlatBufferBuilder builder, TProcessedValueUnion _o)
		{
			TProcessedValue type = _o.Type;
			if (type == TProcessedValue.IProcessedValueConstant)
			{
				return IProcessedValueConstant.Pack(builder, _o.AsIProcessedValueConstant()).Value;
			}
			if (type != TProcessedValue.IProcessedValueConstraint)
			{
				return 0;
			}
			return IProcessedValueConstraint.Pack(builder, _o.AsIProcessedValueConstraint()).Value;
		}
	}
}
