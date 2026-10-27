using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F1 RID: 1521
	public class ConfigNewOccupationConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023B5 RID: 9141 RVA: 0x0012370F File Offset: 0x0012190F
		static ConfigNewOccupationConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewOccupationConfigAll.CreateStaticDefaultValue), new Action(ConfigNewOccupationConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00123730 File Offset: 0x00121930
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

		// Token: 0x060023B7 RID: 9143 RVA: 0x001237AF File Offset: 0x001219AF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewOccupationConfigAll.LogPair = null;
			ConfigNewOccupationConfigAll.HandleId = 0;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x001237BD File Offset: 0x001219BD
		public static void Init()
		{
			ConfigNewOccupationConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigNewOccupationConfigAll.HandleId, "db_new_occupation.db", "select BinData from `NewOccupationConfig`");
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x001237D8 File Offset: 0x001219D8
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

		// Token: 0x0400297D RID: 10621
		private const string DB = "db_new_occupation.db";

		// Token: 0x0400297E RID: 10622
		private const string FILE = "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv";

		// Token: 0x0400297F RID: 10623
		private const string TABLE = "NewOccupationConfig";

		// Token: 0x04002980 RID: 10624
		private const string COMMAND = "select BinData from `NewOccupationConfig`";

		// Token: 0x04002981 RID: 10625
		private const string KEY_PREFIX = "NewOccupationConfigAll";

		// Token: 0x04002982 RID: 10626
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002983 RID: 10627
		private static int HandleId;
	}
}
