using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EB6 RID: 32438
	public class TDynamicSettlementConfigUnion
	{
		// Token: 0x1700F247 RID: 62023
		// (get) Token: 0x0603A8E9 RID: 239849 RVA: 0x007E164E File Offset: 0x007DF84E
		// (set) Token: 0x0603A8EA RID: 239850 RVA: 0x007E1656 File Offset: 0x007DF856
		public TDynamicSettlementConfig Type { get; set; }

		// Token: 0x1700F248 RID: 62024
		// (get) Token: 0x0603A8EB RID: 239851 RVA: 0x007E165F File Offset: 0x007DF85F
		// (set) Token: 0x0603A8EC RID: 239852 RVA: 0x007E1667 File Offset: 0x007DF867
		public object Value { get; set; }

		// Token: 0x0603A8ED RID: 239853 RVA: 0x007E1670 File Offset: 0x007DF870
		public TDynamicSettlementConfigUnion()
		{
			this.Type = TDynamicSettlementConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8EE RID: 239854 RVA: 0x007E1686 File Offset: 0x007DF886
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8EF RID: 239855 RVA: 0x007E1698 File Offset: 0x007DF898
		public IBattleSettlementT AsIBattleSettlement()
		{
			return this.As<IBattleSettlementT>();
		}

		// Token: 0x0603A8F0 RID: 239856 RVA: 0x007E16A0 File Offset: 0x007DF8A0
		public static TDynamicSettlementConfigUnion FromIBattleSettlement(IBattleSettlementT _ibattlesettlement)
		{
			return new TDynamicSettlementConfigUnion
			{
				Type = TDynamicSettlementConfig.IBattleSettlement,
				Value = _ibattlesettlement
			};
		}

		// Token: 0x0603A8F1 RID: 239857 RVA: 0x007E16B5 File Offset: 0x007DF8B5
		public ISoaringChallengeSettlementT AsISoaringChallengeSettlement()
		{
			return this.As<ISoaringChallengeSettlementT>();
		}

		// Token: 0x0603A8F2 RID: 239858 RVA: 0x007E16BD File Offset: 0x007DF8BD
		public static TDynamicSettlementConfigUnion FromISoaringChallengeSettlement(ISoaringChallengeSettlementT _isoaringchallengesettlement)
		{
			return new TDynamicSettlementConfigUnion
			{
				Type = TDynamicSettlementConfig.ISoaringChallengeSettlement,
				Value = _isoaringchallengesettlement
			};
		}

		// Token: 0x0603A8F3 RID: 239859 RVA: 0x007E16D4 File Offset: 0x007DF8D4
		public static int Pack(FlatBufferBuilder builder, TDynamicSettlementConfigUnion _o)
		{
			TDynamicSettlementConfig type = _o.Type;
			if (type == TDynamicSettlementConfig.IBattleSettlement)
			{
				return IBattleSettlement.Pack(builder, _o.AsIBattleSettlement()).Value;
			}
			if (type != TDynamicSettlementConfig.ISoaringChallengeSettlement)
			{
				return 0;
			}
			return ISoaringChallengeSettlement.Pack(builder, _o.AsISoaringChallengeSettlement()).Value;
		}
	}
}
