using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051E7 RID: 20967
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenAreaData
	{
		// Token: 0x060343E6 RID: 213990 RVA: 0x00E9D770 File Offset: 0x00E9B970
		public RealmBetweenAreaData(int areaId)
		{
			this.AreaId = areaId;
		}

		// Token: 0x0401BB68 RID: 113512
		public int AreaId;

		// Token: 0x0401BB69 RID: 113513
		public HashSet<int> TravelTaskIdSet = new HashSet<int>();

		// Token: 0x0401BB6A RID: 113514
		public HashSet<int> PhantomTaskIdSet = new HashSet<int>();

		// Token: 0x0401BB6B RID: 113515
		public bool IsUnlock;
	}
}
