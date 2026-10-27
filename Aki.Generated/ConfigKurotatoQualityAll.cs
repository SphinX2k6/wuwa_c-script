using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004AE RID: 1198
	public class ConfigKurotatoQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x000F8511 File Offset: 0x000F6711
		static ConfigKurotatoQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoQualityAll.CreateStaticDefaultValue), new Action(ConfigKurotatoQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000F8530 File Offset: 0x000F6730
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

		// Token: 0x06001C21 RID: 7201 RVA: 0x000F85AF File Offset: 0x000F67AF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoQualityAll.LogPair = null;
			ConfigKurotatoQualityAll.HandleId = 0;
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x000F85BD File Offset: 0x000F67BD
		public static void Init()
		{
			ConfigKurotatoQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoQualityAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoQuality`");
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000F85D8 File Offset: 0x000F67D8
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

		// Token: 0x040020A6 RID: 8358
		private const string DB = "db_kurotato.db";

		// Token: 0x040020A7 RID: 8359
		private const string FILE = "t.土豆兄弟_道具.xlsx";

		// Token: 0x040020A8 RID: 8360
		private const string TABLE = "KurotatoQuality";

		// Token: 0x040020A9 RID: 8361
		private const string COMMAND = "select BinData from `KurotatoQuality`";

		// Token: 0x040020AA RID: 8362
		private const string KEY_PREFIX = "KurotatoQualityAll";

		// Token: 0x040020AB RID: 8363
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020AC RID: 8364
		private static int HandleId;
	}
}
