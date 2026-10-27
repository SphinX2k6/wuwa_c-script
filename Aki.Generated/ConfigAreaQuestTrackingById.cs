using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A8 RID: 168
	public class ConfigAreaQuestTrackingById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x0006FF24 File Offset: 0x0006E124
		static ConfigAreaQuestTrackingById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaQuestTrackingById.CreateStaticDefaultValue), new Action(ConfigAreaQuestTrackingById.ResetStaticDefaultValue));
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0006FF44 File Offset: 0x0006E144
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x0006FFC3 File Offset: 0x0006E1C3
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaQuestTrackingById.LogPair = null;
			ConfigAreaQuestTrackingById.HandleId = 0;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0006FFD1 File Offset: 0x0006E1D1
		public static void Init()
		{
			ConfigAreaQuestTrackingById.HandleId = ConfigCommon.InitDataStatement(ConfigAreaQuestTrackingById.HandleId, "db_areaquesttracking.db", "select BinData from `AreaQuestTracking` where Id=?");
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0006FFEC File Offset: 0x0006E1EC
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

		// Token: 0x0400047C RID: 1148
		private const string DB = "db_areaquesttracking.db";

		// Token: 0x0400047D RID: 1149
		private const string FILE = "UniverseEditor/AreaQuestTracking.csv";

		// Token: 0x0400047E RID: 1150
		private const string TABLE = "AreaQuestTracking";

		// Token: 0x0400047F RID: 1151
		private const string COMMAND = "select BinData from `AreaQuestTracking` where Id=?";

		// Token: 0x04000480 RID: 1152
		private const string KEY_PREFIX = "AreaQuestTrackingById";

		// Token: 0x04000481 RID: 1153
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000482 RID: 1154
		private static int HandleId;
	}
}
