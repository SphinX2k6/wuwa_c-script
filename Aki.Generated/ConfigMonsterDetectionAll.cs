using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200055E RID: 1374
	public class ConfigMonsterDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002041 RID: 8257 RVA: 0x001133FC File Offset: 0x001115FC
		static ConfigMonsterDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionAll.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0011341C File Offset: 0x0011161C
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDetectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDetectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "MonsterDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterDetection`")
			});
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0011349B File Offset: 0x0011169B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionAll.LogPair = null;
			ConfigMonsterDetectionAll.HandleId = 0;
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x001134A9 File Offset: 0x001116A9
		public static void Init()
		{
			ConfigMonsterDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection`");
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x001134C4 File Offset: 0x001116C4
		[NullableContext(2)]
		public static IReadOnlyList<MonsterDetection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterDetectionAll.HandleId, ConfigMonsterDetectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MonsterDetection> readOnlyList = (IReadOnlyList<MonsterDetection>)ConfigCommon.GetConfig("MonsterDetectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MonsterDetection> list = new List<MonsterDetection>();
			while (ConfigCommon.Step(ConfigMonsterDetectionAll.HandleId, false, ConfigMonsterDetectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterDetectionAll.HandleId, 0, ConfigMonsterDetectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterDetectionAll.HandleId, ConfigMonsterDetectionAll.LogPair);
					return null;
				}
				MonsterDetection rootAsMonsterDetection = MonsterDetection.GetRootAsMonsterDetection(new ByteBuffer(item2));
				list.Add(rootAsMonsterDetection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MonsterDetectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterDetectionAll.HandleId, ConfigMonsterDetectionAll.LogPair);
			return list;
		}

		// Token: 0x04002576 RID: 9590
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04002577 RID: 9591
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04002578 RID: 9592
		private const string TABLE = "MonsterDetection";

		// Token: 0x04002579 RID: 9593
		private const string COMMAND = "select BinData from `MonsterDetection`";

		// Token: 0x0400257A RID: 9594
		private const string KEY_PREFIX = "MonsterDetectionAll";

		// Token: 0x0400257B RID: 9595
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400257C RID: 9596
		private static int HandleId;
	}
}
