using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006260 RID: 25184
	public struct IBvbSendSystemEvent : IFlatbufferObject
	{
		// Token: 0x1700BBB0 RID: 48048
		// (get) Token: 0x0602B728 RID: 177960 RVA: 0x005FB1E1 File Offset: 0x005F93E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B729 RID: 177961 RVA: 0x005FB1EE File Offset: 0x005F93EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B72A RID: 177962 RVA: 0x005FB1F8 File Offset: 0x005F93F8
		public static IBvbSendSystemEvent GetRootAsIBvbSendSystemEvent(ByteBuffer _bb)
		{
			return IBvbSendSystemEvent.GetRootAsIBvbSendSystemEvent(_bb, default(IBvbSendSystemEvent));
		}

		// Token: 0x0602B72B RID: 177963 RVA: 0x005FB214 File Offset: 0x005F9414
		public static IBvbSendSystemEvent GetRootAsIBvbSendSystemEvent(ByteBuffer _bb, IBvbSendSystemEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B72C RID: 177964 RVA: 0x005FB231 File Offset: 0x005F9431
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B72D RID: 177965 RVA: 0x005FB240 File Offset: 0x005F9440
		public IBvbSendSystemEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBB1 RID: 48049
		// (get) Token: 0x0602B72E RID: 177966 RVA: 0x005FB250 File Offset: 0x005F9450
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

		// Token: 0x0602B72F RID: 177967 RVA: 0x005FB28C File Offset: 0x005F948C
		public TTable? EventData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B730 RID: 177968 RVA: 0x005FB2D0 File Offset: 0x005F94D0
		public IBvbAiBattleWinData EventDataAsIBvbAiBattleWinData()
		{
			return this.EventData<IBvbAiBattleWinData>().Value;
		}

		// Token: 0x0602B731 RID: 177969 RVA: 0x005FB2EC File Offset: 0x005F94EC
		public IBvbAiChangeData EventDataAsIBvbAiChangeData()
		{
			return this.EventData<IBvbAiChangeData>().Value;
		}

		// Token: 0x0602B732 RID: 177970 RVA: 0x005FB308 File Offset: 0x005F9508
		public IBvbAiDeployData EventDataAsIBvbAiDeployData()
		{
			return this.EventData<IBvbAiDeployData>().Value;
		}

		// Token: 0x0602B733 RID: 177971 RVA: 0x005FB324 File Offset: 0x005F9524
		public IBvbAiDiscardData EventDataAsIBvbAiDiscardData()
		{
			return this.EventData<IBvbAiDiscardData>().Value;
		}

		// Token: 0x0602B734 RID: 177972 RVA: 0x005FB340 File Offset: 0x005F9540
		public IBvbAiDiscardForEnergyAndActData EventDataAsIBvbAiDiscardForEnergyAndActData()
		{
			return this.EventData<IBvbAiDiscardForEnergyAndActData>().Value;
		}

		// Token: 0x0602B735 RID: 177973 RVA: 0x005FB35C File Offset: 0x005F955C
		public IBvbAiEvolutionData EventDataAsIBvbAiEvolutionData()
		{
			return this.EventData<IBvbAiEvolutionData>().Value;
		}

		// Token: 0x0602B736 RID: 177974 RVA: 0x005FB378 File Offset: 0x005F9578
		public IBvbAiGetBestDeployData EventDataAsIBvbAiGetBestDeployData()
		{
			return this.EventData<IBvbAiGetBestDeployData>().Value;
		}

		// Token: 0x0602B737 RID: 177975 RVA: 0x005FB394 File Offset: 0x005F9594
		public IBvbAiGetBestRearrangeData EventDataAsIBvbAiGetBestRearrangeData()
		{
			return this.EventData<IBvbAiGetBestRearrangeData>().Value;
		}

		// Token: 0x0602B738 RID: 177976 RVA: 0x005FB3B0 File Offset: 0x005F95B0
		public IBvbAiGetBestReplaceData EventDataAsIBvbAiGetBestReplaceData()
		{
			return this.EventData<IBvbAiGetBestReplaceData>().Value;
		}

		// Token: 0x0602B739 RID: 177977 RVA: 0x005FB3CC File Offset: 0x005F95CC
		public IBvbAiGetBestSwapData EventDataAsIBvbAiGetBestSwapData()
		{
			return this.EventData<IBvbAiGetBestSwapData>().Value;
		}

		// Token: 0x0602B73A RID: 177978 RVA: 0x005FB3E8 File Offset: 0x005F95E8
		public IBvbAiRearrangeData EventDataAsIBvbAiRearrangeData()
		{
			return this.EventData<IBvbAiRearrangeData>().Value;
		}

		// Token: 0x0602B73B RID: 177979 RVA: 0x005FB404 File Offset: 0x005F9604
		public IBvbAiRecycleData EventDataAsIBvbAiRecycleData()
		{
			return this.EventData<IBvbAiRecycleData>().Value;
		}

		// Token: 0x0602B73C RID: 177980 RVA: 0x005FB420 File Offset: 0x005F9620
		public IBvbAiSwapData EventDataAsIBvbAiSwapData()
		{
			return this.EventData<IBvbAiSwapData>().Value;
		}

		// Token: 0x0602B73D RID: 177981 RVA: 0x005FB43C File Offset: 0x005F963C
		public IBvbAiTurnEndData EventDataAsIBvbAiTurnEndData()
		{
			return this.EventData<IBvbAiTurnEndData>().Value;
		}

		// Token: 0x0602B73E RID: 177982 RVA: 0x005FB458 File Offset: 0x005F9658
		public IBvbBurnBuffTimeUpData EventDataAsIBvbBurnBuffTimeUpData()
		{
			return this.EventData<IBvbBurnBuffTimeUpData>().Value;
		}

		// Token: 0x0602B73F RID: 177983 RVA: 0x005FB474 File Offset: 0x005F9674
		public IBvbEnableHatredData EventDataAsIBvbEnableHatredData()
		{
			return this.EventData<IBvbEnableHatredData>().Value;
		}

		// Token: 0x0602B740 RID: 177984 RVA: 0x005FB490 File Offset: 0x005F9690
		public IBvbPlayerBattleWinData EventDataAsIBvbPlayerBattleWinData()
		{
			return this.EventData<IBvbPlayerBattleWinData>().Value;
		}

		// Token: 0x0602B741 RID: 177985 RVA: 0x005FB4AC File Offset: 0x005F96AC
		public IBvbPlayerTurnEndData EventDataAsIBvbPlayerTurnEndData()
		{
			return this.EventData<IBvbPlayerTurnEndData>().Value;
		}

		// Token: 0x0602B742 RID: 177986 RVA: 0x005FB4C8 File Offset: 0x005F96C8
		public IBvbPlayerTurnStartData EventDataAsIBvbPlayerTurnStartData()
		{
			return this.EventData<IBvbPlayerTurnStartData>().Value;
		}

		// Token: 0x0602B743 RID: 177987 RVA: 0x005FB4E4 File Offset: 0x005F96E4
		public IBvbSelectCardsEndData EventDataAsIBvbSelectCardsEndData()
		{
			return this.EventData<IBvbSelectCardsEndData>().Value;
		}

		// Token: 0x0602B744 RID: 177988 RVA: 0x005FB500 File Offset: 0x005F9700
		public IBvbStartAiData EventDataAsIBvbStartAiData()
		{
			return this.EventData<IBvbStartAiData>().Value;
		}

		// Token: 0x0602B745 RID: 177989 RVA: 0x005FB51C File Offset: 0x005F971C
		public IBvbStartBattleData EventDataAsIBvbStartBattleData()
		{
			return this.EventData<IBvbStartBattleData>().Value;
		}

		// Token: 0x0602B746 RID: 177990 RVA: 0x005FB538 File Offset: 0x005F9738
		public IBvbStartRoundData EventDataAsIBvbStartRoundData()
		{
			return this.EventData<IBvbStartRoundData>().Value;
		}

		// Token: 0x0602B747 RID: 177991 RVA: 0x005FB554 File Offset: 0x005F9754
		public IBvbWaitForGameBeginData EventDataAsIBvbWaitForGameBeginData()
		{
			return this.EventData<IBvbWaitForGameBeginData>().Value;
		}

		// Token: 0x0602B748 RID: 177992 RVA: 0x005FB56F File Offset: 0x005F976F
		public static Offset<IBvbSendSystemEvent> CreateIBvbSendSystemEvent(FlatBufferBuilder builder, TBvbEventData EventData_type = TBvbEventData.NONE, int EventDataOffset = 0)
		{
			builder.StartTable(2);
			IBvbSendSystemEvent.AddEventData(builder, EventDataOffset);
			IBvbSendSystemEvent.AddEventDataType(builder, EventData_type);
			return IBvbSendSystemEvent.EndIBvbSendSystemEvent(builder);
		}

		// Token: 0x0602B749 RID: 177993 RVA: 0x005FB58C File Offset: 0x005F978C
		public static void StartIBvbSendSystemEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B74A RID: 177994 RVA: 0x005FB595 File Offset: 0x005F9795
		public static void AddEventDataType(FlatBufferBuilder builder, TBvbEventData eventDataType)
		{
			builder.AddByte(0, (byte)eventDataType, 0);
		}

		// Token: 0x0602B74B RID: 177995 RVA: 0x005FB5A0 File Offset: 0x005F97A0
		public static void AddEventData(FlatBufferBuilder builder, int eventDataOffset)
		{
			builder.AddOffset(1, eventDataOffset, 0);
		}

		// Token: 0x0602B74C RID: 177996 RVA: 0x005FB5AB File Offset: 0x005F97AB
		public static Offset<IBvbSendSystemEvent> EndIBvbSendSystemEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSendSystemEvent>(builder.EndTable());
		}

		// Token: 0x0602B74D RID: 177997 RVA: 0x005FB5B8 File Offset: 0x005F97B8
		public IBvbSendSystemEventT UnPack()
		{
			IBvbSendSystemEventT bvbSendSystemEventT = new IBvbSendSystemEventT();
			this.UnPackTo(bvbSendSystemEventT);
			return bvbSendSystemEventT;
		}

		// Token: 0x0602B74E RID: 177998 RVA: 0x005FB5D4 File Offset: 0x005F97D4
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

		// Token: 0x0602B74F RID: 177999 RVA: 0x005FBBA8 File Offset: 0x005F9DA8
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

		// Token: 0x040107BC RID: 67516
		private Table __p;
	}
}
