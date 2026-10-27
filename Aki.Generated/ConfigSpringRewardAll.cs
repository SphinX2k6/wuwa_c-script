using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098C RID: 2444
	public class ConfigSpringRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600395C RID: 14684 RVA: 0x0019DE7B File Offset: 0x0019C07B
		static ConfigSpringRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringRewardAll.CreateStaticDefaultValue), new Action(ConfigSpringRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600395D RID: 14685 RVA: 0x0019DE9C File Offset: 0x0019C09C
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

		// Token: 0x0600395E RID: 14686 RVA: 0x0019DF1B File Offset: 0x0019C11B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringRewardAll.LogPair = null;
			ConfigSpringRewardAll.HandleId = 0;
		}

		// Token: 0x0600395F RID: 14687 RVA: 0x0019DF29 File Offset: 0x0019C129
		public static void Init()
		{
			ConfigSpringRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringRewardAll.HandleId, "db_sprintsign.db", "select BinData from `SpringReward`");
		}

		// Token: 0x06003960 RID: 14688 RVA: 0x0019DF44 File Offset: 0x0019C144
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

		// Token: 0x040042BA RID: 17082
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042BB RID: 17083
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042BC RID: 17084
		private const string TABLE = "SpringReward";

		// Token: 0x040042BD RID: 17085
		private const string COMMAND = "select BinData from `SpringReward`";

		// Token: 0x040042BE RID: 17086
		private const string KEY_PREFIX = "SpringRewardAll";

		// Token: 0x040042BF RID: 17087
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042C0 RID: 17088
		private static int HandleId;
	}
}
