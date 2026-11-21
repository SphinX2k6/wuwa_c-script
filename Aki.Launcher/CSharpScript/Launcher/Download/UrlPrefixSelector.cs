using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Util;
using UnrealEngine;

namespace CSharpScript.Launcher.Download
{
	// Token: 0x020001FD RID: 509
	[NullableContext(1)]
	[Nullable(0)]
	public class UrlPrefixSelector : Singleton
	{
		// Token: 0x06000D45 RID: 3397 RVA: 0x00051A68 File Offset: 0x0004FC68
		public void Init()
		{
			if (this.PrimaryUrlList != null)
			{
				return;
			}
			this.InitInternal(this.ManagePrimary(), (BaseConfigController.Instance.GetSpeedRatio() != null) ? BaseConfigController.Instance.GetSpeedRatio().Value : 0.8f, (BaseConfigController.Instance.GetPriceRatio() != null) ? BaseConfigController.Instance.GetPriceRatio().Value : 0.2f);
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00051AE4 File Offset: 0x0004FCE4
		private Dictionary<string, int> ManagePrimary()
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			List<ICdnUrlData> cdnUrl = BaseConfigController.Instance.GetCdnUrl();
			if (cdnUrl != null)
			{
				for (int i = 0; i < cdnUrl.Count; i++)
				{
					ICdnUrlData cdnUrlData = cdnUrl[i];
					string url = cdnUrlData.url;
					string weight = cdnUrlData.weight;
					dictionary[url] = int.Parse(weight);
				}
			}
			return dictionary;
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00051B3C File Offset: 0x0004FD3C
		public unsafe void SetUrl(string primaryUrl, float speedRatio, float priceRatio)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "设置远程前缀参数";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("primary", primaryUrl);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("speedRatio", speedRatio);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("priceRatio", priceRatio);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = "set_remote_prefix";
			HotPatchLog hotPatchLog2 = hotPatchLog;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(primaryUrl);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<float>(speedRatio);
			defaultInterpolatedStringHandler.AppendLiteral("|");
			defaultInterpolatedStringHandler.AppendFormatted<float>(priceRatio);
			hotPatchLog2.s_step_result = defaultInterpolatedStringHandler.ToStringAndClear();
			HotPatchLogReport.Instance.Report(hotPatchLog);
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			if (!string.IsNullOrEmpty(primaryUrl))
			{
				string text = primaryUrl.Trim();
				if (text != "")
				{
					string[] array = text.Split(';', StringSplitOptions.None);
					for (int i = 0; i < array.Length; i++)
					{
						string[] array2 = array[i].Split(',', StringSplitOptions.None);
						if (array2.Length >= 2)
						{
							dictionary[array2[0].Trim()] = int.Parse(array2[1].Trim());
						}
					}
				}
			}
			this.InitInternal(dictionary, speedRatio, priceRatio);
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00051C9C File Offset: 0x0004FE9C
		private void InitInternal(Dictionary<string, int> primaryUrlMap, float speedRatio, float priceRatio)
		{
			if (primaryUrlMap.Count > 0)
			{
				List<UrlPrefixInfo> list = new List<UrlPrefixInfo>();
				int num = 0;
				float evalTime = this.GetEvalTime();
				foreach (KeyValuePair<string, int> keyValuePair in primaryUrlMap)
				{
					string key = keyValuePair.Key;
					int value = keyValuePair.Value;
					list.Add(new UrlPrefixInfo
					{
						Address = key,
						Price = value,
						OriginOrder = num++,
						EvalPoint = 0,
						IsEvaluated = false,
						RemainDownloadTime = evalTime,
						DownloadedSize = 0L,
						Speed = 0
					});
				}
				this.ShuffleOrSortByOrigin(list);
				this.PrimaryUrlList = list;
			}
			if (primaryUrlMap.Count == 0)
			{
				this.PrimaryUrlList = new List<UrlPrefixInfo>();
			}
			this.SpeedRatio = ((speedRatio != 0f) ? speedRatio : 0.8f);
			this.PriceRatio = ((priceRatio != 0f) ? priceRatio : 0.2f);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00051DB4 File Offset: 0x0004FFB4
		public void Reset()
		{
			if (this.PrimaryUrlList == null)
			{
				return;
			}
			float evalTime = this.GetEvalTime();
			for (int i = 0; i < this.PrimaryUrlList.Count; i++)
			{
				UrlPrefixInfo urlPrefixInfo = this.PrimaryUrlList[i];
				urlPrefixInfo.DownloadedSize = 0L;
				urlPrefixInfo.Speed = 0;
				urlPrefixInfo.RemainDownloadTime = evalTime;
				urlPrefixInfo.EvalPoint = 0;
				urlPrefixInfo.IsEvaluated = false;
			}
			if (this.PrimaryUrlList.Count > 1)
			{
				this.ShuffleOrSortByOrigin(this.PrimaryUrlList);
			}
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00051E30 File Offset: 0x00050030
		public unsafe void Evaluated(long remainKb, int remainFileCount)
		{
			if (this.PrimaryUrlList == null)
			{
				return;
			}
			this.LastFormulaName = "client_builtin";
			this.LastRawValueMap.Clear();
			ICdnScoreCfg cdnScoreCfg = BaseConfigController.Instance.GetCdnScoreCfg();
			CdnScoreSelectionResult cdnScoreSelectionResult = CdnScoreFormula.Select(cdnScoreCfg);
			string reason = cdnScoreSelectionResult.Reason;
			ICdnScoreFormula formula = cdnScoreSelectionResult.Formula;
			bool flag = false;
			if (formula != null)
			{
				string text = this.ApplyCdnScoreFormula(formula, remainKb, remainFileCount);
				if (text != null)
				{
					reason = text;
					LauncherLog instance = LauncherLog.Instance;
					string message = "CDN评分公式执行失败，回退客户端默认公式";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", text);
					instance.Info(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				else
				{
					this.LastFormulaName = formula.Name;
					flag = true;
				}
			}
			this.ReportCdnScoreSelection((cdnScoreCfg != null) ? cdnScoreCfg.UsedCandidate : null, reason, flag, remainKb, remainFileCount, flag ? ((formula != null) ? formula.Order : null) : "desc");
			if (this.PrimaryUrlList.Count > 1)
			{
				this.PrimaryUrlList.Sort(delegate(UrlPrefixInfo a, UrlPrefixInfo b)
				{
					if (b.EvalPoint - a.EvalPoint == 0)
					{
						return a.OriginOrder - b.OriginOrder;
					}
					return b.EvalPoint - a.EvalPoint;
				});
			}
			if (this.PrimaryUrlList != null && this.PrimaryUrlList.Count > 0)
			{
				for (int i = 0; i < this.PrimaryUrlList.Count; i++)
				{
					UrlPrefixInfo urlPrefixInfo = this.PrimaryUrlList[i];
					LauncherLog instance2 = LauncherLog.Instance;
					string message2 = "整体完成评估";
					<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("prefix", urlPrefixInfo.Address);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("size", urlPrefixInfo.DownloadedSize);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("speed", urlPrefixInfo.Speed);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("price", urlPrefixInfo.Price);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("originOrder", urlPrefixInfo.OriginOrder);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("raw", this.GetLastRawValue(urlPrefixInfo.Address));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("point", urlPrefixInfo.EvalPoint);
					instance2.Info(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
				}
			}
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00052089 File Offset: 0x00050289
		public string GetLastFormulaName()
		{
			return this.LastFormulaName;
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00052094 File Offset: 0x00050294
		public double? GetLastRawValue(string address)
		{
			double value;
			if (!this.LastRawValueMap.TryGetValue(address, out value))
			{
				return null;
			}
			return new double?(value);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x000520C4 File Offset: 0x000502C4
		[NullableContext(2)]
		private unsafe void ReportCdnScoreSelection(string usedCandidate, [Nullable(1)] string reason, bool usedConfiguredFormula, long remainKb, int remainFileCount, string order)
		{
			LauncherLog instance = LauncherLog.Instance;
			string message = "CDN评分公式选择结果";
			<>y__InlineArray7<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray7<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("source", usedConfiguredFormula ? "cdn_config" : "client_builtin");
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("selected", this.LastFormulaName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("used", usedCandidate);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("remainSize", remainKb);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("fileCount", remainFileCount);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 6) = new ValueTuple<string, object>("order", order);
			instance.Info(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray7<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 7));
			HotPatchLog hotPatchLog = new HotPatchLog();
			hotPatchLog.s_step_id = "cdn_score_cfg_select";
			Dictionary<string, object> value = new Dictionary<string, object>
			{
				{
					"Selected",
					this.LastFormulaName
				},
				{
					"Reason",
					reason
				},
				{
					"Used",
					usedCandidate
				}
			};
			hotPatchLog.s_step_result = LauncherJson.Stringify(value, null);
			HotPatchLogReport.Instance.Report(hotPatchLog);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00052210 File Offset: 0x00050410
		[return: Nullable(2)]
		private string ApplyCdnScoreFormula(ICdnScoreFormula formula, long remainKb, int remainFileCount)
		{
			if (this.PrimaryUrlList == null || this.PrimaryUrlList.Count == 0)
			{
				return null;
			}
			ENetworkType networkConnectionType = (ENetworkType)UKuroLauncherLibrary.GetNetworkConnectionType();
			List<ValueTuple<UrlPrefixInfo, double>> list = new List<ValueTuple<UrlPrefixInfo, double>>(this.PrimaryUrlList.Count);
			for (int i = 0; i < this.PrimaryUrlList.Count; i++)
			{
				UrlPrefixInfo urlPrefixInfo = this.PrimaryUrlList[i];
				Dictionary<string, double> dictionary = new Dictionary<string, double>();
				dictionary["speed"] = (double)urlPrefixInfo.Speed;
				dictionary["weight"] = (double)urlPrefixInfo.Price;
				dictionary["originOrder"] = (double)urlPrefixInfo.OriginOrder;
				dictionary["remainSize"] = (double)remainKb;
				dictionary["fileCount"] = (double)remainFileCount;
				dictionary["networkType"] = (networkConnectionType == ENetworkType.Cell);
				Dictionary<string, double> vars = dictionary;
				CdnScoreEvalResult cdnScoreEvalResult = CdnScoreFormula.Evaluate(formula, vars);
				if (cdnScoreEvalResult.Error != null)
				{
					return cdnScoreEvalResult.Error;
				}
				list.Add(new ValueTuple<UrlPrefixInfo, double>(urlPrefixInfo, cdnScoreEvalResult.Value.Value));
			}
			int sign = (formula.Order == "asc") ? 1 : -1;
			list.Sort(delegate([TupleElementNames(new string[]
			{
				"Info",
				"Value"
			})] [Nullable(new byte[]
			{
				0,
				1
			})] ValueTuple<UrlPrefixInfo, double> a, [TupleElementNames(new string[]
			{
				"Info",
				"Value"
			})] [Nullable(new byte[]
			{
				0,
				1
			})] ValueTuple<UrlPrefixInfo, double> b)
			{
				double num = (a.Item2 - b.Item2) * (double)sign;
				if (num < 0.0)
				{
					return -1;
				}
				if (num > 0.0)
				{
					return 1;
				}
				return a.Item1.OriginOrder - b.Item1.OriginOrder;
			});
			for (int j = 0; j < list.Count; j++)
			{
				list[j].Item1.EvalPoint = list.Count - j;
				this.LastRawValueMap[list[j].Item1.Address] = list[j].Item2;
			}
			return null;
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x000523A2 File Offset: 0x000505A2
		public List<UrlPrefixInfo> GetPrimaryPrefixList()
		{
			if (this.PrimaryUrlList == null)
			{
				return new List<UrlPrefixInfo>();
			}
			this.ShuffleOrSortByOrigin(this.PrimaryUrlList);
			return this.PrimaryUrlList;
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x000523C4 File Offset: 0x000505C4
		public List<string> GetAllPrefixList(bool bSorted = false)
		{
			if (this.PrimaryUrlList == null)
			{
				LauncherLog.Instance.Error("未初始化UrlPrefixSelector就调用了GetAllPrefixList", default(ReadOnlySpan<ValueTuple<string, object>>));
				return new List<string>();
			}
			if (bSorted && this.PrimaryUrlList.Count > 1)
			{
				this.PrimaryUrlList.Sort(delegate(UrlPrefixInfo a, UrlPrefixInfo b)
				{
					if (b.EvalPoint - a.EvalPoint == 0)
					{
						return a.OriginOrder - b.OriginOrder;
					}
					return b.EvalPoint - a.EvalPoint;
				});
			}
			List<string> list = new List<string>();
			for (int i = 0; i < this.PrimaryUrlList.Count; i++)
			{
				list.Add(this.PrimaryUrlList[i].Address);
			}
			if (!bSorted && this.IsEvalShuffle())
			{
				ProcedureUtil.randomArray<string>(list);
			}
			return list;
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00052477 File Offset: 0x00050677
		public float CalculateUrlPoint(int price, float downloadSpeed)
		{
			return downloadSpeed * this.SpeedRatio - (float)price * this.PriceRatio;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x0005248C File Offset: 0x0005068C
		[NullableContext(2)]
		private IEvalNetworkConfig GetEvalNetworkConfig()
		{
			IEvalConfig cdnEvalCfg = BaseConfigController.Instance.GetCdnEvalCfg();
			if (cdnEvalCfg == null)
			{
				return null;
			}
			if (UKuroLauncherLibrary.GetNetworkConnectionType() != 3)
			{
				return cdnEvalCfg.Broadband;
			}
			return cdnEvalCfg.Cellular;
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000524C0 File Offset: 0x000506C0
		public bool IsEvalShuffle()
		{
			IEvalNetworkConfig evalNetworkConfig = this.GetEvalNetworkConfig();
			return ((evalNetworkConfig != null) ? evalNetworkConfig.Shuffle : null).GetValueOrDefault(true);
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x000524F0 File Offset: 0x000506F0
		public float GetEvalTime()
		{
			IEvalNetworkConfig evalNetworkConfig = this.GetEvalNetworkConfig();
			float? num = (evalNetworkConfig != null) ? evalNetworkConfig.EvalTime : null;
			if (num == null || num.Value <= 0f)
			{
				return 5f;
			}
			return num.Value;
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x0005253C File Offset: 0x0005073C
		public float GetSkipEvalSizeMb()
		{
			IEvalNetworkConfig evalNetworkConfig = this.GetEvalNetworkConfig();
			float? num = (evalNetworkConfig != null) ? evalNetworkConfig.SkipSize : null;
			if (num == null || num.Value <= 0f)
			{
				return 0f;
			}
			return num.Value;
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x00052588 File Offset: 0x00050788
		private void ShuffleOrSortByOrigin(List<UrlPrefixInfo> list)
		{
			if (this.IsEvalShuffle())
			{
				ProcedureUtil.randomArray<UrlPrefixInfo>(list);
				return;
			}
			if (list.Count > 1)
			{
				list.Sort((UrlPrefixInfo a, UrlPrefixInfo b) => a.OriginOrder - b.OriginOrder);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x000525C7 File Offset: 0x000507C7
		public static UrlPrefixSelector Instance
		{
			get
			{
				if (UrlPrefixSelector._instance == null)
				{
					UrlPrefixSelector._instance = new UrlPrefixSelector();
					UrlPrefixSelector._instance.OnInit();
				}
				return UrlPrefixSelector._instance;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x000525EA File Offset: 0x000507EA
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x000525EC File Offset: 0x000507EC
		public static void ResetStaticDefaultValue()
		{
			UrlPrefixSelector instance = UrlPrefixSelector._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			UrlPrefixSelector._instance = null;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00052605 File Offset: 0x00050805
		static UrlPrefixSelector()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(UrlPrefixSelector.CreateStaticDefaultValue), new Action(UrlPrefixSelector.ResetStaticDefaultValue));
		}

		// Token: 0x04000859 RID: 2137
		private const float INLINE_SPEED_RATIO = 0.8f;

		// Token: 0x0400085A RID: 2138
		private const float INLINE_PRICE_RATIO = 0.2f;

		// Token: 0x0400085B RID: 2139
		private const float TEST_TIME = 5f;

		// Token: 0x0400085C RID: 2140
		private const long BigIntZero = 0L;

		// Token: 0x0400085D RID: 2141
		private const long BigIntKb = 1024L;

		// Token: 0x0400085E RID: 2142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<UrlPrefixInfo> PrimaryUrlList;

		// Token: 0x0400085F RID: 2143
		private float SpeedRatio;

		// Token: 0x04000860 RID: 2144
		private float PriceRatio;

		// Token: 0x04000861 RID: 2145
		private string LastFormulaName = "client_builtin";

		// Token: 0x04000862 RID: 2146
		private readonly Dictionary<string, double> LastRawValueMap = new Dictionary<string, double>();

		// Token: 0x04000863 RID: 2147
		[Nullable(2)]
		private static UrlPrefixSelector _instance;
	}
}
