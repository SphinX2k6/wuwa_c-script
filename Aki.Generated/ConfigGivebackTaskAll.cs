using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B4 RID: 948
	public class ConfigGivebackTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x000DAEB8 File Offset: 0x000D90B8
		static ConfigGivebackTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackTaskAll.CreateStaticDefaultValue), new Action(ConfigGivebackTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000DAED8 File Offset: 0x000D90D8
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

		// Token: 0x06001641 RID: 5697 RVA: 0x000DAF57 File Offset: 0x000D9157
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackTaskAll.LogPair = null;
			ConfigGivebackTaskAll.HandleId = 0;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000DAF65 File Offset: 0x000D9165
		public static void Init()
		{
			ConfigGivebackTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackTaskAll.HandleId, "db_feedbackreward.db", "select BinData from `GivebackTask`");
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000DAF80 File Offset: 0x000D9180
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

		// Token: 0x040019D0 RID: 6608
		private const string DB = "db_feedbackreward.db";

		// Token: 0x040019D1 RID: 6609
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x040019D2 RID: 6610
		private const string TABLE = "GivebackTask";

		// Token: 0x040019D3 RID: 6611
		private const string COMMAND = "select BinData from `GivebackTask`";

		// Token: 0x040019D4 RID: 6612
		private const string KEY_PREFIX = "GivebackTaskAll";

		// Token: 0x040019D5 RID: 6613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019D6 RID: 6614
		private static int HandleId;
	}
}
