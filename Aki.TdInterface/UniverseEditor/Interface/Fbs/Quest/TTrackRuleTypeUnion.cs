using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004327 RID: 17191
	public class TTrackRuleTypeUnion
	{
		// Token: 0x1700797C RID: 31100
		// (get) Token: 0x060197DF RID: 104415 RVA: 0x003A6E64 File Offset: 0x003A5064
		// (set) Token: 0x060197E0 RID: 104416 RVA: 0x003A6E6C File Offset: 0x003A506C
		public TTrackRuleType Type { get; set; }

		// Token: 0x1700797D RID: 31101
		// (get) Token: 0x060197E1 RID: 104417 RVA: 0x003A6E75 File Offset: 0x003A5075
		// (set) Token: 0x060197E2 RID: 104418 RVA: 0x003A6E7D File Offset: 0x003A507D
		public object Value { get; set; }

		// Token: 0x060197E3 RID: 104419 RVA: 0x003A6E86 File Offset: 0x003A5086
		public TTrackRuleTypeUnion()
		{
			this.Type = TTrackRuleType.NONE;
			this.Value = null;
		}

		// Token: 0x060197E4 RID: 104420 RVA: 0x003A6E9C File Offset: 0x003A509C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060197E5 RID: 104421 RVA: 0x003A6EAE File Offset: 0x003A50AE
		public ITrackRuleFindFirstNotMatchStateT AsITrackRuleFindFirstNotMatchState()
		{
			return this.As<ITrackRuleFindFirstNotMatchStateT>();
		}

		// Token: 0x060197E6 RID: 104422 RVA: 0x003A6EB6 File Offset: 0x003A50B6
		public static TTrackRuleTypeUnion FromITrackRuleFindFirstNotMatchState(ITrackRuleFindFirstNotMatchStateT _itrackrulefindfirstnotmatchstate)
		{
			return new TTrackRuleTypeUnion
			{
				Type = TTrackRuleType.ITrackRuleFindFirstNotMatchState,
				Value = _itrackrulefindfirstnotmatchstate
			};
		}

		// Token: 0x060197E7 RID: 104423 RVA: 0x003A6ECB File Offset: 0x003A50CB
		public ITrackRuleFindLastMatchStateT AsITrackRuleFindLastMatchState()
		{
			return this.As<ITrackRuleFindLastMatchStateT>();
		}

		// Token: 0x060197E8 RID: 104424 RVA: 0x003A6ED3 File Offset: 0x003A50D3
		public static TTrackRuleTypeUnion FromITrackRuleFindLastMatchState(ITrackRuleFindLastMatchStateT _itrackrulefindlastmatchstate)
		{
			return new TTrackRuleTypeUnion
			{
				Type = TTrackRuleType.ITrackRuleFindLastMatchState,
				Value = _itrackrulefindlastmatchstate
			};
		}

		// Token: 0x060197E9 RID: 104425 RVA: 0x003A6EE8 File Offset: 0x003A50E8
		public static int Pack(FlatBufferBuilder builder, TTrackRuleTypeUnion _o)
		{
			TTrackRuleType type = _o.Type;
			if (type == TTrackRuleType.ITrackRuleFindFirstNotMatchState)
			{
				return ITrackRuleFindFirstNotMatchState.Pack(builder, _o.AsITrackRuleFindFirstNotMatchState()).Value;
			}
			if (type != TTrackRuleType.ITrackRuleFindLastMatchState)
			{
				return 0;
			}
			return ITrackRuleFindLastMatchState.Pack(builder, _o.AsITrackRuleFindLastMatchState()).Value;
		}
	}
}
