using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057C9 RID: 22473
	[NullableContext(1)]
	[Nullable(0)]
	public class RewardExploreTargetReachedData : IRewardExploreTargetReached
	{
		// Token: 0x1700899F RID: 35231
		// (get) Token: 0x06039246 RID: 234054 RVA: 0x00D9007A File Offset: 0x00D8E27A
		// (set) Token: 0x06039247 RID: 234055 RVA: 0x00D90082 File Offset: 0x00D8E282
		public List<string> Target { get; set; }

		// Token: 0x170089A0 RID: 35232
		// (get) Token: 0x06039248 RID: 234056 RVA: 0x00D9008B File Offset: 0x00D8E28B
		// (set) Token: 0x06039249 RID: 234057 RVA: 0x00D90093 File Offset: 0x00D8E293
		public string DescriptionTextId { get; set; }

		// Token: 0x170089A1 RID: 35233
		// (get) Token: 0x0603924A RID: 234058 RVA: 0x00D9009C File Offset: 0x00D8E29C
		// (set) Token: 0x0603924B RID: 234059 RVA: 0x00D900A4 File Offset: 0x00D8E2A4
		public bool IsReached { get; set; }
	}
}
