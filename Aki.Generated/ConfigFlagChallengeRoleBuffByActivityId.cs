using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002FC RID: 764
	public class ConfigFlagChallengeRoleBuffByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060011ED RID: 4589 RVA: 0x000BED08 File Offset: 0x000BCF08
		static ConfigFlagChallengeRoleBuffByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlagChallengeRoleBuffByActivityId.CreateStaticDefaultValue), new Action(ConfigFlagChallengeRoleBuffByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000BED28 File Offset: 0x000BCF28
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

		// Token: 0x060011EF RID: 4591 RVA: 0x000BEDA7 File Offset: 0x000BCFA7
		public static void ResetStaticDefaultValue()
		{
			ConfigFlagChallengeRoleBuffByActivityId.LogPair = null;
			ConfigFlagChallengeRoleBuffByActivityId.HandleId = 0;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000BEDB5 File Offset: 0x000BCFB5
		public static void Init()
		{
			ConfigFlagChallengeRoleBuffByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigFlagChallengeRoleBuffByActivityId.HandleId, "db_flagchallenge.db", "select BinData from `FlagChallengeRoleBuff` where ActivityId=?");
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
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

		// Token: 0x040014C8 RID: 5320
		private const string DB = "db_flagchallenge.db";

		// Token: 0x040014C9 RID: 5321
		private const string FILE = "c.插旗活动局内.xlsx";

		// Token: 0x040014CA RID: 5322
		private const string TABLE = "FlagChallengeRoleBuff";

		// Token: 0x040014CB RID: 5323
		private const string COMMAND = "select BinData from `FlagChallengeRoleBuff` where ActivityId=?";

		// Token: 0x040014CC RID: 5324
		private const string KEY_PREFIX = "FlagChallengeRoleBuffByActivityId";

		// Token: 0x040014CD RID: 5325
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040014CE RID: 5326
		private static int HandleId;
	}
}
