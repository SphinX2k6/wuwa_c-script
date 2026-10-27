using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000DC RID: 220
	public class ConfigBabelTowerTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000529 RID: 1321 RVA: 0x00076CF3 File Offset: 0x00074EF3
		static ConfigBabelTowerTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerTaskAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00076D14 File Offset: 0x00074F14
		public static void CreateStaticDefaultValue()
		{
			ConfigBabelTowerTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBabelTowerTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_babeltower.db"),
				new ValueTuple<string, object>("文件", "b.巴别塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "BabelTowerTask"),
				new ValueTuple<string, object>("语句", "select BinData from `BabelTowerTask`")
			});
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00076D93 File Offset: 0x00074F93
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerTaskAll.LogPair = null;
			ConfigBabelTowerTaskAll.HandleId = 0;
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00076DA1 File Offset: 0x00074FA1
		public static void Init()
		{
			ConfigBabelTowerTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerTaskAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerTask`");
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00076DBC File Offset: 0x00074FBC
		[NullableContext(2)]
		public static IReadOnlyList<BabelTowerTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBabelTowerTaskAll.HandleId, ConfigBabelTowerTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<BabelTowerTask> readOnlyList = (IReadOnlyList<BabelTowerTask>)ConfigCommon.GetConfig("BabelTowerTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<BabelTowerTask> list = new List<BabelTowerTask>();
			while (ConfigCommon.Step(ConfigBabelTowerTaskAll.HandleId, false, ConfigBabelTowerTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBabelTowerTaskAll.HandleId, 0, ConfigBabelTowerTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigBabelTowerTaskAll.HandleId, ConfigBabelTowerTaskAll.LogPair);
					return null;
				}
				BabelTowerTask rootAsBabelTowerTask = BabelTowerTask.GetRootAsBabelTowerTask(new ByteBuffer(item2));
				list.Add(rootAsBabelTowerTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("BabelTowerTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigBabelTowerTaskAll.HandleId, ConfigBabelTowerTaskAll.LogPair);
			return list;
		}

		// Token: 0x040005E8 RID: 1512
		private const string DB = "db_babeltower.db";

		// Token: 0x040005E9 RID: 1513
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x040005EA RID: 1514
		private const string TABLE = "BabelTowerTask";

		// Token: 0x040005EB RID: 1515
		private const string COMMAND = "select BinData from `BabelTowerTask`";

		// Token: 0x040005EC RID: 1516
		private const string KEY_PREFIX = "BabelTowerTaskAll";

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
