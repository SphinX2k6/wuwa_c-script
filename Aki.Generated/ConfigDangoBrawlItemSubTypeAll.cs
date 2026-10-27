using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001CD RID: 461
	public class ConfigDangoBrawlItemSubTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x00096BE0 File Offset: 0x00094DE0
		static ConfigDangoBrawlItemSubTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemSubTypeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemSubTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00096C00 File Offset: 0x00094E00
		public static void CreateStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDangoBrawlItemSubTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangobrawl.db"),
				new ValueTuple<string, object>("文件", "t.团子乱斗外围.xlsx"),
				new ValueTuple<string, object>("表名", "DangoBrawlItemSubType"),
				new ValueTuple<string, object>("语句", "select BinData from `DangoBrawlItemSubType`")
			});
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00096C7F File Offset: 0x00094E7F
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeAll.LogPair = null;
			ConfigDangoBrawlItemSubTypeAll.HandleId = 0;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00096C8D File Offset: 0x00094E8D
		public static void Init()
		{
			ConfigDangoBrawlItemSubTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemSubTypeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemSubType`");
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00096CA8 File Offset: 0x00094EA8
		[NullableContext(2)]
		public static IReadOnlyList<DangoBrawlItemSubType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDangoBrawlItemSubTypeAll.HandleId, ConfigDangoBrawlItemSubTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DangoBrawlItemSubType> readOnlyList = (IReadOnlyList<DangoBrawlItemSubType>)ConfigCommon.GetConfig("DangoBrawlItemSubTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DangoBrawlItemSubType> list = new List<DangoBrawlItemSubType>();
			while (ConfigCommon.Step(ConfigDangoBrawlItemSubTypeAll.HandleId, false, ConfigDangoBrawlItemSubTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDangoBrawlItemSubTypeAll.HandleId, 0, ConfigDangoBrawlItemSubTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeAll.HandleId, ConfigDangoBrawlItemSubTypeAll.LogPair);
					return null;
				}
				DangoBrawlItemSubType rootAsDangoBrawlItemSubType = DangoBrawlItemSubType.GetRootAsDangoBrawlItemSubType(new ByteBuffer(item2));
				list.Add(rootAsDangoBrawlItemSubType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DangoBrawlItemSubTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDangoBrawlItemSubTypeAll.HandleId, ConfigDangoBrawlItemSubTypeAll.LogPair);
			return list;
		}

		// Token: 0x04000C7F RID: 3199
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000C80 RID: 3200
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000C81 RID: 3201
		private const string TABLE = "DangoBrawlItemSubType";

		// Token: 0x04000C82 RID: 3202
		private const string COMMAND = "select BinData from `DangoBrawlItemSubType`";

		// Token: 0x04000C83 RID: 3203
		private const string KEY_PREFIX = "DangoBrawlItemSubTypeAll";

		// Token: 0x04000C84 RID: 3204
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000C85 RID: 3205
		private static int HandleId;
	}
}
