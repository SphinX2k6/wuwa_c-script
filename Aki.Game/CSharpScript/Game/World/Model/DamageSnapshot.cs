using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.World.Model
{
	// Token: 0x0200452A RID: 17706
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class DamageSnapshot
	{
		// Token: 0x0602DBBF RID: 187327 RVA: 0x00A824E8 File Offset: 0x00A806E8
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

		// Token: 0x040186A4 RID: 100004
		public readonly Damage Config;

		// Token: 0x040186A5 RID: 100005
		public readonly long Id;

		// Token: 0x040186A6 RID: 100006
		public readonly string Condition;

		// Token: 0x040186A7 RID: 100007
		public readonly int CalculateType;

		// Token: 0x040186A8 RID: 100008
		public readonly int Type;

		// Token: 0x040186A9 RID: 100009
		public readonly int SmashType;

		// Token: 0x040186AA RID: 100010
		public readonly int Element;

		// Token: 0x040186AB RID: 100011
		public readonly int[] SubTypes;
	}
}
