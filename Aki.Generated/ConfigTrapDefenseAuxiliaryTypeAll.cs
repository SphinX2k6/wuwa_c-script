using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AF0 RID: 2800
	public class ConfigTrapDefenseAuxiliaryTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060041B4 RID: 16820 RVA: 0x001D0584 File Offset: 0x001CE784
		static ConfigTrapDefenseAuxiliaryTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseAuxiliaryTypeAll.CreateStaticDefaultValue), new Action(ConfigTrapDefenseAuxiliaryTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060041B5 RID: 16821 RVA: 0x001D05A4 File Offset: 0x001CE7A4
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

		// Token: 0x060041B6 RID: 16822 RVA: 0x001D0623 File Offset: 0x001CE823
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseAuxiliaryTypeAll.LogPair = null;
			ConfigTrapDefenseAuxiliaryTypeAll.HandleId = 0;
		}

		// Token: 0x060041B7 RID: 16823 RVA: 0x001D0631 File Offset: 0x001CE831
		public static void Init()
		{
			ConfigTrapDefenseAuxiliaryTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseAuxiliaryTypeAll.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseAuxiliaryType`");
		}

		// Token: 0x060041B8 RID: 16824 RVA: 0x001D064C File Offset: 0x001CE84C
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

		// Token: 0x04004C76 RID: 19574
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004C77 RID: 19575
		private const string FILE = "x.陷阱塔防活动_机关.xlsx";

		// Token: 0x04004C78 RID: 19576
		private const string TABLE = "TrapDefenseAuxiliaryType";

		// Token: 0x04004C79 RID: 19577
		private const string COMMAND = "select BinData from `TrapDefenseAuxiliaryType`";

		// Token: 0x04004C7A RID: 19578
		private const string KEY_PREFIX = "TrapDefenseAuxiliaryTypeAll";

		// Token: 0x04004C7B RID: 19579
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C7C RID: 19580
		private static int HandleId;
	}
}
