using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001D5 RID: 469
	public class ConfigDangoBrawlBuffAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B01 RID: 2817 RVA: 0x0009B664 File Offset: 0x00099864
		static ConfigDangoBrawlBuffAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlBuffAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlBuffAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x0009B684 File Offset: 0x00099884
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

		// Token: 0x06000B03 RID: 2819 RVA: 0x0009B703 File Offset: 0x00099903
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlBuffAll.LogPair = null;
			ConfigDangoBrawlBuffAll.HandleId = 0;
		}

		// Token: 0x06000B04 RID: 2820 RVA: 0x0009B711 File Offset: 0x00099911
		public static void Init()
		{
			ConfigDangoBrawlBuffAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlBuffAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlBuff`");
		}

		// Token: 0x06000B05 RID: 2821 RVA: 0x0009B72C File Offset: 0x0009992C
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

		// Token: 0x04000CB7 RID: 3255
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CB8 RID: 3256
		private const string FILE = "t.团子乱斗战斗.xlsx";

		// Token: 0x04000CB9 RID: 3257
		private const string TABLE = "DangoBrawlBuff";

		// Token: 0x04000CBA RID: 3258
		private const string COMMAND = "select BinData from `DangoBrawlBuff`";

		// Token: 0x04000CBB RID: 3259
		private const string KEY_PREFIX = "DangoBrawlBuffAll";

		// Token: 0x04000CBC RID: 3260
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000CBD RID: 3261
		private static int HandleId;
	}
}
