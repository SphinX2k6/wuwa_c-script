using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AD6 RID: 15062
	public class ISystemVarBase_UnionUnion
	{
		// Token: 0x1700674F RID: 26447
		// (get) Token: 0x060147D7 RID: 83927 RVA: 0x002FC059 File Offset: 0x002FA259
		// (set) Token: 0x060147D8 RID: 83928 RVA: 0x002FC061 File Offset: 0x002FA261
		public ISystemVarBase_Union Type { get; set; }

		// Token: 0x17006750 RID: 26448
		// (get) Token: 0x060147D9 RID: 83929 RVA: 0x002FC06A File Offset: 0x002FA26A
		// (set) Token: 0x060147DA RID: 83930 RVA: 0x002FC072 File Offset: 0x002FA272
		public object Value { get; set; }

		// Token: 0x060147DB RID: 83931 RVA: 0x002FC07B File Offset: 0x002FA27B
		public ISystemVarBase_UnionUnion()
		{
			this.Type = ISystemVarBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060147DC RID: 83932 RVA: 0x002FC091 File Offset: 0x002FA291
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060147DD RID: 83933 RVA: 0x002FC0A3 File Offset: 0x002FA2A3
		public ISystemVarBaseT AsISystemVarBase()
		{
			return this.As<ISystemVarBaseT>();
		}

		// Token: 0x060147DE RID: 83934 RVA: 0x002FC0AB File Offset: 0x002FA2AB
		public static ISystemVarBase_UnionUnion FromISystemVarBase(ISystemVarBaseT _isystemvarbase)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ISystemVarBase,
				Value = _isystemvarbase
			};
		}

		// Token: 0x060147DF RID: 83935 RVA: 0x002FC0C0 File Offset: 0x002FA2C0
		public IBvbFetchHandCardT AsIBvbFetchHandCard()
		{
			return this.As<IBvbFetchHandCardT>();
		}

		// Token: 0x060147E0 RID: 83936 RVA: 0x002FC0C8 File Offset: 0x002FA2C8
		public static ISystemVarBase_UnionUnion FromIBvbFetchHandCard(IBvbFetchHandCardT _ibvbfetchhandcard)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbFetchHandCard,
				Value = _ibvbfetchhandcard
			};
		}

		// Token: 0x060147E1 RID: 83937 RVA: 0x002FC0DD File Offset: 0x002FA2DD
		public IBvbGetBoardCardT AsIBvbGetBoardCard()
		{
			return this.As<IBvbGetBoardCardT>();
		}

		// Token: 0x060147E2 RID: 83938 RVA: 0x002FC0E5 File Offset: 0x002FA2E5
		public static ISystemVarBase_UnionUnion FromIBvbGetBoardCard(IBvbGetBoardCardT _ibvbgetboardcard)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetBoardCard,
				Value = _ibvbgetboardcard
			};
		}

		// Token: 0x060147E3 RID: 83939 RVA: 0x002FC0FA File Offset: 0x002FA2FA
		public IBvbGetCardPosT AsIBvbGetCardPos()
		{
			return this.As<IBvbGetCardPosT>();
		}

		// Token: 0x060147E4 RID: 83940 RVA: 0x002FC102 File Offset: 0x002FA302
		public static ISystemVarBase_UnionUnion FromIBvbGetCardPos(IBvbGetCardPosT _ibvbgetcardpos)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardPos,
				Value = _ibvbgetcardpos
			};
		}

		// Token: 0x060147E5 RID: 83941 RVA: 0x002FC117 File Offset: 0x002FA317
		public IBvbGetCardChangeUseT AsIBvbGetCardChangeUse()
		{
			return this.As<IBvbGetCardChangeUseT>();
		}

		// Token: 0x060147E6 RID: 83942 RVA: 0x002FC11F File Offset: 0x002FA31F
		public static ISystemVarBase_UnionUnion FromIBvbGetCardChangeUse(IBvbGetCardChangeUseT _ibvbgetcardchangeuse)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardChangeUse,
				Value = _ibvbgetcardchangeuse
			};
		}

		// Token: 0x060147E7 RID: 83943 RVA: 0x002FC134 File Offset: 0x002FA334
		public IBvbGetCardEvolvedUseT AsIBvbGetCardEvolvedUse()
		{
			return this.As<IBvbGetCardEvolvedUseT>();
		}

		// Token: 0x060147E8 RID: 83944 RVA: 0x002FC13C File Offset: 0x002FA33C
		public static ISystemVarBase_UnionUnion FromIBvbGetCardEvolvedUse(IBvbGetCardEvolvedUseT _ibvbgetcardevolveduse)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbGetCardEvolvedUse,
				Value = _ibvbgetcardevolveduse
			};
		}

		// Token: 0x060147E9 RID: 83945 RVA: 0x002FC151 File Offset: 0x002FA351
		public IBvbAdjustPosPreferenceT AsIBvbAdjustPosPreference()
		{
			return this.As<IBvbAdjustPosPreferenceT>();
		}

		// Token: 0x060147EA RID: 83946 RVA: 0x002FC159 File Offset: 0x002FA359
		public static ISystemVarBase_UnionUnion FromIBvbAdjustPosPreference(IBvbAdjustPosPreferenceT _ibvbadjustpospreference)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbAdjustPosPreference,
				Value = _ibvbadjustpospreference
			};
		}

		// Token: 0x060147EB RID: 83947 RVA: 0x002FC16E File Offset: 0x002FA36E
		public IBvbCurRoundT AsIBvbCurRound()
		{
			return this.As<IBvbCurRoundT>();
		}

		// Token: 0x060147EC RID: 83948 RVA: 0x002FC176 File Offset: 0x002FA376
		public static ISystemVarBase_UnionUnion FromIBvbCurRound(IBvbCurRoundT _ibvbcurround)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCurRound,
				Value = _ibvbcurround
			};
		}

		// Token: 0x060147ED RID: 83949 RVA: 0x002FC18B File Offset: 0x002FA38B
		public IBvbRemainEvolveTimeThisTurnT AsIBvbRemainEvolveTimeThisTurn()
		{
			return this.As<IBvbRemainEvolveTimeThisTurnT>();
		}

		// Token: 0x060147EE RID: 83950 RVA: 0x002FC193 File Offset: 0x002FA393
		public static ISystemVarBase_UnionUnion FromIBvbRemainEvolveTimeThisTurn(IBvbRemainEvolveTimeThisTurnT _ibvbremainevolvetimethisturn)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbRemainEvolveTimeThisTurn,
				Value = _ibvbremainevolvetimethisturn
			};
		}

		// Token: 0x060147EF RID: 83951 RVA: 0x002FC1A9 File Offset: 0x002FA3A9
		public IBvbMaxRoundT AsIBvbMaxRound()
		{
			return this.As<IBvbMaxRoundT>();
		}

		// Token: 0x060147F0 RID: 83952 RVA: 0x002FC1B1 File Offset: 0x002FA3B1
		public static ISystemVarBase_UnionUnion FromIBvbMaxRound(IBvbMaxRoundT _ibvbmaxround)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbMaxRound,
				Value = _ibvbmaxround
			};
		}

		// Token: 0x060147F1 RID: 83953 RVA: 0x002FC1C7 File Offset: 0x002FA3C7
		public IBvbNpcCardNumT AsIBvbNpcCardNum()
		{
			return this.As<IBvbNpcCardNumT>();
		}

		// Token: 0x060147F2 RID: 83954 RVA: 0x002FC1CF File Offset: 0x002FA3CF
		public static ISystemVarBase_UnionUnion FromIBvbNpcCardNum(IBvbNpcCardNumT _ibvbnpccardnum)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCardNum,
				Value = _ibvbnpccardnum
			};
		}

		// Token: 0x060147F3 RID: 83955 RVA: 0x002FC1E5 File Offset: 0x002FA3E5
		public IBvbNpcCurEnergyT AsIBvbNpcCurEnergy()
		{
			return this.As<IBvbNpcCurEnergyT>();
		}

		// Token: 0x060147F4 RID: 83956 RVA: 0x002FC1ED File Offset: 0x002FA3ED
		public static ISystemVarBase_UnionUnion FromIBvbNpcCurEnergy(IBvbNpcCurEnergyT _ibvbnpccurenergy)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCurEnergy,
				Value = _ibvbnpccurenergy
			};
		}

		// Token: 0x060147F5 RID: 83957 RVA: 0x002FC203 File Offset: 0x002FA403
		public IBvbNpcScoreT AsIBvbNpcScore()
		{
			return this.As<IBvbNpcScoreT>();
		}

		// Token: 0x060147F6 RID: 83958 RVA: 0x002FC20B File Offset: 0x002FA40B
		public static ISystemVarBase_UnionUnion FromIBvbNpcScore(IBvbNpcScoreT _ibvbnpcscore)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcScore,
				Value = _ibvbnpcscore
			};
		}

		// Token: 0x060147F7 RID: 83959 RVA: 0x002FC221 File Offset: 0x002FA421
		public IBvbPlayerScoreT AsIBvbPlayerScore()
		{
			return this.As<IBvbPlayerScoreT>();
		}

		// Token: 0x060147F8 RID: 83960 RVA: 0x002FC229 File Offset: 0x002FA429
		public static ISystemVarBase_UnionUnion FromIBvbPlayerScore(IBvbPlayerScoreT _ibvbplayerscore)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerScore,
				Value = _ibvbplayerscore
			};
		}

		// Token: 0x060147F9 RID: 83961 RVA: 0x002FC23F File Offset: 0x002FA43F
		public IBvbPlayerHpT AsIBvbPlayerHp()
		{
			return this.As<IBvbPlayerHpT>();
		}

		// Token: 0x060147FA RID: 83962 RVA: 0x002FC247 File Offset: 0x002FA447
		public static ISystemVarBase_UnionUnion FromIBvbPlayerHp(IBvbPlayerHpT _ibvbplayerhp)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerHp,
				Value = _ibvbplayerhp
			};
		}

		// Token: 0x060147FB RID: 83963 RVA: 0x002FC25D File Offset: 0x002FA45D
		public IBvbNpcHpT AsIBvbNpcHp()
		{
			return this.As<IBvbNpcHpT>();
		}

		// Token: 0x060147FC RID: 83964 RVA: 0x002FC265 File Offset: 0x002FA465
		public static ISystemVarBase_UnionUnion FromIBvbNpcHp(IBvbNpcHpT _ibvbnpchp)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcHp,
				Value = _ibvbnpchp
			};
		}

		// Token: 0x060147FD RID: 83965 RVA: 0x002FC27B File Offset: 0x002FA47B
		public IBvbPlayerHpValueT AsIBvbPlayerHpValue()
		{
			return this.As<IBvbPlayerHpValueT>();
		}

		// Token: 0x060147FE RID: 83966 RVA: 0x002FC283 File Offset: 0x002FA483
		public static ISystemVarBase_UnionUnion FromIBvbPlayerHpValue(IBvbPlayerHpValueT _ibvbplayerhpvalue)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbPlayerHpValue,
				Value = _ibvbplayerhpvalue
			};
		}

		// Token: 0x060147FF RID: 83967 RVA: 0x002FC299 File Offset: 0x002FA499
		public IBvbNpcHpValueT AsIBvbNpcHpValue()
		{
			return this.As<IBvbNpcHpValueT>();
		}

		// Token: 0x06014800 RID: 83968 RVA: 0x002FC2A1 File Offset: 0x002FA4A1
		public static ISystemVarBase_UnionUnion FromIBvbNpcHpValue(IBvbNpcHpValueT _ibvbnpchpvalue)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcHpValue,
				Value = _ibvbnpchpvalue
			};
		}

		// Token: 0x06014801 RID: 83969 RVA: 0x002FC2B7 File Offset: 0x002FA4B7
		public IBvbNpcCurBoardCardCountT AsIBvbNpcCurBoardCardCount()
		{
			return this.As<IBvbNpcCurBoardCardCountT>();
		}

		// Token: 0x06014802 RID: 83970 RVA: 0x002FC2BF File Offset: 0x002FA4BF
		public static ISystemVarBase_UnionUnion FromIBvbNpcCurBoardCardCount(IBvbNpcCurBoardCardCountT _ibvbnpccurboardcardcount)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbNpcCurBoardCardCount,
				Value = _ibvbnpccurboardcardcount
			};
		}

		// Token: 0x06014803 RID: 83971 RVA: 0x002FC2D5 File Offset: 0x002FA4D5
		public IBvbMaxBoardCardCountT AsIBvbMaxBoardCardCount()
		{
			return this.As<IBvbMaxBoardCardCountT>();
		}

		// Token: 0x06014804 RID: 83972 RVA: 0x002FC2DD File Offset: 0x002FA4DD
		public static ISystemVarBase_UnionUnion FromIBvbMaxBoardCardCount(IBvbMaxBoardCardCountT _ibvbmaxboardcardcount)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbMaxBoardCardCount,
				Value = _ibvbmaxboardcardcount
			};
		}

		// Token: 0x06014805 RID: 83973 RVA: 0x002FC2F3 File Offset: 0x002FA4F3
		public IBvbDungeonStageT AsIBvbDungeonStage()
		{
			return this.As<IBvbDungeonStageT>();
		}

		// Token: 0x06014806 RID: 83974 RVA: 0x002FC2FB File Offset: 0x002FA4FB
		public static ISystemVarBase_UnionUnion FromIBvbDungeonStage(IBvbDungeonStageT _ibvbdungeonstage)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbDungeonStage,
				Value = _ibvbdungeonstage
			};
		}

		// Token: 0x06014807 RID: 83975 RVA: 0x002FC311 File Offset: 0x002FA511
		public IBvbCustomSystemVarIntT AsIBvbCustomSystemVarInt()
		{
			return this.As<IBvbCustomSystemVarIntT>();
		}

		// Token: 0x06014808 RID: 83976 RVA: 0x002FC319 File Offset: 0x002FA519
		public static ISystemVarBase_UnionUnion FromIBvbCustomSystemVarInt(IBvbCustomSystemVarIntT _ibvbcustomsystemvarint)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCustomSystemVarInt,
				Value = _ibvbcustomsystemvarint
			};
		}

		// Token: 0x06014809 RID: 83977 RVA: 0x002FC32F File Offset: 0x002FA52F
		public IBvbCustomSystemVarFloatT AsIBvbCustomSystemVarFloat()
		{
			return this.As<IBvbCustomSystemVarFloatT>();
		}

		// Token: 0x0601480A RID: 83978 RVA: 0x002FC337 File Offset: 0x002FA537
		public static ISystemVarBase_UnionUnion FromIBvbCustomSystemVarFloat(IBvbCustomSystemVarFloatT _ibvbcustomsystemvarfloat)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IBvbCustomSystemVarFloat,
				Value = _ibvbcustomsystemvarfloat
			};
		}

		// Token: 0x0601480B RID: 83979 RVA: 0x002FC34D File Offset: 0x002FA54D
		public IQuestBranchPageIdT AsIQuestBranchPageId()
		{
			return this.As<IQuestBranchPageIdT>();
		}

		// Token: 0x0601480C RID: 83980 RVA: 0x002FC355 File Offset: 0x002FA555
		public static ISystemVarBase_UnionUnion FromIQuestBranchPageId(IQuestBranchPageIdT _iquestbranchpageid)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.IQuestBranchPageId,
				Value = _iquestbranchpageid
			};
		}

		// Token: 0x0601480D RID: 83981 RVA: 0x002FC36B File Offset: 0x002FA56B
		public ICommonHotFixVarT AsICommonHotFixVar()
		{
			return this.As<ICommonHotFixVarT>();
		}

		// Token: 0x0601480E RID: 83982 RVA: 0x002FC373 File Offset: 0x002FA573
		public static ISystemVarBase_UnionUnion FromICommonHotFixVar(ICommonHotFixVarT _icommonhotfixvar)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ICommonHotFixVar,
				Value = _icommonhotfixvar
			};
		}

		// Token: 0x0601480F RID: 83983 RVA: 0x002FC389 File Offset: 0x002FA589
		public ICommonHostToTargetDistanceT AsICommonHostToTargetDistance()
		{
			return this.As<ICommonHostToTargetDistanceT>();
		}

		// Token: 0x06014810 RID: 83984 RVA: 0x002FC391 File Offset: 0x002FA591
		public static ISystemVarBase_UnionUnion FromICommonHostToTargetDistance(ICommonHostToTargetDistanceT _icommonhosttotargetdistance)
		{
			return new ISystemVarBase_UnionUnion
			{
				Type = ISystemVarBase_Union.ICommonHostToTargetDistance,
				Value = _icommonhosttotargetdistance
			};
		}

		// Token: 0x06014811 RID: 83985 RVA: 0x002FC3A8 File Offset: 0x002FA5A8
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
