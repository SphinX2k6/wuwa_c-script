using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE3 RID: 2787
	public class ConfigTrackMoonMemoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004166 RID: 16742 RVA: 0x001CE910 File Offset: 0x001CCB10
		static ConfigTrackMoonMemoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004167 RID: 16743 RVA: 0x001CE930 File Offset: 0x001CCB30
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonMemoryAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonMemoryAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonMemory"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonMemory`")
			});
		}

		// Token: 0x06004168 RID: 16744 RVA: 0x001CE9AF File Offset: 0x001CCBAF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryAll.LogPair = null;
			ConfigTrackMoonMemoryAll.HandleId = 0;
		}

		// Token: 0x06004169 RID: 16745 RVA: 0x001CE9BD File Offset: 0x001CCBBD
		public static void Init()
		{
			ConfigTrackMoonMemoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory`");
		}

		// Token: 0x0600416A RID: 16746 RVA: 0x001CE9D8 File Offset: 0x001CCBD8
		[NullableContext(2)]
		public static IReadOnlyList<TrackMoonMemory> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonMemoryAll.HandleId, ConfigTrackMoonMemoryAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrackMoonMemory> readOnlyList = (IReadOnlyList<TrackMoonMemory>)ConfigCommon.GetConfig("TrackMoonMemoryAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrackMoonMemory> list = new List<TrackMoonMemory>();
			while (ConfigCommon.Step(ConfigTrackMoonMemoryAll.HandleId, false, ConfigTrackMoonMemoryAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonMemoryAll.HandleId, 0, ConfigTrackMoonMemoryAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrackMoonMemoryAll.HandleId, ConfigTrackMoonMemoryAll.LogPair);
					return null;
				}
				TrackMoonMemory rootAsTrackMoonMemory = TrackMoonMemory.GetRootAsTrackMoonMemory(new ByteBuffer(item2));
				list.Add(rootAsTrackMoonMemory);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrackMoonMemoryAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrackMoonMemoryAll.HandleId, ConfigTrackMoonMemoryAll.LogPair);
			return list;
		}

		// Token: 0x04004C1B RID: 19483
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C1C RID: 19484
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C1D RID: 19485
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x04004C1E RID: 19486
		private const string COMMAND = "select BinData from `TrackMoonMemory`";

		// Token: 0x04004C1F RID: 19487
		private const string KEY_PREFIX = "TrackMoonMemoryAll";

		// Token: 0x04004C20 RID: 19488
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C21 RID: 19489
		private static int HandleId;
	}
}
