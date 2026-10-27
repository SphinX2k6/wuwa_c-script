using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A13 RID: 2579
	public class ConfigTrackMoonTargetTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C86 RID: 15494 RVA: 0x001B0020 File Offset: 0x001AE220
		static ConfigTrackMoonTargetTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonTargetTypeAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonTargetTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C87 RID: 15495 RVA: 0x001B0040 File Offset: 0x001AE240
		public static void CreateStaticDefaultValue()
		{
			ConfigTrackMoonTargetTypeAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrackMoonTargetTypeAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "TrackMoonTargetType"),
				new ValueTuple<string, object>("语句", "select BinData from `TrackMoonTargetType`")
			});
		}

		// Token: 0x06003C88 RID: 15496 RVA: 0x001B00BF File Offset: 0x001AE2BF
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonTargetTypeAll.LogPair = null;
			ConfigTrackMoonTargetTypeAll.HandleId = 0;
		}

		// Token: 0x06003C89 RID: 15497 RVA: 0x001B00CD File Offset: 0x001AE2CD
		public static void Init()
		{
			ConfigTrackMoonTargetTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonTargetTypeAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonTargetType`");
		}

		// Token: 0x06003C8A RID: 15498 RVA: 0x001B00E8 File Offset: 0x001AE2E8
		[NullableContext(2)]
		public static IReadOnlyList<TrackMoonTargetType> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrackMoonTargetTypeAll.HandleId, ConfigTrackMoonTargetTypeAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<TrackMoonTargetType> readOnlyList = (IReadOnlyList<TrackMoonTargetType>)ConfigCommon.GetConfig("TrackMoonTargetTypeAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<TrackMoonTargetType> list = new List<TrackMoonTargetType>();
			while (ConfigCommon.Step(ConfigTrackMoonTargetTypeAll.HandleId, false, ConfigTrackMoonTargetTypeAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrackMoonTargetTypeAll.HandleId, 0, ConfigTrackMoonTargetTypeAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigTrackMoonTargetTypeAll.HandleId, ConfigTrackMoonTargetTypeAll.LogPair);
					return null;
				}
				TrackMoonTargetType rootAsTrackMoonTargetType = TrackMoonTargetType.GetRootAsTrackMoonTargetType(new ByteBuffer(item2));
				list.Add(rootAsTrackMoonTargetType);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("TrackMoonTargetTypeAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigTrackMoonTargetTypeAll.HandleId, ConfigTrackMoonTargetTypeAll.LogPair);
			return list;
		}

		// Token: 0x0400466B RID: 18027
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400466C RID: 18028
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400466D RID: 18029
		private const string TABLE = "TrackMoonTargetType";

		// Token: 0x0400466E RID: 18030
		private const string COMMAND = "select BinData from `TrackMoonTargetType`";

		// Token: 0x0400466F RID: 18031
		private const string KEY_PREFIX = "TrackMoonTargetTypeAll";

		// Token: 0x04004670 RID: 18032
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004671 RID: 18033
		private static int HandleId;
	}
}
