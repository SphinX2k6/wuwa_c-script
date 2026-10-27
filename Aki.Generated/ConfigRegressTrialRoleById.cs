using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DF RID: 2015
	public class ConfigRegressTrialRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F4C RID: 12108 RVA: 0x0016487B File Offset: 0x00162A7B
		static ConfigRegressTrialRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressTrialRoleById.CreateStaticDefaultValue), new Action(ConfigRegressTrialRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x0016489C File Offset: 0x00162A9C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressTrialRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressTrialRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressTrialRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressTrialRole` where Id=?")
			});
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x0016491B File Offset: 0x00162B1B
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressTrialRoleById.LogPair = null;
			ConfigRegressTrialRoleById.HandleId = 0;
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00164929 File Offset: 0x00162B29
		public static void Init()
		{
			ConfigRegressTrialRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressTrialRoleById.HandleId, "db_regressactivity.db", "select BinData from `RegressTrialRole` where Id=?");
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00164944 File Offset: 0x00162B44
		public static RegressTrialRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressTrialRole?(RegressTrialRole.GetRootAsRegressTrialRole(configBuffer));
				}
			}
			ConfigRegressTrialRoleById.LogPair.Clear();
			ConfigRegressTrialRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressTrialRoleById.HandleId, 1, p0Id, ConfigRegressTrialRoleById.LogPair) || ConfigCommon.Step(ConfigRegressTrialRoleById.HandleId, true, ConfigRegressTrialRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressTrialRoleById.HandleId, 0, ConfigRegressTrialRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressTrialRole rootAsRegressTrialRole = RegressTrialRole.GetRootAsRegressTrialRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressTrialRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressTrialRoleById.HandleId, ConfigRegressTrialRoleById.LogPair);
			return new RegressTrialRole?(rootAsRegressTrialRole);
		}

		// Token: 0x040036FF RID: 14079
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003700 RID: 14080
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003701 RID: 14081
		private const string TABLE = "RegressTrialRole";

		// Token: 0x04003702 RID: 14082
		private const string COMMAND = "select BinData from `RegressTrialRole` where Id=?";

		// Token: 0x04003703 RID: 14083
		private const string KEY_PREFIX = "RegressTrialRoleById";

		// Token: 0x04003704 RID: 14084
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003705 RID: 14085
		private static int HandleId;
	}
}
