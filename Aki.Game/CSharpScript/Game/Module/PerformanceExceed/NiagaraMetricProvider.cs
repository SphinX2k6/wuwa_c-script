using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Game.Module.PerformanceExceed
{
	// Token: 0x0200431D RID: 17181
	[NullableContext(1)]
	[Nullable(0)]
	public class NiagaraMetricProvider : IPerfExceedMetricProvider
	{
		// Token: 0x170056E9 RID: 22249
		// (get) Token: 0x0602B6A2 RID: 177826 RVA: 0x00C343C2 File Offset: 0x00C325C2
		public string Name
		{
			get
			{
				return "niagara";
			}
		}

		// Token: 0x170056EA RID: 22250
		// (get) Token: 0x0602B6A3 RID: 177827 RVA: 0x00C343C9 File Offset: 0x00C325C9
		public int SampleIntervalMs
		{
			get
			{
				return 500;
			}
		}

		// Token: 0x0602B6A4 RID: 177828 RVA: 0x00C343D0 File Offset: 0x00C325D0
		[NullableContext(2)]
		public PerfExceedSample Sample()
		{
			FNiagaraGlobalInfoInHUD globalInfo = UNiagaraFunctionLibrary.GetGlobalInfo();
			TArray<FNiagaraAssetInfoEntry> topNiagaraAssets = UNiagaraFunctionLibrary.GetTopNiagaraAssets(int.MaxValue);
			PerfExceedSample perfExceedSample = new PerfExceedSample
			{
				TotalActive = globalInfo.GlobalTotalActive,
				TotalScalability = globalInfo.GlobalTotalScalability,
				TotalParticles = globalInfo.GlobalTotalParticles,
				TotalEmitters = globalInfo.GlobalTotalEmitters
			};
			if (topNiagaraAssets != null)
			{
				foreach (FNiagaraAssetInfoEntry fniagaraAssetInfoEntry in topNiagaraAssets)
				{
					if (!(fniagaraAssetInfoEntry == null))
					{
						perfExceedSample.Assets.Add(new PerfExceedAssetInfo
						{
							AssetName = fniagaraAssetInfoEntry.AssetName,
							AssetPath = fniagaraAssetInfoEntry.AssetPath,
							Particles = fniagaraAssetInfoEntry.Particles,
							Emitters = fniagaraAssetInfoEntry.Emitters,
							ActiveInstances = fniagaraAssetInfoEntry.ActiveInstances,
							ScalabilityInstances = fniagaraAssetInfoEntry.ScalabilityInstances,
							TotalInstances = fniagaraAssetInfoEntry.TotalInstances
						});
					}
				}
			}
			return perfExceedSample;
		}

		// Token: 0x0602B6A5 RID: 177829 RVA: 0x00C344E0 File Offset: 0x00C326E0
		[NullableContext(2)]
		public PerfExceedPayload BuildPayload(PerfExceedSubMetric subMetric)
		{
			PerfExceedSample perfExceedSample = this.Sample();
			if (perfExceedSample == null)
			{
				return null;
			}
			return NiagaraMetricProvider.BuildPayloadFromSample(perfExceedSample, subMetric);
		}

		// Token: 0x0602B6A6 RID: 177830 RVA: 0x00C34500 File Offset: 0x00C32700
		public static PerfExceedPayload BuildPayloadFromSample(PerfExceedSample sample, PerfExceedSubMetric subMetric)
		{
			List<PerfExceedAssetInfo> topAssets = sample.GetTopAssets(subMetric, 10);
			string value = Json.Stringify(NiagaraMetricProvider.ConvertTopList(topAssets, subMetric), null);
			if (string.IsNullOrEmpty(value))
			{
				throw new InvalidOperationException("PerfExceed Top10 JSON serialization failed");
			}
			Dictionary<string, object> dictionary = new Dictionary<string, object>
			{
				{
					"s_metric",
					NiagaraMetricProvider.MetricName(subMetric)
				},
				{
					"i_total_active",
					sample.TotalActive
				},
				{
					"i_total_scalability",
					sample.TotalScalability
				},
				{
					"i_total_particles",
					sample.TotalParticles
				},
				{
					"i_total_emitters",
					sample.TotalEmitters
				},
				{
					"i_threshold",
					PerfExceedThresholds.GetThreshold(subMetric)
				}
			};
			dictionary["s_top1_asset"] = ((topAssets.Count > 0) ? topAssets[0].AssetName : "");
			dictionary["i_top1_count"] = ((topAssets.Count > 0) ? topAssets[0].GetSortValue(subMetric) : 0);
			dictionary["s_top10_json"] = value;
			return new PerfExceedPayload
			{
				EventName = PerfExceedEventNames.GetEventName(subMetric),
				Fields = dictionary
			};
		}

		// Token: 0x0602B6A7 RID: 177831 RVA: 0x00C34634 File Offset: 0x00C32834
		private static List<PerfExceedTopAssetInfo> ConvertTopList(List<PerfExceedAssetInfo> topAssets, PerfExceedSubMetric metric)
		{
			List<PerfExceedTopAssetInfo> list = new List<PerfExceedTopAssetInfo>(topAssets.Count);
			foreach (PerfExceedAssetInfo perfExceedAssetInfo in topAssets)
			{
				list.Add(new PerfExceedTopAssetInfo
				{
					s_asset = perfExceedAssetInfo.AssetName,
					s_asset_path = perfExceedAssetInfo.AssetPath,
					i_count = perfExceedAssetInfo.GetSortValue(metric),
					i_particles = perfExceedAssetInfo.Particles,
					i_emitters = perfExceedAssetInfo.Emitters,
					i_active = perfExceedAssetInfo.ActiveInstances,
					i_scalability = perfExceedAssetInfo.ScalabilityInstances
				});
			}
			return list;
		}

		// Token: 0x0602B6A8 RID: 177832 RVA: 0x00C346E8 File Offset: 0x00C328E8
		public static string MetricName(PerfExceedSubMetric metric)
		{
			string result;
			switch (metric)
			{
			case PerfExceedSubMetric.Particles:
				result = "niagara_particles";
				break;
			case PerfExceedSubMetric.Emitters:
				result = "niagara_emitters";
				break;
			case PerfExceedSubMetric.Active:
				result = "niagara_active";
				break;
			case PerfExceedSubMetric.Scalability:
				result = "niagara_scalability";
				break;
			default:
				result = "niagara_unknown";
				break;
			}
			return result;
		}

		// Token: 0x04017762 RID: 96098
		private const int ALL_ASSET_CANDIDATES = 2147483647;
	}
}
