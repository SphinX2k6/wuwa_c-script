using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D80 RID: 28032
	public class IExecBattleActionType_UnionUnion
	{
		// Token: 0x1700CDA4 RID: 52644
		// (get) Token: 0x060305F0 RID: 198128 RVA: 0x00692B49 File Offset: 0x00690D49
		// (set) Token: 0x060305F1 RID: 198129 RVA: 0x00692B51 File Offset: 0x00690D51
		public IExecBattleActionType_Union Type { get; set; }

		// Token: 0x1700CDA5 RID: 52645
		// (get) Token: 0x060305F2 RID: 198130 RVA: 0x00692B5A File Offset: 0x00690D5A
		// (set) Token: 0x060305F3 RID: 198131 RVA: 0x00692B62 File Offset: 0x00690D62
		public object Value { get; set; }

		// Token: 0x060305F4 RID: 198132 RVA: 0x00692B6B File Offset: 0x00690D6B
		public IExecBattleActionType_UnionUnion()
		{
			this.Type = IExecBattleActionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060305F5 RID: 198133 RVA: 0x00692B81 File Offset: 0x00690D81
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060305F6 RID: 198134 RVA: 0x00692B93 File Offset: 0x00690D93
		public IExecBattleActionTypeT AsIExecBattleActionType()
		{
			return this.As<IExecBattleActionTypeT>();
		}

		// Token: 0x060305F7 RID: 198135 RVA: 0x00692B9B File Offset: 0x00690D9B
		public static IExecBattleActionType_UnionUnion FromIExecBattleActionType(IExecBattleActionTypeT _iexecbattleactiontype)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExecBattleActionType,
				Value = _iexecbattleactiontype
			};
		}

		// Token: 0x060305F8 RID: 198136 RVA: 0x00692BB0 File Offset: 0x00690DB0
		public ISetBattleTagsT AsISetBattleTags()
		{
			return this.As<ISetBattleTagsT>();
		}

		// Token: 0x060305F9 RID: 198137 RVA: 0x00692BB8 File Offset: 0x00690DB8
		public static IExecBattleActionType_UnionUnion FromISetBattleTags(ISetBattleTagsT _isetbattletags)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetBattleTags,
				Value = _isetbattletags
			};
		}

		// Token: 0x060305FA RID: 198138 RVA: 0x00692BCD File Offset: 0x00690DCD
		public ISendBattleEventsT AsISendBattleEvents()
		{
			return this.As<ISendBattleEventsT>();
		}

		// Token: 0x060305FB RID: 198139 RVA: 0x00692BD5 File Offset: 0x00690DD5
		public static IExecBattleActionType_UnionUnion FromISendBattleEvents(ISendBattleEventsT _isendbattleevents)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISendBattleEvents,
				Value = _isendbattleevents
			};
		}

		// Token: 0x060305FC RID: 198140 RVA: 0x00692BEA File Offset: 0x00690DEA
		public ISendBattleEventsForMonsterSummonT AsISendBattleEventsForMonsterSummon()
		{
			return this.As<ISendBattleEventsForMonsterSummonT>();
		}

		// Token: 0x060305FD RID: 198141 RVA: 0x00692BF2 File Offset: 0x00690DF2
		public static IExecBattleActionType_UnionUnion FromISendBattleEventsForMonsterSummon(ISendBattleEventsForMonsterSummonT _isendbattleeventsformonstersummon)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISendBattleEventsForMonsterSummon,
				Value = _isendbattleeventsformonstersummon
			};
		}

		// Token: 0x060305FE RID: 198142 RVA: 0x00692C07 File Offset: 0x00690E07
		public ISetMonsterMoveTargetT AsISetMonsterMoveTarget()
		{
			return this.As<ISetMonsterMoveTargetT>();
		}

		// Token: 0x060305FF RID: 198143 RVA: 0x00692C0F File Offset: 0x00690E0F
		public static IExecBattleActionType_UnionUnion FromISetMonsterMoveTarget(ISetMonsterMoveTargetT _isetmonstermovetarget)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetMonsterMoveTarget,
				Value = _isetmonstermovetarget
			};
		}

		// Token: 0x06030600 RID: 198144 RVA: 0x00692C24 File Offset: 0x00690E24
		public IExitMonsterMoveTargetT AsIExitMonsterMoveTarget()
		{
			return this.As<IExitMonsterMoveTargetT>();
		}

		// Token: 0x06030601 RID: 198145 RVA: 0x00692C2C File Offset: 0x00690E2C
		public static IExecBattleActionType_UnionUnion FromIExitMonsterMoveTarget(IExitMonsterMoveTargetT _iexitmonstermovetarget)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExitMonsterMoveTarget,
				Value = _iexitmonstermovetarget
			};
		}

		// Token: 0x06030602 RID: 198146 RVA: 0x00692C41 File Offset: 0x00690E41
		public ISetMonsterMoveWithSplineT AsISetMonsterMoveWithSpline()
		{
			return this.As<ISetMonsterMoveWithSplineT>();
		}

		// Token: 0x06030603 RID: 198147 RVA: 0x00692C49 File Offset: 0x00690E49
		public static IExecBattleActionType_UnionUnion FromISetMonsterMoveWithSpline(ISetMonsterMoveWithSplineT _isetmonstermovewithspline)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.ISetMonsterMoveWithSpline,
				Value = _isetmonstermovewithspline
			};
		}

		// Token: 0x06030604 RID: 198148 RVA: 0x00692C5E File Offset: 0x00690E5E
		public IExitMonsterMoveWithSplineT AsIExitMonsterMoveWithSpline()
		{
			return this.As<IExitMonsterMoveWithSplineT>();
		}

		// Token: 0x06030605 RID: 198149 RVA: 0x00692C66 File Offset: 0x00690E66
		public static IExecBattleActionType_UnionUnion FromIExitMonsterMoveWithSpline(IExitMonsterMoveWithSplineT _iexitmonstermovewithspline)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IExitMonsterMoveWithSpline,
				Value = _iexitmonstermovewithspline
			};
		}

		// Token: 0x06030606 RID: 198150 RVA: 0x00692C7B File Offset: 0x00690E7B
		public IAiAssistCharacterMoveToPointT AsIAiAssistCharacterMoveToPoint()
		{
			return this.As<IAiAssistCharacterMoveToPointT>();
		}

		// Token: 0x06030607 RID: 198151 RVA: 0x00692C83 File Offset: 0x00690E83
		public static IExecBattleActionType_UnionUnion FromIAiAssistCharacterMoveToPoint(IAiAssistCharacterMoveToPointT _iaiassistcharactermovetopoint)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IAiAssistCharacterMoveToPoint,
				Value = _iaiassistcharactermovetopoint
			};
		}

		// Token: 0x06030608 RID: 198152 RVA: 0x00692C99 File Offset: 0x00690E99
		public IAiAssistCharacterStopMoveToPointT AsIAiAssistCharacterStopMoveToPoint()
		{
			return this.As<IAiAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x06030609 RID: 198153 RVA: 0x00692CA1 File Offset: 0x00690EA1
		public static IExecBattleActionType_UnionUnion FromIAiAssistCharacterStopMoveToPoint(IAiAssistCharacterStopMoveToPointT _iaiassistcharacterstopmovetopoint)
		{
			return new IExecBattleActionType_UnionUnion
			{
				Type = IExecBattleActionType_Union.IAiAssistCharacterStopMoveToPoint,
				Value = _iaiassistcharacterstopmovetopoint
			};
		}

		// Token: 0x0603060A RID: 198154 RVA: 0x00692CB8 File Offset: 0x00690EB8
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
			case IExecBattleActionType_Union.IAiAssistCharacterMoveToPoint:
				return IAiAssistCharacterMoveToPoint.Pack(builder, _o.AsIAiAssistCharacterMoveToPoint()).Value;
			case IExecBattleActionType_Union.IAiAssistCharacterStopMoveToPoint:
				return IAiAssistCharacterStopMoveToPoint.Pack(builder, _o.AsIAiAssistCharacterStopMoveToPoint()).Value;
			default:
				return 0;
			}
		}
	}
}
