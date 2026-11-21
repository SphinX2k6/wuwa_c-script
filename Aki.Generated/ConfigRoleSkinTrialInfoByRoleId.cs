using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E8 RID: 2280
	public class ConfigRoleSkinTrialInfoByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003583 RID: 13699 RVA: 0x0018B490 File Offset: 0x00189690
		static ConfigRoleSkinTrialInfoByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialInfoByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialInfoByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003584 RID: 13700 RVA: 0x0018B4B0 File Offset: 0x001896B0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinTrialInfoByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleskintrial.db"),
				new ValueTuple<string, object>("文件", "j.角色皮肤试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinTrialInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinTrialInfo` where RoleId=?")
			});
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0018B52F File Offset: 0x0018972F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoByRoleId.LogPair = null;
			ConfigRoleSkinTrialInfoByRoleId.HandleId = 0;
		}

		// Token: 0x06003586 RID: 13702 RVA: 0x0018B53D File Offset: 0x0018973D
		public static void Init()
		{
			ConfigRoleSkinTrialInfoByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialInfoByRoleId.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialInfo` where RoleId=?");
		}

		// Token: 0x06003587 RID: 13703 RVA: 0x0018B558 File Offset: 0x00189758
		public static RoleSkinTrialInfo? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinTrialInfoByRoleId.HandleId, ConfigRoleSkinTrialInfoByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinTrialInfo?(RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(configBuffer));
				}
			}
			ConfigRoleSkinTrialInfoByRoleId.LogPair.Clear();
			ConfigRoleSkinTrialInfoByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleSkinTrialInfoByRoleId.HandleId, 1, p0RoleId, ConfigRoleSkinTrialInfoByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleSkinTrialInfoByRoleId.HandleId, true, ConfigRoleSkinTrialInfoByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoByRoleId.HandleId, ConfigRoleSkinTrialInfoByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinTrialInfoByRoleId.HandleId, 0, ConfigRoleSkinTrialInfoByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoByRoleId.HandleId, ConfigRoleSkinTrialInfoByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinTrialInfo rootAsRoleSkinTrialInfo = RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinTrialInfoByRoleId.HandleId, ConfigRoleSkinTrialInfoByRoleId.LogPair);
			return new RoleSkinTrialInfo?(rootAsRoleSkinTrialInfo);
		}

		// Token: 0x04003E3E RID: 15934
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003E3F RID: 15935
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003E40 RID: 15936
		private const string TABLE = "RoleSkinTrialInfo";

		// Token: 0x04003E41 RID: 15937
		private const string COMMAND = "select BinData from `RoleSkinTrialInfo` where RoleId=?";

		// Token: 0x04003E42 RID: 15938
		private const string KEY_PREFIX = "RoleSkinTrialInfoByRoleId";

		// Token: 0x04003E43 RID: 15939
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E44 RID: 15940
		private static int HandleId;
	}
}
