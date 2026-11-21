using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000145 RID: 325
	public class ConfigCalabashLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600079F RID: 1951 RVA: 0x000885BC File Offset: 0x000867BC
		static ConfigCalabashLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashLevelAll.CreateStaticDefaultValue), new Action(ConfigCalabashLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000885DC File Offset: 0x000867DC
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashLevel`")
			});
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0008865B File Offset: 0x0008685B
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashLevelAll.LogPair = null;
			ConfigCalabashLevelAll.HandleId = 0;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00088669 File Offset: 0x00086869
		public static void Init()
		{
			ConfigCalabashLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashLevelAll.HandleId, "db_calabash.db", "select BinData from `CalabashLevel`");
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00088684 File Offset: 0x00086884
		[NullableContext(2)]
		public static IReadOnlyList<CalabashLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashLevelAll.HandleId, ConfigCalabashLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CalabashLevel> readOnlyList = (IReadOnlyList<CalabashLevel>)ConfigCommon.GetConfig("CalabashLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CalabashLevel> list = new List<CalabashLevel>();
			while (ConfigCommon.Step(ConfigCalabashLevelAll.HandleId, false, ConfigCalabashLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashLevelAll.HandleId, 0, ConfigCalabashLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCalabashLevelAll.HandleId, ConfigCalabashLevelAll.LogPair);
					return null;
				}
				CalabashLevel rootAsCalabashLevel = CalabashLevel.GetRootAsCalabashLevel(new ByteBuffer(item2));
				list.Add(rootAsCalabashLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CalabashLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCalabashLevelAll.HandleId, ConfigCalabashLevelAll.LogPair);
			return list;
		}

		// Token: 0x040008C7 RID: 2247
		private const string DB = "db_calabash.db";

		// Token: 0x040008C8 RID: 2248
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008C9 RID: 2249
		private const string TABLE = "CalabashLevel";

		// Token: 0x040008CA RID: 2250
		private const string COMMAND = "select BinData from `CalabashLevel`";

		// Token: 0x040008CB RID: 2251
		private const string KEY_PREFIX = "CalabashLevelAll";

		// Token: 0x040008CC RID: 2252
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008CD RID: 2253
		private static int HandleId;
	}
}
