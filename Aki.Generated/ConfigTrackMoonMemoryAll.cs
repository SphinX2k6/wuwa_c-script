using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0E RID: 2574
	public class ConfigTrackMoonMemoryAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C68 RID: 15464 RVA: 0x001AF57C File Offset: 0x001AD77C
		static ConfigTrackMoonMemoryAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonMemoryAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonMemoryAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001AF59C File Offset: 0x001AD79C
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

		// Token: 0x06003C6A RID: 15466 RVA: 0x001AF61B File Offset: 0x001AD81B
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonMemoryAll.LogPair = null;
			ConfigTrackMoonMemoryAll.HandleId = 0;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x001AF629 File Offset: 0x001AD829
		public static void Init()
		{
			ConfigTrackMoonMemoryAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonMemoryAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonMemory`");
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x001AF644 File Offset: 0x001AD844
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

		// Token: 0x04004648 RID: 17992
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004649 RID: 17993
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400464A RID: 17994
		private const string TABLE = "TrackMoonMemory";

		// Token: 0x0400464B RID: 17995
		private const string COMMAND = "select BinData from `TrackMoonMemory`";

		// Token: 0x0400464C RID: 17996
		private const string KEY_PREFIX = "TrackMoonMemoryAll";

		// Token: 0x0400464D RID: 17997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400464E RID: 17998
		private static int HandleId;
	}
}
