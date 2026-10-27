using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CD RID: 205
	public class ConfigBabelTowerDailyTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004CF RID: 1231 RVA: 0x00074E1C File Offset: 0x0007301C
		static ConfigBabelTowerDailyTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerDailyTaskAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerDailyTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00074E3C File Offset: 0x0007303C
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

		// Token: 0x060004D1 RID: 1233 RVA: 0x00074EBB File Offset: 0x000730BB
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerDailyTaskAll.LogPair = null;
			ConfigBabelTowerDailyTaskAll.HandleId = 0;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00074EC9 File Offset: 0x000730C9
		public static void Init()
		{
			ConfigBabelTowerDailyTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerDailyTaskAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerDailyTask`");
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00074EE4 File Offset: 0x000730E4
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

		// Token: 0x0400057F RID: 1407
		private const string DB = "db_babeltower.db";

		// Token: 0x04000580 RID: 1408
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000581 RID: 1409
		private const string TABLE = "BabelTowerDailyTask";

		// Token: 0x04000582 RID: 1410
		private const string COMMAND = "select BinData from `BabelTowerDailyTask`";

		// Token: 0x04000583 RID: 1411
		private const string KEY_PREFIX = "BabelTowerDailyTaskAll";

		// Token: 0x04000584 RID: 1412
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000585 RID: 1413
		private static int HandleId;
	}
}
