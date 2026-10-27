using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000866 RID: 2150
	public class ConfigRogueSeasonRewardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003276 RID: 12918 RVA: 0x00176C14 File Offset: 0x00174E14
		static ConfigRogueSeasonRewardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonRewardBySeasonId.CreateStaticDefaultValue), new Action(ConfigRogueSeasonRewardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x00176C34 File Offset: 0x00174E34
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

		// Token: 0x06003278 RID: 12920 RVA: 0x00176CB3 File Offset: 0x00174EB3
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonRewardBySeasonId.LogPair = null;
			ConfigRogueSeasonRewardBySeasonId.HandleId = 0;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x00176CC1 File Offset: 0x00174EC1
		public static void Init()
		{
			ConfigRogueSeasonRewardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonRewardBySeasonId.HandleId, "db_rogue.db", "select BinData from `RogueSeasonReward` where SeasonId=?");
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x00176CDC File Offset: 0x00174EDC
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

		// Token: 0x04003AB0 RID: 15024
		private const string DB = "db_rogue.db";

		// Token: 0x04003AB1 RID: 15025
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AB2 RID: 15026
		private const string TABLE = "RogueSeasonReward";

		// Token: 0x04003AB3 RID: 15027
		private const string COMMAND = "select BinData from `RogueSeasonReward` where SeasonId=?";

		// Token: 0x04003AB4 RID: 15028
		private const string KEY_PREFIX = "RogueSeasonRewardBySeasonId";

		// Token: 0x04003AB5 RID: 15029
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AB6 RID: 15030
		private static int HandleId;
	}
}
