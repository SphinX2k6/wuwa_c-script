using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils
{
	// Token: 0x02003475 RID: 13429
	[NullableContext(1)]
	[Nullable(0)]
	public class FrequencyMonitor
	{
		// Token: 0x06022467 RID: 140391 RVA: 0x009B5BC2 File Offset: 0x009B3DC2
		public FrequencyMonitor(int time, int count, string msg, [Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})] params ValueTuple<string, object>[] parameters)
		{
			this.Time = time;
			this.Count = count;
			this.Msg = msg;
			this.Params = parameters;
		}

		// Token: 0x06022468 RID: 140392 RVA: 0x009B5BF4 File Offset: 0x009B3DF4
		public void Execute()
		{
		}

		// Token: 0x04012DDE RID: 77278
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			2
		})]
		private readonly ValueTuple<string, object>[] Params;

		// Token: 0x04012DDF RID: 77279
		private readonly Queue<double> ExecuteTimes = new Queue<double>(4);

		// Token: 0x04012DE0 RID: 77280
		private readonly int Time;

		// Token: 0x04012DE1 RID: 77281
		private readonly int Count;

		// Token: 0x04012DE2 RID: 77282
		private readonly string Msg;
	}
}
