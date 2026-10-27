using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020007D2 RID: 2002
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline_SetValue
	{
		// Token: 0x04001CD2 RID: 7378
		public ESplineType Type;

		// Token: 0x04001CD3 RID: 7379
		public int RoadZoneId;

		// Token: 0x04001CD4 RID: 7380
		public string PcgRoadPathName;

		// Token: 0x04001CD5 RID: 7381
		public bool? NoEntry;

		// Token: 0x04001CD6 RID: 7382
		public IPavedWayConfig PavedWayConfig;

		// Token: 0x04001CD7 RID: 7383
		[Nullable(1)]
		public List<IWaySplinePoint> Points;

		// Token: 0x04001CD8 RID: 7384
		public List<int> Last;

		// Token: 0x04001CD9 RID: 7385
		public List<int> Next;

		// Token: 0x04001CDA RID: 7386
		public int? Opposite;

		// Token: 0x04001CDB RID: 7387
		public float Width;
	}
}
