using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006107 RID: 24839
	public class ITurntableConnectorGameplayBase_UnionUnion
	{
		// Token: 0x1700B8EB RID: 47339
		// (get) Token: 0x0602A1A4 RID: 172452 RVA: 0x005BF2E1 File Offset: 0x005BD4E1
		// (set) Token: 0x0602A1A5 RID: 172453 RVA: 0x005BF2E9 File Offset: 0x005BD4E9
		public ITurntableConnectorGameplayBase_Union Type { get; set; }

		// Token: 0x1700B8EC RID: 47340
		// (get) Token: 0x0602A1A6 RID: 172454 RVA: 0x005BF2F2 File Offset: 0x005BD4F2
		// (set) Token: 0x0602A1A7 RID: 172455 RVA: 0x005BF2FA File Offset: 0x005BD4FA
		public object Value { get; set; }

		// Token: 0x0602A1A8 RID: 172456 RVA: 0x005BF303 File Offset: 0x005BD503
		public ITurntableConnectorGameplayBase_UnionUnion()
		{
			this.Type = ITurntableConnectorGameplayBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A1A9 RID: 172457 RVA: 0x005BF319 File Offset: 0x005BD519
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A1AA RID: 172458 RVA: 0x005BF32B File Offset: 0x005BD52B
		public ITurntableConnectorGameplayBaseT AsITurntableConnectorGameplayBase()
		{
			return this.As<ITurntableConnectorGameplayBaseT>();
		}

		// Token: 0x0602A1AB RID: 172459 RVA: 0x005BF333 File Offset: 0x005BD533
		public static ITurntableConnectorGameplayBase_UnionUnion FromITurntableConnectorGameplayBase(ITurntableConnectorGameplayBaseT _iturntableconnectorgameplaybase)
		{
			return new ITurntableConnectorGameplayBase_UnionUnion
			{
				Type = ITurntableConnectorGameplayBase_Union.ITurntableConnectorGameplayBase,
				Value = _iturntableconnectorgameplaybase
			};
		}

		// Token: 0x0602A1AC RID: 172460 RVA: 0x005BF348 File Offset: 0x005BD548
		public ICircuitConnectT AsICircuitConnect()
		{
			return this.As<ICircuitConnectT>();
		}

		// Token: 0x0602A1AD RID: 172461 RVA: 0x005BF350 File Offset: 0x005BD550
		public static ITurntableConnectorGameplayBase_UnionUnion FromICircuitConnect(ICircuitConnectT _icircuitconnect)
		{
			return new ITurntableConnectorGameplayBase_UnionUnion
			{
				Type = ITurntableConnectorGameplayBase_Union.ICircuitConnect,
				Value = _icircuitconnect
			};
		}

		// Token: 0x0602A1AE RID: 172462 RVA: 0x005BF368 File Offset: 0x005BD568
		public static int Pack(FlatBufferBuilder builder, ITurntableConnectorGameplayBase_UnionUnion _o)
		{
			ITurntableConnectorGameplayBase_Union type = _o.Type;
			if (type == ITurntableConnectorGameplayBase_Union.ITurntableConnectorGameplayBase)
			{
				return ITurntableConnectorGameplayBase.Pack(builder, _o.AsITurntableConnectorGameplayBase()).Value;
			}
			if (type != ITurntableConnectorGameplayBase_Union.ICircuitConnect)
			{
				return 0;
			}
			return ICircuitConnect.Pack(builder, _o.AsICircuitConnect()).Value;
		}
	}
}
