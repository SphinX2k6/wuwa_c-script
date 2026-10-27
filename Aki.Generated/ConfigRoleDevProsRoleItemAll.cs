using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089E RID: 2206
	public class ConfigRoleDevProsRoleItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033C6 RID: 13254 RVA: 0x0017DF74 File Offset: 0x0017C174
		static ConfigRoleDevProsRoleItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProsRoleItemAll.CreateStaticDefaultValue), new Action(ConfigRoleDevProsRoleItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x0017DF94 File Offset: 0x0017C194
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevProsRoleItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevProsRoleItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevProsRoleItem`")
			});
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x0017E013 File Offset: 0x0017C213
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProsRoleItemAll.LogPair = null;
			ConfigRoleDevProsRoleItemAll.HandleId = 0;
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x0017E021 File Offset: 0x0017C221
		public static void Init()
		{
			ConfigRoleDevProsRoleItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProsRoleItemAll.HandleId, "db_roledev.db", "select BinData from `RoleDevProsRoleItem`");
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x0017E03C File Offset: 0x0017C23C
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevProsRoleItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevProsRoleItem> readOnlyList = (IReadOnlyList<RoleDevProsRoleItem>)ConfigCommon.GetConfig("RoleDevProsRoleItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevProsRoleItem> list = new List<RoleDevProsRoleItem>();
			while (ConfigCommon.Step(ConfigRoleDevProsRoleItemAll.HandleId, false, ConfigRoleDevProsRoleItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevProsRoleItemAll.HandleId, 0, ConfigRoleDevProsRoleItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair);
					return null;
				}
				RoleDevProsRoleItem rootAsRoleDevProsRoleItem = RoleDevProsRoleItem.GetRootAsRoleDevProsRoleItem(new ByteBuffer(item2));
				list.Add(rootAsRoleDevProsRoleItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevProsRoleItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevProsRoleItemAll.HandleId, ConfigRoleDevProsRoleItemAll.LogPair);
			return list;
		}

		// Token: 0x04003C38 RID: 15416
		private const string DB = "db_roledev.db";

		// Token: 0x04003C39 RID: 15417
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C3A RID: 15418
		private const string TABLE = "RoleDevProsRoleItem";

		// Token: 0x04003C3B RID: 15419
		private const string COMMAND = "select BinData from `RoleDevProsRoleItem`";

		// Token: 0x04003C3C RID: 15420
		private const string KEY_PREFIX = "RoleDevProsRoleItemAll";

		// Token: 0x04003C3D RID: 15421
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C3E RID: 15422
		private static int HandleId;
	}
}
