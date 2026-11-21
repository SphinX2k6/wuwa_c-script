using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A62 RID: 2658
	public class ConfigSpringSignAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E60 RID: 15968 RVA: 0x001BD3A3 File Offset: 0x001BB5A3
		static ConfigSpringSignAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringSignAll.CreateStaticDefaultValue), new Action(ConfigSpringSignAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x001BD3C4 File Offset: 0x001BB5C4
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringSignAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringSignAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringSign"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringSign`")
			});
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x001BD443 File Offset: 0x001BB643
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringSignAll.LogPair = null;
			ConfigSpringSignAll.HandleId = 0;
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x001BD451 File Offset: 0x001BB651
		public static void Init()
		{
			ConfigSpringSignAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringSignAll.HandleId, "db_sprintsign.db", "select BinData from `SpringSign`");
		}

		// Token: 0x06003E64 RID: 15972 RVA: 0x001BD46C File Offset: 0x001BB66C
		[NullableContext(2)]
		public static IReadOnlyList<SpringSign> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringSignAll.HandleId, ConfigSpringSignAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringSign> readOnlyList = (IReadOnlyList<SpringSign>)ConfigCommon.GetConfig("SpringSignAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringSign> list = new List<SpringSign>();
			while (ConfigCommon.Step(ConfigSpringSignAll.HandleId, false, ConfigSpringSignAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringSignAll.HandleId, 0, ConfigSpringSignAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringSignAll.HandleId, ConfigSpringSignAll.LogPair);
					return null;
				}
				SpringSign rootAsSpringSign = SpringSign.GetRootAsSpringSign(new ByteBuffer(item2));
				list.Add(rootAsSpringSign);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringSignAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringSignAll.HandleId, ConfigSpringSignAll.LogPair);
			return list;
		}

		// Token: 0x04004894 RID: 18580
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004895 RID: 18581
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x04004896 RID: 18582
		private const string TABLE = "SpringSign";

		// Token: 0x04004897 RID: 18583
		private const string COMMAND = "select BinData from `SpringSign`";

		// Token: 0x04004898 RID: 18584
		private const string KEY_PREFIX = "SpringSignAll";

		// Token: 0x04004899 RID: 18585
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400489A RID: 18586
		private static int HandleId;
	}
}
