using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E7 RID: 30695
	public class TTrackingEventTypeUnion
	{
		// Token: 0x1700E6DD RID: 59101
		// (get) Token: 0x06037AB4 RID: 228020 RVA: 0x00787136 File Offset: 0x00785336
		// (set) Token: 0x06037AB5 RID: 228021 RVA: 0x0078713E File Offset: 0x0078533E
		public TTrackingEventType Type { get; set; }

		// Token: 0x1700E6DE RID: 59102
		// (get) Token: 0x06037AB6 RID: 228022 RVA: 0x00787147 File Offset: 0x00785347
		// (set) Token: 0x06037AB7 RID: 228023 RVA: 0x0078714F File Offset: 0x0078534F
		public object Value { get; set; }

		// Token: 0x06037AB8 RID: 228024 RVA: 0x00787158 File Offset: 0x00785358
		public TTrackingEventTypeUnion()
		{
			this.Type = TTrackingEventType.NONE;
			this.Value = null;
		}

		// Token: 0x06037AB9 RID: 228025 RVA: 0x0078716E File Offset: 0x0078536E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037ABA RID: 228026 RVA: 0x00787180 File Offset: 0x00785380
		public IEasterEggTrackingEventT AsIEasterEggTrackingEvent()
		{
			return this.As<IEasterEggTrackingEventT>();
		}

		// Token: 0x06037ABB RID: 228027 RVA: 0x00787188 File Offset: 0x00785388
		public static TTrackingEventTypeUnion FromIEasterEggTrackingEvent(IEasterEggTrackingEventT _ieastereggtrackingevent)
		{
			return new TTrackingEventTypeUnion
			{
				Type = TTrackingEventType.IEasterEggTrackingEvent,
				Value = _ieastereggtrackingevent
			};
		}

		// Token: 0x06037ABC RID: 228028 RVA: 0x0078719D File Offset: 0x0078539D
		public IMotorParkourTrackingEventT AsIMotorParkourTrackingEvent()
		{
			return this.As<IMotorParkourTrackingEventT>();
		}

		// Token: 0x06037ABD RID: 228029 RVA: 0x007871A5 File Offset: 0x007853A5
		public static TTrackingEventTypeUnion FromIMotorParkourTrackingEvent(IMotorParkourTrackingEventT _imotorparkourtrackingevent)
		{
			return new TTrackingEventTypeUnion
			{
				Type = TTrackingEventType.IMotorParkourTrackingEvent,
				Value = _imotorparkourtrackingevent
			};
		}

		// Token: 0x06037ABE RID: 228030 RVA: 0x007871BC File Offset: 0x007853BC
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
