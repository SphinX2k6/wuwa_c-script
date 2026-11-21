using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B12 RID: 2834
	public class ConfigTrapDefenseRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004280 RID: 17024 RVA: 0x001D4C40 File Offset: 0x001D2E40
		static ConfigTrapDefenseRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06004281 RID: 17025 RVA: 0x001D4C60 File Offset: 0x001D2E60
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseReward` where ActivityId=?")
			});
		}

		// Token: 0x06004282 RID: 17026 RVA: 0x001D4CDF File Offset: 0x001D2EDF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByActivityId.LogPair = null;
			ConfigTrapDefenseRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06004283 RID: 17027 RVA: 0x001D4CED File Offset: 0x001D2EED
		public static void Init()
		{
			ConfigTrapDefenseRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where ActivityId=?");
		}

		// Token: 0x06004284 RID: 17028 RVA: 0x001D4D08 File Offset: 0x001D2F08
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseRewardByActivityId.HandleId, ConfigTrapDefenseRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TrapDefenseReward> readOnlyList = (IReadOnlyList<TrapDefenseReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseRewardByActivityId.LogPair.Clear();
			ConfigTrapDefenseRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseRewardByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseRewardByActivityId.HandleId, ConfigTrapDefenseRewardByActivityId.LogPair);
				return null;
			}
			List<TrapDefenseReward> list = new List<TrapDefenseReward>();
			while (ConfigCommon.Step(ConfigTrapDefenseRewardByActivityId.HandleId, false, ConfigTrapDefenseRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseRewardByActivityId.HandleId, 0, ConfigTrapDefenseRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseRewardByActivityId.HandleId, ConfigTrapDefenseRewardByActivityId.LogPair);
					return null;
				}
				TrapDefenseReward rootAsTrapDefenseReward = TrapDefenseReward.GetRootAsTrapDefenseReward(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseRewardByActivityId.HandleId, ConfigTrapDefenseRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004D64 RID: 19812
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D65 RID: 19813
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D66 RID: 19814
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x04004D67 RID: 19815
		private const string COMMAND = "select BinData from `TrapDefenseReward` where ActivityId=?";

		// Token: 0x04004D68 RID: 19816
		private const string KEY_PREFIX = "TrapDefenseRewardByActivityId";

		// Token: 0x04004D69 RID: 19817
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D6A RID: 19818
		private static int HandleId;
	}
}
