using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F2 RID: 2034
	public class ConfigRegressRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FBE RID: 12222 RVA: 0x0016A8E0 File Offset: 0x00168AE0
		static ConfigRegressRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRecommendAll.CreateStaticDefaultValue), new Action(ConfigRegressRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x0016A900 File Offset: 0x00168B00
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

		// Token: 0x06002FC0 RID: 12224 RVA: 0x0016A97F File Offset: 0x00168B7F
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRecommendAll.LogPair = null;
			ConfigRegressRecommendAll.HandleId = 0;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x0016A98D File Offset: 0x00168B8D
		public static void Init()
		{
			ConfigRegressRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRecommendAll.HandleId, "db_regressactivity.db", "select BinData from `RegressRecommend`");
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x0016A9A8 File Offset: 0x00168BA8
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

		// Token: 0x04003784 RID: 14212
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003785 RID: 14213
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003786 RID: 14214
		private const string TABLE = "RegressRecommend";

		// Token: 0x04003787 RID: 14215
		private const string COMMAND = "select BinData from `RegressRecommend`";

		// Token: 0x04003788 RID: 14216
		private const string KEY_PREFIX = "RegressRecommendAll";

		// Token: 0x04003789 RID: 14217
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400378A RID: 14218
		private static int HandleId;
	}
}
