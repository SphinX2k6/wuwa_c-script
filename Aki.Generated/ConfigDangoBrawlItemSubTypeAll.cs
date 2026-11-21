using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001DF RID: 479
	public class ConfigDangoBrawlItemSubTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000B3D RID: 2877 RVA: 0x0009CB18 File Offset: 0x0009AD18
		static ConfigDangoBrawlItemSubTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDangoBrawlItemSubTypeAll.CreateStaticDefaultValue), new Action(ConfigDangoBrawlItemSubTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0009CB38 File Offset: 0x0009AD38
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

		// Token: 0x06000B3F RID: 2879 RVA: 0x0009CBB7 File Offset: 0x0009ADB7
		public static void ResetStaticDefaultValue()
		{
			ConfigDangoBrawlItemSubTypeAll.LogPair = null;
			ConfigDangoBrawlItemSubTypeAll.HandleId = 0;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0009CBC5 File Offset: 0x0009ADC5
		public static void Init()
		{
			ConfigDangoBrawlItemSubTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigDangoBrawlItemSubTypeAll.HandleId, "db_dangobrawl.db", "select BinData from `DangoBrawlItemSubType`");
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0009CBE0 File Offset: 0x0009ADE0
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

		// Token: 0x04000CFD RID: 3325
		private const string DB = "db_dangobrawl.db";

		// Token: 0x04000CFE RID: 3326
		private const string FILE = "t.团子乱斗外围.xlsx";

		// Token: 0x04000CFF RID: 3327
		private const string TABLE = "DangoBrawlItemSubType";

		// Token: 0x04000D00 RID: 3328
		private const string COMMAND = "select BinData from `DangoBrawlItemSubType`";

		// Token: 0x04000D01 RID: 3329
		private const string KEY_PREFIX = "DangoBrawlItemSubTypeAll";

		// Token: 0x04000D02 RID: 3330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000D03 RID: 3331
		private static int HandleId;
	}
}
