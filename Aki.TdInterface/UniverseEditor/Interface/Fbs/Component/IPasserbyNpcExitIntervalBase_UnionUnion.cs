using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6A RID: 23658
	public class IPasserbyNpcExitIntervalBase_UnionUnion
	{
		// Token: 0x1700ADDE RID: 44510
		// (get) Token: 0x060273F7 RID: 160759 RVA: 0x005605D9 File Offset: 0x0055E7D9
		// (set) Token: 0x060273F8 RID: 160760 RVA: 0x005605E1 File Offset: 0x0055E7E1
		public IPasserbyNpcExitIntervalBase_Union Type { get; set; }

		// Token: 0x1700ADDF RID: 44511
		// (get) Token: 0x060273F9 RID: 160761 RVA: 0x005605EA File Offset: 0x0055E7EA
		// (set) Token: 0x060273FA RID: 160762 RVA: 0x005605F2 File Offset: 0x0055E7F2
		public object Value { get; set; }

		// Token: 0x060273FB RID: 160763 RVA: 0x005605FB File Offset: 0x0055E7FB
		public IPasserbyNpcExitIntervalBase_UnionUnion()
		{
			this.Type = IPasserbyNpcExitIntervalBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060273FC RID: 160764 RVA: 0x00560611 File Offset: 0x0055E811
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060273FD RID: 160765 RVA: 0x00560623 File Offset: 0x0055E823
		public IPasserbyNpcExitIntervalBaseT AsIPasserbyNpcExitIntervalBase()
		{
			return this.As<IPasserbyNpcExitIntervalBaseT>();
		}

		// Token: 0x060273FE RID: 160766 RVA: 0x0056062B File Offset: 0x0055E82B
		public static IPasserbyNpcExitIntervalBase_UnionUnion FromIPasserbyNpcExitIntervalBase(IPasserbyNpcExitIntervalBaseT _ipasserbynpcexitintervalbase)
		{
			return new IPasserbyNpcExitIntervalBase_UnionUnion
			{
				Type = IPasserbyNpcExitIntervalBase_Union.IPasserbyNpcExitIntervalBase,
				Value = _ipasserbynpcexitintervalbase
			};
		}

		// Token: 0x060273FF RID: 160767 RVA: 0x00560640 File Offset: 0x0055E840
		public IPasserbyNpcPerNpcRandomExitIntervalT AsIPasserbyNpcPerNpcRandomExitInterval()
		{
			return this.As<IPasserbyNpcPerNpcRandomExitIntervalT>();
		}

		// Token: 0x06027400 RID: 160768 RVA: 0x00560648 File Offset: 0x0055E848
		public static IPasserbyNpcExitIntervalBase_UnionUnion FromIPasserbyNpcPerNpcRandomExitInterval(IPasserbyNpcPerNpcRandomExitIntervalT _ipasserbynpcpernpcrandomexitinterval)
		{
			return new IPasserbyNpcExitIntervalBase_UnionUnion
			{
				Type = IPasserbyNpcExitIntervalBase_Union.IPasserbyNpcPerNpcRandomExitInterval,
				Value = _ipasserbynpcpernpcrandomexitinterval
			};
		}

		// Token: 0x06027401 RID: 160769 RVA: 0x00560660 File Offset: 0x0055E860
		public static int Pack(FlatBufferBuilder builder, IPasserbyNpcExitIntervalBase_UnionUnion _o)
		{
			IPasserbyNpcExitIntervalBase_Union type = _o.Type;
			if (type == IPasserbyNpcExitIntervalBase_Union.IPasserbyNpcExitIntervalBase)
			{
				return IPasserbyNpcExitIntervalBase.Pack(builder, _o.AsIPasserbyNpcExitIntervalBase()).Value;
			}
			if (type != IPasserbyNpcExitIntervalBase_Union.IPasserbyNpcPerNpcRandomExitInterval)
			{
				return 0;
			}
			return IPasserbyNpcPerNpcRandomExitInterval.Pack(builder, _o.AsIPasserbyNpcPerNpcRandomExitInterval()).Value;
		}
	}
}
