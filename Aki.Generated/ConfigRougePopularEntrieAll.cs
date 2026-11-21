using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000924 RID: 2340
	public class ConfigRougePopularEntrieAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036EB RID: 14059 RVA: 0x00193008 File Offset: 0x00191208
		static ConfigRougePopularEntrieAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougePopularEntrieAll.CreateStaticDefaultValue), new Action(ConfigRougePopularEntrieAll.ResetStaticDefaultValue));
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x00193028 File Offset: 0x00191228
		public static void CreateStaticDefaultValue()
		{
			ConfigRougePopularEntrieAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougePopularEntrieAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougePopularEntrie"),
				new ValueTuple<string, object>("语句", "select BinData from `RougePopularEntrie`")
			});
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x001930A7 File Offset: 0x001912A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRougePopularEntrieAll.LogPair = null;
			ConfigRougePopularEntrieAll.HandleId = 0;
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x001930B5 File Offset: 0x001912B5
		public static void Init()
		{
			ConfigRougePopularEntrieAll.HandleId = ConfigCommon.InitDataStatement(ConfigRougePopularEntrieAll.HandleId, "db_rogue.db", "select BinData from `RougePopularEntrie`");
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x001930D0 File Offset: 0x001912D0
		[NullableContext(2)]
		public static IReadOnlyList<RougePopularEntrie> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougePopularEntrieAll.HandleId, ConfigRougePopularEntrieAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RougePopularEntrie> readOnlyList = (IReadOnlyList<RougePopularEntrie>)ConfigCommon.GetConfig("RougePopularEntrieAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RougePopularEntrie> list = new List<RougePopularEntrie>();
			while (ConfigCommon.Step(ConfigRougePopularEntrieAll.HandleId, false, ConfigRougePopularEntrieAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougePopularEntrieAll.HandleId, 0, ConfigRougePopularEntrieAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRougePopularEntrieAll.HandleId, ConfigRougePopularEntrieAll.LogPair);
					return null;
				}
				RougePopularEntrie rootAsRougePopularEntrie = RougePopularEntrie.GetRootAsRougePopularEntrie(new ByteBuffer(item2));
				list.Add(rootAsRougePopularEntrie);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RougePopularEntrieAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRougePopularEntrieAll.HandleId, ConfigRougePopularEntrieAll.LogPair);
			return list;
		}

		// Token: 0x04003FE2 RID: 16354
		private const string DB = "db_rogue.db";

		// Token: 0x04003FE3 RID: 16355
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003FE4 RID: 16356
		private const string TABLE = "RougePopularEntrie";

		// Token: 0x04003FE5 RID: 16357
		private const string COMMAND = "select BinData from `RougePopularEntrie`";

		// Token: 0x04003FE6 RID: 16358
		private const string KEY_PREFIX = "RougePopularEntrieAll";

		// Token: 0x04003FE7 RID: 16359
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FE8 RID: 16360
		private static int HandleId;
	}
}
