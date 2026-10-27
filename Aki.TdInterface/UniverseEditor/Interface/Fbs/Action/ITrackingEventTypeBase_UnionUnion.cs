using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007437 RID: 29751
	public class ITrackingEventTypeBase_UnionUnion
	{
		// Token: 0x1700E1E1 RID: 57825
		// (get) Token: 0x060360BC RID: 221372 RVA: 0x00759DE1 File Offset: 0x00757FE1
		// (set) Token: 0x060360BD RID: 221373 RVA: 0x00759DE9 File Offset: 0x00757FE9
		public ITrackingEventTypeBase_Union Type { get; set; }

		// Token: 0x1700E1E2 RID: 57826
		// (get) Token: 0x060360BE RID: 221374 RVA: 0x00759DF2 File Offset: 0x00757FF2
		// (set) Token: 0x060360BF RID: 221375 RVA: 0x00759DFA File Offset: 0x00757FFA
		public object Value { get; set; }

		// Token: 0x060360C0 RID: 221376 RVA: 0x00759E03 File Offset: 0x00758003
		public ITrackingEventTypeBase_UnionUnion()
		{
			this.Type = ITrackingEventTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060360C1 RID: 221377 RVA: 0x00759E19 File Offset: 0x00758019
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060360C2 RID: 221378 RVA: 0x00759E2B File Offset: 0x0075802B
		public ITrackingEventTypeBaseT AsITrackingEventTypeBase()
		{
			return this.As<ITrackingEventTypeBaseT>();
		}

		// Token: 0x060360C3 RID: 221379 RVA: 0x00759E33 File Offset: 0x00758033
		public static ITrackingEventTypeBase_UnionUnion FromITrackingEventTypeBase(ITrackingEventTypeBaseT _itrackingeventtypebase)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.ITrackingEventTypeBase,
				Value = _itrackingeventtypebase
			};
		}

		// Token: 0x060360C4 RID: 221380 RVA: 0x00759E48 File Offset: 0x00758048
		public IEasterEggTrackingEventT AsIEasterEggTrackingEvent()
		{
			return this.As<IEasterEggTrackingEventT>();
		}

		// Token: 0x060360C5 RID: 221381 RVA: 0x00759E50 File Offset: 0x00758050
		public static ITrackingEventTypeBase_UnionUnion FromIEasterEggTrackingEvent(IEasterEggTrackingEventT _ieastereggtrackingevent)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.IEasterEggTrackingEvent,
				Value = _ieastereggtrackingevent
			};
		}

		// Token: 0x060360C6 RID: 221382 RVA: 0x00759E65 File Offset: 0x00758065
		public IMotorParkourTrackingEventT AsIMotorParkourTrackingEvent()
		{
			return this.As<IMotorParkourTrackingEventT>();
		}

		// Token: 0x060360C7 RID: 221383 RVA: 0x00759E6D File Offset: 0x0075806D
		public static ITrackingEventTypeBase_UnionUnion FromIMotorParkourTrackingEvent(IMotorParkourTrackingEventT _imotorparkourtrackingevent)
		{
			return new ITrackingEventTypeBase_UnionUnion
			{
				Type = ITrackingEventTypeBase_Union.IMotorParkourTrackingEvent,
				Value = _imotorparkourtrackingevent
			};
		}

		// Token: 0x060360C8 RID: 221384 RVA: 0x00759E84 File Offset: 0x00758084
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
