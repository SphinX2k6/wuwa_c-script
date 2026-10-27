using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004FD RID: 1277
	public class ConfigLordGymFilterTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001DF9 RID: 7673 RVA: 0x00102AC0 File Offset: 0x00100CC0
		static ConfigLordGymFilterTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymFilterTypeAll.CreateStaticDefaultValue), new Action(ConfigLordGymFilterTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00102AE0 File Offset: 0x00100CE0
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymFilterTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymFilterTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymFilterType"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymFilterType`")
			});
		}

		// Token: 0x06001DFB RID: 7675 RVA: 0x00102B5F File Offset: 0x00100D5F
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymFilterTypeAll.LogPair = null;
			ConfigLordGymFilterTypeAll.HandleId = 0;
		}

		// Token: 0x06001DFC RID: 7676 RVA: 0x00102B6D File Offset: 0x00100D6D
		public static void Init()
		{
			ConfigLordGymFilterTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymFilterTypeAll.HandleId, "db_lordgym.db", "select BinData from `LordGymFilterType`");
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x00102B88 File Offset: 0x00100D88
		[NullableContext(2)]
		public static IReadOnlyList<LordGymFilterType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<LordGymFilterType> readOnlyList = (IReadOnlyList<LordGymFilterType>)ConfigCommon.GetConfig("LordGymFilterTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<LordGymFilterType> list = new List<LordGymFilterType>();
			while (ConfigCommon.Step(ConfigLordGymFilterTypeAll.HandleId, false, ConfigLordGymFilterTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymFilterTypeAll.HandleId, 0, ConfigLordGymFilterTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair);
					return null;
				}
				LordGymFilterType rootAsLordGymFilterType = LordGymFilterType.GetRootAsLordGymFilterType(new ByteBuffer(item2));
				list.Add(rootAsLordGymFilterType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("LordGymFilterTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigLordGymFilterTypeAll.HandleId, ConfigLordGymFilterTypeAll.LogPair);
			return list;
		}

		// Token: 0x040022CF RID: 8911
		private const string DB = "db_lordgym.db";

		// Token: 0x040022D0 RID: 8912
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x040022D1 RID: 8913
		private const string TABLE = "LordGymFilterType";

		// Token: 0x040022D2 RID: 8914
		private const string COMMAND = "select BinData from `LordGymFilterType`";

		// Token: 0x040022D3 RID: 8915
		private const string KEY_PREFIX = "LordGymFilterTypeAll";

		// Token: 0x040022D4 RID: 8916
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040022D5 RID: 8917
		private static int HandleId;
	}
}
