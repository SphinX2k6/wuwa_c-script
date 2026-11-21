using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060D RID: 1549
	public class ConfigNewPlayerSupportTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600245D RID: 9309 RVA: 0x0012A8F4 File Offset: 0x00128AF4
		static ConfigNewPlayerSupportTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportTaskAll.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0012A914 File Offset: 0x00128B14
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupportTaskAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupport.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupportTask"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupportTask`")
			});
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0012A993 File Offset: 0x00128B93
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskAll.LogPair = null;
			ConfigNewPlayerSupportTaskAll.HandleId = 0;
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0012A9A1 File Offset: 0x00128BA1
		public static void Init()
		{
			ConfigNewPlayerSupportTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportTaskAll.HandleId, "db_newplayersupport.db", "select BinData from `NewPlayerSupportTask`");
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0012A9BC File Offset: 0x00128BBC
		[NullableContext(2)]
		public static IReadOnlyList<NewPlayerSupportTask> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupportTaskAll.HandleId, ConfigNewPlayerSupportTaskAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewPlayerSupportTask> readOnlyList = (IReadOnlyList<NewPlayerSupportTask>)ConfigCommon.GetConfig("NewPlayerSupportTaskAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewPlayerSupportTask> list = new List<NewPlayerSupportTask>();
			while (ConfigCommon.Step(ConfigNewPlayerSupportTaskAll.HandleId, false, ConfigNewPlayerSupportTaskAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupportTaskAll.HandleId, 0, ConfigNewPlayerSupportTaskAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewPlayerSupportTaskAll.HandleId, ConfigNewPlayerSupportTaskAll.LogPair);
					return null;
				}
				NewPlayerSupportTask rootAsNewPlayerSupportTask = NewPlayerSupportTask.GetRootAsNewPlayerSupportTask(new ByteBuffer(item2));
				list.Add(rootAsNewPlayerSupportTask);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewPlayerSupportTaskAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupportTaskAll.HandleId, ConfigNewPlayerSupportTaskAll.LogPair);
			return list;
		}

		// Token: 0x04002A41 RID: 10817
		private const string DB = "db_newplayersupport.db";

		// Token: 0x04002A42 RID: 10818
		private const string FILE = "x.新玩家助力活动.xlsx";

		// Token: 0x04002A43 RID: 10819
		private const string TABLE = "NewPlayerSupportTask";

		// Token: 0x04002A44 RID: 10820
		private const string COMMAND = "select BinData from `NewPlayerSupportTask`";

		// Token: 0x04002A45 RID: 10821
		private const string KEY_PREFIX = "NewPlayerSupportTaskAll";

		// Token: 0x04002A46 RID: 10822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A47 RID: 10823
		private static int HandleId;
	}
}
