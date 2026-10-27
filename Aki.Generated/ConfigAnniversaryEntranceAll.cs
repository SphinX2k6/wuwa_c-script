using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009A RID: 154
	public class ConfigAnniversaryEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600039C RID: 924 RVA: 0x0006DFB1 File Offset: 0x0006C1B1
		static ConfigAnniversaryEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceAll.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0006DFD0 File Offset: 0x0006C1D0
		public static void CreateStaticDefaultValue()
		{
			ConfigAnniversaryEntranceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnniversaryEntranceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_anniversaryt.db"),
				new ValueTuple<string, object>("文件", "z.周年庆主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "AnniversaryEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `AnniversaryEntrance`")
			});
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0006E04F File Offset: 0x0006C24F
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceAll.LogPair = null;
			ConfigAnniversaryEntranceAll.HandleId = 0;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0006E05D File Offset: 0x0006C25D
		public static void Init()
		{
			ConfigAnniversaryEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceAll.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance`");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0006E078 File Offset: 0x0006C278
		[NullableContext(2)]
		public static IReadOnlyList<AnniversaryEntrance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnniversaryEntranceAll.HandleId, ConfigAnniversaryEntranceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AnniversaryEntrance> readOnlyList = (IReadOnlyList<AnniversaryEntrance>)ConfigCommon.GetConfig("AnniversaryEntranceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AnniversaryEntrance> list = new List<AnniversaryEntrance>();
			while (ConfigCommon.Step(ConfigAnniversaryEntranceAll.HandleId, false, ConfigAnniversaryEntranceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnniversaryEntranceAll.HandleId, 0, ConfigAnniversaryEntranceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAnniversaryEntranceAll.HandleId, ConfigAnniversaryEntranceAll.LogPair);
					return null;
				}
				AnniversaryEntrance rootAsAnniversaryEntrance = AnniversaryEntrance.GetRootAsAnniversaryEntrance(new ByteBuffer(item2));
				list.Add(rootAsAnniversaryEntrance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AnniversaryEntranceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAnniversaryEntranceAll.HandleId, ConfigAnniversaryEntranceAll.LogPair);
			return list;
		}

		// Token: 0x0400041A RID: 1050
		private const string DB = "db_anniversaryt.db";

		// Token: 0x0400041B RID: 1051
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x0400041C RID: 1052
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x0400041D RID: 1053
		private const string COMMAND = "select BinData from `AnniversaryEntrance`";

		// Token: 0x0400041E RID: 1054
		private const string KEY_PREFIX = "AnniversaryEntranceAll";

		// Token: 0x0400041F RID: 1055
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000420 RID: 1056
		private static int HandleId;
	}
}
