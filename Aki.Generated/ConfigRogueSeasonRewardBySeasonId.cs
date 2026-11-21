using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000882 RID: 2178
	public class ConfigRogueSeasonRewardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600331E RID: 13086 RVA: 0x0017DEFC File Offset: 0x0017C0FC
		static ConfigRogueSeasonRewardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonRewardBySeasonId.CreateStaticDefaultValue), new Action(ConfigRogueSeasonRewardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x0017DF1C File Offset: 0x0017C11C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueSeasonRewardBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueSeasonRewardBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueSeasonReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueSeasonReward` where SeasonId=?")
			});
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x0017DF9B File Offset: 0x0017C19B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonRewardBySeasonId.LogPair = null;
			ConfigRogueSeasonRewardBySeasonId.HandleId = 0;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x0017DFA9 File Offset: 0x0017C1A9
		public static void Init()
		{
			ConfigRogueSeasonRewardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonRewardBySeasonId.HandleId, "db_rogue.db", "select BinData from `RogueSeasonReward` where SeasonId=?");
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x0017DFC4 File Offset: 0x0017C1C4
		[NullableContext(2)]
		public static IReadOnlyList<RogueSeasonReward> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueSeasonRewardBySeasonId.HandleId, ConfigRogueSeasonRewardBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSeasonRewardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RogueSeasonReward> readOnlyList = (IReadOnlyList<RogueSeasonReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRogueSeasonRewardBySeasonId.LogPair.Clear();
			ConfigRogueSeasonRewardBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRogueSeasonRewardBySeasonId.HandleId, 1, p0SeasonId, ConfigRogueSeasonRewardBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRogueSeasonRewardBySeasonId.HandleId, ConfigRogueSeasonRewardBySeasonId.LogPair);
				return null;
			}
			List<RogueSeasonReward> list = new List<RogueSeasonReward>();
			while (ConfigCommon.Step(ConfigRogueSeasonRewardBySeasonId.HandleId, false, ConfigRogueSeasonRewardBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueSeasonRewardBySeasonId.HandleId, 0, ConfigRogueSeasonRewardBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueSeasonRewardBySeasonId.HandleId, ConfigRogueSeasonRewardBySeasonId.LogPair);
					return null;
				}
				RogueSeasonReward rootAsRogueSeasonReward = RogueSeasonReward.GetRootAsRogueSeasonReward(new ByteBuffer(item2));
				list.Add(rootAsRogueSeasonReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueSeasonRewardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueSeasonRewardBySeasonId.HandleId, ConfigRogueSeasonRewardBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04003B74 RID: 15220
		private const string DB = "db_rogue.db";

		// Token: 0x04003B75 RID: 15221
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003B76 RID: 15222
		private const string TABLE = "RogueSeasonReward";

		// Token: 0x04003B77 RID: 15223
		private const string COMMAND = "select BinData from `RogueSeasonReward` where SeasonId=?";

		// Token: 0x04003B78 RID: 15224
		private const string KEY_PREFIX = "RogueSeasonRewardBySeasonId";

		// Token: 0x04003B79 RID: 15225
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B7A RID: 15226
		private static int HandleId;
	}
}
