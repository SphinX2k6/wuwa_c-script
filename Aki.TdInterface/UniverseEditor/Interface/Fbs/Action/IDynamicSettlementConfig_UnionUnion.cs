using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C93 RID: 27795
	public class IDynamicSettlementConfig_UnionUnion
	{
		// Token: 0x1700CBDE RID: 52190
		// (get) Token: 0x0602FE3A RID: 196154 RVA: 0x00685299 File Offset: 0x00683499
		// (set) Token: 0x0602FE3B RID: 196155 RVA: 0x006852A1 File Offset: 0x006834A1
		public IDynamicSettlementConfig_Union Type { get; set; }

		// Token: 0x1700CBDF RID: 52191
		// (get) Token: 0x0602FE3C RID: 196156 RVA: 0x006852AA File Offset: 0x006834AA
		// (set) Token: 0x0602FE3D RID: 196157 RVA: 0x006852B2 File Offset: 0x006834B2
		public object Value { get; set; }

		// Token: 0x0602FE3E RID: 196158 RVA: 0x006852BB File Offset: 0x006834BB
		public IDynamicSettlementConfig_UnionUnion()
		{
			this.Type = IDynamicSettlementConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FE3F RID: 196159 RVA: 0x006852D1 File Offset: 0x006834D1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FE40 RID: 196160 RVA: 0x006852E3 File Offset: 0x006834E3
		public IDynamicSettlementConfigT AsIDynamicSettlementConfig()
		{
			return this.As<IDynamicSettlementConfigT>();
		}

		// Token: 0x0602FE41 RID: 196161 RVA: 0x006852EB File Offset: 0x006834EB
		public static IDynamicSettlementConfig_UnionUnion FromIDynamicSettlementConfig(IDynamicSettlementConfigT _idynamicsettlementconfig)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.IDynamicSettlementConfig,
				Value = _idynamicsettlementconfig
			};
		}

		// Token: 0x0602FE42 RID: 196162 RVA: 0x00685300 File Offset: 0x00683500
		public IBattleSettlementT AsIBattleSettlement()
		{
			return this.As<IBattleSettlementT>();
		}

		// Token: 0x0602FE43 RID: 196163 RVA: 0x00685308 File Offset: 0x00683508
		public static IDynamicSettlementConfig_UnionUnion FromIBattleSettlement(IBattleSettlementT _ibattlesettlement)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.IBattleSettlement,
				Value = _ibattlesettlement
			};
		}

		// Token: 0x0602FE44 RID: 196164 RVA: 0x0068531D File Offset: 0x0068351D
		public ISoaringChallengeSettlementT AsISoaringChallengeSettlement()
		{
			return this.As<ISoaringChallengeSettlementT>();
		}

		// Token: 0x0602FE45 RID: 196165 RVA: 0x00685325 File Offset: 0x00683525
		public static IDynamicSettlementConfig_UnionUnion FromISoaringChallengeSettlement(ISoaringChallengeSettlementT _isoaringchallengesettlement)
		{
			return new IDynamicSettlementConfig_UnionUnion
			{
				Type = IDynamicSettlementConfig_Union.ISoaringChallengeSettlement,
				Value = _isoaringchallengesettlement
			};
		}

		// Token: 0x0602FE46 RID: 196166 RVA: 0x0068533C File Offset: 0x0068353C
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
