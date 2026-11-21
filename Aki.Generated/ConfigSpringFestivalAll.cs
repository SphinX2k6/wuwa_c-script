using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A48 RID: 2632
	public class ConfigSpringFestivalAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003DC4 RID: 15812 RVA: 0x001B9CFC File Offset: 0x001B7EFC
		static ConfigSpringFestivalAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringFestivalAll.CreateStaticDefaultValue), new Action(ConfigSpringFestivalAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003DC5 RID: 15813 RVA: 0x001B9D1C File Offset: 0x001B7F1C
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringFestivalAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringFestivalAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_spring26.db"),
				new ValueTuple<string, object>("文件", "c.3.1春节活动外围.xlsx"),
				new ValueTuple<string, object>("表名", "SpringFestival"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringFestival`")
			});
		}

		// Token: 0x06003DC6 RID: 15814 RVA: 0x001B9D9B File Offset: 0x001B7F9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringFestivalAll.LogPair = null;
			ConfigSpringFestivalAll.HandleId = 0;
		}

		// Token: 0x06003DC7 RID: 15815 RVA: 0x001B9DA9 File Offset: 0x001B7FA9
		public static void Init()
		{
			ConfigSpringFestivalAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringFestivalAll.HandleId, "db_spring26.db", "select BinData from `SpringFestival`");
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x001B9DC4 File Offset: 0x001B7FC4
		[NullableContext(2)]
		public static IReadOnlyList<SpringFestival> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringFestival> readOnlyList = (IReadOnlyList<SpringFestival>)ConfigCommon.GetConfig("SpringFestivalAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringFestival> list = new List<SpringFestival>();
			while (ConfigCommon.Step(ConfigSpringFestivalAll.HandleId, false, ConfigSpringFestivalAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringFestivalAll.HandleId, 0, ConfigSpringFestivalAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair);
					return null;
				}
				SpringFestival rootAsSpringFestival = SpringFestival.GetRootAsSpringFestival(new ByteBuffer(item2));
				list.Add(rootAsSpringFestival);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringFestivalAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringFestivalAll.HandleId, ConfigSpringFestivalAll.LogPair);
			return list;
		}

		// Token: 0x040047DE RID: 18398
		private const string DB = "db_spring26.db";

		// Token: 0x040047DF RID: 18399
		private const string FILE = "c.3.1春节活动外围.xlsx";

		// Token: 0x040047E0 RID: 18400
		private const string TABLE = "SpringFestival";

		// Token: 0x040047E1 RID: 18401
		private const string COMMAND = "select BinData from `SpringFestival`";

		// Token: 0x040047E2 RID: 18402
		private const string KEY_PREFIX = "SpringFestivalAll";

		// Token: 0x040047E3 RID: 18403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047E4 RID: 18404
		private static int HandleId;
	}
}
