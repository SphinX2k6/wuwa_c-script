using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002B4 RID: 692
	public class ConfigExploreRouletteTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600103D RID: 4157 RVA: 0x000B8CE8 File Offset: 0x000B6EE8
		static ConfigExploreRouletteTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteTypeAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000B8D08 File Offset: 0x000B6F08
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreRouletteTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreRouletteTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_skill.db"),
				new ValueTuple<string, object>("文件", "t.探索工具.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreRouletteType"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreRouletteType`")
			});
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x000B8D87 File Offset: 0x000B6F87
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteTypeAll.LogPair = null;
			ConfigExploreRouletteTypeAll.HandleId = 0;
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x000B8D95 File Offset: 0x000B6F95
		public static void Init()
		{
			ConfigExploreRouletteTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteTypeAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteType`");
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x000B8DB0 File Offset: 0x000B6FB0
		[NullableContext(2)]
		public static IReadOnlyList<ExploreRouletteType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreRouletteTypeAll.HandleId, ConfigExploreRouletteTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreRouletteType> readOnlyList = (IReadOnlyList<ExploreRouletteType>)ConfigCommon.GetConfig("ExploreRouletteTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreRouletteType> list = new List<ExploreRouletteType>();
			while (ConfigCommon.Step(ConfigExploreRouletteTypeAll.HandleId, false, ConfigExploreRouletteTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreRouletteTypeAll.HandleId, 0, ConfigExploreRouletteTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreRouletteTypeAll.HandleId, ConfigExploreRouletteTypeAll.LogPair);
					return null;
				}
				ExploreRouletteType rootAsExploreRouletteType = ExploreRouletteType.GetRootAsExploreRouletteType(new ByteBuffer(item2));
				list.Add(rootAsExploreRouletteType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreRouletteTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreRouletteTypeAll.HandleId, ConfigExploreRouletteTypeAll.LogPair);
			return list;
		}

		// Token: 0x040012D0 RID: 4816
		private const string DB = "db_explore_skill.db";

		// Token: 0x040012D1 RID: 4817
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x040012D2 RID: 4818
		private const string TABLE = "ExploreRouletteType";

		// Token: 0x040012D3 RID: 4819
		private const string COMMAND = "select BinData from `ExploreRouletteType`";

		// Token: 0x040012D4 RID: 4820
		private const string KEY_PREFIX = "ExploreRouletteTypeAll";

		// Token: 0x040012D5 RID: 4821
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040012D6 RID: 4822
		private static int HandleId;
	}
}
