using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AC5 RID: 31429
	public class ITalkItemPhoneMessageBase_UnionUnion
	{
		// Token: 0x1700E95C RID: 59740
		// (get) Token: 0x06038189 RID: 229769 RVA: 0x0078BCAD File Offset: 0x00789EAD
		// (set) Token: 0x0603818A RID: 229770 RVA: 0x0078BCB5 File Offset: 0x00789EB5
		public ITalkItemPhoneMessageBase_Union Type { get; set; }

		// Token: 0x1700E95D RID: 59741
		// (get) Token: 0x0603818B RID: 229771 RVA: 0x0078BCBE File Offset: 0x00789EBE
		// (set) Token: 0x0603818C RID: 229772 RVA: 0x0078BCC6 File Offset: 0x00789EC6
		public object Value { get; set; }

		// Token: 0x0603818D RID: 229773 RVA: 0x0078BCCF File Offset: 0x00789ECF
		public ITalkItemPhoneMessageBase_UnionUnion()
		{
			this.Type = ITalkItemPhoneMessageBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603818E RID: 229774 RVA: 0x0078BCE5 File Offset: 0x00789EE5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603818F RID: 229775 RVA: 0x0078BCF7 File Offset: 0x00789EF7
		public ITalkItemPhoneMessageBaseT AsITalkItemPhoneMessageBase()
		{
			return this.As<ITalkItemPhoneMessageBaseT>();
		}

		// Token: 0x06038190 RID: 229776 RVA: 0x0078BCFF File Offset: 0x00789EFF
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageBase(ITalkItemPhoneMessageBaseT _italkitemphonemessagebase)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageBase,
				Value = _italkitemphonemessagebase
			};
		}

		// Token: 0x06038191 RID: 229777 RVA: 0x0078BD14 File Offset: 0x00789F14
		public ITalkItemPhoneMessageVoiceT AsITalkItemPhoneMessageVoice()
		{
			return this.As<ITalkItemPhoneMessageVoiceT>();
		}

		// Token: 0x06038192 RID: 229778 RVA: 0x0078BD1C File Offset: 0x00789F1C
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageVoice(ITalkItemPhoneMessageVoiceT _italkitemphonemessagevoice)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageVoice,
				Value = _italkitemphonemessagevoice
			};
		}

		// Token: 0x06038193 RID: 229779 RVA: 0x0078BD31 File Offset: 0x00789F31
		public ITalkItemPhoneMessageEmojiT AsITalkItemPhoneMessageEmoji()
		{
			return this.As<ITalkItemPhoneMessageEmojiT>();
		}

		// Token: 0x06038194 RID: 229780 RVA: 0x0078BD39 File Offset: 0x00789F39
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageEmoji(ITalkItemPhoneMessageEmojiT _italkitemphonemessageemoji)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageEmoji,
				Value = _italkitemphonemessageemoji
			};
		}

		// Token: 0x06038195 RID: 229781 RVA: 0x0078BD4E File Offset: 0x00789F4E
		public ITalkItemPhoneMessageAttachmentT AsITalkItemPhoneMessageAttachment()
		{
			return this.As<ITalkItemPhoneMessageAttachmentT>();
		}

		// Token: 0x06038196 RID: 229782 RVA: 0x0078BD56 File Offset: 0x00789F56
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageAttachment(ITalkItemPhoneMessageAttachmentT _italkitemphonemessageattachment)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageAttachment,
				Value = _italkitemphonemessageattachment
			};
		}

		// Token: 0x06038197 RID: 229783 RVA: 0x0078BD6B File Offset: 0x00789F6B
		public ITalkItemPhoneMessageSystemTipT AsITalkItemPhoneMessageSystemTip()
		{
			return this.As<ITalkItemPhoneMessageSystemTipT>();
		}

		// Token: 0x06038198 RID: 229784 RVA: 0x0078BD73 File Offset: 0x00789F73
		public static ITalkItemPhoneMessageBase_UnionUnion FromITalkItemPhoneMessageSystemTip(ITalkItemPhoneMessageSystemTipT _italkitemphonemessagesystemtip)
		{
			return new ITalkItemPhoneMessageBase_UnionUnion
			{
				Type = ITalkItemPhoneMessageBase_Union.ITalkItemPhoneMessageSystemTip,
				Value = _italkitemphonemessagesystemtip
			};
		}

		// Token: 0x06038199 RID: 229785 RVA: 0x0078BD88 File Offset: 0x00789F88
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
