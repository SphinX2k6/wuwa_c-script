using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D3 RID: 467
	public class ConfigDangoBrawlOccupationAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AF5 RID: 2805 RVA: 0x00097828 File Offset: 0x00095A28
		static ConfigDangoBrawlOccupationAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlOccupationAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlOccupationAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00097848 File Offset: 0x00095A48
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

		// Token: 0x06000AF7 RID: 2807 RVA: 0x000978C7 File Offset: 0x00095AC7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlOccupationAll.LogPair = null;
			ConfigDangoBrawlOccupationAll.HandleId = 0;
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x000978D5 File Offset: 0x00095AD5
		public static void Init()
		{
			ConfigDangoBrawlOccupationAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlOccupationAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlOccupation`");
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x000978F0 File Offset: 0x00095AF0
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

		// Token: 0x04000CA9 RID: 3241
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CAA RID: 3242
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CAB RID: 3243
		private const string TABLE = "DangoBrawlOccupation";

		// Token: 0x04000CAC RID: 3244
		private const string COMMAND = "select BinData from `DangoBrawlOccupation`";

		// Token: 0x04000CAD RID: 3245
		private const string KEY_PREFIX = "DangoBrawlOccupationAll";

		// Token: 0x04000CAE RID: 3246
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CAF RID: 3247
		private static int HandleId;
	}
}
