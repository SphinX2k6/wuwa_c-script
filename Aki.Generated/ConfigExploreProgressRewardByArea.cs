using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AD RID: 685
	public class ConfigExploreProgressRewardByArea : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001013 RID: 4115 RVA: 0x000B7E77 File Offset: 0x000B6077
		static ConfigExploreProgressRewardByArea()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressRewardByArea.CreateStaticDefaultValue), new Action(ConfigExploreProgressRewardByArea.ResetStaticDefaultValue));
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x000B7E98 File Offset: 0x000B6098
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

		// Token: 0x06001015 RID: 4117 RVA: 0x000B7F17 File Offset: 0x000B6117
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressRewardByArea.LogPair = null;
			ConfigExploreProgressRewardByArea.HandleId = 0;
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x000B7F25 File Offset: 0x000B6125
		public static void Init()
		{
			ConfigExploreProgressRewardByArea.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressRewardByArea.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgressReward` where Area=?");
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x000B7F40 File Offset: 0x000B6140
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

		// Token: 0x0400129F RID: 4767
		private const string DB = "db_explore_progress.db";

		// Token: 0x040012A0 RID: 4768
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x040012A1 RID: 4769
		private const string TABLE = "ExploreProgressReward";

		// Token: 0x040012A2 RID: 4770
		private const string COMMAND = "select BinData from `ExploreProgressReward` where Area=?";

		// Token: 0x040012A3 RID: 4771
		private const string KEY_PREFIX = "ExploreProgressRewardByArea";

		// Token: 0x040012A4 RID: 4772
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012A5 RID: 4773
		private static int HandleId;
	}
}
