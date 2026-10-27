using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6D RID: 28525
	public class ISendBattleStateType_UnionUnion
	{
		// Token: 0x1700D3E9 RID: 54249
		// (get) Token: 0x0603264D RID: 206413 RVA: 0x006CD8CD File Offset: 0x006CBACD
		// (set) Token: 0x0603264E RID: 206414 RVA: 0x006CD8D5 File Offset: 0x006CBAD5
		public ISendBattleStateType_Union Type { get; set; }

		// Token: 0x1700D3EA RID: 54250
		// (get) Token: 0x0603264F RID: 206415 RVA: 0x006CD8DE File Offset: 0x006CBADE
		// (set) Token: 0x06032650 RID: 206416 RVA: 0x006CD8E6 File Offset: 0x006CBAE6
		public object Value { get; set; }

		// Token: 0x06032651 RID: 206417 RVA: 0x006CD8EF File Offset: 0x006CBAEF
		public ISendBattleStateType_UnionUnion()
		{
			this.Type = ISendBattleStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032652 RID: 206418 RVA: 0x006CD905 File Offset: 0x006CBB05
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032653 RID: 206419 RVA: 0x006CD917 File Offset: 0x006CBB17
		public ISendBattleStateTypeT AsISendBattleStateType()
		{
			return this.As<ISendBattleStateTypeT>();
		}

		// Token: 0x06032654 RID: 206420 RVA: 0x006CD91F File Offset: 0x006CBB1F
		public static ISendBattleStateType_UnionUnion FromISendBattleStateType(ISendBattleStateTypeT _isendbattlestatetype)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.ISendBattleStateType,
				Value = _isendbattlestatetype
			};
		}

		// Token: 0x06032655 RID: 206421 RVA: 0x006CD934 File Offset: 0x006CBB34
		public INotifyMonsterPerceptionT AsINotifyMonsterPerception()
		{
			return this.As<INotifyMonsterPerceptionT>();
		}

		// Token: 0x06032656 RID: 206422 RVA: 0x006CD93C File Offset: 0x006CBB3C
		public static ISendBattleStateType_UnionUnion FromINotifyMonsterPerception(INotifyMonsterPerceptionT _inotifymonsterperception)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.INotifyMonsterPerception,
				Value = _inotifymonsterperception
			};
		}

		// Token: 0x06032657 RID: 206423 RVA: 0x006CD951 File Offset: 0x006CBB51
		public ISetBattleTagT AsISetBattleTag()
		{
			return this.As<ISetBattleTagT>();
		}

		// Token: 0x06032658 RID: 206424 RVA: 0x006CD959 File Offset: 0x006CBB59
		public static ISendBattleStateType_UnionUnion FromISetBattleTag(ISetBattleTagT _isetbattletag)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.ISetBattleTag,
				Value = _isetbattletag
			};
		}

		// Token: 0x06032659 RID: 206425 RVA: 0x006CD96E File Offset: 0x006CBB6E
		public INotifyMonsterPlayStandbyTagsT AsINotifyMonsterPlayStandbyTags()
		{
			return this.As<INotifyMonsterPlayStandbyTagsT>();
		}

		// Token: 0x0603265A RID: 206426 RVA: 0x006CD976 File Offset: 0x006CBB76
		public static ISendBattleStateType_UnionUnion FromINotifyMonsterPlayStandbyTags(INotifyMonsterPlayStandbyTagsT _inotifymonsterplaystandbytags)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.INotifyMonsterPlayStandbyTags,
				Value = _inotifymonsterplaystandbytags
			};
		}

		// Token: 0x0603265B RID: 206427 RVA: 0x006CD98C File Offset: 0x006CBB8C
		public static int Pack(FlatBufferBuilder builder, ISendBattleStateType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISendBattleStateType_Union.ISendBattleStateType:
				return ISendBattleStateType.Pack(builder, _o.AsISendBattleStateType()).Value;
			case ISendBattleStateType_Union.INotifyMonsterPerception:
				return INotifyMonsterPerception.Pack(builder, _o.AsINotifyMonsterPerception()).Value;
			case ISendBattleStateType_Union.ISetBattleTag:
				return ISetBattleTag.Pack(builder, _o.AsISetBattleTag()).Value;
			case ISendBattleStateType_Union.INotifyMonsterPlayStandbyTags:
				return INotifyMonsterPlayStandbyTags.Pack(builder, _o.AsINotifyMonsterPlayStandbyTags()).Value;
			default:
				return 0;
			}
		}
	}
}
