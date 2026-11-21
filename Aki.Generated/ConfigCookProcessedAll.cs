using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001B2 RID: 434
	public class ConfigCookProcessedAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A2F RID: 2607 RVA: 0x000969E4 File Offset: 0x00094BE4
		static ConfigCookProcessedAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessedAll.CreateStaticDefaultValue), new Action(ConfigCookProcessedAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00096A04 File Offset: 0x00094C04
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessedAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessedAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessed"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessed`")
			});
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00096A83 File Offset: 0x00094C83
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessedAll.LogPair = null;
			ConfigCookProcessedAll.HandleId = 0;
		}

		// Token: 0x06000A32 RID: 2610 RVA: 0x00096A91 File Offset: 0x00094C91
		public static void Init()
		{
			ConfigCookProcessedAll.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessedAll.HandleId, "db_cook.db", "select BinData from `CookProcessed`");
		}

		// Token: 0x06000A33 RID: 2611 RVA: 0x00096AAC File Offset: 0x00094CAC
		[NullableContext(2)]
		public static IReadOnlyList<CookProcessed> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CookProcessed> readOnlyList = (IReadOnlyList<CookProcessed>)ConfigCommon.GetConfig("CookProcessedAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CookProcessed> list = new List<CookProcessed>();
			while (ConfigCommon.Step(ConfigCookProcessedAll.HandleId, false, ConfigCookProcessedAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessedAll.HandleId, 0, ConfigCookProcessedAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair);
					return null;
				}
				CookProcessed rootAsCookProcessed = CookProcessed.GetRootAsCookProcessed(new ByteBuffer(item2));
				list.Add(rootAsCookProcessed);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CookProcessedAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCookProcessedAll.HandleId, ConfigCookProcessedAll.LogPair);
			return list;
		}

		// Token: 0x04000BC2 RID: 3010
		private const string DB = "db_cook.db";

		// Token: 0x04000BC3 RID: 3011
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000BC4 RID: 3012
		private const string TABLE = "CookProcessed";

		// Token: 0x04000BC5 RID: 3013
		private const string COMMAND = "select BinData from `CookProcessed`";

		// Token: 0x04000BC6 RID: 3014
		private const string KEY_PREFIX = "CookProcessedAll";

		// Token: 0x04000BC7 RID: 3015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BC8 RID: 3016
		private static int HandleId;
	}
}
