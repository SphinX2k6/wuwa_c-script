using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x0200344F RID: 13391
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class DamageSnapshot
	{
		// Token: 0x06022286 RID: 139910 RVA: 0x009AD700 File Offset: 0x009AB900
		public DamageSnapshot(Damage config)
		{
			this.Config = config;
			this.Id = config.Id;
			this.Condition = config.Condition;
			this.CalculateType = config.CalculateType;
			this.Type = config.Type;
			this.SmashType = config.SmashType;
			this.Element = config.Element;
			this.SubTypes = config.GetSubTypeArray();
		}

		// Token: 0x04012CC8 RID: 77000
		public readonly Damage Config;

		// Token: 0x04012CC9 RID: 77001
		public readonly long Id;

		// Token: 0x04012CCA RID: 77002
		public readonly string Condition;

		// Token: 0x04012CCB RID: 77003
		public readonly int CalculateType;

		// Token: 0x04012CCC RID: 77004
		public readonly int Type;

		// Token: 0x04012CCD RID: 77005
		public readonly int SmashType;

		// Token: 0x04012CCE RID: 77006
		public readonly int Element;

		// Token: 0x04012CCF RID: 77007
		public readonly int[] SubTypes;
	}
}
