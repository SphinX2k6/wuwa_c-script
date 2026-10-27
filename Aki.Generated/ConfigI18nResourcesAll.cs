using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000416 RID: 1046
	public class ConfigI18nResourcesAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600188D RID: 6285 RVA: 0x000E4A98 File Offset: 0x000E2C98
		static ConfigI18nResourcesAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigI18nResourcesAll.CreateStaticDefaultValue), new Action(ConfigI18nResourcesAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000E4AB8 File Offset: 0x000E2CB8
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

		// Token: 0x0600188F RID: 6287 RVA: 0x000E4B37 File Offset: 0x000E2D37
		public static void ResetStaticDefaultValue()
		{
			ConfigI18nResourcesAll.LogPair = null;
			ConfigI18nResourcesAll.HandleId = 0;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x000E4B45 File Offset: 0x000E2D45
		public static void Init()
		{
			ConfigI18nResourcesAll.HandleId = ConfigCommon.InitDataStatement(ConfigI18nResourcesAll.HandleId, "db_i18nresources.db", "select BinData from `I18nResources`");
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x000E4B60 File Offset: 0x000E2D60
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

		// Token: 0x04001C7E RID: 7294
		private const string DB = "db_i18nresources.db";

		// Token: 0x04001C7F RID: 7295
		private const string FILE = "i.i18n资源.xlsx";

		// Token: 0x04001C80 RID: 7296
		private const string TABLE = "I18nResources";

		// Token: 0x04001C81 RID: 7297
		private const string COMMAND = "select BinData from `I18nResources`";

		// Token: 0x04001C82 RID: 7298
		private const string KEY_PREFIX = "I18nResourcesAll";

		// Token: 0x04001C83 RID: 7299
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C84 RID: 7300
		private static int HandleId;
	}
}
