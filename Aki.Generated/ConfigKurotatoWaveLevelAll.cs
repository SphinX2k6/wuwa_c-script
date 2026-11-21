using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D2 RID: 1234
	public class ConfigKurotatoWaveLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CF7 RID: 7415 RVA: 0x0010081C File Offset: 0x000FEA1C
		static ConfigKurotatoWaveLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveLevelAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x0010083C File Offset: 0x000FEA3C
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoWaveLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_关卡.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoWaveLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoWaveLevel`")
			});
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x001008BB File Offset: 0x000FEABB
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelAll.LogPair = null;
			ConfigKurotatoWaveLevelAll.HandleId = 0;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x001008C9 File Offset: 0x000FEAC9
		public static void Init()
		{
			ConfigKurotatoWaveLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveLevelAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaveLevel`");
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x001008E4 File Offset: 0x000FEAE4
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoWaveLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoWaveLevelAll.HandleId, ConfigKurotatoWaveLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<KurotatoWaveLevel> readOnlyList = (IReadOnlyList<KurotatoWaveLevel>)ConfigCommon.GetConfig("KurotatoWaveLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<KurotatoWaveLevel> list = new List<KurotatoWaveLevel>();
			while (ConfigCommon.Step(ConfigKurotatoWaveLevelAll.HandleId, false, ConfigKurotatoWaveLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoWaveLevelAll.HandleId, 0, ConfigKurotatoWaveLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoWaveLevelAll.HandleId, ConfigKurotatoWaveLevelAll.LogPair);
					return null;
				}
				KurotatoWaveLevel rootAsKurotatoWaveLevel = KurotatoWaveLevel.GetRootAsKurotatoWaveLevel(new ByteBuffer(item2));
				list.Add(rootAsKurotatoWaveLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("KurotatoWaveLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoWaveLevelAll.HandleId, ConfigKurotatoWaveLevelAll.LogPair);
			return list;
		}

		// Token: 0x040021A2 RID: 8610
		private const string DB = "db_kurotato.db";

		// Token: 0x040021A3 RID: 8611
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x040021A4 RID: 8612
		private const string TABLE = "KurotatoWaveLevel";

		// Token: 0x040021A5 RID: 8613
		private const string COMMAND = "select BinData from `KurotatoWaveLevel`";

		// Token: 0x040021A6 RID: 8614
		private const string KEY_PREFIX = "KurotatoWaveLevelAll";

		// Token: 0x040021A7 RID: 8615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021A8 RID: 8616
		private static int HandleId;
	}
}
