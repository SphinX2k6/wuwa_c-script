using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x020045F6 RID: 17910
	public class EffectStatisticsData
	{
		// Token: 0x04018C9E RID: 101534
		public int RegisteredCountInterval;

		// Token: 0x04018C9F RID: 101535
		public int ReleasedCountInterval;

		// Token: 0x04018CA0 RID: 101536
		public int CurrentCount;

		// Token: 0x04018CA1 RID: 101537
		public int TickInFrameCount;

		// Token: 0x04018CA2 RID: 101538
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UEffectStatisticsEntryData_C> Entries;
	}
}
