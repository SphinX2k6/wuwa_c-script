using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054B RID: 1355
	public class ConfigMonsterDetectionFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FCF RID: 8143 RVA: 0x0010D2CC File Offset: 0x0010B4CC
		static ConfigMonsterDetectionFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionFilterAll.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x0010D2EC File Offset: 0x0010B4EC
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDetectionFilterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDetectionFilterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterDetectionFilter"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDetectionFilter`")
			});
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x0010D36B File Offset: 0x0010B56B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionFilterAll.LogPair = null;
			ConfigMonsterDetectionFilterAll.HandleId = 0;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x0010D379 File Offset: 0x0010B579
		public static void Init()
		{
			ConfigMonsterDetectionFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionFilterAll.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetectionFilter`");
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x0010D394 File Offset: 0x0010B594
		[NullableContext(2)]
		public static IReadOnlyList<MonsterDetectionFilter> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDetectionFilterAll.HandleId, ConfigMonsterDetectionFilterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MonsterDetectionFilter> readOnlyList = (IReadOnlyList<MonsterDetectionFilter>)ConfigCommon.GetConfig("MonsterDetectionFilterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MonsterDetectionFilter> list = new List<MonsterDetectionFilter>();
			while (ConfigCommon.Step(ConfigMonsterDetectionFilterAll.HandleId, false, ConfigMonsterDetectionFilterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDetectionFilterAll.HandleId, 0, ConfigMonsterDetectionFilterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterDetectionFilterAll.HandleId, ConfigMonsterDetectionFilterAll.LogPair);
					return null;
				}
				MonsterDetectionFilter rootAsMonsterDetectionFilter = MonsterDetectionFilter.GetRootAsMonsterDetectionFilter(new ByteBuffer(item2));
				list.Add(rootAsMonsterDetectionFilter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MonsterDetectionFilterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterDetectionFilterAll.HandleId, ConfigMonsterDetectionFilterAll.LogPair);
			return list;
		}

		// Token: 0x040024F1 RID: 9457
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040024F2 RID: 9458
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040024F3 RID: 9459
		private const string TABLE = "MonsterDetectionFilter";

		// Token: 0x040024F4 RID: 9460
		private const string COMMAND = "select BinData from `MonsterDetectionFilter`";

		// Token: 0x040024F5 RID: 9461
		private const string KEY_PREFIX = "MonsterDetectionFilterAll";

		// Token: 0x040024F6 RID: 9462
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024F7 RID: 9463
		private static int HandleId;
	}
}
