using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E80 RID: 32384
	public class TClientEventPianoEventUnion
	{
		// Token: 0x1700F21D RID: 61981
		// (get) Token: 0x0603A79B RID: 239515 RVA: 0x007DF1AE File Offset: 0x007DD3AE
		// (set) Token: 0x0603A79C RID: 239516 RVA: 0x007DF1B6 File Offset: 0x007DD3B6
		public TClientEventPianoEvent Type { get; set; }

		// Token: 0x1700F21E RID: 61982
		// (get) Token: 0x0603A79D RID: 239517 RVA: 0x007DF1BF File Offset: 0x007DD3BF
		// (set) Token: 0x0603A79E RID: 239518 RVA: 0x007DF1C7 File Offset: 0x007DD3C7
		public object Value { get; set; }

		// Token: 0x0603A79F RID: 239519 RVA: 0x007DF1D0 File Offset: 0x007DD3D0
		public TClientEventPianoEventUnion()
		{
			this.Type = TClientEventPianoEvent.NONE;
			this.Value = null;
		}

		// Token: 0x0603A7A0 RID: 239520 RVA: 0x007DF1E6 File Offset: 0x007DD3E6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A7A1 RID: 239521 RVA: 0x007DF1F8 File Offset: 0x007DD3F8
		public IClientEventPianoSwitchPhaseT AsIClientEventPianoSwitchPhase()
		{
			return this.As<IClientEventPianoSwitchPhaseT>();
		}

		// Token: 0x0603A7A2 RID: 239522 RVA: 0x007DF200 File Offset: 0x007DD400
		public static TClientEventPianoEventUnion FromIClientEventPianoSwitchPhase(IClientEventPianoSwitchPhaseT _iclienteventpianoswitchphase)
		{
			return new TClientEventPianoEventUnion
			{
				Type = TClientEventPianoEvent.IClientEventPianoSwitchPhase,
				Value = _iclienteventpianoswitchphase
			};
		}

		// Token: 0x0603A7A3 RID: 239523 RVA: 0x007DF215 File Offset: 0x007DD415
		public IClientEventPianoUpdateSubtitleT AsIClientEventPianoUpdateSubtitle()
		{
			return this.As<IClientEventPianoUpdateSubtitleT>();
		}

		// Token: 0x0603A7A4 RID: 239524 RVA: 0x007DF21D File Offset: 0x007DD41D
		public static TClientEventPianoEventUnion FromIClientEventPianoUpdateSubtitle(IClientEventPianoUpdateSubtitleT _iclienteventpianoupdatesubtitle)
		{
			return new TClientEventPianoEventUnion
			{
				Type = TClientEventPianoEvent.IClientEventPianoUpdateSubtitle,
				Value = _iclienteventpianoupdatesubtitle
			};
		}

		// Token: 0x0603A7A5 RID: 239525 RVA: 0x007DF234 File Offset: 0x007DD434
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
