using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000311 RID: 785
	public class ConfigFlagChallengeRoleBuffByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600126B RID: 4715 RVA: 0x000C5214 File Offset: 0x000C3414
		static ConfigFlagChallengeRoleBuffByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleBuffByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleBuffByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x000C5234 File Offset: 0x000C3434
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleBuffByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleBuff` where ActivityId=?")
			});
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x000C52B3 File Offset: 0x000C34B3
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffByActivityId.LogPair = null;
			ConfigFlagChallengeRoleBuffByActivityId.HandleId = 0;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x000C52C1 File Offset: 0x000C34C1
		public static void Init()
		{
			ConfigFlagChallengeRoleBuffByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleBuffByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleBuff` where ActivityId=?");
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x000C52DC File Offset: 0x000C34DC
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeRoleBuff> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleBuffByActivityId.HandleId, ConfigFlagChallengeRoleBuffByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleBuffByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FlagChallengeRoleBuff> readOnlyList = (IReadOnlyList<FlagChallengeRoleBuff>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlagChallengeRoleBuffByActivityId.LogPair.Clear();
			ConfigFlagChallengeRoleBuffByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleBuffByActivityId.HandleId, 1, p0ActivityId, ConfigFlagChallengeRoleBuffByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleBuffByActivityId.HandleId, ConfigFlagChallengeRoleBuffByActivityId.LogPair);
				return null;
			}
			List<FlagChallengeRoleBuff> list = new List<FlagChallengeRoleBuff>();
			while (ConfigCommon.Step(ConfigFlagChallengeRoleBuffByActivityId.HandleId, false, ConfigFlagChallengeRoleBuffByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleBuffByActivityId.HandleId, 0, ConfigFlagChallengeRoleBuffByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeRoleBuffByActivityId.HandleId, ConfigFlagChallengeRoleBuffByActivityId.LogPair);
					return null;
				}
				FlagChallengeRoleBuff rootAsFlagChallengeRoleBuff = FlagChallengeRoleBuff.GetRootAsFlagChallengeRoleBuff(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeRoleBuff);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleBuffByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleBuffByActivityId.HandleId, ConfigFlagChallengeRoleBuffByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400155B RID: 5467
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400155C RID: 5468
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x0400155D RID: 5469
		private const string TABLE = "FlagChallengeRoleBuff";

		// Token: 0x0400155E RID: 5470
		private const string COMMAND = "select BinData from `FlagChallengeRoleBuff` where ActivityId=?";

		// Token: 0x0400155F RID: 5471
		private const string KEY_PREFIX = "FlagChallengeRoleBuffByActivityId";

		// Token: 0x04001560 RID: 5472
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001561 RID: 5473
		private static int HandleId;
	}
}
