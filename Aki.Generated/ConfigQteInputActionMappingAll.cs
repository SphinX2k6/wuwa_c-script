using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000784 RID: 1924
	public class ConfigQteInputActionMappingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002D29 RID: 11561 RVA: 0x0015BFD8 File Offset: 0x0015A1D8
		static ConfigQteInputActionMappingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigQteInputActionMappingAll.CreateStaticDefaultValue), new Action(ConfigQteInputActionMappingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0015BFF8 File Offset: 0x0015A1F8
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

		// Token: 0x06002D2B RID: 11563 RVA: 0x0015C077 File Offset: 0x0015A277
		public static void ResetStaticDefaultValue()
		{
			ConfigQteInputActionMappingAll.LogPair = null;
			ConfigQteInputActionMappingAll.HandleId = 0;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0015C085 File Offset: 0x0015A285
		public static void Init()
		{
			ConfigQteInputActionMappingAll.HandleId = ConfigCommon.InitDataStatement(ConfigQteInputActionMappingAll.HandleId, "db_input_settings.db", "select BinData from `QteInputActionMapping`");
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0015C0A0 File Offset: 0x0015A2A0
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

		// Token: 0x04003482 RID: 13442
		private const string DB = "db_input_settings.db";

		// Token: 0x04003483 RID: 13443
		private const string FILE = "s.输入配置.xlsx";

		// Token: 0x04003484 RID: 13444
		private const string TABLE = "QteInputActionMapping";

		// Token: 0x04003485 RID: 13445
		private const string COMMAND = "select BinData from `QteInputActionMapping`";

		// Token: 0x04003486 RID: 13446
		private const string KEY_PREFIX = "QteInputActionMappingAll";

		// Token: 0x04003487 RID: 13447
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003488 RID: 13448
		private static int HandleId;
	}
}
