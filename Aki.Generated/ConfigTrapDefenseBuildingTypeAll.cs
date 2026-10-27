using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A29 RID: 2601
	public class ConfigTrapDefenseBuildingTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D0A RID: 15626 RVA: 0x001B2FF8 File Offset: 0x001B11F8
		static ConfigTrapDefenseBuildingTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseBuildingTypeAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseBuildingTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x001B3018 File Offset: 0x001B1218
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

		// Token: 0x06003D0C RID: 15628 RVA: 0x001B3097 File Offset: 0x001B1297
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseBuildingTypeAll.LogPair = null;
			ConfigTrapDefenseBuildingTypeAll.HandleId = 0;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x001B30A5 File Offset: 0x001B12A5
		public static void Init()
		{
			ConfigTrapDefenseBuildingTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseBuildingTypeAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseBuildingType`");
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x001B30C0 File Offset: 0x001B12C0
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

		// Token: 0x04004705 RID: 18181
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004706 RID: 18182
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004707 RID: 18183
		private const string TABLE = "TrapDefenseBuildingType";

		// Token: 0x04004708 RID: 18184
		private const string COMMAND = "select BinData from `TrapDefenseBuildingType`";

		// Token: 0x04004709 RID: 18185
		private const string KEY_PREFIX = "TrapDefenseBuildingTypeAll";

		// Token: 0x0400470A RID: 18186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400470B RID: 18187
		private static int HandleId;
	}
}
