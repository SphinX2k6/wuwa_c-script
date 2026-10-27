using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C3 RID: 1987
	public class ConfigRefineRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EA4 RID: 11940 RVA: 0x00160FD7 File Offset: 0x0015F1D7
		static ConfigRefineRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefineRecommendAll.CreateStaticDefaultValue), new Action(ConfigRefineRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00160FF8 File Offset: 0x0015F1F8
		public static void CreateStaticDefaultValue()
		{
			ConfigRefineRecommendAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRefineRecommendAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "RefineRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RefineRecommend`")
			});
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00161077 File Offset: 0x0015F277
		public static void ResetStaticDefaultValue()
		{
			ConfigRefineRecommendAll.LogPair = null;
			ConfigRefineRecommendAll.HandleId = 0;
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00161085 File Offset: 0x0015F285
		public static void Init()
		{
			ConfigRefineRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigRefineRecommendAll.HandleId, "db_visionrecommend.db", "select BinData from `RefineRecommend`");
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x001610A0 File Offset: 0x0015F2A0
		[NullableContext(2)]
		public static IReadOnlyList<RefineRecommend> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRefineRecommendAll.HandleId, ConfigRefineRecommendAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RefineRecommend> readOnlyList = (IReadOnlyList<RefineRecommend>)ConfigCommon.GetConfig("RefineRecommendAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RefineRecommend> list = new List<RefineRecommend>();
			while (ConfigCommon.Step(ConfigRefineRecommendAll.HandleId, false, ConfigRefineRecommendAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRefineRecommendAll.HandleId, 0, ConfigRefineRecommendAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRefineRecommendAll.HandleId, ConfigRefineRecommendAll.LogPair);
					return null;
				}
				RefineRecommend rootAsRefineRecommend = RefineRecommend.GetRootAsRefineRecommend(new ByteBuffer(item2));
				list.Add(rootAsRefineRecommend);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RefineRecommendAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRefineRecommendAll.HandleId, ConfigRefineRecommendAll.LogPair);
			return list;
		}

		// Token: 0x0400363B RID: 13883
		private const string DB = "db_visionrecommend.db";

		// Token: 0x0400363C RID: 13884
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x0400363D RID: 13885
		private const string TABLE = "RefineRecommend";

		// Token: 0x0400363E RID: 13886
		private const string COMMAND = "select BinData from `RefineRecommend`";

		// Token: 0x0400363F RID: 13887
		private const string KEY_PREFIX = "RefineRecommendAll";

		// Token: 0x04003640 RID: 13888
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003641 RID: 13889
		private static int HandleId;
	}
}
