using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200049E RID: 1182
	public class ConfigKurotatoLevelGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BBF RID: 7103 RVA: 0x000F63FF File Offset: 0x000F45FF
		static ConfigKurotatoLevelGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelGroupAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x000F6420 File Offset: 0x000F4620
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoLevelGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoLevelGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoLevelGroup`")
			});
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x000F649F File Offset: 0x000F469F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupAll.LogPair = null;
			ConfigKurotatoLevelGroupAll.HandleId = 0;
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x000F64AD File Offset: 0x000F46AD
		public static void Init()
		{
			ConfigKurotatoLevelGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelGroupAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelGroup`");
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x000F64C8 File Offset: 0x000F46C8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoLevelGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoLevelGroupAll.HandleId, ConfigKurotatoLevelGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoLevelGroup> readOnlyList = (IReadOnlyList<KurotatoLevelGroup>)ConfigCommon.GetConfig("KurotatoLevelGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoLevelGroup> list = new List<KurotatoLevelGroup>();
			while (ConfigCommon.Step(ConfigKurotatoLevelGroupAll.HandleId, false, ConfigKurotatoLevelGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoLevelGroupAll.HandleId, 0, ConfigKurotatoLevelGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoLevelGroupAll.HandleId, ConfigKurotatoLevelGroupAll.LogPair);
					return null;
				}
				KurotatoLevelGroup rootAsKurotatoLevelGroup = KurotatoLevelGroup.GetRootAsKurotatoLevelGroup(new ByteBuffer(item2));
				list.Add(rootAsKurotatoLevelGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoLevelGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoLevelGroupAll.HandleId, ConfigKurotatoLevelGroupAll.LogPair);
			return list;
		}

		// Token: 0x04002036 RID: 8246
		private const string DB = "db_kurotato.db";

		// Token: 0x04002037 RID: 8247
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x04002038 RID: 8248
		private const string TABLE = "KurotatoLevelGroup";

		// Token: 0x04002039 RID: 8249
		private const string COMMAND = "select BinData from `KurotatoLevelGroup`";

		// Token: 0x0400203A RID: 8250
		private const string KEY_PREFIX = "KurotatoLevelGroupAll";

		// Token: 0x0400203B RID: 8251
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400203C RID: 8252
		private static int HandleId;
	}
}
