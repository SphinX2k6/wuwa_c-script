using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AF RID: 687
	public class ConfigExploreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x000B82E7 File Offset: 0x000B64E7
		static ConfigExploreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardById.CreateStaticDefaultValue), new Action(ConfigExploreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000B8308 File Offset: 0x000B6508
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

		// Token: 0x06001021 RID: 4129 RVA: 0x000B8387 File Offset: 0x000B6587
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardById.LogPair = null;
			ConfigExploreRewardById.HandleId = 0;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000B8395 File Offset: 0x000B6595
		public static void Init()
		{
			ConfigExploreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardById.HandleId, "db_explore_progress.db", "select BinData from `ExploreReward` where Id=?");
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000B83B0 File Offset: 0x000B65B0
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

		// Token: 0x040012AD RID: 4781
		private const string DB = "db_explore_progress.db";

		// Token: 0x040012AE RID: 4782
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040012AF RID: 4783
		private const string TABLE = "ExploreReward";

		// Token: 0x040012B0 RID: 4784
		private const string COMMAND = "select BinData from `ExploreReward` where Id=?";

		// Token: 0x040012B1 RID: 4785
		private const string KEY_PREFIX = "ExploreRewardById";

		// Token: 0x040012B2 RID: 4786
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012B3 RID: 4787
		private static int HandleId;
	}
}
