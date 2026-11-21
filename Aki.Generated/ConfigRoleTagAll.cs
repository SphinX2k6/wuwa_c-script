using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008EA RID: 2282
	public class ConfigRoleTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600358F RID: 13711 RVA: 0x0018B920 File Offset: 0x00189B20
		static ConfigRoleTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTagAll.CreateStaticDefaultValue), new Action(ConfigRoleTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0018B940 File Offset: 0x00189B40
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTag"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTag`")
			});
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0018B9BF File Offset: 0x00189BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTagAll.LogPair = null;
			ConfigRoleTagAll.HandleId = 0;
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0018B9CD File Offset: 0x00189BCD
		public static void Init()
		{
			ConfigRoleTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTagAll.HandleId, "db_role.db", "select BinData from `RoleTag`");
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0018B9E8 File Offset: 0x00189BE8
		[NullableContext(2)]
		public static IReadOnlyList<RoleTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTagAll.HandleId, ConfigRoleTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTag> readOnlyList = (IReadOnlyList<RoleTag>)ConfigCommon.GetConfig("RoleTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTag> list = new List<RoleTag>();
			while (ConfigCommon.Step(ConfigRoleTagAll.HandleId, false, ConfigRoleTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTagAll.HandleId, 0, ConfigRoleTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTagAll.HandleId, ConfigRoleTagAll.LogPair);
					return null;
				}
				RoleTag rootAsRoleTag = RoleTag.GetRootAsRoleTag(new ByteBuffer(item2));
				list.Add(rootAsRoleTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTagAll.HandleId, ConfigRoleTagAll.LogPair);
			return list;
		}

		// Token: 0x04003E4C RID: 15948
		private const string DB = "db_role.db";

		// Token: 0x04003E4D RID: 15949
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003E4E RID: 15950
		private const string TABLE = "RoleTag";

		// Token: 0x04003E4F RID: 15951
		private const string COMMAND = "select BinData from `RoleTag`";

		// Token: 0x04003E50 RID: 15952
		private const string KEY_PREFIX = "RoleTagAll";

		// Token: 0x04003E51 RID: 15953
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E52 RID: 15954
		private static int HandleId;
	}
}
