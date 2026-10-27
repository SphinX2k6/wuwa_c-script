using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054F RID: 1359
	public class ConfigMonsterHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FE7 RID: 8167 RVA: 0x0010DB3B File Offset: 0x0010BD3B
		static ConfigMonsterHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterHandBookAll.CreateStaticDefaultValue), new Action(ConfigMonsterHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0010DB5C File Offset: 0x0010BD5C
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

		// Token: 0x06001FE9 RID: 8169 RVA: 0x0010DBDB File Offset: 0x0010BDDB
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterHandBookAll.LogPair = null;
			ConfigMonsterHandBookAll.HandleId = 0;
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0010DBE9 File Offset: 0x0010BDE9
		public static void Init()
		{
			ConfigMonsterHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterHandBookAll.HandleId, "db_handbook.db", "select BinData from `MonsterHandBook`");
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x0010DC04 File Offset: 0x0010BE04
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

		// Token: 0x0400250D RID: 9485
		private const string DB = "db_handbook.db";

		// Token: 0x0400250E RID: 9486
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400250F RID: 9487
		private const string TABLE = "MonsterHandBook";

		// Token: 0x04002510 RID: 9488
		private const string COMMAND = "select BinData from `MonsterHandBook`";

		// Token: 0x04002511 RID: 9489
		private const string KEY_PREFIX = "MonsterHandBookAll";

		// Token: 0x04002512 RID: 9490
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002513 RID: 9491
		private static int HandleId;
	}
}
