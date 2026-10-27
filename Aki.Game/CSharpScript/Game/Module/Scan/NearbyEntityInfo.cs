using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Scan
{
	// Token: 0x02004C91 RID: 19601
	internal class NearbyEntityInfo
	{
		// Token: 0x06032A9E RID: 207518 RVA: 0x00BD147B File Offset: 0x00BCF67B
		[NullableContext(1)]
		public NearbyEntityInfo(Entity entity, double distance)
		{
			this.Entity = entity;
			this.Distance = distance;
		}

		// Token: 0x0401AF7F RID: 110463
		[Nullable(2)]
		public Entity Entity;

		// Token: 0x0401AF80 RID: 110464
		public double Distance;
	}
}
