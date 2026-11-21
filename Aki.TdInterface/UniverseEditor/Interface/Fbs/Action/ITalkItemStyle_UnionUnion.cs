using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AE0 RID: 31456
	public class ITalkItemStyle_UnionUnion
	{
		// Token: 0x1700E9C5 RID: 59845
		// (get) Token: 0x06038330 RID: 230192 RVA: 0x007901AC File Offset: 0x0078E3AC
		// (set) Token: 0x06038331 RID: 230193 RVA: 0x007901B4 File Offset: 0x0078E3B4
		public ITalkItemStyle_Union Type { get; set; }

		// Token: 0x1700E9C6 RID: 59846
		// (get) Token: 0x06038332 RID: 230194 RVA: 0x007901BD File Offset: 0x0078E3BD
		// (set) Token: 0x06038333 RID: 230195 RVA: 0x007901C5 File Offset: 0x0078E3C5
		public object Value { get; set; }

		// Token: 0x06038334 RID: 230196 RVA: 0x007901CE File Offset: 0x0078E3CE
		public ITalkItemStyle_UnionUnion()
		{
			this.Type = ITalkItemStyle_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06038335 RID: 230197 RVA: 0x007901E4 File Offset: 0x0078E3E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06038336 RID: 230198 RVA: 0x007901F6 File Offset: 0x0078E3F6
		public ITalkItemStyleT AsITalkItemStyle()
		{
			return this.As<ITalkItemStyleT>();
		}

		// Token: 0x06038337 RID: 230199 RVA: 0x007901FE File Offset: 0x0078E3FE
		public static ITalkItemStyle_UnionUnion FromITalkItemStyle(ITalkItemStyleT _italkitemstyle)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStyle,
				Value = _italkitemstyle
			};
		}

		// Token: 0x06038338 RID: 230200 RVA: 0x00790213 File Offset: 0x0078E413
		public ITalkItemStyleInnerVoiceT AsITalkItemStyleInnerVoice()
		{
			return this.As<ITalkItemStyleInnerVoiceT>();
		}

		// Token: 0x06038339 RID: 230201 RVA: 0x0079021B File Offset: 0x0078E41B
		public static ITalkItemStyle_UnionUnion FromITalkItemStyleInnerVoice(ITalkItemStyleInnerVoiceT _italkitemstyleinnervoice)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStyleInnerVoice,
				Value = _italkitemstyleinnervoice
			};
		}

		// Token: 0x0603833A RID: 230202 RVA: 0x00790230 File Offset: 0x0078E430
		public ITalkItemStylePhoneSendErrorT AsITalkItemStylePhoneSendError()
		{
			return this.As<ITalkItemStylePhoneSendErrorT>();
		}

		// Token: 0x0603833B RID: 230203 RVA: 0x00790238 File Offset: 0x0078E438
		public static ITalkItemStyle_UnionUnion FromITalkItemStylePhoneSendError(ITalkItemStylePhoneSendErrorT _italkitemstylephonesenderror)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStylePhoneSendError,
				Value = _italkitemstylephonesenderror
			};
		}

		// Token: 0x0603833C RID: 230204 RVA: 0x0079024D File Offset: 0x0078E44D
		public ITalkItemStyleSceneUiSubtitleT AsITalkItemStyleSceneUiSubtitle()
		{
			return this.As<ITalkItemStyleSceneUiSubtitleT>();
		}

		// Token: 0x0603833D RID: 230205 RVA: 0x00790255 File Offset: 0x0078E455
		public static ITalkItemStyle_UnionUnion FromITalkItemStyleSceneUiSubtitle(ITalkItemStyleSceneUiSubtitleT _italkitemstylesceneuisubtitle)
		{
			return new ITalkItemStyle_UnionUnion
			{
				Type = ITalkItemStyle_Union.ITalkItemStyleSceneUiSubtitle,
				Value = _italkitemstylesceneuisubtitle
			};
		}

		// Token: 0x0603833E RID: 230206 RVA: 0x0079026C File Offset: 0x0078E46C
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
			case ITalkItemStyle_Union.ITalkItemStyleSceneUiSubtitle:
				return ITalkItemStyleSceneUiSubtitle.Pack(builder, _o.AsITalkItemStyleSceneUiSubtitle()).Value;
			default:
				return 0;
			}
		}
	}
}
