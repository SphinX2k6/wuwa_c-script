using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EC RID: 2028
	public class ConfigRegressEntryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F9A RID: 12186 RVA: 0x00169D08 File Offset: 0x00167F08
		static ConfigRegressEntryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressEntryAll.CreateStaticDefaultValue), new Action(ConfigRegressEntryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x00169D28 File Offset: 0x00167F28
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressEntryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressEntryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressEntry"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressEntry`")
			});
		}

		// Token: 0x06002F9C RID: 12188 RVA: 0x00169DA7 File Offset: 0x00167FA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressEntryAll.LogPair = null;
			ConfigRegressEntryAll.HandleId = 0;
		}

		// Token: 0x06002F9D RID: 12189 RVA: 0x00169DB5 File Offset: 0x00167FB5
		public static void Init()
		{
			ConfigRegressEntryAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressEntryAll.HandleId, "db_regressactivity.db", "select BinData from `RegressEntry`");
		}

		// Token: 0x06002F9E RID: 12190 RVA: 0x00169DD0 File Offset: 0x00167FD0
		[NullableContext(2)]
		public static IReadOnlyList<RegressEntry> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressEntryAll.HandleId, ConfigRegressEntryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressEntry> readOnlyList = (IReadOnlyList<RegressEntry>)ConfigCommon.GetConfig("RegressEntryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressEntry> list = new List<RegressEntry>();
			while (ConfigCommon.Step(ConfigRegressEntryAll.HandleId, false, ConfigRegressEntryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressEntryAll.HandleId, 0, ConfigRegressEntryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressEntryAll.HandleId, ConfigRegressEntryAll.LogPair);
					return null;
				}
				RegressEntry rootAsRegressEntry = RegressEntry.GetRootAsRegressEntry(new ByteBuffer(item2));
				list.Add(rootAsRegressEntry);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressEntryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressEntryAll.HandleId, ConfigRegressEntryAll.LogPair);
			return list;
		}

		// Token: 0x0400375A RID: 14170
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400375B RID: 14171
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400375C RID: 14172
		private const string TABLE = "RegressEntry";

		// Token: 0x0400375D RID: 14173
		private const string COMMAND = "select BinData from `RegressEntry`";

		// Token: 0x0400375E RID: 14174
		private const string KEY_PREFIX = "RegressEntryAll";

		// Token: 0x0400375F RID: 14175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003760 RID: 14176
		private static int HandleId;
	}
}
