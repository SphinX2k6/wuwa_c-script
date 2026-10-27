using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006700 RID: 26368
	public class IExecBattleActionType_UnionUnion
	{
		// Token: 0x1700C3EE RID: 50158
		// (get) Token: 0x0602DDB1 RID: 187825 RVA: 0x00645525 File Offset: 0x00643725
		// (set) Token: 0x0602DDB2 RID: 187826 RVA: 0x0064552D File Offset: 0x0064372D
		public IExecBattleActionType_Union Type { get; set; }

		// Token: 0x1700C3EF RID: 50159
		// (get) Token: 0x0602DDB3 RID: 187827 RVA: 0x00645536 File Offset: 0x00643736
		// (set) Token: 0x0602DDB4 RID: 187828 RVA: 0x0064553E File Offset: 0x0064373E
		public object Value { get; set; }

		// Token: 0x0602DDB5 RID: 187829 RVA: 0x00645547 File Offset: 0x00643747
		public IExecBattleActionType_UnionUnion()
		{
			this.Type = IExecBattleActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DDB6 RID: 187830 RVA: 0x0064555D File Offset: 0x0064375D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DDB7 RID: 187831 RVA: 0x0064556F File Offset: 0x0064376F
		public IExecBattleActionTypeT AsIExecBattleActionType()
		{
			return this.As<IExecBattleActionTypeT>();
		}

		// Token: 0x0602DDB8 RID: 187832 RVA: 0x00645577 File Offset: 0x00643777
		public static IExecBattleActionType_UnionUnion FromIExecBattleActionType(IExecBattleActionTypeT _iexecbattleactiontype)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExecBattleActionType,
				Value = _iexecbattleactiontype
			};
		}

		// Token: 0x0602DDB9 RID: 187833 RVA: 0x0064558C File Offset: 0x0064378C
		public ISetBattleTagsT AsISetBattleTags()
		{
			return this.As<ISetBattleTagsT>();
		}

		// Token: 0x0602DDBA RID: 187834 RVA: 0x00645594 File Offset: 0x00643794
		public static IExecBattleActionType_UnionUnion FromISetBattleTags(ISetBattleTagsT _isetbattletags)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetBattleTags,
				Value = _isetbattletags
			};
		}

		// Token: 0x0602DDBB RID: 187835 RVA: 0x006455A9 File Offset: 0x006437A9
		public ISendBattleEventsT AsISendBattleEvents()
		{
			return this.As<ISendBattleEventsT>();
		}

		// Token: 0x0602DDBC RID: 187836 RVA: 0x006455B1 File Offset: 0x006437B1
		public static IExecBattleActionType_UnionUnion FromISendBattleEvents(ISendBattleEventsT _isendbattleevents)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISendBattleEvents,
				Value = _isendbattleevents
			};
		}

		// Token: 0x0602DDBD RID: 187837 RVA: 0x006455C6 File Offset: 0x006437C6
		public ISendBattleEventsForMonsterSummonT AsISendBattleEventsForMonsterSummon()
		{
			return this.As<ISendBattleEventsForMonsterSummonT>();
		}

		// Token: 0x0602DDBE RID: 187838 RVA: 0x006455CE File Offset: 0x006437CE
		public static IExecBattleActionType_UnionUnion FromISendBattleEventsForMonsterSummon(ISendBattleEventsForMonsterSummonT _isendbattleeventsformonstersummon)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISendBattleEventsForMonsterSummon,
				Value = _isendbattleeventsformonstersummon
			};
		}

		// Token: 0x0602DDBF RID: 187839 RVA: 0x006455E3 File Offset: 0x006437E3
		public ISetMonsterMoveTargetT AsISetMonsterMoveTarget()
		{
			return this.As<ISetMonsterMoveTargetT>();
		}

		// Token: 0x0602DDC0 RID: 187840 RVA: 0x006455EB File Offset: 0x006437EB
		public static IExecBattleActionType_UnionUnion FromISetMonsterMoveTarget(ISetMonsterMoveTargetT _isetmonstermovetarget)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetMonsterMoveTarget,
				Value = _isetmonstermovetarget
			};
		}

		// Token: 0x0602DDC1 RID: 187841 RVA: 0x00645600 File Offset: 0x00643800
		public IExitMonsterMoveTargetT AsIExitMonsterMoveTarget()
		{
			return this.As<IExitMonsterMoveTargetT>();
		}

		// Token: 0x0602DDC2 RID: 187842 RVA: 0x00645608 File Offset: 0x00643808
		public static IExecBattleActionType_UnionUnion FromIExitMonsterMoveTarget(IExitMonsterMoveTargetT _iexitmonstermovetarget)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExitMonsterMoveTarget,
				Value = _iexitmonstermovetarget
			};
		}

		// Token: 0x0602DDC3 RID: 187843 RVA: 0x0064561D File Offset: 0x0064381D
		public ISetMonsterMoveWithSplineT AsISetMonsterMoveWithSpline()
		{
			return this.As<ISetMonsterMoveWithSplineT>();
		}

		// Token: 0x0602DDC4 RID: 187844 RVA: 0x00645625 File Offset: 0x00643825
		public static IExecBattleActionType_UnionUnion FromISetMonsterMoveWithSpline(ISetMonsterMoveWithSplineT _isetmonstermovewithspline)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetMonsterMoveWithSpline,
				Value = _isetmonstermovewithspline
			};
		}

		// Token: 0x0602DDC5 RID: 187845 RVA: 0x0064563A File Offset: 0x0064383A
		public IExitMonsterMoveWithSplineT AsIExitMonsterMoveWithSpline()
		{
			return this.As<IExitMonsterMoveWithSplineT>();
		}

		// Token: 0x0602DDC6 RID: 187846 RVA: 0x00645642 File Offset: 0x00643842
		public static IExecBattleActionType_UnionUnion FromIExitMonsterMoveWithSpline(IExitMonsterMoveWithSplineT _iexitmonstermovewithspline)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExitMonsterMoveWithSpline,
				Value = _iexitmonstermovewithspline
			};
		}

		// Token: 0x0602DDC7 RID: 187847 RVA: 0x00645658 File Offset: 0x00643858
		public static int Pack(FlatBufferBuilder builder, IExecBattleActionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExecBattleActionType_Union.IExecBattleActionType:
				return IExecBattleActionType.Pack(builder, _o.AsIExecBattleActionType()).Value;
			case IExecBattleActionType_Union.ISetBattleTags:
				return ISetBattleTags.Pack(builder, _o.AsISetBattleTags()).Value;
			case IExecBattleActionType_Union.ISendBattleEvents:
				return ISendBattleEvents.Pack(builder, _o.AsISendBattleEvents()).Value;
			case IExecBattleActionType_Union.ISendBattleEventsForMonsterSummon:
				return ISendBattleEventsForMonsterSummon.Pack(builder, _o.AsISendBattleEventsForMonsterSummon()).Value;
			case IExecBattleActionType_Union.ISetMonsterMoveTarget:
				return ISetMonsterMoveTarget.Pack(builder, _o.AsISetMonsterMoveTarget()).Value;
			case IExecBattleActionType_Union.IExitMonsterMoveTarget:
				return IExitMonsterMoveTarget.Pack(builder, _o.AsIExitMonsterMoveTarget()).Value;
			case IExecBattleActionType_Union.ISetMonsterMoveWithSpline:
				return ISetMonsterMoveWithSpline.Pack(builder, _o.AsISetMonsterMoveWithSpline()).Value;
			case IExecBattleActionType_Union.IExitMonsterMoveWithSpline:
				return IExitMonsterMoveWithSpline.Pack(builder, _o.AsIExitMonsterMoveWithSpline()).Value;
			default:
				return 0;
			}
		}
	}
}
