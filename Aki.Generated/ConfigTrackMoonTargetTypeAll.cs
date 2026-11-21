using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE8 RID: 2792
	public class ConfigTrackMoonTargetTypeAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004184 RID: 16772 RVA: 0x001CF3B4 File Offset: 0x001CD5B4
		static ConfigTrackMoonTargetTypeAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrackMoonTargetTypeAll.CreateStaticDefaultValue), new Action(ConfigTrackMoonTargetTypeAll.ResetStaticDefaultValue));
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x001CF3D4 File Offset: 0x001CD5D4
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

		// Token: 0x06004186 RID: 16774 RVA: 0x001CF453 File Offset: 0x001CD653
		public static void ResetStaticDefaultValue()
		{
			ConfigTrackMoonTargetTypeAll.LogPair = null;
			ConfigTrackMoonTargetTypeAll.HandleId = 0;
		}

		// Token: 0x06004187 RID: 16775 RVA: 0x001CF461 File Offset: 0x001CD661
		public static void Init()
		{
			ConfigTrackMoonTargetTypeAll.HandleId = ConfigCommon.InitDataStatement(ConfigTrackMoonTargetTypeAll.HandleId, "db_moonchasing.db", "select BinData from `TrackMoonTargetType`");
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x001CF47C File Offset: 0x001CD67C
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

		// Token: 0x04004C3E RID: 19518
		private const string DB = "db_moonchasing.db";

		// Token: 0x04004C3F RID: 19519
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04004C40 RID: 19520
		private const string TABLE = "TrackMoonTargetType";

		// Token: 0x04004C41 RID: 19521
		private const string COMMAND = "select BinData from `TrackMoonTargetType`";

		// Token: 0x04004C42 RID: 19522
		private const string KEY_PREFIX = "TrackMoonTargetTypeAll";

		// Token: 0x04004C43 RID: 19523
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004C44 RID: 19524
		private static int HandleId;
	}
}
