using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091E RID: 2334
	public class ConfigRoleTrialRoleConfigByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036C7 RID: 14023 RVA: 0x0019230C File Offset: 0x0019050C
		static ConfigRoleTrialRoleConfigByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialRoleConfigByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleTrialRoleConfigByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x0019232C File Offset: 0x0019052C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTrialRoleConfigByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTrialRoleConfigByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletrial.db"),
				new ValueTuple<string, object>("文件", "j.角色试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTrialRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTrialRoleConfig` where RoleId=?")
			});
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x001923AB File Offset: 0x001905AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialRoleConfigByRoleId.LogPair = null;
			ConfigRoleTrialRoleConfigByRoleId.HandleId = 0;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x001923B9 File Offset: 0x001905B9
		public static void Init()
		{
			ConfigRoleTrialRoleConfigByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialRoleConfigByRoleId.HandleId, "db_roletrial.db", "select BinData from `RoleTrialRoleConfig` where RoleId=?");
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x001923D4 File Offset: 0x001905D4
		public static RoleTrialRoleConfig? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTrialRoleConfigByRoleId.HandleId, ConfigRoleTrialRoleConfigByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialRoleConfigByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTrialRoleConfig?(RoleTrialRoleConfig.GetRootAsRoleTrialRoleConfig(configBuffer));
				}
			}
			ConfigRoleTrialRoleConfigByRoleId.LogPair.Clear();
			ConfigRoleTrialRoleConfigByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleTrialRoleConfigByRoleId.HandleId, 1, p0RoleId, ConfigRoleTrialRoleConfigByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleTrialRoleConfigByRoleId.HandleId, true, ConfigRoleTrialRoleConfigByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTrialRoleConfigByRoleId.HandleId, ConfigRoleTrialRoleConfigByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTrialRoleConfigByRoleId.HandleId, 0, ConfigRoleTrialRoleConfigByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTrialRoleConfigByRoleId.HandleId, ConfigRoleTrialRoleConfigByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTrialRoleConfig rootAsRoleTrialRoleConfig = RoleTrialRoleConfig.GetRootAsRoleTrialRoleConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialRoleConfigByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTrialRoleConfigByRoleId.HandleId, ConfigRoleTrialRoleConfigByRoleId.LogPair);
			return new RoleTrialRoleConfig?(rootAsRoleTrialRoleConfig);
		}

		// Token: 0x04003FB8 RID: 16312
		private const string DB = "db_roletrial.db";

		// Token: 0x04003FB9 RID: 16313
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003FBA RID: 16314
		private const string TABLE = "RoleTrialRoleConfig";

		// Token: 0x04003FBB RID: 16315
		private const string COMMAND = "select BinData from `RoleTrialRoleConfig` where RoleId=?";

		// Token: 0x04003FBC RID: 16316
		private const string KEY_PREFIX = "RoleTrialRoleConfigByRoleId";

		// Token: 0x04003FBD RID: 16317
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FBE RID: 16318
		private static int HandleId;
	}
}
