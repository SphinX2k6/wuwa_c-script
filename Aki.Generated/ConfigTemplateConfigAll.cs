using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A9F RID: 2719
	public class ConfigTemplateConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x001C5988 File Offset: 0x001C3B88
		static ConfigTemplateConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigAll.CreateStaticDefaultValue), new Action(ConfigTemplateConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003FCF RID: 16335 RVA: 0x001C59A8 File Offset: 0x001C3BA8
		public static void CreateStaticDefaultValue()
		{
			ConfigTemplateConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTemplateConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_template.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Entity/Template.csv"),
				new ValueTuple<string, object>("表名", "TemplateConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `TemplateConfig`")
			});
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x001C5A27 File Offset: 0x001C3C27
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigAll.LogPair = null;
			ConfigTemplateConfigAll.HandleId = 0;
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x001C5A35 File Offset: 0x001C3C35
		public static void Init()
		{
			ConfigTemplateConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigAll.HandleId, "db_template.db", "select BinData from `TemplateConfig`");
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x001C5A50 File Offset: 0x001C3C50
		[NullableContext(2)]
		public static IReadOnlyList<TemplateConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTemplateConfigAll.HandleId, ConfigTemplateConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TemplateConfig> readOnlyList = (IReadOnlyList<TemplateConfig>)ConfigCommon.GetConfig("TemplateConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TemplateConfig> list = new List<TemplateConfig>();
			while (ConfigCommon.Step(ConfigTemplateConfigAll.HandleId, false, ConfigTemplateConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTemplateConfigAll.HandleId, 0, ConfigTemplateConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTemplateConfigAll.HandleId, ConfigTemplateConfigAll.LogPair);
					return null;
				}
				TemplateConfig rootAsTemplateConfig = TemplateConfig.GetRootAsTemplateConfig(new ByteBuffer(item2));
				list.Add(rootAsTemplateConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TemplateConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTemplateConfigAll.HandleId, ConfigTemplateConfigAll.LogPair);
			return list;
		}

		// Token: 0x04004A3F RID: 19007
		private const string DB = "db_template.db";

		// Token: 0x04004A40 RID: 19008
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x04004A41 RID: 19009
		private const string TABLE = "TemplateConfig";

		// Token: 0x04004A42 RID: 19010
		private const string COMMAND = "select BinData from `TemplateConfig`";

		// Token: 0x04004A43 RID: 19011
		private const string KEY_PREFIX = "TemplateConfigAll";

		// Token: 0x04004A44 RID: 19012
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004A45 RID: 19013
		private static int HandleId;
	}
}
