using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A15 RID: 27157
	public class IClientEventPianoEvent_UnionUnion
	{
		// Token: 0x1700C7AA RID: 51114
		// (get) Token: 0x0602E967 RID: 190823 RVA: 0x0065A791 File Offset: 0x00658991
		// (set) Token: 0x0602E968 RID: 190824 RVA: 0x0065A799 File Offset: 0x00658999
		public IClientEventPianoEvent_Union Type { get; set; }

		// Token: 0x1700C7AB RID: 51115
		// (get) Token: 0x0602E969 RID: 190825 RVA: 0x0065A7A2 File Offset: 0x006589A2
		// (set) Token: 0x0602E96A RID: 190826 RVA: 0x0065A7AA File Offset: 0x006589AA
		public object Value { get; set; }

		// Token: 0x0602E96B RID: 190827 RVA: 0x0065A7B3 File Offset: 0x006589B3
		public IClientEventPianoEvent_UnionUnion()
		{
			this.Type = IClientEventPianoEvent_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602E96C RID: 190828 RVA: 0x0065A7C9 File Offset: 0x006589C9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602E96D RID: 190829 RVA: 0x0065A7DB File Offset: 0x006589DB
		public IClientEventPianoEventT AsIClientEventPianoEvent()
		{
			return this.As<IClientEventPianoEventT>();
		}

		// Token: 0x0602E96E RID: 190830 RVA: 0x0065A7E3 File Offset: 0x006589E3
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoEvent(IClientEventPianoEventT _iclienteventpianoevent)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoEvent,
				Value = _iclienteventpianoevent
			};
		}

		// Token: 0x0602E96F RID: 190831 RVA: 0x0065A7F8 File Offset: 0x006589F8
		public IClientEventPianoUpdateSubtitleT AsIClientEventPianoUpdateSubtitle()
		{
			return this.As<IClientEventPianoUpdateSubtitleT>();
		}

		// Token: 0x0602E970 RID: 190832 RVA: 0x0065A800 File Offset: 0x00658A00
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoUpdateSubtitle(IClientEventPianoUpdateSubtitleT _iclienteventpianoupdatesubtitle)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoUpdateSubtitle,
				Value = _iclienteventpianoupdatesubtitle
			};
		}

		// Token: 0x0602E971 RID: 190833 RVA: 0x0065A815 File Offset: 0x00658A15
		public IClientEventPianoSwitchPhaseT AsIClientEventPianoSwitchPhase()
		{
			return this.As<IClientEventPianoSwitchPhaseT>();
		}

		// Token: 0x0602E972 RID: 190834 RVA: 0x0065A81D File Offset: 0x00658A1D
		public static IClientEventPianoEvent_UnionUnion FromIClientEventPianoSwitchPhase(IClientEventPianoSwitchPhaseT _iclienteventpianoswitchphase)
		{
			return new IClientEventPianoEvent_UnionUnion
			{
				Type = IClientEventPianoEvent_Union.IClientEventPianoSwitchPhase,
				Value = _iclienteventpianoswitchphase
			};
		}

		// Token: 0x0602E973 RID: 190835 RVA: 0x0065A834 File Offset: 0x00658A34
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
