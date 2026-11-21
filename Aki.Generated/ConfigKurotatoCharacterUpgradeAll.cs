using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004A0 RID: 1184
	public class ConfigKurotatoCharacterUpgradeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001BCA RID: 7114 RVA: 0x000F9F64 File Offset: 0x000F8164
		static ConfigKurotatoCharacterUpgradeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoCharacterUpgradeAll.CreateStaticDefaultValue), new Action(ConfigKurotatoCharacterUpgradeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x000F9F84 File Offset: 0x000F8184
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

		// Token: 0x06001BCC RID: 7116 RVA: 0x000FA003 File Offset: 0x000F8203
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoCharacterUpgradeAll.LogPair = null;
			ConfigKurotatoCharacterUpgradeAll.HandleId = 0;
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x000FA011 File Offset: 0x000F8211
		public static void Init()
		{
			ConfigKurotatoCharacterUpgradeAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoCharacterUpgradeAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoCharacterUpgrade`");
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x000FA02C File Offset: 0x000F822C
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

		// Token: 0x04002044 RID: 8260
		private const string DB = "db_kurotato.db";

		// Token: 0x04002045 RID: 8261
		private const string FILE = "t.土豆兄弟_角色.xlsx";

		// Token: 0x04002046 RID: 8262
		private const string TABLE = "KurotatoCharacterUpgrade";

		// Token: 0x04002047 RID: 8263
		private const string COMMAND = "select BinData from `KurotatoCharacterUpgrade`";

		// Token: 0x04002048 RID: 8264
		private const string KEY_PREFIX = "KurotatoCharacterUpgradeAll";

		// Token: 0x04002049 RID: 8265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400204A RID: 8266
		private static int HandleId;
	}
}
