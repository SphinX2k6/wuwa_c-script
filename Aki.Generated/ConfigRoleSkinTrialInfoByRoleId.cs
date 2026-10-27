using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CC RID: 2252
	public class ConfigRoleSkinTrialInfoByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034DB RID: 13531 RVA: 0x001841A8 File Offset: 0x001823A8
		static ConfigRoleSkinTrialInfoByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialInfoByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialInfoByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060034DC RID: 13532 RVA: 0x001841C8 File Offset: 0x001823C8
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

		// Token: 0x060034DD RID: 13533 RVA: 0x00184247 File Offset: 0x00182447
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoByRoleId.LogPair = null;
			ConfigRoleSkinTrialInfoByRoleId.HandleId = 0;
		}

		// Token: 0x060034DE RID: 13534 RVA: 0x00184255 File Offset: 0x00182455
		public static void Init()
		{
			ConfigRoleSkinTrialInfoByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialInfoByRoleId.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialInfo` where RoleId=?");
		}

		// Token: 0x060034DF RID: 13535 RVA: 0x00184270 File Offset: 0x00182470
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

		// Token: 0x04003D7A RID: 15738
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003D7B RID: 15739
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003D7C RID: 15740
		private const string TABLE = "RoleSkinTrialInfo";

		// Token: 0x04003D7D RID: 15741
		private const string COMMAND = "select BinData from `RoleSkinTrialInfo` where RoleId=?";

		// Token: 0x04003D7E RID: 15742
		private const string KEY_PREFIX = "RoleSkinTrialInfoByRoleId";

		// Token: 0x04003D7F RID: 15743
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D80 RID: 15744
		private static int HandleId;
	}
}
