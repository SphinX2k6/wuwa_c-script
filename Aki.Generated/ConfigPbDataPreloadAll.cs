using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000648 RID: 1608
	public class ConfigPbDataPreloadAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025C0 RID: 9664 RVA: 0x0012F1AD File Offset: 0x0012D3AD
		static ConfigPbDataPreloadAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPbDataPreloadAll.CreateStaticDefaultValue), new Action(ConfigPbDataPreloadAll.ResetStaticDefaultValue));
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0012F1CC File Offset: 0x0012D3CC
		public static void CreateStaticDefaultValue()
		{
			ConfigPbDataPreloadAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPbDataPreloadAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pbdata_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/PbDataPreload.csv"),
				new ValueTuple<string, object>("表名", "PbDataPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `PbDataPreload`")
			});
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x0012F24B File Offset: 0x0012D44B
		public static void ResetStaticDefaultValue()
		{
			ConfigPbDataPreloadAll.LogPair = null;
			ConfigPbDataPreloadAll.HandleId = 0;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x0012F259 File Offset: 0x0012D459
		public static void Init()
		{
			ConfigPbDataPreloadAll.HandleId = ConfigCommon.InitDataStatement(ConfigPbDataPreloadAll.HandleId, "db_pbdata_preload.db", "select BinData from `PbDataPreload`");
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x0012F274 File Offset: 0x0012D474
		[NullableContext(2)]
		public static IReadOnlyList<PbDataPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPbDataPreloadAll.HandleId, ConfigPbDataPreloadAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PbDataPreload> readOnlyList = (IReadOnlyList<PbDataPreload>)ConfigCommon.GetConfig("PbDataPreloadAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PbDataPreload> list = new List<PbDataPreload>();
			while (ConfigCommon.Step(ConfigPbDataPreloadAll.HandleId, false, ConfigPbDataPreloadAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPbDataPreloadAll.HandleId, 0, ConfigPbDataPreloadAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPbDataPreloadAll.HandleId, ConfigPbDataPreloadAll.LogPair);
					return null;
				}
				PbDataPreload rootAsPbDataPreload = PbDataPreload.GetRootAsPbDataPreload(new ByteBuffer(item2));
				list.Add(rootAsPbDataPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PbDataPreloadAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPbDataPreloadAll.HandleId, ConfigPbDataPreloadAll.LogPair);
			return list;
		}

		// Token: 0x04002BDE RID: 11230
		private const string DB = "db_pbdata_preload.db";

		// Token: 0x04002BDF RID: 11231
		private const string FILE = "Preload/PbDataPreload.csv";

		// Token: 0x04002BE0 RID: 11232
		private const string TABLE = "PbDataPreload";

		// Token: 0x04002BE1 RID: 11233
		private const string COMMAND = "select BinData from `PbDataPreload`";

		// Token: 0x04002BE2 RID: 11234
		private const string KEY_PREFIX = "PbDataPreloadAll";

		// Token: 0x04002BE3 RID: 11235
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BE4 RID: 11236
		private static int HandleId;
	}
}
