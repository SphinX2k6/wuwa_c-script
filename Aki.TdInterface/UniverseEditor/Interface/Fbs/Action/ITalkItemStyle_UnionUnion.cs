using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007308 RID: 29448
	public class ITalkItemStyle_UnionUnion
	{
		// Token: 0x1700DDC7 RID: 56775
		// (get) Token: 0x06035010 RID: 217104 RVA: 0x0072E9C9 File Offset: 0x0072CBC9
		// (set) Token: 0x06035011 RID: 217105 RVA: 0x0072E9D1 File Offset: 0x0072CBD1
		public ITalkItemStyle_Union Type { get; set; }

		// Token: 0x1700DDC8 RID: 56776
		// (get) Token: 0x06035012 RID: 217106 RVA: 0x0072E9DA File Offset: 0x0072CBDA
		// (set) Token: 0x06035013 RID: 217107 RVA: 0x0072E9E2 File Offset: 0x0072CBE2
		public object Value { get; set; }

		// Token: 0x06035014 RID: 217108 RVA: 0x0072E9EB File Offset: 0x0072CBEB
		public ITalkItemStyle_UnionUnion()
		{
			this.Type = ITalkItemStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06035015 RID: 217109 RVA: 0x0072EA01 File Offset: 0x0072CC01
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06035016 RID: 217110 RVA: 0x0072EA13 File Offset: 0x0072CC13
		public ITalkItemStyleT AsITalkItemStyle()
		{
			return this.As<ITalkItemStyleT>();
		}

		// Token: 0x06035017 RID: 217111 RVA: 0x0072EA1B File Offset: 0x0072CC1B
		public static ITalkItemStyle_UnionUnion FromITalkItemStyle(ITalkItemStyleT _italkitemstyle)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStyle,
				Value = _italkitemstyle
			};
		}

		// Token: 0x06035018 RID: 217112 RVA: 0x0072EA30 File Offset: 0x0072CC30
		public ITalkItemStyleInnerVoiceT AsITalkItemStyleInnerVoice()
		{
			return this.As<ITalkItemStyleInnerVoiceT>();
		}

		// Token: 0x06035019 RID: 217113 RVA: 0x0072EA38 File Offset: 0x0072CC38
		public static ITalkItemStyle_UnionUnion FromITalkItemStyleInnerVoice(ITalkItemStyleInnerVoiceT _italkitemstyleinnervoice)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStyleInnerVoice,
				Value = _italkitemstyleinnervoice
			};
		}

		// Token: 0x0603501A RID: 217114 RVA: 0x0072EA4D File Offset: 0x0072CC4D
		public ITalkItemStylePhoneSendErrorT AsITalkItemStylePhoneSendError()
		{
			return this.As<ITalkItemStylePhoneSendErrorT>();
		}

		// Token: 0x0603501B RID: 217115 RVA: 0x0072EA55 File Offset: 0x0072CC55
		public static ITalkItemStyle_UnionUnion FromITalkItemStylePhoneSendError(ITalkItemStylePhoneSendErrorT _italkitemstylephonesenderror)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStylePhoneSendError,
				Value = _italkitemstylephonesenderror
			};
		}

		// Token: 0x0603501C RID: 217116 RVA: 0x0072EA6C File Offset: 0x0072CC6C
		public static int Pack(FlatBufferBuilder builder, ITalkItemStyle_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITalkItemStyle_Union.ITalkItemStyle:
				return ITalkItemStyle.Pack(builder, _o.AsITalkItemStyle()).Value;
			case ITalkItemStyle_Union.ITalkItemStyleInnerVoice:
				return ITalkItemStyleInnerVoice.Pack(builder, _o.AsITalkItemStyleInnerVoice()).Value;
			case ITalkItemStyle_Union.ITalkItemStylePhoneSendError:
				return ITalkItemStylePhoneSendError.Pack(builder, _o.AsITalkItemStylePhoneSendError()).Value;
			default:
				return 0;
			}
		}
	}
}
