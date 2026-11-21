using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A5E RID: 2654
	public class ConfigSpringResourceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E48 RID: 15944 RVA: 0x001BCBFC File Offset: 0x001BADFC
		static ConfigSpringResourceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpringResourceAll.CreateStaticDefaultValue), new Action(ConfigSpringResourceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E49 RID: 15945 RVA: 0x001BCC1C File Offset: 0x001BAE1C
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

		// Token: 0x06003E4A RID: 15946 RVA: 0x001BCC9B File Offset: 0x001BAE9B
		public static void ResetStaticDefaultValue()
		{
			ConfigSpringResourceAll.LogPair = null;
			ConfigSpringResourceAll.HandleId = 0;
		}

		// Token: 0x06003E4B RID: 15947 RVA: 0x001BCCA9 File Offset: 0x001BAEA9
		public static void Init()
		{
			ConfigSpringResourceAll.HandleId = ConfigCommon.InitDataStatement(ConfigSpringResourceAll.HandleId, "db_sprintsign.db", "select BinData from `SpringResource`");
		}

		// Token: 0x06003E4C RID: 15948 RVA: 0x001BCCC4 File Offset: 0x001BAEC4
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

		// Token: 0x04004878 RID: 18552
		private const string DB = "db_sprintsign.db";

		// Token: 0x04004879 RID: 18553
		private const string FILE = "c.2.0春节签到.xlsx";

		// Token: 0x0400487A RID: 18554
		private const string TABLE = "SpringResource";

		// Token: 0x0400487B RID: 18555
		private const string COMMAND = "select BinData from `SpringResource`";

		// Token: 0x0400487C RID: 18556
		private const string KEY_PREFIX = "SpringResourceAll";

		// Token: 0x0400487D RID: 18557
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400487E RID: 18558
		private static int HandleId;
	}
}
