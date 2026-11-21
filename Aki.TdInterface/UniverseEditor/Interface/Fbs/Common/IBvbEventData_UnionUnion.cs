using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006387 RID: 25479
	public class IBvbEventData_UnionUnion
	{
		// Token: 0x1700BC67 RID: 48231
		// (get) Token: 0x0602B42C RID: 177196 RVA: 0x005E623D File Offset: 0x005E443D
		// (set) Token: 0x0602B42D RID: 177197 RVA: 0x005E6245 File Offset: 0x005E4445
		public IBvbEventData_Union Type { get; set; }

		// Token: 0x1700BC68 RID: 48232
		// (get) Token: 0x0602B42E RID: 177198 RVA: 0x005E624E File Offset: 0x005E444E
		// (set) Token: 0x0602B42F RID: 177199 RVA: 0x005E6256 File Offset: 0x005E4456
		public object Value { get; set; }

		// Token: 0x0602B430 RID: 177200 RVA: 0x005E625F File Offset: 0x005E445F
		public IBvbEventData_UnionUnion()
		{
			this.Type = IBvbEventData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B431 RID: 177201 RVA: 0x005E6275 File Offset: 0x005E4475
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B432 RID: 177202 RVA: 0x005E6287 File Offset: 0x005E4487
		public IBvbEventDataT AsIBvbEventData()
		{
			return this.As<IBvbEventDataT>();
		}

		// Token: 0x0602B433 RID: 177203 RVA: 0x005E628F File Offset: 0x005E448F
		public static IBvbEventData_UnionUnion FromIBvbEventData(IBvbEventDataT _ibvbeventdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbEventData,
				Value = _ibvbeventdata
			};
		}

		// Token: 0x0602B434 RID: 177204 RVA: 0x005E62A4 File Offset: 0x005E44A4
		public IBvbAiEvolutionDataT AsIBvbAiEvolutionData()
		{
			return this.As<IBvbAiEvolutionDataT>();
		}

		// Token: 0x0602B435 RID: 177205 RVA: 0x005E62AC File Offset: 0x005E44AC
		public static IBvbEventData_UnionUnion FromIBvbAiEvolutionData(IBvbAiEvolutionDataT _ibvbaievolutiondata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiEvolutionData,
				Value = _ibvbaievolutiondata
			};
		}

		// Token: 0x0602B436 RID: 177206 RVA: 0x005E62C1 File Offset: 0x005E44C1
		public IBvbAiDeployDataT AsIBvbAiDeployData()
		{
			return this.As<IBvbAiDeployDataT>();
		}

		// Token: 0x0602B437 RID: 177207 RVA: 0x005E62C9 File Offset: 0x005E44C9
		public static IBvbEventData_UnionUnion FromIBvbAiDeployData(IBvbAiDeployDataT _ibvbaideploydata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDeployData,
				Value = _ibvbaideploydata
			};
		}

		// Token: 0x0602B438 RID: 177208 RVA: 0x005E62DE File Offset: 0x005E44DE
		public IBvbAiChangeDataT AsIBvbAiChangeData()
		{
			return this.As<IBvbAiChangeDataT>();
		}

		// Token: 0x0602B439 RID: 177209 RVA: 0x005E62E6 File Offset: 0x005E44E6
		public static IBvbEventData_UnionUnion FromIBvbAiChangeData(IBvbAiChangeDataT _ibvbaichangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiChangeData,
				Value = _ibvbaichangedata
			};
		}

		// Token: 0x0602B43A RID: 177210 RVA: 0x005E62FB File Offset: 0x005E44FB
		public IBvbAiRecycleDataT AsIBvbAiRecycleData()
		{
			return this.As<IBvbAiRecycleDataT>();
		}

		// Token: 0x0602B43B RID: 177211 RVA: 0x005E6303 File Offset: 0x005E4503
		public static IBvbEventData_UnionUnion FromIBvbAiRecycleData(IBvbAiRecycleDataT _ibvbairecycledata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiRecycleData,
				Value = _ibvbairecycledata
			};
		}

		// Token: 0x0602B43C RID: 177212 RVA: 0x005E6318 File Offset: 0x005E4518
		public IBvbAiRearrangeDataT AsIBvbAiRearrangeData()
		{
			return this.As<IBvbAiRearrangeDataT>();
		}

		// Token: 0x0602B43D RID: 177213 RVA: 0x005E6320 File Offset: 0x005E4520
		public static IBvbEventData_UnionUnion FromIBvbAiRearrangeData(IBvbAiRearrangeDataT _ibvbairearrangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiRearrangeData,
				Value = _ibvbairearrangedata
			};
		}

		// Token: 0x0602B43E RID: 177214 RVA: 0x005E6335 File Offset: 0x005E4535
		public IBvbAiSwapDataT AsIBvbAiSwapData()
		{
			return this.As<IBvbAiSwapDataT>();
		}

		// Token: 0x0602B43F RID: 177215 RVA: 0x005E633D File Offset: 0x005E453D
		public static IBvbEventData_UnionUnion FromIBvbAiSwapData(IBvbAiSwapDataT _ibvbaiswapdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiSwapData,
				Value = _ibvbaiswapdata
			};
		}

		// Token: 0x0602B440 RID: 177216 RVA: 0x005E6352 File Offset: 0x005E4552
		public IBvbAiDiscardDataT AsIBvbAiDiscardData()
		{
			return this.As<IBvbAiDiscardDataT>();
		}

		// Token: 0x0602B441 RID: 177217 RVA: 0x005E635A File Offset: 0x005E455A
		public static IBvbEventData_UnionUnion FromIBvbAiDiscardData(IBvbAiDiscardDataT _ibvbaidiscarddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDiscardData,
				Value = _ibvbaidiscarddata
			};
		}

		// Token: 0x0602B442 RID: 177218 RVA: 0x005E636F File Offset: 0x005E456F
		public IBvbAiGetBestDeployDataT AsIBvbAiGetBestDeployData()
		{
			return this.As<IBvbAiGetBestDeployDataT>();
		}

		// Token: 0x0602B443 RID: 177219 RVA: 0x005E6377 File Offset: 0x005E4577
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestDeployData(IBvbAiGetBestDeployDataT _ibvbaigetbestdeploydata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestDeployData,
				Value = _ibvbaigetbestdeploydata
			};
		}

		// Token: 0x0602B444 RID: 177220 RVA: 0x005E638D File Offset: 0x005E458D
		public IBvbAiGetBestRearrangeDataT AsIBvbAiGetBestRearrangeData()
		{
			return this.As<IBvbAiGetBestRearrangeDataT>();
		}

		// Token: 0x0602B445 RID: 177221 RVA: 0x005E6395 File Offset: 0x005E4595
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestRearrangeData(IBvbAiGetBestRearrangeDataT _ibvbaigetbestrearrangedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestRearrangeData,
				Value = _ibvbaigetbestrearrangedata
			};
		}

		// Token: 0x0602B446 RID: 177222 RVA: 0x005E63AB File Offset: 0x005E45AB
		public IBvbAiGetBestSwapDataT AsIBvbAiGetBestSwapData()
		{
			return this.As<IBvbAiGetBestSwapDataT>();
		}

		// Token: 0x0602B447 RID: 177223 RVA: 0x005E63B3 File Offset: 0x005E45B3
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestSwapData(IBvbAiGetBestSwapDataT _ibvbaigetbestswapdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestSwapData,
				Value = _ibvbaigetbestswapdata
			};
		}

		// Token: 0x0602B448 RID: 177224 RVA: 0x005E63C9 File Offset: 0x005E45C9
		public IBvbAiGetBestReplaceDataT AsIBvbAiGetBestReplaceData()
		{
			return this.As<IBvbAiGetBestReplaceDataT>();
		}

		// Token: 0x0602B449 RID: 177225 RVA: 0x005E63D1 File Offset: 0x005E45D1
		public static IBvbEventData_UnionUnion FromIBvbAiGetBestReplaceData(IBvbAiGetBestReplaceDataT _ibvbaigetbestreplacedata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiGetBestReplaceData,
				Value = _ibvbaigetbestreplacedata
			};
		}

		// Token: 0x0602B44A RID: 177226 RVA: 0x005E63E7 File Offset: 0x005E45E7
		public IBvbAiDiscardForEnergyAndActDataT AsIBvbAiDiscardForEnergyAndActData()
		{
			return this.As<IBvbAiDiscardForEnergyAndActDataT>();
		}

		// Token: 0x0602B44B RID: 177227 RVA: 0x005E63EF File Offset: 0x005E45EF
		public static IBvbEventData_UnionUnion FromIBvbAiDiscardForEnergyAndActData(IBvbAiDiscardForEnergyAndActDataT _ibvbaidiscardforenergyandactdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiDiscardForEnergyAndActData,
				Value = _ibvbaidiscardforenergyandactdata
			};
		}

		// Token: 0x0602B44C RID: 177228 RVA: 0x005E6405 File Offset: 0x005E4605
		public IBvbAiTurnEndDataT AsIBvbAiTurnEndData()
		{
			return this.As<IBvbAiTurnEndDataT>();
		}

		// Token: 0x0602B44D RID: 177229 RVA: 0x005E640D File Offset: 0x005E460D
		public static IBvbEventData_UnionUnion FromIBvbAiTurnEndData(IBvbAiTurnEndDataT _ibvbaiturnenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiTurnEndData,
				Value = _ibvbaiturnenddata
			};
		}

		// Token: 0x0602B44E RID: 177230 RVA: 0x005E6423 File Offset: 0x005E4623
		public IBvbStartAiDataT AsIBvbStartAiData()
		{
			return this.As<IBvbStartAiDataT>();
		}

		// Token: 0x0602B44F RID: 177231 RVA: 0x005E642B File Offset: 0x005E462B
		public static IBvbEventData_UnionUnion FromIBvbStartAiData(IBvbStartAiDataT _ibvbstartaidata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartAiData,
				Value = _ibvbstartaidata
			};
		}

		// Token: 0x0602B450 RID: 177232 RVA: 0x005E6441 File Offset: 0x005E4641
		public IBvbStartBattleDataT AsIBvbStartBattleData()
		{
			return this.As<IBvbStartBattleDataT>();
		}

		// Token: 0x0602B451 RID: 177233 RVA: 0x005E6449 File Offset: 0x005E4649
		public static IBvbEventData_UnionUnion FromIBvbStartBattleData(IBvbStartBattleDataT _ibvbstartbattledata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartBattleData,
				Value = _ibvbstartbattledata
			};
		}

		// Token: 0x0602B452 RID: 177234 RVA: 0x005E645F File Offset: 0x005E465F
		public IBvbEnableHatredDataT AsIBvbEnableHatredData()
		{
			return this.As<IBvbEnableHatredDataT>();
		}

		// Token: 0x0602B453 RID: 177235 RVA: 0x005E6467 File Offset: 0x005E4667
		public static IBvbEventData_UnionUnion FromIBvbEnableHatredData(IBvbEnableHatredDataT _ibvbenablehatreddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbEnableHatredData,
				Value = _ibvbenablehatreddata
			};
		}

		// Token: 0x0602B454 RID: 177236 RVA: 0x005E647D File Offset: 0x005E467D
		public IBvbStartRoundDataT AsIBvbStartRoundData()
		{
			return this.As<IBvbStartRoundDataT>();
		}

		// Token: 0x0602B455 RID: 177237 RVA: 0x005E6485 File Offset: 0x005E4685
		public static IBvbEventData_UnionUnion FromIBvbStartRoundData(IBvbStartRoundDataT _ibvbstartrounddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbStartRoundData,
				Value = _ibvbstartrounddata
			};
		}

		// Token: 0x0602B456 RID: 177238 RVA: 0x005E649B File Offset: 0x005E469B
		public IBvbBurnBuffTimeUpDataT AsIBvbBurnBuffTimeUpData()
		{
			return this.As<IBvbBurnBuffTimeUpDataT>();
		}

		// Token: 0x0602B457 RID: 177239 RVA: 0x005E64A3 File Offset: 0x005E46A3
		public static IBvbEventData_UnionUnion FromIBvbBurnBuffTimeUpData(IBvbBurnBuffTimeUpDataT _ibvbburnbufftimeupdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbBurnBuffTimeUpData,
				Value = _ibvbburnbufftimeupdata
			};
		}

		// Token: 0x0602B458 RID: 177240 RVA: 0x005E64B9 File Offset: 0x005E46B9
		public IBvbWaitForGameBeginDataT AsIBvbWaitForGameBeginData()
		{
			return this.As<IBvbWaitForGameBeginDataT>();
		}

		// Token: 0x0602B459 RID: 177241 RVA: 0x005E64C1 File Offset: 0x005E46C1
		public static IBvbEventData_UnionUnion FromIBvbWaitForGameBeginData(IBvbWaitForGameBeginDataT _ibvbwaitforgamebegindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbWaitForGameBeginData,
				Value = _ibvbwaitforgamebegindata
			};
		}

		// Token: 0x0602B45A RID: 177242 RVA: 0x005E64D7 File Offset: 0x005E46D7
		public IBvbPlayerTurnStartDataT AsIBvbPlayerTurnStartData()
		{
			return this.As<IBvbPlayerTurnStartDataT>();
		}

		// Token: 0x0602B45B RID: 177243 RVA: 0x005E64DF File Offset: 0x005E46DF
		public static IBvbEventData_UnionUnion FromIBvbPlayerTurnStartData(IBvbPlayerTurnStartDataT _ibvbplayerturnstartdata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerTurnStartData,
				Value = _ibvbplayerturnstartdata
			};
		}

		// Token: 0x0602B45C RID: 177244 RVA: 0x005E64F5 File Offset: 0x005E46F5
		public IBvbPlayerTurnEndDataT AsIBvbPlayerTurnEndData()
		{
			return this.As<IBvbPlayerTurnEndDataT>();
		}

		// Token: 0x0602B45D RID: 177245 RVA: 0x005E64FD File Offset: 0x005E46FD
		public static IBvbEventData_UnionUnion FromIBvbPlayerTurnEndData(IBvbPlayerTurnEndDataT _ibvbplayerturnenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerTurnEndData,
				Value = _ibvbplayerturnenddata
			};
		}

		// Token: 0x0602B45E RID: 177246 RVA: 0x005E6513 File Offset: 0x005E4713
		public IBvbAiBattleWinDataT AsIBvbAiBattleWinData()
		{
			return this.As<IBvbAiBattleWinDataT>();
		}

		// Token: 0x0602B45F RID: 177247 RVA: 0x005E651B File Offset: 0x005E471B
		public static IBvbEventData_UnionUnion FromIBvbAiBattleWinData(IBvbAiBattleWinDataT _ibvbaibattlewindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbAiBattleWinData,
				Value = _ibvbaibattlewindata
			};
		}

		// Token: 0x0602B460 RID: 177248 RVA: 0x005E6531 File Offset: 0x005E4731
		public IBvbPlayerBattleWinDataT AsIBvbPlayerBattleWinData()
		{
			return this.As<IBvbPlayerBattleWinDataT>();
		}

		// Token: 0x0602B461 RID: 177249 RVA: 0x005E6539 File Offset: 0x005E4739
		public static IBvbEventData_UnionUnion FromIBvbPlayerBattleWinData(IBvbPlayerBattleWinDataT _ibvbplayerbattlewindata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbPlayerBattleWinData,
				Value = _ibvbplayerbattlewindata
			};
		}

		// Token: 0x0602B462 RID: 177250 RVA: 0x005E654F File Offset: 0x005E474F
		public IBvbSelectCardsEndDataT AsIBvbSelectCardsEndData()
		{
			return this.As<IBvbSelectCardsEndDataT>();
		}

		// Token: 0x0602B463 RID: 177251 RVA: 0x005E6557 File Offset: 0x005E4757
		public static IBvbEventData_UnionUnion FromIBvbSelectCardsEndData(IBvbSelectCardsEndDataT _ibvbselectcardsenddata)
		{
			return new IBvbEventData_UnionUnion
			{
				Type = IBvbEventData_Union.IBvbSelectCardsEndData,
				Value = _ibvbselectcardsenddata
			};
		}

		// Token: 0x0602B464 RID: 177252 RVA: 0x005E6570 File Offset: 0x005E4770
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
