using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F5 RID: 1525
	public class ConfigNewPlayerSupportTaskAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023CD RID: 9165 RVA: 0x00123E78 File Offset: 0x00122078
		static ConfigNewPlayerSupportTaskAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupportTaskAll.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupportTaskAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00123E98 File Offset: 0x00122098
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

		// Token: 0x060023CF RID: 9167 RVA: 0x00123F17 File Offset: 0x00122117
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupportTaskAll.LogPair = null;
			ConfigNewPlayerSupportTaskAll.HandleId = 0;
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00123F25 File Offset: 0x00122125
		public static void Init()
		{
			ConfigNewPlayerSupportTaskAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupportTaskAll.HandleId, "db_newplayersupport.db", "select BinData from `NewPlayerSupportTask`");
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00123F40 File Offset: 0x00122140
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

		// Token: 0x04002999 RID: 10649
		private const string DB = "db_newplayersupport.db";

		// Token: 0x0400299A RID: 10650
		private const string FILE = "x.新玩家助力活动.xlsx";

		// Token: 0x0400299B RID: 10651
		private const string TABLE = "NewPlayerSupportTask";

		// Token: 0x0400299C RID: 10652
		private const string COMMAND = "select BinData from `NewPlayerSupportTask`";

		// Token: 0x0400299D RID: 10653
		private const string KEY_PREFIX = "NewPlayerSupportTaskAll";

		// Token: 0x0400299E RID: 10654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400299F RID: 10655
		private static int HandleId;
	}
}
