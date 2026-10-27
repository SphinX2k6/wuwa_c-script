using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000E6 RID: 230
	public class ConfigBattlePassRewardByBattlePassId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x000781FC File Offset: 0x000763FC
		static ConfigBattlePassRewardByBattlePassId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBattlePassRewardByBattlePassId.CreateStaticDefaultValue), new Action(ConfigBattlePassRewardByBattlePassId.ResetStaticDefaultValue));
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0007821C File Offset: 0x0007641C
		public static void CreateStaticDefaultValue()
		{
			ConfigBattlePassRewardByBattlePassId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBattlePassRewardByBattlePassId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_battle_pass.db"),
				new ValueTuple<string, object>("文件", "z.战令.xlsx"),
				new ValueTuple<string, object>("表名", "BattlePassReward"),
				new ValueTuple<string, object>("语句", "select BinData from `BattlePassReward` where BattlePassId=?")
			});
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0007829B File Offset: 0x0007649B
		public static void ResetStaticDefaultValue()
		{
			ConfigBattlePassRewardByBattlePassId.LogPair = null;
			ConfigBattlePassRewardByBattlePassId.HandleId = 0;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000782A9 File Offset: 0x000764A9
		public static void Init()
		{
			ConfigBattlePassRewardByBattlePassId.HandleId = ConfigCommon.InitDataStatement(ConfigBattlePassRewardByBattlePassId.HandleId, "db_battle_pass.db", "select BinData from `BattlePassReward` where BattlePassId=?");
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000782C4 File Offset: 0x000764C4
		[NullableContext(2)]
		public static IReadOnlyList<BattlePassReward> GetConfigList(int p0BattlePassId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassRewardByBattlePassId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BattlePassId);
				IReadOnlyList<BattlePassReward> readOnlyList = (IReadOnlyList<BattlePassReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigBattlePassRewardByBattlePassId.LogPair.Clear();
			ConfigBattlePassRewardByBattlePassId.LogPair.Add(new ValueTuple<string, object>("BattlePassId", p0BattlePassId));
			if (!ConfigCommon.BindInt(ConfigBattlePassRewardByBattlePassId.HandleId, 1, p0BattlePassId, ConfigBattlePassRewardByBattlePassId.LogPair))
			{
				ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
				return null;
			}
			List<BattlePassReward> list = new List<BattlePassReward>();
			while (ConfigCommon.Step(ConfigBattlePassRewardByBattlePassId.HandleId, false, ConfigBattlePassRewardByBattlePassId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBattlePassRewardByBattlePassId.HandleId, 0, ConfigBattlePassRewardByBattlePassId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
					return null;
				}
				BattlePassReward rootAsBattlePassReward = BattlePassReward.GetRootAsBattlePassReward(new ByteBuffer(item2));
				list.Add(rootAsBattlePassReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BattlePassRewardByBattlePassId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0BattlePassId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigBattlePassRewardByBattlePassId.HandleId, ConfigBattlePassRewardByBattlePassId.LogPair);
			return list;
		}

		// Token: 0x0400062E RID: 1582
		private const string DB = "db_battle_pass.db";

		// Token: 0x0400062F RID: 1583
		private const string FILE = "z.战令.xlsx";

		// Token: 0x04000630 RID: 1584
		private const string TABLE = "BattlePassReward";

		// Token: 0x04000631 RID: 1585
		private const string COMMAND = "select BinData from `BattlePassReward` where BattlePassId=?";

		// Token: 0x04000632 RID: 1586
		private const string KEY_PREFIX = "BattlePassRewardByBattlePassId";

		// Token: 0x04000633 RID: 1587
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000634 RID: 1588
		private static int HandleId;
	}
}
