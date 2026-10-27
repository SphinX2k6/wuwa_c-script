using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031E RID: 798
	public class ConfigFloroRanchRaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x000C349C File Offset: 0x000C169C
		static ConfigFloroRanchRaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRaceAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchRaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000C34BC File Offset: 0x000C16BC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchRaceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchRaceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchRace"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchRace`")
			});
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000C353B File Offset: 0x000C173B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRaceAll.LogPair = null;
			ConfigFloroRanchRaceAll.HandleId = 0;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000C3549 File Offset: 0x000C1749
		public static void Init()
		{
			ConfigFloroRanchRaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRaceAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRace`");
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000C3564 File Offset: 0x000C1764
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchRace> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchRaceAll.HandleId, ConfigFloroRanchRaceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchRace> readOnlyList = (IReadOnlyList<FloroRanchRace>)ConfigCommon.GetConfig("FloroRanchRaceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchRace> list = new List<FloroRanchRace>();
			while (ConfigCommon.Step(ConfigFloroRanchRaceAll.HandleId, false, ConfigFloroRanchRaceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchRaceAll.HandleId, 0, ConfigFloroRanchRaceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchRaceAll.HandleId, ConfigFloroRanchRaceAll.LogPair);
					return null;
				}
				FloroRanchRace rootAsFloroRanchRace = FloroRanchRace.GetRootAsFloroRanchRace(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchRace);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchRaceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchRaceAll.HandleId, ConfigFloroRanchRaceAll.LogPair);
			return list;
		}

		// Token: 0x040015B6 RID: 5558
		private const string DB = "db_flororanch.db";

		// Token: 0x040015B7 RID: 5559
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040015B8 RID: 5560
		private const string TABLE = "FloroRanchRace";

		// Token: 0x040015B9 RID: 5561
		private const string COMMAND = "select BinData from `FloroRanchRace`";

		// Token: 0x040015BA RID: 5562
		private const string KEY_PREFIX = "FloroRanchRaceAll";

		// Token: 0x040015BB RID: 5563
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015BC RID: 5564
		private static int HandleId;
	}
}
