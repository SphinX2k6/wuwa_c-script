using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E5 RID: 485
	public class ConfigDangoBrawlOccupationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x0009D760 File Offset: 0x0009B960
		static ConfigDangoBrawlOccupationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0009D780 File Offset: 0x0009B980
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlOccupationAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlOccupation"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlOccupation`")
			});
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0009D7FF File Offset: 0x0009B9FF
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationAll.LogPair = null;
			ConfigDangoBrawlOccupationAll.HandleId = 0;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0009D80D File Offset: 0x0009BA0D
		public static void Init()
		{
			ConfigDangoBrawlOccupationAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupation`");
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0009D828 File Offset: 0x0009BA28
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlOccupation> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlOccupationAll.HandleId, ConfigDangoBrawlOccupationAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlOccupation> readOnlyList = (IReadOnlyList<DangoBrawlOccupation>)ConfigCommon.GetConfig("DangoBrawlOccupationAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlOccupation> list = new List<DangoBrawlOccupation>();
			while (ConfigCommon.Step(ConfigDangoBrawlOccupationAll.HandleId, false, ConfigDangoBrawlOccupationAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlOccupationAll.HandleId, 0, ConfigDangoBrawlOccupationAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlOccupationAll.HandleId, ConfigDangoBrawlOccupationAll.LogPair);
					return null;
				}
				DangoBrawlOccupation rootAsDangoBrawlOccupation = DangoBrawlOccupation.GetRootAsDangoBrawlOccupation(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlOccupation);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlOccupationAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlOccupationAll.HandleId, ConfigDangoBrawlOccupationAll.LogPair);
			return list;
		}

		// Token: 0x04000D27 RID: 3367
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D28 RID: 3368
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D29 RID: 3369
		private const string TABLE = "DangoBrawlOccupation";

		// Token: 0x04000D2A RID: 3370
		private const string COMMAND = "select BinData from `DangoBrawlOccupation`";

		// Token: 0x04000D2B RID: 3371
		private const string KEY_PREFIX = "DangoBrawlOccupationAll";

		// Token: 0x04000D2C RID: 3372
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D2D RID: 3373
		private static int HandleId;
	}
}
