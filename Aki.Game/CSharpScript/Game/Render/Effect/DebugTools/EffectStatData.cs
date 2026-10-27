using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Render.Effect.DebugTools
{
	// Token: 0x020045F4 RID: 17908
	[NullableContext(1)]
	[Nullable(0)]
	public class EffectStatData
	{
		// Token: 0x0602E2FF RID: 189183 RVA: 0x00AAD874 File Offset: 0x00AABA74
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

		// Token: 0x0602E300 RID: 189184 RVA: 0x00AAD8F2 File Offset: 0x00AABAF2
		public EffectStatData(string path, double spawnTime)
		{
			this.Path = path;
			this.SpawnTime = spawnTime;
		}

		// Token: 0x0602E301 RID: 189185 RVA: 0x00AAD914 File Offset: 0x00AABB14
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

		// Token: 0x04018C87 RID: 101511
		public string Path;

		// Token: 0x04018C88 RID: 101512
		public double SpawnTime;

		// Token: 0x04018C89 RID: 101513
		public double MaxUpdateTime;

		// Token: 0x04018C8A RID: 101514
		public double AvgUpdateTime;

		// Token: 0x04018C8B RID: 101515
		public double LoopTime;

		// Token: 0x04018C8C RID: 101516
		public List<double> UpdateTimeArray = new List<double>();

		// Token: 0x04018C8D RID: 101517
		[StaticVariableRuleIgnore]
		public static readonly string CsvHeader = "Path,SpawnCost(us),AvgUpdateCost(us),MaxUpdateCost(us),LoopTime(ms)\n";
	}
}
