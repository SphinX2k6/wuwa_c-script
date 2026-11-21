using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x0200351D RID: 13597
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectStatData
	{
		// Token: 0x060229F4 RID: 141812 RVA: 0x009DA010 File Offset: 0x009D8210
		public string ToCsv()
		{
			return string.Join(",", new List<string>
			{
				this.Path,
				((int)this.SpawnTime).ToString(),
				((int)this.AvgUpdateTime).ToString(),
				((int)this.MaxUpdateTime).ToString(),
				((int)this.LoopTime).ToString()
			});
		}

		// Token: 0x060229F5 RID: 141813 RVA: 0x009DA08E File Offset: 0x009D828E
		public EffectStatData(string path, double spawnTime)
		{
			this.Path = path;
			this.SpawnTime = spawnTime;
		}

		// Token: 0x060229F6 RID: 141814 RVA: 0x009DA0B0 File Offset: 0x009D82B0
		public void OnStop(double loopTime)
		{
			this.LoopTime = loopTime;
			this.MaxUpdateTime = 0.0;
			this.AvgUpdateTime = 0.0;
			if (this.UpdateTimeArray.Count > 0)
			{
				double num = 0.0;
				for (int i = 0; i < this.UpdateTimeArray.Count; i++)
				{
					num += this.UpdateTimeArray[i];
					if (this.MaxUpdateTime < this.UpdateTimeArray[i])
					{
						this.MaxUpdateTime = this.UpdateTimeArray[i];
					}
				}
				this.AvgUpdateTime = num / (double)this.UpdateTimeArray.Count;
			}
		}

		// Token: 0x040132C6 RID: 78534
		public string Path;

		// Token: 0x040132C7 RID: 78535
		public double SpawnTime;

		// Token: 0x040132C8 RID: 78536
		public double MaxUpdateTime;

		// Token: 0x040132C9 RID: 78537
		public double AvgUpdateTime;

		// Token: 0x040132CA RID: 78538
		public double LoopTime;

		// Token: 0x040132CB RID: 78539
		public List<double> UpdateTimeArray = new List<double>();

		// Token: 0x040132CC RID: 78540
		[StaticVariableRuleIgnore]
		public static readonly string CsvHeader = "Path,SpawnCost(us),AvgUpdateCost(us),MaxUpdateCost(us),LoopTime(ms)\n";
	}
}
