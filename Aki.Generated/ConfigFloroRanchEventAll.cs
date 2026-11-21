using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032C RID: 812
	public class ConfigFloroRanchEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600130D RID: 4877 RVA: 0x000C8B28 File Offset: 0x000C6D28
		static ConfigFloroRanchEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000C8B48 File Offset: 0x000C6D48
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchEventAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchEventAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchEvent`")
			});
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x000C8BC7 File Offset: 0x000C6DC7
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventAll.LogPair = null;
			ConfigFloroRanchEventAll.HandleId = 0;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x000C8BD5 File Offset: 0x000C6DD5
		public static void Init()
		{
			ConfigFloroRanchEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEvent`");
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x000C8BF0 File Offset: 0x000C6DF0
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchEvent> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchEventAll.HandleId, ConfigFloroRanchEventAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchEvent> readOnlyList = (IReadOnlyList<FloroRanchEvent>)ConfigCommon.GetConfig("FloroRanchEventAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchEvent> list = new List<FloroRanchEvent>();
			while (ConfigCommon.Step(ConfigFloroRanchEventAll.HandleId, false, ConfigFloroRanchEventAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchEventAll.HandleId, 0, ConfigFloroRanchEventAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchEventAll.HandleId, ConfigFloroRanchEventAll.LogPair);
					return null;
				}
				FloroRanchEvent rootAsFloroRanchEvent = FloroRanchEvent.GetRootAsFloroRanchEvent(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchEvent);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchEventAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchEventAll.HandleId, ConfigFloroRanchEventAll.LogPair);
			return list;
		}

		// Token: 0x04001618 RID: 5656
		private const string DB = "db_flororanch.db";

		// Token: 0x04001619 RID: 5657
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400161A RID: 5658
		private const string TABLE = "FloroRanchEvent";

		// Token: 0x0400161B RID: 5659
		private const string COMMAND = "select BinData from `FloroRanchEvent`";

		// Token: 0x0400161C RID: 5660
		private const string KEY_PREFIX = "FloroRanchEventAll";

		// Token: 0x0400161D RID: 5661
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400161E RID: 5662
		private static int HandleId;
	}
}
