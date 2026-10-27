using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200625D RID: 25181
	public struct IBvbSendAiEvent : IFlatbufferObject
	{
		// Token: 0x1700BBAD RID: 48045
		// (get) Token: 0x0602B6FC RID: 177916 RVA: 0x005FA754 File Offset: 0x005F8954
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B6FD RID: 177917 RVA: 0x005FA761 File Offset: 0x005F8961
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B6FE RID: 177918 RVA: 0x005FA768 File Offset: 0x005F8968
		public static IBvbSendAiEvent GetRootAsIBvbSendAiEvent(ByteBuffer _bb)
		{
			return IBvbSendAiEvent.GetRootAsIBvbSendAiEvent(_bb, default(IBvbSendAiEvent));
		}

		// Token: 0x0602B6FF RID: 177919 RVA: 0x005FA784 File Offset: 0x005F8984
		public static IBvbSendAiEvent GetRootAsIBvbSendAiEvent(ByteBuffer _bb, IBvbSendAiEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B700 RID: 177920 RVA: 0x005FA7A1 File Offset: 0x005F89A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B701 RID: 177921 RVA: 0x005FA7B0 File Offset: 0x005F89B0
		public IBvbSendAiEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BBAE RID: 48046
		// (get) Token: 0x0602B702 RID: 177922 RVA: 0x005FA7C0 File Offset: 0x005F89C0
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

		// Token: 0x0602B703 RID: 177923 RVA: 0x005FA7FC File Offset: 0x005F89FC
		public TTable? EventData<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602B704 RID: 177924 RVA: 0x005FA840 File Offset: 0x005F8A40
		public IBvbAiBattleWinData EventDataAsIBvbAiBattleWinData()
		{
			return this.EventData<IBvbAiBattleWinData>().Value;
		}

		// Token: 0x0602B705 RID: 177925 RVA: 0x005FA85C File Offset: 0x005F8A5C
		public IBvbAiChangeData EventDataAsIBvbAiChangeData()
		{
			return this.EventData<IBvbAiChangeData>().Value;
		}

		// Token: 0x0602B706 RID: 177926 RVA: 0x005FA878 File Offset: 0x005F8A78
		public IBvbAiDeployData EventDataAsIBvbAiDeployData()
		{
			return this.EventData<IBvbAiDeployData>().Value;
		}

		// Token: 0x0602B707 RID: 177927 RVA: 0x005FA894 File Offset: 0x005F8A94
		public IBvbAiDiscardData EventDataAsIBvbAiDiscardData()
		{
			return this.EventData<IBvbAiDiscardData>().Value;
		}

		// Token: 0x0602B708 RID: 177928 RVA: 0x005FA8B0 File Offset: 0x005F8AB0
		public IBvbAiDiscardForEnergyAndActData EventDataAsIBvbAiDiscardForEnergyAndActData()
		{
			return this.EventData<IBvbAiDiscardForEnergyAndActData>().Value;
		}

		// Token: 0x0602B709 RID: 177929 RVA: 0x005FA8CC File Offset: 0x005F8ACC
		public IBvbAiEvolutionData EventDataAsIBvbAiEvolutionData()
		{
			return this.EventData<IBvbAiEvolutionData>().Value;
		}

		// Token: 0x0602B70A RID: 177930 RVA: 0x005FA8E8 File Offset: 0x005F8AE8
		public IBvbAiGetBestDeployData EventDataAsIBvbAiGetBestDeployData()
		{
			return this.EventData<IBvbAiGetBestDeployData>().Value;
		}

		// Token: 0x0602B70B RID: 177931 RVA: 0x005FA904 File Offset: 0x005F8B04
		public IBvbAiGetBestRearrangeData EventDataAsIBvbAiGetBestRearrangeData()
		{
			return this.EventData<IBvbAiGetBestRearrangeData>().Value;
		}

		// Token: 0x0602B70C RID: 177932 RVA: 0x005FA920 File Offset: 0x005F8B20
		public IBvbAiGetBestReplaceData EventDataAsIBvbAiGetBestReplaceData()
		{
			return this.EventData<IBvbAiGetBestReplaceData>().Value;
		}

		// Token: 0x0602B70D RID: 177933 RVA: 0x005FA93C File Offset: 0x005F8B3C
		public IBvbAiGetBestSwapData EventDataAsIBvbAiGetBestSwapData()
		{
			return this.EventData<IBvbAiGetBestSwapData>().Value;
		}

		// Token: 0x0602B70E RID: 177934 RVA: 0x005FA958 File Offset: 0x005F8B58
		public IBvbAiRearrangeData EventDataAsIBvbAiRearrangeData()
		{
			return this.EventData<IBvbAiRearrangeData>().Value;
		}

		// Token: 0x0602B70F RID: 177935 RVA: 0x005FA974 File Offset: 0x005F8B74
		public IBvbAiRecycleData EventDataAsIBvbAiRecycleData()
		{
			return this.EventData<IBvbAiRecycleData>().Value;
		}

		// Token: 0x0602B710 RID: 177936 RVA: 0x005FA990 File Offset: 0x005F8B90
		public IBvbAiSwapData EventDataAsIBvbAiSwapData()
		{
			return this.EventData<IBvbAiSwapData>().Value;
		}

		// Token: 0x0602B711 RID: 177937 RVA: 0x005FA9AC File Offset: 0x005F8BAC
		public IBvbAiTurnEndData EventDataAsIBvbAiTurnEndData()
		{
			return this.EventData<IBvbAiTurnEndData>().Value;
		}

		// Token: 0x0602B712 RID: 177938 RVA: 0x005FA9C8 File Offset: 0x005F8BC8
		public IBvbBurnBuffTimeUpData EventDataAsIBvbBurnBuffTimeUpData()
		{
			return this.EventData<IBvbBurnBuffTimeUpData>().Value;
		}

		// Token: 0x0602B713 RID: 177939 RVA: 0x005FA9E4 File Offset: 0x005F8BE4
		public IBvbEnableHatredData EventDataAsIBvbEnableHatredData()
		{
			return this.EventData<IBvbEnableHatredData>().Value;
		}

		// Token: 0x0602B714 RID: 177940 RVA: 0x005FAA00 File Offset: 0x005F8C00
		public IBvbPlayerBattleWinData EventDataAsIBvbPlayerBattleWinData()
		{
			return this.EventData<IBvbPlayerBattleWinData>().Value;
		}

		// Token: 0x0602B715 RID: 177941 RVA: 0x005FAA1C File Offset: 0x005F8C1C
		public IBvbPlayerTurnEndData EventDataAsIBvbPlayerTurnEndData()
		{
			return this.EventData<IBvbPlayerTurnEndData>().Value;
		}

		// Token: 0x0602B716 RID: 177942 RVA: 0x005FAA38 File Offset: 0x005F8C38
		public IBvbPlayerTurnStartData EventDataAsIBvbPlayerTurnStartData()
		{
			return this.EventData<IBvbPlayerTurnStartData>().Value;
		}

		// Token: 0x0602B717 RID: 177943 RVA: 0x005FAA54 File Offset: 0x005F8C54
		public IBvbSelectCardsEndData EventDataAsIBvbSelectCardsEndData()
		{
			return this.EventData<IBvbSelectCardsEndData>().Value;
		}

		// Token: 0x0602B718 RID: 177944 RVA: 0x005FAA70 File Offset: 0x005F8C70
		public IBvbStartAiData EventDataAsIBvbStartAiData()
		{
			return this.EventData<IBvbStartAiData>().Value;
		}

		// Token: 0x0602B719 RID: 177945 RVA: 0x005FAA8C File Offset: 0x005F8C8C
		public IBvbStartBattleData EventDataAsIBvbStartBattleData()
		{
			return this.EventData<IBvbStartBattleData>().Value;
		}

		// Token: 0x0602B71A RID: 177946 RVA: 0x005FAAA8 File Offset: 0x005F8CA8
		public IBvbStartRoundData EventDataAsIBvbStartRoundData()
		{
			return this.EventData<IBvbStartRoundData>().Value;
		}

		// Token: 0x0602B71B RID: 177947 RVA: 0x005FAAC4 File Offset: 0x005F8CC4
		public IBvbWaitForGameBeginData EventDataAsIBvbWaitForGameBeginData()
		{
			return this.EventData<IBvbWaitForGameBeginData>().Value;
		}

		// Token: 0x0602B71C RID: 177948 RVA: 0x005FAADF File Offset: 0x005F8CDF
		public static Offset<IBvbSendAiEvent> CreateIBvbSendAiEvent(FlatBufferBuilder builder, TBvbEventData EventData_type = TBvbEventData.NONE, int EventDataOffset = 0)
		{
			builder.StartTable(2);
			IBvbSendAiEvent.AddEventData(builder, EventDataOffset);
			IBvbSendAiEvent.AddEventDataType(builder, EventData_type);
			return IBvbSendAiEvent.EndIBvbSendAiEvent(builder);
		}

		// Token: 0x0602B71D RID: 177949 RVA: 0x005FAAFC File Offset: 0x005F8CFC
		public static void StartIBvbSendAiEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B71E RID: 177950 RVA: 0x005FAB05 File Offset: 0x005F8D05
		public static void AddEventDataType(FlatBufferBuilder builder, TBvbEventData eventDataType)
		{
			builder.AddByte(0, (byte)eventDataType, 0);
		}

		// Token: 0x0602B71F RID: 177951 RVA: 0x005FAB10 File Offset: 0x005F8D10
		public static void AddEventData(FlatBufferBuilder builder, int eventDataOffset)
		{
			builder.AddOffset(1, eventDataOffset, 0);
		}

		// Token: 0x0602B720 RID: 177952 RVA: 0x005FAB1B File Offset: 0x005F8D1B
		public static Offset<IBvbSendAiEvent> EndIBvbSendAiEvent(FlatBufferBuilder builder)
		{
			return new Offset<IBvbSendAiEvent>(builder.EndTable());
		}

		// Token: 0x0602B721 RID: 177953 RVA: 0x005FAB28 File Offset: 0x005F8D28
		public IBvbSendAiEventT UnPack()
		{
			IBvbSendAiEventT bvbSendAiEventT = new IBvbSendAiEventT();
			this.UnPackTo(bvbSendAiEventT);
			return bvbSendAiEventT;
		}

		// Token: 0x0602B722 RID: 177954 RVA: 0x005FAB44 File Offset: 0x005F8D44
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

		// Token: 0x0602B723 RID: 177955 RVA: 0x005FB118 File Offset: 0x005F9318
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

		// Token: 0x040107BA RID: 67514
		private Table __p;
	}
}
