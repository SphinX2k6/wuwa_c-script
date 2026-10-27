using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000864 RID: 2148
	public class ConfigRogueSeasonAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600326A RID: 12906 RVA: 0x00176838 File Offset: 0x00174A38
		static ConfigRogueSeasonAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueSeasonAll.CreateStaticDefaultValue), new Action(ConfigRogueSeasonAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600326B RID: 12907 RVA: 0x00176858 File Offset: 0x00174A58
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueSeasonAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueSeasonAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueSeason`")
			});
		}

		// Token: 0x0600326C RID: 12908 RVA: 0x001768D7 File Offset: 0x00174AD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueSeasonAll.LogPair = null;
			ConfigRogueSeasonAll.HandleId = 0;
		}

		// Token: 0x0600326D RID: 12909 RVA: 0x001768E5 File Offset: 0x00174AE5
		public static void Init()
		{
			ConfigRogueSeasonAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueSeasonAll.HandleId, "db_rogue.db", "select BinData from `RogueSeason`");
		}

		// Token: 0x0600326E RID: 12910 RVA: 0x00176900 File Offset: 0x00174B00
		[NullableContext(2)]
		public static IReadOnlyList<RogueSeason> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueSeason> readOnlyList = (IReadOnlyList<RogueSeason>)ConfigCommon.GetConfig("RogueSeasonAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueSeason> list = new List<RogueSeason>();
			while (ConfigCommon.Step(ConfigRogueSeasonAll.HandleId, false, ConfigRogueSeasonAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueSeasonAll.HandleId, 0, ConfigRogueSeasonAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair);
					return null;
				}
				RogueSeason rootAsRogueSeason = RogueSeason.GetRootAsRogueSeason(new ByteBuffer(item2));
				list.Add(rootAsRogueSeason);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueSeasonAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueSeasonAll.HandleId, ConfigRogueSeasonAll.LogPair);
			return list;
		}

		// Token: 0x04003AA2 RID: 15010
		private const string DB = "db_rogue.db";

		// Token: 0x04003AA3 RID: 15011
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003AA4 RID: 15012
		private const string TABLE = "RogueSeason";

		// Token: 0x04003AA5 RID: 15013
		private const string COMMAND = "select BinData from `RogueSeason`";

		// Token: 0x04003AA6 RID: 15014
		private const string KEY_PREFIX = "RogueSeasonAll";

		// Token: 0x04003AA7 RID: 15015
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AA8 RID: 15016
		private static int HandleId;
	}
}
