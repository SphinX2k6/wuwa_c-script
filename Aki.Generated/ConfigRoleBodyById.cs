using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200088C RID: 2188
	public class ConfigRoleBodyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600335A RID: 13146 RVA: 0x0017BAB8 File Offset: 0x00179CB8
		static ConfigRoleBodyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleBodyById.CreateStaticDefaultValue), new Action(ConfigRoleBodyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x0017BAD8 File Offset: 0x00179CD8
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

		// Token: 0x0600335C RID: 13148 RVA: 0x0017BB57 File Offset: 0x00179D57
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleBodyById.LogPair = null;
			ConfigRoleBodyById.HandleId = 0;
		}

		// Token: 0x0600335D RID: 13149 RVA: 0x0017BB65 File Offset: 0x00179D65
		public static void Init()
		{
			ConfigRoleBodyById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleBodyById.HandleId, "db_role.db", "select BinData from `RoleBody` where Id=?");
		}

		// Token: 0x0600335E RID: 13150 RVA: 0x0017BB80 File Offset: 0x00179D80
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

		// Token: 0x04003BBA RID: 15290
		private const string DB = "db_role.db";

		// Token: 0x04003BBB RID: 15291
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003BBC RID: 15292
		private const string TABLE = "RoleBody";

		// Token: 0x04003BBD RID: 15293
		private const string COMMAND = "select BinData from `RoleBody` where Id=?";

		// Token: 0x04003BBE RID: 15294
		private const string KEY_PREFIX = "RoleBodyById";

		// Token: 0x04003BBF RID: 15295
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BC0 RID: 15296
		private static int HandleId;
	}
}
