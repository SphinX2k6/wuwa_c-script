using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C4 RID: 1220
	public class ConfigKurotatoQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x000FEC65 File Offset: 0x000FCE65
		static ConfigKurotatoQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoQualityAll.CreateStaticDefaultValue), new Action(ConfigKurotatoQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000FEC84 File Offset: 0x000FCE84
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoQualityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoQualityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_道具.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoQuality`")
			});
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000FED03 File Offset: 0x000FCF03
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoQualityAll.LogPair = null;
			ConfigKurotatoQualityAll.HandleId = 0;
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x000FED11 File Offset: 0x000FCF11
		public static void Init()
		{
			ConfigKurotatoQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoQualityAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoQuality`");
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x000FED2C File Offset: 0x000FCF2C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoQuality> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoQualityAll.HandleId, ConfigKurotatoQualityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoQuality> readOnlyList = (IReadOnlyList<KurotatoQuality>)ConfigCommon.GetConfig("KurotatoQualityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoQuality> list = new List<KurotatoQuality>();
			while (ConfigCommon.Step(ConfigKurotatoQualityAll.HandleId, false, ConfigKurotatoQualityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoQualityAll.HandleId, 0, ConfigKurotatoQualityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoQualityAll.HandleId, ConfigKurotatoQualityAll.LogPair);
					return null;
				}
				KurotatoQuality rootAsKurotatoQuality = KurotatoQuality.GetRootAsKurotatoQuality(new ByteBuffer(item2));
				list.Add(rootAsKurotatoQuality);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoQualityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoQualityAll.HandleId, ConfigKurotatoQualityAll.LogPair);
			return list;
		}

		// Token: 0x04002140 RID: 8512
		private const string DB = "db_kurotato.db";

		// Token: 0x04002141 RID: 8513
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x04002142 RID: 8514
		private const string TABLE = "KurotatoQuality";

		// Token: 0x04002143 RID: 8515
		private const string COMMAND = "select BinData from `KurotatoQuality`";

		// Token: 0x04002144 RID: 8516
		private const string KEY_PREFIX = "KurotatoQualityAll";

		// Token: 0x04002145 RID: 8517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002146 RID: 8518
		private static int HandleId;
	}
}
