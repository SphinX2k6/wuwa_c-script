using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CA3 RID: 23715
	public class TSceneTextUnion
	{
		// Token: 0x1700B24A RID: 45642
		// (get) Token: 0x060289B7 RID: 166327 RVA: 0x00594C8A File Offset: 0x00592E8A
		// (set) Token: 0x060289B8 RID: 166328 RVA: 0x00594C92 File Offset: 0x00592E92
		public TSceneText Type { get; set; }

		// Token: 0x1700B24B RID: 45643
		// (get) Token: 0x060289B9 RID: 166329 RVA: 0x00594C9B File Offset: 0x00592E9B
		// (set) Token: 0x060289BA RID: 166330 RVA: 0x00594CA3 File Offset: 0x00592EA3
		public object Value { get; set; }

		// Token: 0x060289BB RID: 166331 RVA: 0x00594CAC File Offset: 0x00592EAC
		public TSceneTextUnion()
		{
			this.Type = TSceneText.NONE;
			this.Value = null;
		}

		// Token: 0x060289BC RID: 166332 RVA: 0x00594CC2 File Offset: 0x00592EC2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060289BD RID: 166333 RVA: 0x00594CD4 File Offset: 0x00592ED4
		public ISceneTextGuideUiT AsISceneTextGuideUi()
		{
			return this.As<ISceneTextGuideUiT>();
		}

		// Token: 0x060289BE RID: 166334 RVA: 0x00594CDC File Offset: 0x00592EDC
		public static TSceneTextUnion FromISceneTextGuideUi(ISceneTextGuideUiT _iscenetextguideui)
		{
			return new TSceneTextUnion
			{
				Type = TSceneText.ISceneTextGuideUi,
				Value = _iscenetextguideui
			};
		}

		// Token: 0x060289BF RID: 166335 RVA: 0x00594CF1 File Offset: 0x00592EF1
		public ISceneTextSubtitleWithVoiceT AsISceneTextSubtitleWithVoice()
		{
			return this.As<ISceneTextSubtitleWithVoiceT>();
		}

		// Token: 0x060289C0 RID: 166336 RVA: 0x00594CF9 File Offset: 0x00592EF9
		public static TSceneTextUnion FromISceneTextSubtitleWithVoice(ISceneTextSubtitleWithVoiceT _iscenetextsubtitlewithvoice)
		{
			return new TSceneTextUnion
			{
				Type = TSceneText.ISceneTextSubtitleWithVoice,
				Value = _iscenetextsubtitlewithvoice
			};
		}

		// Token: 0x060289C1 RID: 166337 RVA: 0x00594D10 File Offset: 0x00592F10
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
