using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000316 RID: 790
	public class ConfigFlagChallengeRoleLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001289 RID: 4745 RVA: 0x000C5DB0 File Offset: 0x000C3FB0
		static ConfigFlagChallengeRoleLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x000C5DD0 File Offset: 0x000C3FD0
		public static void CreateStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlagChallengeRoleLevelByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flagchallenge.db"),
				new ValueTuple<string, object>("文件", "c.插旗活动局内.xlsx"),
				new ValueTuple<string, object>("表名", "FlagChallengeRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `FlagChallengeRoleLevel` where ActivityId=?")
			});
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x000C5E4F File Offset: 0x000C404F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityId.LogPair = null;
			ConfigFlagChallengeRoleLevelByActivityId.HandleId = 0;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x000C5E5D File Offset: 0x000C405D
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where ActivityId=?");
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x000C5E78 File Offset: 0x000C4078
		[NullableContext(2)]
		public static IReadOnlyList<FlagChallengeRoleLevel> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlagChallengeRoleLevelByActivityId.HandleId, ConfigFlagChallengeRoleLevelByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<FlagChallengeRoleLevel> readOnlyList = (IReadOnlyList<FlagChallengeRoleLevel>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigFlagChallengeRoleLevelByActivityId.LogPair.Clear();
			ConfigFlagChallengeRoleLevelByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigFlagChallengeRoleLevelByActivityId.HandleId, 1, p0ActivityId, ConfigFlagChallengeRoleLevelByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityId.HandleId, ConfigFlagChallengeRoleLevelByActivityId.LogPair);
				return null;
			}
			List<FlagChallengeRoleLevel> list = new List<FlagChallengeRoleLevel>();
			while (ConfigCommon.Step(ConfigFlagChallengeRoleLevelByActivityId.HandleId, false, ConfigFlagChallengeRoleLevelByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlagChallengeRoleLevelByActivityId.HandleId, 0, ConfigFlagChallengeRoleLevelByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityId.HandleId, ConfigFlagChallengeRoleLevelByActivityId.LogPair);
					return null;
				}
				FlagChallengeRoleLevel rootAsFlagChallengeRoleLevel = FlagChallengeRoleLevel.GetRootAsFlagChallengeRoleLevel(new ByteBuffer(item2));
				list.Add(rootAsFlagChallengeRoleLevel);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlagChallengeRoleLevelByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigFlagChallengeRoleLevelByActivityId.HandleId, ConfigFlagChallengeRoleLevelByActivityId.LogPair);
			return list;
		}

		// Token: 0x0400157E RID: 5502
		private const string DB = "db_flagchallenge.db";

		// Token: 0x0400157F RID: 5503
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x04001580 RID: 5504
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x04001581 RID: 5505
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where ActivityId=?";

		// Token: 0x04001582 RID: 5506
		private const string KEY_PREFIX = "FlagChallengeRoleLevelByActivityId";

		// Token: 0x04001583 RID: 5507
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001584 RID: 5508
		private static int HandleId;
	}
}
