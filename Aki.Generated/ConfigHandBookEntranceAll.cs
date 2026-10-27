using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CB RID: 971
	public class ConfigHandBookEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016C9 RID: 5833 RVA: 0x000DA58C File Offset: 0x000D878C
		static ConfigHandBookEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookEntranceAll.CreateStaticDefaultValue), new Action(ConfigHandBookEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016CA RID: 5834 RVA: 0x000DA5AC File Offset: 0x000D87AC
		public static void CreateStaticDefaultValue()
		{
			ConfigHandBookEntranceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHandBookEntranceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook_entrance.db"),
				new ValueTuple<string, object>("文件", "t.图鉴入口.xlsx"),
				new ValueTuple<string, object>("表名", "HandBookEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `HandBookEntrance`")
			});
		}

		// Token: 0x060016CB RID: 5835 RVA: 0x000DA62B File Offset: 0x000D882B
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookEntranceAll.LogPair = null;
			ConfigHandBookEntranceAll.HandleId = 0;
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000DA639 File Offset: 0x000D8839
		public static void Init()
		{
			ConfigHandBookEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookEntranceAll.HandleId, "db_handbook_entrance.db", "select BinData from `HandBookEntrance`");
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x000DA654 File Offset: 0x000D8854
		[NullableContext(2)]
		public static IReadOnlyList<HandBookEntrance> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHandBookEntranceAll.HandleId, ConfigHandBookEntranceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<HandBookEntrance> readOnlyList = (IReadOnlyList<HandBookEntrance>)ConfigCommon.GetConfig("HandBookEntranceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<HandBookEntrance> list = new List<HandBookEntrance>();
			while (ConfigCommon.Step(ConfigHandBookEntranceAll.HandleId, false, ConfigHandBookEntranceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHandBookEntranceAll.HandleId, 0, ConfigHandBookEntranceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigHandBookEntranceAll.HandleId, ConfigHandBookEntranceAll.LogPair);
					return null;
				}
				HandBookEntrance rootAsHandBookEntrance = HandBookEntrance.GetRootAsHandBookEntrance(new ByteBuffer(item2));
				list.Add(rootAsHandBookEntrance);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("HandBookEntranceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigHandBookEntranceAll.HandleId, ConfigHandBookEntranceAll.LogPair);
			return list;
		}

		// Token: 0x04001A71 RID: 6769
		private const string DB = "db_handbook_entrance.db";

		// Token: 0x04001A72 RID: 6770
		private const string FILE = "t.图鉴入口.xlsx";

		// Token: 0x04001A73 RID: 6771
		private const string TABLE = "HandBookEntrance";

		// Token: 0x04001A74 RID: 6772
		private const string COMMAND = "select BinData from `HandBookEntrance`";

		// Token: 0x04001A75 RID: 6773
		private const string KEY_PREFIX = "HandBookEntranceAll";

		// Token: 0x04001A76 RID: 6774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A77 RID: 6775
		private static int HandleId;
	}
}
