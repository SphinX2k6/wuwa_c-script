using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E81 RID: 24193
	public class IRoadNetworkNavigationType_UnionUnion
	{
		// Token: 0x1700B291 RID: 45713
		// (get) Token: 0x060287DC RID: 165852 RVA: 0x00589879 File Offset: 0x00587A79
		// (set) Token: 0x060287DD RID: 165853 RVA: 0x00589881 File Offset: 0x00587A81
		public IRoadNetworkNavigationType_Union Type { get; set; }

		// Token: 0x1700B292 RID: 45714
		// (get) Token: 0x060287DE RID: 165854 RVA: 0x0058988A File Offset: 0x00587A8A
		// (set) Token: 0x060287DF RID: 165855 RVA: 0x00589892 File Offset: 0x00587A92
		public object Value { get; set; }

		// Token: 0x060287E0 RID: 165856 RVA: 0x0058989B File Offset: 0x00587A9B
		public IRoadNetworkNavigationType_UnionUnion()
		{
			this.Type = IRoadNetworkNavigationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060287E1 RID: 165857 RVA: 0x005898B1 File Offset: 0x00587AB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060287E2 RID: 165858 RVA: 0x005898C3 File Offset: 0x00587AC3
		public IRoadNetworkNavigationTypeT AsIRoadNetworkNavigationType()
		{
			return this.As<IRoadNetworkNavigationTypeT>();
		}

		// Token: 0x060287E3 RID: 165859 RVA: 0x005898CB File Offset: 0x00587ACB
		public static IRoadNetworkNavigationType_UnionUnion FromIRoadNetworkNavigationType(IRoadNetworkNavigationTypeT _iroadnetworknavigationtype)
		{
			return new IRoadNetworkNavigationType_UnionUnion
			{
				Type = IRoadNetworkNavigationType_Union.IRoadNetworkNavigationType,
				Value = _iroadnetworknavigationtype
			};
		}

		// Token: 0x060287E4 RID: 165860 RVA: 0x005898E0 File Offset: 0x00587AE0
		public ITrafficNavigationConfigT AsITrafficNavigationConfig()
		{
			return this.As<ITrafficNavigationConfigT>();
		}

		// Token: 0x060287E5 RID: 165861 RVA: 0x005898E8 File Offset: 0x00587AE8
		public static IRoadNetworkNavigationType_UnionUnion FromITrafficNavigationConfig(ITrafficNavigationConfigT _itrafficnavigationconfig)
		{
			return new IRoadNetworkNavigationType_UnionUnion
			{
				Type = IRoadNetworkNavigationType_Union.ITrafficNavigationConfig,
				Value = _itrafficnavigationconfig
			};
		}

		// Token: 0x060287E6 RID: 165862 RVA: 0x00589900 File Offset: 0x00587B00
		public static int Pack(FlatBufferBuilder builder, IRoadNetworkNavigationType_UnionUnion _o)
		{
			IRoadNetworkNavigationType_Union type = _o.Type;
			if (type == IRoadNetworkNavigationType_Union.IRoadNetworkNavigationType)
			{
				return IRoadNetworkNavigationType.Pack(builder, _o.AsIRoadNetworkNavigationType()).Value;
			}
			if (type != IRoadNetworkNavigationType_Union.ITrafficNavigationConfig)
			{
				return 0;
			}
			return ITrafficNavigationConfig.Pack(builder, _o.AsITrafficNavigationConfig()).Value;
		}
	}
}
