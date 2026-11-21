using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000905 RID: 2309
	public class ConfigRoleTowerRoleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003631 RID: 13873 RVA: 0x0018EFF4 File Offset: 0x0018D1F4
		static ConfigRoleTowerRoleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRoleByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleTowerRoleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003632 RID: 13874 RVA: 0x0018F014 File Offset: 0x0018D214
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRoleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRoleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRole` where RoleId=?")
			});
		}

		// Token: 0x06003633 RID: 13875 RVA: 0x0018F093 File Offset: 0x0018D293
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRoleByRoleId.LogPair = null;
			ConfigRoleTowerRoleByRoleId.HandleId = 0;
		}

		// Token: 0x06003634 RID: 13876 RVA: 0x0018F0A1 File Offset: 0x0018D2A1
		public static void Init()
		{
			ConfigRoleTowerRoleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRoleByRoleId.HandleId, "db_roletower.db", "select BinData from `RoleTowerRole` where RoleId=?");
		}

		// Token: 0x06003635 RID: 13877 RVA: 0x0018F0BC File Offset: 0x0018D2BC
		public static RoleTowerRole? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRoleByRoleId.HandleId, ConfigRoleTowerRoleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerRole?(RoleTowerRole.GetRootAsRoleTowerRole(configBuffer));
				}
			}
			ConfigRoleTowerRoleByRoleId.LogPair.Clear();
			ConfigRoleTowerRoleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRoleByRoleId.HandleId, 1, p0RoleId, ConfigRoleTowerRoleByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleTowerRoleByRoleId.HandleId, true, ConfigRoleTowerRoleByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerRoleByRoleId.HandleId, ConfigRoleTowerRoleByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRoleByRoleId.HandleId, 0, ConfigRoleTowerRoleByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerRoleByRoleId.HandleId, ConfigRoleTowerRoleByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerRole rootAsRoleTowerRole = RoleTowerRole.GetRootAsRoleTowerRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRoleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerRoleByRoleId.HandleId, ConfigRoleTowerRoleByRoleId.LogPair);
			return new RoleTowerRole?(rootAsRoleTowerRole);
		}

		// Token: 0x04003F09 RID: 16137
		private const string DB = "db_roletower.db";

		// Token: 0x04003F0A RID: 16138
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F0B RID: 16139
		private const string TABLE = "RoleTowerRole";

		// Token: 0x04003F0C RID: 16140
		private const string COMMAND = "select BinData from `RoleTowerRole` where RoleId=?";

		// Token: 0x04003F0D RID: 16141
		private const string KEY_PREFIX = "RoleTowerRoleByRoleId";

		// Token: 0x04003F0E RID: 16142
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F0F RID: 16143
		private static int HandleId;
	}
}
