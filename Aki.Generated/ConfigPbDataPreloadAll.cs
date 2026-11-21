using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000660 RID: 1632
	public class ConfigPbDataPreloadAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002650 RID: 9808 RVA: 0x00135C29 File Offset: 0x00133E29
		static ConfigPbDataPreloadAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPbDataPreloadAll.CreateStaticDefaultValue), new Action(ConfigPbDataPreloadAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00135C48 File Offset: 0x00133E48
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

		// Token: 0x06002652 RID: 9810 RVA: 0x00135CC7 File Offset: 0x00133EC7
		public static void ResetStaticDefaultValue()
		{
			ConfigPbDataPreloadAll.LogPair = null;
			ConfigPbDataPreloadAll.HandleId = 0;
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00135CD5 File Offset: 0x00133ED5
		public static void Init()
		{
			ConfigPbDataPreloadAll.HandleId = ConfigCommon.InitDataStatement(ConfigPbDataPreloadAll.HandleId, "db_pbdata_preload.db", "select BinData from `PbDataPreload`");
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00135CF0 File Offset: 0x00133EF0
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

		// Token: 0x04002C86 RID: 11398
		private const string DB = "db_pbdata_preload.db";

		// Token: 0x04002C87 RID: 11399
		private const string FILE = "Preload/PbDataPreload.csv";

		// Token: 0x04002C88 RID: 11400
		private const string TABLE = "PbDataPreload";

		// Token: 0x04002C89 RID: 11401
		private const string COMMAND = "select BinData from `PbDataPreload`";

		// Token: 0x04002C8A RID: 11402
		private const string KEY_PREFIX = "PbDataPreloadAll";

		// Token: 0x04002C8B RID: 11403
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002C8C RID: 11404
		private static int HandleId;
	}
}
