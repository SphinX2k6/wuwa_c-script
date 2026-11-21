using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062D4 RID: 25300
	public class TSceneTextUnion
	{
		// Token: 0x1700BBA4 RID: 48036
		// (get) Token: 0x0602AFFF RID: 176127 RVA: 0x005DD3FE File Offset: 0x005DB5FE
		// (set) Token: 0x0602B000 RID: 176128 RVA: 0x005DD406 File Offset: 0x005DB606
		public TSceneText Type { get; set; }

		// Token: 0x1700BBA5 RID: 48037
		// (get) Token: 0x0602B001 RID: 176129 RVA: 0x005DD40F File Offset: 0x005DB60F
		// (set) Token: 0x0602B002 RID: 176130 RVA: 0x005DD417 File Offset: 0x005DB617
		public object Value { get; set; }

		// Token: 0x0602B003 RID: 176131 RVA: 0x005DD420 File Offset: 0x005DB620
		public TSceneTextUnion()
		{
			this.Type = TSceneText.NONE;
			this.Value = null;
		}

		// Token: 0x0602B004 RID: 176132 RVA: 0x005DD436 File Offset: 0x005DB636
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B005 RID: 176133 RVA: 0x005DD448 File Offset: 0x005DB648
		public ISceneTextGuideUiT AsISceneTextGuideUi()
		{
			return this.As<ISceneTextGuideUiT>();
		}

		// Token: 0x0602B006 RID: 176134 RVA: 0x005DD450 File Offset: 0x005DB650
		public static TSceneTextUnion FromISceneTextGuideUi(ISceneTextGuideUiT _iscenetextguideui)
		{
			return new TSceneTextUnion
			{
				Type = TSceneText.ISceneTextGuideUi,
				Value = _iscenetextguideui
			};
		}

		// Token: 0x0602B007 RID: 176135 RVA: 0x005DD465 File Offset: 0x005DB665
		public ISceneTextSubtitleWithVoiceT AsISceneTextSubtitleWithVoice()
		{
			return this.As<ISceneTextSubtitleWithVoiceT>();
		}

		// Token: 0x0602B008 RID: 176136 RVA: 0x005DD46D File Offset: 0x005DB66D
		public static TSceneTextUnion FromISceneTextSubtitleWithVoice(ISceneTextSubtitleWithVoiceT _iscenetextsubtitlewithvoice)
		{
			return new TSceneTextUnion
			{
				Type = TSceneText.ISceneTextSubtitleWithVoice,
				Value = _iscenetextsubtitlewithvoice
			};
		}

		// Token: 0x0602B009 RID: 176137 RVA: 0x005DD484 File Offset: 0x005DB684
		public static int Pack(FlatBufferBuilder builder, TSceneTextUnion _o)
		{
			TSceneText type = _o.Type;
			if (type == TSceneText.ISceneTextGuideUi)
			{
				return ISceneTextGuideUi.Pack(builder, _o.AsISceneTextGuideUi()).Value;
			}
			if (type != TSceneText.ISceneTextSubtitleWithVoice)
			{
				return 0;
			}
			return ISceneTextSubtitleWithVoice.Pack(builder, _o.AsISceneTextSubtitleWithVoice()).Value;
		}
	}
}
