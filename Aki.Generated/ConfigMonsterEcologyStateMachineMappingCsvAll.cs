using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200054E RID: 1358
	public class ConfigMonsterEcologyStateMachineMappingCsvAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FE1 RID: 8161 RVA: 0x0010D9A9 File Offset: 0x0010BBA9
		static ConfigMonsterEcologyStateMachineMappingCsvAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterEcologyStateMachineMappingCsvAll.CreateStaticDefaultValue), new Action(ConfigMonsterEcologyStateMachineMappingCsvAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001FE2 RID: 8162 RVA: 0x0010D9C8 File Offset: 0x0010BBC8
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_monsterecologystatemachinemappingcsv.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.怪物生态状态机映射/*.csv*"),
				new ValueTuple<string, object>("表名", "MonsterEcologyStateMachineMappingCsv"),
				new ValueTuple<string, object>("语句", "select BinData from `MonsterEcologyStateMachineMappingCsv`")
			});
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x0010DA47 File Offset: 0x0010BC47
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair = null;
			ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId = 0;
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0010DA55 File Offset: 0x0010BC55
		public static void Init()
		{
			ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, "db_monsterecologystatemachinemappingcsv.db", "select BinData from `MonsterEcologyStateMachineMappingCsv`");
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x0010DA70 File Offset: 0x0010BC70
		[NullableContext(2)]
		public static IReadOnlyList<MonsterEcologyStateMachineMappingCsv> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MonsterEcologyStateMachineMappingCsv> readOnlyList = (IReadOnlyList<MonsterEcologyStateMachineMappingCsv>)ConfigCommon.GetConfig("MonsterEcologyStateMachineMappingCsvAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MonsterEcologyStateMachineMappingCsv> list = new List<MonsterEcologyStateMachineMappingCsv>();
			while (ConfigCommon.Step(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, false, ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, 0, ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair);
					return null;
				}
				MonsterEcologyStateMachineMappingCsv rootAsMonsterEcologyStateMachineMappingCsv = MonsterEcologyStateMachineMappingCsv.GetRootAsMonsterEcologyStateMachineMappingCsv(new ByteBuffer(item2));
				list.Add(rootAsMonsterEcologyStateMachineMappingCsv);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MonsterEcologyStateMachineMappingCsvAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair);
			return list;
		}

		// Token: 0x04002506 RID: 9478
		private const string DB = "db_monsterecologystatemachinemappingcsv.db";

		// Token: 0x04002507 RID: 9479
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物生态状态机映射/*.csv*";

		// Token: 0x04002508 RID: 9480
		private const string TABLE = "MonsterEcologyStateMachineMappingCsv";

		// Token: 0x04002509 RID: 9481
		private const string COMMAND = "select BinData from `MonsterEcologyStateMachineMappingCsv`";

		// Token: 0x0400250A RID: 9482
		private const string KEY_PREFIX = "MonsterEcologyStateMachineMappingCsvAll";

		// Token: 0x0400250B RID: 9483
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400250C RID: 9484
		private static int HandleId;
	}
}
