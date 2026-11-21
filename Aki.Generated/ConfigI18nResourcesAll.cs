using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200042C RID: 1068
	public class ConfigI18nResourcesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001911 RID: 6417 RVA: 0x000EB1EC File Offset: 0x000E93EC
		static ConfigI18nResourcesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nResourcesAll.CreateStaticDefaultValue), new Action(ConfigI18nResourcesAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000EB20C File Offset: 0x000E940C
		public static void CreateStaticDefaultValue()
		{
			ConfigI18nResourcesAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigI18nResourcesAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_i18nresources.db"),
				new ValueTuple<string, object>("文件", "i.i18n资源.xlsx"),
				new ValueTuple<string, object>("表名", "I18nResources"),
				new ValueTuple<string, object>("语句", "select BinData from `I18nResources`")
			});
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x000EB28B File Offset: 0x000E948B
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nResourcesAll.LogPair = null;
			ConfigI18nResourcesAll.HandleId = 0;
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x000EB299 File Offset: 0x000E9499
		public static void Init()
		{
			ConfigI18nResourcesAll.HandleId = ConfigCommon.InitDataStatement(ConfigI18nResourcesAll.HandleId, "db_i18nresources.db", "select BinData from `I18nResources`");
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x000EB2B4 File Offset: 0x000E94B4
		[NullableContext(2)]
		public static IReadOnlyList<I18nResources> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigI18nResourcesAll.HandleId, ConfigI18nResourcesAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<I18nResources> readOnlyList = (IReadOnlyList<I18nResources>)ConfigCommon.GetConfig("I18nResourcesAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<I18nResources> list = new List<I18nResources>();
			while (ConfigCommon.Step(ConfigI18nResourcesAll.HandleId, false, ConfigI18nResourcesAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigI18nResourcesAll.HandleId, 0, ConfigI18nResourcesAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigI18nResourcesAll.HandleId, ConfigI18nResourcesAll.LogPair);
					return null;
				}
				I18nResources rootAsI18nResources = I18nResources.GetRootAsI18nResources(new ByteBuffer(item2));
				list.Add(rootAsI18nResources);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("I18nResourcesAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigI18nResourcesAll.HandleId, ConfigI18nResourcesAll.LogPair);
			return list;
		}

		// Token: 0x04001D18 RID: 7448
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001D19 RID: 7449
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001D1A RID: 7450
		private const string TABLE = "I18nResources";

		// Token: 0x04001D1B RID: 7451
		private const string COMMAND = "select BinData from `I18nResources`";

		// Token: 0x04001D1C RID: 7452
		private const string KEY_PREFIX = "I18nResourcesAll";

		// Token: 0x04001D1D RID: 7453
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D1E RID: 7454
		private static int HandleId;
	}
}
