using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000899 RID: 2201
	public class ConfigRogueWeekQualityConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033A8 RID: 13224 RVA: 0x00180E48 File Offset: 0x0017F048
		static ConfigRogueWeekQualityConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueWeekQualityConfigAll.CreateStaticDefaultValue), new Action(ConfigRogueWeekQualityConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x00180E68 File Offset: 0x0017F068
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

		// Token: 0x060033AA RID: 13226 RVA: 0x00180EE7 File Offset: 0x0017F0E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueWeekQualityConfigAll.LogPair = null;
			ConfigRogueWeekQualityConfigAll.HandleId = 0;
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00180EF5 File Offset: 0x0017F0F5
		public static void Init()
		{
			ConfigRogueWeekQualityConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRogueWeekQualityConfigAll.HandleId, "db_weeklyrogue.db", "select BinData from `RogueWeekQualityConfig`");
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00180F10 File Offset: 0x0017F110
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

		// Token: 0x04003C15 RID: 15381
		private const string DB = "db_weeklyrogue.db";

		// Token: 0x04003C16 RID: 15382
		private const string FILE = "r.肉鸽周常.xlsx";

		// Token: 0x04003C17 RID: 15383
		private const string TABLE = "RogueWeekQualityConfig";

		// Token: 0x04003C18 RID: 15384
		private const string COMMAND = "select BinData from `RogueWeekQualityConfig`";

		// Token: 0x04003C19 RID: 15385
		private const string KEY_PREFIX = "RogueWeekQualityConfigAll";

		// Token: 0x04003C1A RID: 15386
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C1B RID: 15387
		private static int HandleId;
	}
}
