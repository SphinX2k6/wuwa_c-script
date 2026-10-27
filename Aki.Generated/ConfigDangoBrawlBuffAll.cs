using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001C3 RID: 451
	public class ConfigDangoBrawlBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A95 RID: 2709 RVA: 0x0009572C File Offset: 0x0009392C
		static ConfigDangoBrawlBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlBuffAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0009574C File Offset: 0x0009394C
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlBuffAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlBuffAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗战斗.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlBuff"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlBuff`")
			});
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000957CB File Offset: 0x000939CB
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlBuffAll.LogPair = null;
			ConfigDangoBrawlBuffAll.HandleId = 0;
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x000957D9 File Offset: 0x000939D9
		public static void Init()
		{
			ConfigDangoBrawlBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlBuffAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlBuff`");
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x000957F4 File Offset: 0x000939F4
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlBuff> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlBuffAll.HandleId, ConfigDangoBrawlBuffAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlBuff> readOnlyList = (IReadOnlyList<DangoBrawlBuff>)ConfigCommon.GetConfig("DangoBrawlBuffAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlBuff> list = new List<DangoBrawlBuff>();
			while (ConfigCommon.Step(ConfigDangoBrawlBuffAll.HandleId, false, ConfigDangoBrawlBuffAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlBuffAll.HandleId, 0, ConfigDangoBrawlBuffAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlBuffAll.HandleId, ConfigDangoBrawlBuffAll.LogPair);
					return null;
				}
				DangoBrawlBuff rootAsDangoBrawlBuff = DangoBrawlBuff.GetRootAsDangoBrawlBuff(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlBuff);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlBuffAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlBuffAll.HandleId, ConfigDangoBrawlBuffAll.LogPair);
			return list;
		}

		// Token: 0x04000C39 RID: 3129
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C3A RID: 3130
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000C3B RID: 3131
		private const string TABLE = "DangoBrawlBuff";

		// Token: 0x04000C3C RID: 3132
		private const string COMMAND = "select BinData from `DangoBrawlBuff`";

		// Token: 0x04000C3D RID: 3133
		private const string KEY_PREFIX = "DangoBrawlBuffAll";

		// Token: 0x04000C3E RID: 3134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C3F RID: 3135
		private static int HandleId;
	}
}
