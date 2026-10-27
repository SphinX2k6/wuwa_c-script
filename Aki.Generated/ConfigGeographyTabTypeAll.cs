using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038B RID: 907
	public class ConfigGeographyTabTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001548 RID: 5448 RVA: 0x000D1F8F File Offset: 0x000D018F
		static ConfigGeographyTabTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTabTypeAll.CreateStaticDefaultValue), new Action(ConfigGeographyTabTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x000D1FB0 File Offset: 0x000D01B0
		public static void CreateStaticDefaultValue()
		{
			ConfigGeographyTabTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGeographyTabTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "GeographyTabType"),
				new ValueTuple<string, object>("语句", "select BinData from `GeographyTabType`")
			});
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x000D202F File Offset: 0x000D022F
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTabTypeAll.LogPair = null;
			ConfigGeographyTabTypeAll.HandleId = 0;
		}

		// Token: 0x0600154B RID: 5451 RVA: 0x000D203D File Offset: 0x000D023D
		public static void Init()
		{
			ConfigGeographyTabTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTabTypeAll.HandleId, "db_handbook.db", "select BinData from `GeographyTabType`");
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x000D2058 File Offset: 0x000D0258
		[NullableContext(2)]
		public static IReadOnlyList<GeographyTabType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGeographyTabTypeAll.HandleId, ConfigGeographyTabTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GeographyTabType> readOnlyList = (IReadOnlyList<GeographyTabType>)ConfigCommon.GetConfig("GeographyTabTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GeographyTabType> list = new List<GeographyTabType>();
			while (ConfigCommon.Step(ConfigGeographyTabTypeAll.HandleId, false, ConfigGeographyTabTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGeographyTabTypeAll.HandleId, 0, ConfigGeographyTabTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGeographyTabTypeAll.HandleId, ConfigGeographyTabTypeAll.LogPair);
					return null;
				}
				GeographyTabType rootAsGeographyTabType = GeographyTabType.GetRootAsGeographyTabType(new ByteBuffer(item2));
				list.Add(rootAsGeographyTabType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GeographyTabTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGeographyTabTypeAll.HandleId, ConfigGeographyTabTypeAll.LogPair);
			return list;
		}

		// Token: 0x040018B1 RID: 6321
		private const string DB = "db_handbook.db";

		// Token: 0x040018B2 RID: 6322
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x040018B3 RID: 6323
		private const string TABLE = "GeographyTabType";

		// Token: 0x040018B4 RID: 6324
		private const string COMMAND = "select BinData from `GeographyTabType`";

		// Token: 0x040018B5 RID: 6325
		private const string KEY_PREFIX = "GeographyTabTypeAll";

		// Token: 0x040018B6 RID: 6326
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018B7 RID: 6327
		private static int HandleId;
	}
}
