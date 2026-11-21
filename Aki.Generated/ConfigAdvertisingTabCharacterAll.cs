using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006E RID: 110
	public class ConfigAdvertisingTabCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000294 RID: 660 RVA: 0x0006BBAC File Offset: 0x00069DAC
		static ConfigAdvertisingTabCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCharacterAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0006BBCC File Offset: 0x00069DCC
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabCharacterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabCharacter`")
			});
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0006BC4B File Offset: 0x00069E4B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterAll.LogPair = null;
			ConfigAdvertisingTabCharacterAll.HandleId = 0;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0006BC59 File Offset: 0x00069E59
		public static void Init()
		{
			ConfigAdvertisingTabCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCharacterAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCharacter`");
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0006BC74 File Offset: 0x00069E74
		[NullableContext(2)]
		public static IReadOnlyList<AdvertisingTabCharacter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabCharacterAll.HandleId, ConfigAdvertisingTabCharacterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdvertisingTabCharacter> readOnlyList = (IReadOnlyList<AdvertisingTabCharacter>)ConfigCommon.GetConfig("AdvertisingTabCharacterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdvertisingTabCharacter> list = new List<AdvertisingTabCharacter>();
			while (ConfigCommon.Step(ConfigAdvertisingTabCharacterAll.HandleId, false, ConfigAdvertisingTabCharacterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabCharacterAll.HandleId, 0, ConfigAdvertisingTabCharacterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdvertisingTabCharacterAll.HandleId, ConfigAdvertisingTabCharacterAll.LogPair);
					return null;
				}
				AdvertisingTabCharacter rootAsAdvertisingTabCharacter = AdvertisingTabCharacter.GetRootAsAdvertisingTabCharacter(new ByteBuffer(item2));
				list.Add(rootAsAdvertisingTabCharacter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdvertisingTabCharacterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabCharacterAll.HandleId, ConfigAdvertisingTabCharacterAll.LogPair);
			return list;
		}

		// Token: 0x040002E6 RID: 742
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002E7 RID: 743
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002E8 RID: 744
		private const string TABLE = "AdvertisingTabCharacter";

		// Token: 0x040002E9 RID: 745
		private const string COMMAND = "select BinData from `AdvertisingTabCharacter`";

		// Token: 0x040002EA RID: 746
		private const string KEY_PREFIX = "AdvertisingTabCharacterAll";

		// Token: 0x040002EB RID: 747
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002EC RID: 748
		private static int HandleId;
	}
}
