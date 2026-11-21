using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F5F RID: 16223
	public class TSystemVarUnion
	{
		// Token: 0x17006DC3 RID: 28099
		// (get) Token: 0x06016117 RID: 90391 RVA: 0x0032AF2F File Offset: 0x0032912F
		// (set) Token: 0x06016118 RID: 90392 RVA: 0x0032AF37 File Offset: 0x00329137
		public TSystemVar Type { get; set; }

		// Token: 0x17006DC4 RID: 28100
		// (get) Token: 0x06016119 RID: 90393 RVA: 0x0032AF40 File Offset: 0x00329140
		// (set) Token: 0x0601611A RID: 90394 RVA: 0x0032AF48 File Offset: 0x00329148
		public object Value { get; set; }

		// Token: 0x0601611B RID: 90395 RVA: 0x0032AF51 File Offset: 0x00329151
		public TSystemVarUnion()
		{
			this.Type = TSystemVar.NONE;
			this.Value = null;
		}

		// Token: 0x0601611C RID: 90396 RVA: 0x0032AF67 File Offset: 0x00329167
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601611D RID: 90397 RVA: 0x0032AF79 File Offset: 0x00329179
		public IBvbAdjustPosPreferenceT AsIBvbAdjustPosPreference()
		{
			return this.As<IBvbAdjustPosPreferenceT>();
		}

		// Token: 0x0601611E RID: 90398 RVA: 0x0032AF81 File Offset: 0x00329181
		public static TSystemVarUnion FromIBvbAdjustPosPreference(IBvbAdjustPosPreferenceT _ibvbadjustpospreference)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbAdjustPosPreference,
				Value = _ibvbadjustpospreference
			};
		}

		// Token: 0x0601611F RID: 90399 RVA: 0x0032AF96 File Offset: 0x00329196
		public IBvbCurRoundT AsIBvbCurRound()
		{
			return this.As<IBvbCurRoundT>();
		}

		// Token: 0x06016120 RID: 90400 RVA: 0x0032AF9E File Offset: 0x0032919E
		public static TSystemVarUnion FromIBvbCurRound(IBvbCurRoundT _ibvbcurround)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCurRound,
				Value = _ibvbcurround
			};
		}

		// Token: 0x06016121 RID: 90401 RVA: 0x0032AFB3 File Offset: 0x003291B3
		public IBvbDungeonStageT AsIBvbDungeonStage()
		{
			return this.As<IBvbDungeonStageT>();
		}

		// Token: 0x06016122 RID: 90402 RVA: 0x0032AFBB File Offset: 0x003291BB
		public static TSystemVarUnion FromIBvbDungeonStage(IBvbDungeonStageT _ibvbdungeonstage)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbDungeonStage,
				Value = _ibvbdungeonstage
			};
		}

		// Token: 0x06016123 RID: 90403 RVA: 0x0032AFD0 File Offset: 0x003291D0
		public IBvbFetchHandCardT AsIBvbFetchHandCard()
		{
			return this.As<IBvbFetchHandCardT>();
		}

		// Token: 0x06016124 RID: 90404 RVA: 0x0032AFD8 File Offset: 0x003291D8
		public static TSystemVarUnion FromIBvbFetchHandCard(IBvbFetchHandCardT _ibvbfetchhandcard)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbFetchHandCard,
				Value = _ibvbfetchhandcard
			};
		}

		// Token: 0x06016125 RID: 90405 RVA: 0x0032AFED File Offset: 0x003291ED
		public IBvbGetBoardCardT AsIBvbGetBoardCard()
		{
			return this.As<IBvbGetBoardCardT>();
		}

		// Token: 0x06016126 RID: 90406 RVA: 0x0032AFF5 File Offset: 0x003291F5
		public static TSystemVarUnion FromIBvbGetBoardCard(IBvbGetBoardCardT _ibvbgetboardcard)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetBoardCard,
				Value = _ibvbgetboardcard
			};
		}

		// Token: 0x06016127 RID: 90407 RVA: 0x0032B00A File Offset: 0x0032920A
		public IBvbGetCardChangeUseT AsIBvbGetCardChangeUse()
		{
			return this.As<IBvbGetCardChangeUseT>();
		}

		// Token: 0x06016128 RID: 90408 RVA: 0x0032B012 File Offset: 0x00329212
		public static TSystemVarUnion FromIBvbGetCardChangeUse(IBvbGetCardChangeUseT _ibvbgetcardchangeuse)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardChangeUse,
				Value = _ibvbgetcardchangeuse
			};
		}

		// Token: 0x06016129 RID: 90409 RVA: 0x0032B027 File Offset: 0x00329227
		public IBvbGetCardEvolvedUseT AsIBvbGetCardEvolvedUse()
		{
			return this.As<IBvbGetCardEvolvedUseT>();
		}

		// Token: 0x0601612A RID: 90410 RVA: 0x0032B02F File Offset: 0x0032922F
		public static TSystemVarUnion FromIBvbGetCardEvolvedUse(IBvbGetCardEvolvedUseT _ibvbgetcardevolveduse)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardEvolvedUse,
				Value = _ibvbgetcardevolveduse
			};
		}

		// Token: 0x0601612B RID: 90411 RVA: 0x0032B044 File Offset: 0x00329244
		public IBvbGetCardPosT AsIBvbGetCardPos()
		{
			return this.As<IBvbGetCardPosT>();
		}

		// Token: 0x0601612C RID: 90412 RVA: 0x0032B04C File Offset: 0x0032924C
		public static TSystemVarUnion FromIBvbGetCardPos(IBvbGetCardPosT _ibvbgetcardpos)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbGetCardPos,
				Value = _ibvbgetcardpos
			};
		}

		// Token: 0x0601612D RID: 90413 RVA: 0x0032B061 File Offset: 0x00329261
		public IBvbMaxBoardCardCountT AsIBvbMaxBoardCardCount()
		{
			return this.As<IBvbMaxBoardCardCountT>();
		}

		// Token: 0x0601612E RID: 90414 RVA: 0x0032B069 File Offset: 0x00329269
		public static TSystemVarUnion FromIBvbMaxBoardCardCount(IBvbMaxBoardCardCountT _ibvbmaxboardcardcount)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbMaxBoardCardCount,
				Value = _ibvbmaxboardcardcount
			};
		}

		// Token: 0x0601612F RID: 90415 RVA: 0x0032B07F File Offset: 0x0032927F
		public IBvbMaxRoundT AsIBvbMaxRound()
		{
			return this.As<IBvbMaxRoundT>();
		}

		// Token: 0x06016130 RID: 90416 RVA: 0x0032B087 File Offset: 0x00329287
		public static TSystemVarUnion FromIBvbMaxRound(IBvbMaxRoundT _ibvbmaxround)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbMaxRound,
				Value = _ibvbmaxround
			};
		}

		// Token: 0x06016131 RID: 90417 RVA: 0x0032B09D File Offset: 0x0032929D
		public IBvbNpcCardNumT AsIBvbNpcCardNum()
		{
			return this.As<IBvbNpcCardNumT>();
		}

		// Token: 0x06016132 RID: 90418 RVA: 0x0032B0A5 File Offset: 0x003292A5
		public static TSystemVarUnion FromIBvbNpcCardNum(IBvbNpcCardNumT _ibvbnpccardnum)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCardNum,
				Value = _ibvbnpccardnum
			};
		}

		// Token: 0x06016133 RID: 90419 RVA: 0x0032B0BB File Offset: 0x003292BB
		public IBvbNpcCurBoardCardCountT AsIBvbNpcCurBoardCardCount()
		{
			return this.As<IBvbNpcCurBoardCardCountT>();
		}

		// Token: 0x06016134 RID: 90420 RVA: 0x0032B0C3 File Offset: 0x003292C3
		public static TSystemVarUnion FromIBvbNpcCurBoardCardCount(IBvbNpcCurBoardCardCountT _ibvbnpccurboardcardcount)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCurBoardCardCount,
				Value = _ibvbnpccurboardcardcount
			};
		}

		// Token: 0x06016135 RID: 90421 RVA: 0x0032B0D9 File Offset: 0x003292D9
		public IBvbNpcCurEnergyT AsIBvbNpcCurEnergy()
		{
			return this.As<IBvbNpcCurEnergyT>();
		}

		// Token: 0x06016136 RID: 90422 RVA: 0x0032B0E1 File Offset: 0x003292E1
		public static TSystemVarUnion FromIBvbNpcCurEnergy(IBvbNpcCurEnergyT _ibvbnpccurenergy)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcCurEnergy,
				Value = _ibvbnpccurenergy
			};
		}

		// Token: 0x06016137 RID: 90423 RVA: 0x0032B0F7 File Offset: 0x003292F7
		public IBvbNpcHpT AsIBvbNpcHp()
		{
			return this.As<IBvbNpcHpT>();
		}

		// Token: 0x06016138 RID: 90424 RVA: 0x0032B0FF File Offset: 0x003292FF
		public static TSystemVarUnion FromIBvbNpcHp(IBvbNpcHpT _ibvbnpchp)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcHp,
				Value = _ibvbnpchp
			};
		}

		// Token: 0x06016139 RID: 90425 RVA: 0x0032B115 File Offset: 0x00329315
		public IBvbNpcHpValueT AsIBvbNpcHpValue()
		{
			return this.As<IBvbNpcHpValueT>();
		}

		// Token: 0x0601613A RID: 90426 RVA: 0x0032B11D File Offset: 0x0032931D
		public static TSystemVarUnion FromIBvbNpcHpValue(IBvbNpcHpValueT _ibvbnpchpvalue)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcHpValue,
				Value = _ibvbnpchpvalue
			};
		}

		// Token: 0x0601613B RID: 90427 RVA: 0x0032B133 File Offset: 0x00329333
		public IBvbNpcScoreT AsIBvbNpcScore()
		{
			return this.As<IBvbNpcScoreT>();
		}

		// Token: 0x0601613C RID: 90428 RVA: 0x0032B13B File Offset: 0x0032933B
		public static TSystemVarUnion FromIBvbNpcScore(IBvbNpcScoreT _ibvbnpcscore)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbNpcScore,
				Value = _ibvbnpcscore
			};
		}

		// Token: 0x0601613D RID: 90429 RVA: 0x0032B151 File Offset: 0x00329351
		public IBvbPlayerHpT AsIBvbPlayerHp()
		{
			return this.As<IBvbPlayerHpT>();
		}

		// Token: 0x0601613E RID: 90430 RVA: 0x0032B159 File Offset: 0x00329359
		public static TSystemVarUnion FromIBvbPlayerHp(IBvbPlayerHpT _ibvbplayerhp)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerHp,
				Value = _ibvbplayerhp
			};
		}

		// Token: 0x0601613F RID: 90431 RVA: 0x0032B16F File Offset: 0x0032936F
		public IBvbPlayerHpValueT AsIBvbPlayerHpValue()
		{
			return this.As<IBvbPlayerHpValueT>();
		}

		// Token: 0x06016140 RID: 90432 RVA: 0x0032B177 File Offset: 0x00329377
		public static TSystemVarUnion FromIBvbPlayerHpValue(IBvbPlayerHpValueT _ibvbplayerhpvalue)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerHpValue,
				Value = _ibvbplayerhpvalue
			};
		}

		// Token: 0x06016141 RID: 90433 RVA: 0x0032B18D File Offset: 0x0032938D
		public IBvbPlayerScoreT AsIBvbPlayerScore()
		{
			return this.As<IBvbPlayerScoreT>();
		}

		// Token: 0x06016142 RID: 90434 RVA: 0x0032B195 File Offset: 0x00329395
		public static TSystemVarUnion FromIBvbPlayerScore(IBvbPlayerScoreT _ibvbplayerscore)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbPlayerScore,
				Value = _ibvbplayerscore
			};
		}

		// Token: 0x06016143 RID: 90435 RVA: 0x0032B1AB File Offset: 0x003293AB
		public IBvbRemainEvolveTimeThisTurnT AsIBvbRemainEvolveTimeThisTurn()
		{
			return this.As<IBvbRemainEvolveTimeThisTurnT>();
		}

		// Token: 0x06016144 RID: 90436 RVA: 0x0032B1B3 File Offset: 0x003293B3
		public static TSystemVarUnion FromIBvbRemainEvolveTimeThisTurn(IBvbRemainEvolveTimeThisTurnT _ibvbremainevolvetimethisturn)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbRemainEvolveTimeThisTurn,
				Value = _ibvbremainevolvetimethisturn
			};
		}

		// Token: 0x06016145 RID: 90437 RVA: 0x0032B1C9 File Offset: 0x003293C9
		public ICommonHostToTargetDistanceT AsICommonHostToTargetDistance()
		{
			return this.As<ICommonHostToTargetDistanceT>();
		}

		// Token: 0x06016146 RID: 90438 RVA: 0x0032B1D1 File Offset: 0x003293D1
		public static TSystemVarUnion FromICommonHostToTargetDistance(ICommonHostToTargetDistanceT _icommonhosttotargetdistance)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.ICommonHostToTargetDistance,
				Value = _icommonhosttotargetdistance
			};
		}

		// Token: 0x06016147 RID: 90439 RVA: 0x0032B1E7 File Offset: 0x003293E7
		public ICommonHotFixVarT AsICommonHotFixVar()
		{
			return this.As<ICommonHotFixVarT>();
		}

		// Token: 0x06016148 RID: 90440 RVA: 0x0032B1EF File Offset: 0x003293EF
		public static TSystemVarUnion FromICommonHotFixVar(ICommonHotFixVarT _icommonhotfixvar)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.ICommonHotFixVar,
				Value = _icommonhotfixvar
			};
		}

		// Token: 0x06016149 RID: 90441 RVA: 0x0032B205 File Offset: 0x00329405
		public IQuestBranchPageIdT AsIQuestBranchPageId()
		{
			return this.As<IQuestBranchPageIdT>();
		}

		// Token: 0x0601614A RID: 90442 RVA: 0x0032B20D File Offset: 0x0032940D
		public static TSystemVarUnion FromIQuestBranchPageId(IQuestBranchPageIdT _iquestbranchpageid)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IQuestBranchPageId,
				Value = _iquestbranchpageid
			};
		}

		// Token: 0x0601614B RID: 90443 RVA: 0x0032B223 File Offset: 0x00329423
		public IBvbCustomSystemVarIntT AsIBvbCustomSystemVarInt()
		{
			return this.As<IBvbCustomSystemVarIntT>();
		}

		// Token: 0x0601614C RID: 90444 RVA: 0x0032B22B File Offset: 0x0032942B
		public static TSystemVarUnion FromIBvbCustomSystemVarInt(IBvbCustomSystemVarIntT _ibvbcustomsystemvarint)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCustomSystemVarInt,
				Value = _ibvbcustomsystemvarint
			};
		}

		// Token: 0x0601614D RID: 90445 RVA: 0x0032B241 File Offset: 0x00329441
		public IBvbCustomSystemVarFloatT AsIBvbCustomSystemVarFloat()
		{
			return this.As<IBvbCustomSystemVarFloatT>();
		}

		// Token: 0x0601614E RID: 90446 RVA: 0x0032B249 File Offset: 0x00329449
		public static TSystemVarUnion FromIBvbCustomSystemVarFloat(IBvbCustomSystemVarFloatT _ibvbcustomsystemvarfloat)
		{
			return new TSystemVarUnion
			{
				Type = TSystemVar.IBvbCustomSystemVarFloat,
				Value = _ibvbcustomsystemvarfloat
			};
		}

		// Token: 0x0601614F RID: 90447 RVA: 0x0032B260 File Offset: 0x00329460
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
