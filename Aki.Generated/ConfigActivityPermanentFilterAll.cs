using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000045 RID: 69
	public class ConfigActivityPermanentFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00062ED9 File Offset: 0x000610D9
		static ConfigActivityPermanentFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityPermanentFilterAll.CreateStaticDefaultValue), new Action(ConfigActivityPermanentFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00062EF8 File Offset: 0x000610F8
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

		// Token: 0x060001A0 RID: 416 RVA: 0x00062F77 File Offset: 0x00061177
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityPermanentFilterAll.LogPair = null;
			ConfigActivityPermanentFilterAll.HandleId = 0;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00062F85 File Offset: 0x00061185
		public static void Init()
		{
			ConfigActivityPermanentFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityPermanentFilterAll.HandleId, "db_activity.db", "select BinData from `ActivityPermanentFilter`");
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00062FA0 File Offset: 0x000611A0
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

		// Token: 0x040001C7 RID: 455
		private const string DB = "db_activity.db";

		// Token: 0x040001C8 RID: 456
		private const string FILE = "h.活动.xlsx";

		// Token: 0x040001C9 RID: 457
		private const string TABLE = "ActivityPermanentFilter";

		// Token: 0x040001CA RID: 458
		private const string COMMAND = "select BinData from `ActivityPermanentFilter`";

		// Token: 0x040001CB RID: 459
		private const string KEY_PREFIX = "ActivityPermanentFilterAll";

		// Token: 0x040001CC RID: 460
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001CD RID: 461
		private static int HandleId;
	}
}
