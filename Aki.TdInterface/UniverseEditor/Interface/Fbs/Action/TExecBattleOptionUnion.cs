using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007ECB RID: 32459
	public class TExecBattleOptionUnion
	{
		// Token: 0x1700F255 RID: 62037
		// (get) Token: 0x0603A943 RID: 239939 RVA: 0x007E1E1A File Offset: 0x007E001A
		// (set) Token: 0x0603A944 RID: 239940 RVA: 0x007E1E22 File Offset: 0x007E0022
		public TExecBattleOption Type { get; set; }

		// Token: 0x1700F256 RID: 62038
		// (get) Token: 0x0603A945 RID: 239941 RVA: 0x007E1E2B File Offset: 0x007E002B
		// (set) Token: 0x0603A946 RID: 239942 RVA: 0x007E1E33 File Offset: 0x007E0033
		public object Value { get; set; }

		// Token: 0x0603A947 RID: 239943 RVA: 0x007E1E3C File Offset: 0x007E003C
		public TExecBattleOptionUnion()
		{
			this.Type = TExecBattleOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603A948 RID: 239944 RVA: 0x007E1E52 File Offset: 0x007E0052
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A949 RID: 239945 RVA: 0x007E1E64 File Offset: 0x007E0064
		public IAiAssistCharacterMoveToPointT AsIAiAssistCharacterMoveToPoint()
		{
			return this.As<IAiAssistCharacterMoveToPointT>();
		}

		// Token: 0x0603A94A RID: 239946 RVA: 0x007E1E6C File Offset: 0x007E006C
		public static TExecBattleOptionUnion FromIAiAssistCharacterMoveToPoint(IAiAssistCharacterMoveToPointT _iaiassistcharactermovetopoint)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IAiAssistCharacterMoveToPoint,
				Value = _iaiassistcharactermovetopoint
			};
		}

		// Token: 0x0603A94B RID: 239947 RVA: 0x007E1E81 File Offset: 0x007E0081
		public IAiAssistCharacterStopMoveToPointT AsIAiAssistCharacterStopMoveToPoint()
		{
			return this.As<IAiAssistCharacterStopMoveToPointT>();
		}

		// Token: 0x0603A94C RID: 239948 RVA: 0x007E1E89 File Offset: 0x007E0089
		public static TExecBattleOptionUnion FromIAiAssistCharacterStopMoveToPoint(IAiAssistCharacterStopMoveToPointT _iaiassistcharacterstopmovetopoint)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IAiAssistCharacterStopMoveToPoint,
				Value = _iaiassistcharacterstopmovetopoint
			};
		}

		// Token: 0x0603A94D RID: 239949 RVA: 0x007E1E9E File Offset: 0x007E009E
		public IExitMonsterMoveTargetT AsIExitMonsterMoveTarget()
		{
			return this.As<IExitMonsterMoveTargetT>();
		}

		// Token: 0x0603A94E RID: 239950 RVA: 0x007E1EA6 File Offset: 0x007E00A6
		public static TExecBattleOptionUnion FromIExitMonsterMoveTarget(IExitMonsterMoveTargetT _iexitmonstermovetarget)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IExitMonsterMoveTarget,
				Value = _iexitmonstermovetarget
			};
		}

		// Token: 0x0603A94F RID: 239951 RVA: 0x007E1EBB File Offset: 0x007E00BB
		public IExitMonsterMoveWithSplineT AsIExitMonsterMoveWithSpline()
		{
			return this.As<IExitMonsterMoveWithSplineT>();
		}

		// Token: 0x0603A950 RID: 239952 RVA: 0x007E1EC3 File Offset: 0x007E00C3
		public static TExecBattleOptionUnion FromIExitMonsterMoveWithSpline(IExitMonsterMoveWithSplineT _iexitmonstermovewithspline)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.IExitMonsterMoveWithSpline,
				Value = _iexitmonstermovewithspline
			};
		}

		// Token: 0x0603A951 RID: 239953 RVA: 0x007E1ED8 File Offset: 0x007E00D8
		public ISendBattleEventsT AsISendBattleEvents()
		{
			return this.As<ISendBattleEventsT>();
		}

		// Token: 0x0603A952 RID: 239954 RVA: 0x007E1EE0 File Offset: 0x007E00E0
		public static TExecBattleOptionUnion FromISendBattleEvents(ISendBattleEventsT _isendbattleevents)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISendBattleEvents,
				Value = _isendbattleevents
			};
		}

		// Token: 0x0603A953 RID: 239955 RVA: 0x007E1EF5 File Offset: 0x007E00F5
		public ISendBattleEventsForMonsterSummonT AsISendBattleEventsForMonsterSummon()
		{
			return this.As<ISendBattleEventsForMonsterSummonT>();
		}

		// Token: 0x0603A954 RID: 239956 RVA: 0x007E1EFD File Offset: 0x007E00FD
		public static TExecBattleOptionUnion FromISendBattleEventsForMonsterSummon(ISendBattleEventsForMonsterSummonT _isendbattleeventsformonstersummon)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISendBattleEventsForMonsterSummon,
				Value = _isendbattleeventsformonstersummon
			};
		}

		// Token: 0x0603A955 RID: 239957 RVA: 0x007E1F12 File Offset: 0x007E0112
		public ISetBattleTagsT AsISetBattleTags()
		{
			return this.As<ISetBattleTagsT>();
		}

		// Token: 0x0603A956 RID: 239958 RVA: 0x007E1F1A File Offset: 0x007E011A
		public static TExecBattleOptionUnion FromISetBattleTags(ISetBattleTagsT _isetbattletags)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetBattleTags,
				Value = _isetbattletags
			};
		}

		// Token: 0x0603A957 RID: 239959 RVA: 0x007E1F2F File Offset: 0x007E012F
		public ISetMonsterMoveTargetT AsISetMonsterMoveTarget()
		{
			return this.As<ISetMonsterMoveTargetT>();
		}

		// Token: 0x0603A958 RID: 239960 RVA: 0x007E1F37 File Offset: 0x007E0137
		public static TExecBattleOptionUnion FromISetMonsterMoveTarget(ISetMonsterMoveTargetT _isetmonstermovetarget)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetMonsterMoveTarget,
				Value = _isetmonstermovetarget
			};
		}

		// Token: 0x0603A959 RID: 239961 RVA: 0x007E1F4C File Offset: 0x007E014C
		public ISetMonsterMoveWithSplineT AsISetMonsterMoveWithSpline()
		{
			return this.As<ISetMonsterMoveWithSplineT>();
		}

		// Token: 0x0603A95A RID: 239962 RVA: 0x007E1F54 File Offset: 0x007E0154
		public static TExecBattleOptionUnion FromISetMonsterMoveWithSpline(ISetMonsterMoveWithSplineT _isetmonstermovewithspline)
		{
			return new TExecBattleOptionUnion
			{
				Type = TExecBattleOption.ISetMonsterMoveWithSpline,
				Value = _isetmonstermovewithspline
			};
		}

		// Token: 0x0603A95B RID: 239963 RVA: 0x007E1F6C File Offset: 0x007E016C
		public static int Pack(FlatBufferBuilder builder, TExecBattleOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TExecBattleOption.IAiAssistCharacterMoveToPoint:
				return IAiAssistCharacterMoveToPoint.Pack(builder, _o.AsIAiAssistCharacterMoveToPoint()).Value;
			case TExecBattleOption.IAiAssistCharacterStopMoveToPoint:
				return IAiAssistCharacterStopMoveToPoint.Pack(builder, _o.AsIAiAssistCharacterStopMoveToPoint()).Value;
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
