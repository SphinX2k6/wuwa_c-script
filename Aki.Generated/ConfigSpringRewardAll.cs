using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A61 RID: 2657
	public class ConfigSpringRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x001BD20F File Offset: 0x001BB40F
		static ConfigSpringRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringRewardAll.CreateStaticDefaultValue), new Action(ConfigSpringRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x001BD230 File Offset: 0x001BB430
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringReward"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringReward`")
			});
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x001BD2AF File Offset: 0x001BB4AF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringRewardAll.LogPair = null;
			ConfigSpringRewardAll.HandleId = 0;
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x001BD2BD File Offset: 0x001BB4BD
		public static void Init()
		{
			ConfigSpringRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringRewardAll.HandleId, "db_sprintsign.db", "select BinData from `SpringReward`");
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x001BD2D8 File Offset: 0x001BB4D8
		[NullableContext(2)]
		public static IReadOnlyList<SpringReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringRewardAll.HandleId, ConfigSpringRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringReward> readOnlyList = (IReadOnlyList<SpringReward>)ConfigCommon.GetConfig("SpringRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringReward> list = new List<SpringReward>();
			while (ConfigCommon.Step(ConfigSpringRewardAll.HandleId, false, ConfigSpringRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringRewardAll.HandleId, 0, ConfigSpringRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringRewardAll.HandleId, ConfigSpringRewardAll.LogPair);
					return null;
				}
				SpringReward rootAsSpringReward = SpringReward.GetRootAsSpringReward(new ByteBuffer(item2));
				list.Add(rootAsSpringReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringRewardAll.HandleId, ConfigSpringRewardAll.LogPair);
			return list;
		}

		// Token: 0x0400488D RID: 18573
		private const string DB = "db_sprintsign.db";

		// Token: 0x0400488E RID: 18574
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x0400488F RID: 18575
		private const string TABLE = "SpringReward";

		// Token: 0x04004890 RID: 18576
		private const string COMMAND = "select BinData from `SpringReward`";

		// Token: 0x04004891 RID: 18577
		private const string KEY_PREFIX = "SpringRewardAll";

		// Token: 0x04004892 RID: 18578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004893 RID: 18579
		private static int HandleId;
	}
}
