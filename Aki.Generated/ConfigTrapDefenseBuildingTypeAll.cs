using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AFE RID: 2814
	public class ConfigTrapDefenseBuildingTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004208 RID: 16904 RVA: 0x001D238C File Offset: 0x001D058C
		static ConfigTrapDefenseBuildingTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTypeAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004209 RID: 16905 RVA: 0x001D23AC File Offset: 0x001D05AC
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseBuildingTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseBuildingType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseBuildingType`")
			});
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x001D242B File Offset: 0x001D062B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeAll.LogPair = null;
			ConfigTrapDefenseBuildingTypeAll.HandleId = 0;
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x001D2439 File Offset: 0x001D0639
		public static void Init()
		{
			ConfigTrapDefenseBuildingTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTypeAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingType`");
		}

		// Token: 0x0600420C RID: 16908 RVA: 0x001D2454 File Offset: 0x001D0654
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseBuildingType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseBuildingTypeAll.HandleId, ConfigTrapDefenseBuildingTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseBuildingType> readOnlyList = (IReadOnlyList<TrapDefenseBuildingType>)ConfigCommon.GetConfig("TrapDefenseBuildingTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseBuildingType> list = new List<TrapDefenseBuildingType>();
			while (ConfigCommon.Step(ConfigTrapDefenseBuildingTypeAll.HandleId, false, ConfigTrapDefenseBuildingTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseBuildingTypeAll.HandleId, 0, ConfigTrapDefenseBuildingTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseBuildingTypeAll.HandleId, ConfigTrapDefenseBuildingTypeAll.LogPair);
					return null;
				}
				TrapDefenseBuildingType rootAsTrapDefenseBuildingType = TrapDefenseBuildingType.GetRootAsTrapDefenseBuildingType(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseBuildingType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseBuildingTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseBuildingTypeAll.HandleId, ConfigTrapDefenseBuildingTypeAll.LogPair);
			return list;
		}

		// Token: 0x04004CD8 RID: 19672
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004CD9 RID: 19673
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004CDA RID: 19674
		private const string TABLE = "TrapDefenseBuildingType";

		// Token: 0x04004CDB RID: 19675
		private const string COMMAND = "select BinData from `TrapDefenseBuildingType`";

		// Token: 0x04004CDC RID: 19676
		private const string KEY_PREFIX = "TrapDefenseBuildingTypeAll";

		// Token: 0x04004CDD RID: 19677
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004CDE RID: 19678
		private static int HandleId;
	}
}
