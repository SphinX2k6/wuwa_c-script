using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000301 RID: 769
	public class ConfigFlagChallengeRoleLevelByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600120B RID: 4619 RVA: 0x000BF8A4 File Offset: 0x000BDAA4
		static ConfigFlagChallengeRoleLevelByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleLevelByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleLevelByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x000BF8C4 File Offset: 0x000BDAC4
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

		// Token: 0x0600120D RID: 4621 RVA: 0x000BF943 File Offset: 0x000BDB43
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleLevelByActivityId.LogPair = null;
			ConfigFlagChallengeRoleLevelByActivityId.HandleId = 0;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x000BF951 File Offset: 0x000BDB51
		public static void Init()
		{
			ConfigFlagChallengeRoleLevelByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleLevelByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleLevel` where ActivityId=?");
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x000BF96C File Offset: 0x000BDB6C
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

		// Token: 0x040014EB RID: 5355
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014EC RID: 5356
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014ED RID: 5357
		private const string TABLE = "FlagChallengeRoleLevel";

		// Token: 0x040014EE RID: 5358
		private const string COMMAND = "select BinData from `FlagChallengeRoleLevel` where ActivityId=?";

		// Token: 0x040014EF RID: 5359
		private const string KEY_PREFIX = "FlagChallengeRoleLevelByActivityId";

		// Token: 0x040014F0 RID: 5360
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014F1 RID: 5361
		private static int HandleId;
	}
}
