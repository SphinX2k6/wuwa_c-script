using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006622 RID: 26146
	public class IDynamicSettlementConfig_UnionUnion
	{
		// Token: 0x1700C240 RID: 49728
		// (get) Token: 0x0602D669 RID: 185961 RVA: 0x00638731 File Offset: 0x00636931
		// (set) Token: 0x0602D66A RID: 185962 RVA: 0x00638739 File Offset: 0x00636939
		public IDynamicSettlementConfig_Union Type { get; set; }

		// Token: 0x1700C241 RID: 49729
		// (get) Token: 0x0602D66B RID: 185963 RVA: 0x00638742 File Offset: 0x00636942
		// (set) Token: 0x0602D66C RID: 185964 RVA: 0x0063874A File Offset: 0x0063694A
		public object Value { get; set; }

		// Token: 0x0602D66D RID: 185965 RVA: 0x00638753 File Offset: 0x00636953
		public IDynamicSettlementConfig_UnionUnion()
		{
			this.Type = IDynamicSettlementConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D66E RID: 185966 RVA: 0x00638769 File Offset: 0x00636969
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D66F RID: 185967 RVA: 0x0063877B File Offset: 0x0063697B
		public IDynamicSettlementConfigT AsIDynamicSettlementConfig()
		{
			return this.As<IDynamicSettlementConfigT>();
		}

		// Token: 0x0602D670 RID: 185968 RVA: 0x00638783 File Offset: 0x00636983
		public static IDynamicSettlementConfig_UnionUnion FromIDynamicSettlementConfig(IDynamicSettlementConfigT _idynamicsettlementconfig)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.IDynamicSettlementConfig,
				Value = _idynamicsettlementconfig
			};
		}

		// Token: 0x0602D671 RID: 185969 RVA: 0x00638798 File Offset: 0x00636998
		public IBattleSettlementT AsIBattleSettlement()
		{
			return this.As<IBattleSettlementT>();
		}

		// Token: 0x0602D672 RID: 185970 RVA: 0x006387A0 File Offset: 0x006369A0
		public static IDynamicSettlementConfig_UnionUnion FromIBattleSettlement(IBattleSettlementT _ibattlesettlement)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.IBattleSettlement,
				Value = _ibattlesettlement
			};
		}

		// Token: 0x0602D673 RID: 185971 RVA: 0x006387B5 File Offset: 0x006369B5
		public ISoaringChallengeSettlementT AsISoaringChallengeSettlement()
		{
			return this.As<ISoaringChallengeSettlementT>();
		}

		// Token: 0x0602D674 RID: 185972 RVA: 0x006387BD File Offset: 0x006369BD
		public static IDynamicSettlementConfig_UnionUnion FromISoaringChallengeSettlement(ISoaringChallengeSettlementT _isoaringchallengesettlement)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.ISoaringChallengeSettlement,
				Value = _isoaringchallengesettlement
			};
		}

		// Token: 0x0602D675 RID: 185973 RVA: 0x006387D4 File Offset: 0x006369D4
		public static int Pack(FlatBufferBuilder builder, IDynamicSettlementConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDynamicSettlementConfig_Union.IDynamicSettlementConfig:
				return IDynamicSettlementConfig.Pack(builder, _o.AsIDynamicSettlementConfig()).Value;
			case IDynamicSettlementConfig_Union.IBattleSettlement:
				return IBattleSettlement.Pack(builder, _o.AsIBattleSettlement()).Value;
			case IDynamicSettlementConfig_Union.ISoaringChallengeSettlement:
				return ISoaringChallengeSettlement.Pack(builder, _o.AsISoaringChallengeSettlement()).Value;
			default:
				return 0;
			}
		}
	}
}
