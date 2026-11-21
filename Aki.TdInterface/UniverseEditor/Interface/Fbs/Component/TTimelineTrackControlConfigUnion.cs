using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F8 RID: 25336
	public class TTimelineTrackControlConfigUnion
	{
		// Token: 0x1700BBBC RID: 48060
		// (get) Token: 0x0602B0B7 RID: 176311 RVA: 0x005DE544 File Offset: 0x005DC744
		// (set) Token: 0x0602B0B8 RID: 176312 RVA: 0x005DE54C File Offset: 0x005DC74C
		public TTimelineTrackControlConfig Type { get; set; }

		// Token: 0x1700BBBD RID: 48061
		// (get) Token: 0x0602B0B9 RID: 176313 RVA: 0x005DE555 File Offset: 0x005DC755
		// (set) Token: 0x0602B0BA RID: 176314 RVA: 0x005DE55D File Offset: 0x005DC75D
		public object Value { get; set; }

		// Token: 0x0602B0BB RID: 176315 RVA: 0x005DE566 File Offset: 0x005DC766
		public TTimelineTrackControlConfigUnion()
		{
			this.Type = TTimelineTrackControlConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0BC RID: 176316 RVA: 0x005DE57C File Offset: 0x005DC77C
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0BD RID: 176317 RVA: 0x005DE58E File Offset: 0x005DC78E
		public IEntityTrackControlT AsIEntityTrackControl()
		{
			return this.As<IEntityTrackControlT>();
		}

		// Token: 0x0602B0BE RID: 176318 RVA: 0x005DE596 File Offset: 0x005DC796
		public static TTimelineTrackControlConfigUnion FromIEntityTrackControl(IEntityTrackControlT _ientitytrackcontrol)
		{
			return new TTimelineTrackControlConfigUnion
			{
				Type = TTimelineTrackControlConfig.IEntityTrackControl,
				Value = _ientitytrackcontrol
			};
		}

		// Token: 0x0602B0BF RID: 176319 RVA: 0x005DE5AB File Offset: 0x005DC7AB
		public ISequenceTrackControlT AsISequenceTrackControl()
		{
			return this.As<ISequenceTrackControlT>();
		}

		// Token: 0x0602B0C0 RID: 176320 RVA: 0x005DE5B3 File Offset: 0x005DC7B3
		public static TTimelineTrackControlConfigUnion FromISequenceTrackControl(ISequenceTrackControlT _isequencetrackcontrol)
		{
			return new TTimelineTrackControlConfigUnion
			{
				Type = TTimelineTrackControlConfig.ISequenceTrackControl,
				Value = _isequencetrackcontrol
			};
		}

		// Token: 0x0602B0C1 RID: 176321 RVA: 0x005DE5C8 File Offset: 0x005DC7C8
		public static int Pack(FlatBufferBuilder builder, TTimelineTrackControlConfigUnion _o)
		{
			TTimelineTrackControlConfig type = _o.Type;
			if (type == TTimelineTrackControlConfig.IEntityTrackControl)
			{
				return IEntityTrackControl.Pack(builder, _o.AsIEntityTrackControl()).Value;
			}
			if (type != TTimelineTrackControlConfig.ISequenceTrackControl)
			{
				return 0;
			}
			return ISequenceTrackControl.Pack(builder, _o.AsISequenceTrackControl()).Value;
		}
	}
}
