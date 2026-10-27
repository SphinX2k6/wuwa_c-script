using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E8 RID: 1000
	public class ConfigHonamiStoryItemQualityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001777 RID: 6007 RVA: 0x000DE494 File Offset: 0x000DC694
		static ConfigHonamiStoryItemQualityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHonamiStoryItemQualityAll.CreateStaticDefaultValue), new Action(ConfigHonamiStoryItemQualityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x000DE4B4 File Offset: 0x000DC6B4
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

		// Token: 0x06001779 RID: 6009 RVA: 0x000DE533 File Offset: 0x000DC733
		public static void ResetStaticDefaultValue()
		{
			ConfigHonamiStoryItemQualityAll.LogPair = null;
			ConfigHonamiStoryItemQualityAll.HandleId = 0;
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x000DE541 File Offset: 0x000DC741
		public static void Init()
		{
			ConfigHonamiStoryItemQualityAll.HandleId = ConfigCommon.InitDataStatement(ConfigHonamiStoryItemQualityAll.HandleId, "db_honamistory.db", "select BinData from `HonamiStoryItemQuality`");
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x000DE55C File Offset: 0x000DC75C
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

		// Token: 0x04001B3C RID: 6972
		private const string DB = "db_honamistory.db";

		// Token: 0x04001B3D RID: 6973
		private const string FILE = "s.穗波奇妙物语道具.xlsx";

		// Token: 0x04001B3E RID: 6974
		private const string TABLE = "HonamiStoryItemQuality";

		// Token: 0x04001B3F RID: 6975
		private const string COMMAND = "select BinData from `HonamiStoryItemQuality`";

		// Token: 0x04001B40 RID: 6976
		private const string KEY_PREFIX = "HonamiStoryItemQualityAll";

		// Token: 0x04001B41 RID: 6977
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B42 RID: 6978
		private static int HandleId;
	}
}
