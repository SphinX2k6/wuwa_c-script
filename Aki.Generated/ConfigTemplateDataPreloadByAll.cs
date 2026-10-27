using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CD RID: 2509
	public class ConfigTemplateDataPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AE2 RID: 15074 RVA: 0x001A6BC8 File Offset: 0x001A4DC8
		static ConfigTemplateDataPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTemplateDataPreloadByAll.CreateStaticDefaultValue), new Action(ConfigTemplateDataPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003AE3 RID: 15075 RVA: 0x001A6BE8 File Offset: 0x001A4DE8
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

		// Token: 0x06003AE4 RID: 15076 RVA: 0x001A6C67 File Offset: 0x001A4E67
		public static void ResetStaticDefaultValue()
		{
			ConfigTemplateDataPreloadByAll.LogPair = null;
			ConfigTemplateDataPreloadByAll.HandleId = 0;
		}

		// Token: 0x06003AE5 RID: 15077 RVA: 0x001A6C75 File Offset: 0x001A4E75
		public static void Init()
		{
			ConfigTemplateDataPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigTemplateDataPreloadByAll.HandleId, "db_templatedata_preload.db", "select BinData from `TemplateDataPreload`");
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x001A6C90 File Offset: 0x001A4E90
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

		// Token: 0x04004481 RID: 17537
		private const string DB = "db_templatedata_preload.db";

		// Token: 0x04004482 RID: 17538
		private const string FILE = "Preload/TemplateDataPreload.csv";

		// Token: 0x04004483 RID: 17539
		private const string TABLE = "TemplateDataPreload";

		// Token: 0x04004484 RID: 17540
		private const string COMMAND = "select BinData from `TemplateDataPreload`";

		// Token: 0x04004485 RID: 17541
		private const string KEY_PREFIX = "TemplateDataPreloadByAll";

		// Token: 0x04004486 RID: 17542
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004487 RID: 17543
		private static int HandleId;
	}
}
