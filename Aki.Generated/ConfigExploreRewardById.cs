using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029B RID: 667
	public class ConfigExploreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x000B2023 File Offset: 0x000B0223
		static ConfigExploreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardById.CreateStaticDefaultValue), new Action(ConfigExploreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000B2044 File Offset: 0x000B0244
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreReward` where Id=?")
			});
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000B20C3 File Offset: 0x000B02C3
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardById.LogPair = null;
			ConfigExploreRewardById.HandleId = 0;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000B20D1 File Offset: 0x000B02D1
		public static void Init()
		{
			ConfigExploreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardById.HandleId, "db_explore_progress.db", "select BinData from `ExploreReward` where Id=?");
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000B20EC File Offset: 0x000B02EC
		public static ExploreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRewardById.HandleId, ConfigExploreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ExploreReward?(ExploreReward.GetRootAsExploreReward(configBuffer));
				}
			}
			ConfigExploreRewardById.LogPair.Clear();
			ConfigExploreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigExploreRewardById.HandleId, 1, p0Id, ConfigExploreRewardById.LogPair) || ConfigCommon.Step(ConfigExploreRewardById.HandleId, true, ConfigExploreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigExploreRewardById.HandleId, ConfigExploreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRewardById.HandleId, 0, ConfigExploreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigExploreRewardById.HandleId, ConfigExploreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ExploreReward rootAsExploreReward = ExploreReward.GetRootAsExploreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigExploreRewardById.HandleId, ConfigExploreRewardById.LogPair);
			return new ExploreReward?(rootAsExploreReward);
		}

		// Token: 0x04001221 RID: 4641
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001222 RID: 4642
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001223 RID: 4643
		private const string TABLE = "ExploreReward";

		// Token: 0x04001224 RID: 4644
		private const string COMMAND = "select BinData from `ExploreReward` where Id=?";

		// Token: 0x04001225 RID: 4645
		private const string KEY_PREFIX = "ExploreRewardById";

		// Token: 0x04001226 RID: 4646
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001227 RID: 4647
		private static int HandleId;
	}
}
