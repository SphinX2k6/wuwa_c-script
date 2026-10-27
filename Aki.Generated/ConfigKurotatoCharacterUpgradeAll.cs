using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200048A RID: 1162
	public class ConfigKurotatoCharacterUpgradeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x000F3810 File Offset: 0x000F1A10
		static ConfigKurotatoCharacterUpgradeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterUpgradeAll.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterUpgradeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x000F3830 File Offset: 0x000F1A30
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoCharacterUpgradeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_角色.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoCharacterUpgrade"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoCharacterUpgrade`")
			});
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x000F38AF File Offset: 0x000F1AAF
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeAll.LogPair = null;
			ConfigKurotatoCharacterUpgradeAll.HandleId = 0;
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x000F38BD File Offset: 0x000F1ABD
		public static void Init()
		{
			ConfigKurotatoCharacterUpgradeAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterUpgradeAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacterUpgrade`");
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x000F38D8 File Offset: 0x000F1AD8
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoCharacterUpgrade> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoCharacterUpgradeAll.HandleId, ConfigKurotatoCharacterUpgradeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoCharacterUpgrade> readOnlyList = (IReadOnlyList<KurotatoCharacterUpgrade>)ConfigCommon.GetConfig("KurotatoCharacterUpgradeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoCharacterUpgrade> list = new List<KurotatoCharacterUpgrade>();
			while (ConfigCommon.Step(ConfigKurotatoCharacterUpgradeAll.HandleId, false, ConfigKurotatoCharacterUpgradeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoCharacterUpgradeAll.HandleId, 0, ConfigKurotatoCharacterUpgradeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoCharacterUpgradeAll.HandleId, ConfigKurotatoCharacterUpgradeAll.LogPair);
					return null;
				}
				KurotatoCharacterUpgrade rootAsKurotatoCharacterUpgrade = KurotatoCharacterUpgrade.GetRootAsKurotatoCharacterUpgrade(new ByteBuffer(item2));
				list.Add(rootAsKurotatoCharacterUpgrade);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoCharacterUpgradeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoCharacterUpgradeAll.HandleId, ConfigKurotatoCharacterUpgradeAll.LogPair);
			return list;
		}

		// Token: 0x04001FAA RID: 8106
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FAB RID: 8107
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04001FAC RID: 8108
		private const string TABLE = "KurotatoCharacterUpgrade";

		// Token: 0x04001FAD RID: 8109
		private const string COMMAND = "select BinData from `KurotatoCharacterUpgrade`";

		// Token: 0x04001FAE RID: 8110
		private const string KEY_PREFIX = "KurotatoCharacterUpgradeAll";

		// Token: 0x04001FAF RID: 8111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FB0 RID: 8112
		private static int HandleId;
	}
}
