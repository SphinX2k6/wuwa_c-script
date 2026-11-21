using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200431F RID: 17183
	[NullableContext(1)]
	[Nullable(0)]
	public class PerfExceedSample
	{
		// Token: 0x0602B6AE RID: 177838 RVA: 0x00C3473C File Offset: 0x00C3293C
		public int GetValue(PerfExceedSubMetric metric)
		{
			int result;
			switch (metric)
			{
			case PerfExceedSubMetric.Particles:
				result = this.TotalParticles;
				break;
			case PerfExceedSubMetric.Emitters:
				result = this.TotalEmitters;
				break;
			case PerfExceedSubMetric.Active:
				result = this.TotalActive;
				break;
			case PerfExceedSubMetric.Scalability:
				result = this.TotalScalability;
				break;
			default:
				result = 0;
				break;
			}
			return result;
		}

		// Token: 0x0602B6AF RID: 177839 RVA: 0x00C34788 File Offset: 0x00C32988
		public List<PerfExceedAssetInfo> GetTopAssets(PerfExceedSubMetric metric, int topN)
		{
			if (this.Assets.Count == 0)
			{
				return new List<PerfExceedAssetInfo>();
			}
			List<PerfExceedAssetInfo> list = new List<PerfExceedAssetInfo>(this.Assets);
			list.Sort(delegate(PerfExceedAssetInfo a, PerfExceedAssetInfo b)
			{
				int num = b.GetSortValue(metric).CompareTo(a.GetSortValue(metric));
				if (num == 0)
				{
					return StringComparer.Ordinal.Compare(a.AssetId, b.AssetId);
				}
				return num;
			});
			if (list.Count > topN)
			{
				list.RemoveRange(topN, list.Count - topN);
			}
			return list;
		}

		// Token: 0x0602B6B0 RID: 177840 RVA: 0x00C347EC File Offset: 0x00C329EC
		public List<string> GetTopAssetNames(PerfExceedSubMetric metric, int topN)
		{
			return this.GetTopAssets(metric, topN).ConvertAll<string>(([Nullable(1)] PerfExceedAssetInfo info) => info.AssetName);
		}

		// Token: 0x0602B6B1 RID: 177841 RVA: 0x00C3481A File Offset: 0x00C32A1A
		public List<string> GetTopAssetIds(PerfExceedSubMetric metric, int topN)
		{
			return this.GetTopAssets(metric, topN).ConvertAll<string>(([Nullable(1)] PerfExceedAssetInfo info) => info.AssetId);
		}

		// Token: 0x04017763 RID: 96099
		public int TotalActive;

		// Token: 0x04017764 RID: 96100
		public int TotalScalability;

		// Token: 0x04017765 RID: 96101
		public int TotalParticles;

		// Token: 0x04017766 RID: 96102
		public int TotalEmitters;

		// Token: 0x04017767 RID: 96103
		public List<PerfExceedAssetInfo> Assets = new List<PerfExceedAssetInfo>();
	}
}
