using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B39 RID: 19257
	[NullableContext(1)]
	public interface ITowerDefenseParsedStageMessage
	{
		// Token: 0x17007B9D RID: 31645
		// (get) Token: 0x06031DFA RID: 204282
		// (set) Token: 0x06031DFB RID: 204283
		TowerDefenceInstanceInfo Meta { get; set; }

		// Token: 0x17007B9E RID: 31646
		// (get) Token: 0x06031DFC RID: 204284
		// (set) Token: 0x06031DFD RID: 204285
		int Id { get; set; }

		// Token: 0x17007B9F RID: 31647
		// (get) Token: 0x06031DFE RID: 204286
		// (set) Token: 0x06031DFF RID: 204287
		long UnlockTime { get; set; }

		// Token: 0x17007BA0 RID: 31648
		// (get) Token: 0x06031E00 RID: 204288
		// (set) Token: 0x06031E01 RID: 204289
		bool Passed { get; set; }

		// Token: 0x17007BA1 RID: 31649
		// (get) Token: 0x06031E02 RID: 204290
		// (set) Token: 0x06031E03 RID: 204291
		double PassTime { get; set; }

		// Token: 0x17007BA2 RID: 31650
		// (get) Token: 0x06031E04 RID: 204292
		// (set) Token: 0x06031E05 RID: 204293
		bool Rewarded { get; set; }

		// Token: 0x17007BA3 RID: 31651
		// (get) Token: 0x06031E06 RID: 204294
		// (set) Token: 0x06031E07 RID: 204295
		int Record { get; set; }

		// Token: 0x17007BA4 RID: 31652
		// (get) Token: 0x06031E08 RID: 204296
		// (set) Token: 0x06031E09 RID: 204297
		bool RecordOverThreshold { get; set; }
	}
}
