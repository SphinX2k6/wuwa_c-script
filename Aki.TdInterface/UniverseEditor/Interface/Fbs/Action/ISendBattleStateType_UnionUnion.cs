using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007730 RID: 30512
	public class ISendBattleStateType_UnionUnion
	{
		// Token: 0x1700DFB5 RID: 57269
		// (get) Token: 0x0603588B RID: 219275 RVA: 0x0072D10D File Offset: 0x0072B30D
		// (set) Token: 0x0603588C RID: 219276 RVA: 0x0072D115 File Offset: 0x0072B315
		public ISendBattleStateType_Union Type { get; set; }

		// Token: 0x1700DFB6 RID: 57270
		// (get) Token: 0x0603588D RID: 219277 RVA: 0x0072D11E File Offset: 0x0072B31E
		// (set) Token: 0x0603588E RID: 219278 RVA: 0x0072D126 File Offset: 0x0072B326
		public object Value { get; set; }

		// Token: 0x0603588F RID: 219279 RVA: 0x0072D12F File Offset: 0x0072B32F
		public ISendBattleStateType_UnionUnion()
		{
			this.Type = ISendBattleStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035890 RID: 219280 RVA: 0x0072D145 File Offset: 0x0072B345
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035891 RID: 219281 RVA: 0x0072D157 File Offset: 0x0072B357
		public ISendBattleStateTypeT AsISendBattleStateType()
		{
			return this.As<ISendBattleStateTypeT>();
		}

		// Token: 0x06035892 RID: 219282 RVA: 0x0072D15F File Offset: 0x0072B35F
		public static ISendBattleStateType_UnionUnion FromISendBattleStateType(ISendBattleStateTypeT _isendbattlestatetype)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.ISendBattleStateType,
				Value = _isendbattlestatetype
			};
		}

		// Token: 0x06035893 RID: 219283 RVA: 0x0072D174 File Offset: 0x0072B374
		public INotifyMonsterPerceptionT AsINotifyMonsterPerception()
		{
			return this.As<INotifyMonsterPerceptionT>();
		}

		// Token: 0x06035894 RID: 219284 RVA: 0x0072D17C File Offset: 0x0072B37C
		public static ISendBattleStateType_UnionUnion FromINotifyMonsterPerception(INotifyMonsterPerceptionT _inotifymonsterperception)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.INotifyMonsterPerception,
				Value = _inotifymonsterperception
			};
		}

		// Token: 0x06035895 RID: 219285 RVA: 0x0072D191 File Offset: 0x0072B391
		public ISetBattleTagT AsISetBattleTag()
		{
			return this.As<ISetBattleTagT>();
		}

		// Token: 0x06035896 RID: 219286 RVA: 0x0072D199 File Offset: 0x0072B399
		public static ISendBattleStateType_UnionUnion FromISetBattleTag(ISetBattleTagT _isetbattletag)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.ISetBattleTag,
				Value = _isetbattletag
			};
		}

		// Token: 0x06035897 RID: 219287 RVA: 0x0072D1AE File Offset: 0x0072B3AE
		public INotifyMonsterPlayStandbyTagsT AsINotifyMonsterPlayStandbyTags()
		{
			return this.As<INotifyMonsterPlayStandbyTagsT>();
		}

		// Token: 0x06035898 RID: 219288 RVA: 0x0072D1B6 File Offset: 0x0072B3B6
		public static ISendBattleStateType_UnionUnion FromINotifyMonsterPlayStandbyTags(INotifyMonsterPlayStandbyTagsT _inotifymonsterplaystandbytags)
		{
			return new ISendBattleStateType_UnionUnion
			{
				Type = ISendBattleStateType_Union.INotifyMonsterPlayStandbyTags,
				Value = _inotifymonsterplaystandbytags
			};
		}

		// Token: 0x06035899 RID: 219289 RVA: 0x0072D1CC File Offset: 0x0072B3CC
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
