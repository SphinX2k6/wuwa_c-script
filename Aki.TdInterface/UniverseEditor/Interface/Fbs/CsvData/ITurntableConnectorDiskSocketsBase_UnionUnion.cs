using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DBF RID: 19903
	public class ITurntableConnectorDiskSocketsBase_UnionUnion
	{
		// Token: 0x17008E61 RID: 36449
		// (get) Token: 0x0601EE11 RID: 126481 RVA: 0x00450831 File Offset: 0x0044EA31
		// (set) Token: 0x0601EE12 RID: 126482 RVA: 0x00450839 File Offset: 0x0044EA39
		public ITurntableConnectorDiskSocketsBase_Union Type { get; set; }

		// Token: 0x17008E62 RID: 36450
		// (get) Token: 0x0601EE13 RID: 126483 RVA: 0x00450842 File Offset: 0x0044EA42
		// (set) Token: 0x0601EE14 RID: 126484 RVA: 0x0045084A File Offset: 0x0044EA4A
		public object Value { get; set; }

		// Token: 0x0601EE15 RID: 126485 RVA: 0x00450853 File Offset: 0x0044EA53
		public ITurntableConnectorDiskSocketsBase_UnionUnion()
		{
			this.Type = ITurntableConnectorDiskSocketsBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601EE16 RID: 126486 RVA: 0x00450869 File Offset: 0x0044EA69
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601EE17 RID: 126487 RVA: 0x0045087B File Offset: 0x0044EA7B
		public ITurntableConnectorDiskSocketsBaseT AsITurntableConnectorDiskSocketsBase()
		{
			return this.As<ITurntableConnectorDiskSocketsBaseT>();
		}

		// Token: 0x0601EE18 RID: 126488 RVA: 0x00450883 File Offset: 0x0044EA83
		public static ITurntableConnectorDiskSocketsBase_UnionUnion FromITurntableConnectorDiskSocketsBase(ITurntableConnectorDiskSocketsBaseT _iturntableconnectordisksocketsbase)
		{
			return new ITurntableConnectorDiskSocketsBase_UnionUnion
			{
				Type = ITurntableConnectorDiskSocketsBase_Union.ITurntableConnectorDiskSocketsBase,
				Value = _iturntableconnectordisksocketsbase
			};
		}

		// Token: 0x0601EE19 RID: 126489 RVA: 0x00450898 File Offset: 0x0044EA98
		public ITurntableConnectorNormalDiskSocketsT AsITurntableConnectorNormalDiskSockets()
		{
			return this.As<ITurntableConnectorNormalDiskSocketsT>();
		}

		// Token: 0x0601EE1A RID: 126490 RVA: 0x004508A0 File Offset: 0x0044EAA0
		public static ITurntableConnectorDiskSocketsBase_UnionUnion FromITurntableConnectorNormalDiskSockets(ITurntableConnectorNormalDiskSocketsT _iturntableconnectornormaldisksockets)
		{
			return new ITurntableConnectorDiskSocketsBase_UnionUnion
			{
				Type = ITurntableConnectorDiskSocketsBase_Union.ITurntableConnectorNormalDiskSockets,
				Value = _iturntableconnectornormaldisksockets
			};
		}

		// Token: 0x0601EE1B RID: 126491 RVA: 0x004508B8 File Offset: 0x0044EAB8
		public static int Pack(FlatBufferBuilder builder, ITurntableConnectorDiskSocketsBase_UnionUnion _o)
		{
			ITurntableConnectorDiskSocketsBase_Union type = _o.Type;
			if (type == ITurntableConnectorDiskSocketsBase_Union.ITurntableConnectorDiskSocketsBase)
			{
				return ITurntableConnectorDiskSocketsBase.Pack(builder, _o.AsITurntableConnectorDiskSocketsBase()).Value;
			}
			if (type != ITurntableConnectorDiskSocketsBase_Union.ITurntableConnectorNormalDiskSockets)
			{
				return 0;
			}
			return ITurntableConnectorNormalDiskSockets.Pack(builder, _o.AsITurntableConnectorNormalDiskSockets()).Value;
		}
	}
}
