using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000052 RID: 82
	public class ConfigActivityRecommendAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001EC RID: 492 RVA: 0x0006818C File Offset: 0x0006638C
		static ConfigActivityRecommendAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityRecommendAll.CreateStaticDefaultValue), new Action(ConfigActivityRecommendAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001ED RID: 493 RVA: 0x000681AC File Offset: 0x000663AC
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

		// Token: 0x060001EE RID: 494 RVA: 0x0006822B File Offset: 0x0006642B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityRecommendAll.LogPair = null;
			ConfigActivityRecommendAll.HandleId = 0;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00068239 File Offset: 0x00066439
		public static void Init()
		{
			ConfigActivityRecommendAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityRecommendAll.HandleId, "db_activityrecommend.db", "select BinData from `ActivityRecommend`");
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00068254 File Offset: 0x00066454
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

		// Token: 0x04000222 RID: 546
		private const string DB = "db_activityrecommend.db";

		// Token: 0x04000223 RID: 547
		private const string FILE = "h.活动推荐内容.xlsx";

		// Token: 0x04000224 RID: 548
		private const string TABLE = "ActivityRecommend";

		// Token: 0x04000225 RID: 549
		private const string COMMAND = "select BinData from `ActivityRecommend`";

		// Token: 0x04000226 RID: 550
		private const string KEY_PREFIX = "ActivityRecommendAll";

		// Token: 0x04000227 RID: 551
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000228 RID: 552
		private static int HandleId;
	}
}
