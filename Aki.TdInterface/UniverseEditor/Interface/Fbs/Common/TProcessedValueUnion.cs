using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E94 RID: 24212
	public class TProcessedValueUnion
	{
		// Token: 0x1700B4DF RID: 46303
		// (get) Token: 0x0602975E RID: 169822 RVA: 0x005AE4DE File Offset: 0x005AC6DE
		// (set) Token: 0x0602975F RID: 169823 RVA: 0x005AE4E6 File Offset: 0x005AC6E6
		public TProcessedValue Type { get; set; }

		// Token: 0x1700B4E0 RID: 46304
		// (get) Token: 0x06029760 RID: 169824 RVA: 0x005AE4EF File Offset: 0x005AC6EF
		// (set) Token: 0x06029761 RID: 169825 RVA: 0x005AE4F7 File Offset: 0x005AC6F7
		public object Value { get; set; }

		// Token: 0x06029762 RID: 169826 RVA: 0x005AE500 File Offset: 0x005AC700
		public TProcessedValueUnion()
		{
			this.Type = TProcessedValue.NONE;
			this.Value = null;
		}

		// Token: 0x06029763 RID: 169827 RVA: 0x005AE516 File Offset: 0x005AC716
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029764 RID: 169828 RVA: 0x005AE528 File Offset: 0x005AC728
		public IProcessedValueConstantT AsIProcessedValueConstant()
		{
			return this.As<IProcessedValueConstantT>();
		}

		// Token: 0x06029765 RID: 169829 RVA: 0x005AE530 File Offset: 0x005AC730
		public static TProcessedValueUnion FromIProcessedValueConstant(IProcessedValueConstantT _iprocessedvalueconstant)
		{
			return new TProcessedValueUnion
			{
				Type = TProcessedValue.IProcessedValueConstant,
				Value = _iprocessedvalueconstant
			};
		}

		// Token: 0x06029766 RID: 169830 RVA: 0x005AE545 File Offset: 0x005AC745
		public IProcessedValueConstraintT AsIProcessedValueConstraint()
		{
			return this.As<IProcessedValueConstraintT>();
		}

		// Token: 0x06029767 RID: 169831 RVA: 0x005AE54D File Offset: 0x005AC74D
		public static TProcessedValueUnion FromIProcessedValueConstraint(IProcessedValueConstraintT _iprocessedvalueconstraint)
		{
			return new TProcessedValueUnion
			{
				Type = TProcessedValue.IProcessedValueConstraint,
				Value = _iprocessedvalueconstraint
			};
		}

		// Token: 0x06029768 RID: 169832 RVA: 0x005AE564 File Offset: 0x005AC764
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
