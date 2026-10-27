using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200774D RID: 30541
	public class TPhoneMessageTypeUnion
	{
		// Token: 0x1700E677 RID: 58999
		// (get) Token: 0x060377BE RID: 227262 RVA: 0x00782AD0 File Offset: 0x00780CD0
		// (set) Token: 0x060377BF RID: 227263 RVA: 0x00782AD8 File Offset: 0x00780CD8
		public TPhoneMessageType Type { get; set; }

		// Token: 0x1700E678 RID: 59000
		// (get) Token: 0x060377C0 RID: 227264 RVA: 0x00782AE1 File Offset: 0x00780CE1
		// (set) Token: 0x060377C1 RID: 227265 RVA: 0x00782AE9 File Offset: 0x00780CE9
		public object Value { get; set; }

		// Token: 0x060377C2 RID: 227266 RVA: 0x00782AF2 File Offset: 0x00780CF2
		public TPhoneMessageTypeUnion()
		{
			this.Type = TPhoneMessageType.NONE;
			this.Value = null;
		}

		// Token: 0x060377C3 RID: 227267 RVA: 0x00782B08 File Offset: 0x00780D08
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060377C4 RID: 227268 RVA: 0x00782B1A File Offset: 0x00780D1A
		public ITalkItemPhoneMessageAttachmentT AsITalkItemPhoneMessageAttachment()
		{
			return this.As<ITalkItemPhoneMessageAttachmentT>();
		}

		// Token: 0x060377C5 RID: 227269 RVA: 0x00782B22 File Offset: 0x00780D22
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageAttachment(ITalkItemPhoneMessageAttachmentT _italkitemphonemessageattachment)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageAttachment,
				Value = _italkitemphonemessageattachment
			};
		}

		// Token: 0x060377C6 RID: 227270 RVA: 0x00782B37 File Offset: 0x00780D37
		public ITalkItemPhoneMessageEmojiT AsITalkItemPhoneMessageEmoji()
		{
			return this.As<ITalkItemPhoneMessageEmojiT>();
		}

		// Token: 0x060377C7 RID: 227271 RVA: 0x00782B3F File Offset: 0x00780D3F
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageEmoji(ITalkItemPhoneMessageEmojiT _italkitemphonemessageemoji)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageEmoji,
				Value = _italkitemphonemessageemoji
			};
		}

		// Token: 0x060377C8 RID: 227272 RVA: 0x00782B54 File Offset: 0x00780D54
		public ITalkItemPhoneMessageSystemTipT AsITalkItemPhoneMessageSystemTip()
		{
			return this.As<ITalkItemPhoneMessageSystemTipT>();
		}

		// Token: 0x060377C9 RID: 227273 RVA: 0x00782B5C File Offset: 0x00780D5C
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageSystemTip(ITalkItemPhoneMessageSystemTipT _italkitemphonemessagesystemtip)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageSystemTip,
				Value = _italkitemphonemessagesystemtip
			};
		}

		// Token: 0x060377CA RID: 227274 RVA: 0x00782B71 File Offset: 0x00780D71
		public ITalkItemPhoneMessageVoiceT AsITalkItemPhoneMessageVoice()
		{
			return this.As<ITalkItemPhoneMessageVoiceT>();
		}

		// Token: 0x060377CB RID: 227275 RVA: 0x00782B79 File Offset: 0x00780D79
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageVoice(ITalkItemPhoneMessageVoiceT _italkitemphonemessagevoice)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageVoice,
				Value = _italkitemphonemessagevoice
			};
		}

		// Token: 0x060377CC RID: 227276 RVA: 0x00782B90 File Offset: 0x00780D90
		public static int Pack(FlatBufferBuilder builder, TPhoneMessageTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TPhoneMessageType.ITalkItemPhoneMessageAttachment:
				return ITalkItemPhoneMessageAttachment.Pack(builder, _o.AsITalkItemPhoneMessageAttachment()).Value;
			case TPhoneMessageType.ITalkItemPhoneMessageEmoji:
				return ITalkItemPhoneMessageEmoji.Pack(builder, _o.AsITalkItemPhoneMessageEmoji()).Value;
			case TPhoneMessageType.ITalkItemPhoneMessageSystemTip:
				return ITalkItemPhoneMessageSystemTip.Pack(builder, _o.AsITalkItemPhoneMessageSystemTip()).Value;
			case TPhoneMessageType.ITalkItemPhoneMessageVoice:
				return ITalkItemPhoneMessageVoice.Pack(builder, _o.AsITalkItemPhoneMessageVoice()).Value;
			default:
				return 0;
			}
		}
	}
}
