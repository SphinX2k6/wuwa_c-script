using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000317 RID: 791
	public class ConfigFloroRanchEventAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600128F RID: 4751 RVA: 0x000C261C File Offset: 0x000C081C
		static ConfigFloroRanchEventAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchEventAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchEventAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x000C263C File Offset: 0x000C083C
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

		// Token: 0x06001291 RID: 4753 RVA: 0x000C26BB File Offset: 0x000C08BB
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchEventAll.LogPair = null;
			ConfigFloroRanchEventAll.HandleId = 0;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x000C26C9 File Offset: 0x000C08C9
		public static void Init()
		{
			ConfigFloroRanchEventAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchEventAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchEvent`");
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x000C26E4 File Offset: 0x000C08E4
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

		// Token: 0x04001585 RID: 5509
		private const string DB = "db_flororanch.db";

		// Token: 0x04001586 RID: 5510
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001587 RID: 5511
		private const string TABLE = "FloroRanchEvent";

		// Token: 0x04001588 RID: 5512
		private const string COMMAND = "select BinData from `FloroRanchEvent`";

		// Token: 0x04001589 RID: 5513
		private const string KEY_PREFIX = "FloroRanchEventAll";

		// Token: 0x0400158A RID: 5514
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400158B RID: 5515
		private static int HandleId;
	}
}
