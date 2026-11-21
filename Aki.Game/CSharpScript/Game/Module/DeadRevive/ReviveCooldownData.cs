using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DeadRevive
{
	// Token: 0x02004AA5 RID: 19109
	public class ReviveCooldownData
	{
		// Token: 0x0401960D RID: 103949
		public int Index = -1;

		// Token: 0x0401960E RID: 103950
		public double RemainMilliseconds;

		// Token: 0x0401960F RID: 103951
		[Nullable(2)]
		public TimerHandle TimerHandle;

		// Token: 0x04019610 RID: 103952
		public double LastServerStopTimeStamp;
	}
}
