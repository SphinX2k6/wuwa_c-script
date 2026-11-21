using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200091F RID: 2335
	public class ConfigRoleTrialUiConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036CD RID: 14029 RVA: 0x00192554 File Offset: 0x00190754
		static ConfigRoleTrialUiConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTrialUiConfigById.CreateStaticDefaultValue), new Action(ConfigRoleTrialUiConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060036CE RID: 14030 RVA: 0x00192574 File Offset: 0x00190774
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

		// Token: 0x060036CF RID: 14031 RVA: 0x001925F3 File Offset: 0x001907F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTrialUiConfigById.LogPair = null;
			ConfigRoleTrialUiConfigById.HandleId = 0;
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00192601 File Offset: 0x00190801
		public static void Init()
		{
			ConfigRoleTrialUiConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTrialUiConfigById.HandleId, "db_roletrial.db", "select BinData from `RoleTrialUiConfig` where Id=?");
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x0019261C File Offset: 0x0019081C
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

		// Token: 0x04003FBF RID: 16319
		private const string DB = "db_roletrial.db";

		// Token: 0x04003FC0 RID: 16320
		private const string FILE = "j.角色试用活动.xlsx";

		// Token: 0x04003FC1 RID: 16321
		private const string TABLE = "RoleTrialUiConfig";

		// Token: 0x04003FC2 RID: 16322
		private const string COMMAND = "select BinData from `RoleTrialUiConfig` where Id=?";

		// Token: 0x04003FC3 RID: 16323
		private const string KEY_PREFIX = "RoleTrialUiConfigById";

		// Token: 0x04003FC4 RID: 16324
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FC5 RID: 16325
		private static int HandleId;
	}
}
