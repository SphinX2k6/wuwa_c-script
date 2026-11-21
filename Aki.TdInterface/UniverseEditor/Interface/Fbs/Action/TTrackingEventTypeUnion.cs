using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008025 RID: 32805
	public class TTrackingEventTypeUnion
	{
		// Token: 0x1700F33B RID: 62267
		// (get) Token: 0x0603B053 RID: 241747 RVA: 0x007EC9E2 File Offset: 0x007EABE2
		// (set) Token: 0x0603B054 RID: 241748 RVA: 0x007EC9EA File Offset: 0x007EABEA
		public TTrackingEventType Type { get; set; }

		// Token: 0x1700F33C RID: 62268
		// (get) Token: 0x0603B055 RID: 241749 RVA: 0x007EC9F3 File Offset: 0x007EABF3
		// (set) Token: 0x0603B056 RID: 241750 RVA: 0x007EC9FB File Offset: 0x007EABFB
		public object Value { get; set; }

		// Token: 0x0603B057 RID: 241751 RVA: 0x007ECA04 File Offset: 0x007EAC04
		public TTrackingEventTypeUnion()
		{
			this.Type = TTrackingEventType.NONE;
			this.Value = null;
		}

		// Token: 0x0603B058 RID: 241752 RVA: 0x007ECA1A File Offset: 0x007EAC1A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603B059 RID: 241753 RVA: 0x007ECA2C File Offset: 0x007EAC2C
		public IEasterEggTrackingEventT AsIEasterEggTrackingEvent()
		{
			return this.As<IEasterEggTrackingEventT>();
		}

		// Token: 0x0603B05A RID: 241754 RVA: 0x007ECA34 File Offset: 0x007EAC34
		public static TTrackingEventTypeUnion FromIEasterEggTrackingEvent(IEasterEggTrackingEventT _ieastereggtrackingevent)
		{
			return new TTrackingEventTypeUnion
			{
				Type = TTrackingEventType.IEasterEggTrackingEvent,
				Value = _ieastereggtrackingevent
			};
		}

		// Token: 0x0603B05B RID: 241755 RVA: 0x007ECA49 File Offset: 0x007EAC49
		public IMotorParkourTrackingEventT AsIMotorParkourTrackingEvent()
		{
			return this.As<IMotorParkourTrackingEventT>();
		}

		// Token: 0x0603B05C RID: 241756 RVA: 0x007ECA51 File Offset: 0x007EAC51
		public static TTrackingEventTypeUnion FromIMotorParkourTrackingEvent(IMotorParkourTrackingEventT _imotorparkourtrackingevent)
		{
			return new TTrackingEventTypeUnion
			{
				Type = TTrackingEventType.IMotorParkourTrackingEvent,
				Value = _imotorparkourtrackingevent
			};
		}

		// Token: 0x0603B05D RID: 241757 RVA: 0x007ECA68 File Offset: 0x007EAC68
		public static int Pack(FlatBufferBuilder builder, TTrackingEventTypeUnion _o)
		{
			TTrackingEventType type = _o.Type;
			if (type == TTrackingEventType.IEasterEggTrackingEvent)
			{
				return IEasterEggTrackingEvent.Pack(builder, _o.AsIEasterEggTrackingEvent()).Value;
			}
			if (type != TTrackingEventType.IMotorParkourTrackingEvent)
			{
				return 0;
			}
			return IMotorParkourTrackingEvent.Pack(builder, _o.AsIMotorParkourTrackingEvent()).Value;
		}
	}
}
