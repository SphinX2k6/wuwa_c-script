using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200005B RID: 91
	public class ConfigAdventureTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00065CB0 File Offset: 0x00063EB0
		static ConfigAdventureTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdventureTaskAll.CreateStaticDefaultValue), new Action(ConfigAdventureTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00065CD0 File Offset: 0x00063ED0
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

		// Token: 0x06000224 RID: 548 RVA: 0x00065D4F File Offset: 0x00063F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigAdventureTaskAll.LogPair = null;
			ConfigAdventureTaskAll.HandleId = 0;
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00065D5D File Offset: 0x00063F5D
		public static void Init()
		{
			ConfigAdventureTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdventureTaskAll.HandleId, "db_adventuretask.db", "select BinData from `AdventureTask`");
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00065D78 File Offset: 0x00063F78
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

		// Token: 0x04000261 RID: 609
		private const string DB = "db_adventuretask.db";

		// Token: 0x04000262 RID: 610
		private const string FILE = "k.开拓任务.xlsx";

		// Token: 0x04000263 RID: 611
		private const string TABLE = "AdventureTask";

		// Token: 0x04000264 RID: 612
		private const string COMMAND = "select BinData from `AdventureTask`";

		// Token: 0x04000265 RID: 613
		private const string KEY_PREFIX = "AdventureTaskAll";

		// Token: 0x04000266 RID: 614
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000267 RID: 615
		private static int HandleId;
	}
}
