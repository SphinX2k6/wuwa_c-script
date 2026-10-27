using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1B RID: 2587
	public class ConfigTrapDefenseAuxiliaryTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CB6 RID: 15542 RVA: 0x001B11F0 File Offset: 0x001AF3F0
		static ConfigTrapDefenseAuxiliaryTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryTypeAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CB7 RID: 15543 RVA: 0x001B1210 File Offset: 0x001AF410
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseAuxiliaryTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动_机关.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseAuxiliaryType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseAuxiliaryType`")
			});
		}

		// Token: 0x06003CB8 RID: 15544 RVA: 0x001B128F File Offset: 0x001AF48F
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeAll.LogPair = null;
			ConfigTrapDefenseAuxiliaryTypeAll.HandleId = 0;
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x001B129D File Offset: 0x001AF49D
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliaryType`");
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x001B12B8 File Offset: 0x001AF4B8
		[NullableContext(2)]
		public static IReadOnlyList<TrapDefenseAuxiliaryType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, ConfigTrapDefenseAuxiliaryTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrapDefenseAuxiliaryType> readOnlyList = (IReadOnlyList<TrapDefenseAuxiliaryType>)ConfigCommon.GetConfig("TrapDefenseAuxiliaryTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrapDefenseAuxiliaryType> list = new List<TrapDefenseAuxiliaryType>();
			while (ConfigCommon.Step(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, false, ConfigTrapDefenseAuxiliaryTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, 0, ConfigTrapDefenseAuxiliaryTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, ConfigTrapDefenseAuxiliaryTypeAll.LogPair);
					return null;
				}
				TrapDefenseAuxiliaryType rootAsTrapDefenseAuxiliaryType = TrapDefenseAuxiliaryType.GetRootAsTrapDefenseAuxiliaryType(new ByteBuffer(item2));
				list.Add(rootAsTrapDefenseAuxiliaryType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrapDefenseAuxiliaryTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, ConfigTrapDefenseAuxiliaryTypeAll.LogPair);
			return list;
		}

		// Token: 0x040046A3 RID: 18083
		private const string DB = "db_trapdefense.db";

		// Token: 0x040046A4 RID: 18084
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x040046A5 RID: 18085
		private const string TABLE = "TrapDefenseAuxiliaryType";

		// Token: 0x040046A6 RID: 18086
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliaryType`";

		// Token: 0x040046A7 RID: 18087
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryTypeAll";

		// Token: 0x040046A8 RID: 18088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046A9 RID: 18089
		private static int HandleId;
	}
}
