using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006DC RID: 1756
	public class ConfigPhotographHandBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002938 RID: 10552 RVA: 0x0014259C File Offset: 0x0014079C
		static ConfigPhotographHandBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhotographHandBookAll.CreateStaticDefaultValue), new Action(ConfigPhotographHandBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x001425BC File Offset: 0x001407BC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhotographHandBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhotographHandBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhotographHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `PhotographHandBook`")
			});
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x0014263B File Offset: 0x0014083B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhotographHandBookAll.LogPair = null;
			ConfigPhotographHandBookAll.HandleId = 0;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00142649 File Offset: 0x00140849
		public static void Init()
		{
			ConfigPhotographHandBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigPhotographHandBookAll.HandleId, "db_handbook.db", "select BinData from `PhotographHandBook`");
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00142664 File Offset: 0x00140864
		[NullableContext(2)]
		public static IReadOnlyList<PhotographHandBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PhotographHandBook> readOnlyList = (IReadOnlyList<PhotographHandBook>)ConfigCommon.GetConfig("PhotographHandBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PhotographHandBook> list = new List<PhotographHandBook>();
			while (ConfigCommon.Step(ConfigPhotographHandBookAll.HandleId, false, ConfigPhotographHandBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhotographHandBookAll.HandleId, 0, ConfigPhotographHandBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair);
					return null;
				}
				PhotographHandBook rootAsPhotographHandBook = PhotographHandBook.GetRootAsPhotographHandBook(new ByteBuffer(item2));
				list.Add(rootAsPhotographHandBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PhotographHandBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPhotographHandBookAll.HandleId, ConfigPhotographHandBookAll.LogPair);
			return list;
		}

		// Token: 0x04002FEA RID: 12266
		private const string DB = "db_handbook.db";

		// Token: 0x04002FEB RID: 12267
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002FEC RID: 12268
		private const string TABLE = "PhotographHandBook";

		// Token: 0x04002FED RID: 12269
		private const string COMMAND = "select BinData from `PhotographHandBook`";

		// Token: 0x04002FEE RID: 12270
		private const string KEY_PREFIX = "PhotographHandBookAll";

		// Token: 0x04002FEF RID: 12271
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FF0 RID: 12272
		private static int HandleId;
	}
}
