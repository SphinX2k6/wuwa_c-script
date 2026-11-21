using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C2A RID: 31786
	public class ITrackingEventTypeBase_UnionUnion
	{
		// Token: 0x1700EDFE RID: 60926
		// (get) Token: 0x060394A5 RID: 234661 RVA: 0x007BCB0D File Offset: 0x007BAD0D
		// (set) Token: 0x060394A6 RID: 234662 RVA: 0x007BCB15 File Offset: 0x007BAD15
		public ITrackingEventTypeBase_Union Type { get; set; }

		// Token: 0x1700EDFF RID: 60927
		// (get) Token: 0x060394A7 RID: 234663 RVA: 0x007BCB1E File Offset: 0x007BAD1E
		// (set) Token: 0x060394A8 RID: 234664 RVA: 0x007BCB26 File Offset: 0x007BAD26
		public object Value { get; set; }

		// Token: 0x060394A9 RID: 234665 RVA: 0x007BCB2F File Offset: 0x007BAD2F
		public ITrackingEventTypeBase_UnionUnion()
		{
			this.Type = ITrackingEventTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060394AA RID: 234666 RVA: 0x007BCB45 File Offset: 0x007BAD45
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060394AB RID: 234667 RVA: 0x007BCB57 File Offset: 0x007BAD57
		public ITrackingEventTypeBaseT AsITrackingEventTypeBase()
		{
			return this.As<ITrackingEventTypeBaseT>();
		}

		// Token: 0x060394AC RID: 234668 RVA: 0x007BCB5F File Offset: 0x007BAD5F
		public static ITrackingEventTypeBase_UnionUnion FromITrackingEventTypeBase(ITrackingEventTypeBaseT _itrackingeventtypebase)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.ITrackingEventTypeBase,
				Value = _itrackingeventtypebase
			};
		}

		// Token: 0x060394AD RID: 234669 RVA: 0x007BCB74 File Offset: 0x007BAD74
		public IEasterEggTrackingEventT AsIEasterEggTrackingEvent()
		{
			return this.As<IEasterEggTrackingEventT>();
		}

		// Token: 0x060394AE RID: 234670 RVA: 0x007BCB7C File Offset: 0x007BAD7C
		public static ITrackingEventTypeBase_UnionUnion FromIEasterEggTrackingEvent(IEasterEggTrackingEventT _ieastereggtrackingevent)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.IEasterEggTrackingEvent,
				Value = _ieastereggtrackingevent
			};
		}

		// Token: 0x060394AF RID: 234671 RVA: 0x007BCB91 File Offset: 0x007BAD91
		public IMotorParkourTrackingEventT AsIMotorParkourTrackingEvent()
		{
			return this.As<IMotorParkourTrackingEventT>();
		}

		// Token: 0x060394B0 RID: 234672 RVA: 0x007BCB99 File Offset: 0x007BAD99
		public static ITrackingEventTypeBase_UnionUnion FromIMotorParkourTrackingEvent(IMotorParkourTrackingEventT _imotorparkourtrackingevent)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.IMotorParkourTrackingEvent,
				Value = _imotorparkourtrackingevent
			};
		}

		// Token: 0x060394B1 RID: 234673 RVA: 0x007BCBB0 File Offset: 0x007BADB0
		public static int Pack(FlatBufferBuilder builder, ITrackingEventTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITrackingEventTypeBase_Union.ITrackingEventTypeBase:
				return ITrackingEventTypeBase.Pack(builder, _o.AsITrackingEventTypeBase()).Value;
			case ITrackingEventTypeBase_Union.IEasterEggTrackingEvent:
				return IEasterEggTrackingEvent.Pack(builder, _o.AsIEasterEggTrackingEvent()).Value;
			case ITrackingEventTypeBase_Union.IMotorParkourTrackingEvent:
				return IMotorParkourTrackingEvent.Pack(builder, _o.AsIMotorParkourTrackingEvent()).Value;
			default:
				return 0;
			}
		}
	}
}
