using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AE RID: 686
	public class ConfigExploreRewardByCountry : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001019 RID: 4121 RVA: 0x000B80AF File Offset: 0x000B62AF
		static ConfigExploreRewardByCountry()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardByCountry.CreateStaticDefaultValue), new Action(ConfigExploreRewardByCountry.ResetStaticDefaultValue));
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000B80D0 File Offset: 0x000B62D0
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRewardByCountry.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRewardByCountry.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreReward` where Country=?")
			});
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x000B814F File Offset: 0x000B634F
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardByCountry.LogPair = null;
			ConfigExploreRewardByCountry.HandleId = 0;
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x000B815D File Offset: 0x000B635D
		public static void Init()
		{
			ConfigExploreRewardByCountry.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardByCountry.HandleId, "db_explore_progress.db", "select BinData from `ExploreReward` where Country=?");
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000B8178 File Offset: 0x000B6378
		[NullableContext(2)]
		public static IReadOnlyList<ExploreReward> GetConfigList(int p0Country, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRewardByCountry.HandleId, ConfigExploreRewardByCountry.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardByCountry");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Country);
				IReadOnlyList<ExploreReward> readOnlyList = (IReadOnlyList<ExploreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigExploreRewardByCountry.LogPair.Clear();
			ConfigExploreRewardByCountry.LogPair.Add(new ValueTuple<string, object>("Country", p0Country));
			if (!ConfigCommon.BindInt(ConfigExploreRewardByCountry.HandleId, 1, p0Country, ConfigExploreRewardByCountry.LogPair))
			{
				ConfigCommon.Reset(ConfigExploreRewardByCountry.HandleId, ConfigExploreRewardByCountry.LogPair);
				return null;
			}
			List<ExploreReward> list = new List<ExploreReward>();
			while (ConfigCommon.Step(ConfigExploreRewardByCountry.HandleId, false, ConfigExploreRewardByCountry.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRewardByCountry.HandleId, 0, ConfigExploreRewardByCountry.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreRewardByCountry.HandleId, ConfigExploreRewardByCountry.LogPair);
					return null;
				}
				ExploreReward rootAsExploreReward = ExploreReward.GetRootAsExploreReward(new ByteBuffer(item2));
				list.Add(rootAsExploreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreRewardByCountry");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Country);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreRewardByCountry.HandleId, ConfigExploreRewardByCountry.LogPair);
			return list;
		}

		// Token: 0x040012A6 RID: 4774
		private const string DB = "db_explore_progress.db";

		// Token: 0x040012A7 RID: 4775
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040012A8 RID: 4776
		private const string TABLE = "ExploreReward";

		// Token: 0x040012A9 RID: 4777
		private const string COMMAND = "select BinData from `ExploreReward` where Country=?";

		// Token: 0x040012AA RID: 4778
		private const string KEY_PREFIX = "ExploreRewardByCountry";

		// Token: 0x040012AB RID: 4779
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012AC RID: 4780
		private static int HandleId;
	}
}
