using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B8 RID: 1208
	public class ConfigKurotatoTagAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C5B RID: 7259 RVA: 0x000F9910 File Offset: 0x000F7B10
		static ConfigKurotatoTagAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoTagAll.CreateStaticDefaultValue), new Action(ConfigKurotatoTagAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C5C RID: 7260 RVA: 0x000F9930 File Offset: 0x000F7B30
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoTagAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoTagAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_标签.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoTag"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoTag`")
			});
		}

		// Token: 0x06001C5D RID: 7261 RVA: 0x000F99AF File Offset: 0x000F7BAF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoTagAll.LogPair = null;
			ConfigKurotatoTagAll.HandleId = 0;
		}

		// Token: 0x06001C5E RID: 7262 RVA: 0x000F99BD File Offset: 0x000F7BBD
		public static void Init()
		{
			ConfigKurotatoTagAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoTagAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoTag`");
		}

		// Token: 0x06001C5F RID: 7263 RVA: 0x000F99D8 File Offset: 0x000F7BD8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoTag> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoTag> readOnlyList = (IReadOnlyList<KurotatoTag>)ConfigCommon.GetConfig("KurotatoTagAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoTag> list = new List<KurotatoTag>();
			while (ConfigCommon.Step(ConfigKurotatoTagAll.HandleId, false, ConfigKurotatoTagAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoTagAll.HandleId, 0, ConfigKurotatoTagAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair);
					return null;
				}
				KurotatoTag rootAsKurotatoTag = KurotatoTag.GetRootAsKurotatoTag(new ByteBuffer(item2));
				list.Add(rootAsKurotatoTag);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoTagAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoTagAll.HandleId, ConfigKurotatoTagAll.LogPair);
			return list;
		}

		// Token: 0x040020EC RID: 8428
		private const string DB = "db_kurotato.db";

		// Token: 0x040020ED RID: 8429
		private const string FILE = "t.土豆兄弟_标签.xlsx";

		// Token: 0x040020EE RID: 8430
		private const string TABLE = "KurotatoTag";

		// Token: 0x040020EF RID: 8431
		private const string COMMAND = "select BinData from `KurotatoTag`";

		// Token: 0x040020F0 RID: 8432
		private const string KEY_PREFIX = "KurotatoTagAll";

		// Token: 0x040020F1 RID: 8433
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020F2 RID: 8434
		private static int HandleId;
	}
}
