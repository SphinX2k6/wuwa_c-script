using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061C6 RID: 25030
	[NullableContext(1)]
	[Nullable(0)]
	public class RoadBookAreaData
	{
		// Token: 0x0603F3AD RID: 258989 RVA: 0x00F470F3 File Offset: 0x00F452F3
		public RoadBookAreaData(int areaId)
		{
			this.AreaId = areaId;
		}

		// Token: 0x04020F2B RID: 134955
		public int AreaId;

		// Token: 0x04020F2C RID: 134956
		public HashSet<int> TravelTaskIdSet = new HashSet<int>();

		// Token: 0x04020F2D RID: 134957
		public HashSet<int> PhantomTaskIdSet = new HashSet<int>();

		// Token: 0x04020F2E RID: 134958
		public bool IsUnlock;
	}
}
