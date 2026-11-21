using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D1 RID: 26833
	public struct IBvbSendSystemEvent : IFlatbufferObject
	{
		// Token: 0x1700C538 RID: 50488
		// (get) Token: 0x0602DE89 RID: 188041 RVA: 0x00645FE9 File Offset: 0x006441E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE8A RID: 188042 RVA: 0x00645FF6 File Offset: 0x006441F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE8B RID: 188043 RVA: 0x00646000 File Offset: 0x00644200
		public static IBvbSendSystemEvent GetRootAsIBvbSendSystemEvent(ByteBuffer _bb)
		{
			return IBvbSendSystemEvent.GetRootAsIBvbSendSystemEvent(_bb, default(IBvbSendSystemEvent));
		}

		// Token: 0x0602DE8C RID: 188044 RVA: 0x0064601C File Offset: 0x0064421C
		public static IBvbSendSystemEvent GetRootAsIBvbSendSystemEvent(ByteBuffer _bb, IBvbSendSystemEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE8D RID: 188045 RVA: 0x00646039 File Offset: 0x00644239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE8E RID: 188046 RVA: 0x00646048 File Offset: 0x00644248
		public IBvbSendSystemEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C539 RID: 50489
		// (get) Token: 0x0602DE8F RID: 188047 RVA: 0x00646058 File Offset: 0x00644258
		public TBvbEventData EventDataType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TBvbEventData.NONE;
				}
				return (TBvbEventData)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DE90 RID: 188048 RVA: 0x00646094 File Offset: 0x00644294
		public TTable? EventData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DE91 RID: 188049 RVA: 0x006460D8 File Offset: 0x006442D8
		public IBvbAiBattleWinData EventDataAsIBvbAiBattleWinData()
		{
			return this.EventData<IBvbAiBattleWinData>().Value;
		}

		// Token: 0x0602DE92 RID: 188050 RVA: 0x006460F4 File Offset: 0x006442F4
		public IBvbAiChangeData EventDataAsIBvbAiChangeData()
		{
			return this.EventData<IBvbAiChangeData>().Value;
		}

		// Token: 0x0602DE93 RID: 188051 RVA: 0x00646110 File Offset: 0x00644310
		public IBvbAiDeployData EventDataAsIBvbAiDeployData()
		{
			return this.EventData<IBvbAiDeployData>().Value;
		}

		// Token: 0x0602DE94 RID: 188052 RVA: 0x0064612C File Offset: 0x0064432C
		public IBvbAiDiscardData EventDataAsIBvbAiDiscardData()
		{
			return this.EventData<IBvbAiDiscardData>().Value;
		}

		// Token: 0x0602DE95 RID: 188053 RVA: 0x00646148 File Offset: 0x00644348
		public IBvbAiDiscardForEnergyAndActData EventDataAsIBvbAiDiscardForEnergyAndActData()
		{
			return this.EventData<IBvbAiDiscardForEnergyAndActData>().Value;
		}

		// Token: 0x0602DE96 RID: 188054 RVA: 0x00646164 File Offset: 0x00644364
		public IBvbAiEvolutionData EventDataAsIBvbAiEvolutionData()
		{
			return this.EventData<IBvbAiEvolutionData>().Value;
		}

		// Token: 0x0602DE97 RID: 188055 RVA: 0x00646180 File Offset: 0x00644380
		public IBvbAiGetBestDeployData EventDataAsIBvbAiGetBestDeployData()
		{
			return this.EventData<IBvbAiGetBestDeployData>().Value;
		}

		// Token: 0x0602DE98 RID: 188056 RVA: 0x0064619C File Offset: 0x0064439C
		public IBvbAiGetBestRearrangeData EventDataAsIBvbAiGetBestRearrangeData()
		{
			return this.EventData<IBvbAiGetBestRearrangeData>().Value;
		}

		// Token: 0x0602DE99 RID: 188057 RVA: 0x006461B8 File Offset: 0x006443B8
		public IBvbAiGetBestReplaceData EventDataAsIBvbAiGetBestReplaceData()
		{
			return this.EventData<IBvbAiGetBestReplaceData>().Value;
		}

		// Token: 0x0602DE9A RID: 188058 RVA: 0x006461D4 File Offset: 0x006443D4
		public IBvbAiGetBestSwapData EventDataAsIBvbAiGetBestSwapData()
		{
			return this.EventData<IBvbAiGetBestSwapData>().Value;
		}

		// Token: 0x0602DE9B RID: 188059 RVA: 0x006461F0 File Offset: 0x006443F0
		public IBvbAiRearrangeData EventDataAsIBvbAiRearrangeData()
		{
			return this.EventData<IBvbAiRearrangeData>().Value;
		}

		// Token: 0x0602DE9C RID: 188060 RVA: 0x0064620C File Offset: 0x0064440C
		public IBvbAiRecycleData EventDataAsIBvbAiRecycleData()
		{
			return this.EventData<IBvbAiRecycleData>().Value;
		}

		// Token: 0x0602DE9D RID: 188061 RVA: 0x00646228 File Offset: 0x00644428
		public IBvbAiSwapData EventDataAsIBvbAiSwapData()
		{
			return this.EventData<IBvbAiSwapData>().Value;
		}

		// Token: 0x0602DE9E RID: 188062 RVA: 0x00646244 File Offset: 0x00644444
		public IBvbAiTurnEndData EventDataAsIBvbAiTurnEndData()
		{
			return this.EventData<IBvbAiTurnEndData>().Value;
		}

		// Token: 0x0602DE9F RID: 188063 RVA: 0x00646260 File Offset: 0x00644460
		public IBvbBurnBuffTimeUpData EventDataAsIBvbBurnBuffTimeUpData()
		{
			return this.EventData<IBvbBurnBuffTimeUpData>().Value;
		}

		// Token: 0x0602DEA0 RID: 188064 RVA: 0x0064627C File Offset: 0x0064447C
		public IBvbEnableHatredData EventDataAsIBvbEnableHatredData()
		{
			return this.EventData<IBvbEnableHatredData>().Value;
		}

		// Token: 0x0602DEA1 RID: 188065 RVA: 0x00646298 File Offset: 0x00644498
		public IBvbPlayerBattleWinData EventDataAsIBvbPlayerBattleWinData()
		{
			return this.EventData<IBvbPlayerBattleWinData>().Value;
		}

		// Token: 0x0602DEA2 RID: 188066 RVA: 0x006462B4 File Offset: 0x006444B4
		public IBvbPlayerTurnEndData EventDataAsIBvbPlayerTurnEndData()
		{
			return this.EventData<IBvbPlayerTurnEndData>().Value;
		}

		// Token: 0x0602DEA3 RID: 188067 RVA: 0x006462D0 File Offset: 0x006444D0
		public IBvbPlayerTurnStartData EventDataAsIBvbPlayerTurnStartData()
		{
			return this.EventData<IBvbPlayerTurnStartData>().Value;
		}

		// Token: 0x0602DEA4 RID: 188068 RVA: 0x006462EC File Offset: 0x006444EC
		public IBvbSelectCardsEndData EventDataAsIBvbSelectCardsEndData()
		{
			return this.EventData<IBvbSelectCardsEndData>().Value;
		}

		// Token: 0x0602DEA5 RID: 188069 RVA: 0x00646308 File Offset: 0x00644508
		public IBvbStartAiData EventDataAsIBvbStartAiData()
		{
			return this.EventData<IBvbStartAiData>().Value;
		}

		// Token: 0x0602DEA6 RID: 188070 RVA: 0x00646324 File Offset: 0x00644524
		public IBvbStartBattleData EventDataAsIBvbStartBattleData()
		{
			return this.EventData<IBvbStartBattleData>().Value;
		}

		// Token: 0x0602DEA7 RID: 188071 RVA: 0x00646340 File Offset: 0x00644540
		public IBvbStartRoundData EventDataAsIBvbStartRoundData()
		{
			return this.EventData<IBvbStartRoundData>().Value;
		}

		// Token: 0x0602DEA8 RID: 188072 RVA: 0x0064635C File Offset: 0x0064455C
		public IBvbWaitForGameBeginData EventDataAsIBvbWaitForGameBeginData()
		{
			return this.EventData<IBvbWaitForGameBeginData>().Value;
		}

		// Token: 0x0602DEA9 RID: 188073 RVA: 0x00646377 File Offset: 0x00644577
		public static Offset<IBvbSendSystemEvent> CreateIBvbSendSystemEvent(FlatBufferBuilder builder, TBvbEventData EventData_type = TBvbEventData.NONE, int EventDataOffset = 0)
		{
			builder.StartTable(2);
			IBvbSendSystemEvent.AddEventData(builder, EventDataOffset);
			IBvbSendSystemEvent.AddEventDataType(builder, EventData_type);
			return IBvbSendSystemEvent.EndIBvbSendSystemEvent(builder);
		}

		// Token: 0x0602DEAA RID: 188074 RVA: 0x00646394 File Offset: 0x00644594
		public static void StartIBvbSendSystemEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DEAB RID: 188075 RVA: 0x0064639D File Offset: 0x0064459D
		public static void AddEventDataType(FlatBufferBuilder builder, TBvbEventData eventDataType)
		{
			builder.AddByte(0, (byte)eventDataType, 0);
		}

		// Token: 0x0602DEAC RID: 188076 RVA: 0x006463A8 File Offset: 0x006445A8
		public static void AddEventData(FlatBufferBuilder builder, int eventDataOffset)
		{
			builder.AddOffset(1, eventDataOffset, 0);
		}

		// Token: 0x0602DEAD RID: 188077 RVA: 0x006463B3 File Offset: 0x006445B3
		public static Offset<IBvbSendSystemEvent> EndIBvbSendSystemEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSendSystemEvent>(builder.EndTable());
		}

		// Token: 0x0602DEAE RID: 188078 RVA: 0x006463C0 File Offset: 0x006445C0
		public IBvbSendSystemEventT UnPack()
		{
			IBvbSendSystemEventT bvbSendSystemEventT = new IBvbSendSystemEventT();
			this.UnPackTo(bvbSendSystemEventT);
			return bvbSendSystemEventT;
		}

		// Token: 0x0602DEAF RID: 188079 RVA: 0x006463DC File Offset: 0x006445DC
		public void UnPackTo(IBvbSendSystemEventT _o)
		{
			_o.EventData = new TBvbEventDataUnion();
			_o.EventData.Type = this.EventDataType;
			switch (this.EventDataType)
			{
			case TBvbEventData.IBvbAiBattleWinData:
				_o.EventData.Value = ((this.EventData<IBvbAiBattleWinData>() != null) ? this.EventData<IBvbAiBattleWinData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiChangeData:
				_o.EventData.Value = ((this.EventData<IBvbAiChangeData>() != null) ? this.EventData<IBvbAiChangeData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiDeployData:
				_o.EventData.Value = ((this.EventData<IBvbAiDeployData>() != null) ? this.EventData<IBvbAiDeployData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiDiscardData:
				_o.EventData.Value = ((this.EventData<IBvbAiDiscardData>() != null) ? this.EventData<IBvbAiDiscardData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiDiscardForEnergyAndActData:
				_o.EventData.Value = ((this.EventData<IBvbAiDiscardForEnergyAndActData>() != null) ? this.EventData<IBvbAiDiscardForEnergyAndActData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiEvolutionData:
				_o.EventData.Value = ((this.EventData<IBvbAiEvolutionData>() != null) ? this.EventData<IBvbAiEvolutionData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiGetBestDeployData:
				_o.EventData.Value = ((this.EventData<IBvbAiGetBestDeployData>() != null) ? this.EventData<IBvbAiGetBestDeployData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiGetBestRearrangeData:
				_o.EventData.Value = ((this.EventData<IBvbAiGetBestRearrangeData>() != null) ? this.EventData<IBvbAiGetBestRearrangeData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiGetBestReplaceData:
				_o.EventData.Value = ((this.EventData<IBvbAiGetBestReplaceData>() != null) ? this.EventData<IBvbAiGetBestReplaceData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiGetBestSwapData:
				_o.EventData.Value = ((this.EventData<IBvbAiGetBestSwapData>() != null) ? this.EventData<IBvbAiGetBestSwapData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiRearrangeData:
				_o.EventData.Value = ((this.EventData<IBvbAiRearrangeData>() != null) ? this.EventData<IBvbAiRearrangeData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiRecycleData:
				_o.EventData.Value = ((this.EventData<IBvbAiRecycleData>() != null) ? this.EventData<IBvbAiRecycleData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiSwapData:
				_o.EventData.Value = ((this.EventData<IBvbAiSwapData>() != null) ? this.EventData<IBvbAiSwapData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbAiTurnEndData:
				_o.EventData.Value = ((this.EventData<IBvbAiTurnEndData>() != null) ? this.EventData<IBvbAiTurnEndData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbBurnBuffTimeUpData:
				_o.EventData.Value = ((this.EventData<IBvbBurnBuffTimeUpData>() != null) ? this.EventData<IBvbBurnBuffTimeUpData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbEnableHatredData:
				_o.EventData.Value = ((this.EventData<IBvbEnableHatredData>() != null) ? this.EventData<IBvbEnableHatredData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbPlayerBattleWinData:
				_o.EventData.Value = ((this.EventData<IBvbPlayerBattleWinData>() != null) ? this.EventData<IBvbPlayerBattleWinData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbPlayerTurnEndData:
				_o.EventData.Value = ((this.EventData<IBvbPlayerTurnEndData>() != null) ? this.EventData<IBvbPlayerTurnEndData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbPlayerTurnStartData:
				_o.EventData.Value = ((this.EventData<IBvbPlayerTurnStartData>() != null) ? this.EventData<IBvbPlayerTurnStartData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbSelectCardsEndData:
				_o.EventData.Value = ((this.EventData<IBvbSelectCardsEndData>() != null) ? this.EventData<IBvbSelectCardsEndData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbStartAiData:
				_o.EventData.Value = ((this.EventData<IBvbStartAiData>() != null) ? this.EventData<IBvbStartAiData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbStartBattleData:
				_o.EventData.Value = ((this.EventData<IBvbStartBattleData>() != null) ? this.EventData<IBvbStartBattleData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbStartRoundData:
				_o.EventData.Value = ((this.EventData<IBvbStartRoundData>() != null) ? this.EventData<IBvbStartRoundData>().Value.UnPack() : null);
				return;
			case TBvbEventData.IBvbWaitForGameBeginData:
				_o.EventData.Value = ((this.EventData<IBvbWaitForGameBeginData>() != null) ? this.EventData<IBvbWaitForGameBeginData>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602DEB0 RID: 188080 RVA: 0x006469B0 File Offset: 0x00644BB0
		public static Offset<IBvbSendSystemEvent> Pack(FlatBufferBuilder builder, IBvbSendSystemEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSendSystemEvent>);
			}
			TBvbEventData eventData_type = (_o.EventData == null) ? TBvbEventData.NONE : _o.EventData.Type;
			int eventDataOffset = (_o.EventData == null) ? 0 : TBvbEventDataUnion.Pack(builder, _o.EventData);
			return IBvbSendSystemEvent.CreateIBvbSendSystemEvent(builder, eventData_type, eventDataOffset);
		}

		// Token: 0x040115D1 RID: 71121
		private Table __p;
	}
}
