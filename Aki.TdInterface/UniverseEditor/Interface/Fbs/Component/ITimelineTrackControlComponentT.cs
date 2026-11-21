using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200608A RID: 24714
	public class ITimelineTrackControlComponentT
	{
		// Token: 0x1700B7B6 RID: 47030
		// (get) Token: 0x06029CCB RID: 171211 RVA: 0x005B5039 File Offset: 0x005B3239
		// (set) Token: 0x06029CCC RID: 171212 RVA: 0x005B5041 File Offset: 0x005B3241
		public bool Disabled { get; set; }

		// Token: 0x1700B7B7 RID: 47031
		// (get) Token: 0x06029CCD RID: 171213 RVA: 0x005B504A File Offset: 0x005B324A
		// (set) Token: 0x06029CCE RID: 171214 RVA: 0x005B5052 File Offset: 0x005B3252
		public List<ITimelineControlGroupT> ControlGroups { get; set; }

		// Token: 0x1700B7B8 RID: 47032
		// (get) Token: 0x06029CCF RID: 171215 RVA: 0x005B505B File Offset: 0x005B325B
		// (set) Token: 0x06029CD0 RID: 171216 RVA: 0x005B5063 File Offset: 0x005B3263
		public byte NullMask { get; set; }

		// Token: 0x06029CD1 RID: 171217 RVA: 0x005B506C File Offset: 0x005B326C
		public ITimelineTrackControlComponentT()
		{
			this.Disabled = false;
			this.ControlGroups = null;
			this.NullMask = 0;
		}
	}
}
