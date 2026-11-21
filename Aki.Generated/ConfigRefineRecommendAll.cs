using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DF RID: 2015
	public class ConfigRefineRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F4C RID: 12108 RVA: 0x001682BF File Offset: 0x001664BF
		static ConfigRefineRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRefineRecommendAll.CreateStaticDefaultValue), new Action(ConfigRefineRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x001682E0 File Offset: 0x001664E0
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

		// Token: 0x06002F4E RID: 12110 RVA: 0x0016835F File Offset: 0x0016655F
		public static void ResetStaticDefaultValue()
		{
			ConfigRefineRecommendAll.LogPair = null;
			ConfigRefineRecommendAll.HandleId = 0;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x0016836D File Offset: 0x0016656D
		public static void Init()
		{
			ConfigRefineRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigRefineRecommendAll.HandleId, "db_visionrecommend.db", "select BinData from `RefineRecommend`");
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00168388 File Offset: 0x00166588
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

		// Token: 0x040036FF RID: 14079
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04003700 RID: 14080
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04003701 RID: 14081
		private const string TABLE = "RefineRecommend";

		// Token: 0x04003702 RID: 14082
		private const string COMMAND = "select BinData from `RefineRecommend`";

		// Token: 0x04003703 RID: 14083
		private const string KEY_PREFIX = "RefineRecommendAll";

		// Token: 0x04003704 RID: 14084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003705 RID: 14085
		private static int HandleId;
	}
}
