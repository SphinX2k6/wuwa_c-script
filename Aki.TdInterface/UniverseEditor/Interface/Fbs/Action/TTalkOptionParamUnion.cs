using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C9 RID: 30665
	public class TTalkOptionParamUnion
	{
		// Token: 0x1700E6C9 RID: 59081
		// (get) Token: 0x06037A06 RID: 227846 RVA: 0x0078601E File Offset: 0x0078421E
		// (set) Token: 0x06037A07 RID: 227847 RVA: 0x00786026 File Offset: 0x00784226
		public TTalkOptionParam Type { get; set; }

		// Token: 0x1700E6CA RID: 59082
		// (get) Token: 0x06037A08 RID: 227848 RVA: 0x0078602F File Offset: 0x0078422F
		// (set) Token: 0x06037A09 RID: 227849 RVA: 0x00786037 File Offset: 0x00784237
		public object Value { get; set; }

		// Token: 0x06037A0A RID: 227850 RVA: 0x00786040 File Offset: 0x00784240
		public TTalkOptionParamUnion()
		{
			this.Type = TTalkOptionParam.NONE;
			this.Value = null;
		}

		// Token: 0x06037A0B RID: 227851 RVA: 0x00786056 File Offset: 0x00784256
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A0C RID: 227852 RVA: 0x00786068 File Offset: 0x00784268
		public ITalkOptionPhoneMessageEmojiT AsITalkOptionPhoneMessageEmoji()
		{
			return this.As<ITalkOptionPhoneMessageEmojiT>();
		}

		// Token: 0x06037A0D RID: 227853 RVA: 0x00786070 File Offset: 0x00784270
		public static TTalkOptionParamUnion FromITalkOptionPhoneMessageEmoji(ITalkOptionPhoneMessageEmojiT _italkoptionphonemessageemoji)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionPhoneMessageEmoji,
				Value = _italkoptionphonemessageemoji
			};
		}

		// Token: 0x06037A0E RID: 227854 RVA: 0x00786085 File Offset: 0x00784285
		public ITalkOptionQteFailedT AsITalkOptionQteFailed()
		{
			return this.As<ITalkOptionQteFailedT>();
		}

		// Token: 0x06037A0F RID: 227855 RVA: 0x0078608D File Offset: 0x0078428D
		public static TTalkOptionParamUnion FromITalkOptionQteFailed(ITalkOptionQteFailedT _italkoptionqtefailed)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteFailed,
				Value = _italkoptionqtefailed
			};
		}

		// Token: 0x06037A10 RID: 227856 RVA: 0x007860A2 File Offset: 0x007842A2
		public ITalkOptionQteFailedDelayExecT AsITalkOptionQteFailedDelayExec()
		{
			return this.As<ITalkOptionQteFailedDelayExecT>();
		}

		// Token: 0x06037A11 RID: 227857 RVA: 0x007860AA File Offset: 0x007842AA
		public static TTalkOptionParamUnion FromITalkOptionQteFailedDelayExec(ITalkOptionQteFailedDelayExecT _italkoptionqtefaileddelayexec)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteFailedDelayExec,
				Value = _italkoptionqtefaileddelayexec
			};
		}

		// Token: 0x06037A12 RID: 227858 RVA: 0x007860BF File Offset: 0x007842BF
		public ITalkOptionQteSucceedT AsITalkOptionQteSucceed()
		{
			return this.As<ITalkOptionQteSucceedT>();
		}

		// Token: 0x06037A13 RID: 227859 RVA: 0x007860C7 File Offset: 0x007842C7
		public static TTalkOptionParamUnion FromITalkOptionQteSucceed(ITalkOptionQteSucceedT _italkoptionqtesucceed)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteSucceed,
				Value = _italkoptionqtesucceed
			};
		}

		// Token: 0x06037A14 RID: 227860 RVA: 0x007860DC File Offset: 0x007842DC
		public ITalkOptionQteSucceedDelayExecT AsITalkOptionQteSucceedDelayExec()
		{
			return this.As<ITalkOptionQteSucceedDelayExecT>();
		}

		// Token: 0x06037A15 RID: 227861 RVA: 0x007860E4 File Offset: 0x007842E4
		public static TTalkOptionParamUnion FromITalkOptionQteSucceedDelayExec(ITalkOptionQteSucceedDelayExecT _italkoptionqtesucceeddelayexec)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionQteSucceedDelayExec,
				Value = _italkoptionqtesucceeddelayexec
			};
		}

		// Token: 0x06037A16 RID: 227862 RVA: 0x007860F9 File Offset: 0x007842F9
		public ITalkOptionRogueRandomEventT AsITalkOptionRogueRandomEvent()
		{
			return this.As<ITalkOptionRogueRandomEventT>();
		}

		// Token: 0x06037A17 RID: 227863 RVA: 0x00786101 File Offset: 0x00784301
		public static TTalkOptionParamUnion FromITalkOptionRogueRandomEvent(ITalkOptionRogueRandomEventT _italkoptionroguerandomevent)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionRogueRandomEvent,
				Value = _italkoptionroguerandomevent
			};
		}

		// Token: 0x06037A18 RID: 227864 RVA: 0x00786116 File Offset: 0x00784316
		public ITalkOptionVisualNovelT AsITalkOptionVisualNovel()
		{
			return this.As<ITalkOptionVisualNovelT>();
		}

		// Token: 0x06037A19 RID: 227865 RVA: 0x0078611E File Offset: 0x0078431E
		public static TTalkOptionParamUnion FromITalkOptionVisualNovel(ITalkOptionVisualNovelT _italkoptionvisualnovel)
		{
			return new TTalkOptionParamUnion
			{
				Type = TTalkOptionParam.ITalkOptionVisualNovel,
				Value = _italkoptionvisualnovel
			};
		}

		// Token: 0x06037A1A RID: 227866 RVA: 0x00786134 File Offset: 0x00784334
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
