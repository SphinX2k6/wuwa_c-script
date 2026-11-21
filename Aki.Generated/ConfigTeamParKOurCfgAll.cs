using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A98 RID: 2712
	public class ConfigTeamParKOurCfgAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FA4 RID: 16292 RVA: 0x001C4B08 File Offset: 0x001C2D08
		static ConfigTeamParKOurCfgAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurCfgAll.CreateStaticDefaultValue), new Action(ConfigTeamParKOurCfgAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x001C4B28 File Offset: 0x001C2D28
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

		// Token: 0x06003FA6 RID: 16294 RVA: 0x001C4BA7 File Offset: 0x001C2DA7
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurCfgAll.LogPair = null;
			ConfigTeamParKOurCfgAll.HandleId = 0;
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x001C4BB5 File Offset: 0x001C2DB5
		public static void Init()
		{
			ConfigTeamParKOurCfgAll.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurCfgAll.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurCfg`");
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x001C4BD0 File Offset: 0x001C2DD0
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

		// Token: 0x04004A0E RID: 18958
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004A0F RID: 18959
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004A10 RID: 18960
		private const string TABLE = "TeamParKOurCfg";

		// Token: 0x04004A11 RID: 18961
		private const string COMMAND = "select BinData from `TeamParKOurCfg`";

		// Token: 0x04004A12 RID: 18962
		private const string KEY_PREFIX = "TeamParKOurCfgAll";

		// Token: 0x04004A13 RID: 18963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A14 RID: 18964
		private static int HandleId;
	}
}
