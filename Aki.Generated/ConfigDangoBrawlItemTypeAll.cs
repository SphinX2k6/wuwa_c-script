using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001E1 RID: 481
	public class ConfigDangoBrawlItemTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x0009CEF4 File Offset: 0x0009B0F4
		static ConfigDangoBrawlItemTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemTypeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x0009CF14 File Offset: 0x0009B114
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemType`")
			});
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0009CF93 File Offset: 0x0009B193
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeAll.LogPair = null;
			ConfigDangoBrawlItemTypeAll.HandleId = 0;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0009CFA1 File Offset: 0x0009B1A1
		public static void Init()
		{
			ConfigDangoBrawlItemTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemTypeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemType`");
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x0009CFBC File Offset: 0x0009B1BC
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlItemType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemTypeAll.HandleId, ConfigDangoBrawlItemTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlItemType> readOnlyList = (IReadOnlyList<DangoBrawlItemType>)ConfigCommon.GetConfig("DangoBrawlItemTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlItemType> list = new List<DangoBrawlItemType>();
			while (ConfigCommon.Step(ConfigDangoBrawlItemTypeAll.HandleId, false, ConfigDangoBrawlItemTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemTypeAll.HandleId, 0, ConfigDangoBrawlItemTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlItemTypeAll.HandleId, ConfigDangoBrawlItemTypeAll.LogPair);
					return null;
				}
				DangoBrawlItemType rootAsDangoBrawlItemType = DangoBrawlItemType.GetRootAsDangoBrawlItemType(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlItemType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlItemTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemTypeAll.HandleId, ConfigDangoBrawlItemTypeAll.LogPair);
			return list;
		}

		// Token: 0x04000D0B RID: 3339
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000D0C RID: 3340
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000D0D RID: 3341
		private const string TABLE = "DangoBrawlItemType";

		// Token: 0x04000D0E RID: 3342
		private const string COMMAND = "select BinData from `DangoBrawlItemType`";

		// Token: 0x04000D0F RID: 3343
		private const string KEY_PREFIX = "DangoBrawlItemTypeAll";

		// Token: 0x04000D10 RID: 3344
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D11 RID: 3345
		private static int HandleId;
	}
}
