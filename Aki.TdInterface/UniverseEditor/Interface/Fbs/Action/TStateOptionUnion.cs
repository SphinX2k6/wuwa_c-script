using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077A8 RID: 30632
	public class TStateOptionUnion
	{
		// Token: 0x1700E6B3 RID: 59059
		// (get) Token: 0x06037970 RID: 227696 RVA: 0x007852B0 File Offset: 0x007834B0
		// (set) Token: 0x06037971 RID: 227697 RVA: 0x007852B8 File Offset: 0x007834B8
		public TStateOption Type { get; set; }

		// Token: 0x1700E6B4 RID: 59060
		// (get) Token: 0x06037972 RID: 227698 RVA: 0x007852C1 File Offset: 0x007834C1
		// (set) Token: 0x06037973 RID: 227699 RVA: 0x007852C9 File Offset: 0x007834C9
		public object Value { get; set; }

		// Token: 0x06037974 RID: 227700 RVA: 0x007852D2 File Offset: 0x007834D2
		public TStateOptionUnion()
		{
			this.Type = TStateOption.NONE;
			this.Value = null;
		}

		// Token: 0x06037975 RID: 227701 RVA: 0x007852E8 File Offset: 0x007834E8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037976 RID: 227702 RVA: 0x007852FA File Offset: 0x007834FA
		public INotifyMonsterPerceptionT AsINotifyMonsterPerception()
		{
			return this.As<INotifyMonsterPerceptionT>();
		}

		// Token: 0x06037977 RID: 227703 RVA: 0x00785302 File Offset: 0x00783502
		public static TStateOptionUnion FromINotifyMonsterPerception(INotifyMonsterPerceptionT _inotifymonsterperception)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.INotifyMonsterPerception,
				Value = _inotifymonsterperception
			};
		}

		// Token: 0x06037978 RID: 227704 RVA: 0x00785317 File Offset: 0x00783517
		public INotifyMonsterPlayStandbyTagsT AsINotifyMonsterPlayStandbyTags()
		{
			return this.As<INotifyMonsterPlayStandbyTagsT>();
		}

		// Token: 0x06037979 RID: 227705 RVA: 0x0078531F File Offset: 0x0078351F
		public static TStateOptionUnion FromINotifyMonsterPlayStandbyTags(INotifyMonsterPlayStandbyTagsT _inotifymonsterplaystandbytags)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.INotifyMonsterPlayStandbyTags,
				Value = _inotifymonsterplaystandbytags
			};
		}

		// Token: 0x0603797A RID: 227706 RVA: 0x00785334 File Offset: 0x00783534
		public ISetBattleTagT AsISetBattleTag()
		{
			return this.As<ISetBattleTagT>();
		}

		// Token: 0x0603797B RID: 227707 RVA: 0x0078533C File Offset: 0x0078353C
		public static TStateOptionUnion FromISetBattleTag(ISetBattleTagT _isetbattletag)
		{
			return new TStateOptionUnion
			{
				Type = TStateOption.ISetBattleTag,
				Value = _isetbattletag
			};
		}

		// Token: 0x0603797C RID: 227708 RVA: 0x00785354 File Offset: 0x00783554
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
