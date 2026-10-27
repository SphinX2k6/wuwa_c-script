using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004492 RID: 17554
	public class IDartSkillResultType_UnionUnion
	{
		// Token: 0x17007BD8 RID: 31704
		// (get) Token: 0x0601A2E0 RID: 107232 RVA: 0x003BD431 File Offset: 0x003BB631
		// (set) Token: 0x0601A2E1 RID: 107233 RVA: 0x003BD439 File Offset: 0x003BB639
		public IDartSkillResultType_Union Type { get; set; }

		// Token: 0x17007BD9 RID: 31705
		// (get) Token: 0x0601A2E2 RID: 107234 RVA: 0x003BD442 File Offset: 0x003BB642
		// (set) Token: 0x0601A2E3 RID: 107235 RVA: 0x003BD44A File Offset: 0x003BB64A
		public object Value { get; set; }

		// Token: 0x0601A2E4 RID: 107236 RVA: 0x003BD453 File Offset: 0x003BB653
		public IDartSkillResultType_UnionUnion()
		{
			this.Type = IDartSkillResultType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A2E5 RID: 107237 RVA: 0x003BD469 File Offset: 0x003BB669
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A2E6 RID: 107238 RVA: 0x003BD47B File Offset: 0x003BB67B
		public IDartSkillResultTypeT AsIDartSkillResultType()
		{
			return this.As<IDartSkillResultTypeT>();
		}

		// Token: 0x0601A2E7 RID: 107239 RVA: 0x003BD483 File Offset: 0x003BB683
		public static IDartSkillResultType_UnionUnion FromIDartSkillResultType(IDartSkillResultTypeT _idartskillresulttype)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IDartSkillResultType,
				Value = _idartskillresulttype
			};
		}

		// Token: 0x0601A2E8 RID: 107240 RVA: 0x003BD498 File Offset: 0x003BB698
		public INoBustResultT AsINoBustResult()
		{
			return this.As<INoBustResultT>();
		}

		// Token: 0x0601A2E9 RID: 107241 RVA: 0x003BD4A0 File Offset: 0x003BB6A0
		public static IDartSkillResultType_UnionUnion FromINoBustResult(INoBustResultT _inobustresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.INoBustResult,
				Value = _inobustresult
			};
		}

		// Token: 0x0601A2EA RID: 107242 RVA: 0x003BD4B5 File Offset: 0x003BB6B5
		public IHitZoneTimesResultT AsIHitZoneTimesResult()
		{
			return this.As<IHitZoneTimesResultT>();
		}

		// Token: 0x0601A2EB RID: 107243 RVA: 0x003BD4BD File Offset: 0x003BB6BD
		public static IDartSkillResultType_UnionUnion FromIHitZoneTimesResult(IHitZoneTimesResultT _ihitzonetimesresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitZoneTimesResult,
				Value = _ihitzonetimesresult
			};
		}

		// Token: 0x0601A2EC RID: 107244 RVA: 0x003BD4D2 File Offset: 0x003BB6D2
		public IHitRemainScoreZoneResultT AsIHitRemainScoreZoneResult()
		{
			return this.As<IHitRemainScoreZoneResultT>();
		}

		// Token: 0x0601A2ED RID: 107245 RVA: 0x003BD4DA File Offset: 0x003BB6DA
		public static IDartSkillResultType_UnionUnion FromIHitRemainScoreZoneResult(IHitRemainScoreZoneResultT _ihitremainscorezoneresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitRemainScoreZoneResult,
				Value = _ihitremainscorezoneresult
			};
		}

		// Token: 0x0601A2EE RID: 107246 RVA: 0x003BD4EF File Offset: 0x003BB6EF
		public IHitNoScoreResultT AsIHitNoScoreResult()
		{
			return this.As<IHitNoScoreResultT>();
		}

		// Token: 0x0601A2EF RID: 107247 RVA: 0x003BD4F7 File Offset: 0x003BB6F7
		public static IDartSkillResultType_UnionUnion FromIHitNoScoreResult(IHitNoScoreResultT _ihitnoscoreresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitNoScoreResult,
				Value = _ihitnoscoreresult
			};
		}

		// Token: 0x0601A2F0 RID: 107248 RVA: 0x003BD50C File Offset: 0x003BB70C
		public ITripleZoneHitResultT AsITripleZoneHitResult()
		{
			return this.As<ITripleZoneHitResultT>();
		}

		// Token: 0x0601A2F1 RID: 107249 RVA: 0x003BD514 File Offset: 0x003BB714
		public static IDartSkillResultType_UnionUnion FromITripleZoneHitResult(ITripleZoneHitResultT _itriplezonehitresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.ITripleZoneHitResult,
				Value = _itriplezonehitresult
			};
		}

		// Token: 0x0601A2F2 RID: 107250 RVA: 0x003BD529 File Offset: 0x003BB729
		public IHitPlayerLastZoneResultT AsIHitPlayerLastZoneResult()
		{
			return this.As<IHitPlayerLastZoneResultT>();
		}

		// Token: 0x0601A2F3 RID: 107251 RVA: 0x003BD531 File Offset: 0x003BB731
		public static IDartSkillResultType_UnionUnion FromIHitPlayerLastZoneResult(IHitPlayerLastZoneResultT _ihitplayerlastzoneresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitPlayerLastZoneResult,
				Value = _ihitplayerlastzoneresult
			};
		}

		// Token: 0x0601A2F4 RID: 107252 RVA: 0x003BD546 File Offset: 0x003BB746
		public IBlockFinishRouteResultT AsIBlockFinishRouteResult()
		{
			return this.As<IBlockFinishRouteResultT>();
		}

		// Token: 0x0601A2F5 RID: 107253 RVA: 0x003BD54E File Offset: 0x003BB74E
		public static IDartSkillResultType_UnionUnion FromIBlockFinishRouteResult(IBlockFinishRouteResultT _iblockfinishrouteresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IBlockFinishRouteResult,
				Value = _iblockfinishrouteresult
			};
		}

		// Token: 0x0601A2F6 RID: 107254 RVA: 0x003BD563 File Offset: 0x003BB763
		public IHoldBreathResultT AsIHoldBreathResult()
		{
			return this.As<IHoldBreathResultT>();
		}

		// Token: 0x0601A2F7 RID: 107255 RVA: 0x003BD56B File Offset: 0x003BB76B
		public static IDartSkillResultType_UnionUnion FromIHoldBreathResult(IHoldBreathResultT _iholdbreathresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHoldBreathResult,
				Value = _iholdbreathresult
			};
		}

		// Token: 0x0601A2F8 RID: 107256 RVA: 0x003BD584 File Offset: 0x003BB784
		public static int Pack(FlatBufferBuilder builder, IDartSkillResultType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDartSkillResultType_Union.IDartSkillResultType:
				return IDartSkillResultType.Pack(builder, _o.AsIDartSkillResultType()).Value;
			case IDartSkillResultType_Union.INoBustResult:
				return INoBustResult.Pack(builder, _o.AsINoBustResult()).Value;
			case IDartSkillResultType_Union.IHitZoneTimesResult:
				return IHitZoneTimesResult.Pack(builder, _o.AsIHitZoneTimesResult()).Value;
			case IDartSkillResultType_Union.IHitRemainScoreZoneResult:
				return IHitRemainScoreZoneResult.Pack(builder, _o.AsIHitRemainScoreZoneResult()).Value;
			case IDartSkillResultType_Union.IHitNoScoreResult:
				return IHitNoScoreResult.Pack(builder, _o.AsIHitNoScoreResult()).Value;
			case IDartSkillResultType_Union.ITripleZoneHitResult:
				return ITripleZoneHitResult.Pack(builder, _o.AsITripleZoneHitResult()).Value;
			case IDartSkillResultType_Union.IHitPlayerLastZoneResult:
				return IHitPlayerLastZoneResult.Pack(builder, _o.AsIHitPlayerLastZoneResult()).Value;
			case IDartSkillResultType_Union.IBlockFinishRouteResult:
				return IBlockFinishRouteResult.Pack(builder, _o.AsIBlockFinishRouteResult()).Value;
			case IDartSkillResultType_Union.IHoldBreathResult:
				return IHoldBreathResult.Pack(builder, _o.AsIHoldBreathResult()).Value;
			default:
				return 0;
			}
		}
	}
}
