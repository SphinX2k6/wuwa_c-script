using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CB RID: 2251
	public class ConfigRoleSkinTrialInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034D5 RID: 13525 RVA: 0x00183F60 File Offset: 0x00182160
		static ConfigRoleSkinTrialInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialInfoById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060034D6 RID: 13526 RVA: 0x00183F80 File Offset: 0x00182180
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinTrialInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleskintrial.db"),
				new ValueTuple<string, object>("文件", "j.角色皮肤试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinTrialInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinTrialInfo` where Id=?")
			});
		}

		// Token: 0x060034D7 RID: 13527 RVA: 0x00183FFF File Offset: 0x001821FF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialInfoById.LogPair = null;
			ConfigRoleSkinTrialInfoById.HandleId = 0;
		}

		// Token: 0x060034D8 RID: 13528 RVA: 0x0018400D File Offset: 0x0018220D
		public static void Init()
		{
			ConfigRoleSkinTrialInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialInfoById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialInfo` where Id=?");
		}

		// Token: 0x060034D9 RID: 13529 RVA: 0x00184028 File Offset: 0x00182228
		public static RoleSkinTrialInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinTrialInfo?(RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(configBuffer));
				}
			}
			ConfigRoleSkinTrialInfoById.LogPair.Clear();
			ConfigRoleSkinTrialInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinTrialInfoById.HandleId, 1, p0Id, ConfigRoleSkinTrialInfoById.LogPair) || ConfigCommon.Step(ConfigRoleSkinTrialInfoById.HandleId, true, ConfigRoleSkinTrialInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinTrialInfoById.HandleId, 0, ConfigRoleSkinTrialInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinTrialInfo rootAsRoleSkinTrialInfo = RoleSkinTrialInfo.GetRootAsRoleSkinTrialInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinTrialInfoById.HandleId, ConfigRoleSkinTrialInfoById.LogPair);
			return new RoleSkinTrialInfo?(rootAsRoleSkinTrialInfo);
		}

		// Token: 0x04003D73 RID: 15731
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003D74 RID: 15732
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003D75 RID: 15733
		private const string TABLE = "RoleSkinTrialInfo";

		// Token: 0x04003D76 RID: 15734
		private const string COMMAND = "select BinData from `RoleSkinTrialInfo` where Id=?";

		// Token: 0x04003D77 RID: 15735
		private const string KEY_PREFIX = "RoleSkinTrialInfoById";

		// Token: 0x04003D78 RID: 15736
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D79 RID: 15737
		private static int HandleId;
	}
}
