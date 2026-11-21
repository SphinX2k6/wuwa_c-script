using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DB6 RID: 19894
	public class ITurntableConnectorAssetsBase_UnionUnion
	{
		// Token: 0x17008E57 RID: 36439
		// (get) Token: 0x0601EDDB RID: 126427 RVA: 0x00450389 File Offset: 0x0044E589
		// (set) Token: 0x0601EDDC RID: 126428 RVA: 0x00450391 File Offset: 0x0044E591
		public ITurntableConnectorAssetsBase_Union Type { get; set; }

		// Token: 0x17008E58 RID: 36440
		// (get) Token: 0x0601EDDD RID: 126429 RVA: 0x0045039A File Offset: 0x0044E59A
		// (set) Token: 0x0601EDDE RID: 126430 RVA: 0x004503A2 File Offset: 0x0044E5A2
		public object Value { get; set; }

		// Token: 0x0601EDDF RID: 126431 RVA: 0x004503AB File Offset: 0x0044E5AB
		public ITurntableConnectorAssetsBase_UnionUnion()
		{
			this.Type = ITurntableConnectorAssetsBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EDE0 RID: 126432 RVA: 0x004503C1 File Offset: 0x0044E5C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EDE1 RID: 126433 RVA: 0x004503D3 File Offset: 0x0044E5D3
		public ITurntableConnectorAssetsBaseT AsITurntableConnectorAssetsBase()
		{
			return this.As<ITurntableConnectorAssetsBaseT>();
		}

		// Token: 0x0601EDE2 RID: 126434 RVA: 0x004503DB File Offset: 0x0044E5DB
		public static ITurntableConnectorAssetsBase_UnionUnion FromITurntableConnectorAssetsBase(ITurntableConnectorAssetsBaseT _iturntableconnectorassetsbase)
		{
			return new ITurntableConnectorAssetsBase_UnionUnion
			{
				Type = ITurntableConnectorAssetsBase_Union.ITurntableConnectorAssetsBase,
				Value = _iturntableconnectorassetsbase
			};
		}

		// Token: 0x0601EDE3 RID: 126435 RVA: 0x004503F0 File Offset: 0x0044E5F0
		public ICircuitConnectAssetsT AsICircuitConnectAssets()
		{
			return this.As<ICircuitConnectAssetsT>();
		}

		// Token: 0x0601EDE4 RID: 126436 RVA: 0x004503F8 File Offset: 0x0044E5F8
		public static ITurntableConnectorAssetsBase_UnionUnion FromICircuitConnectAssets(ICircuitConnectAssetsT _icircuitconnectassets)
		{
			return new ITurntableConnectorAssetsBase_UnionUnion
			{
				Type = ITurntableConnectorAssetsBase_Union.ICircuitConnectAssets,
				Value = _icircuitconnectassets
			};
		}

		// Token: 0x0601EDE5 RID: 126437 RVA: 0x00450410 File Offset: 0x0044E610
		public static int Pack(FlatBufferBuilder builder, ITurntableConnectorAssetsBase_UnionUnion _o)
		{
			ITurntableConnectorAssetsBase_Union type = _o.Type;
			if (type == ITurntableConnectorAssetsBase_Union.ITurntableConnectorAssetsBase)
			{
				return ITurntableConnectorAssetsBase.Pack(builder, _o.AsITurntableConnectorAssetsBase()).Value;
			}
			if (type != ITurntableConnectorAssetsBase_Union.ICircuitConnectAssets)
			{
				return 0;
			}
			return ICircuitConnectAssets.Pack(builder, _o.AsICircuitConnectAssets()).Value;
		}
	}
}
