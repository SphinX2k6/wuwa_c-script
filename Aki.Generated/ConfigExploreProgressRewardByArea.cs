using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000299 RID: 665
	public class ConfigExploreProgressRewardByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F9B RID: 3995 RVA: 0x000B1BB3 File Offset: 0x000AFDB3
		static ConfigExploreProgressRewardByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressRewardByArea.CreateStaticDefaultValue), new Action(ConfigExploreProgressRewardByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000B1BD4 File Offset: 0x000AFDD4
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreProgressRewardByArea.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreProgressRewardByArea.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreProgressReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreProgressReward` where Area=?")
			});
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000B1C53 File Offset: 0x000AFE53
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressRewardByArea.LogPair = null;
			ConfigExploreProgressRewardByArea.HandleId = 0;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x000B1C61 File Offset: 0x000AFE61
		public static void Init()
		{
			ConfigExploreProgressRewardByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressRewardByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgressReward` where Area=?");
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x000B1C7C File Offset: 0x000AFE7C
		[NullableContext(2)]
		public static IReadOnlyList<ExploreProgressReward> GetConfigList(int p0Area, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreProgressRewardByArea.HandleId, ConfigExploreProgressRewardByArea.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressRewardByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				IReadOnlyList<ExploreProgressReward> readOnlyList = (IReadOnlyList<ExploreProgressReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigExploreProgressRewardByArea.LogPair.Clear();
			ConfigExploreProgressRewardByArea.LogPair.Add(new ValueTuple<string, object>("Area", p0Area));
			if (!ConfigCommon.BindInt(ConfigExploreProgressRewardByArea.HandleId, 1, p0Area, ConfigExploreProgressRewardByArea.LogPair))
			{
				ConfigCommon.Reset(ConfigExploreProgressRewardByArea.HandleId, ConfigExploreProgressRewardByArea.LogPair);
				return null;
			}
			List<ExploreProgressReward> list = new List<ExploreProgressReward>();
			while (ConfigCommon.Step(ConfigExploreProgressRewardByArea.HandleId, false, ConfigExploreProgressRewardByArea.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreProgressRewardByArea.HandleId, 0, ConfigExploreProgressRewardByArea.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreProgressRewardByArea.HandleId, ConfigExploreProgressRewardByArea.LogPair);
					return null;
				}
				ExploreProgressReward rootAsExploreProgressReward = ExploreProgressReward.GetRootAsExploreProgressReward(new ByteBuffer(item2));
				list.Add(rootAsExploreProgressReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ExploreProgressRewardByArea");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Area);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreProgressRewardByArea.HandleId, ConfigExploreProgressRewardByArea.LogPair);
			return list;
		}

		// Token: 0x04001213 RID: 4627
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001214 RID: 4628
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x04001215 RID: 4629
		private const string TABLE = "ExploreProgressReward";

		// Token: 0x04001216 RID: 4630
		private const string COMMAND = "select BinData from `ExploreProgressReward` where Area=?";

		// Token: 0x04001217 RID: 4631
		private const string KEY_PREFIX = "ExploreProgressRewardByArea";

		// Token: 0x04001218 RID: 4632
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001219 RID: 4633
		private static int HandleId;
	}
}
