using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A3 RID: 931
	public class ConfigGeographyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015D8 RID: 5592 RVA: 0x000D8AC0 File Offset: 0x000D6CC0
		static ConfigGeographyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTypeAll.CreateStaticDefaultValue), new Action(ConfigGeographyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x000D8AE0 File Offset: 0x000D6CE0
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyType"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyType`")
			});
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x000D8B5F File Offset: 0x000D6D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTypeAll.LogPair = null;
			ConfigGeographyTypeAll.HandleId = 0;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x000D8B6D File Offset: 0x000D6D6D
		public static void Init()
		{
			ConfigGeographyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTypeAll.HandleId, "db_handbook.db", "select BinData from `GeographyType`");
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000D8B88 File Offset: 0x000D6D88
		[NullableContext(2)]
		public static IReadOnlyList<GeographyType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyTypeAll.HandleId, ConfigGeographyTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GeographyType> readOnlyList = (IReadOnlyList<GeographyType>)ConfigCommon.GetConfig("GeographyTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GeographyType> list = new List<GeographyType>();
			while (ConfigCommon.Step(ConfigGeographyTypeAll.HandleId, false, ConfigGeographyTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyTypeAll.HandleId, 0, ConfigGeographyTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyTypeAll.HandleId, ConfigGeographyTypeAll.LogPair);
					return null;
				}
				GeographyType rootAsGeographyType = GeographyType.GetRootAsGeographyType(new ByteBuffer(item2));
				list.Add(rootAsGeographyType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GeographyTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyTypeAll.HandleId, ConfigGeographyTypeAll.LogPair);
			return list;
		}

		// Token: 0x04001959 RID: 6489
		private const string DB = "db_handbook.db";

		// Token: 0x0400195A RID: 6490
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400195B RID: 6491
		private const string TABLE = "GeographyType";

		// Token: 0x0400195C RID: 6492
		private const string COMMAND = "select BinData from `GeographyType`";

		// Token: 0x0400195D RID: 6493
		private const string KEY_PREFIX = "GeographyTypeAll";

		// Token: 0x0400195E RID: 6494
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400195F RID: 6495
		private static int HandleId;
	}
}
