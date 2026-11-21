using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A1 RID: 929
	public class ConfigGeographyTabTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015CC RID: 5580 RVA: 0x000D86E3 File Offset: 0x000D68E3
		static ConfigGeographyTabTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGeographyTabTypeAll.CreateStaticDefaultValue), new Action(ConfigGeographyTabTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x000D8704 File Offset: 0x000D6904
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

		// Token: 0x060015CE RID: 5582 RVA: 0x000D8783 File Offset: 0x000D6983
		public static void ResetStaticDefaultValue()
		{
			ConfigGeographyTabTypeAll.LogPair = null;
			ConfigGeographyTabTypeAll.HandleId = 0;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000D8791 File Offset: 0x000D6991
		public static void Init()
		{
			ConfigGeographyTabTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigGeographyTabTypeAll.HandleId, "db_handbook.db", "select BinData from `GeographyTabType`");
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x000D87AC File Offset: 0x000D69AC
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

		// Token: 0x0400194B RID: 6475
		private const string DB = "db_handbook.db";

		// Token: 0x0400194C RID: 6476
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400194D RID: 6477
		private const string TABLE = "GeographyTabType";

		// Token: 0x0400194E RID: 6478
		private const string COMMAND = "select BinData from `GeographyTabType`";

		// Token: 0x0400194F RID: 6479
		private const string KEY_PREFIX = "GeographyTabTypeAll";

		// Token: 0x04001950 RID: 6480
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001951 RID: 6481
		private static int HandleId;
	}
}
