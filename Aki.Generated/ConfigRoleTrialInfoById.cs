using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D2 RID: 2258
	public class ConfigRoleTrialInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034FF RID: 13567 RVA: 0x00184EA4 File Offset: 0x001830A4
		static ConfigRoleTrialInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialInfoById.CreateStaticDefaultValue), new Action(ConfigRoleTrialInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00184EC4 File Offset: 0x001830C4
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTrialInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTrialInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletrial.db"),
				new ValueTuple<string, object>("文件", "j.角色试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTrialInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTrialInfo` where Id=?")
			});
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00184F43 File Offset: 0x00183143
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialInfoById.LogPair = null;
			ConfigRoleTrialInfoById.HandleId = 0;
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00184F51 File Offset: 0x00183151
		public static void Init()
		{
			ConfigRoleTrialInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialInfoById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialInfo` where Id=?");
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00184F6C File Offset: 0x0018316C
		public static RoleTrialInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTrialInfoById.HandleId, ConfigRoleTrialInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleTrialInfo?(RoleTrialInfo.GetRootAsRoleTrialInfo(configBuffer));
				}
			}
			ConfigRoleTrialInfoById.LogPair.Clear();
			ConfigRoleTrialInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleTrialInfoById.HandleId, 1, p0Id, ConfigRoleTrialInfoById.LogPair) || ConfigCommon.Step(ConfigRoleTrialInfoById.HandleId, true, ConfigRoleTrialInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleTrialInfoById.HandleId, ConfigRoleTrialInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTrialInfoById.HandleId, 0, ConfigRoleTrialInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleTrialInfoById.HandleId, ConfigRoleTrialInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleTrialInfo rootAsRoleTrialInfo = RoleTrialInfo.GetRootAsRoleTrialInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleTrialInfoById.HandleId, ConfigRoleTrialInfoById.LogPair);
			return new RoleTrialInfo?(rootAsRoleTrialInfo);
		}

		// Token: 0x04003DA4 RID: 15780
		private const string DB = "db_roletrial.db";

		// Token: 0x04003DA5 RID: 15781
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003DA6 RID: 15782
		private const string TABLE = "RoleTrialInfo";

		// Token: 0x04003DA7 RID: 15783
		private const string COMMAND = "select BinData from `RoleTrialInfo` where Id=?";

		// Token: 0x04003DA8 RID: 15784
		private const string KEY_PREFIX = "RoleTrialInfoById";

		// Token: 0x04003DA9 RID: 15785
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DAA RID: 15786
		private static int HandleId;
	}
}
