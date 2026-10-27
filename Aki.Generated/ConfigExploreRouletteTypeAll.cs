using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002A0 RID: 672
	public class ConfigExploreRouletteTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FC5 RID: 4037 RVA: 0x000B2A24 File Offset: 0x000B0C24
		static ConfigExploreRouletteTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreRouletteTypeAll.CreateStaticDefaultValue), new Action(ConfigExploreRouletteTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000B2A44 File Offset: 0x000B0C44
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

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000B2AC3 File Offset: 0x000B0CC3
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreRouletteTypeAll.LogPair = null;
			ConfigExploreRouletteTypeAll.HandleId = 0;
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x000B2AD1 File Offset: 0x000B0CD1
		public static void Init()
		{
			ConfigExploreRouletteTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreRouletteTypeAll.HandleId, "db_explore_skill.db", "select BinData from `ExploreRouletteType`");
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x000B2AEC File Offset: 0x000B0CEC
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

		// Token: 0x04001244 RID: 4676
		private const string DB = "db_explore_skill.db";

		// Token: 0x04001245 RID: 4677
		private const string FILE = "t.探索工具.xlsx";

		// Token: 0x04001246 RID: 4678
		private const string TABLE = "ExploreRouletteType";

		// Token: 0x04001247 RID: 4679
		private const string COMMAND = "select BinData from `ExploreRouletteType`";

		// Token: 0x04001248 RID: 4680
		private const string KEY_PREFIX = "ExploreRouletteTypeAll";

		// Token: 0x04001249 RID: 4681
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400124A RID: 4682
		private static int HandleId;
	}
}
