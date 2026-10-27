using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E6D RID: 24173
	public class TBvbEventDataUnion
	{
		// Token: 0x1700B4BA RID: 46266
		// (get) Token: 0x06029657 RID: 169559 RVA: 0x005AC72E File Offset: 0x005AA92E
		// (set) Token: 0x06029658 RID: 169560 RVA: 0x005AC736 File Offset: 0x005AA936
		public TBvbEventData Type { get; set; }

		// Token: 0x1700B4BB RID: 46267
		// (get) Token: 0x06029659 RID: 169561 RVA: 0x005AC73F File Offset: 0x005AA93F
		// (set) Token: 0x0602965A RID: 169562 RVA: 0x005AC747 File Offset: 0x005AA947
		public object Value { get; set; }

		// Token: 0x0602965B RID: 169563 RVA: 0x005AC750 File Offset: 0x005AA950
		public TBvbEventDataUnion()
		{
			this.Type = TBvbEventData.NONE;
			this.Value = null;
		}

		// Token: 0x0602965C RID: 169564 RVA: 0x005AC766 File Offset: 0x005AA966
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602965D RID: 169565 RVA: 0x005AC778 File Offset: 0x005AA978
		public IBvbAiBattleWinDataT AsIBvbAiBattleWinData()
		{
			return this.As<IBvbAiBattleWinDataT>();
		}

		// Token: 0x0602965E RID: 169566 RVA: 0x005AC780 File Offset: 0x005AA980
		public static TBvbEventDataUnion FromIBvbAiBattleWinData(IBvbAiBattleWinDataT _ibvbaibattlewindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiBattleWinData,
				Value = _ibvbaibattlewindata
			};
		}

		// Token: 0x0602965F RID: 169567 RVA: 0x005AC795 File Offset: 0x005AA995
		public IBvbAiChangeDataT AsIBvbAiChangeData()
		{
			return this.As<IBvbAiChangeDataT>();
		}

		// Token: 0x06029660 RID: 169568 RVA: 0x005AC79D File Offset: 0x005AA99D
		public static TBvbEventDataUnion FromIBvbAiChangeData(IBvbAiChangeDataT _ibvbaichangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiChangeData,
				Value = _ibvbaichangedata
			};
		}

		// Token: 0x06029661 RID: 169569 RVA: 0x005AC7B2 File Offset: 0x005AA9B2
		public IBvbAiDeployDataT AsIBvbAiDeployData()
		{
			return this.As<IBvbAiDeployDataT>();
		}

		// Token: 0x06029662 RID: 169570 RVA: 0x005AC7BA File Offset: 0x005AA9BA
		public static TBvbEventDataUnion FromIBvbAiDeployData(IBvbAiDeployDataT _ibvbaideploydata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDeployData,
				Value = _ibvbaideploydata
			};
		}

		// Token: 0x06029663 RID: 169571 RVA: 0x005AC7CF File Offset: 0x005AA9CF
		public IBvbAiDiscardDataT AsIBvbAiDiscardData()
		{
			return this.As<IBvbAiDiscardDataT>();
		}

		// Token: 0x06029664 RID: 169572 RVA: 0x005AC7D7 File Offset: 0x005AA9D7
		public static TBvbEventDataUnion FromIBvbAiDiscardData(IBvbAiDiscardDataT _ibvbaidiscarddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDiscardData,
				Value = _ibvbaidiscarddata
			};
		}

		// Token: 0x06029665 RID: 169573 RVA: 0x005AC7EC File Offset: 0x005AA9EC
		public IBvbAiDiscardForEnergyAndActDataT AsIBvbAiDiscardForEnergyAndActData()
		{
			return this.As<IBvbAiDiscardForEnergyAndActDataT>();
		}

		// Token: 0x06029666 RID: 169574 RVA: 0x005AC7F4 File Offset: 0x005AA9F4
		public static TBvbEventDataUnion FromIBvbAiDiscardForEnergyAndActData(IBvbAiDiscardForEnergyAndActDataT _ibvbaidiscardforenergyandactdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiDiscardForEnergyAndActData,
				Value = _ibvbaidiscardforenergyandactdata
			};
		}

		// Token: 0x06029667 RID: 169575 RVA: 0x005AC809 File Offset: 0x005AAA09
		public IBvbAiEvolutionDataT AsIBvbAiEvolutionData()
		{
			return this.As<IBvbAiEvolutionDataT>();
		}

		// Token: 0x06029668 RID: 169576 RVA: 0x005AC811 File Offset: 0x005AAA11
		public static TBvbEventDataUnion FromIBvbAiEvolutionData(IBvbAiEvolutionDataT _ibvbaievolutiondata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiEvolutionData,
				Value = _ibvbaievolutiondata
			};
		}

		// Token: 0x06029669 RID: 169577 RVA: 0x005AC826 File Offset: 0x005AAA26
		public IBvbAiGetBestDeployDataT AsIBvbAiGetBestDeployData()
		{
			return this.As<IBvbAiGetBestDeployDataT>();
		}

		// Token: 0x0602966A RID: 169578 RVA: 0x005AC82E File Offset: 0x005AAA2E
		public static TBvbEventDataUnion FromIBvbAiGetBestDeployData(IBvbAiGetBestDeployDataT _ibvbaigetbestdeploydata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestDeployData,
				Value = _ibvbaigetbestdeploydata
			};
		}

		// Token: 0x0602966B RID: 169579 RVA: 0x005AC843 File Offset: 0x005AAA43
		public IBvbAiGetBestRearrangeDataT AsIBvbAiGetBestRearrangeData()
		{
			return this.As<IBvbAiGetBestRearrangeDataT>();
		}

		// Token: 0x0602966C RID: 169580 RVA: 0x005AC84B File Offset: 0x005AAA4B
		public static TBvbEventDataUnion FromIBvbAiGetBestRearrangeData(IBvbAiGetBestRearrangeDataT _ibvbaigetbestrearrangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestRearrangeData,
				Value = _ibvbaigetbestrearrangedata
			};
		}

		// Token: 0x0602966D RID: 169581 RVA: 0x005AC860 File Offset: 0x005AAA60
		public IBvbAiGetBestReplaceDataT AsIBvbAiGetBestReplaceData()
		{
			return this.As<IBvbAiGetBestReplaceDataT>();
		}

		// Token: 0x0602966E RID: 169582 RVA: 0x005AC868 File Offset: 0x005AAA68
		public static TBvbEventDataUnion FromIBvbAiGetBestReplaceData(IBvbAiGetBestReplaceDataT _ibvbaigetbestreplacedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestReplaceData,
				Value = _ibvbaigetbestreplacedata
			};
		}

		// Token: 0x0602966F RID: 169583 RVA: 0x005AC87E File Offset: 0x005AAA7E
		public IBvbAiGetBestSwapDataT AsIBvbAiGetBestSwapData()
		{
			return this.As<IBvbAiGetBestSwapDataT>();
		}

		// Token: 0x06029670 RID: 169584 RVA: 0x005AC886 File Offset: 0x005AAA86
		public static TBvbEventDataUnion FromIBvbAiGetBestSwapData(IBvbAiGetBestSwapDataT _ibvbaigetbestswapdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiGetBestSwapData,
				Value = _ibvbaigetbestswapdata
			};
		}

		// Token: 0x06029671 RID: 169585 RVA: 0x005AC89C File Offset: 0x005AAA9C
		public IBvbAiRearrangeDataT AsIBvbAiRearrangeData()
		{
			return this.As<IBvbAiRearrangeDataT>();
		}

		// Token: 0x06029672 RID: 169586 RVA: 0x005AC8A4 File Offset: 0x005AAAA4
		public static TBvbEventDataUnion FromIBvbAiRearrangeData(IBvbAiRearrangeDataT _ibvbairearrangedata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiRearrangeData,
				Value = _ibvbairearrangedata
			};
		}

		// Token: 0x06029673 RID: 169587 RVA: 0x005AC8BA File Offset: 0x005AAABA
		public IBvbAiRecycleDataT AsIBvbAiRecycleData()
		{
			return this.As<IBvbAiRecycleDataT>();
		}

		// Token: 0x06029674 RID: 169588 RVA: 0x005AC8C2 File Offset: 0x005AAAC2
		public static TBvbEventDataUnion FromIBvbAiRecycleData(IBvbAiRecycleDataT _ibvbairecycledata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiRecycleData,
				Value = _ibvbairecycledata
			};
		}

		// Token: 0x06029675 RID: 169589 RVA: 0x005AC8D8 File Offset: 0x005AAAD8
		public IBvbAiSwapDataT AsIBvbAiSwapData()
		{
			return this.As<IBvbAiSwapDataT>();
		}

		// Token: 0x06029676 RID: 169590 RVA: 0x005AC8E0 File Offset: 0x005AAAE0
		public static TBvbEventDataUnion FromIBvbAiSwapData(IBvbAiSwapDataT _ibvbaiswapdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiSwapData,
				Value = _ibvbaiswapdata
			};
		}

		// Token: 0x06029677 RID: 169591 RVA: 0x005AC8F6 File Offset: 0x005AAAF6
		public IBvbAiTurnEndDataT AsIBvbAiTurnEndData()
		{
			return this.As<IBvbAiTurnEndDataT>();
		}

		// Token: 0x06029678 RID: 169592 RVA: 0x005AC8FE File Offset: 0x005AAAFE
		public static TBvbEventDataUnion FromIBvbAiTurnEndData(IBvbAiTurnEndDataT _ibvbaiturnenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbAiTurnEndData,
				Value = _ibvbaiturnenddata
			};
		}

		// Token: 0x06029679 RID: 169593 RVA: 0x005AC914 File Offset: 0x005AAB14
		public IBvbBurnBuffTimeUpDataT AsIBvbBurnBuffTimeUpData()
		{
			return this.As<IBvbBurnBuffTimeUpDataT>();
		}

		// Token: 0x0602967A RID: 169594 RVA: 0x005AC91C File Offset: 0x005AAB1C
		public static TBvbEventDataUnion FromIBvbBurnBuffTimeUpData(IBvbBurnBuffTimeUpDataT _ibvbburnbufftimeupdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbBurnBuffTimeUpData,
				Value = _ibvbburnbufftimeupdata
			};
		}

		// Token: 0x0602967B RID: 169595 RVA: 0x005AC932 File Offset: 0x005AAB32
		public IBvbEnableHatredDataT AsIBvbEnableHatredData()
		{
			return this.As<IBvbEnableHatredDataT>();
		}

		// Token: 0x0602967C RID: 169596 RVA: 0x005AC93A File Offset: 0x005AAB3A
		public static TBvbEventDataUnion FromIBvbEnableHatredData(IBvbEnableHatredDataT _ibvbenablehatreddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbEnableHatredData,
				Value = _ibvbenablehatreddata
			};
		}

		// Token: 0x0602967D RID: 169597 RVA: 0x005AC950 File Offset: 0x005AAB50
		public IBvbPlayerBattleWinDataT AsIBvbPlayerBattleWinData()
		{
			return this.As<IBvbPlayerBattleWinDataT>();
		}

		// Token: 0x0602967E RID: 169598 RVA: 0x005AC958 File Offset: 0x005AAB58
		public static TBvbEventDataUnion FromIBvbPlayerBattleWinData(IBvbPlayerBattleWinDataT _ibvbplayerbattlewindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerBattleWinData,
				Value = _ibvbplayerbattlewindata
			};
		}

		// Token: 0x0602967F RID: 169599 RVA: 0x005AC96E File Offset: 0x005AAB6E
		public IBvbPlayerTurnEndDataT AsIBvbPlayerTurnEndData()
		{
			return this.As<IBvbPlayerTurnEndDataT>();
		}

		// Token: 0x06029680 RID: 169600 RVA: 0x005AC976 File Offset: 0x005AAB76
		public static TBvbEventDataUnion FromIBvbPlayerTurnEndData(IBvbPlayerTurnEndDataT _ibvbplayerturnenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerTurnEndData,
				Value = _ibvbplayerturnenddata
			};
		}

		// Token: 0x06029681 RID: 169601 RVA: 0x005AC98C File Offset: 0x005AAB8C
		public IBvbPlayerTurnStartDataT AsIBvbPlayerTurnStartData()
		{
			return this.As<IBvbPlayerTurnStartDataT>();
		}

		// Token: 0x06029682 RID: 169602 RVA: 0x005AC994 File Offset: 0x005AAB94
		public static TBvbEventDataUnion FromIBvbPlayerTurnStartData(IBvbPlayerTurnStartDataT _ibvbplayerturnstartdata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbPlayerTurnStartData,
				Value = _ibvbplayerturnstartdata
			};
		}

		// Token: 0x06029683 RID: 169603 RVA: 0x005AC9AA File Offset: 0x005AABAA
		public IBvbSelectCardsEndDataT AsIBvbSelectCardsEndData()
		{
			return this.As<IBvbSelectCardsEndDataT>();
		}

		// Token: 0x06029684 RID: 169604 RVA: 0x005AC9B2 File Offset: 0x005AABB2
		public static TBvbEventDataUnion FromIBvbSelectCardsEndData(IBvbSelectCardsEndDataT _ibvbselectcardsenddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbSelectCardsEndData,
				Value = _ibvbselectcardsenddata
			};
		}

		// Token: 0x06029685 RID: 169605 RVA: 0x005AC9C8 File Offset: 0x005AABC8
		public IBvbStartAiDataT AsIBvbStartAiData()
		{
			return this.As<IBvbStartAiDataT>();
		}

		// Token: 0x06029686 RID: 169606 RVA: 0x005AC9D0 File Offset: 0x005AABD0
		public static TBvbEventDataUnion FromIBvbStartAiData(IBvbStartAiDataT _ibvbstartaidata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartAiData,
				Value = _ibvbstartaidata
			};
		}

		// Token: 0x06029687 RID: 169607 RVA: 0x005AC9E6 File Offset: 0x005AABE6
		public IBvbStartBattleDataT AsIBvbStartBattleData()
		{
			return this.As<IBvbStartBattleDataT>();
		}

		// Token: 0x06029688 RID: 169608 RVA: 0x005AC9EE File Offset: 0x005AABEE
		public static TBvbEventDataUnion FromIBvbStartBattleData(IBvbStartBattleDataT _ibvbstartbattledata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartBattleData,
				Value = _ibvbstartbattledata
			};
		}

		// Token: 0x06029689 RID: 169609 RVA: 0x005ACA04 File Offset: 0x005AAC04
		public IBvbStartRoundDataT AsIBvbStartRoundData()
		{
			return this.As<IBvbStartRoundDataT>();
		}

		// Token: 0x0602968A RID: 169610 RVA: 0x005ACA0C File Offset: 0x005AAC0C
		public static TBvbEventDataUnion FromIBvbStartRoundData(IBvbStartRoundDataT _ibvbstartrounddata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbStartRoundData,
				Value = _ibvbstartrounddata
			};
		}

		// Token: 0x0602968B RID: 169611 RVA: 0x005ACA22 File Offset: 0x005AAC22
		public IBvbWaitForGameBeginDataT AsIBvbWaitForGameBeginData()
		{
			return this.As<IBvbWaitForGameBeginDataT>();
		}

		// Token: 0x0602968C RID: 169612 RVA: 0x005ACA2A File Offset: 0x005AAC2A
		public static TBvbEventDataUnion FromIBvbWaitForGameBeginData(IBvbWaitForGameBeginDataT _ibvbwaitforgamebegindata)
		{
			return new TBvbEventDataUnion
			{
				Type = TBvbEventData.IBvbWaitForGameBeginData,
				Value = _ibvbwaitforgamebegindata
			};
		}

		// Token: 0x0602968D RID: 169613 RVA: 0x005ACA40 File Offset: 0x005AAC40
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
