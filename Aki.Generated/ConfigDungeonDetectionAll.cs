using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000255 RID: 597
	public class ConfigDungeonDetectionAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E02 RID: 3586 RVA: 0x000AC441 File Offset: 0x000AA641
		static ConfigDungeonDetectionAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDungeonDetectionAll.CreateStaticDefaultValue), new Action(ConfigDungeonDetectionAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x000AC460 File Offset: 0x000AA660
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

		// Token: 0x06000E04 RID: 3588 RVA: 0x000AC4DF File Offset: 0x000AA6DF
		public static void ResetStaticDefaultValue()
		{
			ConfigDungeonDetectionAll.LogPair = null;
			ConfigDungeonDetectionAll.HandleId = 0;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x000AC4ED File Offset: 0x000AA6ED
		public static void Init()
		{
			ConfigDungeonDetectionAll.HandleId = ConfigCommon.InitDataStatement(ConfigDungeonDetectionAll.HandleId, "db_adventure_detect.db", "select BinData from `DungeonDetection`");
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x000AC508 File Offset: 0x000AA708
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

		// Token: 0x04001037 RID: 4151
		private const string DB = "db_adventure_detect.db";

		// Token: 0x04001038 RID: 4152
		private const string FILE = "k.开拓探测.xlsx";

		// Token: 0x04001039 RID: 4153
		private const string TABLE = "DungeonDetection";

		// Token: 0x0400103A RID: 4154
		private const string COMMAND = "select BinData from `DungeonDetection`";

		// Token: 0x0400103B RID: 4155
		private const string KEY_PREFIX = "DungeonDetectionAll";

		// Token: 0x0400103C RID: 4156
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400103D RID: 4157
		private static int HandleId;
	}
}
