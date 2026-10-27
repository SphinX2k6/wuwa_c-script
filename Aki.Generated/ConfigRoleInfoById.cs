using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B1 RID: 2225
	public class ConfigRoleInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003439 RID: 13369 RVA: 0x00180644 File Offset: 0x0017E844
		static ConfigRoleInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoById.CreateStaticDefaultValue), new Action(ConfigRoleInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00180664 File Offset: 0x0017E864
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfo` where Id=?")
			});
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x001806E3 File Offset: 0x0017E8E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoById.LogPair = null;
			ConfigRoleInfoById.HandleId = 0;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x001806F1 File Offset: 0x0017E8F1
		public static void Init()
		{
			ConfigRoleInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoById.HandleId, "db_role.db", "select BinData from `RoleInfo` where Id=?");
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x0018070C File Offset: 0x0017E90C
		public static RoleInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoById.HandleId, ConfigRoleInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleInfo?(RoleInfo.GetRootAsRoleInfo(configBuffer));
				}
			}
			ConfigRoleInfoById.LogPair.Clear();
			ConfigRoleInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleInfoById.HandleId, 1, p0Id, ConfigRoleInfoById.LogPair) || ConfigCommon.Step(ConfigRoleInfoById.HandleId, true, ConfigRoleInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleInfoById.HandleId, ConfigRoleInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoById.HandleId, 0, ConfigRoleInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleInfoById.HandleId, ConfigRoleInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleInfo rootAsRoleInfo = RoleInfo.GetRootAsRoleInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleInfoById.HandleId, ConfigRoleInfoById.LogPair);
			return new RoleInfo?(rootAsRoleInfo);
		}

		// Token: 0x04003CBD RID: 15549
		private const string DB = "db_role.db";

		// Token: 0x04003CBE RID: 15550
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003CBF RID: 15551
		private const string TABLE = "RoleInfo";

		// Token: 0x04003CC0 RID: 15552
		private const string COMMAND = "select BinData from `RoleInfo` where Id=?";

		// Token: 0x04003CC1 RID: 15553
		private const string KEY_PREFIX = "RoleInfoById";

		// Token: 0x04003CC2 RID: 15554
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CC3 RID: 15555
		private static int HandleId;
	}
}
