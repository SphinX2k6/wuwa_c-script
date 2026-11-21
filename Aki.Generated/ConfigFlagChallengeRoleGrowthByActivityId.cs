using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000313 RID: 787
	public class ConfigFlagChallengeRoleGrowthByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001277 RID: 4727 RVA: 0x000C5694 File Offset: 0x000C3894
		static ConfigFlagChallengeRoleGrowthByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x000C56B4 File Offset: 0x000C38B4
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleGrowth"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=?")
			});
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x000C5733 File Offset: 0x000C3933
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair = null;
			ConfigFlagChallengeRoleGrowthByActivityId.HandleId = 0;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x000C5741 File Offset: 0x000C3941
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=?");
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x000C575C File Offset: 0x000C395C
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeRoleGrowth> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, ConfigFlagChallengeRoleGrowthByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FlagChallengeRoleGrowth> readOnlyList = (IReadOnlyList<FlagChallengeRoleGrowth>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair.Clear();
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, 1, p0ActivityId, ConfigFlagChallengeRoleGrowthByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, ConfigFlagChallengeRoleGrowthByActivityId.LogPair);
				return null;
			}
			List<FlagChallengeRoleGrowth> list = new List<FlagChallengeRoleGrowth>();
			while (ConfigCommon.Step(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, false, ConfigFlagChallengeRoleGrowthByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, 0, ConfigFlagChallengeRoleGrowthByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, ConfigFlagChallengeRoleGrowthByActivityId.LogPair);
					return null;
				}
				FlagChallengeRoleGrowth rootAsFlagChallengeRoleGrowth = FlagChallengeRoleGrowth.GetRootAsFlagChallengeRoleGrowth(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeRoleGrowth);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleGrowthByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, ConfigFlagChallengeRoleGrowthByActivityId.LogPair);
			return list;
		}

		// Token: 0x04001569 RID: 5481
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400156A RID: 5482
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x0400156B RID: 5483
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x0400156C RID: 5484
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where ActivityId=?";

		// Token: 0x0400156D RID: 5485
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthByActivityId";

		// Token: 0x0400156E RID: 5486
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400156F RID: 5487
		private static int HandleId;
	}
}
