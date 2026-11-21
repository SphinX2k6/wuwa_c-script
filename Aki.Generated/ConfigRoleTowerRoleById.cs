using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000904 RID: 2308
	public class ConfigRoleTowerRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600362B RID: 13867 RVA: 0x0018EDAB File Offset: 0x0018CFAB
		static ConfigRoleTowerRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRoleById.CreateStaticDefaultValue), new Action(ConfigRoleTowerRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600362C RID: 13868 RVA: 0x0018EDCC File Offset: 0x0018CFCC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRole` where Id=?")
			});
		}

		// Token: 0x0600362D RID: 13869 RVA: 0x0018EE4B File Offset: 0x0018D04B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRoleById.LogPair = null;
			ConfigRoleTowerRoleById.HandleId = 0;
		}

		// Token: 0x0600362E RID: 13870 RVA: 0x0018EE59 File Offset: 0x0018D059
		public static void Init()
		{
			ConfigRoleTowerRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRoleById.HandleId, "db_roletower.db", "select BinData from `RoleTowerRole` where Id=?");
		}

		// Token: 0x0600362F RID: 13871 RVA: 0x0018EE74 File Offset: 0x0018D074
		public static RoleTowerRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRoleById.HandleId, ConfigRoleTowerRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTowerRole?(RoleTowerRole.GetRootAsRoleTowerRole(configBuffer));
				}
			}
			ConfigRoleTowerRoleById.LogPair.Clear();
			ConfigRoleTowerRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTowerRoleById.HandleId, 1, p0Id, ConfigRoleTowerRoleById.LogPair) || ConfigCommon.Step(ConfigRoleTowerRoleById.HandleId, true, ConfigRoleTowerRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTowerRoleById.HandleId, ConfigRoleTowerRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRoleById.HandleId, 0, ConfigRoleTowerRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTowerRoleById.HandleId, ConfigRoleTowerRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTowerRole rootAsRoleTowerRole = RoleTowerRole.GetRootAsRoleTowerRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTowerRoleById.HandleId, ConfigRoleTowerRoleById.LogPair);
			return new RoleTowerRole?(rootAsRoleTowerRole);
		}

		// Token: 0x04003F02 RID: 16130
		private const string DB = "db_roletower.db";

		// Token: 0x04003F03 RID: 16131
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003F04 RID: 16132
		private const string TABLE = "RoleTowerRole";

		// Token: 0x04003F05 RID: 16133
		private const string COMMAND = "select BinData from `RoleTowerRole` where Id=?";

		// Token: 0x04003F06 RID: 16134
		private const string KEY_PREFIX = "RoleTowerRoleById";

		// Token: 0x04003F07 RID: 16135
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F08 RID: 16136
		private static int HandleId;
	}
}
