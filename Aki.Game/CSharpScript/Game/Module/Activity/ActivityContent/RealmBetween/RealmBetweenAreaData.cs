using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x02006269 RID: 25193
	[NullableContext(1)]
	[Nullable(0)]
	public class RealmBetweenAreaData
	{
		// Token: 0x0603F725 RID: 259877 RVA: 0x00F56814 File Offset: 0x00F54A14
		public RealmBetweenAreaData(int areaId)
		{
			this.AreaId = areaId;
		}

		// Token: 0x04021239 RID: 135737
		public int AreaId;

		// Token: 0x0402123A RID: 135738
		public HashSet<int> TravelTaskIdSet = new HashSet<int>();

		// Token: 0x0402123B RID: 135739
		public HashSet<int> PhantomTaskIdSet = new HashSet<int>();

		// Token: 0x0402123C RID: 135740
		public bool IsUnlock;
	}
}
