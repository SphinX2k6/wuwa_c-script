using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000561 RID: 1377
	public class ConfigMonsterDetectionFilterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002053 RID: 8275 RVA: 0x00113A20 File Offset: 0x00111C20
		static ConfigMonsterDetectionFilterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionFilterAll.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionFilterAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00113A40 File Offset: 0x00111C40
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

		// Token: 0x06002055 RID: 8277 RVA: 0x00113ABF File Offset: 0x00111CBF
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionFilterAll.LogPair = null;
			ConfigMonsterDetectionFilterAll.HandleId = 0;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00113ACD File Offset: 0x00111CCD
		public static void Init()
		{
			ConfigMonsterDetectionFilterAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionFilterAll.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetectionFilter`");
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00113AE8 File Offset: 0x00111CE8
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

		// Token: 0x0400258B RID: 9611
		private const string DB = "db_adventure_detect.db";

		// Token: 0x0400258C RID: 9612
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x0400258D RID: 9613
		private const string TABLE = "MonsterDetectionFilter";

		// Token: 0x0400258E RID: 9614
		private const string COMMAND = "select BinData from `MonsterDetectionFilter`";

		// Token: 0x0400258F RID: 9615
		private const string KEY_PREFIX = "MonsterDetectionFilterAll";

		// Token: 0x04002590 RID: 9616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002591 RID: 9617
		private static int HandleId;
	}
}
