using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A83 RID: 2691
	public class ConfigSurvivorsTemplateAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F26 RID: 16166 RVA: 0x001C1DCC File Offset: 0x001BFFCC
		static ConfigSurvivorsTemplateAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTemplateAll.CreateStaticDefaultValue), new Action(ConfigSurvivorsTemplateAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x001C1DEC File Offset: 0x001BFFEC
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

		// Token: 0x06003F28 RID: 16168 RVA: 0x001C1E6B File Offset: 0x001C006B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTemplateAll.LogPair = null;
			ConfigSurvivorsTemplateAll.HandleId = 0;
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x001C1E79 File Offset: 0x001C0079
		public static void Init()
		{
			ConfigSurvivorsTemplateAll.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTemplateAll.HandleId, "db_survivors.db", "select BinData from `SurvivorsTemplate`");
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x001C1E94 File Offset: 0x001C0094
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

		// Token: 0x0400497B RID: 18811
		private const string DB = "db_survivors.db";

		// Token: 0x0400497C RID: 18812
		private const string FILE = "x.幸存者_怪物.xlsx";

		// Token: 0x0400497D RID: 18813
		private const string TABLE = "SurvivorsTemplate";

		// Token: 0x0400497E RID: 18814
		private const string COMMAND = "select BinData from `SurvivorsTemplate`";

		// Token: 0x0400497F RID: 18815
		private const string KEY_PREFIX = "SurvivorsTemplateAll";

		// Token: 0x04004980 RID: 18816
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004981 RID: 18817
		private static int HandleId;
	}
}
