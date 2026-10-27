using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A7 RID: 423
	public class ConfigCoopSpRewardListByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x00091A38 File Offset: 0x0008FC38
		static ConfigCoopSpRewardListByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopSpRewardListByActivityId.CreateStaticDefaultValue), new Action(ConfigCoopSpRewardListByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060009EE RID: 2542 RVA: 0x00091A58 File Offset: 0x0008FC58
		public static void CreateStaticDefaultValue()
		{
			ConfigCoopSpRewardListByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCoopSpRewardListByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cooprolelevel.db"),
				new ValueTuple<string, object>("文件", "c.3.2coop活动.xlsx"),
				new ValueTuple<string, object>("表名", "CoopSpReward"),
				new ValueTuple<string, object>("语句", "select BinData from `CoopSpReward` where ActivityId=?")
			});
		}

		// Token: 0x060009EF RID: 2543 RVA: 0x00091AD7 File Offset: 0x0008FCD7
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopSpRewardListByActivityId.LogPair = null;
			ConfigCoopSpRewardListByActivityId.HandleId = 0;
		}

		// Token: 0x060009F0 RID: 2544 RVA: 0x00091AE5 File Offset: 0x0008FCE5
		public static void Init()
		{
			ConfigCoopSpRewardListByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigCoopSpRewardListByActivityId.HandleId, "db_cooprolelevel.db", "select BinData from `CoopSpReward` where ActivityId=?");
		}

		// Token: 0x060009F1 RID: 2545 RVA: 0x00091B00 File Offset: 0x0008FD00
		[NullableContext(2)]
		public static IReadOnlyList<CoopSpReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCoopSpRewardListByActivityId.HandleId, ConfigCoopSpRewardListByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopSpRewardListByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<CoopSpReward> readOnlyList = (IReadOnlyList<CoopSpReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigCoopSpRewardListByActivityId.LogPair.Clear();
			ConfigCoopSpRewardListByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigCoopSpRewardListByActivityId.HandleId, 1, p0ActivityId, ConfigCoopSpRewardListByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigCoopSpRewardListByActivityId.HandleId, ConfigCoopSpRewardListByActivityId.LogPair);
				return null;
			}
			List<CoopSpReward> list = new List<CoopSpReward>();
			while (ConfigCommon.Step(ConfigCoopSpRewardListByActivityId.HandleId, false, ConfigCoopSpRewardListByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCoopSpRewardListByActivityId.HandleId, 0, ConfigCoopSpRewardListByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCoopSpRewardListByActivityId.HandleId, ConfigCoopSpRewardListByActivityId.LogPair);
					return null;
				}
				CoopSpReward rootAsCoopSpReward = CoopSpReward.GetRootAsCoopSpReward(new ByteBuffer(item2));
				list.Add(rootAsCoopSpReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CoopSpRewardListByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigCoopSpRewardListByActivityId.HandleId, ConfigCoopSpRewardListByActivityId.LogPair);
			return list;
		}

		// Token: 0x04000B75 RID: 2933
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000B76 RID: 2934
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000B77 RID: 2935
		private const string TABLE = "CoopSpReward";

		// Token: 0x04000B78 RID: 2936
		private const string COMMAND = "select BinData from `CoopSpReward` where ActivityId=?";

		// Token: 0x04000B79 RID: 2937
		private const string KEY_PREFIX = "CoopSpRewardListByActivityId";

		// Token: 0x04000B7A RID: 2938
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B7B RID: 2939
		private static int HandleId;
	}
}
