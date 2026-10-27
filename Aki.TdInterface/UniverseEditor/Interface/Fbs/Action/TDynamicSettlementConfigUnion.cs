using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AB RID: 30379
	public class TDynamicSettlementConfigUnion
	{
		// Token: 0x1700E60B RID: 58891
		// (get) Token: 0x06037446 RID: 226374 RVA: 0x0077D4FA File Offset: 0x0077B6FA
		// (set) Token: 0x06037447 RID: 226375 RVA: 0x0077D502 File Offset: 0x0077B702
		public TDynamicSettlementConfig Type { get; set; }

		// Token: 0x1700E60C RID: 58892
		// (get) Token: 0x06037448 RID: 226376 RVA: 0x0077D50B File Offset: 0x0077B70B
		// (set) Token: 0x06037449 RID: 226377 RVA: 0x0077D513 File Offset: 0x0077B713
		public object Value { get; set; }

		// Token: 0x0603744A RID: 226378 RVA: 0x0077D51C File Offset: 0x0077B71C
		public TDynamicSettlementConfigUnion()
		{
			this.Type = TDynamicSettlementConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603744B RID: 226379 RVA: 0x0077D532 File Offset: 0x0077B732
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603744C RID: 226380 RVA: 0x0077D544 File Offset: 0x0077B744
		public IBattleSettlementT AsIBattleSettlement()
		{
			return this.As<IBattleSettlementT>();
		}

		// Token: 0x0603744D RID: 226381 RVA: 0x0077D54C File Offset: 0x0077B74C
		public static TDynamicSettlementConfigUnion FromIBattleSettlement(IBattleSettlementT _ibattlesettlement)
		{
			return new TDynamicSettlementConfigUnion
			{
				Type = TDynamicSettlementConfig.IBattleSettlement,
				Value = _ibattlesettlement
			};
		}

		// Token: 0x0603744E RID: 226382 RVA: 0x0077D561 File Offset: 0x0077B761
		public ISoaringChallengeSettlementT AsISoaringChallengeSettlement()
		{
			return this.As<ISoaringChallengeSettlementT>();
		}

		// Token: 0x0603744F RID: 226383 RVA: 0x0077D569 File Offset: 0x0077B769
		public static TDynamicSettlementConfigUnion FromISoaringChallengeSettlement(ISoaringChallengeSettlementT _isoaringchallengesettlement)
		{
			return new TDynamicSettlementConfigUnion
			{
				Type = TDynamicSettlementConfig.ISoaringChallengeSettlement,
				Value = _isoaringchallengesettlement
			};
		}

		// Token: 0x06037450 RID: 226384 RVA: 0x0077D580 File Offset: 0x0077B780
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
