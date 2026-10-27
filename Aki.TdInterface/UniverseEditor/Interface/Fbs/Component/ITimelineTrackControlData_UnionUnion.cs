using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A83 RID: 23171
	public class ITimelineTrackControlData_UnionUnion
	{
		// Token: 0x1700AE84 RID: 44676
		// (get) Token: 0x0602776D RID: 161645 RVA: 0x0056E259 File Offset: 0x0056C459
		// (set) Token: 0x0602776E RID: 161646 RVA: 0x0056E261 File Offset: 0x0056C461
		public ITimelineTrackControlData_Union Type { get; set; }

		// Token: 0x1700AE85 RID: 44677
		// (get) Token: 0x0602776F RID: 161647 RVA: 0x0056E26A File Offset: 0x0056C46A
		// (set) Token: 0x06027770 RID: 161648 RVA: 0x0056E272 File Offset: 0x0056C472
		public object Value { get; set; }

		// Token: 0x06027771 RID: 161649 RVA: 0x0056E27B File Offset: 0x0056C47B
		public ITimelineTrackControlData_UnionUnion()
		{
			this.Type = ITimelineTrackControlData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027772 RID: 161650 RVA: 0x0056E291 File Offset: 0x0056C491
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027773 RID: 161651 RVA: 0x0056E2A3 File Offset: 0x0056C4A3
		public ITimelineTrackControlDataT AsITimelineTrackControlData()
		{
			return this.As<ITimelineTrackControlDataT>();
		}

		// Token: 0x06027774 RID: 161652 RVA: 0x0056E2AB File Offset: 0x0056C4AB
		public static ITimelineTrackControlData_UnionUnion FromITimelineTrackControlData(ITimelineTrackControlDataT _itimelinetrackcontroldata)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.ITimelineTrackControlData,
				Value = _itimelinetrackcontroldata
			};
		}

		// Token: 0x06027775 RID: 161653 RVA: 0x0056E2C0 File Offset: 0x0056C4C0
		public ISequenceTrackControlT AsISequenceTrackControl()
		{
			return this.As<ISequenceTrackControlT>();
		}

		// Token: 0x06027776 RID: 161654 RVA: 0x0056E2C8 File Offset: 0x0056C4C8
		public static ITimelineTrackControlData_UnionUnion FromISequenceTrackControl(ISequenceTrackControlT _isequencetrackcontrol)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.ISequenceTrackControl,
				Value = _isequencetrackcontrol
			};
		}

		// Token: 0x06027777 RID: 161655 RVA: 0x0056E2DD File Offset: 0x0056C4DD
		public IEntityTrackControlT AsIEntityTrackControl()
		{
			return this.As<IEntityTrackControlT>();
		}

		// Token: 0x06027778 RID: 161656 RVA: 0x0056E2E5 File Offset: 0x0056C4E5
		public static ITimelineTrackControlData_UnionUnion FromIEntityTrackControl(IEntityTrackControlT _ientitytrackcontrol)
		{
			return new ITimelineTrackControlData_UnionUnion
			{
				Type = ITimelineTrackControlData_Union.IEntityTrackControl,
				Value = _ientitytrackcontrol
			};
		}

		// Token: 0x06027779 RID: 161657 RVA: 0x0056E2FC File Offset: 0x0056C4FC
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
