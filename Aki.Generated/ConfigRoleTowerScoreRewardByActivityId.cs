using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000907 RID: 2311
	public class ConfigRoleTowerScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600363D RID: 13885 RVA: 0x0018F3CF File Offset: 0x0018D5CF
		static ConfigRoleTowerScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigRoleTowerScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600363E RID: 13886 RVA: 0x0018F3F0 File Offset: 0x0018D5F0
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerScoreRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerScoreReward` where ActivityId=?")
			});
		}

		// Token: 0x0600363F RID: 13887 RVA: 0x0018F46F File Offset: 0x0018D66F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerScoreRewardByActivityId.LogPair = null;
			ConfigRoleTowerScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003640 RID: 13888 RVA: 0x0018F47D File Offset: 0x0018D67D
		public static void Init()
		{
			ConfigRoleTowerScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerScoreRewardByActivityId.HandleId, "db_roletower.db", "select BinData from `RoleTowerScoreReward` where ActivityId=?");
		}

		// Token: 0x06003641 RID: 13889 RVA: 0x0018F498 File Offset: 0x0018D698
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerScoreReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerScoreRewardByActivityId.HandleId, ConfigRoleTowerScoreRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RoleTowerScoreReward> readOnlyList = (IReadOnlyList<RoleTowerScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRoleTowerScoreRewardByActivityId.LogPair.Clear();
			ConfigRoleTowerScoreRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRoleTowerScoreRewardByActivityId.HandleId, 1, p0ActivityId, ConfigRoleTowerScoreRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRoleTowerScoreRewardByActivityId.HandleId, ConfigRoleTowerScoreRewardByActivityId.LogPair);
				return null;
			}
			List<RoleTowerScoreReward> list = new List<RoleTowerScoreReward>();
			while (ConfigCommon.Step(ConfigRoleTowerScoreRewardByActivityId.HandleId, false, ConfigRoleTowerScoreRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerScoreRewardByActivityId.HandleId, 0, ConfigRoleTowerScoreRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerScoreRewardByActivityId.HandleId, ConfigRoleTowerScoreRewardByActivityId.LogPair);
					return null;
				}
				RoleTowerScoreReward rootAsRoleTowerScoreReward = RoleTowerScoreReward.GetRootAsRoleTowerScoreReward(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleTowerScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerScoreRewardByActivityId.HandleId, ConfigRoleTowerScoreRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003F17 RID: 16151
		private const string DB = "db_roletower.db";

		// Token: 0x04003F18 RID: 16152
		private const string FILE = "j.角色爬塔_局外.xlsx";

		// Token: 0x04003F19 RID: 16153
		private const string TABLE = "RoleTowerScoreReward";

		// Token: 0x04003F1A RID: 16154
		private const string COMMAND = "select BinData from `RoleTowerScoreReward` where ActivityId=?";

		// Token: 0x04003F1B RID: 16155
		private const string KEY_PREFIX = "RoleTowerScoreRewardByActivityId";

		// Token: 0x04003F1C RID: 16156
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F1D RID: 16157
		private static int HandleId;
	}
}
