using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DC RID: 220
	public class ConfigBabelTowerDailyTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x0007A780 File Offset: 0x00078980
		static ConfigBabelTowerDailyTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDailyTaskAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDailyTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0007A7A0 File Offset: 0x000789A0
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerDailyTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerDailyTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerDailyTask`")
			});
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0007A81F File Offset: 0x00078A1F
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskAll.LogPair = null;
			ConfigBabelTowerDailyTaskAll.HandleId = 0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0007A82D File Offset: 0x00078A2D
		public static void Init()
		{
			ConfigBabelTowerDailyTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDailyTaskAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDailyTask`");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0007A848 File Offset: 0x00078A48
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerDailyTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerDailyTaskAll.HandleId, ConfigBabelTowerDailyTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerDailyTask> readOnlyList = (IReadOnlyList<BabelTowerDailyTask>)ConfigCommon.GetConfig("BabelTowerDailyTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerDailyTask> list = new List<BabelTowerDailyTask>();
			while (ConfigCommon.Step(ConfigBabelTowerDailyTaskAll.HandleId, false, ConfigBabelTowerDailyTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerDailyTaskAll.HandleId, 0, ConfigBabelTowerDailyTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerDailyTaskAll.HandleId, ConfigBabelTowerDailyTaskAll.LogPair);
					return null;
				}
				BabelTowerDailyTask rootAsBabelTowerDailyTask = BabelTowerDailyTask.GetRootAsBabelTowerDailyTask(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerDailyTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerDailyTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerDailyTaskAll.HandleId, ConfigBabelTowerDailyTaskAll.LogPair);
			return list;
		}

		// Token: 0x040005E8 RID: 1512
		private const string DB = "db_babeltower.db";

		// Token: 0x040005E9 RID: 1513
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005EA RID: 1514
		private const string TABLE = "BabelTowerDailyTask";

		// Token: 0x040005EB RID: 1515
		private const string COMMAND = "select BinData from `BabelTowerDailyTask`";

		// Token: 0x040005EC RID: 1516
		private const string KEY_PREFIX = "BabelTowerDailyTaskAll";

		// Token: 0x040005ED RID: 1517
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040005EE RID: 1518
		private static int HandleId;
	}
}
