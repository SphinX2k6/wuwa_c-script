using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F76 RID: 32630
	public class TPhoneMessageTypeUnion
	{
		// Token: 0x1700F2C7 RID: 62151
		// (get) Token: 0x0603ACFB RID: 240891 RVA: 0x007E7AA4 File Offset: 0x007E5CA4
		// (set) Token: 0x0603ACFC RID: 240892 RVA: 0x007E7AAC File Offset: 0x007E5CAC
		public TPhoneMessageType Type { get; set; }

		// Token: 0x1700F2C8 RID: 62152
		// (get) Token: 0x0603ACFD RID: 240893 RVA: 0x007E7AB5 File Offset: 0x007E5CB5
		// (set) Token: 0x0603ACFE RID: 240894 RVA: 0x007E7ABD File Offset: 0x007E5CBD
		public object Value { get; set; }

		// Token: 0x0603ACFF RID: 240895 RVA: 0x007E7AC6 File Offset: 0x007E5CC6
		public TPhoneMessageTypeUnion()
		{
			this.Type = TPhoneMessageType.NONE;
			this.Value = null;
		}

		// Token: 0x0603AD00 RID: 240896 RVA: 0x007E7ADC File Offset: 0x007E5CDC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AD01 RID: 240897 RVA: 0x007E7AEE File Offset: 0x007E5CEE
		public ITalkItemPhoneMessageAttachmentT AsITalkItemPhoneMessageAttachment()
		{
			return this.As<ITalkItemPhoneMessageAttachmentT>();
		}

		// Token: 0x0603AD02 RID: 240898 RVA: 0x007E7AF6 File Offset: 0x007E5CF6
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageAttachment(ITalkItemPhoneMessageAttachmentT _italkitemphonemessageattachment)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageAttachment,
				Value = _italkitemphonemessageattachment
			};
		}

		// Token: 0x0603AD03 RID: 240899 RVA: 0x007E7B0B File Offset: 0x007E5D0B
		public ITalkItemPhoneMessageEmojiT AsITalkItemPhoneMessageEmoji()
		{
			return this.As<ITalkItemPhoneMessageEmojiT>();
		}

		// Token: 0x0603AD04 RID: 240900 RVA: 0x007E7B13 File Offset: 0x007E5D13
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageEmoji(ITalkItemPhoneMessageEmojiT _italkitemphonemessageemoji)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageEmoji,
				Value = _italkitemphonemessageemoji
			};
		}

		// Token: 0x0603AD05 RID: 240901 RVA: 0x007E7B28 File Offset: 0x007E5D28
		public ITalkItemPhoneMessageSystemTipT AsITalkItemPhoneMessageSystemTip()
		{
			return this.As<ITalkItemPhoneMessageSystemTipT>();
		}

		// Token: 0x0603AD06 RID: 240902 RVA: 0x007E7B30 File Offset: 0x007E5D30
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageSystemTip(ITalkItemPhoneMessageSystemTipT _italkitemphonemessagesystemtip)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageSystemTip,
				Value = _italkitemphonemessagesystemtip
			};
		}

		// Token: 0x0603AD07 RID: 240903 RVA: 0x007E7B45 File Offset: 0x007E5D45
		public ITalkItemPhoneMessageVoiceT AsITalkItemPhoneMessageVoice()
		{
			return this.As<ITalkItemPhoneMessageVoiceT>();
		}

		// Token: 0x0603AD08 RID: 240904 RVA: 0x007E7B4D File Offset: 0x007E5D4D
		public static TPhoneMessageTypeUnion FromITalkItemPhoneMessageVoice(ITalkItemPhoneMessageVoiceT _italkitemphonemessagevoice)
		{
			return new TPhoneMessageTypeUnion
			{
				Type = TPhoneMessageType.ITalkItemPhoneMessageVoice,
				Value = _italkitemphonemessagevoice
			};
		}

		// Token: 0x0603AD09 RID: 240905 RVA: 0x007E7B64 File Offset: 0x007E5D64
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
