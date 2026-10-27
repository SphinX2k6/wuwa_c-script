using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C3 RID: 195
	public class ConfigAvoidBlockRewardByRewardGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x000739E8 File Offset: 0x00071BE8
		static ConfigAvoidBlockRewardByRewardGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvoidBlockRewardByRewardGroupId.CreateStaticDefaultValue), new Action(ConfigAvoidBlockRewardByRewardGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00073A08 File Offset: 0x00071C08
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

		// Token: 0x06000495 RID: 1173 RVA: 0x00073A87 File Offset: 0x00071C87
		public static void ResetStaticDefaultValue()
		{
			ConfigAvoidBlockRewardByRewardGroupId.LogPair = null;
			ConfigAvoidBlockRewardByRewardGroupId.HandleId = 0;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00073A95 File Offset: 0x00071C95
		public static void Init()
		{
			ConfigAvoidBlockRewardByRewardGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigAvoidBlockRewardByRewardGroupId.HandleId, "db_avoidblock.db", "select BinData from `AvoidBlockReward` where RewardGroupId=?");
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00073AB0 File Offset: 0x00071CB0
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

		// Token: 0x04000539 RID: 1337
		private const string DB = "db_avoidblock.db";

		// Token: 0x0400053A RID: 1338
		private const string FILE = "d.躲避方块.xlsx";

		// Token: 0x0400053B RID: 1339
		private const string TABLE = "AvoidBlockReward";

		// Token: 0x0400053C RID: 1340
		private const string COMMAND = "select BinData from `AvoidBlockReward` where RewardGroupId=?";

		// Token: 0x0400053D RID: 1341
		private const string KEY_PREFIX = "AvoidBlockRewardByRewardGroupId";

		// Token: 0x0400053E RID: 1342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400053F RID: 1343
		private static int HandleId;
	}
}
