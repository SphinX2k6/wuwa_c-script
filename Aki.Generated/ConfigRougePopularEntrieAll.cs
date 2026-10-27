using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D9 RID: 2265
	public class ConfigRougePopularEntrieAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003529 RID: 13609 RVA: 0x00185DE8 File Offset: 0x00183FE8
		static ConfigRougePopularEntrieAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougePopularEntrieAll.CreateStaticDefaultValue), new Action(ConfigRougePopularEntrieAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600352A RID: 13610 RVA: 0x00185E08 File Offset: 0x00184008
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

		// Token: 0x0600352B RID: 13611 RVA: 0x00185E87 File Offset: 0x00184087
		public static void ResetStaticDefaultValue()
		{
			ConfigRougePopularEntrieAll.LogPair = null;
			ConfigRougePopularEntrieAll.HandleId = 0;
		}

		// Token: 0x0600352C RID: 13612 RVA: 0x00185E95 File Offset: 0x00184095
		public static void Init()
		{
			ConfigRougePopularEntrieAll.HandleId = ConfigCommon.InitDataStatement(ConfigRougePopularEntrieAll.HandleId, "db_rogue.db", "select BinData from `RougePopularEntrie`");
		}

		// Token: 0x0600352D RID: 13613 RVA: 0x00185EB0 File Offset: 0x001840B0
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

		// Token: 0x04003DD5 RID: 15829
		private const string DB = "db_rogue.db";

		// Token: 0x04003DD6 RID: 15830
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003DD7 RID: 15831
		private const string TABLE = "RougePopularEntrie";

		// Token: 0x04003DD8 RID: 15832
		private const string COMMAND = "select BinData from `RougePopularEntrie`";

		// Token: 0x04003DD9 RID: 15833
		private const string KEY_PREFIX = "RougePopularEntrieAll";

		// Token: 0x04003DDA RID: 15834
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DDB RID: 15835
		private static int HandleId;
	}
}
