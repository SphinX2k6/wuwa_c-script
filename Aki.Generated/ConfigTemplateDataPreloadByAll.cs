using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AA2 RID: 2722
	public class ConfigTemplateDataPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FE0 RID: 16352 RVA: 0x001C5F5C File Offset: 0x001C415C
		static ConfigTemplateDataPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateDataPreloadByAll.CreateStaticDefaultValue), new Action(ConfigTemplateDataPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x001C5F7C File Offset: 0x001C417C
		public static void CreateStaticDefaultValue()
		{
			ConfigTemplateDataPreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemplateDataPreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_templatedata_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/TemplateDataPreload.csv"),
				new ValueTuple<string, object>("表名", "TemplateDataPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `TemplateDataPreload`")
			});
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x001C5FFB File Offset: 0x001C41FB
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateDataPreloadByAll.LogPair = null;
			ConfigTemplateDataPreloadByAll.HandleId = 0;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x001C6009 File Offset: 0x001C4209
		public static void Init()
		{
			ConfigTemplateDataPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateDataPreloadByAll.HandleId, "db_templatedata_preload.db", "select BinData from `TemplateDataPreload`");
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x001C6024 File Offset: 0x001C4224
		[NullableContext(2)]
		public static IReadOnlyList<TemplateDataPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemplateDataPreloadByAll.HandleId, ConfigTemplateDataPreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TemplateDataPreload> readOnlyList = (IReadOnlyList<TemplateDataPreload>)ConfigCommon.GetConfig("TemplateDataPreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TemplateDataPreload> list = new List<TemplateDataPreload>();
			while (ConfigCommon.Step(ConfigTemplateDataPreloadByAll.HandleId, false, ConfigTemplateDataPreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemplateDataPreloadByAll.HandleId, 0, ConfigTemplateDataPreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTemplateDataPreloadByAll.HandleId, ConfigTemplateDataPreloadByAll.LogPair);
					return null;
				}
				TemplateDataPreload rootAsTemplateDataPreload = TemplateDataPreload.GetRootAsTemplateDataPreload(new ByteBuffer(item2));
				list.Add(rootAsTemplateDataPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TemplateDataPreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTemplateDataPreloadByAll.HandleId, ConfigTemplateDataPreloadByAll.LogPair);
			return list;
		}

		// Token: 0x04004A54 RID: 19028
		private const string DB = "db_templatedata_preload.db";

		// Token: 0x04004A55 RID: 19029
		private const string FILE = "Preload/TemplateDataPreload.csv";

		// Token: 0x04004A56 RID: 19030
		private const string TABLE = "TemplateDataPreload";

		// Token: 0x04004A57 RID: 19031
		private const string COMMAND = "select BinData from `TemplateDataPreload`";

		// Token: 0x04004A58 RID: 19032
		private const string KEY_PREFIX = "TemplateDataPreloadByAll";

		// Token: 0x04004A59 RID: 19033
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A5A RID: 19034
		private static int HandleId;
	}
}
