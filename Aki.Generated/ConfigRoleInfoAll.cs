using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AE RID: 2222
	public class ConfigRoleInfoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003427 RID: 13351 RVA: 0x001800D4 File Offset: 0x0017E2D4
		static ConfigRoleInfoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoAll.CreateStaticDefaultValue), new Action(ConfigRoleInfoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x001800F4 File Offset: 0x0017E2F4
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

		// Token: 0x06003429 RID: 13353 RVA: 0x00180173 File Offset: 0x0017E373
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoAll.LogPair = null;
			ConfigRoleInfoAll.HandleId = 0;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00180181 File Offset: 0x0017E381
		public static void Init()
		{
			ConfigRoleInfoAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoAll.HandleId, "db_role.db", "select BinData from `RoleInfo`");
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x0018019C File Offset: 0x0017E39C
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

		// Token: 0x04003CA8 RID: 15528
		private const string DB = "db_role.db";

		// Token: 0x04003CA9 RID: 15529
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CAA RID: 15530
		private const string TABLE = "RoleInfo";

		// Token: 0x04003CAB RID: 15531
		private const string COMMAND = "select BinData from `RoleInfo`";

		// Token: 0x04003CAC RID: 15532
		private const string KEY_PREFIX = "RoleInfoAll";

		// Token: 0x04003CAD RID: 15533
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CAE RID: 15534
		private static int HandleId;
	}
}
