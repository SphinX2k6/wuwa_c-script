using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077C6 RID: 30662
	public class TTalkItemStyleUnion
	{
		// Token: 0x1700E6C7 RID: 59079
		// (get) Token: 0x060379FA RID: 227834 RVA: 0x00785F22 File Offset: 0x00784122
		// (set) Token: 0x060379FB RID: 227835 RVA: 0x00785F2A File Offset: 0x0078412A
		public TTalkItemStyle Type { get; set; }

		// Token: 0x1700E6C8 RID: 59080
		// (get) Token: 0x060379FC RID: 227836 RVA: 0x00785F33 File Offset: 0x00784133
		// (set) Token: 0x060379FD RID: 227837 RVA: 0x00785F3B File Offset: 0x0078413B
		public object Value { get; set; }

		// Token: 0x060379FE RID: 227838 RVA: 0x00785F44 File Offset: 0x00784144
		public TTalkItemStyleUnion()
		{
			this.Type = TTalkItemStyle.NONE;
			this.Value = null;
		}

		// Token: 0x060379FF RID: 227839 RVA: 0x00785F5A File Offset: 0x0078415A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A00 RID: 227840 RVA: 0x00785F6C File Offset: 0x0078416C
		public ITalkItemStyleInnerVoiceT AsITalkItemStyleInnerVoice()
		{
			return this.As<ITalkItemStyleInnerVoiceT>();
		}

		// Token: 0x06037A01 RID: 227841 RVA: 0x00785F74 File Offset: 0x00784174
		public static TTalkItemStyleUnion FromITalkItemStyleInnerVoice(ITalkItemStyleInnerVoiceT _italkitemstyleinnervoice)
		{
			return new TTalkItemStyleUnion
			{
				Type = TTalkItemStyle.ITalkItemStyleInnerVoice,
				Value = _italkitemstyleinnervoice
			};
		}

		// Token: 0x06037A02 RID: 227842 RVA: 0x00785F89 File Offset: 0x00784189
		public ITalkItemStylePhoneSendErrorT AsITalkItemStylePhoneSendError()
		{
			return this.As<ITalkItemStylePhoneSendErrorT>();
		}

		// Token: 0x06037A03 RID: 227843 RVA: 0x00785F91 File Offset: 0x00784191
		public static TTalkItemStyleUnion FromITalkItemStylePhoneSendError(ITalkItemStylePhoneSendErrorT _italkitemstylephonesenderror)
		{
			return new TTalkItemStyleUnion
			{
				Type = TTalkItemStyle.ITalkItemStylePhoneSendError,
				Value = _italkitemstylephonesenderror
			};
		}

		// Token: 0x06037A04 RID: 227844 RVA: 0x00785FA8 File Offset: 0x007841A8
		public static int Pack(FlatBufferBuilder builder, TTalkItemStyleUnion _o)
		{
			TTalkItemStyle type = _o.Type;
			if (type == TTalkItemStyle.ITalkItemStyleInnerVoice)
			{
				return ITalkItemStyleInnerVoice.Pack(builder, _o.AsITalkItemStyleInnerVoice()).Value;
			}
			if (type != TTalkItemStyle.ITalkItemStylePhoneSendError)
			{
				return 0;
			}
			return ITalkItemStylePhoneSendError.Pack(builder, _o.AsITalkItemStylePhoneSendError()).Value;
		}
	}
}
