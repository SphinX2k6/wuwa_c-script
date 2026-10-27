using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B57 RID: 15191
	public class TSystemVarUnion
	{
		// Token: 0x17006824 RID: 26660
		// (get) Token: 0x06014C4D RID: 85069 RVA: 0x00304997 File Offset: 0x00302B97
		// (set) Token: 0x06014C4E RID: 85070 RVA: 0x0030499F File Offset: 0x00302B9F
		public TSystemVar Type { get; set; }

		// Token: 0x17006825 RID: 26661
		// (get) Token: 0x06014C4F RID: 85071 RVA: 0x003049A8 File Offset: 0x00302BA8
		// (set) Token: 0x06014C50 RID: 85072 RVA: 0x003049B0 File Offset: 0x00302BB0
		public object Value { get; set; }

		// Token: 0x06014C51 RID: 85073 RVA: 0x003049B9 File Offset: 0x00302BB9
		public TSystemVarUnion()
		{
			this.Type = TSystemVar.NONE;
			this.Value = null;
		}

		// Token: 0x06014C52 RID: 85074 RVA: 0x003049CF File Offset: 0x00302BCF
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014C53 RID: 85075 RVA: 0x003049E1 File Offset: 0x00302BE1
		public IBvbAdjustPosPreferenceT AsIBvbAdjustPosPreference()
		{
			return this.As<IBvbAdjustPosPreferenceT>();
		}

		// Token: 0x06014C54 RID: 85076 RVA: 0x003049E9 File Offset: 0x00302BE9
		public static TSystemVarUnion FromIBvbAdjustPosPreference(IBvbAdjustPosPreferenceT _ibvbadjustpospreference)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbAdjustPosPreference,
				Value = _ibvbadjustpospreference
			};
		}

		// Token: 0x06014C55 RID: 85077 RVA: 0x003049FE File Offset: 0x00302BFE
		public IBvbCurRoundT AsIBvbCurRound()
		{
			return this.As<IBvbCurRoundT>();
		}

		// Token: 0x06014C56 RID: 85078 RVA: 0x00304A06 File Offset: 0x00302C06
		public static TSystemVarUnion FromIBvbCurRound(IBvbCurRoundT _ibvbcurround)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCurRound,
				Value = _ibvbcurround
			};
		}

		// Token: 0x06014C57 RID: 85079 RVA: 0x00304A1B File Offset: 0x00302C1B
		public IBvbDungeonStageT AsIBvbDungeonStage()
		{
			return this.As<IBvbDungeonStageT>();
		}

		// Token: 0x06014C58 RID: 85080 RVA: 0x00304A23 File Offset: 0x00302C23
		public static TSystemVarUnion FromIBvbDungeonStage(IBvbDungeonStageT _ibvbdungeonstage)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbDungeonStage,
				Value = _ibvbdungeonstage
			};
		}

		// Token: 0x06014C59 RID: 85081 RVA: 0x00304A38 File Offset: 0x00302C38
		public IBvbFetchHandCardT AsIBvbFetchHandCard()
		{
			return this.As<IBvbFetchHandCardT>();
		}

		// Token: 0x06014C5A RID: 85082 RVA: 0x00304A40 File Offset: 0x00302C40
		public static TSystemVarUnion FromIBvbFetchHandCard(IBvbFetchHandCardT _ibvbfetchhandcard)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbFetchHandCard,
				Value = _ibvbfetchhandcard
			};
		}

		// Token: 0x06014C5B RID: 85083 RVA: 0x00304A55 File Offset: 0x00302C55
		public IBvbGetBoardCardT AsIBvbGetBoardCard()
		{
			return this.As<IBvbGetBoardCardT>();
		}

		// Token: 0x06014C5C RID: 85084 RVA: 0x00304A5D File Offset: 0x00302C5D
		public static TSystemVarUnion FromIBvbGetBoardCard(IBvbGetBoardCardT _ibvbgetboardcard)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetBoardCard,
				Value = _ibvbgetboardcard
			};
		}

		// Token: 0x06014C5D RID: 85085 RVA: 0x00304A72 File Offset: 0x00302C72
		public IBvbGetCardChangeUseT AsIBvbGetCardChangeUse()
		{
			return this.As<IBvbGetCardChangeUseT>();
		}

		// Token: 0x06014C5E RID: 85086 RVA: 0x00304A7A File Offset: 0x00302C7A
		public static TSystemVarUnion FromIBvbGetCardChangeUse(IBvbGetCardChangeUseT _ibvbgetcardchangeuse)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardChangeUse,
				Value = _ibvbgetcardchangeuse
			};
		}

		// Token: 0x06014C5F RID: 85087 RVA: 0x00304A8F File Offset: 0x00302C8F
		public IBvbGetCardEvolvedUseT AsIBvbGetCardEvolvedUse()
		{
			return this.As<IBvbGetCardEvolvedUseT>();
		}

		// Token: 0x06014C60 RID: 85088 RVA: 0x00304A97 File Offset: 0x00302C97
		public static TSystemVarUnion FromIBvbGetCardEvolvedUse(IBvbGetCardEvolvedUseT _ibvbgetcardevolveduse)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardEvolvedUse,
				Value = _ibvbgetcardevolveduse
			};
		}

		// Token: 0x06014C61 RID: 85089 RVA: 0x00304AAC File Offset: 0x00302CAC
		public IBvbGetCardPosT AsIBvbGetCardPos()
		{
			return this.As<IBvbGetCardPosT>();
		}

		// Token: 0x06014C62 RID: 85090 RVA: 0x00304AB4 File Offset: 0x00302CB4
		public static TSystemVarUnion FromIBvbGetCardPos(IBvbGetCardPosT _ibvbgetcardpos)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardPos,
				Value = _ibvbgetcardpos
			};
		}

		// Token: 0x06014C63 RID: 85091 RVA: 0x00304AC9 File Offset: 0x00302CC9
		public IBvbMaxBoardCardCountT AsIBvbMaxBoardCardCount()
		{
			return this.As<IBvbMaxBoardCardCountT>();
		}

		// Token: 0x06014C64 RID: 85092 RVA: 0x00304AD1 File Offset: 0x00302CD1
		public static TSystemVarUnion FromIBvbMaxBoardCardCount(IBvbMaxBoardCardCountT _ibvbmaxboardcardcount)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbMaxBoardCardCount,
				Value = _ibvbmaxboardcardcount
			};
		}

		// Token: 0x06014C65 RID: 85093 RVA: 0x00304AE7 File Offset: 0x00302CE7
		public IBvbMaxRoundT AsIBvbMaxRound()
		{
			return this.As<IBvbMaxRoundT>();
		}

		// Token: 0x06014C66 RID: 85094 RVA: 0x00304AEF File Offset: 0x00302CEF
		public static TSystemVarUnion FromIBvbMaxRound(IBvbMaxRoundT _ibvbmaxround)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbMaxRound,
				Value = _ibvbmaxround
			};
		}

		// Token: 0x06014C67 RID: 85095 RVA: 0x00304B05 File Offset: 0x00302D05
		public IBvbNpcCardNumT AsIBvbNpcCardNum()
		{
			return this.As<IBvbNpcCardNumT>();
		}

		// Token: 0x06014C68 RID: 85096 RVA: 0x00304B0D File Offset: 0x00302D0D
		public static TSystemVarUnion FromIBvbNpcCardNum(IBvbNpcCardNumT _ibvbnpccardnum)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCardNum,
				Value = _ibvbnpccardnum
			};
		}

		// Token: 0x06014C69 RID: 85097 RVA: 0x00304B23 File Offset: 0x00302D23
		public IBvbNpcCurBoardCardCountT AsIBvbNpcCurBoardCardCount()
		{
			return this.As<IBvbNpcCurBoardCardCountT>();
		}

		// Token: 0x06014C6A RID: 85098 RVA: 0x00304B2B File Offset: 0x00302D2B
		public static TSystemVarUnion FromIBvbNpcCurBoardCardCount(IBvbNpcCurBoardCardCountT _ibvbnpccurboardcardcount)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCurBoardCardCount,
				Value = _ibvbnpccurboardcardcount
			};
		}

		// Token: 0x06014C6B RID: 85099 RVA: 0x00304B41 File Offset: 0x00302D41
		public IBvbNpcCurEnergyT AsIBvbNpcCurEnergy()
		{
			return this.As<IBvbNpcCurEnergyT>();
		}

		// Token: 0x06014C6C RID: 85100 RVA: 0x00304B49 File Offset: 0x00302D49
		public static TSystemVarUnion FromIBvbNpcCurEnergy(IBvbNpcCurEnergyT _ibvbnpccurenergy)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCurEnergy,
				Value = _ibvbnpccurenergy
			};
		}

		// Token: 0x06014C6D RID: 85101 RVA: 0x00304B5F File Offset: 0x00302D5F
		public IBvbNpcHpT AsIBvbNpcHp()
		{
			return this.As<IBvbNpcHpT>();
		}

		// Token: 0x06014C6E RID: 85102 RVA: 0x00304B67 File Offset: 0x00302D67
		public static TSystemVarUnion FromIBvbNpcHp(IBvbNpcHpT _ibvbnpchp)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcHp,
				Value = _ibvbnpchp
			};
		}

		// Token: 0x06014C6F RID: 85103 RVA: 0x00304B7D File Offset: 0x00302D7D
		public IBvbNpcHpValueT AsIBvbNpcHpValue()
		{
			return this.As<IBvbNpcHpValueT>();
		}

		// Token: 0x06014C70 RID: 85104 RVA: 0x00304B85 File Offset: 0x00302D85
		public static TSystemVarUnion FromIBvbNpcHpValue(IBvbNpcHpValueT _ibvbnpchpvalue)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcHpValue,
				Value = _ibvbnpchpvalue
			};
		}

		// Token: 0x06014C71 RID: 85105 RVA: 0x00304B9B File Offset: 0x00302D9B
		public IBvbNpcScoreT AsIBvbNpcScore()
		{
			return this.As<IBvbNpcScoreT>();
		}

		// Token: 0x06014C72 RID: 85106 RVA: 0x00304BA3 File Offset: 0x00302DA3
		public static TSystemVarUnion FromIBvbNpcScore(IBvbNpcScoreT _ibvbnpcscore)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcScore,
				Value = _ibvbnpcscore
			};
		}

		// Token: 0x06014C73 RID: 85107 RVA: 0x00304BB9 File Offset: 0x00302DB9
		public IBvbPlayerHpT AsIBvbPlayerHp()
		{
			return this.As<IBvbPlayerHpT>();
		}

		// Token: 0x06014C74 RID: 85108 RVA: 0x00304BC1 File Offset: 0x00302DC1
		public static TSystemVarUnion FromIBvbPlayerHp(IBvbPlayerHpT _ibvbplayerhp)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerHp,
				Value = _ibvbplayerhp
			};
		}

		// Token: 0x06014C75 RID: 85109 RVA: 0x00304BD7 File Offset: 0x00302DD7
		public IBvbPlayerHpValueT AsIBvbPlayerHpValue()
		{
			return this.As<IBvbPlayerHpValueT>();
		}

		// Token: 0x06014C76 RID: 85110 RVA: 0x00304BDF File Offset: 0x00302DDF
		public static TSystemVarUnion FromIBvbPlayerHpValue(IBvbPlayerHpValueT _ibvbplayerhpvalue)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerHpValue,
				Value = _ibvbplayerhpvalue
			};
		}

		// Token: 0x06014C77 RID: 85111 RVA: 0x00304BF5 File Offset: 0x00302DF5
		public IBvbPlayerScoreT AsIBvbPlayerScore()
		{
			return this.As<IBvbPlayerScoreT>();
		}

		// Token: 0x06014C78 RID: 85112 RVA: 0x00304BFD File Offset: 0x00302DFD
		public static TSystemVarUnion FromIBvbPlayerScore(IBvbPlayerScoreT _ibvbplayerscore)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerScore,
				Value = _ibvbplayerscore
			};
		}

		// Token: 0x06014C79 RID: 85113 RVA: 0x00304C13 File Offset: 0x00302E13
		public IBvbRemainEvolveTimeThisTurnT AsIBvbRemainEvolveTimeThisTurn()
		{
			return this.As<IBvbRemainEvolveTimeThisTurnT>();
		}

		// Token: 0x06014C7A RID: 85114 RVA: 0x00304C1B File Offset: 0x00302E1B
		public static TSystemVarUnion FromIBvbRemainEvolveTimeThisTurn(IBvbRemainEvolveTimeThisTurnT _ibvbremainevolvetimethisturn)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbRemainEvolveTimeThisTurn,
				Value = _ibvbremainevolvetimethisturn
			};
		}

		// Token: 0x06014C7B RID: 85115 RVA: 0x00304C31 File Offset: 0x00302E31
		public ICommonHostToTargetDistanceT AsICommonHostToTargetDistance()
		{
			return this.As<ICommonHostToTargetDistanceT>();
		}

		// Token: 0x06014C7C RID: 85116 RVA: 0x00304C39 File Offset: 0x00302E39
		public static TSystemVarUnion FromICommonHostToTargetDistance(ICommonHostToTargetDistanceT _icommonhosttotargetdistance)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.ICommonHostToTargetDistance,
				Value = _icommonhosttotargetdistance
			};
		}

		// Token: 0x06014C7D RID: 85117 RVA: 0x00304C4F File Offset: 0x00302E4F
		public ICommonHotFixVarT AsICommonHotFixVar()
		{
			return this.As<ICommonHotFixVarT>();
		}

		// Token: 0x06014C7E RID: 85118 RVA: 0x00304C57 File Offset: 0x00302E57
		public static TSystemVarUnion FromICommonHotFixVar(ICommonHotFixVarT _icommonhotfixvar)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.ICommonHotFixVar,
				Value = _icommonhotfixvar
			};
		}

		// Token: 0x06014C7F RID: 85119 RVA: 0x00304C6D File Offset: 0x00302E6D
		public IQuestBranchPageIdT AsIQuestBranchPageId()
		{
			return this.As<IQuestBranchPageIdT>();
		}

		// Token: 0x06014C80 RID: 85120 RVA: 0x00304C75 File Offset: 0x00302E75
		public static TSystemVarUnion FromIQuestBranchPageId(IQuestBranchPageIdT _iquestbranchpageid)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IQuestBranchPageId,
				Value = _iquestbranchpageid
			};
		}

		// Token: 0x06014C81 RID: 85121 RVA: 0x00304C8B File Offset: 0x00302E8B
		public IBvbCustomSystemVarIntT AsIBvbCustomSystemVarInt()
		{
			return this.As<IBvbCustomSystemVarIntT>();
		}

		// Token: 0x06014C82 RID: 85122 RVA: 0x00304C93 File Offset: 0x00302E93
		public static TSystemVarUnion FromIBvbCustomSystemVarInt(IBvbCustomSystemVarIntT _ibvbcustomsystemvarint)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCustomSystemVarInt,
				Value = _ibvbcustomsystemvarint
			};
		}

		// Token: 0x06014C83 RID: 85123 RVA: 0x00304CA9 File Offset: 0x00302EA9
		public IBvbCustomSystemVarFloatT AsIBvbCustomSystemVarFloat()
		{
			return this.As<IBvbCustomSystemVarFloatT>();
		}

		// Token: 0x06014C84 RID: 85124 RVA: 0x00304CB1 File Offset: 0x00302EB1
		public static TSystemVarUnion FromIBvbCustomSystemVarFloat(IBvbCustomSystemVarFloatT _ibvbcustomsystemvarfloat)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCustomSystemVarFloat,
				Value = _ibvbcustomsystemvarfloat
			};
		}

		// Token: 0x06014C85 RID: 85125 RVA: 0x00304CC8 File Offset: 0x00302EC8
		public static int Pack(FlatBufferBuilder builder, TSystemVarUnion _o)
		{
			switch (_o.Type)
			{
			case TSystemVar.IBvbAdjustPosPreference:
				return IBvbAdjustPosPreference.Pack(builder, _o.AsIBvbAdjustPosPreference()).Value;
			case TSystemVar.IBvbCurRound:
				return IBvbCurRound.Pack(builder, _o.AsIBvbCurRound()).Value;
			case TSystemVar.IBvbDungeonStage:
				return IBvbDungeonStage.Pack(builder, _o.AsIBvbDungeonStage()).Value;
			case TSystemVar.IBvbFetchHandCard:
				return IBvbFetchHandCard.Pack(builder, _o.AsIBvbFetchHandCard()).Value;
			case TSystemVar.IBvbGetBoardCard:
				return IBvbGetBoardCard.Pack(builder, _o.AsIBvbGetBoardCard()).Value;
			case TSystemVar.IBvbGetCardChangeUse:
				return IBvbGetCardChangeUse.Pack(builder, _o.AsIBvbGetCardChangeUse()).Value;
			case TSystemVar.IBvbGetCardEvolvedUse:
				return IBvbGetCardEvolvedUse.Pack(builder, _o.AsIBvbGetCardEvolvedUse()).Value;
			case TSystemVar.IBvbGetCardPos:
				return IBvbGetCardPos.Pack(builder, _o.AsIBvbGetCardPos()).Value;
			case TSystemVar.IBvbMaxBoardCardCount:
				return IBvbMaxBoardCardCount.Pack(builder, _o.AsIBvbMaxBoardCardCount()).Value;
			case TSystemVar.IBvbMaxRound:
				return IBvbMaxRound.Pack(builder, _o.AsIBvbMaxRound()).Value;
			case TSystemVar.IBvbNpcCardNum:
				return IBvbNpcCardNum.Pack(builder, _o.AsIBvbNpcCardNum()).Value;
			case TSystemVar.IBvbNpcCurBoardCardCount:
				return IBvbNpcCurBoardCardCount.Pack(builder, _o.AsIBvbNpcCurBoardCardCount()).Value;
			case TSystemVar.IBvbNpcCurEnergy:
				return IBvbNpcCurEnergy.Pack(builder, _o.AsIBvbNpcCurEnergy()).Value;
			case TSystemVar.IBvbNpcHp:
				return IBvbNpcHp.Pack(builder, _o.AsIBvbNpcHp()).Value;
			case TSystemVar.IBvbNpcHpValue:
				return IBvbNpcHpValue.Pack(builder, _o.AsIBvbNpcHpValue()).Value;
			case TSystemVar.IBvbNpcScore:
				return IBvbNpcScore.Pack(builder, _o.AsIBvbNpcScore()).Value;
			case TSystemVar.IBvbPlayerHp:
				return IBvbPlayerHp.Pack(builder, _o.AsIBvbPlayerHp()).Value;
			case TSystemVar.IBvbPlayerHpValue:
				return IBvbPlayerHpValue.Pack(builder, _o.AsIBvbPlayerHpValue()).Value;
			case TSystemVar.IBvbPlayerScore:
				return IBvbPlayerScore.Pack(builder, _o.AsIBvbPlayerScore()).Value;
			case TSystemVar.IBvbRemainEvolveTimeThisTurn:
				return IBvbRemainEvolveTimeThisTurn.Pack(builder, _o.AsIBvbRemainEvolveTimeThisTurn()).Value;
			case TSystemVar.ICommonHostToTargetDistance:
				return ICommonHostToTargetDistance.Pack(builder, _o.AsICommonHostToTargetDistance()).Value;
			case TSystemVar.ICommonHotFixVar:
				return ICommonHotFixVar.Pack(builder, _o.AsICommonHotFixVar()).Value;
			case TSystemVar.IQuestBranchPageId:
				return IQuestBranchPageId.Pack(builder, _o.AsIQuestBranchPageId()).Value;
			case TSystemVar.IBvbCustomSystemVarInt:
				return IBvbCustomSystemVarInt.Pack(builder, _o.AsIBvbCustomSystemVarInt()).Value;
			case TSystemVar.IBvbCustomSystemVarFloat:
				return IBvbCustomSystemVarFloat.Pack(builder, _o.AsIBvbCustomSystemVarFloat()).Value;
			default:
				return 0;
			}
		}
	}
}
