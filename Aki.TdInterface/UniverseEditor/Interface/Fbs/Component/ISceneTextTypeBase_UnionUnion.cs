using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005EFC RID: 24316
	public class ISceneTextTypeBase_UnionUnion
	{
		// Token: 0x1700B3C8 RID: 46024
		// (get) Token: 0x06028CA6 RID: 167078 RVA: 0x00593301 File Offset: 0x00591501
		// (set) Token: 0x06028CA7 RID: 167079 RVA: 0x00593309 File Offset: 0x00591509
		public ISceneTextTypeBase_Union Type { get; set; }

		// Token: 0x1700B3C9 RID: 46025
		// (get) Token: 0x06028CA8 RID: 167080 RVA: 0x00593312 File Offset: 0x00591512
		// (set) Token: 0x06028CA9 RID: 167081 RVA: 0x0059331A File Offset: 0x0059151A
		public object Value { get; set; }

		// Token: 0x06028CAA RID: 167082 RVA: 0x00593323 File Offset: 0x00591523
		public ISceneTextTypeBase_UnionUnion()
		{
			this.Type = ISceneTextTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06028CAB RID: 167083 RVA: 0x00593339 File Offset: 0x00591539
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028CAC RID: 167084 RVA: 0x0059334B File Offset: 0x0059154B
		public ISceneTextTypeBaseT AsISceneTextTypeBase()
		{
			return this.As<ISceneTextTypeBaseT>();
		}

		// Token: 0x06028CAD RID: 167085 RVA: 0x00593353 File Offset: 0x00591553
		public static ISceneTextTypeBase_UnionUnion FromISceneTextTypeBase(ISceneTextTypeBaseT _iscenetexttypebase)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextTypeBase,
				Value = _iscenetexttypebase
			};
		}

		// Token: 0x06028CAE RID: 167086 RVA: 0x00593368 File Offset: 0x00591568
		public ISceneTextSubtitleWithVoiceT AsISceneTextSubtitleWithVoice()
		{
			return this.As<ISceneTextSubtitleWithVoiceT>();
		}

		// Token: 0x06028CAF RID: 167087 RVA: 0x00593370 File Offset: 0x00591570
		public static ISceneTextTypeBase_UnionUnion FromISceneTextSubtitleWithVoice(ISceneTextSubtitleWithVoiceT _iscenetextsubtitlewithvoice)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextSubtitleWithVoice,
				Value = _iscenetextsubtitlewithvoice
			};
		}

		// Token: 0x06028CB0 RID: 167088 RVA: 0x00593385 File Offset: 0x00591585
		public ISceneTextGuideUiT AsISceneTextGuideUi()
		{
			return this.As<ISceneTextGuideUiT>();
		}

		// Token: 0x06028CB1 RID: 167089 RVA: 0x0059338D File Offset: 0x0059158D
		public static ISceneTextTypeBase_UnionUnion FromISceneTextGuideUi(ISceneTextGuideUiT _iscenetextguideui)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextGuideUi,
				Value = _iscenetextguideui
			};
		}

		// Token: 0x06028CB2 RID: 167090 RVA: 0x005933A4 File Offset: 0x005915A4
		public static int Pack(FlatBufferBuilder builder, ISceneTextTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISceneTextTypeBase_Union.ISceneTextTypeBase:
				return ISceneTextTypeBase.Pack(builder, _o.AsISceneTextTypeBase()).Value;
			case ISceneTextTypeBase_Union.ISceneTextSubtitleWithVoice:
				return ISceneTextSubtitleWithVoice.Pack(builder, _o.AsISceneTextSubtitleWithVoice()).Value;
			case ISceneTextTypeBase_Union.ISceneTextGuideUi:
				return ISceneTextGuideUi.Pack(builder, _o.AsISceneTextGuideUi()).Value;
			default:
				return 0;
			}
		}
	}
}
