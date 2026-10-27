using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200003F RID: 63
	public class ConfigActivityFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00062134 File Offset: 0x00060334
		static ConfigActivityFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityFilterAll.CreateStaticDefaultValue), new Action(ConfigActivityFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00062154 File Offset: 0x00060354
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

		// Token: 0x0600017C RID: 380 RVA: 0x000621D3 File Offset: 0x000603D3
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityFilterAll.LogPair = null;
			ConfigActivityFilterAll.HandleId = 0;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000621E1 File Offset: 0x000603E1
		public static void Init()
		{
			ConfigActivityFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityFilterAll.HandleId, "db_activity.db", "select BinData from `ActivityFilter`");
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000621FC File Offset: 0x000603FC
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

		// Token: 0x0400019D RID: 413
		private const string DB = "db_activity.db";

		// Token: 0x0400019E RID: 414
		private const string FILE = "h.活动.xlsx";

		// Token: 0x0400019F RID: 415
		private const string TABLE = "ActivityFilter";

		// Token: 0x040001A0 RID: 416
		private const string COMMAND = "select BinData from `ActivityFilter`";

		// Token: 0x040001A1 RID: 417
		private const string KEY_PREFIX = "ActivityFilterAll";

		// Token: 0x040001A2 RID: 418
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001A3 RID: 419
		private static int HandleId;
	}
}
