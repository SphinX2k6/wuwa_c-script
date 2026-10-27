using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200009E RID: 158
	public class ConfigAreaAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x0006E81C File Offset: 0x0006CA1C
		static ConfigAreaAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaAll.CreateStaticDefaultValue), new Action(ConfigAreaAll.ResetStaticDefaultValue));
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0006E83C File Offset: 0x0006CA3C
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_area.db"),
				new ValueTuple<string, object>("文件", "q.区域.xlsx"),
				new ValueTuple<string, object>("表名", "Area"),
				new ValueTuple<string, object>("语句", "select BinData from `Area`")
			});
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0006E8BB File Offset: 0x0006CABB
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaAll.LogPair = null;
			ConfigAreaAll.HandleId = 0;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0006E8C9 File Offset: 0x0006CAC9
		public static void Init()
		{
			ConfigAreaAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaAll.HandleId, "db_area.db", "select BinData from `Area`");
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0006E8E4 File Offset: 0x0006CAE4
		[NullableContext(2)]
		public static IReadOnlyList<Area> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Area> readOnlyList = (IReadOnlyList<Area>)ConfigCommon.GetConfig("AreaAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Area> list = new List<Area>();
			while (ConfigCommon.Step(ConfigAreaAll.HandleId, false, ConfigAreaAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaAll.HandleId, 0, ConfigAreaAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair);
					return null;
				}
				Area rootAsArea = Area.GetRootAsArea(new ByteBuffer(item2));
				list.Add(rootAsArea);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AreaAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaAll.HandleId, ConfigAreaAll.LogPair);
			return list;
		}

		// Token: 0x04000436 RID: 1078
		private const string DB = "db_area.db";

		// Token: 0x04000437 RID: 1079
		private const string FILE = "q.区域.xlsx";

		// Token: 0x04000438 RID: 1080
		private const string TABLE = "Area";

		// Token: 0x04000439 RID: 1081
		private const string COMMAND = "select BinData from `Area`";

		// Token: 0x0400043A RID: 1082
		private const string KEY_PREFIX = "AreaAll";

		// Token: 0x0400043B RID: 1083
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400043C RID: 1084
		private static int HandleId;
	}
}
