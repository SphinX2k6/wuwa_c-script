using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004CA RID: 1226
	public class ConfigKurotatoScoreAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CC7 RID: 7367 RVA: 0x000FF7F8 File Offset: 0x000FD9F8
		static ConfigKurotatoScoreAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoScoreAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoScoreAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000FF818 File Offset: 0x000FDA18
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoScoreAwardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoScoreAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoScoreAward`")
			});
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000FF897 File Offset: 0x000FDA97
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardAll.LogPair = null;
			ConfigKurotatoScoreAwardAll.HandleId = 0;
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x000FF8A5 File Offset: 0x000FDAA5
		public static void Init()
		{
			ConfigKurotatoScoreAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoScoreAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoScoreAward`");
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x000FF8C0 File Offset: 0x000FDAC0
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoScoreAward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoScoreAwardAll.HandleId, ConfigKurotatoScoreAwardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoScoreAward> readOnlyList = (IReadOnlyList<KurotatoScoreAward>)ConfigCommon.GetConfig("KurotatoScoreAwardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoScoreAward> list = new List<KurotatoScoreAward>();
			while (ConfigCommon.Step(ConfigKurotatoScoreAwardAll.HandleId, false, ConfigKurotatoScoreAwardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoScoreAwardAll.HandleId, 0, ConfigKurotatoScoreAwardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoScoreAwardAll.HandleId, ConfigKurotatoScoreAwardAll.LogPair);
					return null;
				}
				KurotatoScoreAward rootAsKurotatoScoreAward = KurotatoScoreAward.GetRootAsKurotatoScoreAward(new ByteBuffer(item2));
				list.Add(rootAsKurotatoScoreAward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoScoreAwardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoScoreAwardAll.HandleId, ConfigKurotatoScoreAwardAll.LogPair);
			return list;
		}

		// Token: 0x0400216A RID: 8554
		private const string DB = "db_kurotato.db";

		// Token: 0x0400216B RID: 8555
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x0400216C RID: 8556
		private const string TABLE = "KurotatoScoreAward";

		// Token: 0x0400216D RID: 8557
		private const string COMMAND = "select BinData from `KurotatoScoreAward`";

		// Token: 0x0400216E RID: 8558
		private const string KEY_PREFIX = "KurotatoScoreAwardAll";

		// Token: 0x0400216F RID: 8559
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002170 RID: 8560
		private static int HandleId;
	}
}
