using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008E9 RID: 2281
	public class ConfigRoleSkinTrialUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003589 RID: 13705 RVA: 0x0018B6D8 File Offset: 0x001898D8
		static ConfigRoleSkinTrialUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleSkinTrialUiConfigById.CreateStaticDefaultValue), new Action(ConfigRoleSkinTrialUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600358A RID: 13706 RVA: 0x0018B6F8 File Offset: 0x001898F8
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

		// Token: 0x0600358B RID: 13707 RVA: 0x0018B777 File Offset: 0x00189977
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleSkinTrialUiConfigById.LogPair = null;
			ConfigRoleSkinTrialUiConfigById.HandleId = 0;
		}

		// Token: 0x0600358C RID: 13708 RVA: 0x0018B785 File Offset: 0x00189985
		public static void Init()
		{
			ConfigRoleSkinTrialUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleSkinTrialUiConfigById.HandleId, "db_roleskintrial.db", "select BinData from `RoleSkinTrialUiConfig` where Id=?");
		}

		// Token: 0x0600358D RID: 13709 RVA: 0x0018B7A0 File Offset: 0x001899A0
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

		// Token: 0x04003E45 RID: 15941
		private const string DB = "db_roleskintrial.db";

		// Token: 0x04003E46 RID: 15942
		private const string FILE = "j.角色皮肤试用活动.xlsx";

		// Token: 0x04003E47 RID: 15943
		private const string TABLE = "RoleSkinTrialUiConfig";

		// Token: 0x04003E48 RID: 15944
		private const string COMMAND = "select BinData from `RoleSkinTrialUiConfig` where Id=?";

		// Token: 0x04003E49 RID: 15945
		private const string KEY_PREFIX = "RoleSkinTrialUiConfigById";

		// Token: 0x04003E4A RID: 15946
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003E4B RID: 15947
		private static int HandleId;
	}
}
