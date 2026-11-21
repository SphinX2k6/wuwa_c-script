using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0D RID: 31501
	public class ITalkOptionParamType_UnionUnion
	{
		// Token: 0x1700EBFD RID: 60413
		// (get) Token: 0x06038B83 RID: 232323 RVA: 0x007AC2AD File Offset: 0x007AA4AD
		// (set) Token: 0x06038B84 RID: 232324 RVA: 0x007AC2B5 File Offset: 0x007AA4B5
		public ITalkOptionParamType_Union Type { get; set; }

		// Token: 0x1700EBFE RID: 60414
		// (get) Token: 0x06038B85 RID: 232325 RVA: 0x007AC2BE File Offset: 0x007AA4BE
		// (set) Token: 0x06038B86 RID: 232326 RVA: 0x007AC2C6 File Offset: 0x007AA4C6
		public object Value { get; set; }

		// Token: 0x06038B87 RID: 232327 RVA: 0x007AC2CF File Offset: 0x007AA4CF
		public ITalkOptionParamType_UnionUnion()
		{
			this.Type = ITalkOptionParamType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038B88 RID: 232328 RVA: 0x007AC2E5 File Offset: 0x007AA4E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038B89 RID: 232329 RVA: 0x007AC2F7 File Offset: 0x007AA4F7
		public ITalkOptionParamTypeT AsITalkOptionParamType()
		{
			return this.As<ITalkOptionParamTypeT>();
		}

		// Token: 0x06038B8A RID: 232330 RVA: 0x007AC2FF File Offset: 0x007AA4FF
		public static ITalkOptionParamType_UnionUnion FromITalkOptionParamType(ITalkOptionParamTypeT _italkoptionparamtype)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionParamType,
				Value = _italkoptionparamtype
			};
		}

		// Token: 0x06038B8B RID: 232331 RVA: 0x007AC314 File Offset: 0x007AA514
		public ITalkOptionQteSucceedT AsITalkOptionQteSucceed()
		{
			return this.As<ITalkOptionQteSucceedT>();
		}

		// Token: 0x06038B8C RID: 232332 RVA: 0x007AC31C File Offset: 0x007AA51C
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteSucceed(ITalkOptionQteSucceedT _italkoptionqtesucceed)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteSucceed,
				Value = _italkoptionqtesucceed
			};
		}

		// Token: 0x06038B8D RID: 232333 RVA: 0x007AC331 File Offset: 0x007AA531
		public ITalkOptionQteFailedT AsITalkOptionQteFailed()
		{
			return this.As<ITalkOptionQteFailedT>();
		}

		// Token: 0x06038B8E RID: 232334 RVA: 0x007AC339 File Offset: 0x007AA539
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteFailed(ITalkOptionQteFailedT _italkoptionqtefailed)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteFailed,
				Value = _italkoptionqtefailed
			};
		}

		// Token: 0x06038B8F RID: 232335 RVA: 0x007AC34E File Offset: 0x007AA54E
		public ITalkOptionQteSucceedDelayExecT AsITalkOptionQteSucceedDelayExec()
		{
			return this.As<ITalkOptionQteSucceedDelayExecT>();
		}

		// Token: 0x06038B90 RID: 232336 RVA: 0x007AC356 File Offset: 0x007AA556
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteSucceedDelayExec(ITalkOptionQteSucceedDelayExecT _italkoptionqtesucceeddelayexec)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteSucceedDelayExec,
				Value = _italkoptionqtesucceeddelayexec
			};
		}

		// Token: 0x06038B91 RID: 232337 RVA: 0x007AC36B File Offset: 0x007AA56B
		public ITalkOptionQteFailedDelayExecT AsITalkOptionQteFailedDelayExec()
		{
			return this.As<ITalkOptionQteFailedDelayExecT>();
		}

		// Token: 0x06038B92 RID: 232338 RVA: 0x007AC373 File Offset: 0x007AA573
		public static ITalkOptionParamType_UnionUnion FromITalkOptionQteFailedDelayExec(ITalkOptionQteFailedDelayExecT _italkoptionqtefaileddelayexec)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionQteFailedDelayExec,
				Value = _italkoptionqtefaileddelayexec
			};
		}

		// Token: 0x06038B93 RID: 232339 RVA: 0x007AC388 File Offset: 0x007AA588
		public ITalkOptionRogueRandomEventT AsITalkOptionRogueRandomEvent()
		{
			return this.As<ITalkOptionRogueRandomEventT>();
		}

		// Token: 0x06038B94 RID: 232340 RVA: 0x007AC390 File Offset: 0x007AA590
		public static ITalkOptionParamType_UnionUnion FromITalkOptionRogueRandomEvent(ITalkOptionRogueRandomEventT _italkoptionroguerandomevent)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionRogueRandomEvent,
				Value = _italkoptionroguerandomevent
			};
		}

		// Token: 0x06038B95 RID: 232341 RVA: 0x007AC3A5 File Offset: 0x007AA5A5
		public ITalkOptionPhoneMessageEmojiT AsITalkOptionPhoneMessageEmoji()
		{
			return this.As<ITalkOptionPhoneMessageEmojiT>();
		}

		// Token: 0x06038B96 RID: 232342 RVA: 0x007AC3AD File Offset: 0x007AA5AD
		public static ITalkOptionParamType_UnionUnion FromITalkOptionPhoneMessageEmoji(ITalkOptionPhoneMessageEmojiT _italkoptionphonemessageemoji)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionPhoneMessageEmoji,
				Value = _italkoptionphonemessageemoji
			};
		}

		// Token: 0x06038B97 RID: 232343 RVA: 0x007AC3C2 File Offset: 0x007AA5C2
		public ITalkOptionVisualNovelT AsITalkOptionVisualNovel()
		{
			return this.As<ITalkOptionVisualNovelT>();
		}

		// Token: 0x06038B98 RID: 232344 RVA: 0x007AC3CA File Offset: 0x007AA5CA
		public static ITalkOptionParamType_UnionUnion FromITalkOptionVisualNovel(ITalkOptionVisualNovelT _italkoptionvisualnovel)
		{
			return new ITalkOptionParamType_UnionUnion
			{
				Type = ITalkOptionParamType_Union.ITalkOptionVisualNovel,
				Value = _italkoptionvisualnovel
			};
		}

		// Token: 0x06038B99 RID: 232345 RVA: 0x007AC3E0 File Offset: 0x007AA5E0
		public static int Pack(FlatBufferBuilder builder, ITalkOptionParamType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkOptionParamType_Union.ITalkOptionParamType:
				return ITalkOptionParamType.Pack(builder, _o.AsITalkOptionParamType()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteSucceed:
				return ITalkOptionQteSucceed.Pack(builder, _o.AsITalkOptionQteSucceed()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteFailed:
				return ITalkOptionQteFailed.Pack(builder, _o.AsITalkOptionQteFailed()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteSucceedDelayExec:
				return ITalkOptionQteSucceedDelayExec.Pack(builder, _o.AsITalkOptionQteSucceedDelayExec()).Value;
			case ITalkOptionParamType_Union.ITalkOptionQteFailedDelayExec:
				return ITalkOptionQteFailedDelayExec.Pack(builder, _o.AsITalkOptionQteFailedDelayExec()).Value;
			case ITalkOptionParamType_Union.ITalkOptionRogueRandomEvent:
				return ITalkOptionRogueRandomEvent.Pack(builder, _o.AsITalkOptionRogueRandomEvent()).Value;
			case ITalkOptionParamType_Union.ITalkOptionPhoneMessageEmoji:
				return ITalkOptionPhoneMessageEmoji.Pack(builder, _o.AsITalkOptionPhoneMessageEmoji()).Value;
			case ITalkOptionParamType_Union.ITalkOptionVisualNovel:
				return ITalkOptionVisualNovel.Pack(builder, _o.AsITalkOptionVisualNovel()).Value;
			default:
				return 0;
			}
		}
	}
}
