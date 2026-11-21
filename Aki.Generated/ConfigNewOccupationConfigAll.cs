using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000609 RID: 1545
	public class ConfigNewOccupationConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002445 RID: 9285 RVA: 0x0012A18B File Offset: 0x0012838B
		static ConfigNewOccupationConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewOccupationConfigAll.CreateStaticDefaultValue), new Action(ConfigNewOccupationConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0012A1AC File Offset: 0x001283AC
		public static void CreateStaticDefaultValue()
		{
			ConfigNewOccupationConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewOccupationConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_new_occupation.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv"),
				new ValueTuple<string, object>("表名", "NewOccupationConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `NewOccupationConfig`")
			});
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x0012A22B File Offset: 0x0012842B
		public static void ResetStaticDefaultValue()
		{
			ConfigNewOccupationConfigAll.LogPair = null;
			ConfigNewOccupationConfigAll.HandleId = 0;
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x0012A239 File Offset: 0x00128439
		public static void Init()
		{
			ConfigNewOccupationConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewOccupationConfigAll.HandleId, "db_new_occupation.db", "select BinData from `NewOccupationConfig`");
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x0012A254 File Offset: 0x00128454
		[NullableContext(2)]
		public static IReadOnlyList<NewOccupationConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewOccupationConfigAll.HandleId, ConfigNewOccupationConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<NewOccupationConfig> readOnlyList = (IReadOnlyList<NewOccupationConfig>)ConfigCommon.GetConfig("NewOccupationConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<NewOccupationConfig> list = new List<NewOccupationConfig>();
			while (ConfigCommon.Step(ConfigNewOccupationConfigAll.HandleId, false, ConfigNewOccupationConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewOccupationConfigAll.HandleId, 0, ConfigNewOccupationConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewOccupationConfigAll.HandleId, ConfigNewOccupationConfigAll.LogPair);
					return null;
				}
				NewOccupationConfig rootAsNewOccupationConfig = NewOccupationConfig.GetRootAsNewOccupationConfig(new ByteBuffer(item2));
				list.Add(rootAsNewOccupationConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("NewOccupationConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewOccupationConfigAll.HandleId, ConfigNewOccupationConfigAll.LogPair);
			return list;
		}

		// Token: 0x04002A25 RID: 10789
		private const string DB = "db_new_occupation.db";

		// Token: 0x04002A26 RID: 10790
		private const string FILE = "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv";

		// Token: 0x04002A27 RID: 10791
		private const string TABLE = "NewOccupationConfig";

		// Token: 0x04002A28 RID: 10792
		private const string COMMAND = "select BinData from `NewOccupationConfig`";

		// Token: 0x04002A29 RID: 10793
		private const string KEY_PREFIX = "NewOccupationConfigAll";

		// Token: 0x04002A2A RID: 10794
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A2B RID: 10795
		private static int HandleId;
	}
}
