using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029A RID: 666
	public class ConfigExploreRewardByCountry : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FA1 RID: 4001 RVA: 0x000B1DEB File Offset: 0x000AFFEB
		static ConfigExploreRewardByCountry()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRewardByCountry.CreateStaticDefaultValue), new Action(ConfigExploreRewardByCountry.ResetStaticDefaultValue));
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000B1E0C File Offset: 0x000B000C
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

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000B1E8B File Offset: 0x000B008B
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRewardByCountry.LogPair = null;
			ConfigExploreRewardByCountry.HandleId = 0;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000B1E99 File Offset: 0x000B0099
		public static void Init()
		{
			ConfigExploreRewardByCountry.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRewardByCountry.HandleId, "db_explore_progress.db", "select BinData from `ExploreReward` where Country=?");
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000B1EB4 File Offset: 0x000B00B4
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

		// Token: 0x0400121A RID: 4634
		private const string DB = "db_explore_progress.db";

		// Token: 0x0400121B RID: 4635
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400121C RID: 4636
		private const string TABLE = "ExploreReward";

		// Token: 0x0400121D RID: 4637
		private const string COMMAND = "select BinData from `ExploreReward` where Country=?";

		// Token: 0x0400121E RID: 4638
		private const string KEY_PREFIX = "ExploreRewardByCountry";

		// Token: 0x0400121F RID: 4639
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001220 RID: 4640
		private static int HandleId;
	}
}
