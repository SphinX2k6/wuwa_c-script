using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B9 RID: 441
	public class ConfigCoopSpRewardListByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A59 RID: 2649 RVA: 0x00097970 File Offset: 0x00095B70
		static ConfigCoopSpRewardListByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCoopSpRewardListByActivityId.CreateStaticDefaultValue), new Action(ConfigCoopSpRewardListByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06000A5A RID: 2650 RVA: 0x00097990 File Offset: 0x00095B90
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

		// Token: 0x06000A5B RID: 2651 RVA: 0x00097A0F File Offset: 0x00095C0F
		public static void ResetStaticDefaultValue()
		{
			ConfigCoopSpRewardListByActivityId.LogPair = null;
			ConfigCoopSpRewardListByActivityId.HandleId = 0;
		}

		// Token: 0x06000A5C RID: 2652 RVA: 0x00097A1D File Offset: 0x00095C1D
		public static void Init()
		{
			ConfigCoopSpRewardListByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigCoopSpRewardListByActivityId.HandleId, "db_cooprolelevel.db", "select BinData from `CoopSpReward` where ActivityId=?");
		}

		// Token: 0x06000A5D RID: 2653 RVA: 0x00097A38 File Offset: 0x00095C38
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

		// Token: 0x04000BF3 RID: 3059
		private const string DB = "db_cooprolelevel.db";

		// Token: 0x04000BF4 RID: 3060
		private const string FILE = "c.3.2coop活动.xlsx";

		// Token: 0x04000BF5 RID: 3061
		private const string TABLE = "CoopSpReward";

		// Token: 0x04000BF6 RID: 3062
		private const string COMMAND = "select BinData from `CoopSpReward` where ActivityId=?";

		// Token: 0x04000BF7 RID: 3063
		private const string KEY_PREFIX = "CoopSpRewardListByActivityId";

		// Token: 0x04000BF8 RID: 3064
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BF9 RID: 3065
		private static int HandleId;
	}
}
