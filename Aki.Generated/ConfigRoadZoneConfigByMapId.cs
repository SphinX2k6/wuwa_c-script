using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000836 RID: 2102
	public class ConfigRoadZoneConfigByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003156 RID: 12630 RVA: 0x00173A07 File Offset: 0x00171C07
		static ConfigRoadZoneConfigByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoadZoneConfigByMapId.CreateStaticDefaultValue), new Action(ConfigRoadZoneConfigByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06003157 RID: 12631 RVA: 0x00173A28 File Offset: 0x00171C28
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

		// Token: 0x06003158 RID: 12632 RVA: 0x00173AA7 File Offset: 0x00171CA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoadZoneConfigByMapId.LogPair = null;
			ConfigRoadZoneConfigByMapId.HandleId = 0;
		}

		// Token: 0x06003159 RID: 12633 RVA: 0x00173AB5 File Offset: 0x00171CB5
		public static void Init()
		{
			ConfigRoadZoneConfigByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigRoadZoneConfigByMapId.HandleId, "db_roadzoneconfig.db", "select BinData from `RoadZoneConfig` where MapId=?");
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00173AD0 File Offset: 0x00171CD0
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

		// Token: 0x04003960 RID: 14688
		private const string DB = "db_roadzoneconfig.db";

		// Token: 0x04003961 RID: 14689
		private const string FILE = "UniverseEditor/LevelPlay/RoadZoneConfig.csv";

		// Token: 0x04003962 RID: 14690
		private const string TABLE = "RoadZoneConfig";

		// Token: 0x04003963 RID: 14691
		private const string COMMAND = "select BinData from `RoadZoneConfig` where MapId=?";

		// Token: 0x04003964 RID: 14692
		private const string KEY_PREFIX = "RoadZoneConfigByMapId";

		// Token: 0x04003965 RID: 14693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003966 RID: 14694
		private static int HandleId;
	}
}
