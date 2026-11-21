using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000606 RID: 1542
	public class ConfigNewbieMainActTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002433 RID: 9267 RVA: 0x00129B78 File Offset: 0x00127D78
		static ConfigNewbieMainActTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewbieMainActTaskAll.CreateStaticDefaultValue), new Action(ConfigNewbieMainActTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x00129B98 File Offset: 0x00127D98
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

		// Token: 0x06002435 RID: 9269 RVA: 0x00129C17 File Offset: 0x00127E17
		public static void ResetStaticDefaultValue()
		{
			ConfigNewbieMainActTaskAll.LogPair = null;
			ConfigNewbieMainActTaskAll.HandleId = 0;
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x00129C25 File Offset: 0x00127E25
		public static void Init()
		{
			ConfigNewbieMainActTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewbieMainActTaskAll.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewbieMainActTask`");
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x00129C40 File Offset: 0x00127E40
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

		// Token: 0x04002A10 RID: 10768
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A11 RID: 10769
		private const string FILE = "x.新手主线奖励新.xlsx";

		// Token: 0x04002A12 RID: 10770
		private const string TABLE = "NewbieMainActTask";

		// Token: 0x04002A13 RID: 10771
		private const string COMMAND = "select BinData from `NewbieMainActTask`";

		// Token: 0x04002A14 RID: 10772
		private const string KEY_PREFIX = "NewbieMainActTaskAll";

		// Token: 0x04002A15 RID: 10773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A16 RID: 10774
		private static int HandleId;
	}
}
