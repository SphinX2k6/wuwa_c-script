using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FFE RID: 32766
	public class TTalkItemStyleUnion
	{
		// Token: 0x1700F321 RID: 62241
		// (get) Token: 0x0603AF7D RID: 241533 RVA: 0x007EB536 File Offset: 0x007E9736
		// (set) Token: 0x0603AF7E RID: 241534 RVA: 0x007EB53E File Offset: 0x007E973E
		public TTalkItemStyle Type { get; set; }

		// Token: 0x1700F322 RID: 62242
		// (get) Token: 0x0603AF7F RID: 241535 RVA: 0x007EB547 File Offset: 0x007E9747
		// (set) Token: 0x0603AF80 RID: 241536 RVA: 0x007EB54F File Offset: 0x007E974F
		public object Value { get; set; }

		// Token: 0x0603AF81 RID: 241537 RVA: 0x007EB558 File Offset: 0x007E9758
		public TTalkItemStyleUnion()
		{
			this.Type = TTalkItemStyle.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF82 RID: 241538 RVA: 0x007EB56E File Offset: 0x007E976E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF83 RID: 241539 RVA: 0x007EB580 File Offset: 0x007E9780
		public ITalkItemStyleInnerVoiceT AsITalkItemStyleInnerVoice()
		{
			return this.As<ITalkItemStyleInnerVoiceT>();
		}

		// Token: 0x0603AF84 RID: 241540 RVA: 0x007EB588 File Offset: 0x007E9788
		public static TTalkItemStyleUnion FromITalkItemStyleInnerVoice(ITalkItemStyleInnerVoiceT _italkitemstyleinnervoice)
		{
			return new TTalkItemStyleUnion
			{
				Type = TTalkItemStyle.ITalkItemStyleInnerVoice,
				Value = _italkitemstyleinnervoice
			};
		}

		// Token: 0x0603AF85 RID: 241541 RVA: 0x007EB59D File Offset: 0x007E979D
		public ITalkItemStylePhoneSendErrorT AsITalkItemStylePhoneSendError()
		{
			return this.As<ITalkItemStylePhoneSendErrorT>();
		}

		// Token: 0x0603AF86 RID: 241542 RVA: 0x007EB5A5 File Offset: 0x007E97A5
		public static TTalkItemStyleUnion FromITalkItemStylePhoneSendError(ITalkItemStylePhoneSendErrorT _italkitemstylephonesenderror)
		{
			return new TTalkItemStyleUnion
			{
				Type = TTalkItemStyle.ITalkItemStylePhoneSendError,
				Value = _italkitemstylephonesenderror
			};
		}

		// Token: 0x0603AF87 RID: 241543 RVA: 0x007EB5BA File Offset: 0x007E97BA
		public ITalkItemStyleSceneUiSubtitleT AsITalkItemStyleSceneUiSubtitle()
		{
			return this.As<ITalkItemStyleSceneUiSubtitleT>();
		}

		// Token: 0x0603AF88 RID: 241544 RVA: 0x007EB5C2 File Offset: 0x007E97C2
		public static TTalkItemStyleUnion FromITalkItemStyleSceneUiSubtitle(ITalkItemStyleSceneUiSubtitleT _italkitemstylesceneuisubtitle)
		{
			return new TTalkItemStyleUnion
			{
				Type = TTalkItemStyle.ITalkItemStyleSceneUiSubtitle,
				Value = _italkitemstylesceneuisubtitle
			};
		}

		// Token: 0x0603AF89 RID: 241545 RVA: 0x007EB5D8 File Offset: 0x007E97D8
		public static int Pack(FlatBufferBuilder builder, TTalkItemStyleUnion _o)
		{
			switch (_o.Type)
			{
			case TTalkItemStyle.ITalkItemStyleInnerVoice:
				return ITalkItemStyleInnerVoice.Pack(builder, _o.AsITalkItemStyleInnerVoice()).Value;
			case TTalkItemStyle.ITalkItemStylePhoneSendError:
				return ITalkItemStylePhoneSendError.Pack(builder, _o.AsITalkItemStylePhoneSendError()).Value;
			case TTalkItemStyle.ITalkItemStyleSceneUiSubtitle:
				return ITalkItemStyleSceneUiSubtitle.Pack(builder, _o.AsITalkItemStyleSceneUiSubtitle()).Value;
			default:
				return 0;
			}
		}
	}
}
