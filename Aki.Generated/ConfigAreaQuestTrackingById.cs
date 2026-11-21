using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B0 RID: 176
	public class ConfigAreaQuestTrackingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000421 RID: 1057 RVA: 0x000747D8 File Offset: 0x000729D8
		static ConfigAreaQuestTrackingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaQuestTrackingById.CreateStaticDefaultValue), new Action(ConfigAreaQuestTrackingById.ResetStaticDefaultValue));
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x000747F8 File Offset: 0x000729F8
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaQuestTrackingById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaQuestTrackingById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaquesttracking.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/AreaQuestTracking.csv"),
				new ValueTuple<string, object>("表名", "AreaQuestTracking"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaQuestTracking` where Id=?")
			});
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00074877 File Offset: 0x00072A77
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaQuestTrackingById.LogPair = null;
			ConfigAreaQuestTrackingById.HandleId = 0;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00074885 File Offset: 0x00072A85
		public static void Init()
		{
			ConfigAreaQuestTrackingById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaQuestTrackingById.HandleId, "db_areaquesttracking.db", "select BinData from `AreaQuestTracking` where Id=?");
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000748A0 File Offset: 0x00072AA0
		public static AreaQuestTracking? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaQuestTrackingById.HandleId, ConfigAreaQuestTrackingById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("AreaQuestTrackingById#" + p0Id);
				if (configBuffer != null)
				{
					return new AreaQuestTracking?(AreaQuestTracking.GetRootAsAreaQuestTracking(configBuffer));
				}
			}
			ConfigAreaQuestTrackingById.LogPair.Clear();
			ConfigAreaQuestTrackingById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigAreaQuestTrackingById.HandleId, 1, p0Id, ConfigAreaQuestTrackingById.LogPair) || ConfigCommon.Step(ConfigAreaQuestTrackingById.HandleId, true, ConfigAreaQuestTrackingById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAreaQuestTrackingById.HandleId, ConfigAreaQuestTrackingById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaQuestTrackingById.HandleId, 0, ConfigAreaQuestTrackingById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAreaQuestTrackingById.HandleId, ConfigAreaQuestTrackingById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AreaQuestTracking rootAsAreaQuestTracking = AreaQuestTracking.GetRootAsAreaQuestTracking(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("AreaQuestTrackingById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAreaQuestTrackingById.HandleId, ConfigAreaQuestTrackingById.LogPair);
			return new AreaQuestTracking?(rootAsAreaQuestTracking);
		}

		// Token: 0x040004B4 RID: 1204
		private const string DB = "db_areaquesttracking.db";

		// Token: 0x040004B5 RID: 1205
		private const string FILE = "UniverseEditor/AreaQuestTracking.csv";

		// Token: 0x040004B6 RID: 1206
		private const string TABLE = "AreaQuestTracking";

		// Token: 0x040004B7 RID: 1207
		private const string COMMAND = "select BinData from `AreaQuestTracking` where Id=?";

		// Token: 0x040004B8 RID: 1208
		private const string KEY_PREFIX = "AreaQuestTrackingById";

		// Token: 0x040004B9 RID: 1209
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004BA RID: 1210
		private static int HandleId;
	}
}
