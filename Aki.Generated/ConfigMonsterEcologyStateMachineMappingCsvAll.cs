using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000564 RID: 1380
	public class ConfigMonsterEcologyStateMachineMappingCsvAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x001140FD File Offset: 0x001122FD
		static ConfigMonsterEcologyStateMachineMappingCsvAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterEcologyStateMachineMappingCsvAll.CreateStaticDefaultValue), new Action(ConfigMonsterEcologyStateMachineMappingCsvAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0011411C File Offset: 0x0011231C
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

		// Token: 0x06002067 RID: 8295 RVA: 0x0011419B File Offset: 0x0011239B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterEcologyStateMachineMappingCsvAll.LogPair = null;
			ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId = 0;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x001141A9 File Offset: 0x001123A9
		public static void Init()
		{
			ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId = ConfigCommon.InitDataStatement(ConfigMonsterEcologyStateMachineMappingCsvAll.HandleId, "db_monsterecologystatemachinemappingcsv.db", "select BinData from `MonsterEcologyStateMachineMappingCsv`");
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x001141C4 File Offset: 0x001123C4
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

		// Token: 0x040025A0 RID: 9632
		private const string DB = "db_monsterecologystatemachinemappingcsv.db";

		// Token: 0x040025A1 RID: 9633
		private const string FILE = "k.可视化编辑/c.Csv/g.怪物生态状态机映射/*.csv*";

		// Token: 0x040025A2 RID: 9634
		private const string TABLE = "MonsterEcologyStateMachineMappingCsv";

		// Token: 0x040025A3 RID: 9635
		private const string COMMAND = "select BinData from `MonsterEcologyStateMachineMappingCsv`";

		// Token: 0x040025A4 RID: 9636
		private const string KEY_PREFIX = "MonsterEcologyStateMachineMappingCsvAll";

		// Token: 0x040025A5 RID: 9637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025A6 RID: 9638
		private static int HandleId;
	}
}
