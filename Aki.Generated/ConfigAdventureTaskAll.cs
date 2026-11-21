using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000063 RID: 99
	public class ConfigAdventureTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000252 RID: 594 RVA: 0x0006A564 File Offset: 0x00068764
		static ConfigAdventureTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskAll.CreateStaticDefaultValue), new Action(ConfigAdventureTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0006A584 File Offset: 0x00068784
		public static void CreateStaticDefaultValue()
		{
			ConfigAdventureTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdventureTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_adventuretask.db"),
				new ValueTuple<string, object>("文件", "k.开拓任务.xlsx"),
				new ValueTuple<string, object>("表名", "AdventureTask"),
				new ValueTuple<string, object>("语句", "select BinData from `AdventureTask`")
			});
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0006A603 File Offset: 0x00068803
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskAll.LogPair = null;
			ConfigAdventureTaskAll.HandleId = 0;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0006A611 File Offset: 0x00068811
		public static void Init()
		{
			ConfigAdventureTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskAll.HandleId, "db_adventuretask.db", "select BinData from `AdventureTask`");
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0006A62C File Offset: 0x0006882C
		[NullableContext(2)]
		public static IReadOnlyList<AdventureTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdventureTaskAll.HandleId, ConfigAdventureTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdventureTask> readOnlyList = (IReadOnlyList<AdventureTask>)ConfigCommon.GetConfig("AdventureTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdventureTask> list = new List<AdventureTask>();
			while (ConfigCommon.Step(ConfigAdventureTaskAll.HandleId, false, ConfigAdventureTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdventureTaskAll.HandleId, 0, ConfigAdventureTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdventureTaskAll.HandleId, ConfigAdventureTaskAll.LogPair);
					return null;
				}
				AdventureTask rootAsAdventureTask = AdventureTask.GetRootAsAdventureTask(new ByteBuffer(item2));
				list.Add(rootAsAdventureTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdventureTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdventureTaskAll.HandleId, ConfigAdventureTaskAll.LogPair);
			return list;
		}

		// Token: 0x04000299 RID: 665
		private const string DB = "db_adventuretask.db";

		// Token: 0x0400029A RID: 666
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x0400029B RID: 667
		private const string TABLE = "AdventureTask";

		// Token: 0x0400029C RID: 668
		private const string COMMAND = "select BinData from `AdventureTask`";

		// Token: 0x0400029D RID: 669
		private const string KEY_PREFIX = "AdventureTaskAll";

		// Token: 0x0400029E RID: 670
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400029F RID: 671
		private static int HandleId;
	}
}
