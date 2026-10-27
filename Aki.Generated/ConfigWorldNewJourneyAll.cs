using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9B RID: 2715
	public class ConfigWorldNewJourneyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FB7 RID: 16311 RVA: 0x001C2AC4 File Offset: 0x001C0CC4
		static ConfigWorldNewJourneyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWorldNewJourneyAll.CreateStaticDefaultValue), new Action(ConfigWorldNewJourneyAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FB8 RID: 16312 RVA: 0x001C2AE4 File Offset: 0x001C0CE4
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

		// Token: 0x06003FB9 RID: 16313 RVA: 0x001C2B63 File Offset: 0x001C0D63
		public static void ResetStaticDefaultValue()
		{
			ConfigWorldNewJourneyAll.LogPair = null;
			ConfigWorldNewJourneyAll.HandleId = 0;
		}

		// Token: 0x06003FBA RID: 16314 RVA: 0x001C2B71 File Offset: 0x001C0D71
		public static void Init()
		{
			ConfigWorldNewJourneyAll.HandleId = ConfigCommon.InitDataStatement(ConfigWorldNewJourneyAll.HandleId, "db_worldnewjourney.db", "select BinData from `WorldNewJourney`");
		}

		// Token: 0x06003FBB RID: 16315 RVA: 0x001C2B8C File Offset: 0x001C0D8C
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

		// Token: 0x04004A23 RID: 18979
		private const string DB = "db_worldnewjourney.db";

		// Token: 0x04004A24 RID: 18980
		private const string FILE = "m.鸣域新程活动.xlsx";

		// Token: 0x04004A25 RID: 18981
		private const string TABLE = "WorldNewJourney";

		// Token: 0x04004A26 RID: 18982
		private const string COMMAND = "select BinData from `WorldNewJourney`";

		// Token: 0x04004A27 RID: 18983
		private const string KEY_PREFIX = "WorldNewJourneyAll";

		// Token: 0x04004A28 RID: 18984
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A29 RID: 18985
		private static int HandleId;
	}
}
