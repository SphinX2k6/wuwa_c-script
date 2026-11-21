using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024E RID: 590
	public class ConfigDropCatchRoleBookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x000AB5FF File Offset: 0x000A97FF
		static ConfigDropCatchRoleBookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleBookAll.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleBookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000AB620 File Offset: 0x000A9820
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

		// Token: 0x06000DDA RID: 3546 RVA: 0x000AB69F File Offset: 0x000A989F
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleBookAll.LogPair = null;
			ConfigDropCatchRoleBookAll.HandleId = 0;
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x000AB6AD File Offset: 0x000A98AD
		public static void Init()
		{
			ConfigDropCatchRoleBookAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleBookAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRoleBook`");
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000AB6C8 File Offset: 0x000A98C8
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

		// Token: 0x04001006 RID: 4102
		private const string DB = "db_dropcatch.db";

		// Token: 0x04001007 RID: 4103
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04001008 RID: 4104
		private const string TABLE = "DropCatchRoleBook";

		// Token: 0x04001009 RID: 4105
		private const string COMMAND = "select BinData from `DropCatchRoleBook`";

		// Token: 0x0400100A RID: 4106
		private const string KEY_PREFIX = "DropCatchRoleBookAll";

		// Token: 0x0400100B RID: 4107
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400100C RID: 4108
		private static int HandleId;
	}
}
