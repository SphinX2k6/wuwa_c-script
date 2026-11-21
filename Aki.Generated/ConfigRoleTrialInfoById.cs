using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091D RID: 2333
	public class ConfigRoleTrialInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036C1 RID: 14017 RVA: 0x001920C4 File Offset: 0x001902C4
		static ConfigRoleTrialInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialInfoById.CreateStaticDefaultValue), new Action(ConfigRoleTrialInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x001920E4 File Offset: 0x001902E4
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

		// Token: 0x060036C3 RID: 14019 RVA: 0x00192163 File Offset: 0x00190363
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialInfoById.LogPair = null;
			ConfigRoleTrialInfoById.HandleId = 0;
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00192171 File Offset: 0x00190371
		public static void Init()
		{
			ConfigRoleTrialInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialInfoById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialInfo` where Id=?");
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x0019218C File Offset: 0x0019038C
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

		// Token: 0x04003FB1 RID: 16305
		private const string DB = "db_roletrial.db";

		// Token: 0x04003FB2 RID: 16306
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003FB3 RID: 16307
		private const string TABLE = "RoleTrialInfo";

		// Token: 0x04003FB4 RID: 16308
		private const string COMMAND = "select BinData from `RoleTrialInfo` where Id=?";

		// Token: 0x04003FB5 RID: 16309
		private const string KEY_PREFIX = "RoleTrialInfoById";

		// Token: 0x04003FB6 RID: 16310
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FB7 RID: 16311
		private static int HandleId;
	}
}
