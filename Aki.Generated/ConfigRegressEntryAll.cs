using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007D0 RID: 2000
	public class ConfigRegressEntryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EF2 RID: 12018 RVA: 0x00162A20 File Offset: 0x00160C20
		static ConfigRegressEntryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressEntryAll.CreateStaticDefaultValue), new Action(ConfigRegressEntryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x00162A40 File Offset: 0x00160C40
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

		// Token: 0x06002EF4 RID: 12020 RVA: 0x00162ABF File Offset: 0x00160CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressEntryAll.LogPair = null;
			ConfigRegressEntryAll.HandleId = 0;
		}

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00162ACD File Offset: 0x00160CCD
		public static void Init()
		{
			ConfigRegressEntryAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressEntryAll.HandleId, "db_regressactivity.db", "select BinData from `RegressEntry`");
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00162AE8 File Offset: 0x00160CE8
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

		// Token: 0x04003696 RID: 13974
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003697 RID: 13975
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003698 RID: 13976
		private const string TABLE = "RegressEntry";

		// Token: 0x04003699 RID: 13977
		private const string COMMAND = "select BinData from `RegressEntry`";

		// Token: 0x0400369A RID: 13978
		private const string KEY_PREFIX = "RegressEntryAll";

		// Token: 0x0400369B RID: 13979
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400369C RID: 13980
		private static int HandleId;
	}
}
