using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A1 RID: 1185
	public class ConfigKurotatoLimitAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BD1 RID: 7121 RVA: 0x000F6A24 File Offset: 0x000F4C24
		static ConfigKurotatoLimitAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLimitAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLimitAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x000F6A44 File Offset: 0x000F4C44
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLimitAwardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLimitAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLimitAward`")
			});
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x000F6AC3 File Offset: 0x000F4CC3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLimitAwardAll.LogPair = null;
			ConfigKurotatoLimitAwardAll.HandleId = 0;
		}

		// Token: 0x06001BD4 RID: 7124 RVA: 0x000F6AD1 File Offset: 0x000F4CD1
		public static void Init()
		{
			ConfigKurotatoLimitAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLimitAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLimitAward`");
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x000F6AEC File Offset: 0x000F4CEC
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLimitAward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoLimitAward> readOnlyList = (IReadOnlyList<KurotatoLimitAward>)ConfigCommon.GetConfig("KurotatoLimitAwardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoLimitAward> list = new List<KurotatoLimitAward>();
			while (ConfigCommon.Step(ConfigKurotatoLimitAwardAll.HandleId, false, ConfigKurotatoLimitAwardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLimitAwardAll.HandleId, 0, ConfigKurotatoLimitAwardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair);
					return null;
				}
				KurotatoLimitAward rootAsKurotatoLimitAward = KurotatoLimitAward.GetRootAsKurotatoLimitAward(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLimitAward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoLimitAwardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLimitAwardAll.HandleId, ConfigKurotatoLimitAwardAll.LogPair);
			return list;
		}

		// Token: 0x0400204B RID: 8267
		private const string DB = "db_kurotato.db";

		// Token: 0x0400204C RID: 8268
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x0400204D RID: 8269
		private const string TABLE = "KurotatoLimitAward";

		// Token: 0x0400204E RID: 8270
		private const string COMMAND = "select BinData from `KurotatoLimitAward`";

		// Token: 0x0400204F RID: 8271
		private const string KEY_PREFIX = "KurotatoLimitAwardAll";

		// Token: 0x04002050 RID: 8272
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002051 RID: 8273
		private static int HandleId;
	}
}
