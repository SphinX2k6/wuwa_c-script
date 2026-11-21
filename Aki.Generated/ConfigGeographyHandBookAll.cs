using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039C RID: 924
	public class ConfigGeographyHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015AE RID: 5550 RVA: 0x000D7C08 File Offset: 0x000D5E08
		static ConfigGeographyHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyHandBookAll.CreateStaticDefaultValue), new Action(ConfigGeographyHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000D7C28 File Offset: 0x000D5E28
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyHandBook`")
			});
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000D7CA7 File Offset: 0x000D5EA7
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyHandBookAll.LogPair = null;
			ConfigGeographyHandBookAll.HandleId = 0;
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000D7CB5 File Offset: 0x000D5EB5
		public static void Init()
		{
			ConfigGeographyHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyHandBookAll.HandleId, "db_handbook.db", "select BinData from `GeographyHandBook`");
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000D7CD0 File Offset: 0x000D5ED0
		[NullableContext(2)]
		public static IReadOnlyList<GeographyHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GeographyHandBook> readOnlyList = (IReadOnlyList<GeographyHandBook>)ConfigCommon.GetConfig("GeographyHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GeographyHandBook> list = new List<GeographyHandBook>();
			while (ConfigCommon.Step(ConfigGeographyHandBookAll.HandleId, false, ConfigGeographyHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyHandBookAll.HandleId, 0, ConfigGeographyHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair);
					return null;
				}
				GeographyHandBook rootAsGeographyHandBook = GeographyHandBook.GetRootAsGeographyHandBook(new ByteBuffer(item2));
				list.Add(rootAsGeographyHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GeographyHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyHandBookAll.HandleId, ConfigGeographyHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04001928 RID: 6440
		private const string DB = "db_handbook.db";

		// Token: 0x04001929 RID: 6441
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400192A RID: 6442
		private const string TABLE = "GeographyHandBook";

		// Token: 0x0400192B RID: 6443
		private const string COMMAND = "select BinData from `GeographyHandBook`";

		// Token: 0x0400192C RID: 6444
		private const string KEY_PREFIX = "GeographyHandBookAll";

		// Token: 0x0400192D RID: 6445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400192E RID: 6446
		private static int HandleId;
	}
}
