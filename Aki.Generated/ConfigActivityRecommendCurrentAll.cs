using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004E RID: 78
	public class ConfigActivityRecommendCurrentAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001D4 RID: 468 RVA: 0x00064134 File Offset: 0x00062334
		static ConfigActivityRecommendCurrentAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendCurrentAll.CreateStaticDefaultValue), new Action(ConfigActivityRecommendCurrentAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00064154 File Offset: 0x00062354
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

		// Token: 0x060001D6 RID: 470 RVA: 0x000641D3 File Offset: 0x000623D3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendCurrentAll.LogPair = null;
			ConfigActivityRecommendCurrentAll.HandleId = 0;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000641E1 File Offset: 0x000623E1
		public static void Init()
		{
			ConfigActivityRecommendCurrentAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendCurrentAll.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommendCurrent`");
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000641FC File Offset: 0x000623FC
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

		// Token: 0x04000206 RID: 518
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000207 RID: 519
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000208 RID: 520
		private const string TABLE = "ActivityRecommendCurrent";

		// Token: 0x04000209 RID: 521
		private const string COMMAND = "select BinData from `ActivityRecommendCurrent`";

		// Token: 0x0400020A RID: 522
		private const string KEY_PREFIX = "ActivityRecommendCurrentAll";

		// Token: 0x0400020B RID: 523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400020C RID: 524
		private static int HandleId;
	}
}
