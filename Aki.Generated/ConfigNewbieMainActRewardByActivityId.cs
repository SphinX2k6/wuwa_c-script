using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EA RID: 1514
	public class ConfigNewbieMainActRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600238B RID: 9099 RVA: 0x001227FC File Offset: 0x001209FC
		static ConfigNewbieMainActRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigNewbieMainActRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x0012281C File Offset: 0x00120A1C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActReward"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActReward` where ActivityId=?")
			});
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x0012289B File Offset: 0x00120A9B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActRewardByActivityId.LogPair = null;
			ConfigNewbieMainActRewardByActivityId.HandleId = 0;
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x001228A9 File Offset: 0x00120AA9
		public static void Init()
		{
			ConfigNewbieMainActRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActRewardByActivityId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActReward` where ActivityId=?");
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x001228C4 File Offset: 0x00120AC4
		[NullableContext(2)]
		public static IReadOnlyList<NewbieMainActReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<NewbieMainActReward> readOnlyList = (IReadOnlyList<NewbieMainActReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewbieMainActRewardByActivityId.LogPair.Clear();
			ConfigNewbieMainActRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigNewbieMainActRewardByActivityId.HandleId, 1, p0ActivityId, ConfigNewbieMainActRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
				return null;
			}
			List<NewbieMainActReward> list = new List<NewbieMainActReward>();
			while (ConfigCommon.Step(ConfigNewbieMainActRewardByActivityId.HandleId, false, ConfigNewbieMainActRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActRewardByActivityId.HandleId, 0, ConfigNewbieMainActRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
					return null;
				}
				NewbieMainActReward rootAsNewbieMainActReward = NewbieMainActReward.GetRootAsNewbieMainActReward(new ByteBuffer(item2));
				list.Add(rootAsNewbieMainActReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewbieMainActRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieMainActRewardByActivityId.HandleId, ConfigNewbieMainActRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400294C RID: 10572
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x0400294D RID: 10573
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x0400294E RID: 10574
		private const string TABLE = "NewbieMainActReward";

		// Token: 0x0400294F RID: 10575
		private const string COMMAND = "select BinData from `NewbieMainActReward` where ActivityId=?";

		// Token: 0x04002950 RID: 10576
		private const string KEY_PREFIX = "NewbieMainActRewardByActivityId";

		// Token: 0x04002951 RID: 10577
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002952 RID: 10578
		private static int HandleId;
	}
}
