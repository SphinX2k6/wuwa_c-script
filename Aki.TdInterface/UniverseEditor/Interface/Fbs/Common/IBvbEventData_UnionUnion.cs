using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D50 RID: 23888
	public class IBvbEventData_UnionUnion
	{
		// Token: 0x1700B306 RID: 45830
		// (get) Token: 0x06028DC2 RID: 167362 RVA: 0x0059D7CD File Offset: 0x0059B9CD
		// (set) Token: 0x06028DC3 RID: 167363 RVA: 0x0059D7D5 File Offset: 0x0059B9D5
		public IBvbEventData_Union Type { get; set; }

		// Token: 0x1700B307 RID: 45831
		// (get) Token: 0x06028DC4 RID: 167364 RVA: 0x0059D7DE File Offset: 0x0059B9DE
		// (set) Token: 0x06028DC5 RID: 167365 RVA: 0x0059D7E6 File Offset: 0x0059B9E6
		public object Value { get; set; }

		// Token: 0x06028DC6 RID: 167366 RVA: 0x0059D7EF File Offset: 0x0059B9EF
		public IBvbEventData_UnionUnion()
		{
			this.Type = IBvbEventData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028DC7 RID: 167367 RVA: 0x0059D805 File Offset: 0x0059BA05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028DC8 RID: 167368 RVA: 0x0059D817 File Offset: 0x0059BA17
		public IBvbEventDataT AsIBvbEventData()
		{
			return this.As<IBvbEventDataT>();
		}

		// Token: 0x06028DC9 RID: 167369 RVA: 0x0059D81F File Offset: 0x0059BA1F
		public static IBvbEventData_UnionUnion FromIBvbEventData(IBvbEventDataT _ibvbeventdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbEventData,
				Value = _ibvbeventdata
			};
		}

		// Token: 0x06028DCA RID: 167370 RVA: 0x0059D834 File Offset: 0x0059BA34
		public IBvbAiEvolutionDataT AsIBvbAiEvolutionData()
		{
			return this.As<IBvbAiEvolutionDataT>();
		}

		// Token: 0x06028DCB RID: 167371 RVA: 0x0059D83C File Offset: 0x0059BA3C
		public static IBvbEventData_UnionUnion FromIBvbAiEvolutionData(IBvbAiEvolutionDataT _ibvbaievolutiondata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiEvolutionData,
				Value = _ibvbaievolutiondata
			};
		}

		// Token: 0x06028DCC RID: 167372 RVA: 0x0059D851 File Offset: 0x0059BA51
		public IBvbAiDeployDataT AsIBvbAiDeployData()
		{
			return this.As<IBvbAiDeployDataT>();
		}

		// Token: 0x06028DCD RID: 167373 RVA: 0x0059D859 File Offset: 0x0059BA59
		public static IBvbEventData_UnionUnion FromIBvbAiDeployData(IBvbAiDeployDataT _ibvbaideploydata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDeployData,
				Value = _ibvbaideploydata
			};
		}

		// Token: 0x06028DCE RID: 167374 RVA: 0x0059D86E File Offset: 0x0059BA6E
		public IBvbAiChangeDataT AsIBvbAiChangeData()
		{
			return this.As<IBvbAiChangeDataT>();
		}

		// Token: 0x06028DCF RID: 167375 RVA: 0x0059D876 File Offset: 0x0059BA76
		public static IBvbEventData_UnionUnion FromIBvbAiChangeData(IBvbAiChangeDataT _ibvbaichangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiChangeData,
				Value = _ibvbaichangedata
			};
		}

		// Token: 0x06028DD0 RID: 167376 RVA: 0x0059D88B File Offset: 0x0059BA8B
		public IBvbAiRecycleDataT AsIBvbAiRecycleData()
		{
			return this.As<IBvbAiRecycleDataT>();
		}

		// Token: 0x06028DD1 RID: 167377 RVA: 0x0059D893 File Offset: 0x0059BA93
		public static IBvbEventData_UnionUnion FromIBvbAiRecycleData(IBvbAiRecycleDataT _ibvbairecycledata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiRecycleData,
				Value = _ibvbairecycledata
			};
		}

		// Token: 0x06028DD2 RID: 167378 RVA: 0x0059D8A8 File Offset: 0x0059BAA8
		public IBvbAiRearrangeDataT AsIBvbAiRearrangeData()
		{
			return this.As<IBvbAiRearrangeDataT>();
		}

		// Token: 0x06028DD3 RID: 167379 RVA: 0x0059D8B0 File Offset: 0x0059BAB0
		public static IBvbEventData_UnionUnion FromIBvbAiRearrangeData(IBvbAiRearrangeDataT _ibvbairearrangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiRearrangeData,
				Value = _ibvbairearrangedata
			};
		}

		// Token: 0x06028DD4 RID: 167380 RVA: 0x0059D8C5 File Offset: 0x0059BAC5
		public IBvbAiSwapDataT AsIBvbAiSwapData()
		{
			return this.As<IBvbAiSwapDataT>();
		}

		// Token: 0x06028DD5 RID: 167381 RVA: 0x0059D8CD File Offset: 0x0059BACD
		public static IBvbEventData_UnionUnion FromIBvbAiSwapData(IBvbAiSwapDataT _ibvbaiswapdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiSwapData,
				Value = _ibvbaiswapdata
			};
		}

		// Token: 0x06028DD6 RID: 167382 RVA: 0x0059D8E2 File Offset: 0x0059BAE2
		public IBvbAiDiscardDataT AsIBvbAiDiscardData()
		{
			return this.As<IBvbAiDiscardDataT>();
		}

		// Token: 0x06028DD7 RID: 167383 RVA: 0x0059D8EA File Offset: 0x0059BAEA
		public static IBvbEventData_UnionUnion FromIBvbAiDiscardData(IBvbAiDiscardDataT _ibvbaidiscarddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDiscardData,
				Value = _ibvbaidiscarddata
			};
		}

		// Token: 0x06028DD8 RID: 167384 RVA: 0x0059D8FF File Offset: 0x0059BAFF
		public IBvbAiGetBestDeployDataT AsIBvbAiGetBestDeployData()
		{
			return this.As<IBvbAiGetBestDeployDataT>();
		}

		// Token: 0x06028DD9 RID: 167385 RVA: 0x0059D907 File Offset: 0x0059BB07
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestDeployData(IBvbAiGetBestDeployDataT _ibvbaigetbestdeploydata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestDeployData,
				Value = _ibvbaigetbestdeploydata
			};
		}

		// Token: 0x06028DDA RID: 167386 RVA: 0x0059D91D File Offset: 0x0059BB1D
		public IBvbAiGetBestRearrangeDataT AsIBvbAiGetBestRearrangeData()
		{
			return this.As<IBvbAiGetBestRearrangeDataT>();
		}

		// Token: 0x06028DDB RID: 167387 RVA: 0x0059D925 File Offset: 0x0059BB25
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestRearrangeData(IBvbAiGetBestRearrangeDataT _ibvbaigetbestrearrangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestRearrangeData,
				Value = _ibvbaigetbestrearrangedata
			};
		}

		// Token: 0x06028DDC RID: 167388 RVA: 0x0059D93B File Offset: 0x0059BB3B
		public IBvbAiGetBestSwapDataT AsIBvbAiGetBestSwapData()
		{
			return this.As<IBvbAiGetBestSwapDataT>();
		}

		// Token: 0x06028DDD RID: 167389 RVA: 0x0059D943 File Offset: 0x0059BB43
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestSwapData(IBvbAiGetBestSwapDataT _ibvbaigetbestswapdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestSwapData,
				Value = _ibvbaigetbestswapdata
			};
		}

		// Token: 0x06028DDE RID: 167390 RVA: 0x0059D959 File Offset: 0x0059BB59
		public IBvbAiGetBestReplaceDataT AsIBvbAiGetBestReplaceData()
		{
			return this.As<IBvbAiGetBestReplaceDataT>();
		}

		// Token: 0x06028DDF RID: 167391 RVA: 0x0059D961 File Offset: 0x0059BB61
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestReplaceData(IBvbAiGetBestReplaceDataT _ibvbaigetbestreplacedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestReplaceData,
				Value = _ibvbaigetbestreplacedata
			};
		}

		// Token: 0x06028DE0 RID: 167392 RVA: 0x0059D977 File Offset: 0x0059BB77
		public IBvbAiDiscardForEnergyAndActDataT AsIBvbAiDiscardForEnergyAndActData()
		{
			return this.As<IBvbAiDiscardForEnergyAndActDataT>();
		}

		// Token: 0x06028DE1 RID: 167393 RVA: 0x0059D97F File Offset: 0x0059BB7F
		public static IBvbEventData_UnionUnion FromIBvbAiDiscardForEnergyAndActData(IBvbAiDiscardForEnergyAndActDataT _ibvbaidiscardforenergyandactdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDiscardForEnergyAndActData,
				Value = _ibvbaidiscardforenergyandactdata
			};
		}

		// Token: 0x06028DE2 RID: 167394 RVA: 0x0059D995 File Offset: 0x0059BB95
		public IBvbAiTurnEndDataT AsIBvbAiTurnEndData()
		{
			return this.As<IBvbAiTurnEndDataT>();
		}

		// Token: 0x06028DE3 RID: 167395 RVA: 0x0059D99D File Offset: 0x0059BB9D
		public static IBvbEventData_UnionUnion FromIBvbAiTurnEndData(IBvbAiTurnEndDataT _ibvbaiturnenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiTurnEndData,
				Value = _ibvbaiturnenddata
			};
		}

		// Token: 0x06028DE4 RID: 167396 RVA: 0x0059D9B3 File Offset: 0x0059BBB3
		public IBvbStartAiDataT AsIBvbStartAiData()
		{
			return this.As<IBvbStartAiDataT>();
		}

		// Token: 0x06028DE5 RID: 167397 RVA: 0x0059D9BB File Offset: 0x0059BBBB
		public static IBvbEventData_UnionUnion FromIBvbStartAiData(IBvbStartAiDataT _ibvbstartaidata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartAiData,
				Value = _ibvbstartaidata
			};
		}

		// Token: 0x06028DE6 RID: 167398 RVA: 0x0059D9D1 File Offset: 0x0059BBD1
		public IBvbStartBattleDataT AsIBvbStartBattleData()
		{
			return this.As<IBvbStartBattleDataT>();
		}

		// Token: 0x06028DE7 RID: 167399 RVA: 0x0059D9D9 File Offset: 0x0059BBD9
		public static IBvbEventData_UnionUnion FromIBvbStartBattleData(IBvbStartBattleDataT _ibvbstartbattledata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartBattleData,
				Value = _ibvbstartbattledata
			};
		}

		// Token: 0x06028DE8 RID: 167400 RVA: 0x0059D9EF File Offset: 0x0059BBEF
		public IBvbEnableHatredDataT AsIBvbEnableHatredData()
		{
			return this.As<IBvbEnableHatredDataT>();
		}

		// Token: 0x06028DE9 RID: 167401 RVA: 0x0059D9F7 File Offset: 0x0059BBF7
		public static IBvbEventData_UnionUnion FromIBvbEnableHatredData(IBvbEnableHatredDataT _ibvbenablehatreddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbEnableHatredData,
				Value = _ibvbenablehatreddata
			};
		}

		// Token: 0x06028DEA RID: 167402 RVA: 0x0059DA0D File Offset: 0x0059BC0D
		public IBvbStartRoundDataT AsIBvbStartRoundData()
		{
			return this.As<IBvbStartRoundDataT>();
		}

		// Token: 0x06028DEB RID: 167403 RVA: 0x0059DA15 File Offset: 0x0059BC15
		public static IBvbEventData_UnionUnion FromIBvbStartRoundData(IBvbStartRoundDataT _ibvbstartrounddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartRoundData,
				Value = _ibvbstartrounddata
			};
		}

		// Token: 0x06028DEC RID: 167404 RVA: 0x0059DA2B File Offset: 0x0059BC2B
		public IBvbBurnBuffTimeUpDataT AsIBvbBurnBuffTimeUpData()
		{
			return this.As<IBvbBurnBuffTimeUpDataT>();
		}

		// Token: 0x06028DED RID: 167405 RVA: 0x0059DA33 File Offset: 0x0059BC33
		public static IBvbEventData_UnionUnion FromIBvbBurnBuffTimeUpData(IBvbBurnBuffTimeUpDataT _ibvbburnbufftimeupdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbBurnBuffTimeUpData,
				Value = _ibvbburnbufftimeupdata
			};
		}

		// Token: 0x06028DEE RID: 167406 RVA: 0x0059DA49 File Offset: 0x0059BC49
		public IBvbWaitForGameBeginDataT AsIBvbWaitForGameBeginData()
		{
			return this.As<IBvbWaitForGameBeginDataT>();
		}

		// Token: 0x06028DEF RID: 167407 RVA: 0x0059DA51 File Offset: 0x0059BC51
		public static IBvbEventData_UnionUnion FromIBvbWaitForGameBeginData(IBvbWaitForGameBeginDataT _ibvbwaitforgamebegindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbWaitForGameBeginData,
				Value = _ibvbwaitforgamebegindata
			};
		}

		// Token: 0x06028DF0 RID: 167408 RVA: 0x0059DA67 File Offset: 0x0059BC67
		public IBvbPlayerTurnStartDataT AsIBvbPlayerTurnStartData()
		{
			return this.As<IBvbPlayerTurnStartDataT>();
		}

		// Token: 0x06028DF1 RID: 167409 RVA: 0x0059DA6F File Offset: 0x0059BC6F
		public static IBvbEventData_UnionUnion FromIBvbPlayerTurnStartData(IBvbPlayerTurnStartDataT _ibvbplayerturnstartdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerTurnStartData,
				Value = _ibvbplayerturnstartdata
			};
		}

		// Token: 0x06028DF2 RID: 167410 RVA: 0x0059DA85 File Offset: 0x0059BC85
		public IBvbPlayerTurnEndDataT AsIBvbPlayerTurnEndData()
		{
			return this.As<IBvbPlayerTurnEndDataT>();
		}

		// Token: 0x06028DF3 RID: 167411 RVA: 0x0059DA8D File Offset: 0x0059BC8D
		public static IBvbEventData_UnionUnion FromIBvbPlayerTurnEndData(IBvbPlayerTurnEndDataT _ibvbplayerturnenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerTurnEndData,
				Value = _ibvbplayerturnenddata
			};
		}

		// Token: 0x06028DF4 RID: 167412 RVA: 0x0059DAA3 File Offset: 0x0059BCA3
		public IBvbAiBattleWinDataT AsIBvbAiBattleWinData()
		{
			return this.As<IBvbAiBattleWinDataT>();
		}

		// Token: 0x06028DF5 RID: 167413 RVA: 0x0059DAAB File Offset: 0x0059BCAB
		public static IBvbEventData_UnionUnion FromIBvbAiBattleWinData(IBvbAiBattleWinDataT _ibvbaibattlewindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiBattleWinData,
				Value = _ibvbaibattlewindata
			};
		}

		// Token: 0x06028DF6 RID: 167414 RVA: 0x0059DAC1 File Offset: 0x0059BCC1
		public IBvbPlayerBattleWinDataT AsIBvbPlayerBattleWinData()
		{
			return this.As<IBvbPlayerBattleWinDataT>();
		}

		// Token: 0x06028DF7 RID: 167415 RVA: 0x0059DAC9 File Offset: 0x0059BCC9
		public static IBvbEventData_UnionUnion FromIBvbPlayerBattleWinData(IBvbPlayerBattleWinDataT _ibvbplayerbattlewindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerBattleWinData,
				Value = _ibvbplayerbattlewindata
			};
		}

		// Token: 0x06028DF8 RID: 167416 RVA: 0x0059DADF File Offset: 0x0059BCDF
		public IBvbSelectCardsEndDataT AsIBvbSelectCardsEndData()
		{
			return this.As<IBvbSelectCardsEndDataT>();
		}

		// Token: 0x06028DF9 RID: 167417 RVA: 0x0059DAE7 File Offset: 0x0059BCE7
		public static IBvbEventData_UnionUnion FromIBvbSelectCardsEndData(IBvbSelectCardsEndDataT _ibvbselectcardsenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbSelectCardsEndData,
				Value = _ibvbselectcardsenddata
			};
		}

		// Token: 0x06028DFA RID: 167418 RVA: 0x0059DB00 File Offset: 0x0059BD00
		public static int Pack(FlatBufferBuilder builder, IBvbEventData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBvbEventData_Union.IBvbEventData:
				return IBvbEventData.Pack(builder, _o.AsIBvbEventData()).Value;
			case IBvbEventData_Union.IBvbAiEvolutionData:
				return IBvbAiEvolutionData.Pack(builder, _o.AsIBvbAiEvolutionData()).Value;
			case IBvbEventData_Union.IBvbAiDeployData:
				return IBvbAiDeployData.Pack(builder, _o.AsIBvbAiDeployData()).Value;
			case IBvbEventData_Union.IBvbAiChangeData:
				return IBvbAiChangeData.Pack(builder, _o.AsIBvbAiChangeData()).Value;
			case IBvbEventData_Union.IBvbAiRecycleData:
				return IBvbAiRecycleData.Pack(builder, _o.AsIBvbAiRecycleData()).Value;
			case IBvbEventData_Union.IBvbAiRearrangeData:
				return IBvbAiRearrangeData.Pack(builder, _o.AsIBvbAiRearrangeData()).Value;
			case IBvbEventData_Union.IBvbAiSwapData:
				return IBvbAiSwapData.Pack(builder, _o.AsIBvbAiSwapData()).Value;
			case IBvbEventData_Union.IBvbAiDiscardData:
				return IBvbAiDiscardData.Pack(builder, _o.AsIBvbAiDiscardData()).Value;
			case IBvbEventData_Union.IBvbAiGetBestDeployData:
				return IBvbAiGetBestDeployData.Pack(builder, _o.AsIBvbAiGetBestDeployData()).Value;
			case IBvbEventData_Union.IBvbAiGetBestRearrangeData:
				return IBvbAiGetBestRearrangeData.Pack(builder, _o.AsIBvbAiGetBestRearrangeData()).Value;
			case IBvbEventData_Union.IBvbAiGetBestSwapData:
				return IBvbAiGetBestSwapData.Pack(builder, _o.AsIBvbAiGetBestSwapData()).Value;
			case IBvbEventData_Union.IBvbAiGetBestReplaceData:
				return IBvbAiGetBestReplaceData.Pack(builder, _o.AsIBvbAiGetBestReplaceData()).Value;
			case IBvbEventData_Union.IBvbAiDiscardForEnergyAndActData:
				return IBvbAiDiscardForEnergyAndActData.Pack(builder, _o.AsIBvbAiDiscardForEnergyAndActData()).Value;
			case IBvbEventData_Union.IBvbAiTurnEndData:
				return IBvbAiTurnEndData.Pack(builder, _o.AsIBvbAiTurnEndData()).Value;
			case IBvbEventData_Union.IBvbStartAiData:
				return IBvbStartAiData.Pack(builder, _o.AsIBvbStartAiData()).Value;
			case IBvbEventData_Union.IBvbStartBattleData:
				return IBvbStartBattleData.Pack(builder, _o.AsIBvbStartBattleData()).Value;
			case IBvbEventData_Union.IBvbEnableHatredData:
				return IBvbEnableHatredData.Pack(builder, _o.AsIBvbEnableHatredData()).Value;
			case IBvbEventData_Union.IBvbStartRoundData:
				return IBvbStartRoundData.Pack(builder, _o.AsIBvbStartRoundData()).Value;
			case IBvbEventData_Union.IBvbBurnBuffTimeUpData:
				return IBvbBurnBuffTimeUpData.Pack(builder, _o.AsIBvbBurnBuffTimeUpData()).Value;
			case IBvbEventData_Union.IBvbWaitForGameBeginData:
				return IBvbWaitForGameBeginData.Pack(builder, _o.AsIBvbWaitForGameBeginData()).Value;
			case IBvbEventData_Union.IBvbPlayerTurnStartData:
				return IBvbPlayerTurnStartData.Pack(builder, _o.AsIBvbPlayerTurnStartData()).Value;
			case IBvbEventData_Union.IBvbPlayerTurnEndData:
				return IBvbPlayerTurnEndData.Pack(builder, _o.AsIBvbPlayerTurnEndData()).Value;
			case IBvbEventData_Union.IBvbAiBattleWinData:
				return IBvbAiBattleWinData.Pack(builder, _o.AsIBvbAiBattleWinData()).Value;
			case IBvbEventData_Union.IBvbPlayerBattleWinData:
				return IBvbPlayerBattleWinData.Pack(builder, _o.AsIBvbPlayerBattleWinData()).Value;
			case IBvbEventData_Union.IBvbSelectCardsEndData:
				return IBvbSelectCardsEndData.Pack(builder, _o.AsIBvbSelectCardsEndData()).Value;
			default:
				return 0;
			}
		}
	}
}
