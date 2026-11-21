using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A6B RID: 19051
	public class TDartSkillResultUnion
	{
		// Token: 0x170085A2 RID: 34210
		// (get) Token: 0x0601CA3C RID: 117308 RVA: 0x0040A7D8 File Offset: 0x004089D8
		// (set) Token: 0x0601CA3D RID: 117309 RVA: 0x0040A7E0 File Offset: 0x004089E0
		public TDartSkillResult Type { get; set; }

		// Token: 0x170085A3 RID: 34211
		// (get) Token: 0x0601CA3E RID: 117310 RVA: 0x0040A7E9 File Offset: 0x004089E9
		// (set) Token: 0x0601CA3F RID: 117311 RVA: 0x0040A7F1 File Offset: 0x004089F1
		public object Value { get; set; }

		// Token: 0x0601CA40 RID: 117312 RVA: 0x0040A7FA File Offset: 0x004089FA
		public TDartSkillResultUnion()
		{
			this.Type = TDartSkillResult.NONE;
			this.Value = null;
		}

		// Token: 0x0601CA41 RID: 117313 RVA: 0x0040A810 File Offset: 0x00408A10
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601CA42 RID: 117314 RVA: 0x0040A822 File Offset: 0x00408A22
		public IBlockFinishRouteResultT AsIBlockFinishRouteResult()
		{
			return this.As<IBlockFinishRouteResultT>();
		}

		// Token: 0x0601CA43 RID: 117315 RVA: 0x0040A82A File Offset: 0x00408A2A
		public static TDartSkillResultUnion FromIBlockFinishRouteResult(IBlockFinishRouteResultT _iblockfinishrouteresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IBlockFinishRouteResult,
				Value = _iblockfinishrouteresult
			};
		}

		// Token: 0x0601CA44 RID: 117316 RVA: 0x0040A83F File Offset: 0x00408A3F
		public IHitNoScoreResultT AsIHitNoScoreResult()
		{
			return this.As<IHitNoScoreResultT>();
		}

		// Token: 0x0601CA45 RID: 117317 RVA: 0x0040A847 File Offset: 0x00408A47
		public static TDartSkillResultUnion FromIHitNoScoreResult(IHitNoScoreResultT _ihitnoscoreresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitNoScoreResult,
				Value = _ihitnoscoreresult
			};
		}

		// Token: 0x0601CA46 RID: 117318 RVA: 0x0040A85C File Offset: 0x00408A5C
		public IHitPlayerLastZoneResultT AsIHitPlayerLastZoneResult()
		{
			return this.As<IHitPlayerLastZoneResultT>();
		}

		// Token: 0x0601CA47 RID: 117319 RVA: 0x0040A864 File Offset: 0x00408A64
		public static TDartSkillResultUnion FromIHitPlayerLastZoneResult(IHitPlayerLastZoneResultT _ihitplayerlastzoneresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitPlayerLastZoneResult,
				Value = _ihitplayerlastzoneresult
			};
		}

		// Token: 0x0601CA48 RID: 117320 RVA: 0x0040A879 File Offset: 0x00408A79
		public IHitRemainScoreZoneResultT AsIHitRemainScoreZoneResult()
		{
			return this.As<IHitRemainScoreZoneResultT>();
		}

		// Token: 0x0601CA49 RID: 117321 RVA: 0x0040A881 File Offset: 0x00408A81
		public static TDartSkillResultUnion FromIHitRemainScoreZoneResult(IHitRemainScoreZoneResultT _ihitremainscorezoneresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitRemainScoreZoneResult,
				Value = _ihitremainscorezoneresult
			};
		}

		// Token: 0x0601CA4A RID: 117322 RVA: 0x0040A896 File Offset: 0x00408A96
		public IHitZoneTimesResultT AsIHitZoneTimesResult()
		{
			return this.As<IHitZoneTimesResultT>();
		}

		// Token: 0x0601CA4B RID: 117323 RVA: 0x0040A89E File Offset: 0x00408A9E
		public static TDartSkillResultUnion FromIHitZoneTimesResult(IHitZoneTimesResultT _ihitzonetimesresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitZoneTimesResult,
				Value = _ihitzonetimesresult
			};
		}

		// Token: 0x0601CA4C RID: 117324 RVA: 0x0040A8B3 File Offset: 0x00408AB3
		public IHoldBreathResultT AsIHoldBreathResult()
		{
			return this.As<IHoldBreathResultT>();
		}

		// Token: 0x0601CA4D RID: 117325 RVA: 0x0040A8BB File Offset: 0x00408ABB
		public static TDartSkillResultUnion FromIHoldBreathResult(IHoldBreathResultT _iholdbreathresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHoldBreathResult,
				Value = _iholdbreathresult
			};
		}

		// Token: 0x0601CA4E RID: 117326 RVA: 0x0040A8D0 File Offset: 0x00408AD0
		public INoBustResultT AsINoBustResult()
		{
			return this.As<INoBustResultT>();
		}

		// Token: 0x0601CA4F RID: 117327 RVA: 0x0040A8D8 File Offset: 0x00408AD8
		public static TDartSkillResultUnion FromINoBustResult(INoBustResultT _inobustresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.INoBustResult,
				Value = _inobustresult
			};
		}

		// Token: 0x0601CA50 RID: 117328 RVA: 0x0040A8ED File Offset: 0x00408AED
		public ITripleZoneHitResultT AsITripleZoneHitResult()
		{
			return this.As<ITripleZoneHitResultT>();
		}

		// Token: 0x0601CA51 RID: 117329 RVA: 0x0040A8F5 File Offset: 0x00408AF5
		public static TDartSkillResultUnion FromITripleZoneHitResult(ITripleZoneHitResultT _itriplezonehitresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.ITripleZoneHitResult,
				Value = _itriplezonehitresult
			};
		}

		// Token: 0x0601CA52 RID: 117330 RVA: 0x0040A90C File Offset: 0x00408B0C
		public static int Pack(FlatBufferBuilder builder, TDartSkillResultUnion _o)
		{
			switch (_o.Type)
			{
			case TDartSkillResult.IBlockFinishRouteResult:
				return IBlockFinishRouteResult.Pack(builder, _o.AsIBlockFinishRouteResult()).Value;
			case TDartSkillResult.IHitNoScoreResult:
				return IHitNoScoreResult.Pack(builder, _o.AsIHitNoScoreResult()).Value;
			case TDartSkillResult.IHitPlayerLastZoneResult:
				return IHitPlayerLastZoneResult.Pack(builder, _o.AsIHitPlayerLastZoneResult()).Value;
			case TDartSkillResult.IHitRemainScoreZoneResult:
				return IHitRemainScoreZoneResult.Pack(builder, _o.AsIHitRemainScoreZoneResult()).Value;
			case TDartSkillResult.IHitZoneTimesResult:
				return IHitZoneTimesResult.Pack(builder, _o.AsIHitZoneTimesResult()).Value;
			case TDartSkillResult.IHoldBreathResult:
				return IHoldBreathResult.Pack(builder, _o.AsIHoldBreathResult()).Value;
			case TDartSkillResult.INoBustResult:
				return INoBustResult.Pack(builder, _o.AsINoBustResult()).Value;
			case TDartSkillResult.ITripleZoneHitResult:
				return ITripleZoneHitResult.Pack(builder, _o.AsITripleZoneHitResult()).Value;
			default:
				return 0;
			}
		}
	}
}
