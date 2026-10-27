using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B4 RID: 1204
	public class ConfigKurotatoScoreAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x000F90A4 File Offset: 0x000F72A4
		static ConfigKurotatoScoreAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoScoreAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoScoreAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x000F90C4 File Offset: 0x000F72C4
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

		// Token: 0x06001C45 RID: 7237 RVA: 0x000F9143 File Offset: 0x000F7343
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoScoreAwardAll.LogPair = null;
			ConfigKurotatoScoreAwardAll.HandleId = 0;
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000F9151 File Offset: 0x000F7351
		public static void Init()
		{
			ConfigKurotatoScoreAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoScoreAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoScoreAward`");
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000F916C File Offset: 0x000F736C
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

		// Token: 0x040020D0 RID: 8400
		private const string DB = "db_kurotato.db";

		// Token: 0x040020D1 RID: 8401
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020D2 RID: 8402
		private const string TABLE = "KurotatoScoreAward";

		// Token: 0x040020D3 RID: 8403
		private const string COMMAND = "select BinData from `KurotatoScoreAward`";

		// Token: 0x040020D4 RID: 8404
		private const string KEY_PREFIX = "KurotatoScoreAwardAll";

		// Token: 0x040020D5 RID: 8405
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020D6 RID: 8406
		private static int HandleId;
	}
}
