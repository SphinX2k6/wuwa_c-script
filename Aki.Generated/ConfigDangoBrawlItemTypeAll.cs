using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CF RID: 463
	public class ConfigDangoBrawlItemTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000ADD RID: 2781 RVA: 0x00096FBC File Offset: 0x000951BC
		static ConfigDangoBrawlItemTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemTypeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00096FDC File Offset: 0x000951DC
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

		// Token: 0x06000ADF RID: 2783 RVA: 0x0009705B File Offset: 0x0009525B
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemTypeAll.LogPair = null;
			ConfigDangoBrawlItemTypeAll.HandleId = 0;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00097069 File Offset: 0x00095269
		public static void Init()
		{
			ConfigDangoBrawlItemTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemTypeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemType`");
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00097084 File Offset: 0x00095284
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

		// Token: 0x04000C8D RID: 3213
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C8E RID: 3214
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C8F RID: 3215
		private const string TABLE = "DangoBrawlItemType";

		// Token: 0x04000C90 RID: 3216
		private const string COMMAND = "select BinData from `DangoBrawlItemType`";

		// Token: 0x04000C91 RID: 3217
		private const string KEY_PREFIX = "DangoBrawlItemTypeAll";

		// Token: 0x04000C92 RID: 3218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C93 RID: 3219
		private static int HandleId;
	}
}
