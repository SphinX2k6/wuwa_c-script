using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004603 RID: 17923
	public class TDartSkillResultUnion
	{
		// Token: 0x17007F61 RID: 32609
		// (get) Token: 0x0601B267 RID: 111207 RVA: 0x003DE53C File Offset: 0x003DC73C
		// (set) Token: 0x0601B268 RID: 111208 RVA: 0x003DE544 File Offset: 0x003DC744
		public TDartSkillResult Type { get; set; }

		// Token: 0x17007F62 RID: 32610
		// (get) Token: 0x0601B269 RID: 111209 RVA: 0x003DE54D File Offset: 0x003DC74D
		// (set) Token: 0x0601B26A RID: 111210 RVA: 0x003DE555 File Offset: 0x003DC755
		public object Value { get; set; }

		// Token: 0x0601B26B RID: 111211 RVA: 0x003DE55E File Offset: 0x003DC75E
		public TDartSkillResultUnion()
		{
			this.Type = TDartSkillResult.NONE;
			this.Value = null;
		}

		// Token: 0x0601B26C RID: 111212 RVA: 0x003DE574 File Offset: 0x003DC774
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601B26D RID: 111213 RVA: 0x003DE586 File Offset: 0x003DC786
		public IBlockFinishRouteResultT AsIBlockFinishRouteResult()
		{
			return this.As<IBlockFinishRouteResultT>();
		}

		// Token: 0x0601B26E RID: 111214 RVA: 0x003DE58E File Offset: 0x003DC78E
		public static TDartSkillResultUnion FromIBlockFinishRouteResult(IBlockFinishRouteResultT _iblockfinishrouteresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IBlockFinishRouteResult,
				Value = _iblockfinishrouteresult
			};
		}

		// Token: 0x0601B26F RID: 111215 RVA: 0x003DE5A3 File Offset: 0x003DC7A3
		public IHitNoScoreResultT AsIHitNoScoreResult()
		{
			return this.As<IHitNoScoreResultT>();
		}

		// Token: 0x0601B270 RID: 111216 RVA: 0x003DE5AB File Offset: 0x003DC7AB
		public static TDartSkillResultUnion FromIHitNoScoreResult(IHitNoScoreResultT _ihitnoscoreresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitNoScoreResult,
				Value = _ihitnoscoreresult
			};
		}

		// Token: 0x0601B271 RID: 111217 RVA: 0x003DE5C0 File Offset: 0x003DC7C0
		public IHitPlayerLastZoneResultT AsIHitPlayerLastZoneResult()
		{
			return this.As<IHitPlayerLastZoneResultT>();
		}

		// Token: 0x0601B272 RID: 111218 RVA: 0x003DE5C8 File Offset: 0x003DC7C8
		public static TDartSkillResultUnion FromIHitPlayerLastZoneResult(IHitPlayerLastZoneResultT _ihitplayerlastzoneresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitPlayerLastZoneResult,
				Value = _ihitplayerlastzoneresult
			};
		}

		// Token: 0x0601B273 RID: 111219 RVA: 0x003DE5DD File Offset: 0x003DC7DD
		public IHitRemainScoreZoneResultT AsIHitRemainScoreZoneResult()
		{
			return this.As<IHitRemainScoreZoneResultT>();
		}

		// Token: 0x0601B274 RID: 111220 RVA: 0x003DE5E5 File Offset: 0x003DC7E5
		public static TDartSkillResultUnion FromIHitRemainScoreZoneResult(IHitRemainScoreZoneResultT _ihitremainscorezoneresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitRemainScoreZoneResult,
				Value = _ihitremainscorezoneresult
			};
		}

		// Token: 0x0601B275 RID: 111221 RVA: 0x003DE5FA File Offset: 0x003DC7FA
		public IHitZoneTimesResultT AsIHitZoneTimesResult()
		{
			return this.As<IHitZoneTimesResultT>();
		}

		// Token: 0x0601B276 RID: 111222 RVA: 0x003DE602 File Offset: 0x003DC802
		public static TDartSkillResultUnion FromIHitZoneTimesResult(IHitZoneTimesResultT _ihitzonetimesresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHitZoneTimesResult,
				Value = _ihitzonetimesresult
			};
		}

		// Token: 0x0601B277 RID: 111223 RVA: 0x003DE617 File Offset: 0x003DC817
		public IHoldBreathResultT AsIHoldBreathResult()
		{
			return this.As<IHoldBreathResultT>();
		}

		// Token: 0x0601B278 RID: 111224 RVA: 0x003DE61F File Offset: 0x003DC81F
		public static TDartSkillResultUnion FromIHoldBreathResult(IHoldBreathResultT _iholdbreathresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.IHoldBreathResult,
				Value = _iholdbreathresult
			};
		}

		// Token: 0x0601B279 RID: 111225 RVA: 0x003DE634 File Offset: 0x003DC834
		public INoBustResultT AsINoBustResult()
		{
			return this.As<INoBustResultT>();
		}

		// Token: 0x0601B27A RID: 111226 RVA: 0x003DE63C File Offset: 0x003DC83C
		public static TDartSkillResultUnion FromINoBustResult(INoBustResultT _inobustresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.INoBustResult,
				Value = _inobustresult
			};
		}

		// Token: 0x0601B27B RID: 111227 RVA: 0x003DE651 File Offset: 0x003DC851
		public ITripleZoneHitResultT AsITripleZoneHitResult()
		{
			return this.As<ITripleZoneHitResultT>();
		}

		// Token: 0x0601B27C RID: 111228 RVA: 0x003DE659 File Offset: 0x003DC859
		public static TDartSkillResultUnion FromITripleZoneHitResult(ITripleZoneHitResultT _itriplezonehitresult)
		{
			return new TDartSkillResultUnion
			{
				Type = TDartSkillResult.ITripleZoneHitResult,
				Value = _itriplezonehitresult
			};
		}

		// Token: 0x0601B27D RID: 111229 RVA: 0x003DE670 File Offset: 0x003DC870
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
