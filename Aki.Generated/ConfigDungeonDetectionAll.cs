using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000241 RID: 577
	public class ConfigDungeonDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x000A617C File Offset: 0x000A437C
		static ConfigDungeonDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionAll.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000A619C File Offset: 0x000A439C
		public static void CreateStaticDefaultValue()
		{
			ConfigDungeonDetectionAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDungeonDetectionAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventure_detect.db"),
				new ValueTuple<string, object>("文件", "k.开拓探测.xlsx"),
				new ValueTuple<string, object>("表名", "DungeonDetection"),
				new ValueTuple<string, object>("语句", "select BinData from `DungeonDetection`")
			});
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000A621B File Offset: 0x000A441B
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionAll.LogPair = null;
			ConfigDungeonDetectionAll.HandleId = 0;
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000A6229 File Offset: 0x000A4429
		public static void Init()
		{
			ConfigDungeonDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection`");
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000A6244 File Offset: 0x000A4444
		[NullableContext(2)]
		public static IReadOnlyList<DungeonDetection> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDungeonDetectionAll.HandleId, ConfigDungeonDetectionAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DungeonDetection> readOnlyList = (IReadOnlyList<DungeonDetection>)ConfigCommon.GetConfig("DungeonDetectionAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DungeonDetection> list = new List<DungeonDetection>();
			while (ConfigCommon.Step(ConfigDungeonDetectionAll.HandleId, false, ConfigDungeonDetectionAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDungeonDetectionAll.HandleId, 0, ConfigDungeonDetectionAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDungeonDetectionAll.HandleId, ConfigDungeonDetectionAll.LogPair);
					return null;
				}
				DungeonDetection rootAsDungeonDetection = DungeonDetection.GetRootAsDungeonDetection(new ByteBuffer(item2));
				list.Add(rootAsDungeonDetection);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DungeonDetectionAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDungeonDetectionAll.HandleId, ConfigDungeonDetectionAll.LogPair);
			return list;
		}

		// Token: 0x04000FAB RID: 4011
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04000FAC RID: 4012
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04000FAD RID: 4013
		private const string TABLE = "DungeonDetection";

		// Token: 0x04000FAE RID: 4014
		private const string COMMAND = "select BinData from `DungeonDetection`";

		// Token: 0x04000FAF RID: 4015
		private const string KEY_PREFIX = "DungeonDetectionAll";

		// Token: 0x04000FB0 RID: 4016
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FB1 RID: 4017
		private static int HandleId;
	}
}
