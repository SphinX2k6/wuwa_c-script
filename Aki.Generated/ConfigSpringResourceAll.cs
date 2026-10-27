using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000989 RID: 2441
	public class ConfigSpringResourceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600394A RID: 14666 RVA: 0x0019D868 File Offset: 0x0019BA68
		static ConfigSpringResourceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceAll.CreateStaticDefaultValue), new Action(ConfigSpringResourceAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x0019D888 File Offset: 0x0019BA88
		public static void CreateStaticDefaultValue()
		{
			ConfigSpringResourceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpringResourceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sprintsign.db"),
				new ValueTuple<string, object>("文件", "c.2.0春节签到.xlsx"),
				new ValueTuple<string, object>("表名", "SpringResource"),
				new ValueTuple<string, object>("语句", "select BinData from `SpringResource`")
			});
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x0019D907 File Offset: 0x0019BB07
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceAll.LogPair = null;
			ConfigSpringResourceAll.HandleId = 0;
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0019D915 File Offset: 0x0019BB15
		public static void Init()
		{
			ConfigSpringResourceAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceAll.HandleId, "db_sprintsign.db", "select BinData from `SpringResource`");
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x0019D930 File Offset: 0x0019BB30
		[NullableContext(2)]
		public static IReadOnlyList<SpringResource> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSpringResourceAll.HandleId, ConfigSpringResourceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SpringResource> readOnlyList = (IReadOnlyList<SpringResource>)ConfigCommon.GetConfig("SpringResourceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SpringResource> list = new List<SpringResource>();
			while (ConfigCommon.Step(ConfigSpringResourceAll.HandleId, false, ConfigSpringResourceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSpringResourceAll.HandleId, 0, ConfigSpringResourceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSpringResourceAll.HandleId, ConfigSpringResourceAll.LogPair);
					return null;
				}
				SpringResource rootAsSpringResource = SpringResource.GetRootAsSpringResource(new ByteBuffer(item2));
				list.Add(rootAsSpringResource);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SpringResourceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSpringResourceAll.HandleId, ConfigSpringResourceAll.LogPair);
			return list;
		}

		// Token: 0x040042A5 RID: 17061
		private const string DB = "db_sprintsign.db";

		// Token: 0x040042A6 RID: 17062
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x040042A7 RID: 17063
		private const string TABLE = "SpringResource";

		// Token: 0x040042A8 RID: 17064
		private const string COMMAND = "select BinData from `SpringResource`";

		// Token: 0x040042A9 RID: 17065
		private const string KEY_PREFIX = "SpringResourceAll";

		// Token: 0x040042AA RID: 17066
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042AB RID: 17067
		private static int HandleId;
	}
}
