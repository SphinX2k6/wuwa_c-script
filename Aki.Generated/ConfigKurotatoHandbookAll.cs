using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000494 RID: 1172
	public class ConfigKurotatoHandbookAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B83 RID: 7043 RVA: 0x000F4EDC File Offset: 0x000F30DC
		static ConfigKurotatoHandbookAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoHandbookAll.CreateStaticDefaultValue), new Action(ConfigKurotatoHandbookAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x000F4EFC File Offset: 0x000F30FC
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoHandbookAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoHandbookAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局外.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoHandbook"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoHandbook`")
			});
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x000F4F7B File Offset: 0x000F317B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoHandbookAll.LogPair = null;
			ConfigKurotatoHandbookAll.HandleId = 0;
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x000F4F89 File Offset: 0x000F3189
		public static void Init()
		{
			ConfigKurotatoHandbookAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoHandbookAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoHandbook`");
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x000F4FA4 File Offset: 0x000F31A4
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoHandbook> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoHandbook> readOnlyList = (IReadOnlyList<KurotatoHandbook>)ConfigCommon.GetConfig("KurotatoHandbookAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoHandbook> list = new List<KurotatoHandbook>();
			while (ConfigCommon.Step(ConfigKurotatoHandbookAll.HandleId, false, ConfigKurotatoHandbookAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoHandbookAll.HandleId, 0, ConfigKurotatoHandbookAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair);
					return null;
				}
				KurotatoHandbook rootAsKurotatoHandbook = KurotatoHandbook.GetRootAsKurotatoHandbook(new ByteBuffer(item2));
				list.Add(rootAsKurotatoHandbook);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoHandbookAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoHandbookAll.HandleId, ConfigKurotatoHandbookAll.LogPair);
			return list;
		}

		// Token: 0x04001FF0 RID: 8176
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FF1 RID: 8177
		private const string FILE = "t.土豆兄弟_局外.xlsx";

		// Token: 0x04001FF2 RID: 8178
		private const string TABLE = "KurotatoHandbook";

		// Token: 0x04001FF3 RID: 8179
		private const string COMMAND = "select BinData from `KurotatoHandbook`";

		// Token: 0x04001FF4 RID: 8180
		private const string KEY_PREFIX = "KurotatoHandbookAll";

		// Token: 0x04001FF5 RID: 8181
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FF6 RID: 8182
		private static int HandleId;
	}
}
