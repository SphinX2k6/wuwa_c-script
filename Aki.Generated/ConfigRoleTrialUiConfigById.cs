using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D4 RID: 2260
	public class ConfigRoleTrialUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600350B RID: 13579 RVA: 0x00185334 File Offset: 0x00183534
		static ConfigRoleTrialUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialUiConfigById.CreateStaticDefaultValue), new Action(ConfigRoleTrialUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00185354 File Offset: 0x00183554
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTrialUiConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTrialUiConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletrial.db"),
				new ValueTuple<string, object>("文件", "j.角色试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTrialUiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTrialUiConfig` where Id=?")
			});
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x001853D3 File Offset: 0x001835D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialUiConfigById.LogPair = null;
			ConfigRoleTrialUiConfigById.HandleId = 0;
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x001853E1 File Offset: 0x001835E1
		public static void Init()
		{
			ConfigRoleTrialUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialUiConfigById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialUiConfig` where Id=?");
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x001853FC File Offset: 0x001835FC
		public static RoleTrialUiConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTrialUiConfigById.HandleId, ConfigRoleTrialUiConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTrialUiConfig?(RoleTrialUiConfig.GetRootAsRoleTrialUiConfig(configBuffer));
				}
			}
			ConfigRoleTrialUiConfigById.LogPair.Clear();
			ConfigRoleTrialUiConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTrialUiConfigById.HandleId, 1, p0Id, ConfigRoleTrialUiConfigById.LogPair) || ConfigCommon.Step(ConfigRoleTrialUiConfigById.HandleId, true, ConfigRoleTrialUiConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTrialUiConfigById.HandleId, ConfigRoleTrialUiConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTrialUiConfigById.HandleId, 0, ConfigRoleTrialUiConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTrialUiConfigById.HandleId, ConfigRoleTrialUiConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTrialUiConfig rootAsRoleTrialUiConfig = RoleTrialUiConfig.GetRootAsRoleTrialUiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTrialUiConfigById.HandleId, ConfigRoleTrialUiConfigById.LogPair);
			return new RoleTrialUiConfig?(rootAsRoleTrialUiConfig);
		}

		// Token: 0x04003DB2 RID: 15794
		private const string DB = "db_roletrial.db";

		// Token: 0x04003DB3 RID: 15795
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003DB4 RID: 15796
		private const string TABLE = "RoleTrialUiConfig";

		// Token: 0x04003DB5 RID: 15797
		private const string COMMAND = "select BinData from `RoleTrialUiConfig` where Id=?";

		// Token: 0x04003DB6 RID: 15798
		private const string KEY_PREFIX = "RoleTrialUiConfigById";

		// Token: 0x04003DB7 RID: 15799
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DB8 RID: 15800
		private static int HandleId;
	}
}
