using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BD RID: 30397
	public class TExecBattleOptionUnion
	{
		// Token: 0x1700E617 RID: 58903
		// (get) Token: 0x06037494 RID: 226452 RVA: 0x0077DBCA File Offset: 0x0077BDCA
		// (set) Token: 0x06037495 RID: 226453 RVA: 0x0077DBD2 File Offset: 0x0077BDD2
		public TExecBattleOption Type { get; set; }

		// Token: 0x1700E618 RID: 58904
		// (get) Token: 0x06037496 RID: 226454 RVA: 0x0077DBDB File Offset: 0x0077BDDB
		// (set) Token: 0x06037497 RID: 226455 RVA: 0x0077DBE3 File Offset: 0x0077BDE3
		public object Value { get; set; }

		// Token: 0x06037498 RID: 226456 RVA: 0x0077DBEC File Offset: 0x0077BDEC
		public TExecBattleOptionUnion()
		{
			this.Type = TExecBattleOption.NONE;
			this.Value = null;
		}

		// Token: 0x06037499 RID: 226457 RVA: 0x0077DC02 File Offset: 0x0077BE02
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603749A RID: 226458 RVA: 0x0077DC14 File Offset: 0x0077BE14
		public IExitMonsterMoveTargetT AsIExitMonsterMoveTarget()
		{
			return this.As<IExitMonsterMoveTargetT>();
		}

		// Token: 0x0603749B RID: 226459 RVA: 0x0077DC1C File Offset: 0x0077BE1C
		public static TExecBattleOptionUnion FromIExitMonsterMoveTarget(IExitMonsterMoveTargetT _iexitmonstermovetarget)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IExitMonsterMoveTarget,
				Value = _iexitmonstermovetarget
			};
		}

		// Token: 0x0603749C RID: 226460 RVA: 0x0077DC31 File Offset: 0x0077BE31
		public IExitMonsterMoveWithSplineT AsIExitMonsterMoveWithSpline()
		{
			return this.As<IExitMonsterMoveWithSplineT>();
		}

		// Token: 0x0603749D RID: 226461 RVA: 0x0077DC39 File Offset: 0x0077BE39
		public static TExecBattleOptionUnion FromIExitMonsterMoveWithSpline(IExitMonsterMoveWithSplineT _iexitmonstermovewithspline)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IExitMonsterMoveWithSpline,
				Value = _iexitmonstermovewithspline
			};
		}

		// Token: 0x0603749E RID: 226462 RVA: 0x0077DC4E File Offset: 0x0077BE4E
		public ISendBattleEventsT AsISendBattleEvents()
		{
			return this.As<ISendBattleEventsT>();
		}

		// Token: 0x0603749F RID: 226463 RVA: 0x0077DC56 File Offset: 0x0077BE56
		public static TExecBattleOptionUnion FromISendBattleEvents(ISendBattleEventsT _isendbattleevents)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISendBattleEvents,
				Value = _isendbattleevents
			};
		}

		// Token: 0x060374A0 RID: 226464 RVA: 0x0077DC6B File Offset: 0x0077BE6B
		public ISendBattleEventsForMonsterSummonT AsISendBattleEventsForMonsterSummon()
		{
			return this.As<ISendBattleEventsForMonsterSummonT>();
		}

		// Token: 0x060374A1 RID: 226465 RVA: 0x0077DC73 File Offset: 0x0077BE73
		public static TExecBattleOptionUnion FromISendBattleEventsForMonsterSummon(ISendBattleEventsForMonsterSummonT _isendbattleeventsformonstersummon)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISendBattleEventsForMonsterSummon,
				Value = _isendbattleeventsformonstersummon
			};
		}

		// Token: 0x060374A2 RID: 226466 RVA: 0x0077DC88 File Offset: 0x0077BE88
		public ISetBattleTagsT AsISetBattleTags()
		{
			return this.As<ISetBattleTagsT>();
		}

		// Token: 0x060374A3 RID: 226467 RVA: 0x0077DC90 File Offset: 0x0077BE90
		public static TExecBattleOptionUnion FromISetBattleTags(ISetBattleTagsT _isetbattletags)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetBattleTags,
				Value = _isetbattletags
			};
		}

		// Token: 0x060374A4 RID: 226468 RVA: 0x0077DCA5 File Offset: 0x0077BEA5
		public ISetMonsterMoveTargetT AsISetMonsterMoveTarget()
		{
			return this.As<ISetMonsterMoveTargetT>();
		}

		// Token: 0x060374A5 RID: 226469 RVA: 0x0077DCAD File Offset: 0x0077BEAD
		public static TExecBattleOptionUnion FromISetMonsterMoveTarget(ISetMonsterMoveTargetT _isetmonstermovetarget)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetMonsterMoveTarget,
				Value = _isetmonstermovetarget
			};
		}

		// Token: 0x060374A6 RID: 226470 RVA: 0x0077DCC2 File Offset: 0x0077BEC2
		public ISetMonsterMoveWithSplineT AsISetMonsterMoveWithSpline()
		{
			return this.As<ISetMonsterMoveWithSplineT>();
		}

		// Token: 0x060374A7 RID: 226471 RVA: 0x0077DCCA File Offset: 0x0077BECA
		public static TExecBattleOptionUnion FromISetMonsterMoveWithSpline(ISetMonsterMoveWithSplineT _isetmonstermovewithspline)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetMonsterMoveWithSpline,
				Value = _isetmonstermovewithspline
			};
		}

		// Token: 0x060374A8 RID: 226472 RVA: 0x0077DCE0 File Offset: 0x0077BEE0
		public static int Pack(FlatBufferBuilder builder, TExecBattleOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TExecBattleOption.IExitMonsterMoveTarget:
				return IExitMonsterMoveTarget.Pack(builder, _o.AsIExitMonsterMoveTarget()).Value;
			case TExecBattleOption.IExitMonsterMoveWithSpline:
				return IExitMonsterMoveWithSpline.Pack(builder, _o.AsIExitMonsterMoveWithSpline()).Value;
			case TExecBattleOption.ISendBattleEvents:
				return ISendBattleEvents.Pack(builder, _o.AsISendBattleEvents()).Value;
			case TExecBattleOption.ISendBattleEventsForMonsterSummon:
				return ISendBattleEventsForMonsterSummon.Pack(builder, _o.AsISendBattleEventsForMonsterSummon()).Value;
			case TExecBattleOption.ISetBattleTags:
				return ISetBattleTags.Pack(builder, _o.AsISetBattleTags()).Value;
			case TExecBattleOption.ISetMonsterMoveTarget:
				return ISetMonsterMoveTarget.Pack(builder, _o.AsISetMonsterMoveTarget()).Value;
			case TExecBattleOption.ISetMonsterMoveWithSpline:
				return ISetMonsterMoveWithSpline.Pack(builder, _o.AsISetMonsterMoveWithSpline()).Value;
			default:
				return 0;
			}
		}
	}
}
