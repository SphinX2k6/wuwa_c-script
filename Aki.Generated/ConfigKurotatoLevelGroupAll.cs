using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004B4 RID: 1204
	public class ConfigKurotatoLevelGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x000FCB53 File Offset: 0x000FAD53
		static ConfigKurotatoLevelGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoLevelGroupAll.CreateStaticDefaultValue), new Action(ConfigKurotatoLevelGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x000FCB74 File Offset: 0x000FAD74
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

		// Token: 0x06001C45 RID: 7237 RVA: 0x000FCBF3 File Offset: 0x000FADF3
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoLevelGroupAll.LogPair = null;
			ConfigKurotatoLevelGroupAll.HandleId = 0;
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x000FCC01 File Offset: 0x000FAE01
		public static void Init()
		{
			ConfigKurotatoLevelGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoLevelGroupAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoLevelGroup`");
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x000FCC1C File Offset: 0x000FAE1C
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

		// Token: 0x040020D0 RID: 8400
		private const string DB = "db_kurotato.db";

		// Token: 0x040020D1 RID: 8401
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020D2 RID: 8402
		private const string TABLE = "KurotatoLevelGroup";

		// Token: 0x040020D3 RID: 8403
		private const string COMMAND = "select BinData from `KurotatoLevelGroup`";

		// Token: 0x040020D4 RID: 8404
		private const string KEY_PREFIX = "KurotatoLevelGroupAll";

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
