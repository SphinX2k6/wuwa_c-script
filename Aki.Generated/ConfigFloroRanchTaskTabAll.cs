using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000340 RID: 832
	public class ConfigFloroRanchTaskTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001385 RID: 4997 RVA: 0x000CB460 File Offset: 0x000C9660
		static ConfigFloroRanchTaskTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskTabAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x000CB480 File Offset: 0x000C9680
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTaskTabAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTaskTab`")
			});
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x000CB4FF File Offset: 0x000C96FF
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabAll.LogPair = null;
			ConfigFloroRanchTaskTabAll.HandleId = 0;
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000CB50D File Offset: 0x000C970D
		public static void Init()
		{
			ConfigFloroRanchTaskTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskTabAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTaskTab`");
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000CB528 File Offset: 0x000C9728
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchTaskTab> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTaskTabAll.HandleId, ConfigFloroRanchTaskTabAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchTaskTab> readOnlyList = (IReadOnlyList<FloroRanchTaskTab>)ConfigCommon.GetConfig("FloroRanchTaskTabAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchTaskTab> list = new List<FloroRanchTaskTab>();
			while (ConfigCommon.Step(ConfigFloroRanchTaskTabAll.HandleId, false, ConfigFloroRanchTaskTabAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTaskTabAll.HandleId, 0, ConfigFloroRanchTaskTabAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchTaskTabAll.HandleId, ConfigFloroRanchTaskTabAll.LogPair);
					return null;
				}
				FloroRanchTaskTab rootAsFloroRanchTaskTab = FloroRanchTaskTab.GetRootAsFloroRanchTaskTab(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchTaskTab);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchTaskTabAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchTaskTabAll.HandleId, ConfigFloroRanchTaskTabAll.LogPair);
			return list;
		}

		// Token: 0x040016A4 RID: 5796
		private const string DB = "db_flororanch.db";

		// Token: 0x040016A5 RID: 5797
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016A6 RID: 5798
		private const string TABLE = "FloroRanchTaskTab";

		// Token: 0x040016A7 RID: 5799
		private const string COMMAND = "select BinData from `FloroRanchTaskTab`";

		// Token: 0x040016A8 RID: 5800
		private const string KEY_PREFIX = "FloroRanchTaskTabAll";

		// Token: 0x040016A9 RID: 5801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016AA RID: 5802
		private static int HandleId;
	}
}
