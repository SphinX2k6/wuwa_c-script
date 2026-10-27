using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000748 RID: 1864
	public class ConfigPlayStationStaticActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002BC1 RID: 11201 RVA: 0x00150D5F File Offset: 0x0014EF5F
		static ConfigPlayStationStaticActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayStationStaticActivityAll.CreateStaticDefaultValue), new Action(ConfigPlayStationStaticActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002BC2 RID: 11202 RVA: 0x00150D80 File Offset: 0x0014EF80
		public static void CreateStaticDefaultValue()
		{
			ConfigPlayStationStaticActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlayStationStaticActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_quest.db"),
				new ValueTuple<string, object>("文件", "r.任务.xlsx"),
				new ValueTuple<string, object>("表名", "PlayStationStaticActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `PlayStationStaticActivity`")
			});
		}

		// Token: 0x06002BC3 RID: 11203 RVA: 0x00150DFF File Offset: 0x0014EFFF
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayStationStaticActivityAll.LogPair = null;
			ConfigPlayStationStaticActivityAll.HandleId = 0;
		}

		// Token: 0x06002BC4 RID: 11204 RVA: 0x00150E0D File Offset: 0x0014F00D
		public static void Init()
		{
			ConfigPlayStationStaticActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayStationStaticActivityAll.HandleId, "db_quest.db", "select BinData from `PlayStationStaticActivity`");
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x00150E28 File Offset: 0x0014F028
		[NullableContext(2)]
		public static IReadOnlyList<PlayStationStaticActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlayStationStaticActivityAll.HandleId, ConfigPlayStationStaticActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<PlayStationStaticActivity> readOnlyList = (IReadOnlyList<PlayStationStaticActivity>)ConfigCommon.GetConfig("PlayStationStaticActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<PlayStationStaticActivity> list = new List<PlayStationStaticActivity>();
			while (ConfigCommon.Step(ConfigPlayStationStaticActivityAll.HandleId, false, ConfigPlayStationStaticActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlayStationStaticActivityAll.HandleId, 0, ConfigPlayStationStaticActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigPlayStationStaticActivityAll.HandleId, ConfigPlayStationStaticActivityAll.LogPair);
					return null;
				}
				PlayStationStaticActivity rootAsPlayStationStaticActivity = PlayStationStaticActivity.GetRootAsPlayStationStaticActivity(new ByteBuffer(item2));
				list.Add(rootAsPlayStationStaticActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("PlayStationStaticActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigPlayStationStaticActivityAll.HandleId, ConfigPlayStationStaticActivityAll.LogPair);
			return list;
		}

		// Token: 0x040032DE RID: 13022
		private const string DB = "db_quest.db";

		// Token: 0x040032DF RID: 13023
		private const string FILE = "r.任务.xlsx";

		// Token: 0x040032E0 RID: 13024
		private const string TABLE = "PlayStationStaticActivity";

		// Token: 0x040032E1 RID: 13025
		private const string COMMAND = "select BinData from `PlayStationStaticActivity`";

		// Token: 0x040032E2 RID: 13026
		private const string KEY_PREFIX = "PlayStationStaticActivityAll";

		// Token: 0x040032E3 RID: 13027
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040032E4 RID: 13028
		private static int HandleId;
	}
}
