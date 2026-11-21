using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048FA RID: 18682
	public class IDartSkillResultType_UnionUnion
	{
		// Token: 0x17008217 RID: 33303
		// (get) Token: 0x0601BAB1 RID: 113329 RVA: 0x003E963D File Offset: 0x003E783D
		// (set) Token: 0x0601BAB2 RID: 113330 RVA: 0x003E9645 File Offset: 0x003E7845
		public IDartSkillResultType_Union Type { get; set; }

		// Token: 0x17008218 RID: 33304
		// (get) Token: 0x0601BAB3 RID: 113331 RVA: 0x003E964E File Offset: 0x003E784E
		// (set) Token: 0x0601BAB4 RID: 113332 RVA: 0x003E9656 File Offset: 0x003E7856
		public object Value { get; set; }

		// Token: 0x0601BAB5 RID: 113333 RVA: 0x003E965F File Offset: 0x003E785F
		public IDartSkillResultType_UnionUnion()
		{
			this.Type = IDartSkillResultType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601BAB6 RID: 113334 RVA: 0x003E9675 File Offset: 0x003E7875
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601BAB7 RID: 113335 RVA: 0x003E9687 File Offset: 0x003E7887
		public IDartSkillResultTypeT AsIDartSkillResultType()
		{
			return this.As<IDartSkillResultTypeT>();
		}

		// Token: 0x0601BAB8 RID: 113336 RVA: 0x003E968F File Offset: 0x003E788F
		public static IDartSkillResultType_UnionUnion FromIDartSkillResultType(IDartSkillResultTypeT _idartskillresulttype)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IDartSkillResultType,
				Value = _idartskillresulttype
			};
		}

		// Token: 0x0601BAB9 RID: 113337 RVA: 0x003E96A4 File Offset: 0x003E78A4
		public INoBustResultT AsINoBustResult()
		{
			return this.As<INoBustResultT>();
		}

		// Token: 0x0601BABA RID: 113338 RVA: 0x003E96AC File Offset: 0x003E78AC
		public static IDartSkillResultType_UnionUnion FromINoBustResult(INoBustResultT _inobustresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.INoBustResult,
				Value = _inobustresult
			};
		}

		// Token: 0x0601BABB RID: 113339 RVA: 0x003E96C1 File Offset: 0x003E78C1
		public IHitZoneTimesResultT AsIHitZoneTimesResult()
		{
			return this.As<IHitZoneTimesResultT>();
		}

		// Token: 0x0601BABC RID: 113340 RVA: 0x003E96C9 File Offset: 0x003E78C9
		public static IDartSkillResultType_UnionUnion FromIHitZoneTimesResult(IHitZoneTimesResultT _ihitzonetimesresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitZoneTimesResult,
				Value = _ihitzonetimesresult
			};
		}

		// Token: 0x0601BABD RID: 113341 RVA: 0x003E96DE File Offset: 0x003E78DE
		public IHitRemainScoreZoneResultT AsIHitRemainScoreZoneResult()
		{
			return this.As<IHitRemainScoreZoneResultT>();
		}

		// Token: 0x0601BABE RID: 113342 RVA: 0x003E96E6 File Offset: 0x003E78E6
		public static IDartSkillResultType_UnionUnion FromIHitRemainScoreZoneResult(IHitRemainScoreZoneResultT _ihitremainscorezoneresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitRemainScoreZoneResult,
				Value = _ihitremainscorezoneresult
			};
		}

		// Token: 0x0601BABF RID: 113343 RVA: 0x003E96FB File Offset: 0x003E78FB
		public IHitNoScoreResultT AsIHitNoScoreResult()
		{
			return this.As<IHitNoScoreResultT>();
		}

		// Token: 0x0601BAC0 RID: 113344 RVA: 0x003E9703 File Offset: 0x003E7903
		public static IDartSkillResultType_UnionUnion FromIHitNoScoreResult(IHitNoScoreResultT _ihitnoscoreresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitNoScoreResult,
				Value = _ihitnoscoreresult
			};
		}

		// Token: 0x0601BAC1 RID: 113345 RVA: 0x003E9718 File Offset: 0x003E7918
		public ITripleZoneHitResultT AsITripleZoneHitResult()
		{
			return this.As<ITripleZoneHitResultT>();
		}

		// Token: 0x0601BAC2 RID: 113346 RVA: 0x003E9720 File Offset: 0x003E7920
		public static IDartSkillResultType_UnionUnion FromITripleZoneHitResult(ITripleZoneHitResultT _itriplezonehitresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.ITripleZoneHitResult,
				Value = _itriplezonehitresult
			};
		}

		// Token: 0x0601BAC3 RID: 113347 RVA: 0x003E9735 File Offset: 0x003E7935
		public IHitPlayerLastZoneResultT AsIHitPlayerLastZoneResult()
		{
			return this.As<IHitPlayerLastZoneResultT>();
		}

		// Token: 0x0601BAC4 RID: 113348 RVA: 0x003E973D File Offset: 0x003E793D
		public static IDartSkillResultType_UnionUnion FromIHitPlayerLastZoneResult(IHitPlayerLastZoneResultT _ihitplayerlastzoneresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHitPlayerLastZoneResult,
				Value = _ihitplayerlastzoneresult
			};
		}

		// Token: 0x0601BAC5 RID: 113349 RVA: 0x003E9752 File Offset: 0x003E7952
		public IBlockFinishRouteResultT AsIBlockFinishRouteResult()
		{
			return this.As<IBlockFinishRouteResultT>();
		}

		// Token: 0x0601BAC6 RID: 113350 RVA: 0x003E975A File Offset: 0x003E795A
		public static IDartSkillResultType_UnionUnion FromIBlockFinishRouteResult(IBlockFinishRouteResultT _iblockfinishrouteresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IBlockFinishRouteResult,
				Value = _iblockfinishrouteresult
			};
		}

		// Token: 0x0601BAC7 RID: 113351 RVA: 0x003E976F File Offset: 0x003E796F
		public IHoldBreathResultT AsIHoldBreathResult()
		{
			return this.As<IHoldBreathResultT>();
		}

		// Token: 0x0601BAC8 RID: 113352 RVA: 0x003E9777 File Offset: 0x003E7977
		public static IDartSkillResultType_UnionUnion FromIHoldBreathResult(IHoldBreathResultT _iholdbreathresult)
		{
			return new IDartSkillResultType_UnionUnion
			{
				Type = IDartSkillResultType_Union.IHoldBreathResult,
				Value = _iholdbreathresult
			};
		}

		// Token: 0x0601BAC9 RID: 113353 RVA: 0x003E9790 File Offset: 0x003E7990
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
