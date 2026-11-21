using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000893 RID: 2195
	public class ConfigRogueWeeklyRewardByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003384 RID: 13188 RVA: 0x00180210 File Offset: 0x0017E410
		static ConfigRogueWeeklyRewardByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeeklyRewardByCycleId.CreateStaticDefaultValue), new Action(ConfigRogueWeeklyRewardByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00180230 File Offset: 0x0017E430
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

		// Token: 0x06003386 RID: 13190 RVA: 0x001802AF File Offset: 0x0017E4AF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeeklyRewardByCycleId.LogPair = null;
			ConfigRogueWeeklyRewardByCycleId.HandleId = 0;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x001802BD File Offset: 0x0017E4BD
		public static void Init()
		{
			ConfigRogueWeeklyRewardByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeeklyRewardByCycleId.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeeklyReward` where CycleId=?");
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x001802D8 File Offset: 0x0017E4D8
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

		// Token: 0x04003BEB RID: 15339
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003BEC RID: 15340
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003BED RID: 15341
		private const string TABLE = "RogueWeeklyReward";

		// Token: 0x04003BEE RID: 15342
		private const string COMMAND = "select BinData from `RogueWeeklyReward` where CycleId=?";

		// Token: 0x04003BEF RID: 15343
		private const string KEY_PREFIX = "RogueWeeklyRewardByCycleId";

		// Token: 0x04003BF0 RID: 15344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BF1 RID: 15345
		private static int HandleId;
	}
}
