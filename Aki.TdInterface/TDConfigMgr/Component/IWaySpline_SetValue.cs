using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000875 RID: 2165
	[NullableContext(2)]
	[Nullable(0)]
	public class IWaySpline_SetValue
	{
		// Token: 0x04001EDE RID: 7902
		public ESplineType Type;

		// Token: 0x04001EDF RID: 7903
		public int RoadZoneId;

		// Token: 0x04001EE0 RID: 7904
		public string PcgRoadPathName;

		// Token: 0x04001EE1 RID: 7905
		public bool? NoEntry;

		// Token: 0x04001EE2 RID: 7906
		public IPavedWayConfig PavedWayConfig;

		// Token: 0x04001EE3 RID: 7907
		[Nullable(0)]
		public List<IWaySplinePoint> Points;

		// Token: 0x04001EE4 RID: 7908
		public List<int> Last;

		// Token: 0x04001EE5 RID: 7909
		public List<int> Next;

		// Token: 0x04001EE6 RID: 7910
		public int? Opposite;

		// Token: 0x04001EE7 RID: 7911
		public float Width;
	}
}
