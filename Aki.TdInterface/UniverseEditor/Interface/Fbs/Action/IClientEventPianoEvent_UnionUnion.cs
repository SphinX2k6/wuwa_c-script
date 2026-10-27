using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063A4 RID: 25508
	public class IClientEventPianoEvent_UnionUnion
	{
		// Token: 0x1700BE26 RID: 48678
		// (get) Token: 0x0602C205 RID: 180741 RVA: 0x0060F759 File Offset: 0x0060D959
		// (set) Token: 0x0602C206 RID: 180742 RVA: 0x0060F761 File Offset: 0x0060D961
		public IClientEventPianoEvent_Union Type { get; set; }

		// Token: 0x1700BE27 RID: 48679
		// (get) Token: 0x0602C207 RID: 180743 RVA: 0x0060F76A File Offset: 0x0060D96A
		// (set) Token: 0x0602C208 RID: 180744 RVA: 0x0060F772 File Offset: 0x0060D972
		public object Value { get; set; }

		// Token: 0x0602C209 RID: 180745 RVA: 0x0060F77B File Offset: 0x0060D97B
		public IClientEventPianoEvent_UnionUnion()
		{
			this.Type = IClientEventPianoEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602C20A RID: 180746 RVA: 0x0060F791 File Offset: 0x0060D991
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602C20B RID: 180747 RVA: 0x0060F7A3 File Offset: 0x0060D9A3
		public IClientEventPianoEventT AsIClientEventPianoEvent()
		{
			return this.As<IClientEventPianoEventT>();
		}

		// Token: 0x0602C20C RID: 180748 RVA: 0x0060F7AB File Offset: 0x0060D9AB
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoEvent(IClientEventPianoEventT _iclienteventpianoevent)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoEvent,
				Value = _iclienteventpianoevent
			};
		}

		// Token: 0x0602C20D RID: 180749 RVA: 0x0060F7C0 File Offset: 0x0060D9C0
		public IClientEventPianoUpdateSubtitleT AsIClientEventPianoUpdateSubtitle()
		{
			return this.As<IClientEventPianoUpdateSubtitleT>();
		}

		// Token: 0x0602C20E RID: 180750 RVA: 0x0060F7C8 File Offset: 0x0060D9C8
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoUpdateSubtitle(IClientEventPianoUpdateSubtitleT _iclienteventpianoupdatesubtitle)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoUpdateSubtitle,
				Value = _iclienteventpianoupdatesubtitle
			};
		}

		// Token: 0x0602C20F RID: 180751 RVA: 0x0060F7DD File Offset: 0x0060D9DD
		public IClientEventPianoSwitchPhaseT AsIClientEventPianoSwitchPhase()
		{
			return this.As<IClientEventPianoSwitchPhaseT>();
		}

		// Token: 0x0602C210 RID: 180752 RVA: 0x0060F7E5 File Offset: 0x0060D9E5
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoSwitchPhase(IClientEventPianoSwitchPhaseT _iclienteventpianoswitchphase)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoSwitchPhase,
				Value = _iclienteventpianoswitchphase
			};
		}

		// Token: 0x0602C211 RID: 180753 RVA: 0x0060F7FC File Offset: 0x0060D9FC
		public static int Pack(FlatBufferBuilder builder, IClientEventPianoEvent_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IClientEventPianoEvent_Union.IClientEventPianoEvent:
				return IClientEventPianoEvent.Pack(builder, _o.AsIClientEventPianoEvent()).Value;
			case IClientEventPianoEvent_Union.IClientEventPianoUpdateSubtitle:
				return IClientEventPianoUpdateSubtitle.Pack(builder, _o.AsIClientEventPianoUpdateSubtitle()).Value;
			case IClientEventPianoEvent_Union.IClientEventPianoSwitchPhase:
				return IClientEventPianoSwitchPhase.Pack(builder, _o.AsIClientEventPianoSwitchPhase()).Value;
			default:
				return 0;
			}
		}
	}
}
