using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081A RID: 2074
	public class ConfigRoadZoneConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030AE RID: 12462 RVA: 0x0016C71F File Offset: 0x0016A91F
		static ConfigRoadZoneConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadZoneConfigByMapId.CreateStaticDefaultValue), new Action(ConfigRoadZoneConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x0016C740 File Offset: 0x0016A940
		public static void CreateStaticDefaultValue()
		{
			ConfigRoadZoneConfigByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoadZoneConfigByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roadzoneconfig.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/LevelPlay/RoadZoneConfig.csv"),
				new ValueTuple<string, object>("表名", "RoadZoneConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoadZoneConfig` where MapId=?")
			});
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0016C7BF File Offset: 0x0016A9BF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadZoneConfigByMapId.LogPair = null;
			ConfigRoadZoneConfigByMapId.HandleId = 0;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0016C7CD File Offset: 0x0016A9CD
		public static void Init()
		{
			ConfigRoadZoneConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadZoneConfigByMapId.HandleId, "db_roadzoneconfig.db", "select BinData from `RoadZoneConfig` where MapId=?");
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0016C7E8 File Offset: 0x0016A9E8
		public static RoadZoneConfig? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoadZoneConfigByMapId.HandleId, ConfigRoadZoneConfigByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadZoneConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoadZoneConfig?(RoadZoneConfig.GetRootAsRoadZoneConfig(configBuffer));
				}
			}
			ConfigRoadZoneConfigByMapId.LogPair.Clear();
			ConfigRoadZoneConfigByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigRoadZoneConfigByMapId.HandleId, 1, p0MapId, ConfigRoadZoneConfigByMapId.LogPair) || ConfigCommon.Step(ConfigRoadZoneConfigByMapId.HandleId, true, ConfigRoadZoneConfigByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoadZoneConfigByMapId.HandleId, ConfigRoadZoneConfigByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoadZoneConfigByMapId.HandleId, 0, ConfigRoadZoneConfigByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoadZoneConfigByMapId.HandleId, ConfigRoadZoneConfigByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoadZoneConfig rootAsRoadZoneConfig = RoadZoneConfig.GetRootAsRoadZoneConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoadZoneConfigByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoadZoneConfigByMapId.HandleId, ConfigRoadZoneConfigByMapId.LogPair);
			return new RoadZoneConfig?(rootAsRoadZoneConfig);
		}

		// Token: 0x0400389C RID: 14492
		private const string DB = "db_roadzoneconfig.db";

		// Token: 0x0400389D RID: 14493
		private const string FILE = "UniverseEditor/LevelPlay/RoadZoneConfig.csv";

		// Token: 0x0400389E RID: 14494
		private const string TABLE = "RoadZoneConfig";

		// Token: 0x0400389F RID: 14495
		private const string COMMAND = "select BinData from `RoadZoneConfig` where MapId=?";

		// Token: 0x040038A0 RID: 14496
		private const string KEY_PREFIX = "RoadZoneConfigByMapId";

		// Token: 0x040038A1 RID: 14497
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038A2 RID: 14498
		private static int HandleId;
	}
}
