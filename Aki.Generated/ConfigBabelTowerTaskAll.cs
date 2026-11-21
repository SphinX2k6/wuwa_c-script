using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000EB RID: 235
	public class ConfigBabelTowerTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000583 RID: 1411 RVA: 0x0007C657 File Offset: 0x0007A857
		static ConfigBabelTowerTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBabelTowerTaskAll.CreateStaticDefaultValue), new Action(ConfigBabelTowerTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0007C678 File Offset: 0x0007A878
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

		// Token: 0x06000585 RID: 1413 RVA: 0x0007C6F7 File Offset: 0x0007A8F7
		public static void ResetStaticDefaultValue()
		{
			ConfigBabelTowerTaskAll.LogPair = null;
			ConfigBabelTowerTaskAll.HandleId = 0;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0007C705 File Offset: 0x0007A905
		public static void Init()
		{
			ConfigBabelTowerTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigBabelTowerTaskAll.HandleId, "db_babeltower.db", "select BinData from `BabelTowerTask`");
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0007C720 File Offset: 0x0007A920
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

		// Token: 0x04000651 RID: 1617
		private const string DB = "db_babeltower.db";

		// Token: 0x04000652 RID: 1618
		private const string FILE = "b.巴别塔活动.xlsx";

		// Token: 0x04000653 RID: 1619
		private const string TABLE = "BabelTowerTask";

		// Token: 0x04000654 RID: 1620
		private const string COMMAND = "select BinData from `BabelTowerTask`";

		// Token: 0x04000655 RID: 1621
		private const string KEY_PREFIX = "BabelTowerTaskAll";

		// Token: 0x04000656 RID: 1622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000657 RID: 1623
		private static int HandleId;
	}
}
