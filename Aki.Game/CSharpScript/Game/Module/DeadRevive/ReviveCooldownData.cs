using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02005AC4 RID: 23236
	public class ReviveCooldownData
	{
		// Token: 0x0401EB52 RID: 125778
		public int Index = -1;

		// Token: 0x0401EB53 RID: 125779
		public double RemainMilliseconds;

		// Token: 0x0401EB54 RID: 125780
		[Nullable(2)]
		public TimerHandle TimerHandle;

		// Token: 0x0401EB55 RID: 125781
		public double LastServerStopTimeStamp;
	}
}
