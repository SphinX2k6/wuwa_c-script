using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A97 RID: 2711
	public class ConfigTeamConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F9E RID: 16286 RVA: 0x001C48C0 File Offset: 0x001C2AC0
		static ConfigTeamConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamConfigById.CreateStaticDefaultValue), new Action(ConfigTeamConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x001C48E0 File Offset: 0x001C2AE0
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamconfig.db"),
				new ValueTuple<string, object>("文件", "z.组队配置.xlsx"),
				new ValueTuple<string, object>("表名", "TeamConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamConfig` where Id = ?")
			});
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x001C495F File Offset: 0x001C2B5F
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamConfigById.LogPair = null;
			ConfigTeamConfigById.HandleId = 0;
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x001C496D File Offset: 0x001C2B6D
		public static void Init()
		{
			ConfigTeamConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigTeamConfigById.HandleId, "db_teamconfig.db", "select BinData from `TeamConfig` where Id = ?");
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x001C4988 File Offset: 0x001C2B88
		public static TeamConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TeamConfig?(TeamConfig.GetRootAsTeamConfig(configBuffer));
				}
			}
			ConfigTeamConfigById.LogPair.Clear();
			ConfigTeamConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTeamConfigById.HandleId, 1, p0Id, ConfigTeamConfigById.LogPair) || ConfigCommon.Step(ConfigTeamConfigById.HandleId, true, ConfigTeamConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamConfigById.HandleId, 0, ConfigTeamConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TeamConfig rootAsTeamConfig = TeamConfig.GetRootAsTeamConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TeamConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTeamConfigById.HandleId, ConfigTeamConfigById.LogPair);
			return new TeamConfig?(rootAsTeamConfig);
		}

		// Token: 0x04004A07 RID: 18951
		private const string DB = "db_teamconfig.db";

		// Token: 0x04004A08 RID: 18952
		private const string FILE = "z.组队配置.xlsx";

		// Token: 0x04004A09 RID: 18953
		private const string TABLE = "TeamConfig";

		// Token: 0x04004A0A RID: 18954
		private const string COMMAND = "select BinData from `TeamConfig` where Id = ?";

		// Token: 0x04004A0B RID: 18955
		private const string KEY_PREFIX = "TeamConfigById";

		// Token: 0x04004A0C RID: 18956
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A0D RID: 18957
		private static int HandleId;
	}
}
