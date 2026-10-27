using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048F RID: 1167
	public class ConfigKurotatoExpAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x000F42C4 File Offset: 0x000F24C4
		static ConfigKurotatoExpAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoExpAll.CreateStaticDefaultValue), new Action(ConfigKurotatoExpAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x000F42E4 File Offset: 0x000F24E4
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoExpAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoExpAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoExp"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoExp`")
			});
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x000F4363 File Offset: 0x000F2563
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoExpAll.LogPair = null;
			ConfigKurotatoExpAll.HandleId = 0;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x000F4371 File Offset: 0x000F2571
		public static void Init()
		{
			ConfigKurotatoExpAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoExpAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoExp`");
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x000F438C File Offset: 0x000F258C
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoExp> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoExp> readOnlyList = (IReadOnlyList<KurotatoExp>)ConfigCommon.GetConfig("KurotatoExpAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoExp> list = new List<KurotatoExp>();
			while (ConfigCommon.Step(ConfigKurotatoExpAll.HandleId, false, ConfigKurotatoExpAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpAll.HandleId, 0, ConfigKurotatoExpAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair);
					return null;
				}
				KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(new ByteBuffer(item2));
				list.Add(rootAsKurotatoExp);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoExpAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoExpAll.HandleId, ConfigKurotatoExpAll.LogPair);
			return list;
		}

		// Token: 0x04001FCD RID: 8141
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FCE RID: 8142
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04001FCF RID: 8143
		private const string TABLE = "KurotatoExp";

		// Token: 0x04001FD0 RID: 8144
		private const string COMMAND = "select BinData from `KurotatoExp`";

		// Token: 0x04001FD1 RID: 8145
		private const string KEY_PREFIX = "KurotatoExpAll";

		// Token: 0x04001FD2 RID: 8146
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FD3 RID: 8147
		private static int HandleId;
	}
}
