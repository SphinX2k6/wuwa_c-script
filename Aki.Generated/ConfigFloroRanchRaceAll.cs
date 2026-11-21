using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000333 RID: 819
	public class ConfigFloroRanchRaceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001337 RID: 4919 RVA: 0x000C99A8 File Offset: 0x000C7BA8
		static ConfigFloroRanchRaceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchRaceAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchRaceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x000C99C8 File Offset: 0x000C7BC8
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

		// Token: 0x06001339 RID: 4921 RVA: 0x000C9A47 File Offset: 0x000C7C47
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchRaceAll.LogPair = null;
			ConfigFloroRanchRaceAll.HandleId = 0;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x000C9A55 File Offset: 0x000C7C55
		public static void Init()
		{
			ConfigFloroRanchRaceAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchRaceAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchRace`");
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000C9A70 File Offset: 0x000C7C70
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

		// Token: 0x04001649 RID: 5705
		private const string DB = "db_flororanch.db";

		// Token: 0x0400164A RID: 5706
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400164B RID: 5707
		private const string TABLE = "FloroRanchRace";

		// Token: 0x0400164C RID: 5708
		private const string COMMAND = "select BinData from `FloroRanchRace`";

		// Token: 0x0400164D RID: 5709
		private const string KEY_PREFIX = "FloroRanchRaceAll";

		// Token: 0x0400164E RID: 5710
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400164F RID: 5711
		private static int HandleId;
	}
}
