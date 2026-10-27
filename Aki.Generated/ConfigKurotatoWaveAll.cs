using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BA RID: 1210
	public class ConfigKurotatoWaveAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C67 RID: 7271 RVA: 0x000F9CEC File Offset: 0x000F7EEC
		static ConfigKurotatoWaveAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x000F9D0C File Offset: 0x000F7F0C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaveAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaveAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWave"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWave`")
			});
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x000F9D8B File Offset: 0x000F7F8B
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveAll.LogPair = null;
			ConfigKurotatoWaveAll.HandleId = 0;
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x000F9D99 File Offset: 0x000F7F99
		public static void Init()
		{
			ConfigKurotatoWaveAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWave`");
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x000F9DB4 File Offset: 0x000F7FB4
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWave> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaveAll.HandleId, ConfigKurotatoWaveAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWave> readOnlyList = (IReadOnlyList<KurotatoWave>)ConfigCommon.GetConfig("KurotatoWaveAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWave> list = new List<KurotatoWave>();
			while (ConfigCommon.Step(ConfigKurotatoWaveAll.HandleId, false, ConfigKurotatoWaveAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaveAll.HandleId, 0, ConfigKurotatoWaveAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWaveAll.HandleId, ConfigKurotatoWaveAll.LogPair);
					return null;
				}
				KurotatoWave rootAsKurotatoWave = KurotatoWave.GetRootAsKurotatoWave(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWave);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWaveAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWaveAll.HandleId, ConfigKurotatoWaveAll.LogPair);
			return list;
		}

		// Token: 0x040020FA RID: 8442
		private const string DB = "db_kurotato.db";

		// Token: 0x040020FB RID: 8443
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040020FC RID: 8444
		private const string TABLE = "KurotatoWave";

		// Token: 0x040020FD RID: 8445
		private const string COMMAND = "select BinData from `KurotatoWave`";

		// Token: 0x040020FE RID: 8446
		private const string KEY_PREFIX = "KurotatoWaveAll";

		// Token: 0x040020FF RID: 8447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002100 RID: 8448
		private static int HandleId;
	}
}
