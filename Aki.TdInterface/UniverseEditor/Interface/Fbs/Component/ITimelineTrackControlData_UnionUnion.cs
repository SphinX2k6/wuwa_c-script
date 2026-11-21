using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006090 RID: 24720
	public class ITimelineTrackControlData_UnionUnion
	{
		// Token: 0x1700B7BC RID: 47036
		// (get) Token: 0x06029CE5 RID: 171237 RVA: 0x005B5265 File Offset: 0x005B3465
		// (set) Token: 0x06029CE6 RID: 171238 RVA: 0x005B526D File Offset: 0x005B346D
		public ITimelineTrackControlData_Union Type { get; set; }

		// Token: 0x1700B7BD RID: 47037
		// (get) Token: 0x06029CE7 RID: 171239 RVA: 0x005B5276 File Offset: 0x005B3476
		// (set) Token: 0x06029CE8 RID: 171240 RVA: 0x005B527E File Offset: 0x005B347E
		public object Value { get; set; }

		// Token: 0x06029CE9 RID: 171241 RVA: 0x005B5287 File Offset: 0x005B3487
		public ITimelineTrackControlData_UnionUnion()
		{
			this.Type = ITimelineTrackControlData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029CEA RID: 171242 RVA: 0x005B529D File Offset: 0x005B349D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029CEB RID: 171243 RVA: 0x005B52AF File Offset: 0x005B34AF
		public ITimelineTrackControlDataT AsITimelineTrackControlData()
		{
			return this.As<ITimelineTrackControlDataT>();
		}

		// Token: 0x06029CEC RID: 171244 RVA: 0x005B52B7 File Offset: 0x005B34B7
		public static ITimelineTrackControlData_UnionUnion FromITimelineTrackControlData(ITimelineTrackControlDataT _itimelinetrackcontroldata)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.ITimelineTrackControlData,
				Value = _itimelinetrackcontroldata
			};
		}

		// Token: 0x06029CED RID: 171245 RVA: 0x005B52CC File Offset: 0x005B34CC
		public ISequenceTrackControlT AsISequenceTrackControl()
		{
			return this.As<ISequenceTrackControlT>();
		}

		// Token: 0x06029CEE RID: 171246 RVA: 0x005B52D4 File Offset: 0x005B34D4
		public static ITimelineTrackControlData_UnionUnion FromISequenceTrackControl(ISequenceTrackControlT _isequencetrackcontrol)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.ISequenceTrackControl,
				Value = _isequencetrackcontrol
			};
		}

		// Token: 0x06029CEF RID: 171247 RVA: 0x005B52E9 File Offset: 0x005B34E9
		public IEntityTrackControlT AsIEntityTrackControl()
		{
			return this.As<IEntityTrackControlT>();
		}

		// Token: 0x06029CF0 RID: 171248 RVA: 0x005B52F1 File Offset: 0x005B34F1
		public static ITimelineTrackControlData_UnionUnion FromIEntityTrackControl(IEntityTrackControlT _ientitytrackcontrol)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.IEntityTrackControl,
				Value = _ientitytrackcontrol
			};
		}

		// Token: 0x06029CF1 RID: 171249 RVA: 0x005B5308 File Offset: 0x005B3508
		public static int Pack(FlatBufferBuilder builder, ITimelineTrackControlData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITimelineTrackControlData_Union.ITimelineTrackControlData:
				return ITimelineTrackControlData.Pack(builder, _o.AsITimelineTrackControlData()).Value;
			case ITimelineTrackControlData_Union.ISequenceTrackControl:
				return ISequenceTrackControl.Pack(builder, _o.AsISequenceTrackControl()).Value;
			case ITimelineTrackControlData_Union.IEntityTrackControl:
				return IEntityTrackControl.Pack(builder, _o.AsIEntityTrackControl()).Value;
			default:
				return 0;
			}
		}
	}
}
