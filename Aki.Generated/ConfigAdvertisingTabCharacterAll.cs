using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000066 RID: 102
	public class ConfigAdvertisingTabCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000264 RID: 612 RVA: 0x000672F8 File Offset: 0x000654F8
		static ConfigAdvertisingTabCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCharacterAll.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00067318 File Offset: 0x00065518
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

		// Token: 0x06000266 RID: 614 RVA: 0x00067397 File Offset: 0x00065597
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterAll.LogPair = null;
			ConfigAdvertisingTabCharacterAll.HandleId = 0;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000673A5 File Offset: 0x000655A5
		public static void Init()
		{
			ConfigAdvertisingTabCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCharacterAll.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCharacter`");
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000673C0 File Offset: 0x000655C0
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

		// Token: 0x040002AE RID: 686
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002AF RID: 687
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002B0 RID: 688
		private const string TABLE = "AdvertisingTabCharacter";

		// Token: 0x040002B1 RID: 689
		private const string COMMAND = "select BinData from `AdvertisingTabCharacter`";

		// Token: 0x040002B2 RID: 690
		private const string KEY_PREFIX = "AdvertisingTabCharacterAll";

		// Token: 0x040002B3 RID: 691
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002B4 RID: 692
		private static int HandleId;
	}
}
