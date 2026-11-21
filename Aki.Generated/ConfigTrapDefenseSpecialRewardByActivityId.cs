using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B17 RID: 2839
	public class ConfigTrapDefenseSpecialRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600429E RID: 17054 RVA: 0x001D5788 File Offset: 0x001D3988
		static ConfigTrapDefenseSpecialRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseSpecialRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseSpecialRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600429F RID: 17055 RVA: 0x001D57A8 File Offset: 0x001D39A8
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseSpecialReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseSpecialReward` where ActivityId=?")
			});
		}

		// Token: 0x060042A0 RID: 17056 RVA: 0x001D5827 File Offset: 0x001D3A27
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair = null;
			ConfigTrapDefenseSpecialRewardByActivityId.HandleId = 0;
		}

		// Token: 0x060042A1 RID: 17057 RVA: 0x001D5835 File Offset: 0x001D3A35
		public static void Init()
		{
			ConfigTrapDefenseSpecialRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseSpecialReward` where ActivityId=?");
		}

		// Token: 0x060042A2 RID: 17058 RVA: 0x001D5850 File Offset: 0x001D3A50
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseSpecialReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<TrapDefenseSpecialReward> readOnlyList = (IReadOnlyList<TrapDefenseSpecialReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.Clear();
			ConfigTrapDefenseSpecialRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, 1, p0ActivityId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
				return null;
			}
			List<TrapDefenseSpecialReward> list = new List<TrapDefenseSpecialReward>();
			while (ConfigCommon.Step(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, false, ConfigTrapDefenseSpecialRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, 0, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
					return null;
				}
				TrapDefenseSpecialReward rootAsTrapDefenseSpecialReward = TrapDefenseSpecialReward.GetRootAsTrapDefenseSpecialReward(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseSpecialReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseSpecialRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseSpecialRewardByActivityId.HandleId, ConfigTrapDefenseSpecialRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004D87 RID: 19847
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004D88 RID: 19848
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004D89 RID: 19849
		private const string TABLE = "TrapDefenseSpecialReward";

		// Token: 0x04004D8A RID: 19850
		private const string COMMAND = "select BinData from `TrapDefenseSpecialReward` where ActivityId=?";

		// Token: 0x04004D8B RID: 19851
		private const string KEY_PREFIX = "TrapDefenseSpecialRewardByActivityId";

		// Token: 0x04004D8C RID: 19852
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004D8D RID: 19853
		private static int HandleId;
	}
}
