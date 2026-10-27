using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FE RID: 766
	public class ConfigFlagChallengeRoleGrowthByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x000BF188 File Offset: 0x000BD388
		static ConfigFlagChallengeRoleGrowthByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleGrowthByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleGrowthByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000BF1A8 File Offset: 0x000BD3A8
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

		// Token: 0x060011FB RID: 4603 RVA: 0x000BF227 File Offset: 0x000BD427
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleGrowthByActivityId.LogPair = null;
			ConfigFlagChallengeRoleGrowthByActivityId.HandleId = 0;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000BF235 File Offset: 0x000BD435
		public static void Init()
		{
			ConfigFlagChallengeRoleGrowthByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleGrowthByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleGrowth` where ActivityId=?");
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000BF250 File Offset: 0x000BD450
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

		// Token: 0x040014D6 RID: 5334
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014D7 RID: 5335
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014D8 RID: 5336
		private const string TABLE = "FlagChallengeRoleGrowth";

		// Token: 0x040014D9 RID: 5337
		private const string COMMAND = "select BinData from `FlagChallengeRoleGrowth` where ActivityId=?";

		// Token: 0x040014DA RID: 5338
		private const string KEY_PREFIX = "FlagChallengeRoleGrowthByActivityId";

		// Token: 0x040014DB RID: 5339
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014DC RID: 5340
		private static int HandleId;
	}
}
