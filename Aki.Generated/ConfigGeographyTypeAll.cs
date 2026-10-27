using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038D RID: 909
	public class ConfigGeographyTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001554 RID: 5460 RVA: 0x000D236C File Offset: 0x000D056C
		static ConfigGeographyTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTypeAll.CreateStaticDefaultValue), new Action(ConfigGeographyTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x000D238C File Offset: 0x000D058C
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

		// Token: 0x06001556 RID: 5462 RVA: 0x000D240B File Offset: 0x000D060B
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTypeAll.LogPair = null;
			ConfigGeographyTypeAll.HandleId = 0;
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x000D2419 File Offset: 0x000D0619
		public static void Init()
		{
			ConfigGeographyTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTypeAll.HandleId, "db_handbook.db", "select BinData from `GeographyType`");
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x000D2434 File Offset: 0x000D0634
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

		// Token: 0x040018BF RID: 6335
		private const string DB = "db_handbook.db";

		// Token: 0x040018C0 RID: 6336
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018C1 RID: 6337
		private const string TABLE = "GeographyType";

		// Token: 0x040018C2 RID: 6338
		private const string COMMAND = "select BinData from `GeographyType`";

		// Token: 0x040018C3 RID: 6339
		private const string KEY_PREFIX = "GeographyTypeAll";

		// Token: 0x040018C4 RID: 6340
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018C5 RID: 6341
		private static int HandleId;
	}
}
