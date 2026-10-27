using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F0 RID: 29424
	public class ITalkItemPhoneMessageBase_UnionUnion
	{
		// Token: 0x1700DD63 RID: 56675
		// (get) Token: 0x06034E83 RID: 216707 RVA: 0x0072A849 File Offset: 0x00728A49
		// (set) Token: 0x06034E84 RID: 216708 RVA: 0x0072A851 File Offset: 0x00728A51
		public ITalkItemPhoneMessageBase_Union Type { get; set; }

		// Token: 0x1700DD64 RID: 56676
		// (get) Token: 0x06034E85 RID: 216709 RVA: 0x0072A85A File Offset: 0x00728A5A
		// (set) Token: 0x06034E86 RID: 216710 RVA: 0x0072A862 File Offset: 0x00728A62
		public object Value { get; set; }

		// Token: 0x06034E87 RID: 216711 RVA: 0x0072A86B File Offset: 0x00728A6B
		public ITalkItemPhoneMessageBase_UnionUnion()
		{
			this.Type = ITalkItemPhoneMessageBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06034E88 RID: 216712 RVA: 0x0072A881 File Offset: 0x00728A81
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06034E89 RID: 216713 RVA: 0x0072A893 File Offset: 0x00728A93
		public ITalkItemPhoneMessageBaseT AsITalkItemPhoneMessageBase()
		{
			return this.As<ITalkItemPhoneMessageBaseT>();
		}

		// Token: 0x06034E8A RID: 216714 RVA: 0x0072A89B File Offset: 0x00728A9B
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageBase(ITalkItemPhoneMessageBaseT _italkitemphonemessagebase)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageBase,
				Value = _italkitemphonemessagebase
			};
		}

		// Token: 0x06034E8B RID: 216715 RVA: 0x0072A8B0 File Offset: 0x00728AB0
		public ITalkItemPhoneMessageVoiceT AsITalkItemPhoneMessageVoice()
		{
			return this.As<ITalkItemPhoneMessageVoiceT>();
		}

		// Token: 0x06034E8C RID: 216716 RVA: 0x0072A8B8 File Offset: 0x00728AB8
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageVoice(ITalkItemPhoneMessageVoiceT _italkitemphonemessagevoice)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageVoice,
				Value = _italkitemphonemessagevoice
			};
		}

		// Token: 0x06034E8D RID: 216717 RVA: 0x0072A8CD File Offset: 0x00728ACD
		public ITalkItemPhoneMessageEmojiT AsITalkItemPhoneMessageEmoji()
		{
			return this.As<ITalkItemPhoneMessageEmojiT>();
		}

		// Token: 0x06034E8E RID: 216718 RVA: 0x0072A8D5 File Offset: 0x00728AD5
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageEmoji(ITalkItemPhoneMessageEmojiT _italkitemphonemessageemoji)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageEmoji,
				Value = _italkitemphonemessageemoji
			};
		}

		// Token: 0x06034E8F RID: 216719 RVA: 0x0072A8EA File Offset: 0x00728AEA
		public ITalkItemPhoneMessageAttachmentT AsITalkItemPhoneMessageAttachment()
		{
			return this.As<ITalkItemPhoneMessageAttachmentT>();
		}

		// Token: 0x06034E90 RID: 216720 RVA: 0x0072A8F2 File Offset: 0x00728AF2
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageAttachment(ITalkItemPhoneMessageAttachmentT _italkitemphonemessageattachment)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageAttachment,
				Value = _italkitemphonemessageattachment
			};
		}

		// Token: 0x06034E91 RID: 216721 RVA: 0x0072A907 File Offset: 0x00728B07
		public ITalkItemPhoneMessageSystemTipT AsITalkItemPhoneMessageSystemTip()
		{
			return this.As<ITalkItemPhoneMessageSystemTipT>();
		}

		// Token: 0x06034E92 RID: 216722 RVA: 0x0072A90F File Offset: 0x00728B0F
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageSystemTip(ITalkItemPhoneMessageSystemTipT _italkitemphonemessagesystemtip)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageSystemTip,
				Value = _italkitemphonemessagesystemtip
			};
		}

		// Token: 0x06034E93 RID: 216723 RVA: 0x0072A924 File Offset: 0x00728B24
		public static int Pack(FlatBufferBuilder builder, ITalkItemPhoneMessageBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageBase:
				return ITalkItemPhoneMessageBase.Pack(builder, _o.AsITalkItemPhoneMessageBase()).Value;
			case ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageVoice:
				return ITalkItemPhoneMessageVoice.Pack(builder, _o.AsITalkItemPhoneMessageVoice()).Value;
			case ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageEmoji:
				return ITalkItemPhoneMessageEmoji.Pack(builder, _o.AsITalkItemPhoneMessageEmoji()).Value;
			case ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageAttachment:
				return ITalkItemPhoneMessageAttachment.Pack(builder, _o.AsITalkItemPhoneMessageAttachment()).Value;
			case ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageSystemTip:
				return ITalkItemPhoneMessageSystemTip.Pack(builder, _o.AsITalkItemPhoneMessageSystemTip()).Value;
			default:
				return 0;
			}
		}
	}
}
