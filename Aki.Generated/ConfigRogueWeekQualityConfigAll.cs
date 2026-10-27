using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200087D RID: 2173
	public class ConfigRogueWeekQualityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003300 RID: 13056 RVA: 0x00179B60 File Offset: 0x00177D60
		static ConfigRogueWeekQualityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekQualityConfigAll.CreateStaticDefaultValue), new Action(ConfigRogueWeekQualityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003301 RID: 13057 RVA: 0x00179B80 File Offset: 0x00177D80
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueWeekQualityConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weeklyrogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽周常.xlsx"),
				new ValueTuple<string, object>("表名", "RogueWeekQualityConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueWeekQualityConfig`")
			});
		}

		// Token: 0x06003302 RID: 13058 RVA: 0x00179BFF File Offset: 0x00177DFF
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigAll.LogPair = null;
			ConfigRogueWeekQualityConfigAll.HandleId = 0;
		}

		// Token: 0x06003303 RID: 13059 RVA: 0x00179C0D File Offset: 0x00177E0D
		public static void Init()
		{
			ConfigRogueWeekQualityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekQualityConfigAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekQualityConfig`");
		}

		// Token: 0x06003304 RID: 13060 RVA: 0x00179C28 File Offset: 0x00177E28
		[NullableContext(2)]
		public static IReadOnlyList<RogueWeekQualityConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueWeekQualityConfigAll.HandleId, ConfigRogueWeekQualityConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RogueWeekQualityConfig> readOnlyList = (IReadOnlyList<RogueWeekQualityConfig>)ConfigCommon.GetConfig("RogueWeekQualityConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RogueWeekQualityConfig> list = new List<RogueWeekQualityConfig>();
			while (ConfigCommon.Step(ConfigRogueWeekQualityConfigAll.HandleId, false, ConfigRogueWeekQualityConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueWeekQualityConfigAll.HandleId, 0, ConfigRogueWeekQualityConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRogueWeekQualityConfigAll.HandleId, ConfigRogueWeekQualityConfigAll.LogPair);
					return null;
				}
				RogueWeekQualityConfig rootAsRogueWeekQualityConfig = RogueWeekQualityConfig.GetRootAsRogueWeekQualityConfig(new ByteBuffer(item2));
				list.Add(rootAsRogueWeekQualityConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RogueWeekQualityConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRogueWeekQualityConfigAll.HandleId, ConfigRogueWeekQualityConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003B51 RID: 15185
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003B52 RID: 15186
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003B53 RID: 15187
		private const string TABLE = "RogueWeekQualityConfig";

		// Token: 0x04003B54 RID: 15188
		private const string COMMAND = "select BinData from `RogueWeekQualityConfig`";

		// Token: 0x04003B55 RID: 15189
		private const string KEY_PREFIX = "RogueWeekQualityConfigAll";

		// Token: 0x04003B56 RID: 15190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003B57 RID: 15191
		private static int HandleId;
	}
}
