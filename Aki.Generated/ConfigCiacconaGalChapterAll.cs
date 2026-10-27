using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000165 RID: 357
	public class ConfigCiacconaGalChapterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600085F RID: 2143 RVA: 0x00088C94 File Offset: 0x00086E94
		static ConfigCiacconaGalChapterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChapterAll.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChapterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00088CB4 File Offset: 0x00086EB4
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

		// Token: 0x06000861 RID: 2145 RVA: 0x00088D33 File Offset: 0x00086F33
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChapterAll.LogPair = null;
			ConfigCiacconaGalChapterAll.HandleId = 0;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00088D41 File Offset: 0x00086F41
		public static void Init()
		{
			ConfigCiacconaGalChapterAll.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChapterAll.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChapter`");
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00088D5C File Offset: 0x00086F5C
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

		// Token: 0x040009A7 RID: 2471
		private const string DB = "db_ciacconagal.db";

		// Token: 0x040009A8 RID: 2472
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x040009A9 RID: 2473
		private const string TABLE = "CiacconaGalChapter";

		// Token: 0x040009AA RID: 2474
		private const string COMMAND = "select BinData from `CiacconaGalChapter`";

		// Token: 0x040009AB RID: 2475
		private const string KEY_PREFIX = "CiacconaGalChapterAll";

		// Token: 0x040009AC RID: 2476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009AD RID: 2477
		private static int HandleId;
	}
}
