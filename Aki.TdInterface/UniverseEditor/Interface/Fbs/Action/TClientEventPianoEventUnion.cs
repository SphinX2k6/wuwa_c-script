using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007672 RID: 30322
	public class TClientEventPianoEventUnion
	{
		// Token: 0x1700E5DF RID: 58847
		// (get) Token: 0x060372F6 RID: 226038 RVA: 0x0077B0B2 File Offset: 0x007792B2
		// (set) Token: 0x060372F7 RID: 226039 RVA: 0x0077B0BA File Offset: 0x007792BA
		public TClientEventPianoEvent Type { get; set; }

		// Token: 0x1700E5E0 RID: 58848
		// (get) Token: 0x060372F8 RID: 226040 RVA: 0x0077B0C3 File Offset: 0x007792C3
		// (set) Token: 0x060372F9 RID: 226041 RVA: 0x0077B0CB File Offset: 0x007792CB
		public object Value { get; set; }

		// Token: 0x060372FA RID: 226042 RVA: 0x0077B0D4 File Offset: 0x007792D4
		public TClientEventPianoEventUnion()
		{
			this.Type = TClientEventPianoEvent.NONE;
			this.Value = null;
		}

		// Token: 0x060372FB RID: 226043 RVA: 0x0077B0EA File Offset: 0x007792EA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060372FC RID: 226044 RVA: 0x0077B0FC File Offset: 0x007792FC
		public IClientEventPianoSwitchPhaseT AsIClientEventPianoSwitchPhase()
		{
			return this.As<IClientEventPianoSwitchPhaseT>();
		}

		// Token: 0x060372FD RID: 226045 RVA: 0x0077B104 File Offset: 0x00779304
		public static TClientEventPianoEventUnion FromIClientEventPianoSwitchPhase(IClientEventPianoSwitchPhaseT _iclienteventpianoswitchphase)
		{
			return new TClientEventPianoEventUnion
			{
				Type = TClientEventPianoEvent.IClientEventPianoSwitchPhase,
				Value = _iclienteventpianoswitchphase
			};
		}

		// Token: 0x060372FE RID: 226046 RVA: 0x0077B119 File Offset: 0x00779319
		public IClientEventPianoUpdateSubtitleT AsIClientEventPianoUpdateSubtitle()
		{
			return this.As<IClientEventPianoUpdateSubtitleT>();
		}

		// Token: 0x060372FF RID: 226047 RVA: 0x0077B121 File Offset: 0x00779321
		public static TClientEventPianoEventUnion FromIClientEventPianoUpdateSubtitle(IClientEventPianoUpdateSubtitleT _iclienteventpianoupdatesubtitle)
		{
			return new TClientEventPianoEventUnion
			{
				Type = TClientEventPianoEvent.IClientEventPianoUpdateSubtitle,
				Value = _iclienteventpianoupdatesubtitle
			};
		}

		// Token: 0x06037300 RID: 226048 RVA: 0x0077B138 File Offset: 0x00779338
		public static int Pack(FlatBufferBuilder builder, TClientEventPianoEventUnion _o)
		{
			TClientEventPianoEvent type = _o.Type;
			if (type == TClientEventPianoEvent.IClientEventPianoSwitchPhase)
			{
				return IClientEventPianoSwitchPhase.Pack(builder, _o.AsIClientEventPianoSwitchPhase()).Value;
			}
			if (type != TClientEventPianoEvent.IClientEventPianoUpdateSubtitle)
			{
				return 0;
			}
			return IClientEventPianoUpdateSubtitle.Pack(builder, _o.AsIClientEventPianoUpdateSubtitle()).Value;
		}
	}
}
