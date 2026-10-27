using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D3 RID: 2259
	public class ConfigRoleTrialRoleConfigByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003505 RID: 13573 RVA: 0x001850EC File Offset: 0x001832EC
		static ConfigRoleTrialRoleConfigByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialRoleConfigByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleTrialRoleConfigByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x0018510C File Offset: 0x0018330C
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

		// Token: 0x06003507 RID: 13575 RVA: 0x0018518B File Offset: 0x0018338B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialRoleConfigByRoleId.LogPair = null;
			ConfigRoleTrialRoleConfigByRoleId.HandleId = 0;
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00185199 File Offset: 0x00183399
		public static void Init()
		{
			ConfigRoleTrialRoleConfigByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialRoleConfigByRoleId.HandleId, "db_roletrial.db", "select BinData from `RoleTrialRoleConfig` where RoleId=?");
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x001851B4 File Offset: 0x001833B4
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

		// Token: 0x04003DAB RID: 15787
		private const string DB = "db_roletrial.db";

		// Token: 0x04003DAC RID: 15788
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003DAD RID: 15789
		private const string TABLE = "RoleTrialRoleConfig";

		// Token: 0x04003DAE RID: 15790
		private const string COMMAND = "select BinData from `RoleTrialRoleConfig` where RoleId=?";

		// Token: 0x04003DAF RID: 15791
		private const string KEY_PREFIX = "RoleTrialRoleConfigByRoleId";

		// Token: 0x04003DB0 RID: 15792
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DB1 RID: 15793
		private static int HandleId;
	}
}
