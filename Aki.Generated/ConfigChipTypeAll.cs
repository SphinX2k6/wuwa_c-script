using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200016F RID: 367
	public class ConfigChipTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600089B RID: 2203 RVA: 0x0008DBA7 File Offset: 0x0008BDA7
		static ConfigChipTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigChipTypeAll.CreateStaticDefaultValue), new Action(ConfigChipTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x0008DBC8 File Offset: 0x0008BDC8
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

		// Token: 0x0600089D RID: 2205 RVA: 0x0008DC47 File Offset: 0x0008BE47
		public static void ResetStaticDefaultValue()
		{
			ConfigChipTypeAll.LogPair = null;
			ConfigChipTypeAll.HandleId = 0;
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x0008DC55 File Offset: 0x0008BE55
		public static void Init()
		{
			ConfigChipTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigChipTypeAll.HandleId, "db_handbook.db", "select BinData from `ChipType`");
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x0008DC70 File Offset: 0x0008BE70
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

		// Token: 0x040009ED RID: 2541
		private const string DB = "db_handbook.db";

		// Token: 0x040009EE RID: 2542
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040009EF RID: 2543
		private const string TABLE = "ChipType";

		// Token: 0x040009F0 RID: 2544
		private const string COMMAND = "select BinData from `ChipType`";

		// Token: 0x040009F1 RID: 2545
		private const string KEY_PREFIX = "ChipTypeAll";

		// Token: 0x040009F2 RID: 2546
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040009F3 RID: 2547
		private static int HandleId;
	}
}
