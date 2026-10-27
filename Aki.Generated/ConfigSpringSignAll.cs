using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200098D RID: 2445
	public class ConfigSpringSignAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003962 RID: 14690 RVA: 0x0019E00F File Offset: 0x0019C20F
		static ConfigSpringSignAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringSignAll.CreateStaticDefaultValue), new Action(ConfigSpringSignAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x0019E030 File Offset: 0x0019C230
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

		// Token: 0x06003964 RID: 14692 RVA: 0x0019E0AF File Offset: 0x0019C2AF
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringSignAll.LogPair = null;
			ConfigSpringSignAll.HandleId = 0;
		}

		// Token: 0x06003965 RID: 14693 RVA: 0x0019E0BD File Offset: 0x0019C2BD
		public static void Init()
		{
			ConfigSpringSignAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringSignAll.HandleId, "db_sprintsign.db", "select BinData from `SpringSign`");
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0019E0D8 File Offset: 0x0019C2D8
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

		// Token: 0x040042C1 RID: 17089
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042C2 RID: 17090
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042C3 RID: 17091
		private const string TABLE = "SpringSign";

		// Token: 0x040042C4 RID: 17092
		private const string COMMAND = "select BinData from `SpringSign`";

		// Token: 0x040042C5 RID: 17093
		private const string KEY_PREFIX = "SpringSignAll";

		// Token: 0x040042C6 RID: 17094
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042C7 RID: 17095
		private static int HandleId;
	}
}
