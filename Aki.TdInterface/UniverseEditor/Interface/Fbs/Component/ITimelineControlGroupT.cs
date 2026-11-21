using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006087 RID: 24711
	public class ITimelineControlGroupT
	{
		// Token: 0x1700B7AB RID: 47019
		// (get) Token: 0x06029CA3 RID: 171171 RVA: 0x005B4B4F File Offset: 0x005B2D4F
		// (set) Token: 0x06029CA4 RID: 171172 RVA: 0x005B4B57 File Offset: 0x005B2D57
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B7AC RID: 47020
		// (get) Token: 0x06029CA5 RID: 171173 RVA: 0x005B4B60 File Offset: 0x005B2D60
		// (set) Token: 0x06029CA6 RID: 171174 RVA: 0x005B4B68 File Offset: 0x005B2D68
		public string TidContent { get; set; }

		// Token: 0x1700B7AD RID: 47021
		// (get) Token: 0x06029CA7 RID: 171175 RVA: 0x005B4B71 File Offset: 0x005B2D71
		// (set) Token: 0x06029CA8 RID: 171176 RVA: 0x005B4B79 File Offset: 0x005B2D79
		public float SegmentTime { get; set; }

		// Token: 0x1700B7AE RID: 47022
		// (get) Token: 0x06029CA9 RID: 171177 RVA: 0x005B4B82 File Offset: 0x005B2D82
		// (set) Token: 0x06029CAA RID: 171178 RVA: 0x005B4B8A File Offset: 0x005B2D8A
		public List<TTimelineTrackControlConfigUnion> ControlConfigs { get; set; }

		// Token: 0x1700B7AF RID: 47023
		// (get) Token: 0x06029CAB RID: 171179 RVA: 0x005B4B93 File Offset: 0x005B2D93
		// (set) Token: 0x06029CAC RID: 171180 RVA: 0x005B4B9B File Offset: 0x005B2D9B
		public List<IControlPointEventConfigT> ControlPointEvents { get; set; }

		// Token: 0x1700B7B0 RID: 47024
		// (get) Token: 0x06029CAD RID: 171181 RVA: 0x005B4BA4 File Offset: 0x005B2DA4
		// (set) Token: 0x06029CAE RID: 171182 RVA: 0x005B4BAC File Offset: 0x005B2DAC
		public string Description { get; set; }

		// Token: 0x1700B7B1 RID: 47025
		// (get) Token: 0x06029CAF RID: 171183 RVA: 0x005B4BB5 File Offset: 0x005B2DB5
		// (set) Token: 0x06029CB0 RID: 171184 RVA: 0x005B4BBD File Offset: 0x005B2DBD
		public byte NullMask { get; set; }

		// Token: 0x06029CB1 RID: 171185 RVA: 0x005B4BC6 File Offset: 0x005B2DC6
		public ITimelineControlGroupT()
		{
			this.Condition = null;
			this.TidContent = null;
			this.SegmentTime = 0f;
			this.ControlConfigs = null;
			this.ControlPointEvents = null;
			this.Description = null;
			this.NullMask = 0;
		}
	}
}
