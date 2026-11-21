using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000D2 RID: 210
	public class ConfigAvoidBlockRewardByRewardGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x0007934C File Offset: 0x0007754C
		static ConfigAvoidBlockRewardByRewardGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockRewardByRewardGroupId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockRewardByRewardGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0007936C File Offset: 0x0007756C
		public static void CreateStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvoidBlockRewardByRewardGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avoidblock.db"),
				new ValueTuple<string, object>("文件", "d.躲避方块.xlsx"),
				new ValueTuple<string, object>("表名", "AvoidBlockReward"),
				new ValueTuple<string, object>("语句", "select BinData from `AvoidBlockReward` where RewardGroupId=?")
			});
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000793EB File Offset: 0x000775EB
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardGroupId.LogPair = null;
			ConfigAvoidBlockRewardByRewardGroupId.HandleId = 0;
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000793F9 File Offset: 0x000775F9
		public static void Init()
		{
			ConfigAvoidBlockRewardByRewardGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockRewardByRewardGroupId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockReward` where RewardGroupId=?");
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00079414 File Offset: 0x00077614
		[NullableContext(2)]
		public static IReadOnlyList<AvoidBlockReward> GetConfigList(int p0RewardGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvoidBlockRewardByRewardGroupId.HandleId, ConfigAvoidBlockRewardByRewardGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockRewardByRewardGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardGroupId);
				IReadOnlyList<AvoidBlockReward> readOnlyList = (IReadOnlyList<AvoidBlockReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigAvoidBlockRewardByRewardGroupId.LogPair.Clear();
			ConfigAvoidBlockRewardByRewardGroupId.LogPair.Add(new ValueTuple<string, object>("RewardGroupId", p0RewardGroupId));
			if (!ConfigCommon.BindInt(ConfigAvoidBlockRewardByRewardGroupId.HandleId, 1, p0RewardGroupId, ConfigAvoidBlockRewardByRewardGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardGroupId.HandleId, ConfigAvoidBlockRewardByRewardGroupId.LogPair);
				return null;
			}
			List<AvoidBlockReward> list = new List<AvoidBlockReward>();
			while (ConfigCommon.Step(ConfigAvoidBlockRewardByRewardGroupId.HandleId, false, ConfigAvoidBlockRewardByRewardGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvoidBlockRewardByRewardGroupId.HandleId, 0, ConfigAvoidBlockRewardByRewardGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardGroupId.HandleId, ConfigAvoidBlockRewardByRewardGroupId.LogPair);
					return null;
				}
				AvoidBlockReward rootAsAvoidBlockReward = AvoidBlockReward.GetRootAsAvoidBlockReward(new ByteBuffer(item2));
				list.Add(rootAsAvoidBlockReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvoidBlockRewardByRewardGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RewardGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigAvoidBlockRewardByRewardGroupId.HandleId, ConfigAvoidBlockRewardByRewardGroupId.LogPair);
			return list;
		}

		// Token: 0x040005A2 RID: 1442
		private const string DB = "db_avoidblock.db";

		// Token: 0x040005A3 RID: 1443
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x040005A4 RID: 1444
		private const string TABLE = "AvoidBlockReward";

		// Token: 0x040005A5 RID: 1445
		private const string COMMAND = "select BinData from `AvoidBlockReward` where RewardGroupId=?";

		// Token: 0x040005A6 RID: 1446
		private const string KEY_PREFIX = "AvoidBlockRewardByRewardGroupId";

		// Token: 0x040005A7 RID: 1447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005A8 RID: 1448
		private static int HandleId;
	}
}
