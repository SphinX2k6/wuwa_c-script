using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C4 RID: 1988
	public class ConfigRefineRecommendByCost : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EAA RID: 11946 RVA: 0x0016116B File Offset: 0x0015F36B
		static ConfigRefineRecommendByCost()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefineRecommendByCost.CreateStaticDefaultValue), new Action(ConfigRefineRecommendByCost.ResetStaticDefaultValue));
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x0016118C File Offset: 0x0015F38C
		public static void CreateStaticDefaultValue()
		{
			ConfigRefineRecommendByCost.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRefineRecommendByCost.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "RefineRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RefineRecommend` where Cost=?")
			});
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x0016120B File Offset: 0x0015F40B
		public static void ResetStaticDefaultValue()
		{
			ConfigRefineRecommendByCost.LogPair = null;
			ConfigRefineRecommendByCost.HandleId = 0;
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00161219 File Offset: 0x0015F419
		public static void Init()
		{
			ConfigRefineRecommendByCost.HandleId = ConfigCommon.InitDataStatement(ConfigRefineRecommendByCost.HandleId, "db_visionrecommend.db", "select BinData from `RefineRecommend` where Cost=?");
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00161234 File Offset: 0x0015F434
		[NullableContext(2)]
		public static IReadOnlyList<RefineRecommend> GetConfigList(int p0Cost, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRefineRecommendByCost.HandleId, ConfigRefineRecommendByCost.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RefineRecommendByCost");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Cost);
				IReadOnlyList<RefineRecommend> readOnlyList = (IReadOnlyList<RefineRecommend>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRefineRecommendByCost.LogPair.Clear();
			ConfigRefineRecommendByCost.LogPair.Add(new ValueTuple<string, object>("Cost", p0Cost));
			if (!ConfigCommon.BindInt(ConfigRefineRecommendByCost.HandleId, 1, p0Cost, ConfigRefineRecommendByCost.LogPair))
			{
				ConfigCommon.Reset(ConfigRefineRecommendByCost.HandleId, ConfigRefineRecommendByCost.LogPair);
				return null;
			}
			List<RefineRecommend> list = new List<RefineRecommend>();
			while (ConfigCommon.Step(ConfigRefineRecommendByCost.HandleId, false, ConfigRefineRecommendByCost.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRefineRecommendByCost.HandleId, 0, ConfigRefineRecommendByCost.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRefineRecommendByCost.HandleId, ConfigRefineRecommendByCost.LogPair);
					return null;
				}
				RefineRecommend rootAsRefineRecommend = RefineRecommend.GetRootAsRefineRecommend(new ByteBuffer(item2));
				list.Add(rootAsRefineRecommend);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RefineRecommendByCost");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Cost);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRefineRecommendByCost.HandleId, ConfigRefineRecommendByCost.LogPair);
			return list;
		}

		// Token: 0x04003642 RID: 13890
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04003643 RID: 13891
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04003644 RID: 13892
		private const string TABLE = "RefineRecommend";

		// Token: 0x04003645 RID: 13893
		private const string COMMAND = "select BinData from `RefineRecommend` where Cost=?";

		// Token: 0x04003646 RID: 13894
		private const string KEY_PREFIX = "RefineRecommendByCost";

		// Token: 0x04003647 RID: 13895
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003648 RID: 13896
		private static int HandleId;
	}
}
