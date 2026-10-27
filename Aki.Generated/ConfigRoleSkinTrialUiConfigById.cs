using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008CD RID: 2253
	public class ConfigRoleSkinTrialUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034E1 RID: 13537 RVA: 0x001843F0 File Offset: 0x001825F0
		static ConfigRoleSkinTrialUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialUiConfigById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060034E2 RID: 13538 RVA: 0x00184410 File Offset: 0x00182610
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleSkinTrialUiConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleSkinTrialUiConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roleskintrial.db"),
				new ValueTuple<string, object>("文件", "j.角色皮肤试用活动.xlsx"),
				new ValueTuple<string, object>("表名", "RoleSkinTrialUiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleSkinTrialUiConfig` where Id=?")
			});
		}

		// Token: 0x060034E3 RID: 13539 RVA: 0x0018448F File Offset: 0x0018268F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialUiConfigById.LogPair = null;
			ConfigRoleSkinTrialUiConfigById.HandleId = 0;
		}

		// Token: 0x060034E4 RID: 13540 RVA: 0x0018449D File Offset: 0x0018269D
		public static void Init()
		{
			ConfigRoleSkinTrialUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialUiConfigById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialUiConfig` where Id=?");
		}

		// Token: 0x060034E5 RID: 13541 RVA: 0x001844B8 File Offset: 0x001826B8
		public static RoleSkinTrialUiConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleSkinTrialUiConfigById.HandleId, ConfigRoleSkinTrialUiConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleSkinTrialUiConfig?(RoleSkinTrialUiConfig.GetRootAsRoleSkinTrialUiConfig(configBuffer));
				}
			}
			ConfigRoleSkinTrialUiConfigById.LogPair.Clear();
			ConfigRoleSkinTrialUiConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoleSkinTrialUiConfigById.HandleId, 1, p0Id, ConfigRoleSkinTrialUiConfigById.LogPair) || ConfigCommon.Step(ConfigRoleSkinTrialUiConfigById.HandleId, true, ConfigRoleSkinTrialUiConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialUiConfigById.HandleId, ConfigRoleSkinTrialUiConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleSkinTrialUiConfigById.HandleId, 0, ConfigRoleSkinTrialUiConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleSkinTrialUiConfigById.HandleId, ConfigRoleSkinTrialUiConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleSkinTrialUiConfig rootAsRoleSkinTrialUiConfig = RoleSkinTrialUiConfig.GetRootAsRoleSkinTrialUiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleSkinTrialUiConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleSkinTrialUiConfigById.HandleId, ConfigRoleSkinTrialUiConfigById.LogPair);
			return new RoleSkinTrialUiConfig?(rootAsRoleSkinTrialUiConfig);
		}

		// Token: 0x04003D81 RID: 15745
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003D82 RID: 15746
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003D83 RID: 15747
		private const string TABLE = "RoleSkinTrialUiConfig";

		// Token: 0x04003D84 RID: 15748
		private const string COMMAND = "select BinData from `RoleSkinTrialUiConfig` where Id=?";

		// Token: 0x04003D85 RID: 15749
		private const string KEY_PREFIX = "RoleSkinTrialUiConfigById";

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
