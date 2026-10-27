using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D6 RID: 2006
	public class ConfigRegressRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F16 RID: 12054 RVA: 0x001635F8 File Offset: 0x001617F8
		static ConfigRegressRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendAll.CreateStaticDefaultValue), new Action(ConfigRegressRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F17 RID: 12055 RVA: 0x00163618 File Offset: 0x00161818
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRecommendAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRecommendAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRecommend`")
			});
		}

		// Token: 0x06002F18 RID: 12056 RVA: 0x00163697 File Offset: 0x00161897
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendAll.LogPair = null;
			ConfigRegressRecommendAll.HandleId = 0;
		}

		// Token: 0x06002F19 RID: 12057 RVA: 0x001636A5 File Offset: 0x001618A5
		public static void Init()
		{
			ConfigRegressRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendAll.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend`");
		}

		// Token: 0x06002F1A RID: 12058 RVA: 0x001636C0 File Offset: 0x001618C0
		[NullableContext(2)]
		public static IReadOnlyList<RegressRecommend> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRecommendAll.HandleId, ConfigRegressRecommendAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressRecommend> readOnlyList = (IReadOnlyList<RegressRecommend>)ConfigCommon.GetConfig("RegressRecommendAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressRecommend> list = new List<RegressRecommend>();
			while (ConfigCommon.Step(ConfigRegressRecommendAll.HandleId, false, ConfigRegressRecommendAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRecommendAll.HandleId, 0, ConfigRegressRecommendAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressRecommendAll.HandleId, ConfigRegressRecommendAll.LogPair);
					return null;
				}
				RegressRecommend rootAsRegressRecommend = RegressRecommend.GetRootAsRegressRecommend(new ByteBuffer(item2));
				list.Add(rootAsRegressRecommend);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressRecommendAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressRecommendAll.HandleId, ConfigRegressRecommendAll.LogPair);
			return list;
		}

		// Token: 0x040036C0 RID: 14016
		private const string DB = "db_regressactivity.db";

		// Token: 0x040036C1 RID: 14017
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x040036C2 RID: 14018
		private const string TABLE = "RegressRecommend";

		// Token: 0x040036C3 RID: 14019
		private const string COMMAND = "select BinData from `RegressRecommend`";

		// Token: 0x040036C4 RID: 14020
		private const string KEY_PREFIX = "RegressRecommendAll";

		// Token: 0x040036C5 RID: 14021
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036C6 RID: 14022
		private static int HandleId;
	}
}
