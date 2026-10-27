using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032B RID: 811
	public class ConfigFloroRanchTaskTabAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001307 RID: 4871 RVA: 0x000C4F54 File Offset: 0x000C3154
		static ConfigFloroRanchTaskTabAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTaskTabAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchTaskTabAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000C4F74 File Offset: 0x000C3174
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

		// Token: 0x06001309 RID: 4873 RVA: 0x000C4FF3 File Offset: 0x000C31F3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTaskTabAll.LogPair = null;
			ConfigFloroRanchTaskTabAll.HandleId = 0;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000C5001 File Offset: 0x000C3201
		public static void Init()
		{
			ConfigFloroRanchTaskTabAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTaskTabAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTaskTab`");
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000C501C File Offset: 0x000C321C
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

		// Token: 0x04001611 RID: 5649
		private const string DB = "db_flororanch.db";

		// Token: 0x04001612 RID: 5650
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001613 RID: 5651
		private const string TABLE = "FloroRanchTaskTab";

		// Token: 0x04001614 RID: 5652
		private const string COMMAND = "select BinData from `FloroRanchTaskTab`";

		// Token: 0x04001615 RID: 5653
		private const string KEY_PREFIX = "FloroRanchTaskTabAll";

		// Token: 0x04001616 RID: 5654
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001617 RID: 5655
		private static int HandleId;
	}
}
