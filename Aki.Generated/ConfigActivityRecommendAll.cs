using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004A RID: 74
	public class ConfigActivityRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001BC RID: 444 RVA: 0x000638D8 File Offset: 0x00061AD8
		static ConfigActivityRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendAll.CreateStaticDefaultValue), new Action(ConfigActivityRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000638F8 File Offset: 0x00061AF8
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityRecommendAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityRecommendAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activityrecommend.db"),
				new ValueTuple<string, object>("文件", "h.活动推荐内容.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityRecommend"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityRecommend`")
			});
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00063977 File Offset: 0x00061B77
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendAll.LogPair = null;
			ConfigActivityRecommendAll.HandleId = 0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00063985 File Offset: 0x00061B85
		public static void Init()
		{
			ConfigActivityRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendAll.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend`");
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000639A0 File Offset: 0x00061BA0
		[NullableContext(2)]
		public static IReadOnlyList<ActivityRecommend> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityRecommendAll.HandleId, ConfigActivityRecommendAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityRecommend> readOnlyList = (IReadOnlyList<ActivityRecommend>)ConfigCommon.GetConfig("ActivityRecommendAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityRecommend> list = new List<ActivityRecommend>();
			while (ConfigCommon.Step(ConfigActivityRecommendAll.HandleId, false, ConfigActivityRecommendAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityRecommendAll.HandleId, 0, ConfigActivityRecommendAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityRecommendAll.HandleId, ConfigActivityRecommendAll.LogPair);
					return null;
				}
				ActivityRecommend rootAsActivityRecommend = ActivityRecommend.GetRootAsActivityRecommend(new ByteBuffer(item2));
				list.Add(rootAsActivityRecommend);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityRecommendAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityRecommendAll.HandleId, ConfigActivityRecommendAll.LogPair);
			return list;
		}

		// Token: 0x040001EA RID: 490
		private const string DB = "db_activityrecommend.db";

		// Token: 0x040001EB RID: 491
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x040001EC RID: 492
		private const string TABLE = "ActivityRecommend";

		// Token: 0x040001ED RID: 493
		private const string COMMAND = "select BinData from `ActivityRecommend`";

		// Token: 0x040001EE RID: 494
		private const string KEY_PREFIX = "ActivityRecommendAll";

		// Token: 0x040001EF RID: 495
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001F0 RID: 496
		private static int HandleId;
	}
}
