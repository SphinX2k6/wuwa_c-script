using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008001 RID: 32769
	public class TTalkOptionParamUnion
	{
		// Token: 0x1700F323 RID: 62243
		// (get) Token: 0x0603AF8B RID: 241547 RVA: 0x007EB680 File Offset: 0x007E9880
		// (set) Token: 0x0603AF8C RID: 241548 RVA: 0x007EB688 File Offset: 0x007E9888
		public TTalkOptionParam Type { get; set; }

		// Token: 0x1700F324 RID: 62244
		// (get) Token: 0x0603AF8D RID: 241549 RVA: 0x007EB691 File Offset: 0x007E9891
		// (set) Token: 0x0603AF8E RID: 241550 RVA: 0x007EB699 File Offset: 0x007E9899
		public object Value { get; set; }

		// Token: 0x0603AF8F RID: 241551 RVA: 0x007EB6A2 File Offset: 0x007E98A2
		public TTalkOptionParamUnion()
		{
			this.Type = TTalkOptionParam.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF90 RID: 241552 RVA: 0x007EB6B8 File Offset: 0x007E98B8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF91 RID: 241553 RVA: 0x007EB6CA File Offset: 0x007E98CA
		public ITalkOptionPhoneMessageEmojiT AsITalkOptionPhoneMessageEmoji()
		{
			return this.As<ITalkOptionPhoneMessageEmojiT>();
		}

		// Token: 0x0603AF92 RID: 241554 RVA: 0x007EB6D2 File Offset: 0x007E98D2
		public static TTalkOptionParamUnion FromITalkOptionPhoneMessageEmoji(ITalkOptionPhoneMessageEmojiT _italkoptionphonemessageemoji)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionPhoneMessageEmoji,
				Value = _italkoptionphonemessageemoji
			};
		}

		// Token: 0x0603AF93 RID: 241555 RVA: 0x007EB6E7 File Offset: 0x007E98E7
		public ITalkOptionQteFailedT AsITalkOptionQteFailed()
		{
			return this.As<ITalkOptionQteFailedT>();
		}

		// Token: 0x0603AF94 RID: 241556 RVA: 0x007EB6EF File Offset: 0x007E98EF
		public static TTalkOptionParamUnion FromITalkOptionQteFailed(ITalkOptionQteFailedT _italkoptionqtefailed)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteFailed,
				Value = _italkoptionqtefailed
			};
		}

		// Token: 0x0603AF95 RID: 241557 RVA: 0x007EB704 File Offset: 0x007E9904
		public ITalkOptionQteFailedDelayExecT AsITalkOptionQteFailedDelayExec()
		{
			return this.As<ITalkOptionQteFailedDelayExecT>();
		}

		// Token: 0x0603AF96 RID: 241558 RVA: 0x007EB70C File Offset: 0x007E990C
		public static TTalkOptionParamUnion FromITalkOptionQteFailedDelayExec(ITalkOptionQteFailedDelayExecT _italkoptionqtefaileddelayexec)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteFailedDelayExec,
				Value = _italkoptionqtefaileddelayexec
			};
		}

		// Token: 0x0603AF97 RID: 241559 RVA: 0x007EB721 File Offset: 0x007E9921
		public ITalkOptionQteSucceedT AsITalkOptionQteSucceed()
		{
			return this.As<ITalkOptionQteSucceedT>();
		}

		// Token: 0x0603AF98 RID: 241560 RVA: 0x007EB729 File Offset: 0x007E9929
		public static TTalkOptionParamUnion FromITalkOptionQteSucceed(ITalkOptionQteSucceedT _italkoptionqtesucceed)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteSucceed,
				Value = _italkoptionqtesucceed
			};
		}

		// Token: 0x0603AF99 RID: 241561 RVA: 0x007EB73E File Offset: 0x007E993E
		public ITalkOptionQteSucceedDelayExecT AsITalkOptionQteSucceedDelayExec()
		{
			return this.As<ITalkOptionQteSucceedDelayExecT>();
		}

		// Token: 0x0603AF9A RID: 241562 RVA: 0x007EB746 File Offset: 0x007E9946
		public static TTalkOptionParamUnion FromITalkOptionQteSucceedDelayExec(ITalkOptionQteSucceedDelayExecT _italkoptionqtesucceeddelayexec)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteSucceedDelayExec,
				Value = _italkoptionqtesucceeddelayexec
			};
		}

		// Token: 0x0603AF9B RID: 241563 RVA: 0x007EB75B File Offset: 0x007E995B
		public ITalkOptionRogueRandomEventT AsITalkOptionRogueRandomEvent()
		{
			return this.As<ITalkOptionRogueRandomEventT>();
		}

		// Token: 0x0603AF9C RID: 241564 RVA: 0x007EB763 File Offset: 0x007E9963
		public static TTalkOptionParamUnion FromITalkOptionRogueRandomEvent(ITalkOptionRogueRandomEventT _italkoptionroguerandomevent)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionRogueRandomEvent,
				Value = _italkoptionroguerandomevent
			};
		}

		// Token: 0x0603AF9D RID: 241565 RVA: 0x007EB778 File Offset: 0x007E9978
		public ITalkOptionVisualNovelT AsITalkOptionVisualNovel()
		{
			return this.As<ITalkOptionVisualNovelT>();
		}

		// Token: 0x0603AF9E RID: 241566 RVA: 0x007EB780 File Offset: 0x007E9980
		public static TTalkOptionParamUnion FromITalkOptionVisualNovel(ITalkOptionVisualNovelT _italkoptionvisualnovel)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionVisualNovel,
				Value = _italkoptionvisualnovel
			};
		}

		// Token: 0x0603AF9F RID: 241567 RVA: 0x007EB798 File Offset: 0x007E9998
		public static int Pack(FlatBufferBuilder builder, TTalkOptionParamUnion _o)
		{
			switch (_o.Type)
			{
			case TTalkOptionParam.ITalkOptionPhoneMessageEmoji:
				return ITalkOptionPhoneMessageEmoji.Pack(builder, _o.AsITalkOptionPhoneMessageEmoji()).Value;
			case TTalkOptionParam.ITalkOptionQteFailed:
				return ITalkOptionQteFailed.Pack(builder, _o.AsITalkOptionQteFailed()).Value;
			case TTalkOptionParam.ITalkOptionQteFailedDelayExec:
				return ITalkOptionQteFailedDelayExec.Pack(builder, _o.AsITalkOptionQteFailedDelayExec()).Value;
			case TTalkOptionParam.ITalkOptionQteSucceed:
				return ITalkOptionQteSucceed.Pack(builder, _o.AsITalkOptionQteSucceed()).Value;
			case TTalkOptionParam.ITalkOptionQteSucceedDelayExec:
				return ITalkOptionQteSucceedDelayExec.Pack(builder, _o.AsITalkOptionQteSucceedDelayExec()).Value;
			case TTalkOptionParam.ITalkOptionRogueRandomEvent:
				return ITalkOptionRogueRandomEvent.Pack(builder, _o.AsITalkOptionRogueRandomEvent()).Value;
			case TTalkOptionParam.ITalkOptionVisualNovel:
				return ITalkOptionVisualNovel.Pack(builder, _o.AsITalkOptionVisualNovel()).Value;
			default:
				return 0;
			}
		}
	}
}
