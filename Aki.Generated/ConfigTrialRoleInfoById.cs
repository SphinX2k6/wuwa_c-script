using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B2A RID: 2858
	public class ConfigTrialRoleInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004310 RID: 17168 RVA: 0x001D820F File Offset: 0x001D640F
		static ConfigTrialRoleInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrialRoleInfoById.CreateStaticDefaultValue), new Action(ConfigTrialRoleInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06004311 RID: 17169 RVA: 0x001D8230 File Offset: 0x001D6430
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

		// Token: 0x06004312 RID: 17170 RVA: 0x001D82AF File Offset: 0x001D64AF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrialRoleInfoById.LogPair = null;
			ConfigTrialRoleInfoById.HandleId = 0;
		}

		// Token: 0x06004313 RID: 17171 RVA: 0x001D82BD File Offset: 0x001D64BD
		public static void Init()
		{
			ConfigTrialRoleInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTrialRoleInfoById.HandleId, "db_trial_role.db", "select BinData from `TrialRoleInfo` where Id = ?");
		}

		// Token: 0x06004314 RID: 17172 RVA: 0x001D82D8 File Offset: 0x001D64D8
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

		// Token: 0x04004E0C RID: 19980
		private const string DB = "db_trial_role.db";

		// Token: 0x04004E0D RID: 19981
		private const string FILE = "s.试用角色.xlsx";

		// Token: 0x04004E0E RID: 19982
		private const string TABLE = "TrialRoleInfo";

		// Token: 0x04004E0F RID: 19983
		private const string COMMAND = "select BinData from `TrialRoleInfo` where Id = ?";

		// Token: 0x04004E10 RID: 19984
		private const string KEY_PREFIX = "TrialRoleInfoById";

		// Token: 0x04004E11 RID: 19985
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E12 RID: 19986
		private static int HandleId;
	}
}
