using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004BC RID: 1212
	public class ConfigKurotatoWaveLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001C73 RID: 7283 RVA: 0x000FA0C8 File Offset: 0x000F82C8
		static ConfigKurotatoWaveLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoWaveLevelAll.CreateStaticDefaultValue), new Action(ConfigKurotatoWaveLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x000FA0E8 File Offset: 0x000F82E8
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

		// Token: 0x06001C75 RID: 7285 RVA: 0x000FA167 File Offset: 0x000F8367
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoWaveLevelAll.LogPair = null;
			ConfigKurotatoWaveLevelAll.HandleId = 0;
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x000FA175 File Offset: 0x000F8375
		public static void Init()
		{
			ConfigKurotatoWaveLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoWaveLevelAll.HandleId, "db_kurotato.db", "select BinData from `KurotatoWaveLevel`");
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x000FA190 File Offset: 0x000F8390
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

		// Token: 0x04002108 RID: 8456
		private const string DB = "db_kurotato.db";

		// Token: 0x04002109 RID: 8457
		private const string FILE = "t.土豆兄弟_关卡.xlsx";

		// Token: 0x0400210A RID: 8458
		private const string TABLE = "KurotatoWaveLevel";

		// Token: 0x0400210B RID: 8459
		private const string COMMAND = "select BinData from `KurotatoWaveLevel`";

		// Token: 0x0400210C RID: 8460
		private const string KEY_PREFIX = "KurotatoWaveLevelAll";

		// Token: 0x0400210D RID: 8461
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400210E RID: 8462
		private static int HandleId;
	}
}
