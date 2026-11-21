using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CA RID: 2250
	public class ConfigRoleInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034CF RID: 13519 RVA: 0x001873BC File Offset: 0x001855BC
		static ConfigRoleInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x001873DC File Offset: 0x001855DC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfo`")
			});
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x0018745B File Offset: 0x0018565B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAll.LogPair = null;
			ConfigRoleInfoAll.HandleId = 0;
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00187469 File Offset: 0x00185669
		public static void Init()
		{
			ConfigRoleInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAll.HandleId, "db_role.db", "select BinData from `RoleInfo`");
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00187484 File Offset: 0x00185684
		[NullableContext(2)]
		public static IReadOnlyList<RoleInfo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoAll.HandleId, ConfigRoleInfoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleInfo> readOnlyList = (IReadOnlyList<RoleInfo>)ConfigCommon.GetConfig("RoleInfoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleInfo> list = new List<RoleInfo>();
			while (ConfigCommon.Step(ConfigRoleInfoAll.HandleId, false, ConfigRoleInfoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoAll.HandleId, 0, ConfigRoleInfoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleInfoAll.HandleId, ConfigRoleInfoAll.LogPair);
					return null;
				}
				RoleInfo rootAsRoleInfo = RoleInfo.GetRootAsRoleInfo(new ByteBuffer(item2));
				list.Add(rootAsRoleInfo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleInfoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleInfoAll.HandleId, ConfigRoleInfoAll.LogPair);
			return list;
		}

		// Token: 0x04003D6C RID: 15724
		private const string DB = "db_role.db";

		// Token: 0x04003D6D RID: 15725
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D6E RID: 15726
		private const string TABLE = "RoleInfo";

		// Token: 0x04003D6F RID: 15727
		private const string COMMAND = "select BinData from `RoleInfo`";

		// Token: 0x04003D70 RID: 15728
		private const string KEY_PREFIX = "RoleInfoAll";

		// Token: 0x04003D71 RID: 15729
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D72 RID: 15730
		private static int HandleId;
	}
}
