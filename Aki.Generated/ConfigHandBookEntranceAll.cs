using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E1 RID: 993
	public class ConfigHandBookEntranceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600174D RID: 5965 RVA: 0x000E0CE0 File Offset: 0x000DEEE0
		static ConfigHandBookEntranceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHandBookEntranceAll.CreateStaticDefaultValue), new Action(ConfigHandBookEntranceAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x000E0D00 File Offset: 0x000DEF00
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

		// Token: 0x0600174F RID: 5967 RVA: 0x000E0D7F File Offset: 0x000DEF7F
		public static void ResetStaticDefaultValue()
		{
			ConfigHandBookEntranceAll.LogPair = null;
			ConfigHandBookEntranceAll.HandleId = 0;
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x000E0D8D File Offset: 0x000DEF8D
		public static void Init()
		{
			ConfigHandBookEntranceAll.HandleId = ConfigCommon.InitDataStatement(ConfigHandBookEntranceAll.HandleId, "db_handbook_entrance.db", "select BinData from `HandBookEntrance`");
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x000E0DA8 File Offset: 0x000DEFA8
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

		// Token: 0x04001B0B RID: 6923
		private const string DB = "db_handbook_entrance.db";

		// Token: 0x04001B0C RID: 6924
		private const string FILE = "t.图鉴入口.xlsx";

		// Token: 0x04001B0D RID: 6925
		private const string TABLE = "HandBookEntrance";

		// Token: 0x04001B0E RID: 6926
		private const string COMMAND = "select BinData from `HandBookEntrance`";

		// Token: 0x04001B0F RID: 6927
		private const string KEY_PREFIX = "HandBookEntranceAll";

		// Token: 0x04001B10 RID: 6928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B11 RID: 6929
		private static int HandleId;
	}
}
