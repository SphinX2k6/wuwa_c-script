using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032F RID: 815
	public class ConfigFloroRanchFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600131F RID: 4895 RVA: 0x000C914C File Offset: 0x000C734C
		static ConfigFloroRanchFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x000C916C File Offset: 0x000C736C
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchFilterTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchFilterType`")
			});
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x000C91EB File Offset: 0x000C73EB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchFilterTypeAll.LogPair = null;
			ConfigFloroRanchFilterTypeAll.HandleId = 0;
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x000C91F9 File Offset: 0x000C73F9
		public static void Init()
		{
			ConfigFloroRanchFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchFilterTypeAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchFilterType`");
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000C9214 File Offset: 0x000C7414
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchFilterType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchFilterType> readOnlyList = (IReadOnlyList<FloroRanchFilterType>)ConfigCommon.GetConfig("FloroRanchFilterTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchFilterType> list = new List<FloroRanchFilterType>();
			while (ConfigCommon.Step(ConfigFloroRanchFilterTypeAll.HandleId, false, ConfigFloroRanchFilterTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchFilterTypeAll.HandleId, 0, ConfigFloroRanchFilterTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair);
					return null;
				}
				FloroRanchFilterType rootAsFloroRanchFilterType = FloroRanchFilterType.GetRootAsFloroRanchFilterType(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchFilterType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchFilterTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchFilterTypeAll.HandleId, ConfigFloroRanchFilterTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400162D RID: 5677
		private const string DB = "db_flororanch.db";

		// Token: 0x0400162E RID: 5678
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400162F RID: 5679
		private const string TABLE = "FloroRanchFilterType";

		// Token: 0x04001630 RID: 5680
		private const string COMMAND = "select BinData from `FloroRanchFilterType`";

		// Token: 0x04001631 RID: 5681
		private const string KEY_PREFIX = "FloroRanchFilterTypeAll";

		// Token: 0x04001632 RID: 5682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001633 RID: 5683
		private static int HandleId;
	}
}
