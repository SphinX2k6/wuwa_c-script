using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013A RID: 314
	public class ConfigCalabashSkinAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x000834C4 File Offset: 0x000816C4
		static ConfigCalabashSkinAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashSkinAll.CreateStaticDefaultValue), new Action(ConfigCalabashSkinAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x000834E4 File Offset: 0x000816E4
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashSkinAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashSkinAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashSkin`")
			});
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x00083563 File Offset: 0x00081763
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashSkinAll.LogPair = null;
			ConfigCalabashSkinAll.HandleId = 0;
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00083571 File Offset: 0x00081771
		public static void Init()
		{
			ConfigCalabashSkinAll.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashSkinAll.HandleId, "db_calabash.db", "select BinData from `CalabashSkin`");
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0008358C File Offset: 0x0008178C
		[NullableContext(2)]
		public static IReadOnlyList<CalabashSkin> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CalabashSkin> readOnlyList = (IReadOnlyList<CalabashSkin>)ConfigCommon.GetConfig("CalabashSkinAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CalabashSkin> list = new List<CalabashSkin>();
			while (ConfigCommon.Step(ConfigCalabashSkinAll.HandleId, false, ConfigCalabashSkinAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashSkinAll.HandleId, 0, ConfigCalabashSkinAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair);
					return null;
				}
				CalabashSkin rootAsCalabashSkin = CalabashSkin.GetRootAsCalabashSkin(new ByteBuffer(item2));
				list.Add(rootAsCalabashSkin);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CalabashSkinAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCalabashSkinAll.HandleId, ConfigCalabashSkinAll.LogPair);
			return list;
		}

		// Token: 0x0400087A RID: 2170
		private const string DB = "db_calabash.db";

		// Token: 0x0400087B RID: 2171
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x0400087C RID: 2172
		private const string TABLE = "CalabashSkin";

		// Token: 0x0400087D RID: 2173
		private const string COMMAND = "select BinData from `CalabashSkin`";

		// Token: 0x0400087E RID: 2174
		private const string KEY_PREFIX = "CalabashSkinAll";

		// Token: 0x0400087F RID: 2175
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000880 RID: 2176
		private static int HandleId;
	}
}
