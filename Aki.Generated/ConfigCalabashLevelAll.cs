using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000136 RID: 310
	public class ConfigCalabashLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00082C58 File Offset: 0x00080E58
		static ConfigCalabashLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashLevelAll.CreateStaticDefaultValue), new Action(ConfigCalabashLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00082C78 File Offset: 0x00080E78
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

		// Token: 0x06000747 RID: 1863 RVA: 0x00082CF7 File Offset: 0x00080EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashLevelAll.LogPair = null;
			ConfigCalabashLevelAll.HandleId = 0;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00082D05 File Offset: 0x00080F05
		public static void Init()
		{
			ConfigCalabashLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashLevelAll.HandleId, "db_calabash.db", "select BinData from `CalabashLevel`");
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00082D20 File Offset: 0x00080F20
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

		// Token: 0x0400085E RID: 2142
		private const string DB = "db_calabash.db";

		// Token: 0x0400085F RID: 2143
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000860 RID: 2144
		private const string TABLE = "CalabashLevel";

		// Token: 0x04000861 RID: 2145
		private const string COMMAND = "select BinData from `CalabashLevel`";

		// Token: 0x04000862 RID: 2146
		private const string KEY_PREFIX = "CalabashLevelAll";

		// Token: 0x04000863 RID: 2147
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000864 RID: 2148
		private static int HandleId;
	}
}
