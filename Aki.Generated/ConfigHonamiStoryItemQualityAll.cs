using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003FE RID: 1022
	public class ConfigHonamiStoryItemQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x000E4BE8 File Offset: 0x000E2DE8
		static ConfigHonamiStoryItemQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemQualityAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x060017FC RID: 6140 RVA: 0x000E4C08 File Offset: 0x000E2E08
		public static void CreateStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHonamiStoryItemQualityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_honamistory.db"),
				new ValueTuple<string, object>("文件", "s.穗波奇妙物语道具.xlsx"),
				new ValueTuple<string, object>("表名", "HonamiStoryItemQuality"),
				new ValueTuple<string, object>("语句", "select BinData from `HonamiStoryItemQuality`")
			});
		}

		// Token: 0x060017FD RID: 6141 RVA: 0x000E4C87 File Offset: 0x000E2E87
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityAll.LogPair = null;
			ConfigHonamiStoryItemQualityAll.HandleId = 0;
		}

		// Token: 0x060017FE RID: 6142 RVA: 0x000E4C95 File Offset: 0x000E2E95
		public static void Init()
		{
			ConfigHonamiStoryItemQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemQualityAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemQuality`");
		}

		// Token: 0x060017FF RID: 6143 RVA: 0x000E4CB0 File Offset: 0x000E2EB0
		[NullableContext(2)]
		public static IReadOnlyList<HonamiStoryItemQuality> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHonamiStoryItemQualityAll.HandleId, ConfigHonamiStoryItemQualityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HonamiStoryItemQuality> readOnlyList = (IReadOnlyList<HonamiStoryItemQuality>)ConfigCommon.GetConfig("HonamiStoryItemQualityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HonamiStoryItemQuality> list = new List<HonamiStoryItemQuality>();
			while (ConfigCommon.Step(ConfigHonamiStoryItemQualityAll.HandleId, false, ConfigHonamiStoryItemQualityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHonamiStoryItemQualityAll.HandleId, 0, ConfigHonamiStoryItemQualityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHonamiStoryItemQualityAll.HandleId, ConfigHonamiStoryItemQualityAll.LogPair);
					return null;
				}
				HonamiStoryItemQuality rootAsHonamiStoryItemQuality = HonamiStoryItemQuality.GetRootAsHonamiStoryItemQuality(new ByteBuffer(item2));
				list.Add(rootAsHonamiStoryItemQuality);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HonamiStoryItemQualityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHonamiStoryItemQualityAll.HandleId, ConfigHonamiStoryItemQualityAll.LogPair);
			return list;
		}

		// Token: 0x04001BD6 RID: 7126
		private const string DB = "db_honamistory.db";

		// Token: 0x04001BD7 RID: 7127
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001BD8 RID: 7128
		private const string TABLE = "HonamiStoryItemQuality";

		// Token: 0x04001BD9 RID: 7129
		private const string COMMAND = "select BinData from `HonamiStoryItemQuality`";

		// Token: 0x04001BDA RID: 7130
		private const string KEY_PREFIX = "HonamiStoryItemQualityAll";

		// Token: 0x04001BDB RID: 7131
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001BDC RID: 7132
		private static int HandleId;
	}
}
