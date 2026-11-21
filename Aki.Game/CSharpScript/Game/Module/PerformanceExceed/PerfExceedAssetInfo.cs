using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x02004320 RID: 17184
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedAssetInfo
	{
		// Token: 0x170056ED RID: 22253
		// (get) Token: 0x0602B6B3 RID: 177843 RVA: 0x00C3485B File Offset: 0x00C32A5B
		public string AssetId
		{
			get
			{
				if (string.IsNullOrEmpty(this.AssetPath))
				{
					return "name:" + this.AssetName;
				}
				return this.AssetPath;
			}
		}

		// Token: 0x0602B6B4 RID: 177844 RVA: 0x00C34884 File Offset: 0x00C32A84
		public int GetSortValue(PerfExceedSubMetric metric)
		{
			int result;
			switch (metric)
			{
			case PerfExceedSubMetric.Particles:
				result = this.Particles;
				break;
			case PerfExceedSubMetric.Emitters:
				result = this.Emitters;
				break;
			case PerfExceedSubMetric.Active:
				result = this.ActiveInstances;
				break;
			case PerfExceedSubMetric.Scalability:
				result = this.ScalabilityInstances;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x04017768 RID: 96104
		public string AssetName = "";

		// Token: 0x04017769 RID: 96105
		public string AssetPath = "";

		// Token: 0x0401776A RID: 96106
		public int Particles;

		// Token: 0x0401776B RID: 96107
		public int Emitters;

		// Token: 0x0401776C RID: 96108
		public int ActiveInstances;

		// Token: 0x0401776D RID: 96109
		public int ScalabilityInstances;

		// Token: 0x0401776E RID: 96110
		public int TotalInstances;
	}
}
