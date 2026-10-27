using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200015F RID: 351
	public class ConfigChipTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x0008804B File Offset: 0x0008624B
		static ConfigChipTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipTypeAll.CreateStaticDefaultValue), new Action(ConfigChipTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0008806C File Offset: 0x0008626C
		public static void CreateStaticDefaultValue()
		{
			ConfigChipTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigChipTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "ChipType"),
				new ValueTuple<string, object>("语句", "select BinData from `ChipType`")
			});
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000880EB File Offset: 0x000862EB
		public static void ResetStaticDefaultValue()
		{
			ConfigChipTypeAll.LogPair = null;
			ConfigChipTypeAll.HandleId = 0;
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000880F9 File Offset: 0x000862F9
		public static void Init()
		{
			ConfigChipTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChipTypeAll.HandleId, "db_handbook.db", "select BinData from `ChipType`");
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00088114 File Offset: 0x00086314
		[NullableContext(2)]
		public static IReadOnlyList<ChipType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigChipTypeAll.HandleId, ConfigChipTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ChipType> readOnlyList = (IReadOnlyList<ChipType>)ConfigCommon.GetConfig("ChipTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ChipType> list = new List<ChipType>();
			while (ConfigCommon.Step(ConfigChipTypeAll.HandleId, false, ConfigChipTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigChipTypeAll.HandleId, 0, ConfigChipTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigChipTypeAll.HandleId, ConfigChipTypeAll.LogPair);
					return null;
				}
				ChipType rootAsChipType = ChipType.GetRootAsChipType(new ByteBuffer(item2));
				list.Add(rootAsChipType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ChipTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigChipTypeAll.HandleId, ConfigChipTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400097D RID: 2429
		private const string DB = "db_handbook.db";

		// Token: 0x0400097E RID: 2430
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400097F RID: 2431
		private const string TABLE = "ChipType";

		// Token: 0x04000980 RID: 2432
		private const string COMMAND = "select BinData from `ChipType`";

		// Token: 0x04000981 RID: 2433
		private const string KEY_PREFIX = "ChipTypeAll";

		// Token: 0x04000982 RID: 2434
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000983 RID: 2435
		private static int HandleId;
	}
}
