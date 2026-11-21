using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A8 RID: 2216
	public class ConfigRoleBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003402 RID: 13314 RVA: 0x00182DA0 File Offset: 0x00180FA0
		static ConfigRoleBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBodyById.CreateStaticDefaultValue), new Action(ConfigRoleBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x00182DC0 File Offset: 0x00180FC0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleBodyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleBodyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleBody"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleBody` where Id=?")
			});
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x00182E3F File Offset: 0x0018103F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBodyById.LogPair = null;
			ConfigRoleBodyById.HandleId = 0;
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x00182E4D File Offset: 0x0018104D
		public static void Init()
		{
			ConfigRoleBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBodyById.HandleId, "db_role.db", "select BinData from `RoleBody` where Id=?");
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x00182E68 File Offset: 0x00181068
		public static RoleBody? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleBodyById.HandleId, ConfigRoleBodyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("RoleBodyById#" + p0Id);
				if (configBuffer != null)
				{
					return new RoleBody?(RoleBody.GetRootAsRoleBody(configBuffer));
				}
			}
			ConfigRoleBodyById.LogPair.Clear();
			ConfigRoleBodyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigRoleBodyById.HandleId, 1, p0Id, ConfigRoleBodyById.LogPair) || ConfigCommon.Step(ConfigRoleBodyById.HandleId, true, ConfigRoleBodyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleBodyById.HandleId, ConfigRoleBodyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleBodyById.HandleId, 0, ConfigRoleBodyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleBodyById.HandleId, ConfigRoleBodyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleBody rootAsRoleBody = RoleBody.GetRootAsRoleBody(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("RoleBodyById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleBodyById.HandleId, ConfigRoleBodyById.LogPair);
			return new RoleBody?(rootAsRoleBody);
		}

		// Token: 0x04003C7E RID: 15486
		private const string DB = "db_role.db";

		// Token: 0x04003C7F RID: 15487
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003C80 RID: 15488
		private const string TABLE = "RoleBody";

		// Token: 0x04003C81 RID: 15489
		private const string COMMAND = "select BinData from `RoleBody` where Id=?";

		// Token: 0x04003C82 RID: 15490
		private const string KEY_PREFIX = "RoleBodyById";

		// Token: 0x04003C83 RID: 15491
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C84 RID: 15492
		private static int HandleId;
	}
}
