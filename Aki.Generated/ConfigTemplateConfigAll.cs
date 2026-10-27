using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CA RID: 2506
	public class ConfigTemplateConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AD0 RID: 15056 RVA: 0x001A65F4 File Offset: 0x001A47F4
		static ConfigTemplateConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateConfigAll.CreateStaticDefaultValue), new Action(ConfigTemplateConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003AD1 RID: 15057 RVA: 0x001A6614 File Offset: 0x001A4814
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

		// Token: 0x06003AD2 RID: 15058 RVA: 0x001A6693 File Offset: 0x001A4893
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateConfigAll.LogPair = null;
			ConfigTemplateConfigAll.HandleId = 0;
		}

		// Token: 0x06003AD3 RID: 15059 RVA: 0x001A66A1 File Offset: 0x001A48A1
		public static void Init()
		{
			ConfigTemplateConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateConfigAll.HandleId, "db_template.db", "select BinData from `TemplateConfig`");
		}

		// Token: 0x06003AD4 RID: 15060 RVA: 0x001A66BC File Offset: 0x001A48BC
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

		// Token: 0x0400446C RID: 17516
		private const string DB = "db_template.db";

		// Token: 0x0400446D RID: 17517
		private const string FILE = "UniverseEditor/Entity/Template.csv";

		// Token: 0x0400446E RID: 17518
		private const string TABLE = "TemplateConfig";

		// Token: 0x0400446F RID: 17519
		private const string COMMAND = "select BinData from `TemplateConfig`";

		// Token: 0x04004470 RID: 17520
		private const string KEY_PREFIX = "TemplateConfigAll";

		// Token: 0x04004471 RID: 17521
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004472 RID: 17522
		private static int HandleId;
	}
}
