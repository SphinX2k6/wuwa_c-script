using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AE RID: 2478
	public class ConfigSurvivorsTemplateAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A28 RID: 14888 RVA: 0x001A2A38 File Offset: 0x001A0C38
		static ConfigSurvivorsTemplateAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTemplateAll.CreateStaticDefaultValue), new Action(ConfigSurvivorsTemplateAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A29 RID: 14889 RVA: 0x001A2A58 File Offset: 0x001A0C58
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTemplateAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTemplateAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_怪物.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTemplate"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTemplate`")
			});
		}

		// Token: 0x06003A2A RID: 14890 RVA: 0x001A2AD7 File Offset: 0x001A0CD7
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTemplateAll.LogPair = null;
			ConfigSurvivorsTemplateAll.HandleId = 0;
		}

		// Token: 0x06003A2B RID: 14891 RVA: 0x001A2AE5 File Offset: 0x001A0CE5
		public static void Init()
		{
			ConfigSurvivorsTemplateAll.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTemplateAll.HandleId, "db_survivors.db", "select BinData from `SurvivorsTemplate`");
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x001A2B00 File Offset: 0x001A0D00
		[NullableContext(2)]
		public static IReadOnlyList<SurvivorsTemplate> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTemplateAll.HandleId, ConfigSurvivorsTemplateAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SurvivorsTemplate> readOnlyList = (IReadOnlyList<SurvivorsTemplate>)ConfigCommon.GetConfig("SurvivorsTemplateAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SurvivorsTemplate> list = new List<SurvivorsTemplate>();
			while (ConfigCommon.Step(ConfigSurvivorsTemplateAll.HandleId, false, ConfigSurvivorsTemplateAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTemplateAll.HandleId, 0, ConfigSurvivorsTemplateAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSurvivorsTemplateAll.HandleId, ConfigSurvivorsTemplateAll.LogPair);
					return null;
				}
				SurvivorsTemplate rootAsSurvivorsTemplate = SurvivorsTemplate.GetRootAsSurvivorsTemplate(new ByteBuffer(item2));
				list.Add(rootAsSurvivorsTemplate);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SurvivorsTemplateAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSurvivorsTemplateAll.HandleId, ConfigSurvivorsTemplateAll.LogPair);
			return list;
		}

		// Token: 0x040043A8 RID: 17320
		private const string DB = "db_survivors.db";

		// Token: 0x040043A9 RID: 17321
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x040043AA RID: 17322
		private const string TABLE = "SurvivorsTemplate";

		// Token: 0x040043AB RID: 17323
		private const string COMMAND = "select BinData from `SurvivorsTemplate`";

		// Token: 0x040043AC RID: 17324
		private const string KEY_PREFIX = "SurvivorsTemplateAll";

		// Token: 0x040043AD RID: 17325
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043AE RID: 17326
		private static int HandleId;
	}
}
