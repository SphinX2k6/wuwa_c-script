using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC7 RID: 23751
	public class TTimelineTrackControlConfigUnion
	{
		// Token: 0x1700B262 RID: 45666
		// (get) Token: 0x06028A6F RID: 166511 RVA: 0x00595DD0 File Offset: 0x00593FD0
		// (set) Token: 0x06028A70 RID: 166512 RVA: 0x00595DD8 File Offset: 0x00593FD8
		public TTimelineTrackControlConfig Type { get; set; }

		// Token: 0x1700B263 RID: 45667
		// (get) Token: 0x06028A71 RID: 166513 RVA: 0x00595DE1 File Offset: 0x00593FE1
		// (set) Token: 0x06028A72 RID: 166514 RVA: 0x00595DE9 File Offset: 0x00593FE9
		public object Value { get; set; }

		// Token: 0x06028A73 RID: 166515 RVA: 0x00595DF2 File Offset: 0x00593FF2
		public TTimelineTrackControlConfigUnion()
		{
			this.Type = TTimelineTrackControlConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028A74 RID: 166516 RVA: 0x00595E08 File Offset: 0x00594008
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028A75 RID: 166517 RVA: 0x00595E1A File Offset: 0x0059401A
		public IEntityTrackControlT AsIEntityTrackControl()
		{
			return this.As<IEntityTrackControlT>();
		}

		// Token: 0x06028A76 RID: 166518 RVA: 0x00595E22 File Offset: 0x00594022
		public static TTimelineTrackControlConfigUnion FromIEntityTrackControl(IEntityTrackControlT _ientitytrackcontrol)
		{
			return new TTimelineTrackControlConfigUnion
			{
				Type = TTimelineTrackControlConfig.IEntityTrackControl,
				Value = _ientitytrackcontrol
			};
		}

		// Token: 0x06028A77 RID: 166519 RVA: 0x00595E37 File Offset: 0x00594037
		public ISequenceTrackControlT AsISequenceTrackControl()
		{
			return this.As<ISequenceTrackControlT>();
		}

		// Token: 0x06028A78 RID: 166520 RVA: 0x00595E3F File Offset: 0x0059403F
		public static TTimelineTrackControlConfigUnion FromISequenceTrackControl(ISequenceTrackControlT _isequencetrackcontrol)
		{
			return new TTimelineTrackControlConfigUnion
			{
				Type = TTimelineTrackControlConfig.ISequenceTrackControl,
				Value = _isequencetrackcontrol
			};
		}

		// Token: 0x06028A79 RID: 166521 RVA: 0x00595E54 File Offset: 0x00594054
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
