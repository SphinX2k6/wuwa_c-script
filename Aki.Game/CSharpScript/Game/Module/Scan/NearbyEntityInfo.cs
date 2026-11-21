using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02003C42 RID: 15426
	internal class NearbyEntityInfo
	{
		// Token: 0x06027851 RID: 161873 RVA: 0x00B160DF File Offset: 0x00B142DF
		[NullableContext(1)]
		public NearbyEntityInfo(Entity entity, double distance)
		{
			this.Entity = entity;
			this.Distance = distance;
		}

		// Token: 0x040158DC RID: 88284
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x040158DD RID: 88285
		public double Distance;
	}
}
