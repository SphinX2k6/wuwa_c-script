using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005EE RID: 1518
	public class ConfigNewbieMainActTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023A3 RID: 9123 RVA: 0x001230FC File Offset: 0x001212FC
		static ConfigNewbieMainActTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskAll.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0012311C File Offset: 0x0012131C
		public static void CreateStaticDefaultValue()
		{
			ConfigNewbieMainActTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewbieMainActTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新手主线奖励新.xlsx"),
				new ValueTuple<string, object>("表名", "NewbieMainActTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewbieMainActTask`")
			});
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0012319B File Offset: 0x0012139B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskAll.LogPair = null;
			ConfigNewbieMainActTaskAll.HandleId = 0;
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x001231A9 File Offset: 0x001213A9
		public static void Init()
		{
			ConfigNewbieMainActTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskAll.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask`");
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x001231C4 File Offset: 0x001213C4
		[NullableContext(2)]
		public static IReadOnlyList<NewbieMainActTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewbieMainActTaskAll.HandleId, ConfigNewbieMainActTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewbieMainActTask> readOnlyList = (IReadOnlyList<NewbieMainActTask>)ConfigCommon.GetConfig("NewbieMainActTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewbieMainActTask> list = new List<NewbieMainActTask>();
			while (ConfigCommon.Step(ConfigNewbieMainActTaskAll.HandleId, false, ConfigNewbieMainActTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewbieMainActTaskAll.HandleId, 0, ConfigNewbieMainActTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewbieMainActTaskAll.HandleId, ConfigNewbieMainActTaskAll.LogPair);
					return null;
				}
				NewbieMainActTask rootAsNewbieMainActTask = NewbieMainActTask.GetRootAsNewbieMainActTask(new ByteBuffer(item2));
				list.Add(rootAsNewbieMainActTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewbieMainActTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewbieMainActTaskAll.HandleId, ConfigNewbieMainActTaskAll.LogPair);
			return list;
		}

		// Token: 0x04002968 RID: 10600
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002969 RID: 10601
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x0400296A RID: 10602
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x0400296B RID: 10603
		private const string COMMAND = "select BinData from `NewbieMainActTask`";

		// Token: 0x0400296C RID: 10604
		private const string KEY_PREFIX = "NewbieMainActTaskAll";

		// Token: 0x0400296D RID: 10605
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400296E RID: 10606
		private static int HandleId;
	}
}
