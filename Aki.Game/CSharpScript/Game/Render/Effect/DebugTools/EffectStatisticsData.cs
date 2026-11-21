using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Effect.Statistics;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x0200351F RID: 13599
	public class EffectStatisticsData
	{
		// Token: 0x040132DD RID: 78557
		public int RegisteredCountInterval;

		// Token: 0x040132DE RID: 78558
		public int ReleasedCountInterval;

		// Token: 0x040132DF RID: 78559
		public int CurrentCount;

		// Token: 0x040132E0 RID: 78560
		public int TickInFrameCount;

		// Token: 0x040132E1 RID: 78561
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<UEffectStatisticsEntryData_C> Entries;
	}
}
