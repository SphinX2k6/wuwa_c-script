using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000331 RID: 817
	public class ConfigFloroRanchToyAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600132B RID: 4907 RVA: 0x000C5B8C File Offset: 0x000C3D8C
		static ConfigFloroRanchToyAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchToyAll.CreateStaticDefaultValue), new Action(ConfigFloroRanchToyAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x000C5BAC File Offset: 0x000C3DAC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchToyAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchToyAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchToy"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchToy`")
			});
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x000C5C2B File Offset: 0x000C3E2B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchToyAll.LogPair = null;
			ConfigFloroRanchToyAll.HandleId = 0;
		}

		// Token: 0x0600132E RID: 4910 RVA: 0x000C5C39 File Offset: 0x000C3E39
		public static void Init()
		{
			ConfigFloroRanchToyAll.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchToyAll.HandleId, "db_flororanch.db", "select BinData from `FloroRanchToy`");
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x000C5C54 File Offset: 0x000C3E54
		[NullableContext(2)]
		public static IReadOnlyList<FloroRanchToy> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<FloroRanchToy> readOnlyList = (IReadOnlyList<FloroRanchToy>)ConfigCommon.GetConfig("FloroRanchToyAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<FloroRanchToy> list = new List<FloroRanchToy>();
			while (ConfigCommon.Step(ConfigFloroRanchToyAll.HandleId, false, ConfigFloroRanchToyAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchToyAll.HandleId, 0, ConfigFloroRanchToyAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair);
					return null;
				}
				FloroRanchToy rootAsFloroRanchToy = FloroRanchToy.GetRootAsFloroRanchToy(new ByteBuffer(item2));
				list.Add(rootAsFloroRanchToy);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("FloroRanchToyAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigFloroRanchToyAll.HandleId, ConfigFloroRanchToyAll.LogPair);
			return list;
		}

		// Token: 0x0400163B RID: 5691
		private const string DB = "db_flororanch.db";

		// Token: 0x0400163C RID: 5692
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x0400163D RID: 5693
		private const string TABLE = "FloroRanchToy";

		// Token: 0x0400163E RID: 5694
		private const string COMMAND = "select BinData from `FloroRanchToy`";

		// Token: 0x0400163F RID: 5695
		private const string KEY_PREFIX = "FloroRanchToyAll";

		// Token: 0x04001640 RID: 5696
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001641 RID: 5697
		private static int HandleId;
	}
}
