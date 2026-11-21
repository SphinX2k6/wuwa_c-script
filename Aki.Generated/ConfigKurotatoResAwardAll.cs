using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C6 RID: 1222
	public class ConfigKurotatoResAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CAF RID: 7343 RVA: 0x000FF040 File Offset: 0x000FD240
		static ConfigKurotatoResAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoResAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoResAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CB0 RID: 7344 RVA: 0x000FF060 File Offset: 0x000FD260
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoResAwardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoResAwardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoResAward"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoResAward`")
			});
		}

		// Token: 0x06001CB1 RID: 7345 RVA: 0x000FF0DF File Offset: 0x000FD2DF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoResAwardAll.LogPair = null;
			ConfigKurotatoResAwardAll.HandleId = 0;
		}

		// Token: 0x06001CB2 RID: 7346 RVA: 0x000FF0ED File Offset: 0x000FD2ED
		public static void Init()
		{
			ConfigKurotatoResAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoResAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoResAward`");
		}

		// Token: 0x06001CB3 RID: 7347 RVA: 0x000FF108 File Offset: 0x000FD308
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoResAward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoResAwardAll.HandleId, ConfigKurotatoResAwardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoResAward> readOnlyList = (IReadOnlyList<KurotatoResAward>)ConfigCommon.GetConfig("KurotatoResAwardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoResAward> list = new List<KurotatoResAward>();
			while (ConfigCommon.Step(ConfigKurotatoResAwardAll.HandleId, false, ConfigKurotatoResAwardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoResAwardAll.HandleId, 0, ConfigKurotatoResAwardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoResAwardAll.HandleId, ConfigKurotatoResAwardAll.LogPair);
					return null;
				}
				KurotatoResAward rootAsKurotatoResAward = KurotatoResAward.GetRootAsKurotatoResAward(new ByteBuffer(item2));
				list.Add(rootAsKurotatoResAward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoResAwardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoResAwardAll.HandleId, ConfigKurotatoResAwardAll.LogPair);
			return list;
		}

		// Token: 0x0400214E RID: 8526
		private const string DB = "db_kurotato.db";

		// Token: 0x0400214F RID: 8527
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04002150 RID: 8528
		private const string TABLE = "KurotatoResAward";

		// Token: 0x04002151 RID: 8529
		private const string COMMAND = "select BinData from `KurotatoResAward`";

		// Token: 0x04002152 RID: 8530
		private const string KEY_PREFIX = "KurotatoResAwardAll";

		// Token: 0x04002153 RID: 8531
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002154 RID: 8532
		private static int HandleId;
	}
}
