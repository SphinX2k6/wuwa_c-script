using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000085 RID: 133
	public class ConfigAdviceWordTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600031E RID: 798 RVA: 0x0006E90B File Offset: 0x0006CB0B
		static ConfigAdviceWordTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdviceWordTypeAll.CreateStaticDefaultValue), new Action(ConfigAdviceWordTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0006E92C File Offset: 0x0006CB2C
		public static void CreateStaticDefaultValue()
		{
			ConfigAdviceWordTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdviceWordTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advice.db"),
				new ValueTuple<string, object>("文件", "s.溯言.xlsx"),
				new ValueTuple<string, object>("表名", "AdviceWordType"),
				new ValueTuple<string, object>("语句", "select BinData from `AdviceWordType`")
			});
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0006E9AB File Offset: 0x0006CBAB
		public static void ResetStaticDefaultValue()
		{
			ConfigAdviceWordTypeAll.LogPair = null;
			ConfigAdviceWordTypeAll.HandleId = 0;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0006E9B9 File Offset: 0x0006CBB9
		public static void Init()
		{
			ConfigAdviceWordTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigAdviceWordTypeAll.HandleId, "db_advice.db", "select BinData from `AdviceWordType`");
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0006E9D4 File Offset: 0x0006CBD4
		[NullableContext(2)]
		public static IReadOnlyList<AdviceWordType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AdviceWordType> readOnlyList = (IReadOnlyList<AdviceWordType>)ConfigCommon.GetConfig("AdviceWordTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AdviceWordType> list = new List<AdviceWordType>();
			while (ConfigCommon.Step(ConfigAdviceWordTypeAll.HandleId, false, ConfigAdviceWordTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdviceWordTypeAll.HandleId, 0, ConfigAdviceWordTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair);
					return null;
				}
				AdviceWordType rootAsAdviceWordType = AdviceWordType.GetRootAsAdviceWordType(new ByteBuffer(item2));
				list.Add(rootAsAdviceWordType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AdviceWordTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAdviceWordTypeAll.HandleId, ConfigAdviceWordTypeAll.LogPair);
			return list;
		}

		// Token: 0x04000387 RID: 903
		private const string DB = "db_advice.db";

		// Token: 0x04000388 RID: 904
		private const string FILE = "s.溯言.xlsx";

		// Token: 0x04000389 RID: 905
		private const string TABLE = "AdviceWordType";

		// Token: 0x0400038A RID: 906
		private const string COMMAND = "select BinData from `AdviceWordType`";

		// Token: 0x0400038B RID: 907
		private const string KEY_PREFIX = "AdviceWordTypeAll";

		// Token: 0x0400038C RID: 908
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400038D RID: 909
		private static int HandleId;
	}
}
