using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C5 RID: 2501
	public class ConfigTeamParKOurRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AB2 RID: 15026 RVA: 0x001A5B50 File Offset: 0x001A3D50
		static ConfigTeamParKOurRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurRewardAll.CreateStaticDefaultValue), new Action(ConfigTeamParKOurRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x001A5B70 File Offset: 0x001A3D70
		public static void CreateStaticDefaultValue()
		{
			ConfigTeamParKOurRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTeamParKOurRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_teamparkour.db"),
				new ValueTuple<string, object>("文件", "l.联机跑酷活动.xlsx"),
				new ValueTuple<string, object>("表名", "TeamParKOurReward"),
				new ValueTuple<string, object>("语句", "select BinData from `TeamParKOurReward`")
			});
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x001A5BEF File Offset: 0x001A3DEF
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurRewardAll.LogPair = null;
			ConfigTeamParKOurRewardAll.HandleId = 0;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x001A5BFD File Offset: 0x001A3DFD
		public static void Init()
		{
			ConfigTeamParKOurRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurRewardAll.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurReward`");
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x001A5C18 File Offset: 0x001A3E18
		[NullableContext(2)]
		public static IReadOnlyList<TeamParKOurReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTeamParKOurRewardAll.HandleId, ConfigTeamParKOurRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TeamParKOurReward> readOnlyList = (IReadOnlyList<TeamParKOurReward>)ConfigCommon.GetConfig("TeamParKOurRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TeamParKOurReward> list = new List<TeamParKOurReward>();
			while (ConfigCommon.Step(ConfigTeamParKOurRewardAll.HandleId, false, ConfigTeamParKOurRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTeamParKOurRewardAll.HandleId, 0, ConfigTeamParKOurRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTeamParKOurRewardAll.HandleId, ConfigTeamParKOurRewardAll.LogPair);
					return null;
				}
				TeamParKOurReward rootAsTeamParKOurReward = TeamParKOurReward.GetRootAsTeamParKOurReward(new ByteBuffer(item2));
				list.Add(rootAsTeamParKOurReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TeamParKOurRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTeamParKOurRewardAll.HandleId, ConfigTeamParKOurRewardAll.LogPair);
			return list;
		}

		// Token: 0x04004449 RID: 17481
		private const string DB = "db_teamparkour.db";

		// Token: 0x0400444A RID: 17482
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x0400444B RID: 17483
		private const string TABLE = "TeamParKOurReward";

		// Token: 0x0400444C RID: 17484
		private const string COMMAND = "select BinData from `TeamParKOurReward`";

		// Token: 0x0400444D RID: 17485
		private const string KEY_PREFIX = "TeamParKOurRewardAll";

		// Token: 0x0400444E RID: 17486
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400444F RID: 17487
		private static int HandleId;
	}
}
