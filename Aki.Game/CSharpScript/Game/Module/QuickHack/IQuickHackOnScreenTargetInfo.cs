using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F49 RID: 16201
	[NullableContext(1)]
	public interface IQuickHackOnScreenTargetInfo
	{
		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x0602904D RID: 168013
		// (set) Token: 0x0602904E RID: 168014
		Dictionary<int, int> TargetIdToIndexMap { get; set; }

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x0602904F RID: 168015
		// (set) Token: 0x06029050 RID: 168016
		List<EntityHandle> Targets { get; set; }

		// Token: 0x1700530B RID: 21259
		// (get) Token: 0x06029051 RID: 168017
		// (set) Token: 0x06029052 RID: 168018
		List<double> SignedScreenDistSquaredList { get; set; }

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x06029053 RID: 168019
		// (set) Token: 0x06029054 RID: 168020
		List<double> DistSquaredList { get; set; }
	}
}
