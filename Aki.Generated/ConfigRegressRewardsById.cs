using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007DA RID: 2010
	public class ConfigRegressRewardsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F2E RID: 12078 RVA: 0x00163E43 File Offset: 0x00162043
		static ConfigRegressRewardsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressRewardsById.CreateStaticDefaultValue), new Action(ConfigRegressRewardsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x00163E64 File Offset: 0x00162064
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressRewardsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressRewardsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_circumfluence.db"),
				new ValueTuple<string, object>("文件", "h.回流活动.xlsx"),
				new ValueTuple<string, object>("表名", "RegressRewards"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressRewards` where Id=?")
			});
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x00163EE3 File Offset: 0x001620E3
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressRewardsById.LogPair = null;
			ConfigRegressRewardsById.HandleId = 0;
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x00163EF1 File Offset: 0x001620F1
		public static void Init()
		{
			ConfigRegressRewardsById.HandleId = ConfigCommon.InitDataStatement(ConfigRegressRewardsById.HandleId, "db_circumfluence.db", "select BinData from `RegressRewards` where Id=?");
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x00163F0C File Offset: 0x0016210C
		public static RegressRewards? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RegressRewards?(RegressRewards.GetRootAsRegressRewards(configBuffer));
				}
			}
			ConfigRegressRewardsById.LogPair.Clear();
			ConfigRegressRewardsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRegressRewardsById.HandleId, 1, p0Id, ConfigRegressRewardsById.LogPair) || ConfigCommon.Step(ConfigRegressRewardsById.HandleId, true, ConfigRegressRewardsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressRewardsById.HandleId, 0, ConfigRegressRewardsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RegressRewards rootAsRegressRewards = RegressRewards.GetRootAsRegressRewards(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RegressRewardsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRegressRewardsById.HandleId, ConfigRegressRewardsById.LogPair);
			return new RegressRewards?(rootAsRegressRewards);
		}

		// Token: 0x040036DC RID: 14044
		private const string DB = "db_circumfluence.db";

		// Token: 0x040036DD RID: 14045
		private const string FILE = "h.回流活动.xlsx";

		// Token: 0x040036DE RID: 14046
		private const string TABLE = "RegressRewards";

		// Token: 0x040036DF RID: 14047
		private const string COMMAND = "select BinData from `RegressRewards` where Id=?";

		// Token: 0x040036E0 RID: 14048
		private const string KEY_PREFIX = "RegressRewardsById";

		// Token: 0x040036E1 RID: 14049
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040036E2 RID: 14050
		private static int HandleId;
	}
}
