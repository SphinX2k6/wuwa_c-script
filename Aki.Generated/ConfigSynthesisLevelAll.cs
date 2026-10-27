using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BD RID: 2493
	public class ConfigSynthesisLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A82 RID: 14978 RVA: 0x001A4B2C File Offset: 0x001A2D2C
		static ConfigSynthesisLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSynthesisLevelAll.CreateStaticDefaultValue), new Action(ConfigSynthesisLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A83 RID: 14979 RVA: 0x001A4B4C File Offset: 0x001A2D4C
		public static void CreateStaticDefaultValue()
		{
			ConfigSynthesisLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSynthesisLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_compose.db"),
				new ValueTuple<string, object>("文件", "h.合成.xlsx"),
				new ValueTuple<string, object>("表名", "SynthesisLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SynthesisLevel`")
			});
		}

		// Token: 0x06003A84 RID: 14980 RVA: 0x001A4BCB File Offset: 0x001A2DCB
		public static void ResetStaticDefaultValue()
		{
			ConfigSynthesisLevelAll.LogPair = null;
			ConfigSynthesisLevelAll.HandleId = 0;
		}

		// Token: 0x06003A85 RID: 14981 RVA: 0x001A4BD9 File Offset: 0x001A2DD9
		public static void Init()
		{
			ConfigSynthesisLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigSynthesisLevelAll.HandleId, "db_compose.db", "select BinData from `SynthesisLevel`");
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x001A4BF4 File Offset: 0x001A2DF4
		[NullableContext(2)]
		public static IReadOnlyList<SynthesisLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SynthesisLevel> readOnlyList = (IReadOnlyList<SynthesisLevel>)ConfigCommon.GetConfig("SynthesisLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SynthesisLevel> list = new List<SynthesisLevel>();
			while (ConfigCommon.Step(ConfigSynthesisLevelAll.HandleId, false, ConfigSynthesisLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSynthesisLevelAll.HandleId, 0, ConfigSynthesisLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair);
					return null;
				}
				SynthesisLevel rootAsSynthesisLevel = SynthesisLevel.GetRootAsSynthesisLevel(new ByteBuffer(item2));
				list.Add(rootAsSynthesisLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SynthesisLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSynthesisLevelAll.HandleId, ConfigSynthesisLevelAll.LogPair);
			return list;
		}

		// Token: 0x04004411 RID: 17425
		private const string DB = "db_compose.db";

		// Token: 0x04004412 RID: 17426
		private const string FILE = "h.合成.xlsx";

		// Token: 0x04004413 RID: 17427
		private const string TABLE = "SynthesisLevel";

		// Token: 0x04004414 RID: 17428
		private const string COMMAND = "select BinData from `SynthesisLevel`";

		// Token: 0x04004415 RID: 17429
		private const string KEY_PREFIX = "SynthesisLevelAll";

		// Token: 0x04004416 RID: 17430
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004417 RID: 17431
		private static int HandleId;
	}
}
