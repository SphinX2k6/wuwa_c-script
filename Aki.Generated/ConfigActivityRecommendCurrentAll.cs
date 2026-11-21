using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000056 RID: 86
	public class ConfigActivityRecommendCurrentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000204 RID: 516 RVA: 0x000689E8 File Offset: 0x00066BE8
		static ConfigActivityRecommendCurrentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendCurrentAll.CreateStaticDefaultValue), new Action(ConfigActivityRecommendCurrentAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00068A08 File Offset: 0x00066C08
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendCurrentAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommendCurrent"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommendCurrent`")
			});
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00068A87 File Offset: 0x00066C87
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentAll.LogPair = null;
			ConfigActivityRecommendCurrentAll.HandleId = 0;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00068A95 File Offset: 0x00066C95
		public static void Init()
		{
			ConfigActivityRecommendCurrentAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendCurrentAll.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommendCurrent`");
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00068AB0 File Offset: 0x00066CB0
		[NullableContext(2)]
		public static IReadOnlyList<ActivityRecommendCurrent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendCurrentAll.HandleId, ConfigActivityRecommendCurrentAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityRecommendCurrent> readOnlyList = (IReadOnlyList<ActivityRecommendCurrent>)ConfigCommon.GetConfig("ActivityRecommendCurrentAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityRecommendCurrent> list = new List<ActivityRecommendCurrent>();
			while (ConfigCommon.Step(ConfigActivityRecommendCurrentAll.HandleId, false, ConfigActivityRecommendCurrentAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendCurrentAll.HandleId, 0, ConfigActivityRecommendCurrentAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityRecommendCurrentAll.HandleId, ConfigActivityRecommendCurrentAll.LogPair);
					return null;
				}
				ActivityRecommendCurrent rootAsActivityRecommendCurrent = ActivityRecommendCurrent.GetRootAsActivityRecommendCurrent(new ByteBuffer(item2));
				list.Add(rootAsActivityRecommendCurrent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityRecommendCurrentAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityRecommendCurrentAll.HandleId, ConfigActivityRecommendCurrentAll.LogPair);
			return list;
		}

		// Token: 0x0400023E RID: 574
		private const string DB = "db_activityrecommend.db";

		// Token: 0x0400023F RID: 575
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000240 RID: 576
		private const string TABLE = "ActivityRecommendCurrent";

		// Token: 0x04000241 RID: 577
		private const string COMMAND = "select BinData from `ActivityRecommendCurrent`";

		// Token: 0x04000242 RID: 578
		private const string KEY_PREFIX = "ActivityRecommendCurrentAll";

		// Token: 0x04000243 RID: 579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000244 RID: 580
		private static int HandleId;
	}
}
