using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B0 RID: 1200
	public class ConfigKurotatoResAwardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C2B RID: 7211 RVA: 0x000F88EC File Offset: 0x000F6AEC
		static ConfigKurotatoResAwardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoResAwardAll.CreateStaticDefaultValue), new Action(ConfigKurotatoResAwardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x000F890C File Offset: 0x000F6B0C
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

		// Token: 0x06001C2D RID: 7213 RVA: 0x000F898B File Offset: 0x000F6B8B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoResAwardAll.LogPair = null;
			ConfigKurotatoResAwardAll.HandleId = 0;
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x000F8999 File Offset: 0x000F6B99
		public static void Init()
		{
			ConfigKurotatoResAwardAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoResAwardAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoResAward`");
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x000F89B4 File Offset: 0x000F6BB4
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

		// Token: 0x040020B4 RID: 8372
		private const string DB = "db_kurotato.db";

		// Token: 0x040020B5 RID: 8373
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x040020B6 RID: 8374
		private const string TABLE = "KurotatoResAward";

		// Token: 0x040020B7 RID: 8375
		private const string COMMAND = "select BinData from `KurotatoResAward`";

		// Token: 0x040020B8 RID: 8376
		private const string KEY_PREFIX = "KurotatoResAwardAll";

		// Token: 0x040020B9 RID: 8377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040020BA RID: 8378
		private static int HandleId;
	}
}
