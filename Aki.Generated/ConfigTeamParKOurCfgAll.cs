using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C3 RID: 2499
	public class ConfigTeamParKOurCfgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AA6 RID: 15014 RVA: 0x001A5774 File Offset: 0x001A3974
		static ConfigTeamParKOurCfgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurCfgAll.CreateStaticDefaultValue), new Action(ConfigTeamParKOurCfgAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x001A5794 File Offset: 0x001A3994
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamParKOurCfgAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamParKOurCfgAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "TeamParKOurCfg"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamParKOurCfg`")
			});
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x001A5813 File Offset: 0x001A3A13
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurCfgAll.LogPair = null;
			ConfigTeamParKOurCfgAll.HandleId = 0;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x001A5821 File Offset: 0x001A3A21
		public static void Init()
		{
			ConfigTeamParKOurCfgAll.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurCfgAll.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurCfg`");
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x001A583C File Offset: 0x001A3A3C
		[NullableContext(2)]
		public static IReadOnlyList<TeamParKOurCfg> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamParKOurCfgAll.HandleId, ConfigTeamParKOurCfgAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TeamParKOurCfg> readOnlyList = (IReadOnlyList<TeamParKOurCfg>)ConfigCommon.GetConfig("TeamParKOurCfgAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TeamParKOurCfg> list = new List<TeamParKOurCfg>();
			while (ConfigCommon.Step(ConfigTeamParKOurCfgAll.HandleId, false, ConfigTeamParKOurCfgAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamParKOurCfgAll.HandleId, 0, ConfigTeamParKOurCfgAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTeamParKOurCfgAll.HandleId, ConfigTeamParKOurCfgAll.LogPair);
					return null;
				}
				TeamParKOurCfg rootAsTeamParKOurCfg = TeamParKOurCfg.GetRootAsTeamParKOurCfg(new ByteBuffer(item2));
				list.Add(rootAsTeamParKOurCfg);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TeamParKOurCfgAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTeamParKOurCfgAll.HandleId, ConfigTeamParKOurCfgAll.LogPair);
			return list;
		}

		// Token: 0x0400443B RID: 17467
		private const string DB = "db_teamparkour.db";

		// Token: 0x0400443C RID: 17468
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x0400443D RID: 17469
		private const string TABLE = "TeamParKOurCfg";

		// Token: 0x0400443E RID: 17470
		private const string COMMAND = "select BinData from `TeamParKOurCfg`";

		// Token: 0x0400443F RID: 17471
		private const string KEY_PREFIX = "TeamParKOurCfgAll";

		// Token: 0x04004440 RID: 17472
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004441 RID: 17473
		private static int HandleId;
	}
}
