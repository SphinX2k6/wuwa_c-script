using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000810 RID: 2064
	public class ConfigRhythmShipLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003072 RID: 12402 RVA: 0x0016E908 File Offset: 0x0016CB08
		static ConfigRhythmShipLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003073 RID: 12403 RVA: 0x0016E928 File Offset: 0x0016CB28
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmShipLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmShipLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmShipLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmShipLevel`")
			});
		}

		// Token: 0x06003074 RID: 12404 RVA: 0x0016E9A7 File Offset: 0x0016CBA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelAll.LogPair = null;
			ConfigRhythmShipLevelAll.HandleId = 0;
		}

		// Token: 0x06003075 RID: 12405 RVA: 0x0016E9B5 File Offset: 0x0016CBB5
		public static void Init()
		{
			ConfigRhythmShipLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel`");
		}

		// Token: 0x06003076 RID: 12406 RVA: 0x0016E9D0 File Offset: 0x0016CBD0
		[NullableContext(2)]
		public static IReadOnlyList<RhythmShipLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmShipLevelAll.HandleId, ConfigRhythmShipLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RhythmShipLevel> readOnlyList = (IReadOnlyList<RhythmShipLevel>)ConfigCommon.GetConfig("RhythmShipLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RhythmShipLevel> list = new List<RhythmShipLevel>();
			while (ConfigCommon.Step(ConfigRhythmShipLevelAll.HandleId, false, ConfigRhythmShipLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmShipLevelAll.HandleId, 0, ConfigRhythmShipLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRhythmShipLevelAll.HandleId, ConfigRhythmShipLevelAll.LogPair);
					return null;
				}
				RhythmShipLevel rootAsRhythmShipLevel = RhythmShipLevel.GetRootAsRhythmShipLevel(new ByteBuffer(item2));
				list.Add(rootAsRhythmShipLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RhythmShipLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRhythmShipLevelAll.HandleId, ConfigRhythmShipLevelAll.LogPair);
			return list;
		}

		// Token: 0x04003856 RID: 14422
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003857 RID: 14423
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003858 RID: 14424
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x04003859 RID: 14425
		private const string COMMAND = "select BinData from `RhythmShipLevel`";

		// Token: 0x0400385A RID: 14426
		private const string KEY_PREFIX = "RhythmShipLevelAll";

		// Token: 0x0400385B RID: 14427
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400385C RID: 14428
		private static int HandleId;
	}
}
