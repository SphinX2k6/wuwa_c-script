using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A55 RID: 2645
	public class ConfigTrialRoleInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E12 RID: 15890 RVA: 0x001B8E7B File Offset: 0x001B707B
		static ConfigTrialRoleInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoById.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x001B8E9C File Offset: 0x001B709C
		public static void CreateStaticDefaultValue()
		{
			ConfigTrialRoleInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrialRoleInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trial_role.db"),
				new ValueTuple<string, object>("文件", "s.试用角色.xlsx"),
				new ValueTuple<string, object>("表名", "TrialRoleInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TrialRoleInfo` where Id = ?")
			});
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x001B8F1B File Offset: 0x001B711B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoById.LogPair = null;
			ConfigTrialRoleInfoById.HandleId = 0;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x001B8F29 File Offset: 0x001B7129
		public static void Init()
		{
			ConfigTrialRoleInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoById.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where Id = ?");
		}

		// Token: 0x06003E16 RID: 15894 RVA: 0x001B8F44 File Offset: 0x001B7144
		public static TrialRoleInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrialRoleInfoById.HandleId, ConfigTrialRoleInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrialRoleInfo?(TrialRoleInfo.GetRootAsTrialRoleInfo(configBuffer));
				}
			}
			ConfigTrialRoleInfoById.LogPair.Clear();
			ConfigTrialRoleInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTrialRoleInfoById.HandleId, 1, p0Id, ConfigTrialRoleInfoById.LogPair) || ConfigCommon.Step(ConfigTrialRoleInfoById.HandleId, true, ConfigTrialRoleInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrialRoleInfoById.HandleId, ConfigTrialRoleInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrialRoleInfoById.HandleId, 0, ConfigTrialRoleInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrialRoleInfoById.HandleId, ConfigTrialRoleInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrialRoleInfo rootAsTrialRoleInfo = TrialRoleInfo.GetRootAsTrialRoleInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrialRoleInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrialRoleInfoById.HandleId, ConfigTrialRoleInfoById.LogPair);
			return new TrialRoleInfo?(rootAsTrialRoleInfo);
		}

		// Token: 0x04004839 RID: 18489
		private const string DB = "db_trial_role.db";

		// Token: 0x0400483A RID: 18490
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x0400483B RID: 18491
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x0400483C RID: 18492
		private const string COMMAND = "select BinData from `TrialRoleInfo` where Id = ?";

		// Token: 0x0400483D RID: 18493
		private const string KEY_PREFIX = "TrialRoleInfoById";

		// Token: 0x0400483E RID: 18494
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400483F RID: 18495
		private static int HandleId;
	}
}
