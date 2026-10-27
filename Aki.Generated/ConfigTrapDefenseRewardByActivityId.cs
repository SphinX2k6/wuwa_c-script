using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A3D RID: 2621
	public class ConfigTrapDefenseRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D82 RID: 15746 RVA: 0x001B58AC File Offset: 0x001B3AAC
		static ConfigTrapDefenseRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x001B58CC File Offset: 0x001B3ACC
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

		// Token: 0x06003D84 RID: 15748 RVA: 0x001B594B File Offset: 0x001B3B4B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseRewardByActivityId.LogPair = null;
			ConfigTrapDefenseRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x001B5959 File Offset: 0x001B3B59
		public static void Init()
		{
			ConfigTrapDefenseRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseRewardByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseReward` where ActivityId=?");
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x001B5974 File Offset: 0x001B3B74
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

		// Token: 0x04004791 RID: 18321
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004792 RID: 18322
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004793 RID: 18323
		private const string TABLE = "TrapDefenseReward";

		// Token: 0x04004794 RID: 18324
		private const string COMMAND = "select BinData from `TrapDefenseReward` where ActivityId=?";

		// Token: 0x04004795 RID: 18325
		private const string KEY_PREFIX = "TrapDefenseRewardByActivityId";

		// Token: 0x04004796 RID: 18326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004797 RID: 18327
		private static int HandleId;
	}
}
