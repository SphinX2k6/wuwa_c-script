using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9A RID: 2714
	public class ConfigTeamParKOurRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FB0 RID: 16304 RVA: 0x001C4EE4 File Offset: 0x001C30E4
		static ConfigTeamParKOurRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTeamParKOurRewardAll.CreateStaticDefaultValue), new Action(ConfigTeamParKOurRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FB1 RID: 16305 RVA: 0x001C4F04 File Offset: 0x001C3104
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

		// Token: 0x06003FB2 RID: 16306 RVA: 0x001C4F83 File Offset: 0x001C3183
		public static void ResetStaticDefaultValue()
		{
			ConfigTeamParKOurRewardAll.LogPair = null;
			ConfigTeamParKOurRewardAll.HandleId = 0;
		}

		// Token: 0x06003FB3 RID: 16307 RVA: 0x001C4F91 File Offset: 0x001C3191
		public static void Init()
		{
			ConfigTeamParKOurRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigTeamParKOurRewardAll.HandleId, "db_teamparkour.db", "select BinData from `TeamParKOurReward`");
		}

		// Token: 0x06003FB4 RID: 16308 RVA: 0x001C4FAC File Offset: 0x001C31AC
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

		// Token: 0x04004A1C RID: 18972
		private const string DB = "db_teamparkour.db";

		// Token: 0x04004A1D RID: 18973
		private const string FILE = "l.联机跑酷活动.xlsx";

		// Token: 0x04004A1E RID: 18974
		private const string TABLE = "TeamParKOurReward";

		// Token: 0x04004A1F RID: 18975
		private const string COMMAND = "select BinData from `TeamParKOurReward`";

		// Token: 0x04004A20 RID: 18976
		private const string KEY_PREFIX = "TeamParKOurRewardAll";

		// Token: 0x04004A21 RID: 18977
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A22 RID: 18978
		private static int HandleId;
	}
}
