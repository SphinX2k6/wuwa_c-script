using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CE RID: 2254
	public class ConfigRoleTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034E7 RID: 13543 RVA: 0x00184638 File Offset: 0x00182838
		static ConfigRoleTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTagAll.CreateStaticDefaultValue), new Action(ConfigRoleTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00184658 File Offset: 0x00182858
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

		// Token: 0x060034E9 RID: 13545 RVA: 0x001846D7 File Offset: 0x001828D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTagAll.LogPair = null;
			ConfigRoleTagAll.HandleId = 0;
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x001846E5 File Offset: 0x001828E5
		public static void Init()
		{
			ConfigRoleTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTagAll.HandleId, "db_role.db", "select BinData from `RoleTag`");
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00184700 File Offset: 0x00182900
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

		// Token: 0x04003D88 RID: 15752
		private const string DB = "db_role.db";

		// Token: 0x04003D89 RID: 15753
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D8A RID: 15754
		private const string TABLE = "RoleTag";

		// Token: 0x04003D8B RID: 15755
		private const string COMMAND = "select BinData from `RoleTag`";

		// Token: 0x04003D8C RID: 15756
		private const string KEY_PREFIX = "RoleTagAll";

		// Token: 0x04003D8D RID: 15757
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D8E RID: 15758
		private static int HandleId;
	}
}
