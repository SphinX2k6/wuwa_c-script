using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020064AD RID: 25773
	public class TBvbEventDataUnion
	{
		// Token: 0x1700BE23 RID: 48675
		// (get) Token: 0x0602BCF3 RID: 179443 RVA: 0x005F55D6 File Offset: 0x005F37D6
		// (set) Token: 0x0602BCF4 RID: 179444 RVA: 0x005F55DE File Offset: 0x005F37DE
		public TBvbEventData Type { get; set; }

		// Token: 0x1700BE24 RID: 48676
		// (get) Token: 0x0602BCF5 RID: 179445 RVA: 0x005F55E7 File Offset: 0x005F37E7
		// (set) Token: 0x0602BCF6 RID: 179446 RVA: 0x005F55EF File Offset: 0x005F37EF
		public object Value { get; set; }

		// Token: 0x0602BCF7 RID: 179447 RVA: 0x005F55F8 File Offset: 0x005F37F8
		public TBvbEventDataUnion()
		{
			this.Type = TBvbEventData.NONE;
			this.Value = null;
		}

		// Token: 0x0602BCF8 RID: 179448 RVA: 0x005F560E File Offset: 0x005F380E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602BCF9 RID: 179449 RVA: 0x005F5620 File Offset: 0x005F3820
		public IBvbAiBattleWinDataT AsIBvbAiBattleWinData()
		{
			return this.As<IBvbAiBattleWinDataT>();
		}

		// Token: 0x0602BCFA RID: 179450 RVA: 0x005F5628 File Offset: 0x005F3828
		public static TBvbEventDataUnion FromIBvbAiBattleWinData(IBvbAiBattleWinDataT _ibvbaibattlewindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiBattleWinData,
				Value = _ibvbaibattlewindata
			};
		}

		// Token: 0x0602BCFB RID: 179451 RVA: 0x005F563D File Offset: 0x005F383D
		public IBvbAiChangeDataT AsIBvbAiChangeData()
		{
			return this.As<IBvbAiChangeDataT>();
		}

		// Token: 0x0602BCFC RID: 179452 RVA: 0x005F5645 File Offset: 0x005F3845
		public static TBvbEventDataUnion FromIBvbAiChangeData(IBvbAiChangeDataT _ibvbaichangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiChangeData,
				Value = _ibvbaichangedata
			};
		}

		// Token: 0x0602BCFD RID: 179453 RVA: 0x005F565A File Offset: 0x005F385A
		public IBvbAiDeployDataT AsIBvbAiDeployData()
		{
			return this.As<IBvbAiDeployDataT>();
		}

		// Token: 0x0602BCFE RID: 179454 RVA: 0x005F5662 File Offset: 0x005F3862
		public static TBvbEventDataUnion FromIBvbAiDeployData(IBvbAiDeployDataT _ibvbaideploydata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDeployData,
				Value = _ibvbaideploydata
			};
		}

		// Token: 0x0602BCFF RID: 179455 RVA: 0x005F5677 File Offset: 0x005F3877
		public IBvbAiDiscardDataT AsIBvbAiDiscardData()
		{
			return this.As<IBvbAiDiscardDataT>();
		}

		// Token: 0x0602BD00 RID: 179456 RVA: 0x005F567F File Offset: 0x005F387F
		public static TBvbEventDataUnion FromIBvbAiDiscardData(IBvbAiDiscardDataT _ibvbaidiscarddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDiscardData,
				Value = _ibvbaidiscarddata
			};
		}

		// Token: 0x0602BD01 RID: 179457 RVA: 0x005F5694 File Offset: 0x005F3894
		public IBvbAiDiscardForEnergyAndActDataT AsIBvbAiDiscardForEnergyAndActData()
		{
			return this.As<IBvbAiDiscardForEnergyAndActDataT>();
		}

		// Token: 0x0602BD02 RID: 179458 RVA: 0x005F569C File Offset: 0x005F389C
		public static TBvbEventDataUnion FromIBvbAiDiscardForEnergyAndActData(IBvbAiDiscardForEnergyAndActDataT _ibvbaidiscardforenergyandactdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDiscardForEnergyAndActData,
				Value = _ibvbaidiscardforenergyandactdata
			};
		}

		// Token: 0x0602BD03 RID: 179459 RVA: 0x005F56B1 File Offset: 0x005F38B1
		public IBvbAiEvolutionDataT AsIBvbAiEvolutionData()
		{
			return this.As<IBvbAiEvolutionDataT>();
		}

		// Token: 0x0602BD04 RID: 179460 RVA: 0x005F56B9 File Offset: 0x005F38B9
		public static TBvbEventDataUnion FromIBvbAiEvolutionData(IBvbAiEvolutionDataT _ibvbaievolutiondata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiEvolutionData,
				Value = _ibvbaievolutiondata
			};
		}

		// Token: 0x0602BD05 RID: 179461 RVA: 0x005F56CE File Offset: 0x005F38CE
		public IBvbAiGetBestDeployDataT AsIBvbAiGetBestDeployData()
		{
			return this.As<IBvbAiGetBestDeployDataT>();
		}

		// Token: 0x0602BD06 RID: 179462 RVA: 0x005F56D6 File Offset: 0x005F38D6
		public static TBvbEventDataUnion FromIBvbAiGetBestDeployData(IBvbAiGetBestDeployDataT _ibvbaigetbestdeploydata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestDeployData,
				Value = _ibvbaigetbestdeploydata
			};
		}

		// Token: 0x0602BD07 RID: 179463 RVA: 0x005F56EB File Offset: 0x005F38EB
		public IBvbAiGetBestRearrangeDataT AsIBvbAiGetBestRearrangeData()
		{
			return this.As<IBvbAiGetBestRearrangeDataT>();
		}

		// Token: 0x0602BD08 RID: 179464 RVA: 0x005F56F3 File Offset: 0x005F38F3
		public static TBvbEventDataUnion FromIBvbAiGetBestRearrangeData(IBvbAiGetBestRearrangeDataT _ibvbaigetbestrearrangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestRearrangeData,
				Value = _ibvbaigetbestrearrangedata
			};
		}

		// Token: 0x0602BD09 RID: 179465 RVA: 0x005F5708 File Offset: 0x005F3908
		public IBvbAiGetBestReplaceDataT AsIBvbAiGetBestReplaceData()
		{
			return this.As<IBvbAiGetBestReplaceDataT>();
		}

		// Token: 0x0602BD0A RID: 179466 RVA: 0x005F5710 File Offset: 0x005F3910
		public static TBvbEventDataUnion FromIBvbAiGetBestReplaceData(IBvbAiGetBestReplaceDataT _ibvbaigetbestreplacedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestReplaceData,
				Value = _ibvbaigetbestreplacedata
			};
		}

		// Token: 0x0602BD0B RID: 179467 RVA: 0x005F5726 File Offset: 0x005F3926
		public IBvbAiGetBestSwapDataT AsIBvbAiGetBestSwapData()
		{
			return this.As<IBvbAiGetBestSwapDataT>();
		}

		// Token: 0x0602BD0C RID: 179468 RVA: 0x005F572E File Offset: 0x005F392E
		public static TBvbEventDataUnion FromIBvbAiGetBestSwapData(IBvbAiGetBestSwapDataT _ibvbaigetbestswapdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestSwapData,
				Value = _ibvbaigetbestswapdata
			};
		}

		// Token: 0x0602BD0D RID: 179469 RVA: 0x005F5744 File Offset: 0x005F3944
		public IBvbAiRearrangeDataT AsIBvbAiRearrangeData()
		{
			return this.As<IBvbAiRearrangeDataT>();
		}

		// Token: 0x0602BD0E RID: 179470 RVA: 0x005F574C File Offset: 0x005F394C
		public static TBvbEventDataUnion FromIBvbAiRearrangeData(IBvbAiRearrangeDataT _ibvbairearrangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiRearrangeData,
				Value = _ibvbairearrangedata
			};
		}

		// Token: 0x0602BD0F RID: 179471 RVA: 0x005F5762 File Offset: 0x005F3962
		public IBvbAiRecycleDataT AsIBvbAiRecycleData()
		{
			return this.As<IBvbAiRecycleDataT>();
		}

		// Token: 0x0602BD10 RID: 179472 RVA: 0x005F576A File Offset: 0x005F396A
		public static TBvbEventDataUnion FromIBvbAiRecycleData(IBvbAiRecycleDataT _ibvbairecycledata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiRecycleData,
				Value = _ibvbairecycledata
			};
		}

		// Token: 0x0602BD11 RID: 179473 RVA: 0x005F5780 File Offset: 0x005F3980
		public IBvbAiSwapDataT AsIBvbAiSwapData()
		{
			return this.As<IBvbAiSwapDataT>();
		}

		// Token: 0x0602BD12 RID: 179474 RVA: 0x005F5788 File Offset: 0x005F3988
		public static TBvbEventDataUnion FromIBvbAiSwapData(IBvbAiSwapDataT _ibvbaiswapdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiSwapData,
				Value = _ibvbaiswapdata
			};
		}

		// Token: 0x0602BD13 RID: 179475 RVA: 0x005F579E File Offset: 0x005F399E
		public IBvbAiTurnEndDataT AsIBvbAiTurnEndData()
		{
			return this.As<IBvbAiTurnEndDataT>();
		}

		// Token: 0x0602BD14 RID: 179476 RVA: 0x005F57A6 File Offset: 0x005F39A6
		public static TBvbEventDataUnion FromIBvbAiTurnEndData(IBvbAiTurnEndDataT _ibvbaiturnenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiTurnEndData,
				Value = _ibvbaiturnenddata
			};
		}

		// Token: 0x0602BD15 RID: 179477 RVA: 0x005F57BC File Offset: 0x005F39BC
		public IBvbBurnBuffTimeUpDataT AsIBvbBurnBuffTimeUpData()
		{
			return this.As<IBvbBurnBuffTimeUpDataT>();
		}

		// Token: 0x0602BD16 RID: 179478 RVA: 0x005F57C4 File Offset: 0x005F39C4
		public static TBvbEventDataUnion FromIBvbBurnBuffTimeUpData(IBvbBurnBuffTimeUpDataT _ibvbburnbufftimeupdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbBurnBuffTimeUpData,
				Value = _ibvbburnbufftimeupdata
			};
		}

		// Token: 0x0602BD17 RID: 179479 RVA: 0x005F57DA File Offset: 0x005F39DA
		public IBvbEnableHatredDataT AsIBvbEnableHatredData()
		{
			return this.As<IBvbEnableHatredDataT>();
		}

		// Token: 0x0602BD18 RID: 179480 RVA: 0x005F57E2 File Offset: 0x005F39E2
		public static TBvbEventDataUnion FromIBvbEnableHatredData(IBvbEnableHatredDataT _ibvbenablehatreddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbEnableHatredData,
				Value = _ibvbenablehatreddata
			};
		}

		// Token: 0x0602BD19 RID: 179481 RVA: 0x005F57F8 File Offset: 0x005F39F8
		public IBvbPlayerBattleWinDataT AsIBvbPlayerBattleWinData()
		{
			return this.As<IBvbPlayerBattleWinDataT>();
		}

		// Token: 0x0602BD1A RID: 179482 RVA: 0x005F5800 File Offset: 0x005F3A00
		public static TBvbEventDataUnion FromIBvbPlayerBattleWinData(IBvbPlayerBattleWinDataT _ibvbplayerbattlewindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerBattleWinData,
				Value = _ibvbplayerbattlewindata
			};
		}

		// Token: 0x0602BD1B RID: 179483 RVA: 0x005F5816 File Offset: 0x005F3A16
		public IBvbPlayerTurnEndDataT AsIBvbPlayerTurnEndData()
		{
			return this.As<IBvbPlayerTurnEndDataT>();
		}

		// Token: 0x0602BD1C RID: 179484 RVA: 0x005F581E File Offset: 0x005F3A1E
		public static TBvbEventDataUnion FromIBvbPlayerTurnEndData(IBvbPlayerTurnEndDataT _ibvbplayerturnenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerTurnEndData,
				Value = _ibvbplayerturnenddata
			};
		}

		// Token: 0x0602BD1D RID: 179485 RVA: 0x005F5834 File Offset: 0x005F3A34
		public IBvbPlayerTurnStartDataT AsIBvbPlayerTurnStartData()
		{
			return this.As<IBvbPlayerTurnStartDataT>();
		}

		// Token: 0x0602BD1E RID: 179486 RVA: 0x005F583C File Offset: 0x005F3A3C
		public static TBvbEventDataUnion FromIBvbPlayerTurnStartData(IBvbPlayerTurnStartDataT _ibvbplayerturnstartdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerTurnStartData,
				Value = _ibvbplayerturnstartdata
			};
		}

		// Token: 0x0602BD1F RID: 179487 RVA: 0x005F5852 File Offset: 0x005F3A52
		public IBvbSelectCardsEndDataT AsIBvbSelectCardsEndData()
		{
			return this.As<IBvbSelectCardsEndDataT>();
		}

		// Token: 0x0602BD20 RID: 179488 RVA: 0x005F585A File Offset: 0x005F3A5A
		public static TBvbEventDataUnion FromIBvbSelectCardsEndData(IBvbSelectCardsEndDataT _ibvbselectcardsenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbSelectCardsEndData,
				Value = _ibvbselectcardsenddata
			};
		}

		// Token: 0x0602BD21 RID: 179489 RVA: 0x005F5870 File Offset: 0x005F3A70
		public IBvbStartAiDataT AsIBvbStartAiData()
		{
			return this.As<IBvbStartAiDataT>();
		}

		// Token: 0x0602BD22 RID: 179490 RVA: 0x005F5878 File Offset: 0x005F3A78
		public static TBvbEventDataUnion FromIBvbStartAiData(IBvbStartAiDataT _ibvbstartaidata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartAiData,
				Value = _ibvbstartaidata
			};
		}

		// Token: 0x0602BD23 RID: 179491 RVA: 0x005F588E File Offset: 0x005F3A8E
		public IBvbStartBattleDataT AsIBvbStartBattleData()
		{
			return this.As<IBvbStartBattleDataT>();
		}

		// Token: 0x0602BD24 RID: 179492 RVA: 0x005F5896 File Offset: 0x005F3A96
		public static TBvbEventDataUnion FromIBvbStartBattleData(IBvbStartBattleDataT _ibvbstartbattledata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartBattleData,
				Value = _ibvbstartbattledata
			};
		}

		// Token: 0x0602BD25 RID: 179493 RVA: 0x005F58AC File Offset: 0x005F3AAC
		public IBvbStartRoundDataT AsIBvbStartRoundData()
		{
			return this.As<IBvbStartRoundDataT>();
		}

		// Token: 0x0602BD26 RID: 179494 RVA: 0x005F58B4 File Offset: 0x005F3AB4
		public static TBvbEventDataUnion FromIBvbStartRoundData(IBvbStartRoundDataT _ibvbstartrounddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartRoundData,
				Value = _ibvbstartrounddata
			};
		}

		// Token: 0x0602BD27 RID: 179495 RVA: 0x005F58CA File Offset: 0x005F3ACA
		public IBvbWaitForGameBeginDataT AsIBvbWaitForGameBeginData()
		{
			return this.As<IBvbWaitForGameBeginDataT>();
		}

		// Token: 0x0602BD28 RID: 179496 RVA: 0x005F58D2 File Offset: 0x005F3AD2
		public static TBvbEventDataUnion FromIBvbWaitForGameBeginData(IBvbWaitForGameBeginDataT _ibvbwaitforgamebegindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbWaitForGameBeginData,
				Value = _ibvbwaitforgamebegindata
			};
		}

		// Token: 0x0602BD29 RID: 179497 RVA: 0x005F58E8 File Offset: 0x005F3AE8
		public static int Pack(FlatBufferBuilder builder, TBvbEventDataUnion _o)
		{
			switch (_o.Type)
			{
			case TBvbEventData.IBvbAiBattleWinData:
				return IBvbAiBattleWinData.Pack(builder, _o.AsIBvbAiBattleWinData()).Value;
			case TBvbEventData.IBvbAiChangeData:
				return IBvbAiChangeData.Pack(builder, _o.AsIBvbAiChangeData()).Value;
			case TBvbEventData.IBvbAiDeployData:
				return IBvbAiDeployData.Pack(builder, _o.AsIBvbAiDeployData()).Value;
			case TBvbEventData.IBvbAiDiscardData:
				return IBvbAiDiscardData.Pack(builder, _o.AsIBvbAiDiscardData()).Value;
			case TBvbEventData.IBvbAiDiscardForEnergyAndActData:
				return IBvbAiDiscardForEnergyAndActData.Pack(builder, _o.AsIBvbAiDiscardForEnergyAndActData()).Value;
			case TBvbEventData.IBvbAiEvolutionData:
				return IBvbAiEvolutionData.Pack(builder, _o.AsIBvbAiEvolutionData()).Value;
			case TBvbEventData.IBvbAiGetBestDeployData:
				return IBvbAiGetBestDeployData.Pack(builder, _o.AsIBvbAiGetBestDeployData()).Value;
			case TBvbEventData.IBvbAiGetBestRearrangeData:
				return IBvbAiGetBestRearrangeData.Pack(builder, _o.AsIBvbAiGetBestRearrangeData()).Value;
			case TBvbEventData.IBvbAiGetBestReplaceData:
				return IBvbAiGetBestReplaceData.Pack(builder, _o.AsIBvbAiGetBestReplaceData()).Value;
			case TBvbEventData.IBvbAiGetBestSwapData:
				return IBvbAiGetBestSwapData.Pack(builder, _o.AsIBvbAiGetBestSwapData()).Value;
			case TBvbEventData.IBvbAiRearrangeData:
				return IBvbAiRearrangeData.Pack(builder, _o.AsIBvbAiRearrangeData()).Value;
			case TBvbEventData.IBvbAiRecycleData:
				return IBvbAiRecycleData.Pack(builder, _o.AsIBvbAiRecycleData()).Value;
			case TBvbEventData.IBvbAiSwapData:
				return IBvbAiSwapData.Pack(builder, _o.AsIBvbAiSwapData()).Value;
			case TBvbEventData.IBvbAiTurnEndData:
				return IBvbAiTurnEndData.Pack(builder, _o.AsIBvbAiTurnEndData()).Value;
			case TBvbEventData.IBvbBurnBuffTimeUpData:
				return IBvbBurnBuffTimeUpData.Pack(builder, _o.AsIBvbBurnBuffTimeUpData()).Value;
			case TBvbEventData.IBvbEnableHatredData:
				return IBvbEnableHatredData.Pack(builder, _o.AsIBvbEnableHatredData()).Value;
			case TBvbEventData.IBvbPlayerBattleWinData:
				return IBvbPlayerBattleWinData.Pack(builder, _o.AsIBvbPlayerBattleWinData()).Value;
			case TBvbEventData.IBvbPlayerTurnEndData:
				return IBvbPlayerTurnEndData.Pack(builder, _o.AsIBvbPlayerTurnEndData()).Value;
			case TBvbEventData.IBvbPlayerTurnStartData:
				return IBvbPlayerTurnStartData.Pack(builder, _o.AsIBvbPlayerTurnStartData()).Value;
			case TBvbEventData.IBvbSelectCardsEndData:
				return IBvbSelectCardsEndData.Pack(builder, _o.AsIBvbSelectCardsEndData()).Value;
			case TBvbEventData.IBvbStartAiData:
				return IBvbStartAiData.Pack(builder, _o.AsIBvbStartAiData()).Value;
			case TBvbEventData.IBvbStartBattleData:
				return IBvbStartBattleData.Pack(builder, _o.AsIBvbStartBattleData()).Value;
			case TBvbEventData.IBvbStartRoundData:
				return IBvbStartRoundData.Pack(builder, _o.AsIBvbStartRoundData()).Value;
			case TBvbEventData.IBvbWaitForGameBeginData:
				return IBvbWaitForGameBeginData.Pack(builder, _o.AsIBvbWaitForGameBeginData()).Value;
			default:
				return 0;
			}
		}
	}
}
