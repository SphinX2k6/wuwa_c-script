using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200076A RID: 1898
	public class ConfigQteInputActionMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C8D RID: 11405 RVA: 0x001550CC File Offset: 0x001532CC
		static ConfigQteInputActionMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingAll.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x001550EC File Offset: 0x001532EC
		public static void CreateStaticDefaultValue()
		{
			ConfigQteInputActionMappingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigQteInputActionMappingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_input_settings.db"),
				new ValueTuple<string, object>("文件", "s.输入配置.xlsx"),
				new ValueTuple<string, object>("表名", "QteInputActionMapping"),
				new ValueTuple<string, object>("语句", "select BinData from `QteInputActionMapping`")
			});
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x0015516B File Offset: 0x0015336B
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingAll.LogPair = null;
			ConfigQteInputActionMappingAll.HandleId = 0;
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x00155179 File Offset: 0x00153379
		public static void Init()
		{
			ConfigQteInputActionMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingAll.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping`");
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00155194 File Offset: 0x00153394
		[NullableContext(2)]
		public static IReadOnlyList<QteInputActionMapping> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigQteInputActionMappingAll.HandleId, ConfigQteInputActionMappingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<QteInputActionMapping> readOnlyList = (IReadOnlyList<QteInputActionMapping>)ConfigCommon.GetConfig("QteInputActionMappingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<QteInputActionMapping> list = new List<QteInputActionMapping>();
			while (ConfigCommon.Step(ConfigQteInputActionMappingAll.HandleId, false, ConfigQteInputActionMappingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigQteInputActionMappingAll.HandleId, 0, ConfigQteInputActionMappingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigQteInputActionMappingAll.HandleId, ConfigQteInputActionMappingAll.LogPair);
					return null;
				}
				QteInputActionMapping rootAsQteInputActionMapping = QteInputActionMapping.GetRootAsQteInputActionMapping(new ByteBuffer(item2));
				list.Add(rootAsQteInputActionMapping);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("QteInputActionMappingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigQteInputActionMappingAll.HandleId, ConfigQteInputActionMappingAll.LogPair);
			return list;
		}

		// Token: 0x040033CC RID: 13260
		private const string DB = "db_input_settings.db";

		// Token: 0x040033CD RID: 13261
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x040033CE RID: 13262
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x040033CF RID: 13263
		private const string COMMAND = "select BinData from `QteInputActionMapping`";

		// Token: 0x040033D0 RID: 13264
		private const string KEY_PREFIX = "QteInputActionMappingAll";

		// Token: 0x040033D1 RID: 13265
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033D2 RID: 13266
		private static int HandleId;
	}
}
