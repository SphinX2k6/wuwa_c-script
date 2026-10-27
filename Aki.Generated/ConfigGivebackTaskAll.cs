using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039E RID: 926
	public class ConfigGivebackTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x000D4764 File Offset: 0x000D2964
		static ConfigGivebackTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackTaskAll.CreateStaticDefaultValue), new Action(ConfigGivebackTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x000D4784 File Offset: 0x000D2984
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackTask"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackTask`")
			});
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x000D4803 File Offset: 0x000D2A03
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackTaskAll.LogPair = null;
			ConfigGivebackTaskAll.HandleId = 0;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x000D4811 File Offset: 0x000D2A11
		public static void Init()
		{
			ConfigGivebackTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackTaskAll.HandleId, "db_feedbackreward.db", "select BinData from `GivebackTask`");
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x000D482C File Offset: 0x000D2A2C
		[NullableContext(2)]
		public static IReadOnlyList<GivebackTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackTaskAll.HandleId, ConfigGivebackTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GivebackTask> readOnlyList = (IReadOnlyList<GivebackTask>)ConfigCommon.GetConfig("GivebackTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GivebackTask> list = new List<GivebackTask>();
			while (ConfigCommon.Step(ConfigGivebackTaskAll.HandleId, false, ConfigGivebackTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackTaskAll.HandleId, 0, ConfigGivebackTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGivebackTaskAll.HandleId, ConfigGivebackTaskAll.LogPair);
					return null;
				}
				GivebackTask rootAsGivebackTask = GivebackTask.GetRootAsGivebackTask(new ByteBuffer(item2));
				list.Add(rootAsGivebackTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GivebackTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGivebackTaskAll.HandleId, ConfigGivebackTaskAll.LogPair);
			return list;
		}

		// Token: 0x04001936 RID: 6454
		private const string DB = "db_feedbackreward.db";

		// Token: 0x04001937 RID: 6455
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x04001938 RID: 6456
		private const string TABLE = "GivebackTask";

		// Token: 0x04001939 RID: 6457
		private const string COMMAND = "select BinData from `GivebackTask`";

		// Token: 0x0400193A RID: 6458
		private const string KEY_PREFIX = "GivebackTaskAll";

		// Token: 0x0400193B RID: 6459
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400193C RID: 6460
		private static int HandleId;
	}
}
