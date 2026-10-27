using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000877 RID: 2167
	public class ConfigRogueWeeklyRewardByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060032DC RID: 13020 RVA: 0x00178F28 File Offset: 0x00177128
		static ConfigRogueWeeklyRewardByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRewardByCycleId.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRewardByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00178F48 File Offset: 0x00177148
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardByCycleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeeklyRewardByCycleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeeklyReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeeklyReward` where CycleId=?")
			});
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00178FC7 File Offset: 0x001771C7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardByCycleId.LogPair = null;
			ConfigRogueWeeklyRewardByCycleId.HandleId = 0;
		}

		// Token: 0x060032DF RID: 13023 RVA: 0x00178FD5 File Offset: 0x001771D5
		public static void Init()
		{
			ConfigRogueWeeklyRewardByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRewardByCycleId.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyReward` where CycleId=?");
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00178FF0 File Offset: 0x001771F0
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeeklyReward> GetConfigList(int p0CycleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeeklyRewardByCycleId.HandleId, ConfigRogueWeeklyRewardByCycleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				IReadOnlyList<RogueWeeklyReward> readOnlyList = (IReadOnlyList<RogueWeeklyReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRogueWeeklyRewardByCycleId.LogPair.Clear();
			ConfigRogueWeeklyRewardByCycleId.LogPair.Add(new ValueTuple<string, object>("CycleId", p0CycleId));
			if (!ConfigCommon.BindInt(ConfigRogueWeeklyRewardByCycleId.HandleId, 1, p0CycleId, ConfigRogueWeeklyRewardByCycleId.LogPair))
			{
				ConfigCommon.Reset(ConfigRogueWeeklyRewardByCycleId.HandleId, ConfigRogueWeeklyRewardByCycleId.LogPair);
				return null;
			}
			List<RogueWeeklyReward> list = new List<RogueWeeklyReward>();
			while (ConfigCommon.Step(ConfigRogueWeeklyRewardByCycleId.HandleId, false, ConfigRogueWeeklyRewardByCycleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeeklyRewardByCycleId.HandleId, 0, ConfigRogueWeeklyRewardByCycleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeeklyRewardByCycleId.HandleId, ConfigRogueWeeklyRewardByCycleId.LogPair);
					return null;
				}
				RogueWeeklyReward rootAsRogueWeeklyReward = RogueWeeklyReward.GetRootAsRogueWeeklyReward(new ByteBuffer(item2));
				list.Add(rootAsRogueWeeklyReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueWeeklyRewardByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeeklyRewardByCycleId.HandleId, ConfigRogueWeeklyRewardByCycleId.LogPair);
			return list;
		}

		// Token: 0x04003B27 RID: 15143
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B28 RID: 15144
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B29 RID: 15145
		private const string TABLE = "RogueWeeklyReward";

		// Token: 0x04003B2A RID: 15146
		private const string COMMAND = "select BinData from `RogueWeeklyReward` where CycleId=?";

		// Token: 0x04003B2B RID: 15147
		private const string KEY_PREFIX = "RogueWeeklyRewardByCycleId";

		// Token: 0x04003B2C RID: 15148
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B2D RID: 15149
		private static int HandleId;
	}
}
