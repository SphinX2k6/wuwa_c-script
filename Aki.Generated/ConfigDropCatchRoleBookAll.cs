using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023C RID: 572
	public class ConfigDropCatchRoleBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D6C RID: 3436 RVA: 0x000A56C7 File Offset: 0x000A38C7
		static ConfigDropCatchRoleBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleBookAll.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x000A56E8 File Offset: 0x000A38E8
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchRoleBookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchRoleBookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchRoleBook"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchRoleBook`")
			});
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x000A5767 File Offset: 0x000A3967
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleBookAll.LogPair = null;
			ConfigDropCatchRoleBookAll.HandleId = 0;
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x000A5775 File Offset: 0x000A3975
		public static void Init()
		{
			ConfigDropCatchRoleBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleBookAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRoleBook`");
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x000A5790 File Offset: 0x000A3990
		[NullableContext(2)]
		public static IReadOnlyList<DropCatchRoleBook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchRoleBookAll.HandleId, ConfigDropCatchRoleBookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DropCatchRoleBook> readOnlyList = (IReadOnlyList<DropCatchRoleBook>)ConfigCommon.GetConfig("DropCatchRoleBookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DropCatchRoleBook> list = new List<DropCatchRoleBook>();
			while (ConfigCommon.Step(ConfigDropCatchRoleBookAll.HandleId, false, ConfigDropCatchRoleBookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchRoleBookAll.HandleId, 0, ConfigDropCatchRoleBookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDropCatchRoleBookAll.HandleId, ConfigDropCatchRoleBookAll.LogPair);
					return null;
				}
				DropCatchRoleBook rootAsDropCatchRoleBook = DropCatchRoleBook.GetRootAsDropCatchRoleBook(new ByteBuffer(item2));
				list.Add(rootAsDropCatchRoleBook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DropCatchRoleBookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDropCatchRoleBookAll.HandleId, ConfigDropCatchRoleBookAll.LogPair);
			return list;
		}

		// Token: 0x04000F88 RID: 3976
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F89 RID: 3977
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F8A RID: 3978
		private const string TABLE = "DropCatchRoleBook";

		// Token: 0x04000F8B RID: 3979
		private const string COMMAND = "select BinData from `DropCatchRoleBook`";

		// Token: 0x04000F8C RID: 3980
		private const string KEY_PREFIX = "DropCatchRoleBookAll";

		// Token: 0x04000F8D RID: 3981
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F8E RID: 3982
		private static int HandleId;
	}
}
