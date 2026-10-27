using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000548 RID: 1352
	public class ConfigMonsterDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FBD RID: 8125 RVA: 0x0010CCA8 File Offset: 0x0010AEA8
		static ConfigMonsterDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDetectionAll.CreateStaticDefaultValue), new Action(ConfigMonsterDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FBE RID: 8126 RVA: 0x0010CCC8 File Offset: 0x0010AEC8
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

		// Token: 0x06001FBF RID: 8127 RVA: 0x0010CD47 File Offset: 0x0010AF47
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDetectionAll.LogPair = null;
			ConfigMonsterDetectionAll.HandleId = 0;
		}

		// Token: 0x06001FC0 RID: 8128 RVA: 0x0010CD55 File Offset: 0x0010AF55
		public static void Init()
		{
			ConfigMonsterDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `MonsterDetection`");
		}

		// Token: 0x06001FC1 RID: 8129 RVA: 0x0010CD70 File Offset: 0x0010AF70
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

		// Token: 0x040024DC RID: 9436
		private const string DB = "db_adventure_detect.db";

		// Token: 0x040024DD RID: 9437
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x040024DE RID: 9438
		private const string TABLE = "MonsterDetection";

		// Token: 0x040024DF RID: 9439
		private const string COMMAND = "select BinData from `MonsterDetection`";

		// Token: 0x040024E0 RID: 9440
		private const string KEY_PREFIX = "MonsterDetectionAll";

		// Token: 0x040024E1 RID: 9441
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040024E2 RID: 9442
		private static int HandleId;
	}
}
