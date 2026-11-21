using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE0 RID: 32736
	public class TStateOptionUnion
	{
		// Token: 0x1700F30D RID: 62221
		// (get) Token: 0x0603AEF1 RID: 241393 RVA: 0x007EA882 File Offset: 0x007E8A82
		// (set) Token: 0x0603AEF2 RID: 241394 RVA: 0x007EA88A File Offset: 0x007E8A8A
		public TStateOption Type { get; set; }

		// Token: 0x1700F30E RID: 62222
		// (get) Token: 0x0603AEF3 RID: 241395 RVA: 0x007EA893 File Offset: 0x007E8A93
		// (set) Token: 0x0603AEF4 RID: 241396 RVA: 0x007EA89B File Offset: 0x007E8A9B
		public object Value { get; set; }

		// Token: 0x0603AEF5 RID: 241397 RVA: 0x007EA8A4 File Offset: 0x007E8AA4
		public TStateOptionUnion()
		{
			this.Type = TStateOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AEF6 RID: 241398 RVA: 0x007EA8BA File Offset: 0x007E8ABA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AEF7 RID: 241399 RVA: 0x007EA8CC File Offset: 0x007E8ACC
		public INotifyMonsterPerceptionT AsINotifyMonsterPerception()
		{
			return this.As<INotifyMonsterPerceptionT>();
		}

		// Token: 0x0603AEF8 RID: 241400 RVA: 0x007EA8D4 File Offset: 0x007E8AD4
		public static TStateOptionUnion FromINotifyMonsterPerception(INotifyMonsterPerceptionT _inotifymonsterperception)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.INotifyMonsterPerception,
				Value = _inotifymonsterperception
			};
		}

		// Token: 0x0603AEF9 RID: 241401 RVA: 0x007EA8E9 File Offset: 0x007E8AE9
		public INotifyMonsterPlayStandbyTagsT AsINotifyMonsterPlayStandbyTags()
		{
			return this.As<INotifyMonsterPlayStandbyTagsT>();
		}

		// Token: 0x0603AEFA RID: 241402 RVA: 0x007EA8F1 File Offset: 0x007E8AF1
		public static TStateOptionUnion FromINotifyMonsterPlayStandbyTags(INotifyMonsterPlayStandbyTagsT _inotifymonsterplaystandbytags)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.INotifyMonsterPlayStandbyTags,
				Value = _inotifymonsterplaystandbytags
			};
		}

		// Token: 0x0603AEFB RID: 241403 RVA: 0x007EA906 File Offset: 0x007E8B06
		public ISetBattleTagT AsISetBattleTag()
		{
			return this.As<ISetBattleTagT>();
		}

		// Token: 0x0603AEFC RID: 241404 RVA: 0x007EA90E File Offset: 0x007E8B0E
		public static TStateOptionUnion FromISetBattleTag(ISetBattleTagT _isetbattletag)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.ISetBattleTag,
				Value = _isetbattletag
			};
		}

		// Token: 0x0603AEFD RID: 241405 RVA: 0x007EA924 File Offset: 0x007E8B24
		public static int Pack(FlatBufferBuilder builder, TStateOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TStateOption.INotifyMonsterPerception:
				return INotifyMonsterPerception.Pack(builder, _o.AsINotifyMonsterPerception()).Value;
			case TStateOption.INotifyMonsterPlayStandbyTags:
				return INotifyMonsterPlayStandbyTags.Pack(builder, _o.AsINotifyMonsterPlayStandbyTags()).Value;
			case TStateOption.ISetBattleTag:
				return ISetBattleTag.Pack(builder, _o.AsISetBattleTag()).Value;
			default:
				return 0;
			}
		}
	}
}
