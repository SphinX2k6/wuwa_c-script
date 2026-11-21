using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000042 RID: 66
	public class ConfigActivityConditionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600018C RID: 396 RVA: 0x00065FF8 File Offset: 0x000641F8
		static ConfigActivityConditionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigActivityConditionAll.CreateStaticDefaultValue), new Action(ConfigActivityConditionAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00066018 File Offset: 0x00064218
		public static void CreateStaticDefaultValue()
		{
			ConfigActivityConditionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigActivityConditionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_activitycondition.db"),
				new ValueTuple<string, object>("文件", "h.活动条件.xlsx"),
				new ValueTuple<string, object>("表名", "ActivityCondition"),
				new ValueTuple<string, object>("语句", "select BinData from `ActivityCondition`")
			});
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00066097 File Offset: 0x00064297
		public static void ResetStaticDefaultValue()
		{
			ConfigActivityConditionAll.LogPair = null;
			ConfigActivityConditionAll.HandleId = 0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000660A5 File Offset: 0x000642A5
		public static void Init()
		{
			ConfigActivityConditionAll.HandleId = ConfigCommon.InitDataStatement(ConfigActivityConditionAll.HandleId, "db_activitycondition.db", "select BinData from `ActivityCondition`");
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000660C0 File Offset: 0x000642C0
		[NullableContext(2)]
		public static IReadOnlyList<ActivityCondition> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigActivityConditionAll.HandleId, ConfigActivityConditionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ActivityCondition> readOnlyList = (IReadOnlyList<ActivityCondition>)ConfigCommon.GetConfig("ActivityConditionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ActivityCondition> list = new List<ActivityCondition>();
			while (ConfigCommon.Step(ConfigActivityConditionAll.HandleId, false, ConfigActivityConditionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigActivityConditionAll.HandleId, 0, ConfigActivityConditionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigActivityConditionAll.HandleId, ConfigActivityConditionAll.LogPair);
					return null;
				}
				ActivityCondition rootAsActivityCondition = ActivityCondition.GetRootAsActivityCondition(new ByteBuffer(item2));
				list.Add(rootAsActivityCondition);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ActivityConditionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigActivityConditionAll.HandleId, ConfigActivityConditionAll.LogPair);
			return list;
		}

		// Token: 0x040001B2 RID: 434
		private const string DB = "db_activitycondition.db";

		// Token: 0x040001B3 RID: 435
		private const string FILE = "h.活动条件.xlsx";

		// Token: 0x040001B4 RID: 436
		private const string TABLE = "ActivityCondition";

		// Token: 0x040001B5 RID: 437
		private const string COMMAND = "select BinData from `ActivityCondition`";

		// Token: 0x040001B6 RID: 438
		private const string KEY_PREFIX = "ActivityConditionAll";

		// Token: 0x040001B7 RID: 439
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040001B8 RID: 440
		private static int HandleId;
	}
}
