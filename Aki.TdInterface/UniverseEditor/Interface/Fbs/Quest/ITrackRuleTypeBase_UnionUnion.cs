using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004218 RID: 16920
	public class ITrackRuleTypeBase_UnionUnion
	{
		// Token: 0x1700782D RID: 30765
		// (get) Token: 0x0601900B RID: 102411 RVA: 0x0039910D File Offset: 0x0039730D
		// (set) Token: 0x0601900C RID: 102412 RVA: 0x00399115 File Offset: 0x00397315
		public ITrackRuleTypeBase_Union Type { get; set; }

		// Token: 0x1700782E RID: 30766
		// (get) Token: 0x0601900D RID: 102413 RVA: 0x0039911E File Offset: 0x0039731E
		// (set) Token: 0x0601900E RID: 102414 RVA: 0x00399126 File Offset: 0x00397326
		public object Value { get; set; }

		// Token: 0x0601900F RID: 102415 RVA: 0x0039912F File Offset: 0x0039732F
		public ITrackRuleTypeBase_UnionUnion()
		{
			this.Type = ITrackRuleTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06019010 RID: 102416 RVA: 0x00399145 File Offset: 0x00397345
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06019011 RID: 102417 RVA: 0x00399157 File Offset: 0x00397357
		public ITrackRuleTypeBaseT AsITrackRuleTypeBase()
		{
			return this.As<ITrackRuleTypeBaseT>();
		}

		// Token: 0x06019012 RID: 102418 RVA: 0x0039915F File Offset: 0x0039735F
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleTypeBase(ITrackRuleTypeBaseT _itrackruletypebase)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleTypeBase,
				Value = _itrackruletypebase
			};
		}

		// Token: 0x06019013 RID: 102419 RVA: 0x00399174 File Offset: 0x00397374
		public ITrackRuleFindLastMatchStateT AsITrackRuleFindLastMatchState()
		{
			return this.As<ITrackRuleFindLastMatchStateT>();
		}

		// Token: 0x06019014 RID: 102420 RVA: 0x0039917C File Offset: 0x0039737C
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleFindLastMatchState(ITrackRuleFindLastMatchStateT _itrackrulefindlastmatchstate)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleFindLastMatchState,
				Value = _itrackrulefindlastmatchstate
			};
		}

		// Token: 0x06019015 RID: 102421 RVA: 0x00399191 File Offset: 0x00397391
		public ITrackRuleFindFirstNotMatchStateT AsITrackRuleFindFirstNotMatchState()
		{
			return this.As<ITrackRuleFindFirstNotMatchStateT>();
		}

		// Token: 0x06019016 RID: 102422 RVA: 0x00399199 File Offset: 0x00397399
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleFindFirstNotMatchState(ITrackRuleFindFirstNotMatchStateT _itrackrulefindfirstnotmatchstate)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleFindFirstNotMatchState,
				Value = _itrackrulefindfirstnotmatchstate
			};
		}

		// Token: 0x06019017 RID: 102423 RVA: 0x003991B0 File Offset: 0x003973B0
		public static int Pack(FlatBufferBuilder builder, ITrackRuleTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrackRuleTypeBase_Union.ITrackRuleTypeBase:
				return ITrackRuleTypeBase.Pack(builder, _o.AsITrackRuleTypeBase()).Value;
			case ITrackRuleTypeBase_Union.ITrackRuleFindLastMatchState:
				return ITrackRuleFindLastMatchState.Pack(builder, _o.AsITrackRuleFindLastMatchState()).Value;
			case ITrackRuleTypeBase_Union.ITrackRuleFindFirstNotMatchState:
				return ITrackRuleFindFirstNotMatchState.Pack(builder, _o.AsITrackRuleFindFirstNotMatchState()).Value;
			default:
				return 0;
			}
		}
	}
}
