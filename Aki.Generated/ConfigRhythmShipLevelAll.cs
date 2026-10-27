using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007F4 RID: 2036
	public class ConfigRhythmShipLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FCA RID: 12234 RVA: 0x00167620 File Offset: 0x00165820
		static ConfigRhythmShipLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmShipLevelAll.CreateStaticDefaultValue), new Action(ConfigRhythmShipLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00167640 File Offset: 0x00165840
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

		// Token: 0x06002FCC RID: 12236 RVA: 0x001676BF File Offset: 0x001658BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmShipLevelAll.LogPair = null;
			ConfigRhythmShipLevelAll.HandleId = 0;
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x001676CD File Offset: 0x001658CD
		public static void Init()
		{
			ConfigRhythmShipLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmShipLevelAll.HandleId, "db_rhythmship.db", "select BinData from `RhythmShipLevel`");
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x001676E8 File Offset: 0x001658E8
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

		// Token: 0x04003792 RID: 14226
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003793 RID: 14227
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003794 RID: 14228
		private const string TABLE = "RhythmShipLevel";

		// Token: 0x04003795 RID: 14229
		private const string COMMAND = "select BinData from `RhythmShipLevel`";

		// Token: 0x04003796 RID: 14230
		private const string KEY_PREFIX = "RhythmShipLevelAll";

		// Token: 0x04003797 RID: 14231
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003798 RID: 14232
		private static int HandleId;
	}
}
