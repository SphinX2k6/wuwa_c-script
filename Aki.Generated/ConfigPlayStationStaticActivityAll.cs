using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000760 RID: 1888
	public class ConfigPlayStationStaticActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C51 RID: 11345 RVA: 0x001577DB File Offset: 0x001559DB
		static ConfigPlayStationStaticActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlayStationStaticActivityAll.CreateStaticDefaultValue), new Action(ConfigPlayStationStaticActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C52 RID: 11346 RVA: 0x001577FC File Offset: 0x001559FC
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

		// Token: 0x06002C53 RID: 11347 RVA: 0x0015787B File Offset: 0x00155A7B
		public static void ResetStaticDefaultValue()
		{
			ConfigPlayStationStaticActivityAll.LogPair = null;
			ConfigPlayStationStaticActivityAll.HandleId = 0;
		}

		// Token: 0x06002C54 RID: 11348 RVA: 0x00157889 File Offset: 0x00155A89
		public static void Init()
		{
			ConfigPlayStationStaticActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigPlayStationStaticActivityAll.HandleId, "db_quest.db", "select BinData from `PlayStationStaticActivity`");
		}

		// Token: 0x06002C55 RID: 11349 RVA: 0x001578A4 File Offset: 0x00155AA4
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

		// Token: 0x04003386 RID: 13190
		private const string DB = "db_quest.db";

		// Token: 0x04003387 RID: 13191
		private const string FILE = "r.任务.xlsx";

		// Token: 0x04003388 RID: 13192
		private const string TABLE = "PlayStationStaticActivity";

		// Token: 0x04003389 RID: 13193
		private const string COMMAND = "select BinData from `PlayStationStaticActivity`";

		// Token: 0x0400338A RID: 13194
		private const string KEY_PREFIX = "PlayStationStaticActivityAll";

		// Token: 0x0400338B RID: 13195
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400338C RID: 13196
		private static int HandleId;
	}
}
