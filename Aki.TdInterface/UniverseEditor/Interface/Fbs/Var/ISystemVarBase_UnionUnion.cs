using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003ED8 RID: 16088
	public class ISystemVarBase_UnionUnion
	{
		// Token: 0x17006CEA RID: 27882
		// (get) Token: 0x06015C81 RID: 89217 RVA: 0x003222E9 File Offset: 0x003204E9
		// (set) Token: 0x06015C82 RID: 89218 RVA: 0x003222F1 File Offset: 0x003204F1
		public ISystemVarBase_Union Type { get; set; }

		// Token: 0x17006CEB RID: 27883
		// (get) Token: 0x06015C83 RID: 89219 RVA: 0x003222FA File Offset: 0x003204FA
		// (set) Token: 0x06015C84 RID: 89220 RVA: 0x00322302 File Offset: 0x00320502
		public object Value { get; set; }

		// Token: 0x06015C85 RID: 89221 RVA: 0x0032230B File Offset: 0x0032050B
		public ISystemVarBase_UnionUnion()
		{
			this.Type = ISystemVarBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015C86 RID: 89222 RVA: 0x00322321 File Offset: 0x00320521
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015C87 RID: 89223 RVA: 0x00322333 File Offset: 0x00320533
		public ISystemVarBaseT AsISystemVarBase()
		{
			return this.As<ISystemVarBaseT>();
		}

		// Token: 0x06015C88 RID: 89224 RVA: 0x0032233B File Offset: 0x0032053B
		public static ISystemVarBase_UnionUnion FromISystemVarBase(ISystemVarBaseT _isystemvarbase)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ISystemVarBase,
				Value = _isystemvarbase
			};
		}

		// Token: 0x06015C89 RID: 89225 RVA: 0x00322350 File Offset: 0x00320550
		public IBvbFetchHandCardT AsIBvbFetchHandCard()
		{
			return this.As<IBvbFetchHandCardT>();
		}

		// Token: 0x06015C8A RID: 89226 RVA: 0x00322358 File Offset: 0x00320558
		public static ISystemVarBase_UnionUnion FromIBvbFetchHandCard(IBvbFetchHandCardT _ibvbfetchhandcard)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbFetchHandCard,
				Value = _ibvbfetchhandcard
			};
		}

		// Token: 0x06015C8B RID: 89227 RVA: 0x0032236D File Offset: 0x0032056D
		public IBvbGetBoardCardT AsIBvbGetBoardCard()
		{
			return this.As<IBvbGetBoardCardT>();
		}

		// Token: 0x06015C8C RID: 89228 RVA: 0x00322375 File Offset: 0x00320575
		public static ISystemVarBase_UnionUnion FromIBvbGetBoardCard(IBvbGetBoardCardT _ibvbgetboardcard)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetBoardCard,
				Value = _ibvbgetboardcard
			};
		}

		// Token: 0x06015C8D RID: 89229 RVA: 0x0032238A File Offset: 0x0032058A
		public IBvbGetCardPosT AsIBvbGetCardPos()
		{
			return this.As<IBvbGetCardPosT>();
		}

		// Token: 0x06015C8E RID: 89230 RVA: 0x00322392 File Offset: 0x00320592
		public static ISystemVarBase_UnionUnion FromIBvbGetCardPos(IBvbGetCardPosT _ibvbgetcardpos)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardPos,
				Value = _ibvbgetcardpos
			};
		}

		// Token: 0x06015C8F RID: 89231 RVA: 0x003223A7 File Offset: 0x003205A7
		public IBvbGetCardChangeUseT AsIBvbGetCardChangeUse()
		{
			return this.As<IBvbGetCardChangeUseT>();
		}

		// Token: 0x06015C90 RID: 89232 RVA: 0x003223AF File Offset: 0x003205AF
		public static ISystemVarBase_UnionUnion FromIBvbGetCardChangeUse(IBvbGetCardChangeUseT _ibvbgetcardchangeuse)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardChangeUse,
				Value = _ibvbgetcardchangeuse
			};
		}

		// Token: 0x06015C91 RID: 89233 RVA: 0x003223C4 File Offset: 0x003205C4
		public IBvbGetCardEvolvedUseT AsIBvbGetCardEvolvedUse()
		{
			return this.As<IBvbGetCardEvolvedUseT>();
		}

		// Token: 0x06015C92 RID: 89234 RVA: 0x003223CC File Offset: 0x003205CC
		public static ISystemVarBase_UnionUnion FromIBvbGetCardEvolvedUse(IBvbGetCardEvolvedUseT _ibvbgetcardevolveduse)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardEvolvedUse,
				Value = _ibvbgetcardevolveduse
			};
		}

		// Token: 0x06015C93 RID: 89235 RVA: 0x003223E1 File Offset: 0x003205E1
		public IBvbAdjustPosPreferenceT AsIBvbAdjustPosPreference()
		{
			return this.As<IBvbAdjustPosPreferenceT>();
		}

		// Token: 0x06015C94 RID: 89236 RVA: 0x003223E9 File Offset: 0x003205E9
		public static ISystemVarBase_UnionUnion FromIBvbAdjustPosPreference(IBvbAdjustPosPreferenceT _ibvbadjustpospreference)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbAdjustPosPreference,
				Value = _ibvbadjustpospreference
			};
		}

		// Token: 0x06015C95 RID: 89237 RVA: 0x003223FE File Offset: 0x003205FE
		public IBvbCurRoundT AsIBvbCurRound()
		{
			return this.As<IBvbCurRoundT>();
		}

		// Token: 0x06015C96 RID: 89238 RVA: 0x00322406 File Offset: 0x00320606
		public static ISystemVarBase_UnionUnion FromIBvbCurRound(IBvbCurRoundT _ibvbcurround)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCurRound,
				Value = _ibvbcurround
			};
		}

		// Token: 0x06015C97 RID: 89239 RVA: 0x0032241B File Offset: 0x0032061B
		public IBvbRemainEvolveTimeThisTurnT AsIBvbRemainEvolveTimeThisTurn()
		{
			return this.As<IBvbRemainEvolveTimeThisTurnT>();
		}

		// Token: 0x06015C98 RID: 89240 RVA: 0x00322423 File Offset: 0x00320623
		public static ISystemVarBase_UnionUnion FromIBvbRemainEvolveTimeThisTurn(IBvbRemainEvolveTimeThisTurnT _ibvbremainevolvetimethisturn)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbRemainEvolveTimeThisTurn,
				Value = _ibvbremainevolvetimethisturn
			};
		}

		// Token: 0x06015C99 RID: 89241 RVA: 0x00322439 File Offset: 0x00320639
		public IBvbMaxRoundT AsIBvbMaxRound()
		{
			return this.As<IBvbMaxRoundT>();
		}

		// Token: 0x06015C9A RID: 89242 RVA: 0x00322441 File Offset: 0x00320641
		public static ISystemVarBase_UnionUnion FromIBvbMaxRound(IBvbMaxRoundT _ibvbmaxround)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbMaxRound,
				Value = _ibvbmaxround
			};
		}

		// Token: 0x06015C9B RID: 89243 RVA: 0x00322457 File Offset: 0x00320657
		public IBvbNpcCardNumT AsIBvbNpcCardNum()
		{
			return this.As<IBvbNpcCardNumT>();
		}

		// Token: 0x06015C9C RID: 89244 RVA: 0x0032245F File Offset: 0x0032065F
		public static ISystemVarBase_UnionUnion FromIBvbNpcCardNum(IBvbNpcCardNumT _ibvbnpccardnum)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCardNum,
				Value = _ibvbnpccardnum
			};
		}

		// Token: 0x06015C9D RID: 89245 RVA: 0x00322475 File Offset: 0x00320675
		public IBvbNpcCurEnergyT AsIBvbNpcCurEnergy()
		{
			return this.As<IBvbNpcCurEnergyT>();
		}

		// Token: 0x06015C9E RID: 89246 RVA: 0x0032247D File Offset: 0x0032067D
		public static ISystemVarBase_UnionUnion FromIBvbNpcCurEnergy(IBvbNpcCurEnergyT _ibvbnpccurenergy)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCurEnergy,
				Value = _ibvbnpccurenergy
			};
		}

		// Token: 0x06015C9F RID: 89247 RVA: 0x00322493 File Offset: 0x00320693
		public IBvbNpcScoreT AsIBvbNpcScore()
		{
			return this.As<IBvbNpcScoreT>();
		}

		// Token: 0x06015CA0 RID: 89248 RVA: 0x0032249B File Offset: 0x0032069B
		public static ISystemVarBase_UnionUnion FromIBvbNpcScore(IBvbNpcScoreT _ibvbnpcscore)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcScore,
				Value = _ibvbnpcscore
			};
		}

		// Token: 0x06015CA1 RID: 89249 RVA: 0x003224B1 File Offset: 0x003206B1
		public IBvbPlayerScoreT AsIBvbPlayerScore()
		{
			return this.As<IBvbPlayerScoreT>();
		}

		// Token: 0x06015CA2 RID: 89250 RVA: 0x003224B9 File Offset: 0x003206B9
		public static ISystemVarBase_UnionUnion FromIBvbPlayerScore(IBvbPlayerScoreT _ibvbplayerscore)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerScore,
				Value = _ibvbplayerscore
			};
		}

		// Token: 0x06015CA3 RID: 89251 RVA: 0x003224CF File Offset: 0x003206CF
		public IBvbPlayerHpT AsIBvbPlayerHp()
		{
			return this.As<IBvbPlayerHpT>();
		}

		// Token: 0x06015CA4 RID: 89252 RVA: 0x003224D7 File Offset: 0x003206D7
		public static ISystemVarBase_UnionUnion FromIBvbPlayerHp(IBvbPlayerHpT _ibvbplayerhp)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerHp,
				Value = _ibvbplayerhp
			};
		}

		// Token: 0x06015CA5 RID: 89253 RVA: 0x003224ED File Offset: 0x003206ED
		public IBvbNpcHpT AsIBvbNpcHp()
		{
			return this.As<IBvbNpcHpT>();
		}

		// Token: 0x06015CA6 RID: 89254 RVA: 0x003224F5 File Offset: 0x003206F5
		public static ISystemVarBase_UnionUnion FromIBvbNpcHp(IBvbNpcHpT _ibvbnpchp)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcHp,
				Value = _ibvbnpchp
			};
		}

		// Token: 0x06015CA7 RID: 89255 RVA: 0x0032250B File Offset: 0x0032070B
		public IBvbPlayerHpValueT AsIBvbPlayerHpValue()
		{
			return this.As<IBvbPlayerHpValueT>();
		}

		// Token: 0x06015CA8 RID: 89256 RVA: 0x00322513 File Offset: 0x00320713
		public static ISystemVarBase_UnionUnion FromIBvbPlayerHpValue(IBvbPlayerHpValueT _ibvbplayerhpvalue)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerHpValue,
				Value = _ibvbplayerhpvalue
			};
		}

		// Token: 0x06015CA9 RID: 89257 RVA: 0x00322529 File Offset: 0x00320729
		public IBvbNpcHpValueT AsIBvbNpcHpValue()
		{
			return this.As<IBvbNpcHpValueT>();
		}

		// Token: 0x06015CAA RID: 89258 RVA: 0x00322531 File Offset: 0x00320731
		public static ISystemVarBase_UnionUnion FromIBvbNpcHpValue(IBvbNpcHpValueT _ibvbnpchpvalue)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcHpValue,
				Value = _ibvbnpchpvalue
			};
		}

		// Token: 0x06015CAB RID: 89259 RVA: 0x00322547 File Offset: 0x00320747
		public IBvbNpcCurBoardCardCountT AsIBvbNpcCurBoardCardCount()
		{
			return this.As<IBvbNpcCurBoardCardCountT>();
		}

		// Token: 0x06015CAC RID: 89260 RVA: 0x0032254F File Offset: 0x0032074F
		public static ISystemVarBase_UnionUnion FromIBvbNpcCurBoardCardCount(IBvbNpcCurBoardCardCountT _ibvbnpccurboardcardcount)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCurBoardCardCount,
				Value = _ibvbnpccurboardcardcount
			};
		}

		// Token: 0x06015CAD RID: 89261 RVA: 0x00322565 File Offset: 0x00320765
		public IBvbMaxBoardCardCountT AsIBvbMaxBoardCardCount()
		{
			return this.As<IBvbMaxBoardCardCountT>();
		}

		// Token: 0x06015CAE RID: 89262 RVA: 0x0032256D File Offset: 0x0032076D
		public static ISystemVarBase_UnionUnion FromIBvbMaxBoardCardCount(IBvbMaxBoardCardCountT _ibvbmaxboardcardcount)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbMaxBoardCardCount,
				Value = _ibvbmaxboardcardcount
			};
		}

		// Token: 0x06015CAF RID: 89263 RVA: 0x00322583 File Offset: 0x00320783
		public IBvbDungeonStageT AsIBvbDungeonStage()
		{
			return this.As<IBvbDungeonStageT>();
		}

		// Token: 0x06015CB0 RID: 89264 RVA: 0x0032258B File Offset: 0x0032078B
		public static ISystemVarBase_UnionUnion FromIBvbDungeonStage(IBvbDungeonStageT _ibvbdungeonstage)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbDungeonStage,
				Value = _ibvbdungeonstage
			};
		}

		// Token: 0x06015CB1 RID: 89265 RVA: 0x003225A1 File Offset: 0x003207A1
		public IBvbCustomSystemVarIntT AsIBvbCustomSystemVarInt()
		{
			return this.As<IBvbCustomSystemVarIntT>();
		}

		// Token: 0x06015CB2 RID: 89266 RVA: 0x003225A9 File Offset: 0x003207A9
		public static ISystemVarBase_UnionUnion FromIBvbCustomSystemVarInt(IBvbCustomSystemVarIntT _ibvbcustomsystemvarint)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCustomSystemVarInt,
				Value = _ibvbcustomsystemvarint
			};
		}

		// Token: 0x06015CB3 RID: 89267 RVA: 0x003225BF File Offset: 0x003207BF
		public IBvbCustomSystemVarFloatT AsIBvbCustomSystemVarFloat()
		{
			return this.As<IBvbCustomSystemVarFloatT>();
		}

		// Token: 0x06015CB4 RID: 89268 RVA: 0x003225C7 File Offset: 0x003207C7
		public static ISystemVarBase_UnionUnion FromIBvbCustomSystemVarFloat(IBvbCustomSystemVarFloatT _ibvbcustomsystemvarfloat)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCustomSystemVarFloat,
				Value = _ibvbcustomsystemvarfloat
			};
		}

		// Token: 0x06015CB5 RID: 89269 RVA: 0x003225DD File Offset: 0x003207DD
		public IQuestBranchPageIdT AsIQuestBranchPageId()
		{
			return this.As<IQuestBranchPageIdT>();
		}

		// Token: 0x06015CB6 RID: 89270 RVA: 0x003225E5 File Offset: 0x003207E5
		public static ISystemVarBase_UnionUnion FromIQuestBranchPageId(IQuestBranchPageIdT _iquestbranchpageid)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IQuestBranchPageId,
				Value = _iquestbranchpageid
			};
		}

		// Token: 0x06015CB7 RID: 89271 RVA: 0x003225FB File Offset: 0x003207FB
		public ICommonHotFixVarT AsICommonHotFixVar()
		{
			return this.As<ICommonHotFixVarT>();
		}

		// Token: 0x06015CB8 RID: 89272 RVA: 0x00322603 File Offset: 0x00320803
		public static ISystemVarBase_UnionUnion FromICommonHotFixVar(ICommonHotFixVarT _icommonhotfixvar)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ICommonHotFixVar,
				Value = _icommonhotfixvar
			};
		}

		// Token: 0x06015CB9 RID: 89273 RVA: 0x00322619 File Offset: 0x00320819
		public ICommonHostToTargetDistanceT AsICommonHostToTargetDistance()
		{
			return this.As<ICommonHostToTargetDistanceT>();
		}

		// Token: 0x06015CBA RID: 89274 RVA: 0x00322621 File Offset: 0x00320821
		public static ISystemVarBase_UnionUnion FromICommonHostToTargetDistance(ICommonHostToTargetDistanceT _icommonhosttotargetdistance)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ICommonHostToTargetDistance,
				Value = _icommonhosttotargetdistance
			};
		}

		// Token: 0x06015CBB RID: 89275 RVA: 0x00322638 File Offset: 0x00320838
		public static int Pack(FlatBufferBuilder builder, ISystemVarBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISystemVarBase_Union.ISystemVarBase:
				return ISystemVarBase.Pack(builder, _o.AsISystemVarBase()).Value;
			case ISystemVarBase_Union.IBvbFetchHandCard:
				return IBvbFetchHandCard.Pack(builder, _o.AsIBvbFetchHandCard()).Value;
			case ISystemVarBase_Union.IBvbGetBoardCard:
				return IBvbGetBoardCard.Pack(builder, _o.AsIBvbGetBoardCard()).Value;
			case ISystemVarBase_Union.IBvbGetCardPos:
				return IBvbGetCardPos.Pack(builder, _o.AsIBvbGetCardPos()).Value;
			case ISystemVarBase_Union.IBvbGetCardChangeUse:
				return IBvbGetCardChangeUse.Pack(builder, _o.AsIBvbGetCardChangeUse()).Value;
			case ISystemVarBase_Union.IBvbGetCardEvolvedUse:
				return IBvbGetCardEvolvedUse.Pack(builder, _o.AsIBvbGetCardEvolvedUse()).Value;
			case ISystemVarBase_Union.IBvbAdjustPosPreference:
				return IBvbAdjustPosPreference.Pack(builder, _o.AsIBvbAdjustPosPreference()).Value;
			case ISystemVarBase_Union.IBvbCurRound:
				return IBvbCurRound.Pack(builder, _o.AsIBvbCurRound()).Value;
			case ISystemVarBase_Union.IBvbRemainEvolveTimeThisTurn:
				return IBvbRemainEvolveTimeThisTurn.Pack(builder, _o.AsIBvbRemainEvolveTimeThisTurn()).Value;
			case ISystemVarBase_Union.IBvbMaxRound:
				return IBvbMaxRound.Pack(builder, _o.AsIBvbMaxRound()).Value;
			case ISystemVarBase_Union.IBvbNpcCardNum:
				return IBvbNpcCardNum.Pack(builder, _o.AsIBvbNpcCardNum()).Value;
			case ISystemVarBase_Union.IBvbNpcCurEnergy:
				return IBvbNpcCurEnergy.Pack(builder, _o.AsIBvbNpcCurEnergy()).Value;
			case ISystemVarBase_Union.IBvbNpcScore:
				return IBvbNpcScore.Pack(builder, _o.AsIBvbNpcScore()).Value;
			case ISystemVarBase_Union.IBvbPlayerScore:
				return IBvbPlayerScore.Pack(builder, _o.AsIBvbPlayerScore()).Value;
			case ISystemVarBase_Union.IBvbPlayerHp:
				return IBvbPlayerHp.Pack(builder, _o.AsIBvbPlayerHp()).Value;
			case ISystemVarBase_Union.IBvbNpcHp:
				return IBvbNpcHp.Pack(builder, _o.AsIBvbNpcHp()).Value;
			case ISystemVarBase_Union.IBvbPlayerHpValue:
				return IBvbPlayerHpValue.Pack(builder, _o.AsIBvbPlayerHpValue()).Value;
			case ISystemVarBase_Union.IBvbNpcHpValue:
				return IBvbNpcHpValue.Pack(builder, _o.AsIBvbNpcHpValue()).Value;
			case ISystemVarBase_Union.IBvbNpcCurBoardCardCount:
				return IBvbNpcCurBoardCardCount.Pack(builder, _o.AsIBvbNpcCurBoardCardCount()).Value;
			case ISystemVarBase_Union.IBvbMaxBoardCardCount:
				return IBvbMaxBoardCardCount.Pack(builder, _o.AsIBvbMaxBoardCardCount()).Value;
			case ISystemVarBase_Union.IBvbDungeonStage:
				return IBvbDungeonStage.Pack(builder, _o.AsIBvbDungeonStage()).Value;
			case ISystemVarBase_Union.IBvbCustomSystemVarInt:
				return IBvbCustomSystemVarInt.Pack(builder, _o.AsIBvbCustomSystemVarInt()).Value;
			case ISystemVarBase_Union.IBvbCustomSystemVarFloat:
				return IBvbCustomSystemVarFloat.Pack(builder, _o.AsIBvbCustomSystemVarFloat()).Value;
			case ISystemVarBase_Union.IQuestBranchPageId:
				return IQuestBranchPageId.Pack(builder, _o.AsIQuestBranchPageId()).Value;
			case ISystemVarBase_Union.ICommonHotFixVar:
				return ICommonHotFixVar.Pack(builder, _o.AsICommonHotFixVar()).Value;
			case ISystemVarBase_Union.ICommonHostToTargetDistance:
				return ICommonHostToTargetDistance.Pack(builder, _o.AsICommonHostToTargetDistance()).Value;
			default:
				return 0;
			}
		}
	}
}
