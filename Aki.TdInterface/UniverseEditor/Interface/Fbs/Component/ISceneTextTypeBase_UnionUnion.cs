using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058EF RID: 22767
	public class ISceneTextTypeBase_UnionUnion
	{
		// Token: 0x1700AA94 RID: 43668
		// (get) Token: 0x0602673C RID: 157500 RVA: 0x0054C695 File Offset: 0x0054A895
		// (set) Token: 0x0602673D RID: 157501 RVA: 0x0054C69D File Offset: 0x0054A89D
		public ISceneTextTypeBase_Union Type { get; set; }

		// Token: 0x1700AA95 RID: 43669
		// (get) Token: 0x0602673E RID: 157502 RVA: 0x0054C6A6 File Offset: 0x0054A8A6
		// (set) Token: 0x0602673F RID: 157503 RVA: 0x0054C6AE File Offset: 0x0054A8AE
		public object Value { get; set; }

		// Token: 0x06026740 RID: 157504 RVA: 0x0054C6B7 File Offset: 0x0054A8B7
		public ISceneTextTypeBase_UnionUnion()
		{
			this.Type = ISceneTextTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026741 RID: 157505 RVA: 0x0054C6CD File Offset: 0x0054A8CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026742 RID: 157506 RVA: 0x0054C6DF File Offset: 0x0054A8DF
		public ISceneTextTypeBaseT AsISceneTextTypeBase()
		{
			return this.As<ISceneTextTypeBaseT>();
		}

		// Token: 0x06026743 RID: 157507 RVA: 0x0054C6E7 File Offset: 0x0054A8E7
		public static ISceneTextTypeBase_UnionUnion FromISceneTextTypeBase(ISceneTextTypeBaseT _iscenetexttypebase)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextTypeBase,
				Value = _iscenetexttypebase
			};
		}

		// Token: 0x06026744 RID: 157508 RVA: 0x0054C6FC File Offset: 0x0054A8FC
		public ISceneTextSubtitleWithVoiceT AsISceneTextSubtitleWithVoice()
		{
			return this.As<ISceneTextSubtitleWithVoiceT>();
		}

		// Token: 0x06026745 RID: 157509 RVA: 0x0054C704 File Offset: 0x0054A904
		public static ISceneTextTypeBase_UnionUnion FromISceneTextSubtitleWithVoice(ISceneTextSubtitleWithVoiceT _iscenetextsubtitlewithvoice)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextSubtitleWithVoice,
				Value = _iscenetextsubtitlewithvoice
			};
		}

		// Token: 0x06026746 RID: 157510 RVA: 0x0054C719 File Offset: 0x0054A919
		public ISceneTextGuideUiT AsISceneTextGuideUi()
		{
			return this.As<ISceneTextGuideUiT>();
		}

		// Token: 0x06026747 RID: 157511 RVA: 0x0054C721 File Offset: 0x0054A921
		public static ISceneTextTypeBase_UnionUnion FromISceneTextGuideUi(ISceneTextGuideUiT _iscenetextguideui)
		{
			return new ISceneTextTypeBase_UnionUnion
			{
				Type = ISceneTextTypeBase_Union.ISceneTextGuideUi,
				Value = _iscenetextguideui
			};
		}

		// Token: 0x06026748 RID: 157512 RVA: 0x0054C738 File Offset: 0x0054A938
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
