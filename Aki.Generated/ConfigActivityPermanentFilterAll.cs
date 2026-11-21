using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200004D RID: 77
	public class ConfigActivityPermanentFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060001CE RID: 462 RVA: 0x0006778D File Offset: 0x0006598D
		static ConfigActivityPermanentFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityPermanentFilterAll.CreateStaticDefaultValue), new Action(ConfigActivityPermanentFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000677AC File Offset: 0x000659AC
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityPermanentFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityPermanentFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activity.db"),
				new ValueTuple<string, object>("文件", "h.活动.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityPermanentFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityPermanentFilter`")
			});
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0006782B File Offset: 0x00065A2B
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityPermanentFilterAll.LogPair = null;
			ConfigActivityPermanentFilterAll.HandleId = 0;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00067839 File Offset: 0x00065A39
		public static void Init()
		{
			ConfigActivityPermanentFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityPermanentFilterAll.HandleId, "db_activity.db", "select BinData from `ActivityPermanentFilter`");
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00067854 File Offset: 0x00065A54
		[NullableContext(2)]
		public static IReadOnlyList<ActivityPermanentFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityPermanentFilterAll.HandleId, ConfigActivityPermanentFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityPermanentFilter> readOnlyList = (IReadOnlyList<ActivityPermanentFilter>)ConfigCommon.GetConfig("ActivityPermanentFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityPermanentFilter> list = new List<ActivityPermanentFilter>();
			while (ConfigCommon.Step(ConfigActivityPermanentFilterAll.HandleId, false, ConfigActivityPermanentFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityPermanentFilterAll.HandleId, 0, ConfigActivityPermanentFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityPermanentFilterAll.HandleId, ConfigActivityPermanentFilterAll.LogPair);
					return null;
				}
				ActivityPermanentFilter rootAsActivityPermanentFilter = ActivityPermanentFilter.GetRootAsActivityPermanentFilter(new ByteBuffer(item2));
				list.Add(rootAsActivityPermanentFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityPermanentFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityPermanentFilterAll.HandleId, ConfigActivityPermanentFilterAll.LogPair);
			return list;
		}

		// Token: 0x040001FF RID: 511
		private const string DB = "db_activity.db";

		// Token: 0x04000200 RID: 512
		private const string FILE = "h.活动.xlsx";

		// Token: 0x04000201 RID: 513
		private const string TABLE = "ActivityPermanentFilter";

		// Token: 0x04000202 RID: 514
		private const string COMMAND = "select BinData from `ActivityPermanentFilter`";

		// Token: 0x04000203 RID: 515
		private const string KEY_PREFIX = "ActivityPermanentFilterAll";

		// Token: 0x04000204 RID: 516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000205 RID: 517
		private static int HandleId;
	}
}
