using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CE RID: 26830
	public struct IBvbSendAiEvent : IFlatbufferObject
	{
		// Token: 0x1700C535 RID: 50485
		// (get) Token: 0x0602DE5D RID: 187997 RVA: 0x0064555C File Offset: 0x0064375C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DE5E RID: 187998 RVA: 0x00645569 File Offset: 0x00643769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DE5F RID: 187999 RVA: 0x00645570 File Offset: 0x00643770
		public static IBvbSendAiEvent GetRootAsIBvbSendAiEvent(ByteBuffer _bb)
		{
			return IBvbSendAiEvent.GetRootAsIBvbSendAiEvent(_bb, default(IBvbSendAiEvent));
		}

		// Token: 0x0602DE60 RID: 188000 RVA: 0x0064558C File Offset: 0x0064378C
		public static IBvbSendAiEvent GetRootAsIBvbSendAiEvent(ByteBuffer _bb, IBvbSendAiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DE61 RID: 188001 RVA: 0x006455A9 File Offset: 0x006437A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DE62 RID: 188002 RVA: 0x006455B8 File Offset: 0x006437B8
		public IBvbSendAiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C536 RID: 50486
		// (get) Token: 0x0602DE63 RID: 188003 RVA: 0x006455C8 File Offset: 0x006437C8
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

		// Token: 0x0602DE64 RID: 188004 RVA: 0x00645604 File Offset: 0x00643804
		public TTable? EventData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602DE65 RID: 188005 RVA: 0x00645648 File Offset: 0x00643848
		public IBvbAiBattleWinData EventDataAsIBvbAiBattleWinData()
		{
			return this.EventData<IBvbAiBattleWinData>().Value;
		}

		// Token: 0x0602DE66 RID: 188006 RVA: 0x00645664 File Offset: 0x00643864
		public IBvbAiChangeData EventDataAsIBvbAiChangeData()
		{
			return this.EventData<IBvbAiChangeData>().Value;
		}

		// Token: 0x0602DE67 RID: 188007 RVA: 0x00645680 File Offset: 0x00643880
		public IBvbAiDeployData EventDataAsIBvbAiDeployData()
		{
			return this.EventData<IBvbAiDeployData>().Value;
		}

		// Token: 0x0602DE68 RID: 188008 RVA: 0x0064569C File Offset: 0x0064389C
		public IBvbAiDiscardData EventDataAsIBvbAiDiscardData()
		{
			return this.EventData<IBvbAiDiscardData>().Value;
		}

		// Token: 0x0602DE69 RID: 188009 RVA: 0x006456B8 File Offset: 0x006438B8
		public IBvbAiDiscardForEnergyAndActData EventDataAsIBvbAiDiscardForEnergyAndActData()
		{
			return this.EventData<IBvbAiDiscardForEnergyAndActData>().Value;
		}

		// Token: 0x0602DE6A RID: 188010 RVA: 0x006456D4 File Offset: 0x006438D4
		public IBvbAiEvolutionData EventDataAsIBvbAiEvolutionData()
		{
			return this.EventData<IBvbAiEvolutionData>().Value;
		}

		// Token: 0x0602DE6B RID: 188011 RVA: 0x006456F0 File Offset: 0x006438F0
		public IBvbAiGetBestDeployData EventDataAsIBvbAiGetBestDeployData()
		{
			return this.EventData<IBvbAiGetBestDeployData>().Value;
		}

		// Token: 0x0602DE6C RID: 188012 RVA: 0x0064570C File Offset: 0x0064390C
		public IBvbAiGetBestRearrangeData EventDataAsIBvbAiGetBestRearrangeData()
		{
			return this.EventData<IBvbAiGetBestRearrangeData>().Value;
		}

		// Token: 0x0602DE6D RID: 188013 RVA: 0x00645728 File Offset: 0x00643928
		public IBvbAiGetBestReplaceData EventDataAsIBvbAiGetBestReplaceData()
		{
			return this.EventData<IBvbAiGetBestReplaceData>().Value;
		}

		// Token: 0x0602DE6E RID: 188014 RVA: 0x00645744 File Offset: 0x00643944
		public IBvbAiGetBestSwapData EventDataAsIBvbAiGetBestSwapData()
		{
			return this.EventData<IBvbAiGetBestSwapData>().Value;
		}

		// Token: 0x0602DE6F RID: 188015 RVA: 0x00645760 File Offset: 0x00643960
		public IBvbAiRearrangeData EventDataAsIBvbAiRearrangeData()
		{
			return this.EventData<IBvbAiRearrangeData>().Value;
		}

		// Token: 0x0602DE70 RID: 188016 RVA: 0x0064577C File Offset: 0x0064397C
		public IBvbAiRecycleData EventDataAsIBvbAiRecycleData()
		{
			return this.EventData<IBvbAiRecycleData>().Value;
		}

		// Token: 0x0602DE71 RID: 188017 RVA: 0x00645798 File Offset: 0x00643998
		public IBvbAiSwapData EventDataAsIBvbAiSwapData()
		{
			return this.EventData<IBvbAiSwapData>().Value;
		}

		// Token: 0x0602DE72 RID: 188018 RVA: 0x006457B4 File Offset: 0x006439B4
		public IBvbAiTurnEndData EventDataAsIBvbAiTurnEndData()
		{
			return this.EventData<IBvbAiTurnEndData>().Value;
		}

		// Token: 0x0602DE73 RID: 188019 RVA: 0x006457D0 File Offset: 0x006439D0
		public IBvbBurnBuffTimeUpData EventDataAsIBvbBurnBuffTimeUpData()
		{
			return this.EventData<IBvbBurnBuffTimeUpData>().Value;
		}

		// Token: 0x0602DE74 RID: 188020 RVA: 0x006457EC File Offset: 0x006439EC
		public IBvbEnableHatredData EventDataAsIBvbEnableHatredData()
		{
			return this.EventData<IBvbEnableHatredData>().Value;
		}

		// Token: 0x0602DE75 RID: 188021 RVA: 0x00645808 File Offset: 0x00643A08
		public IBvbPlayerBattleWinData EventDataAsIBvbPlayerBattleWinData()
		{
			return this.EventData<IBvbPlayerBattleWinData>().Value;
		}

		// Token: 0x0602DE76 RID: 188022 RVA: 0x00645824 File Offset: 0x00643A24
		public IBvbPlayerTurnEndData EventDataAsIBvbPlayerTurnEndData()
		{
			return this.EventData<IBvbPlayerTurnEndData>().Value;
		}

		// Token: 0x0602DE77 RID: 188023 RVA: 0x00645840 File Offset: 0x00643A40
		public IBvbPlayerTurnStartData EventDataAsIBvbPlayerTurnStartData()
		{
			return this.EventData<IBvbPlayerTurnStartData>().Value;
		}

		// Token: 0x0602DE78 RID: 188024 RVA: 0x0064585C File Offset: 0x00643A5C
		public IBvbSelectCardsEndData EventDataAsIBvbSelectCardsEndData()
		{
			return this.EventData<IBvbSelectCardsEndData>().Value;
		}

		// Token: 0x0602DE79 RID: 188025 RVA: 0x00645878 File Offset: 0x00643A78
		public IBvbStartAiData EventDataAsIBvbStartAiData()
		{
			return this.EventData<IBvbStartAiData>().Value;
		}

		// Token: 0x0602DE7A RID: 188026 RVA: 0x00645894 File Offset: 0x00643A94
		public IBvbStartBattleData EventDataAsIBvbStartBattleData()
		{
			return this.EventData<IBvbStartBattleData>().Value;
		}

		// Token: 0x0602DE7B RID: 188027 RVA: 0x006458B0 File Offset: 0x00643AB0
		public IBvbStartRoundData EventDataAsIBvbStartRoundData()
		{
			return this.EventData<IBvbStartRoundData>().Value;
		}

		// Token: 0x0602DE7C RID: 188028 RVA: 0x006458CC File Offset: 0x00643ACC
		public IBvbWaitForGameBeginData EventDataAsIBvbWaitForGameBeginData()
		{
			return this.EventData<IBvbWaitForGameBeginData>().Value;
		}

		// Token: 0x0602DE7D RID: 188029 RVA: 0x006458E7 File Offset: 0x00643AE7
		public static Offset<IBvbSendAiEvent> CreateIBvbSendAiEvent(FlatBufferBuilder builder, TBvbEventData EventData_type = TBvbEventData.NONE, int EventDataOffset = 0)
		{
			builder.StartTable(2);
			IBvbSendAiEvent.AddEventData(builder, EventDataOffset);
			IBvbSendAiEvent.AddEventDataType(builder, EventData_type);
			return IBvbSendAiEvent.EndIBvbSendAiEvent(builder);
		}

		// Token: 0x0602DE7E RID: 188030 RVA: 0x00645904 File Offset: 0x00643B04
		public static void StartIBvbSendAiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602DE7F RID: 188031 RVA: 0x0064590D File Offset: 0x00643B0D
		public static void AddEventDataType(FlatBufferBuilder builder, TBvbEventData eventDataType)
		{
			builder.AddByte(0, (byte)eventDataType, 0);
		}

		// Token: 0x0602DE80 RID: 188032 RVA: 0x00645918 File Offset: 0x00643B18
		public static void AddEventData(FlatBufferBuilder builder, int eventDataOffset)
		{
			builder.AddOffset(1, eventDataOffset, 0);
		}

		// Token: 0x0602DE81 RID: 188033 RVA: 0x00645923 File Offset: 0x00643B23
		public static Offset<IBvbSendAiEvent> EndIBvbSendAiEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSendAiEvent>(builder.EndTable());
		}

		// Token: 0x0602DE82 RID: 188034 RVA: 0x00645930 File Offset: 0x00643B30
		public IBvbSendAiEventT UnPack()
		{
			IBvbSendAiEventT bvbSendAiEventT = new IBvbSendAiEventT();
			this.UnPackTo(bvbSendAiEventT);
			return bvbSendAiEventT;
		}

		// Token: 0x0602DE83 RID: 188035 RVA: 0x0064594C File Offset: 0x00643B4C
		public void UnPackTo(IBvbSendAiEventT _o)
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

		// Token: 0x0602DE84 RID: 188036 RVA: 0x00645F20 File Offset: 0x00644120
		public static Offset<IBvbSendAiEvent> Pack(FlatBufferBuilder builder, IBvbSendAiEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbSendAiEvent>);
			}
			TBvbEventData eventData_type = (_o.EventData == null) ? TBvbEventData.NONE : _o.EventData.Type;
			int eventDataOffset = (_o.EventData == null) ? 0 : TBvbEventDataUnion.Pack(builder, _o.EventData);
			return IBvbSendAiEvent.CreateIBvbSendAiEvent(builder, eventData_type, eventDataOffset);
		}

		// Token: 0x040115CF RID: 71119
		private Table __p;
	}
}
