using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CD RID: 2253
	public class ConfigRoleInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034E1 RID: 13537 RVA: 0x0018792C File Offset: 0x00185B2C
		static ConfigRoleInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoById.CreateStaticDefaultValue), new Action(ConfigRoleInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x0018794C File Offset: 0x00185B4C
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

		// Token: 0x060034E3 RID: 13539 RVA: 0x001879CB File Offset: 0x00185BCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoById.LogPair = null;
			ConfigRoleInfoById.HandleId = 0;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x001879D9 File Offset: 0x00185BD9
		public static void Init()
		{
			ConfigRoleInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoById.HandleId, "db_role.db", "select BinData from `RoleInfo` where Id=?");
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x001879F4 File Offset: 0x00185BF4
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

		// Token: 0x04003D81 RID: 15745
		private const string DB = "db_role.db";

		// Token: 0x04003D82 RID: 15746
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D83 RID: 15747
		private const string TABLE = "RoleInfo";

		// Token: 0x04003D84 RID: 15748
		private const string COMMAND = "select BinData from `RoleInfo` where Id=?";

		// Token: 0x04003D85 RID: 15749
		private const string KEY_PREFIX = "RoleInfoById";

		// Token: 0x04003D86 RID: 15750
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D87 RID: 15751
		private static int HandleId;
	}
}
