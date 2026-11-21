using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005144 RID: 20804
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookAreaData
	{
		// Token: 0x0603406E RID: 213102 RVA: 0x00E8E04B File Offset: 0x00E8C24B
		public RoadBookAreaData(int areaId)
		{
			this.AreaId = areaId;
		}

		// Token: 0x0401B85A RID: 112730
		public int AreaId;

		// Token: 0x0401B85B RID: 112731
		public HashSet<int> TravelTaskIdSet = new HashSet<int>();

		// Token: 0x0401B85C RID: 112732
		public HashSet<int> PhantomTaskIdSet = new HashSet<int>();

		// Token: 0x0401B85D RID: 112733
		public bool IsUnlock;
	}
}
