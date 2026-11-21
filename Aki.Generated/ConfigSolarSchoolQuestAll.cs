using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009FE RID: 2558
	public class ConfigSolarSchoolQuestAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C08 RID: 15368 RVA: 0x001B0230 File Offset: 0x001AE430
		static ConfigSolarSchoolQuestAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolQuestAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolQuestAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x001B0250 File Offset: 0x001AE450
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolQuestAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolQuestAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_任务.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolQuest"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolQuest`")
			});
		}

		// Token: 0x06003C0A RID: 15370 RVA: 0x001B02CF File Offset: 0x001AE4CF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolQuestAll.LogPair = null;
			ConfigSolarSchoolQuestAll.HandleId = 0;
		}

		// Token: 0x06003C0B RID: 15371 RVA: 0x001B02DD File Offset: 0x001AE4DD
		public static void Init()
		{
			ConfigSolarSchoolQuestAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolQuestAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolQuest`");
		}

		// Token: 0x06003C0C RID: 15372 RVA: 0x001B02F8 File Offset: 0x001AE4F8
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolQuest> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolQuestAll.HandleId, ConfigSolarSchoolQuestAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolQuest> readOnlyList = (IReadOnlyList<SolarSchoolQuest>)ConfigCommon.GetConfig("SolarSchoolQuestAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolQuest> list = new List<SolarSchoolQuest>();
			while (ConfigCommon.Step(ConfigSolarSchoolQuestAll.HandleId, false, ConfigSolarSchoolQuestAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolQuestAll.HandleId, 0, ConfigSolarSchoolQuestAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolQuestAll.HandleId, ConfigSolarSchoolQuestAll.LogPair);
					return null;
				}
				SolarSchoolQuest rootAsSolarSchoolQuest = SolarSchoolQuest.GetRootAsSolarSchoolQuest(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolQuest);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolQuestAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolQuestAll.HandleId, ConfigSolarSchoolQuestAll.LogPair);
			return list;
		}

		// Token: 0x040045D8 RID: 17880
		private const string DB = "db_solarschool.db";

		// Token: 0x040045D9 RID: 17881
		private const string FILE = "d.第二索拉_任务.xlsx";

		// Token: 0x040045DA RID: 17882
		private const string TABLE = "SolarSchoolQuest";

		// Token: 0x040045DB RID: 17883
		private const string COMMAND = "select BinData from `SolarSchoolQuest`";

		// Token: 0x040045DC RID: 17884
		private const string KEY_PREFIX = "SolarSchoolQuestAll";

		// Token: 0x040045DD RID: 17885
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040045DE RID: 17886
		private static int HandleId;
	}
}
