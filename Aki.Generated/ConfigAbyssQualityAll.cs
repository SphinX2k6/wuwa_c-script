using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200001B RID: 27
	public class ConfigAbyssQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x0005D82C File Offset: 0x0005BA2C
		static ConfigAbyssQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssQualityAll.CreateStaticDefaultValue), new Action(ConfigAbyssQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0005D84C File Offset: 0x0005BA4C
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssQualityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssQualityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssQuality`")
			});
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0005D8CB File Offset: 0x0005BACB
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssQualityAll.LogPair = null;
			ConfigAbyssQualityAll.HandleId = 0;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0005D8D9 File Offset: 0x0005BAD9
		public static void Init()
		{
			ConfigAbyssQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssQualityAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssQuality`");
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
		[NullableContext(2)]
		public static IReadOnlyList<AbyssQuality> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssQualityAll.HandleId, ConfigAbyssQualityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssQuality> readOnlyList = (IReadOnlyList<AbyssQuality>)ConfigCommon.GetConfig("AbyssQualityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssQuality> list = new List<AbyssQuality>();
			while (ConfigCommon.Step(ConfigAbyssQualityAll.HandleId, false, ConfigAbyssQualityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssQualityAll.HandleId, 0, ConfigAbyssQualityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssQualityAll.HandleId, ConfigAbyssQualityAll.LogPair);
					return null;
				}
				AbyssQuality rootAsAbyssQuality = AbyssQuality.GetRootAsAbyssQuality(new ByteBuffer(item2));
				list.Add(rootAsAbyssQuality);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssQualityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssQualityAll.HandleId, ConfigAbyssQualityAll.LogPair);
			return list;
		}

		// Token: 0x040000A1 RID: 161
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000A2 RID: 162
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000A3 RID: 163
		private const string TABLE = "AbyssQuality";

		// Token: 0x040000A4 RID: 164
		private const string COMMAND = "select BinData from `AbyssQuality`";

		// Token: 0x040000A5 RID: 165
		private const string KEY_PREFIX = "AbyssQualityAll";

		// Token: 0x040000A6 RID: 166
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000A7 RID: 167
		private static int HandleId;
	}
}
