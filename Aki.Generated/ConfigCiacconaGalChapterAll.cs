using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000175 RID: 373
	public class ConfigCiacconaGalChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008BF RID: 2239 RVA: 0x0008E7F0 File Offset: 0x0008C9F0
		static ConfigCiacconaGalChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChapterAll.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0008E810 File Offset: 0x0008CA10
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalChapterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalChapterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalChapter"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalChapter`")
			});
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0008E88F File Offset: 0x0008CA8F
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChapterAll.LogPair = null;
			ConfigCiacconaGalChapterAll.HandleId = 0;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0008E89D File Offset: 0x0008CA9D
		public static void Init()
		{
			ConfigCiacconaGalChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChapterAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChapter`");
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0008E8B8 File Offset: 0x0008CAB8
		[NullableContext(2)]
		public static IReadOnlyList<CiacconaGalChapter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalChapterAll.HandleId, ConfigCiacconaGalChapterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CiacconaGalChapter> readOnlyList = (IReadOnlyList<CiacconaGalChapter>)ConfigCommon.GetConfig("CiacconaGalChapterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CiacconaGalChapter> list = new List<CiacconaGalChapter>();
			while (ConfigCommon.Step(ConfigCiacconaGalChapterAll.HandleId, false, ConfigCiacconaGalChapterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalChapterAll.HandleId, 0, ConfigCiacconaGalChapterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCiacconaGalChapterAll.HandleId, ConfigCiacconaGalChapterAll.LogPair);
					return null;
				}
				CiacconaGalChapter rootAsCiacconaGalChapter = CiacconaGalChapter.GetRootAsCiacconaGalChapter(new ByteBuffer(item2));
				list.Add(rootAsCiacconaGalChapter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CiacconaGalChapterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCiacconaGalChapterAll.HandleId, ConfigCiacconaGalChapterAll.LogPair);
			return list;
		}

		// Token: 0x04000A17 RID: 2583
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A18 RID: 2584
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A19 RID: 2585
		private const string TABLE = "CiacconaGalChapter";

		// Token: 0x04000A1A RID: 2586
		private const string COMMAND = "select BinData from `CiacconaGalChapter`";

		// Token: 0x04000A1B RID: 2587
		private const string KEY_PREFIX = "CiacconaGalChapterAll";

		// Token: 0x04000A1C RID: 2588
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A1D RID: 2589
		private static int HandleId;
	}
}
