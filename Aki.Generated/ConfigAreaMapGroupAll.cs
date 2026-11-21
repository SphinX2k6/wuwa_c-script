using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AD RID: 173
	public class ConfigAreaMapGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x000741B4 File Offset: 0x000723B4
		static ConfigAreaMapGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaMapGroupAll.CreateStaticDefaultValue), new Action(ConfigAreaMapGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000741D4 File Offset: 0x000723D4
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaMapGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaMapGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaMapGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaMapGroup`")
			});
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00074253 File Offset: 0x00072453
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaMapGroupAll.LogPair = null;
			ConfigAreaMapGroupAll.HandleId = 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00074261 File Offset: 0x00072461
		public static void Init()
		{
			ConfigAreaMapGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaMapGroupAll.HandleId, "db_areaterminal.db", "select BinData from `AreaMapGroup`");
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0007427C File Offset: 0x0007247C
		[NullableContext(2)]
		public static IReadOnlyList<AreaMapGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AreaMapGroup> readOnlyList = (IReadOnlyList<AreaMapGroup>)ConfigCommon.GetConfig("AreaMapGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AreaMapGroup> list = new List<AreaMapGroup>();
			while (ConfigCommon.Step(ConfigAreaMapGroupAll.HandleId, false, ConfigAreaMapGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaMapGroupAll.HandleId, 0, ConfigAreaMapGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair);
					return null;
				}
				AreaMapGroup rootAsAreaMapGroup = AreaMapGroup.GetRootAsAreaMapGroup(new ByteBuffer(item2));
				list.Add(rootAsAreaMapGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AreaMapGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaMapGroupAll.HandleId, ConfigAreaMapGroupAll.LogPair);
			return list;
		}

		// Token: 0x0400049F RID: 1183
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004A0 RID: 1184
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004A1 RID: 1185
		private const string TABLE = "AreaMapGroup";

		// Token: 0x040004A2 RID: 1186
		private const string COMMAND = "select BinData from `AreaMapGroup`";

		// Token: 0x040004A3 RID: 1187
		private const string KEY_PREFIX = "AreaMapGroupAll";

		// Token: 0x040004A4 RID: 1188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004A5 RID: 1189
		private static int HandleId;
	}
}
