using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004789 RID: 18313
	public class TTrackRuleTypeUnion
	{
		// Token: 0x17007FB1 RID: 32689
		// (get) Token: 0x0601AF6D RID: 110445 RVA: 0x003D288C File Offset: 0x003D0A8C
		// (set) Token: 0x0601AF6E RID: 110446 RVA: 0x003D2894 File Offset: 0x003D0A94
		public TTrackRuleType Type { get; set; }

		// Token: 0x17007FB2 RID: 32690
		// (get) Token: 0x0601AF6F RID: 110447 RVA: 0x003D289D File Offset: 0x003D0A9D
		// (set) Token: 0x0601AF70 RID: 110448 RVA: 0x003D28A5 File Offset: 0x003D0AA5
		public object Value { get; set; }

		// Token: 0x0601AF71 RID: 110449 RVA: 0x003D28AE File Offset: 0x003D0AAE
		public TTrackRuleTypeUnion()
		{
			this.Type = TTrackRuleType.NONE;
			this.Value = null;
		}

		// Token: 0x0601AF72 RID: 110450 RVA: 0x003D28C4 File Offset: 0x003D0AC4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601AF73 RID: 110451 RVA: 0x003D28D6 File Offset: 0x003D0AD6
		public ITrackRuleFindFirstNotMatchStateT AsITrackRuleFindFirstNotMatchState()
		{
			return this.As<ITrackRuleFindFirstNotMatchStateT>();
		}

		// Token: 0x0601AF74 RID: 110452 RVA: 0x003D28DE File Offset: 0x003D0ADE
		public static TTrackRuleTypeUnion FromITrackRuleFindFirstNotMatchState(ITrackRuleFindFirstNotMatchStateT _itrackrulefindfirstnotmatchstate)
		{
			return new TTrackRuleTypeUnion
			{
				Type = TTrackRuleType.ITrackRuleFindFirstNotMatchState,
				Value = _itrackrulefindfirstnotmatchstate
			};
		}

		// Token: 0x0601AF75 RID: 110453 RVA: 0x003D28F3 File Offset: 0x003D0AF3
		public ITrackRuleFindLastMatchStateT AsITrackRuleFindLastMatchState()
		{
			return this.As<ITrackRuleFindLastMatchStateT>();
		}

		// Token: 0x0601AF76 RID: 110454 RVA: 0x003D28FB File Offset: 0x003D0AFB
		public static TTrackRuleTypeUnion FromITrackRuleFindLastMatchState(ITrackRuleFindLastMatchStateT _itrackrulefindlastmatchstate)
		{
			return new TTrackRuleTypeUnion
			{
				Type = TTrackRuleType.ITrackRuleFindLastMatchState,
				Value = _itrackrulefindlastmatchstate
			};
		}

		// Token: 0x0601AF77 RID: 110455 RVA: 0x003D2910 File Offset: 0x003D0B10
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
