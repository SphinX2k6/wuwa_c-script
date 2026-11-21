using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000047 RID: 71
	public class ConfigActivityFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001AA RID: 426 RVA: 0x000669E8 File Offset: 0x00064BE8
		static ConfigActivityFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityFilterAll.CreateStaticDefaultValue), new Action(ConfigActivityFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00066A08 File Offset: 0x00064C08
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityFilter`")
			});
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00066A87 File Offset: 0x00064C87
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityFilterAll.LogPair = null;
			ConfigActivityFilterAll.HandleId = 0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00066A95 File Offset: 0x00064C95
		public static void Init()
		{
			ConfigActivityFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityFilterAll.HandleId, "db_activity.db", "select BinData from `ActivityFilter`");
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00066AB0 File Offset: 0x00064CB0
		[NullableContext(2)]
		public static IReadOnlyList<ActivityFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityFilterAll.HandleId, ConfigActivityFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityFilter> readOnlyList = (IReadOnlyList<ActivityFilter>)ConfigCommon.GetConfig("ActivityFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityFilter> list = new List<ActivityFilter>();
			while (ConfigCommon.Step(ConfigActivityFilterAll.HandleId, false, ConfigActivityFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityFilterAll.HandleId, 0, ConfigActivityFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityFilterAll.HandleId, ConfigActivityFilterAll.LogPair);
					return null;
				}
				ActivityFilter rootAsActivityFilter = ActivityFilter.GetRootAsActivityFilter(new ByteBuffer(item2));
				list.Add(rootAsActivityFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityFilterAll.HandleId, ConfigActivityFilterAll.LogPair);
			return list;
		}

		// Token: 0x040001D5 RID: 469
		private const string DB = "db_activity.db";

		// Token: 0x040001D6 RID: 470
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001D7 RID: 471
		private const string TABLE = "ActivityFilter";

		// Token: 0x040001D8 RID: 472
		private const string COMMAND = "select BinData from `ActivityFilter`";

		// Token: 0x040001D9 RID: 473
		private const string KEY_PREFIX = "ActivityFilterAll";

		// Token: 0x040001DA RID: 474
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001DB RID: 475
		private static int HandleId;
	}
}
