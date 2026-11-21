using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004674 RID: 18036
	public class ITrackRuleTypeBase_UnionUnion
	{
		// Token: 0x17007E5E RID: 32350
		// (get) Token: 0x0601A777 RID: 108407 RVA: 0x003C47E5 File Offset: 0x003C29E5
		// (set) Token: 0x0601A778 RID: 108408 RVA: 0x003C47ED File Offset: 0x003C29ED
		public ITrackRuleTypeBase_Union Type { get; set; }

		// Token: 0x17007E5F RID: 32351
		// (get) Token: 0x0601A779 RID: 108409 RVA: 0x003C47F6 File Offset: 0x003C29F6
		// (set) Token: 0x0601A77A RID: 108410 RVA: 0x003C47FE File Offset: 0x003C29FE
		public object Value { get; set; }

		// Token: 0x0601A77B RID: 108411 RVA: 0x003C4807 File Offset: 0x003C2A07
		public ITrackRuleTypeBase_UnionUnion()
		{
			this.Type = ITrackRuleTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601A77C RID: 108412 RVA: 0x003C481D File Offset: 0x003C2A1D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601A77D RID: 108413 RVA: 0x003C482F File Offset: 0x003C2A2F
		public ITrackRuleTypeBaseT AsITrackRuleTypeBase()
		{
			return this.As<ITrackRuleTypeBaseT>();
		}

		// Token: 0x0601A77E RID: 108414 RVA: 0x003C4837 File Offset: 0x003C2A37
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleTypeBase(ITrackRuleTypeBaseT _itrackruletypebase)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleTypeBase,
				Value = _itrackruletypebase
			};
		}

		// Token: 0x0601A77F RID: 108415 RVA: 0x003C484C File Offset: 0x003C2A4C
		public ITrackRuleFindLastMatchStateT AsITrackRuleFindLastMatchState()
		{
			return this.As<ITrackRuleFindLastMatchStateT>();
		}

		// Token: 0x0601A780 RID: 108416 RVA: 0x003C4854 File Offset: 0x003C2A54
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleFindLastMatchState(ITrackRuleFindLastMatchStateT _itrackrulefindlastmatchstate)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleFindLastMatchState,
				Value = _itrackrulefindlastmatchstate
			};
		}

		// Token: 0x0601A781 RID: 108417 RVA: 0x003C4869 File Offset: 0x003C2A69
		public ITrackRuleFindFirstNotMatchStateT AsITrackRuleFindFirstNotMatchState()
		{
			return this.As<ITrackRuleFindFirstNotMatchStateT>();
		}

		// Token: 0x0601A782 RID: 108418 RVA: 0x003C4871 File Offset: 0x003C2A71
		public static ITrackRuleTypeBase_UnionUnion FromITrackRuleFindFirstNotMatchState(ITrackRuleFindFirstNotMatchStateT _itrackrulefindfirstnotmatchstate)
		{
			return new ITrackRuleTypeBase_UnionUnion
			{
				Type = ITrackRuleTypeBase_Union.ITrackRuleFindFirstNotMatchState,
				Value = _itrackrulefindfirstnotmatchstate
			};
		}

		// Token: 0x0601A783 RID: 108419 RVA: 0x003C4888 File Offset: 0x003C2A88
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
