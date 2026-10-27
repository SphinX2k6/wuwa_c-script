using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005874 RID: 22644
	public class IRoadNetworkNavigationType_UnionUnion
	{
		// Token: 0x1700A961 RID: 43361
		// (get) Token: 0x0602627A RID: 156282 RVA: 0x00542D2D File Offset: 0x00540F2D
		// (set) Token: 0x0602627B RID: 156283 RVA: 0x00542D35 File Offset: 0x00540F35
		public IRoadNetworkNavigationType_Union Type { get; set; }

		// Token: 0x1700A962 RID: 43362
		// (get) Token: 0x0602627C RID: 156284 RVA: 0x00542D3E File Offset: 0x00540F3E
		// (set) Token: 0x0602627D RID: 156285 RVA: 0x00542D46 File Offset: 0x00540F46
		public object Value { get; set; }

		// Token: 0x0602627E RID: 156286 RVA: 0x00542D4F File Offset: 0x00540F4F
		public IRoadNetworkNavigationType_UnionUnion()
		{
			this.Type = IRoadNetworkNavigationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602627F RID: 156287 RVA: 0x00542D65 File Offset: 0x00540F65
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026280 RID: 156288 RVA: 0x00542D77 File Offset: 0x00540F77
		public IRoadNetworkNavigationTypeT AsIRoadNetworkNavigationType()
		{
			return this.As<IRoadNetworkNavigationTypeT>();
		}

		// Token: 0x06026281 RID: 156289 RVA: 0x00542D7F File Offset: 0x00540F7F
		public static IRoadNetworkNavigationType_UnionUnion FromIRoadNetworkNavigationType(IRoadNetworkNavigationTypeT _iroadnetworknavigationtype)
		{
			return new IRoadNetworkNavigationType_UnionUnion
			{
				Type = IRoadNetworkNavigationType_Union.IRoadNetworkNavigationType,
				Value = _iroadnetworknavigationtype
			};
		}

		// Token: 0x06026282 RID: 156290 RVA: 0x00542D94 File Offset: 0x00540F94
		public ITrafficNavigationConfigT AsITrafficNavigationConfig()
		{
			return this.As<ITrafficNavigationConfigT>();
		}

		// Token: 0x06026283 RID: 156291 RVA: 0x00542D9C File Offset: 0x00540F9C
		public static IRoadNetworkNavigationType_UnionUnion FromITrafficNavigationConfig(ITrafficNavigationConfigT _itrafficnavigationconfig)
		{
			return new IRoadNetworkNavigationType_UnionUnion
			{
				Type = IRoadNetworkNavigationType_Union.ITrafficNavigationConfig,
				Value = _itrafficnavigationconfig
			};
		}

		// Token: 0x06026284 RID: 156292 RVA: 0x00542DB4 File Offset: 0x00540FB4
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
