using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E0 RID: 2016
	public class ConfigRefineRecommendByCost : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F52 RID: 12114 RVA: 0x00168453 File Offset: 0x00166653
		static ConfigRefineRecommendByCost()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefineRecommendByCost.CreateStaticDefaultValue), new Action(ConfigRefineRecommendByCost.ResetStaticDefaultValue));
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00168474 File Offset: 0x00166674
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

		// Token: 0x06002F54 RID: 12116 RVA: 0x001684F3 File Offset: 0x001666F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRefineRecommendByCost.LogPair = null;
			ConfigRefineRecommendByCost.HandleId = 0;
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00168501 File Offset: 0x00166701
		public static void Init()
		{
			ConfigRefineRecommendByCost.HandleId = ConfigCommon.InitDataStatement(ConfigRefineRecommendByCost.HandleId, "db_visionrecommend.db", "select BinData from `RefineRecommend` where Cost=?");
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x0016851C File Offset: 0x0016671C
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

		// Token: 0x04003706 RID: 14086
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04003707 RID: 14087
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04003708 RID: 14088
		private const string TABLE = "RefineRecommend";

		// Token: 0x04003709 RID: 14089
		private const string COMMAND = "select BinData from `RefineRecommend` where Cost=?";

		// Token: 0x0400370A RID: 14090
		private const string KEY_PREFIX = "RefineRecommendByCost";

		// Token: 0x0400370B RID: 14091
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400370C RID: 14092
		private static int HandleId;
	}
}
