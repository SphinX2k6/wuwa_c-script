using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000565 RID: 1381
	public class ConfigMonsterHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600206B RID: 8299 RVA: 0x0011428F File Offset: 0x0011248F
		static ConfigMonsterHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookAll.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x001142B0 File Offset: 0x001124B0
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterHandBook`")
			});
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0011432F File Offset: 0x0011252F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookAll.LogPair = null;
			ConfigMonsterHandBookAll.HandleId = 0;
		}

		// Token: 0x0600206E RID: 8302 RVA: 0x0011433D File Offset: 0x0011253D
		public static void Init()
		{
			ConfigMonsterHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookAll.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook`");
		}

		// Token: 0x0600206F RID: 8303 RVA: 0x00114358 File Offset: 0x00112558
		[NullableContext(2)]
		public static IReadOnlyList<MonsterHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterHandBookAll.HandleId, ConfigMonsterHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MonsterHandBook> readOnlyList = (IReadOnlyList<MonsterHandBook>)ConfigCommon.GetConfig("MonsterHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MonsterHandBook> list = new List<MonsterHandBook>();
			while (ConfigCommon.Step(ConfigMonsterHandBookAll.HandleId, false, ConfigMonsterHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterHandBookAll.HandleId, 0, ConfigMonsterHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterHandBookAll.HandleId, ConfigMonsterHandBookAll.LogPair);
					return null;
				}
				MonsterHandBook rootAsMonsterHandBook = MonsterHandBook.GetRootAsMonsterHandBook(new ByteBuffer(item2));
				list.Add(rootAsMonsterHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MonsterHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterHandBookAll.HandleId, ConfigMonsterHandBookAll.LogPair);
			return list;
		}

		// Token: 0x040025A7 RID: 9639
		private const string DB = "db_handbook.db";

		// Token: 0x040025A8 RID: 9640
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040025A9 RID: 9641
		private const string TABLE = "MonsterHandBook";

		// Token: 0x040025AA RID: 9642
		private const string COMMAND = "select BinData from `MonsterHandBook`";

		// Token: 0x040025AB RID: 9643
		private const string KEY_PREFIX = "MonsterHandBookAll";

		// Token: 0x040025AC RID: 9644
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025AD RID: 9645
		private static int HandleId;
	}
}
