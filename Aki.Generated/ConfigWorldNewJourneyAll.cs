using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B70 RID: 2928
	public class ConfigWorldNewJourneyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060044B5 RID: 17589 RVA: 0x001E1E58 File Offset: 0x001E0058
		static ConfigWorldNewJourneyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldNewJourneyAll.CreateStaticDefaultValue), new Action(ConfigWorldNewJourneyAll.ResetStaticDefaultValue));
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x001E1E78 File Offset: 0x001E0078
		public static void CreateStaticDefaultValue()
		{
			ConfigWorldNewJourneyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWorldNewJourneyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_worldnewjourney.db"),
				new ValueTuple<string, object>("文件", "m.鸣域新程活动.xlsx"),
				new ValueTuple<string, object>("表名", "WorldNewJourney"),
				new ValueTuple<string, object>("语句", "select BinData from `WorldNewJourney`")
			});
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x001E1EF7 File Offset: 0x001E00F7
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldNewJourneyAll.LogPair = null;
			ConfigWorldNewJourneyAll.HandleId = 0;
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x001E1F05 File Offset: 0x001E0105
		public static void Init()
		{
			ConfigWorldNewJourneyAll.HandleId = ConfigCommon.InitDataStatement(ConfigWorldNewJourneyAll.HandleId, "db_worldnewjourney.db", "select BinData from `WorldNewJourney`");
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x001E1F20 File Offset: 0x001E0120
		[NullableContext(2)]
		public static IReadOnlyList<WorldNewJourney> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWorldNewJourneyAll.HandleId, ConfigWorldNewJourneyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<WorldNewJourney> readOnlyList = (IReadOnlyList<WorldNewJourney>)ConfigCommon.GetConfig("WorldNewJourneyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<WorldNewJourney> list = new List<WorldNewJourney>();
			while (ConfigCommon.Step(ConfigWorldNewJourneyAll.HandleId, false, ConfigWorldNewJourneyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWorldNewJourneyAll.HandleId, 0, ConfigWorldNewJourneyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWorldNewJourneyAll.HandleId, ConfigWorldNewJourneyAll.LogPair);
					return null;
				}
				WorldNewJourney rootAsWorldNewJourney = WorldNewJourney.GetRootAsWorldNewJourney(new ByteBuffer(item2));
				list.Add(rootAsWorldNewJourney);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("WorldNewJourneyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigWorldNewJourneyAll.HandleId, ConfigWorldNewJourneyAll.LogPair);
			return list;
		}

		// Token: 0x04004FF6 RID: 20470
		private const string DB = "db_worldnewjourney.db";

		// Token: 0x04004FF7 RID: 20471
		private const string FILE = "m.鸣域新程活动.xlsx";

		// Token: 0x04004FF8 RID: 20472
		private const string TABLE = "WorldNewJourney";

		// Token: 0x04004FF9 RID: 20473
		private const string COMMAND = "select BinData from `WorldNewJourney`";

		// Token: 0x04004FFA RID: 20474
		private const string KEY_PREFIX = "WorldNewJourneyAll";

		// Token: 0x04004FFB RID: 20475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004FFC RID: 20476
		private static int HandleId;
	}
}
