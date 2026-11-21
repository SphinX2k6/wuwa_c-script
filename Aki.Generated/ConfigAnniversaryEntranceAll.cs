using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A2 RID: 162
	public class ConfigAnniversaryEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003CC RID: 972 RVA: 0x00072865 File Offset: 0x00070A65
		static ConfigAnniversaryEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnniversaryEntranceAll.CreateStaticDefaultValue), new Action(ConfigAnniversaryEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00072884 File Offset: 0x00070A84
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

		// Token: 0x060003CE RID: 974 RVA: 0x00072903 File Offset: 0x00070B03
		public static void ResetStaticDefaultValue()
		{
			ConfigAnniversaryEntranceAll.LogPair = null;
			ConfigAnniversaryEntranceAll.HandleId = 0;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00072911 File Offset: 0x00070B11
		public static void Init()
		{
			ConfigAnniversaryEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigAnniversaryEntranceAll.HandleId, "db_anniversaryt.db", "select BinData from `AnniversaryEntrance`");
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0007292C File Offset: 0x00070B2C
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

		// Token: 0x04000452 RID: 1106
		private const string DB = "db_anniversaryt.db";

		// Token: 0x04000453 RID: 1107
		private const string FILE = "z.周年庆主题活动.xlsx";

		// Token: 0x04000454 RID: 1108
		private const string TABLE = "AnniversaryEntrance";

		// Token: 0x04000455 RID: 1109
		private const string COMMAND = "select BinData from `AnniversaryEntrance`";

		// Token: 0x04000456 RID: 1110
		private const string KEY_PREFIX = "AnniversaryEntranceAll";

		// Token: 0x04000457 RID: 1111
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000458 RID: 1112
		private static int HandleId;
	}
}
